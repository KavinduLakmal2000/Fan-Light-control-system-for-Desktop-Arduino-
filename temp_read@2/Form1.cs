using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenHardwareMonitor.Hardware;
using System.IO.Ports;
using System.Threading;

namespace temp_read_2
{

    
    public partial class Form1 : Form
    {

        int i = 0;
        int butCount = 0;
        int butCount1 = 0;
        int butCount2 = 0;

        static float cpuTemp;
        static float gpuTemp;


        static Computer c = new Computer()
        {
            GPUEnabled = true,
            CPUEnabled = true,
            //RAMEnabled = true, // uncomment for RAM reports
            MainboardEnabled = true, // uncomment for Motherboard reports
            //FanControllerEnabled = true, // uncomment for FAN Reports
            //HDDEnabled = true, // uncomment for HDD Report
        };

        static void ReportSystemInfo()
        {
            foreach (var hardware in c.Hardware)
            {

                if (hardware.HardwareType == HardwareType.CPU)
                {
                    // only fire the update when found
                    hardware.Update();

                    // loop through the data
                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("CPU Core"))
                        {
                            // store
                            cpuTemp = sensor.Value.GetValueOrDefault();
                            // print to console
                            System.Diagnostics.Debug.WriteLine("cpuTemp: " + sensor.Value.GetValueOrDefault());

                        }
                       
                }


                // Targets AMD & Nvidia GPUS
                if (hardware.HardwareType == HardwareType.GpuAti || hardware.HardwareType == HardwareType.GpuNvidia)
                {
                    // only fire the update when found
                    hardware.Update();

                    // loop through the data
                    foreach (var sensor in hardware.Sensors)
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name.Contains("GPU Core"))
                        {
                            // store
                            gpuTemp = sensor.Value.GetValueOrDefault();
                            // print to console
                            System.Diagnostics.Debug.WriteLine("gpuTemp: " + sensor.Value.GetValueOrDefault());
                        }
                        

                }


            }
        }
        

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e) // ================================================= LOOP 
        {
            
            i++;
            if (i == 1000)
            {
                i = 0;
            }
            c.Open();            
            ReportSystemInfo();
          

            cou.Text = i.ToString();
            outCpu.Text = cpuTemp.ToString();
            outGpu.Text = gpuTemp.ToString();

           

           

            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(cpuTemp.ToString());
                }
            }
            catch (Exception ex)
            {
                error_show.Text = ex.Message;
            }

            try
            {
                if (serialPort1.IsOpen)
                {
                    ex_rpm.Text = serialPort1.ReadExisting();
                }

                else
                {
                    ex_rpm.Text = "0";
                }

            }
            catch (Exception ex)
            {
                error_show.Text = ex.Message;
            }

        }


        private void Form1_Load(object sender, EventArgs e) // ================================ void setup
        {
            timer1.Stop();
            String[] ports = SerialPort.GetPortNames();
            Cports.Items.AddRange(ports);
            Cports.SelectedIndex = 0;
        }


       

        private void button1_Click(object sender, EventArgs e) //==================================== connect
        {
            try
            {
                serialPort1.PortName = Cports.Text;
                serialPort1.BaudRate = int.Parse(boxRate.Text);

                serialPort1.Open();
               
                    timer1.Start();
                    
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            } 

        }

        private void button2_Click(object sender, EventArgs e) // ======================================= disconnect
        {
            serialPort1.Close();
            timer1.Stop();
           
            i = 0;
        }

        private void button6_Click(object sender, EventArgs e) //============================= standby 
        {

            butCount++;
            timer1.Stop();

            if (butCount == 1)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine("115");
                        Standby_s.Text = "ON";
                        timer1.Stop();
                       
                        i = 0;
                    }

                    else
                    {
                        Standby_s.Text = "OFF";
                    }
                }
                catch (Exception ex)
                {
                    error_show.Text = ex.Message;
                }
            }

            else if (butCount == 2)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine("106");
                        Standby_s.Text = "OFF";
                        timer1.Start();
                        
                    }

                    else
                    {
                        Standby_s.Text = "ON";
                    }
                }
                catch (Exception ex)
                {
                    error_show.Text = ex.Message;
                }
                butCount = 0;
            }
            Thread.Sleep(5000);
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e) // ======================================== Lights
        {
            timer1.Stop();
            butCount1++;

            if (butCount1 == 1)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine("108");
                        Lights_s.Text = "OFF";
                    }

                    else
                    {
                        Lights_s.Text = "ON";
                    }
                }
                catch (Exception ex)
                {
                    error_show.Text = ex.Message;
                }
            }

            else if (butCount1 == 2)
            {
                try
                {         
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.Write("103"); ;
                        Lights_s.Text = "ON";
                    }

                    else
                    {
                        Lights_s.Text = "OFF";
                    }
                }
                catch (Exception ex)
                {
                    error_show.Text = ex.Message;
                }
                butCount1 = 0;
            }
            Thread.Sleep(5000);
            timer1.Start();
        }

        private void button7_Click(object sender, EventArgs e) // =================================================== max speed
        {
            butCount2++;
            timer1.Stop();

            if (butCount2 == 1)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine("104");
                        speed_s.Text = "ON";
                    }

                    else
                    {
                        speed_s.Text = "OFF";
                    }
                }
                catch (Exception ex)
                {
                    error_show.Text = ex.Message;
                }
            }

            else if (butCount2 == 2)
            {
                try
                {
                    if (serialPort1.IsOpen)
                    {
                        serialPort1.WriteLine("109");
                        speed_s.Text = "OFF";
                    }

                    else
                    {
                        speed_s.Text = "ON";
                    }
                }
                catch (Exception ex)
                {
                    error_show.Text = ex.Message;
                }
                butCount2 = 0;
            }
            Thread.Sleep(5000);
            timer1.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
            }
        }
    }
}

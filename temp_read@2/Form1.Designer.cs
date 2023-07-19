namespace temp_read_2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.outCpu = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.cou = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.outGpu = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.label1 = new System.Windows.Forms.Label();
            this.boxRate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.Cports = new System.Windows.Forms.ComboBox();
            this.bunifuSwitch1 = new Bunifu.Framework.UI.BunifuSwitch();
            this.button6 = new System.Windows.Forms.Button();
            this.lights = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.con = new System.Windows.Forms.GroupBox();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ex_rpm = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.speed_s = new System.Windows.Forms.Label();
            this.Lights_s = new System.Windows.Forms.Label();
            this.Standby_s = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.error_show = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.con.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "CPU Temp :";
            // 
            // outCpu
            // 
            this.outCpu.AutoSize = true;
            this.outCpu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outCpu.Location = new System.Drawing.Point(159, 30);
            this.outCpu.Name = "outCpu";
            this.outCpu.Size = new System.Drawing.Size(21, 23);
            this.outCpu.TabIndex = 2;
            this.outCpu.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.label3.Location = new System.Drawing.Point(12, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Loop :";
            // 
            // cou
            // 
            this.cou.AutoSize = true;
            this.cou.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cou.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(186)))));
            this.cou.Location = new System.Drawing.Point(61, 9);
            this.cou.Name = "cou";
            this.cou.Size = new System.Drawing.Size(14, 16);
            this.cou.TabIndex = 4;
            this.cou.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 23);
            this.label4.TabIndex = 5;
            this.label4.Text = "GPU Temp :";
            // 
            // outGpu
            // 
            this.outGpu.AutoSize = true;
            this.outGpu.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outGpu.Location = new System.Drawing.Point(159, 75);
            this.outGpu.Name = "outGpu";
            this.outGpu.Size = new System.Drawing.Size(21, 23);
            this.outGpu.TabIndex = 6;
            this.outGpu.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 22);
            this.label1.TabIndex = 10;
            this.label1.Text = "COM Port :";
            // 
            // boxRate
            // 
            this.boxRate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.boxRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxRate.Location = new System.Drawing.Point(158, 104);
            this.boxRate.Name = "boxRate";
            this.boxRate.Size = new System.Drawing.Size(219, 27);
            this.boxRate.TabIndex = 11;
            this.boxRate.Text = "9600";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 22);
            this.label5.TabIndex = 12;
            this.label5.Text = "BaudRate :";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(23, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(234, 161);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 33);
            this.button2.TabIndex = 14;
            this.button2.Text = "Disconnect";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Cports
            // 
            this.Cports.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(238)))), ((int)(((byte)(255)))));
            this.Cports.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cports.ForeColor = System.Drawing.Color.Black;
            this.Cports.FormattingEnabled = true;
            this.Cports.Location = new System.Drawing.Point(158, 43);
            this.Cports.Name = "Cports";
            this.Cports.Size = new System.Drawing.Size(219, 28);
            this.Cports.TabIndex = 19;
            this.Cports.Text = "COM1";
            // 
            // bunifuSwitch1
            // 
            this.bunifuSwitch1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuSwitch1.BorderRadius = 0;
            this.bunifuSwitch1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuSwitch1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuSwitch1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Location = new System.Drawing.Point(1531, 1028);
            this.bunifuSwitch1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.bunifuSwitch1.Name = "bunifuSwitch1";
            this.bunifuSwitch1.Oncolor = System.Drawing.Color.SeaGreen;
            this.bunifuSwitch1.Onoffcolor = System.Drawing.Color.DarkGray;
            this.bunifuSwitch1.Size = new System.Drawing.Size(0, 0);
            this.bunifuSwitch1.TabIndex = 19;
            this.bunifuSwitch1.Textcolor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bunifuSwitch1.Value = true;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(21, 350);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(114, 41);
            this.button6.TabIndex = 20;
            this.button6.Text = "Stand by ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // lights
            // 
            this.lights.Location = new System.Drawing.Point(169, 350);
            this.lights.Name = "lights";
            this.lights.Size = new System.Drawing.Size(114, 41);
            this.lights.TabIndex = 21;
            this.lights.Text = "Lights";
            this.lights.UseVisualStyleBackColor = true;
            this.lights.Click += new System.EventHandler(this.button4_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(325, 350);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(114, 41);
            this.button7.TabIndex = 23;
            this.button7.Text = "Max Speed";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // con
            // 
            this.con.Controls.Add(this.Cports);
            this.con.Controls.Add(this.label1);
            this.con.Controls.Add(this.button2);
            this.con.Controls.Add(this.button1);
            this.con.Controls.Add(this.boxRate);
            this.con.Controls.Add(this.label5);
            this.con.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.con.Location = new System.Drawing.Point(21, 71);
            this.con.Name = "con";
            this.con.Size = new System.Drawing.Size(418, 234);
            this.con.TabIndex = 25;
            this.con.TabStop = false;
            this.con.Text = "Serial Connection";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.outCpu);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.outGpu);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.groupBox1.Location = new System.Drawing.Point(479, 71);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(246, 116);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Temperature";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ex_rpm);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.groupBox2.Location = new System.Drawing.Point(479, 193);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(246, 112);
            this.groupBox2.TabIndex = 27;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Fan RPM";
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(147, 70);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 29);
            this.label9.TabIndex = 9;
            this.label9.Text = "0000";
            // 
            // ex_rpm
            // 
            this.ex_rpm.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_rpm.Location = new System.Drawing.Point(147, 30);
            this.ex_rpm.Name = "ex_rpm";
            this.ex_rpm.Size = new System.Drawing.Size(77, 23);
            this.ex_rpm.TabIndex = 7;
            this.ex_rpm.Text = "0000";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 23);
            this.label7.TabIndex = 8;
            this.label7.Text = "Intake Fan :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 30);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 23);
            this.label6.TabIndex = 7;
            this.label6.Text = "Exhaust Fan :";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.speed_s);
            this.groupBox3.Controls.Add(this.Lights_s);
            this.groupBox3.Controls.Add(this.Standby_s);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.groupBox3.Location = new System.Drawing.Point(479, 311);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(246, 107);
            this.groupBox3.TabIndex = 28;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // speed_s
            // 
            this.speed_s.AutoSize = true;
            this.speed_s.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_s.Location = new System.Drawing.Point(143, 76);
            this.speed_s.Name = "speed_s";
            this.speed_s.Size = new System.Drawing.Size(44, 23);
            this.speed_s.TabIndex = 14;
            this.speed_s.Text = "OFF";
            // 
            // Lights_s
            // 
            this.Lights_s.AutoSize = true;
            this.Lights_s.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lights_s.Location = new System.Drawing.Point(143, 48);
            this.Lights_s.Name = "Lights_s";
            this.Lights_s.Size = new System.Drawing.Size(37, 23);
            this.Lights_s.TabIndex = 13;
            this.Lights_s.Text = "ON";
            // 
            // Standby_s
            // 
            this.Standby_s.AutoSize = true;
            this.Standby_s.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Standby_s.Location = new System.Drawing.Point(143, 21);
            this.Standby_s.Name = "Standby_s";
            this.Standby_s.Size = new System.Drawing.Size(44, 23);
            this.Standby_s.TabIndex = 7;
            this.Standby_s.Text = "OFF";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(6, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(123, 23);
            this.label12.TabIndex = 12;
            this.label12.Text = "Max Speed :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 48);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 23);
            this.label11.TabIndex = 11;
            this.label11.Text = "Lights :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(6, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(104, 23);
            this.label10.TabIndex = 10;
            this.label10.Text = "Stand by :";
            // 
            // error_show
            // 
            this.error_show.AutoSize = true;
            this.error_show.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.error_show.ForeColor = System.Drawing.Color.Red;
            this.error_show.Location = new System.Drawing.Point(18, 402);
            this.error_show.Name = "error_show";
            this.error_show.Size = new System.Drawing.Size(77, 20);
            this.error_show.TabIndex = 29;
            this.error_show.Text = "Message";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("TR2N", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(185)))), ((int)(((byte)(230)))));
            this.label17.Location = new System.Drawing.Point(187, 18);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(355, 35);
            this.label17.TabIndex = 30;
            this.label17.Text = "Smart Fans";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(746, 439);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.error_show);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.con);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.lights);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.bunifuSwitch1);
            this.Controls.Add(this.cou);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "abc";
            this.Text = "SMART FANS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.con.ResumeLayout(false);
            this.con.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label outCpu;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label cou;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label outGpu;
        private System.IO.Ports.SerialPort serialPort1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox boxRate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox Cports;
        private Bunifu.Framework.UI.BunifuSwitch bunifuSwitch1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button lights;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox con;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label ex_rpm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label speed_s;
        private System.Windows.Forms.Label Lights_s;
        private System.Windows.Forms.Label Standby_s;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label error_show;
        private System.Windows.Forms.Label label17;
    }
}


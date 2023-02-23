#include "FastLED.h"

#define NUM_LEDS 44 //60
CRGB leds[NUM_LEDS];
#define PIN 4

int temp;
const int exhaust_fan = 5;
const int intake_fan = 6;

int count1 = 0;
int count2 = 0;
int count3 = 0;
int count4 = 0;
unsigned long start_time;
int rpm_intake1;
int rpm_intake2;

int rpm_exhaust1;
int rpm_exhaust2;

void counter1(){
  count1++; 
}
void counter2(){
  count2++; 
}
void counter3(){
  count3++; 
}
void counter4(){
  count4++; 
}

int serialData;

boolean lights = true;
boolean standby = false;
boolean allMax = false;
boolean HighSpeed = false;

int SetFan1 = 0;
int SetFan2 = 0;

int LightColor = 0;

int HighSpeedCount = 0;
int C = 0;
///////////////////////////////////////////// ws2812 setup ///////////////////////////////////////
void setAll(byte red, byte green, byte blue) {
  for(int i = 0; i < NUM_LEDS; i++ ) {
    setPixel(i, red, green, blue);
  }
  showStrip();
}

void showStrip() {
 #ifdef ADAFRUIT_NEOPIXEL_H
   // NeoPixel
   strip.show();
 #endif
 #ifndef ADAFRUIT_NEOPIXEL_H
   // FastLED
   FastLED.show();
 #endif
}

void setPixel(int Pixel, byte red, byte green, byte blue) {
 #ifdef ADAFRUIT_NEOPIXEL_H
   // NeoPixel
   strip.setPixelColor(Pixel, strip.Color(red, green, blue));
 #endif
 #ifndef ADAFRUIT_NEOPIXEL_H
   // FastLED
   leds[Pixel].r = red;
   leds[Pixel].g = green;
   leds[Pixel].b = blue;
 #endif
}
///////////////////////////////////////////////////////////////////////////////////////////////////////

void setup()
{
  Serial.begin(9600);
  
  FastLED.addLeds<WS2811, PIN, GRB>(leds, NUM_LEDS).setCorrection( TypicalLEDStrip );

  attachInterrupt(digitalPinToInterrupt(2), counter1, RISING);
  attachInterrupt(digitalPinToInterrupt(3), counter2, RISING);

  attachInterrupt(digitalPinToInterrupt(8), counter3, RISING);
  attachInterrupt(digitalPinToInterrupt(9), counter4, RISING);
  
  pinMode(exhaust_fan, OUTPUT);
  pinMode(intake_fan, OUTPUT);
  
 digitalWrite(exhaust_fan, HIGH);
 digitalWrite(intake_fan, HIGH);
 
 CylonBounce(0xFF, 0xFF, 0x0, 2, 60, 70);
 colorFill(0xFF, 0xE4, 0xC4, 80);
 

 while(Out_FanRpm1() < 800 || Out_FanRpm1() > 2000){ // check ex1 fan
  Strobe(0xFF, 0x0, 0x0, 10, 50, 1000);
 }
 while(Out_FanRpm2() < 800 || Out_FanRpm2() > 2000){ // check ex2 fan
  Strobe(0xFF, 0x0, 0x0, 10, 50, 1000);
 }
 // ==================================================================unlock after all done==========================
 /*
 while(In_FanRpm1() < 800 || In_FanRpm1() > 2000){ // check in2 fan
  Strobe(0xFF, 0x0, 0x0, 10, 50, 1000);
 }
 while(In_FanRpm2() < 800 || In_FanRpm2() > 2000){ // check in2 fan
  Strobe(0xFF, 0x0, 0x0, 10, 50, 1000);
 }
 */
       
   colorFill(0x70, 0x80, 0x90, 80);
   
   digitalWrite(exhaust_fan, LOW);
   digitalWrite(intake_fan, LOW);
   
   colorFill(0x0, 0xFF, 0xFF, 80); 
   colorWipe(0x0, 0x0, 0x0, 50);

  while (!Serial){ // check connection
  FadeInOut(0xFF, 0xFF, 0xFF);
  analogWrite(exhaust_fan, 120);
  analogWrite(intake_fan, 120);
  digitalWrite(13,LOW);
  delay (100);
  digitalWrite(13,HIGH);
  delay(100);
}

  FastLED.clear();
  FastLED.show();
  
}


void loop() {

LIGHTS();
SdataRead();

digitalWrite(13,LOW);

   if (serialData == 115){ // s
    standby = true;
   }

   if(serialData == 108){ // l
    lights = false;
   }
   
   if(serialData == 103){ // g
    lights = true;
   }

//==============================All fans max speed===============================
if (serialData == 104){ // h
allMax = true;
}

while (allMax){
 SdataRead();
  
 digitalWrite(exhaust_fan, HIGH);
 digitalWrite(intake_fan, HIGH);



 if(serialData == 109){ //m
 digitalWrite(exhaust_fan, LOW);
 digitalWrite(intake_fan, LOW);
  allMax = false;
 }

    digitalWrite(13,HIGH);
    delay(500);
    digitalWrite(13,LOW);
    delay(100);
 meteorRain(0xFF, 0x0, 0x0,20, 80, false, 10);
}
//================================standby=============
   while(standby){
   SdataRead();
   FadeInOut(0xFF, 0xFF, 0xFF);
   if (serialData == 106){ // j
    standby = false;
   } 

    digitalWrite(13,HIGH);
    delay(500);
    digitalWrite(13,LOW);
    delay(100);
    
   }  
//=================================================== speed send 
  //Serial.println(In_FanRpm1());
  Serial.println(Out_FanRpm1());


if (serialData == 0){
  temp = 49;
}

else if (serialData < 100){
  temp = serialData;
}

SetFan1 = map (temp , 48 , 75 , 50 , 255); // zz , xx , xx , yy , yy (x are temp reange and y are fan speed)

SetFan2 = map (temp , 52 , 75 , 47 , 255);

LightColor = map(temp, 47, 75, 1, 4);


if (SetFan1 > 50){
  analogWrite(intake_fan, SetFan1);
}
else{
  digitalWrite(intake_fan, LOW);
}

if(SetFan2 > 50){
  analogWrite(exhaust_fan, SetFan2);
}
else{
   digitalWrite(exhaust_fan, LOW);
}
////////////////////////////////////////////////////////////auto high speed/////////////////////////////////////

// ====================================================================lights with temp ===============================================


digitalWrite(13,HIGH);
delay(200);


  FastLED.clear();
  FastLED.show();

  
} //============================================================ loop end

// ================================================================ lights call =================================================
void LIGHTS(){
if(lights){

if(LightColor == 1){
  meteorRain(0xFF, 0xFF, 0xFF,20, 80, false, 50); // white
}

else if (LightColor == 2){
  meteorRain(0x0, 0xFF, 0xFF,20, 80, false, 30); //aqua 
}

else if (LightColor == 3){ 
  meteorRain(0xFF, 0xD7, 0x0,20, 100, false, 20); //yellow
}

else if (LightColor == 4){
  meteorRain(0xFF, 0x0, 0x0,20, 80, false, 10); //red  
}

}

else {
  FastLED.clear();
  FastLED.show(); 
  delay(100);
}
}
// ================================================================ serial store ================================================
void SdataRead(){        
    if (Serial.available() > 0){
      serialData  = Serial.parseInt();  
 } 
}
//=======================================================fan RPM read=================================================================
void Millis(){
  start_time = millis();
  count1 = 0;
  count2 = 0;
  while((millis() - start_time) <1000){
    
  }
}

int In_FanRpm1(){
  Millis();
  rpm_intake1 = count3 * 60 / 2;
  return rpm_intake1;
}

int In_FanRpm2(){
  Millis();
  rpm_intake2 = count4 * 60 / 2;
  return rpm_intake2;
}

int Out_FanRpm2(){
  Millis();
  rpm_exhaust2 = count2 * 60 / 2;
  return rpm_exhaust2;
}

int Out_FanRpm1(){
  Millis();
  rpm_exhaust1 = count1 * 60 / 2;
  return rpm_exhaust1;
}

//=======================================================================================================

void CylonBounce(byte red, byte green, byte blue, int EyeSize, int SpeedDelay, int ReturnDelay){

  for(int i = 0; i < NUM_LEDS-EyeSize-2; i++) {
    setAll(0,0,0);
    setPixel(i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(i+j, red, green, blue);
    }
    setPixel(i+EyeSize+1, red/10, green/10, blue/10);
    showStrip();
    delay(SpeedDelay);
  }

  delay(ReturnDelay);

  for(int i = NUM_LEDS-EyeSize-2; i > 0; i--) {
    setAll(0,0,0);
    setPixel(i, red/10, green/10, blue/10);
    for(int j = 1; j <= EyeSize; j++) {
      setPixel(i+j, red, green, blue);
    }
    setPixel(i+EyeSize+1, red/10, green/10, blue/10);
    showStrip();
    delay(SpeedDelay);
  }
 
  delay(ReturnDelay);
}

//======================================================================================================================================
void FadeInOut(byte red, byte green, byte blue){
  float r, g, b;
     
  for(int k = 0; k < 256; k=k+1) {
    r = (k/256.0)*red;
    g = (k/256.0)*green;
    b = (k/256.0)*blue;
    setAll(r,g,b);
    showStrip();
  }
     
  for(int k = 255; k >= 0; k=k-2) {
    r = (k/256.0)*red;
    g = (k/256.0)*green;
    b = (k/256.0)*blue;
    setAll(r,g,b);
    showStrip();
  }
}



//=====================================================================================================================================
void meteorRain(byte red, byte green, byte blue, byte meteorSize, byte meteorTrailDecay, boolean meteorRandomDecay, int SpeedDelay) {  
  setAll(0,0,0);
 
  for(int i = 0; i < NUM_LEDS+NUM_LEDS; i++) {
   
    // fade brightness all LEDs one step
    for(int j=0; j<NUM_LEDS; j++) {
      if( (!meteorRandomDecay) || (random(10)>5) ) {
        fadeToBlack(j, meteorTrailDecay );        
      }
    }

    // draw meteor
    for(int j = 0; j < meteorSize; j++) {
      if( ( i-j <NUM_LEDS) && (i-j>=0) ) {
        setPixel(i-j, red, green, blue);
      }
    }
   
    showStrip();
    delay(SpeedDelay);
  }
}

void fadeToBlack(int ledNo, byte fadeValue) {
 #ifdef ADAFRUIT_NEOPIXEL_H
    // NeoPixel
    uint32_t oldColor;
    uint8_t r, g, b;
    int value;
   
    oldColor = strip.getPixelColor(ledNo);
    r = (oldColor & 0x00ff0000UL) >> 16;
    g = (oldColor & 0x0000ff00UL) >> 8;
    b = (oldColor & 0x000000ffUL);

    r=(r<=10)? 0 : (int) r-(r*fadeValue/256);
    g=(g<=10)? 0 : (int) g-(g*fadeValue/256);
    b=(b<=10)? 0 : (int) b-(b*fadeValue/256);

    strip.setPixelColor(ledNo, r,g,b);
    
 #endif
 #ifndef ADAFRUIT_NEOPIXEL_H
   // FastLED
   leds[ledNo].fadeToBlackBy( fadeValue );
 #endif  
 
}

//=====================================================================================================================
void colorFill(byte red, byte green, byte blue, int SpeedDelay) {
  for(uint16_t i=0; i<NUM_LEDS; i++) {
      setPixel(i, red, green, blue);
      showStrip();
      delay(SpeedDelay);
  }
}

void colorWipe(byte red, byte green, byte blue, int SpeedDelay) {
  for(uint16_t i=NUM_LEDS; i>0; i--) {
      setPixel(i, red, green, blue);
      showStrip();
      delay(SpeedDelay);
  }
}

//==========================================================================================================================
void Strobe(byte red, byte green, byte blue, int StrobeCount, int FlashDelay, int EndPause){
  for(int j = 0; j < StrobeCount; j++) {
    setAll(red,green,blue);
    showStrip();
    delay(FlashDelay);
    setAll(0,0,0);
    showStrip();
    delay(FlashDelay);
  }
 
 delay(EndPause);
}

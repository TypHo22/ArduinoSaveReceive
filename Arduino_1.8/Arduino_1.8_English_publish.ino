/************************************Arduino_Save_ReceiveMainProgram*********************************************************
 * Company: Fraunhofer IBP
 * Author: Andreas Bernatzky
 * Program: Arduino_Save_ReceiveMain1.8
 * Date: 10.10.17
 *+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+*
 * Acknowledgement: This work has benefitted from funding through the CleanSky2 Programme under Grant Agreement CS2-LPA-GAM-2016-2017-01. The authors are responsible for the content of this publication.
 *+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+**+*
 * Description:  Regulation/Control of the Fan test bench(please refer Bachelorthesis Andreas Bernatzky)
 *               This Prpogram works only properly with the es associated Graphical User Interface "ArduinoSaveReceive.exe".
 *               This program is able to control or regulate the fan test bench to a desired setpoint.
 *               Since the PID parameters have been determined for the system treated in the bachelor thesis, it is unlikely that these parameters will work for other systems as well.
 *               This requires a new system identification followed by a controller design, which is explained in the bachelor thesis.
 *               However, the controller parameters can theoretically also be determined empirically
 *               In contrast to the version 1.7 some new functions have come to it.
 *               Two outputs can now be controlled or regulated and a measuring schedule can be specified
 * 
 * Hardware:     The program Arduino Save Receive 1.8 was written and debugged for the Arduino UNO
 *               Since communication with the GUI works serial, it should work for any Arduino type that has at least one UART.
 *               But it was only tested with an Arduino Uno. 
 *               On Arduino models with more than one UART (like Arduino Mega) it is necessary that the Measuringvalues 
 *               are passed to the main UART (UART 0).            
 *               1 x Arduino UNO or Mega
 *               1 x USB Typ B Kabel
 *               1 x Sensordevice for the measurement of air velocity for the control-loop-feedback
 *               
 * Software:     The Arduino has to be flashed with this Program Arduino_Save_ReceiveMain1.8
 *               For an successfully communication with the program, you must have the program "ArduinoSaveReceive.exe" on your computer
 *               An operation can be found in the documentation of version 1.7 (please refer Bachelorthesis Andreas Bernatzky). Because of the slightly changes Version 1.8 should be self-explanatory.
 *               
 *               
 *               
 * Version: 1.8            
 * 
 * 
 * 
 * 
**************************************************************************************************************************/
/*/************************************PID_v1_OWN*********************************************************
 * 
 *The PID_v1_OWN.h library has been modified to work with Float instead of the double variable type. Otherwise, there are complications with the ToFloat () command.
 *The library PID_v1.h would expect a variable of type double.
 */


#include <PID_v1_OWN.h> // Library which includes the Regulationalgorithm
float dichte;
float pressure ;
float Setpoint_Flow, Input_Flow, Output_Flow;
float Setpoint_Temp, Input_Temp, Output_Temp;
float Setpoint_Flow1, Setpoint_Flow2, Setpoint_Flow3;
float Setpoint_Temp1, Setpoint_Temp2, Setpoint_Temp3;
int Timedistance1, Timedistance2, Timedistance3;
int Regulation; // Query for control or regulation
int Timedistances; // query for measurementschedule
int count = 0; // Timercounter is used for measurementschedule
int resettimer;

float Kp_Flow=0.0, Ki_Flow=0.0, Kd_Flow=0.0;  // Establishing the PID Values for the flow (Are passed through the GUI)
float Kp_Temp=0.0, Ki_Temp=0.0, Kd_Temp=0.0;  // Establishing the PID Values for the temperature regulation (Are passed through the GUI)
String inString = "";    // Empfangsstring

long previousTime = 0;
long interval = 1000; // Determining the measuring intervals 1000 corresponds to one measured value per second, 2500 would correspond to a reading of the measurement values every 2.5 seconds.
 
//Declaration of PID variables for flow and temperature regulation
PID myPID(&Input_Flow, &Output_Flow, &Setpoint_Flow, Kp_Flow, Ki_Flow, Kd_Flow, DIRECT);
PID myPID2(&Input_Temp, &Output_Temp, &Setpoint_Temp, Kp_Temp, Ki_Temp, Kd_Temp, DIRECT);


 /***********************************Setup Schleife***************************************************************************************
 * 
 * The setup loop is run once at the program start.
 * Defining the GPIO pins 
 * Input_Flow pins must be for analog signals of type Ax on the Arduino. Any PIN can be used for digital signals.
 * You should always save PIN 0 (RX), PIN1 (TX) and PIN 13 (LED connected in series on the Arduino)
 * 
*******************************************************************************************************************************************/ 
void setup() {
  
pinMode(5, OUTPUT); // Declaration of PIN 5 as output for fan
pinMode(6, OUTPUT);  // Declaration of PIN 6 as output for heater
pinMode(A0,INPUT);  // Declaraion of PIN A0= as Input for Input_Flow
pinMode(A1,INPUT); // Declaration of PIN A1= as Input for Input_Temp
myPID.SetMode(AUTOMATIC);
myPID2.SetMode(AUTOMATIC);


myPID.SetOutputLimits(0, 255); // maximum and minimum actuating signal for the fan 
myPID2.SetOutputLimits(0, 255); // maximum and minimum actuating signal for the fan 

Serial.begin(9600); // Initialising Serialcommunication at a BAUDrate of 9600 

 }


/***********************************Loop Schleife***************************************************************************************
 * 
 * The void-loop will run continuously and repetitively. When making changes, make sure that the program
 * is working sequential ( from top to bottom ). 
 * 
 * 
*******************************************************************************************************************************************/ 

  
 void loop() {

/***********************************Zustandsvariable speichern*****************************************************************************
 * 
 *The command Serial.readStringUntil(;) reads received Data until a ";" appeears as a seperator. The received value gets written into a string
 *The command toFloat() changes this string to a float type, this allows further calculations
 * 
 * At following order the values are received:
 * 
 * Kp_Flow;Ki_Flow;Kd_Flow;Setpoint_Flow;Kp_Temp;Ki_Temp;Kd_Temp;Setpoint_Temp;Regulationabfrage;Zeitabstandabfrage;Zeitabstand1;Zeitabstand2;Zeitabstand3;Setpoint_Flow1;Setpoint_Flow2;Setpoint_Flow3;Setpoint_Temp1;Setpoint_Temp2;Setpoint_Temp3;
 * 
 * The regulationquery commands if there is a control or an regulation required
 * The Timedistances commands if there is a measurement schedule or not
*******************************************************************************************************************************************/
  
    
    while (Serial.available() > 0) {
     int inChar = Serial.read();
     
     if (inChar != '\n') {

    Kp_Flow = Serial.readStringUntil(';').toFloat(); // Proportional Gain for Fan regulation
    Ki_Flow = Serial.readStringUntil(';').toFloat(); // Integral Gain for Fan regulation
    Kd_Flow = Serial.readStringUntil(';').toFloat(); // Derivative Gain for Fan regulation
    Setpoint_Flow = Serial.readStringUntil(';').toFloat(); // Setpoint for the fan regulation loop
    Kp_Temp = Serial.readStringUntil(';').toFloat(); // Proportional Gain for Heater regulation
    Ki_Temp = Serial.readStringUntil(';').toFloat(); // Integral Gain for Heater regulation
    Kd_Temp = Serial.readStringUntil(';').toFloat(); // Derivative Gain for Heater regulation
    Setpoint_Temp = Serial.readStringUntil(';').toFloat(); // Setpoint for the heater regulation loop
    Regulation = Serial.readStringUntil(';').toFloat(); // Query if there is a control or a regulation needed. If Regulation == 1 then regulation, else control
    Timedistances = Serial.readStringUntil(';').toFloat(); // Query if there is a measurement schedule needed
    Timedistance1 = Serial.readStringUntil(';').toFloat(); // schedule 1
    Timedistance2 = Serial.readStringUntil(';').toFloat(); // schedule 2
    Timedistance3 = Serial.readStringUntil(';').toFloat(); // schedule 3
    Setpoint_Flow1 = Serial.readStringUntil(';').toFloat(); // Setpoint fan for schedule 1
    Setpoint_Flow2 = Serial.readStringUntil(';').toFloat(); // Setpoint fan for schedule 2
    Setpoint_Flow3 = Serial.readStringUntil(';').toFloat(); // Setpoint fan for schedule 3
    Setpoint_Temp1 = Serial.readStringUntil(';').toFloat(); // Setpoint heater for schedule 1
    Setpoint_Temp2 = Serial.readStringUntil(';').toFloat(); // Setpoint heater for schedule 2
    Setpoint_Temp3 = Serial.readStringUntil(';').toFloat(); // Setpoint heater for schedule 3
    resettimer     = Serial.readStringUntil(';').toFloat(); // Is needed to reset the timer for the measurement schedule
    
    myPID.SetTunings(Kp_Flow,Ki_Flow,Kd_Flow); // Write the new Regulation parameters 
    myPID2.SetTunings(Kp_Temp,Ki_Temp,Kd_Temp); //  Write the new Regulation parameters
    
     }
 
     else {
     
    
    inString = ""; // if there aren't new measurement values received (highly unlikely because of measurement noise)
     }


     
   }

  
 /***********************************Sensor Feedback************************************************************************************
 This section is for the regulation feedback it also calculates the actual value which is send to the GUI 
 If you use different sensors you have to make changes in this section
 For example a Thermical anemometry sensor which can measure up to 20 m/s: Input_Flow= (analogRead(A0)/1023.0)*20.0*0.74    

*******************************************************************************************************************************************/ 
 int zaehl=0;      // counter for-loop
 int mwleng = 2;   // how often should be measured
 float adcAverage; // sums up the median values
 float adcVal;     // keeps the median values
 float adcValue;   // measures the actual value which is summed up
 
 float adcAverage1;
 float adcVal1;
 float adcValue1;
 


 for(zaehl=0; zaehl <mwleng; zaehl++){
   
   adcValue=analogRead(A0);
   adcValue1=analogRead(A1);
   
   adcAverage += adcValue;
   adcAverage1 +=adcValue1;

 }

adcVal = adcAverage/ mwleng;
adcVal1 = adcAverage1/mwleng;
//Input_Temp= (adcVal1 * (300/1023.0)-100.0); // PT100
Input_Temp= (adcVal1 * (125/1023.0)-40.0); //Anemometry
//********************************************For Thermical Anemometry***************************************************
Input_Flow=(adcVal/1023.0)*35.0;



//********************************************For differential pressure*********************************************************
 /*dichte = 93500/(287.058*(273.15+Input_Temp)); // Calculation of Airdensity
                                          // 287.058 specific Gasconstant for dry air
                                          // 93500 pa air pressure (pending on your region)
                                          
                                          
 pressure= (((adcVal)/1023.0)*200);
 Input_Flow = (sqrt((2*pressure)/dichte)*0.816); // Sensorsignal is my actual value for the regulation-loop-feedback
                                          // Input_Flow is my actual air velocity


 /***********************************Communication with the GUI*****************************************************************************
 * 
 *The GUI communicates with the Arduino via a serial interface (UART) which can be taken from the device manager of Windows
 *It is important, that there is  ";" as a separator between each variable passed to the GUI";" 
 *The if query serves to not have to slow down the code with a delay (time triggered measurement) A delay() would cause a complete "freeze" of the code
 *for a second.This would also cause an stop in the calculation of the PID-Algortihm.
 *The Regulation output is calculated with a sample Time of 100 ms (can be changed in the PID Libary 
 * 
*******************************************************************************************************************************************/
unsigned long currentTime = millis();

if (resettimer == 1) 
{
  count=0;
  resettimer=0;
}

if(currentTime - previousTime > interval) {
  previousTime = currentTime;

count++; 
 
 Serial.print(Input_Flow); //controlled variable
 Serial.print(";");   
 Serial.print(Setpoint_Flow); //set value
 Serial.print(";"); 
 Serial.print(Output_Flow); //Current PWM output signal 0-255
 Serial.print(";"); 
 Serial.print(Input_Temp); // controlled variable
 Serial.print(";"); 
 Serial.print(Setpoint_Temp); // set value
 Serial.print(";"); 
 Serial.print(Output_Temp); // Current PWM output signal 0-255
 Serial.print(";"); 
 Serial.print(count); // counter
 Serial.println(";");
 
}
 /***********************************Actual output*****************************************************************************
 * 
 * Here, the manipulated variable of the Arduino is recalculated with each loop loop pass
 *
*******************************************************************************************************************************************/  


 /***********************************Regulation in combination with measurement schedule*****************************************************************************
 * 
 * Here, a regulation is made on a measurement schedule. For example the User can comand a set value of 7 m/s between 0-400 seconds. After the 400 seconds a 
 * new given setpoint will automatically be taken for another time interval
*******************************************************************************************************************************************/  

if(Regulation == 1 && Timedistances == 1) {


if(count < Timedistance1){   // First time interval

  Setpoint_Flow = Setpoint_Flow1;
  Setpoint_Temp = Setpoint_Temp1;


  myPID.Compute();
  myPID2.Compute();
  analogWrite(5,Output_Flow);
  analogWrite(6,Output_Temp);
}

if(count < Timedistance2 && count > Timedistance1 ){ // second time interval

  Setpoint_Flow = Setpoint_Flow2;
  Setpoint_Temp = Setpoint_Temp2;


  myPID.Compute();
  myPID2.Compute();
  analogWrite(5,Output_Flow);
  analogWrite(6,Output_Temp);
}

if(count < Timedistance3 && count > Timedistance2){ // third time interval

  Setpoint_Flow = Setpoint_Flow3;
  Setpoint_Temp = Setpoint_Temp3;


  myPID.Compute();
  myPID2.Compute();
  analogWrite(5,Output_Flow);
  analogWrite(6,Output_Temp);
}

if(count > Timedistance3){

  Output_Flow = 0.00;
  Output_Temp = 0.00;

  analogWrite(5,Output_Flow);  // PWM Capable Pin
  analogWrite(6,Output_Temp); // PWM Capable Pin

}
}

 /***********************************Control in combination with a measurement schedule*****************************************************************************
 * 
 * Here, a control is made on a measurement schedule. For example the User can comand a output value of 0-255 digits for a give time by example 0-400 seconds. After the 400 seconds a 
 * new given output digit will automatically be taken for another time interval
*******************************************************************************************************************************************/  


if(Regulation == 0 && Timedistances == 1) {


if(count < Timedistance1){   // First time interval

  analogWrite(5,Setpoint_Flow1);
  analogWrite(6,Setpoint_Temp1);
  Output_Flow = Setpoint_Flow1;
  Output_Temp = Setpoint_Temp1;
}

if(count < Timedistance2 && count > Timedistance1 ){ // second time interval

  analogWrite(5,Setpoint_Flow2);
  analogWrite(6,Setpoint_Temp2);
  Output_Flow = Setpoint_Flow2;
  Output_Temp = Setpoint_Temp2;
  
}

if(count < Timedistance3 && count > Timedistance2){ // third time interval
  
  analogWrite(5,Setpoint_Flow3);
  analogWrite(6,Setpoint_Flow3);
  Output_Flow = Setpoint_Flow3;
  Output_Temp = Setpoint_Temp3;
  
}

if(count > Timedistance3){

  analogWrite(5,0);
  analogWrite(6,0); 
  Output_Flow = 0;
  Output_Temp = 0;

}
}


 /***********************************control without measurement schedule*****************************************************************************
 * 
 * In this section there is a control signal between 0-255 commanded which causes a voltage.
 *
*******************************************************************************************************************************************/  


if(Regulation==0 && Timedistances==0){

  analogWrite(5,Setpoint_Flow);
  analogWrite(6,Setpoint_Temp);
  Output_Flow = Setpoint_Flow;
  Output_Temp = Setpoint_Temp;

 
}

 /***********************************Regulation without measurement schedule*****************************************************************************
 * 
 * In this section there is a regulation setpoint commanded.
 *
*******************************************************************************************************************************************/  


if(Regulation==1 && Timedistances==0){

  myPID.Compute();
  myPID2.Compute();
  
  analogWrite(5,Output_Flow);
  analogWrite(6,Output_Temp);
}
}





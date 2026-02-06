#include <Servo.h>
#include<DHT.h>
#include <SoftwareSerial.h>
SoftwareSerial BT(10, 11); 

#define DHTPIN 8       
#define DHTTYPE DHT11 
DHT dht(DHTPIN, DHTTYPE);
Servo myservo;
Servo myservo2;

#include <LiquidCrystal_I2C.h>
const String correctPIN = "1234";
String enteredPIN = "";
int attempts = 0;
bool enteringpin = false;
 int pir1 = 13;
// int pir2 = 12;
// #define buzzer 12

#define PIR2 7
#define PIR3 12 
#define maximum 2
   //#define led1 3
#define CheckLed1 A3
#define CheckLed2 A2
int available=2;


// int led1 = 3;
int led2 = 2;

bool ledState2 = LOW;
bool lastButtonState2 = LOW;

// int switch1 = 7;
int switch2 =6;
//  int relayPin = 7;
int smokePin =9;
int redLight = 4;
int smokeSensor = A0;
int lightsensor = A1;

unsigned long previousMillis = 0;
const long blinkInterval = 500; 
bool redState = false;
LiquidCrystal_I2C lcd(0x27, 16, 2);
int smokeThreshold = 150;
int lightThreshold = 900;

void displaytemp();
void senseMotion();
void checkBT();
void resetPIN();
void validatePIN();
void OpenSpaces();
void  Garage();
void OpenGate();

void setup()
{
   pinMode(pir1, INPUT);
  // pinMode(pir2, INPUT);
  dht.begin();
  // pinMode(led1, OUTPUT);
  pinMode(led2, OUTPUT);
     myservo.attach(5);
   myservo.write(0);
//  pinMode(relayPin, OUTPUT);
  // pinMode(buzzer, OUTPUT);
  pinMode(redLight, OUTPUT);
  pinMode(smokeSensor, INPUT);
   
  // digitalWrite(led1, LOW);
  digitalWrite(led2, LOW);
  digitalWrite(redLight, HIGH);
  // digitalWrite(relayPin, LOW);
  
  lcd.init();
  lcd.backlight();
  lcd.setCursor(0, 0);
  // lcd.print("Welcome");

  BT.begin(9600); 
  resetPIN();
  Serial.begin(9600); // for testing

   pinMode(PIR2, INPUT);
  pinMode(PIR3, INPUT);
   myservo2.attach(3);
   myservo2.write(0);
     // pinMode(led1, OUTPUT);
  pinMode(CheckLed1, OUTPUT);
  pinMode(CheckLed2, OUTPUT);
      //digitalWrite(led1,LOW);
}

void loop()
{
  senseMotion();
   senseSmoke();
   if (!enteringpin) {   // only show temp when NOT typing PIN
    displaytemp();
    
  }

 checkBT();

  OpenSpaces();
  Garage();

}

// MOTION SENSING

void senseMotion() {
  int lightLevel = analogRead(lightsensor);
  bool isNight = lightLevel > lightThreshold;  
   Serial.println(lightLevel); 

  bool currentButtonState2 = digitalRead(switch2);

  if (currentButtonState2 == HIGH && lastButtonState2 == LOW) {
    ledState2 = !ledState2;  
  }
  lastButtonState2 = currentButtonState2;

  if (isNight || ledState2 || digitalRead(pir1)==LOW ) {
    digitalWrite(led2, HIGH);   
  } else {
    digitalWrite(led2, LOW);    
  }

//  if(digitalRead(pir1)==LOW){
//    digitalWrite(led2, HIGH);   
//    } else {
//      digitalWrite(led2, LOW);    
//    }

 }

 
  
  // if (digitalRead(switch2) == LOW || isNight) {
       

  //   digitalWrite(led2, HIGH);
  // }
  //  else {
  //   digitalWrite(led2, LOW);
  // }

// SMOKE SENSING
void senseSmoke()
{
  int gasValue = analogRead(smokeSensor);
    Serial.println(gasValue);
  if(gasValue > smokeThreshold)
  {
    //  digitalWrite(relayPin, LOW);
    //  digitalWrite(buzzer, HIGH);
    
    unsigned long currentMillis = millis();
    if(currentMillis - previousMillis >= blinkInterval)
    {
      previousMillis = currentMillis;
      redState = !redState;
      digitalWrite(redLight, redState);
    }
  }
  else if(gasValue < smokeThreshold)
  {
    //  digitalWrite(relayPin, HIGH);
    digitalWrite(redLight, LOW);
    //  digitalWrite(buzzer, LOW);
  }
  // Serial.println(gasValue); 
}
void displaytemp(){
   static unsigned long lastUpdate = 0;
  if (millis() - lastUpdate < 2000) return; 
  lastUpdate = millis();
  float h = dht.readHumidity();
  float t = dht.readTemperature();
  if (isnan(h)||isnan(t)){
    lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("DHT Error");
    return;
  }
  lcd.clear();
    lcd.setCursor(0,0);
    lcd.print("Temp: ");
    lcd.print(t);
    lcd.print("C ");


    lcd.setCursor(0,1);
    lcd.print("Humidity:");
    lcd.print(h);
    lcd.print("% ");

}

 void checkBT() {
  while (BT.available()) {
    char c = BT.read();

    if (!enteringpin) {
      enteringpin = true;      
      lcd.clear();
      lcd.print("Enter PIN:");
      lcd.setCursor(0, 1);
    }

    if (c == '*') {
      resetPIN();
      enteringpin = false;
    } else if (c >= '0' && c <= '9') {
      enteredPIN += c;

      lcd.setCursor(0, 1);
      lcd.print("                ");  // clear row
      lcd.setCursor(0, 1);
      for (int i = 0; i < enteredPIN.length(); i++) {
        lcd.print("*");
      }

      if (enteredPIN.length() == 4) validatePIN();
    }
  }
  }


void resetPIN() {
  enteredPIN = "";
  enteringpin = false;
  displaytemp();   
}


void validatePIN() {
  delay(300);
  if (enteredPIN == correctPIN) {
    lcd.clear();
    lcd.print("Welcome");
    myservo.write(180);
    BT.println("ACCESS GRANTED");
    unsigned long unlockTime = millis();
    while (millis() - unlockTime < 5000) {
  
  checkBT();
}
    myservo.write(0);
    attempts = 0;
  } else {
    attempts++;
    lcd.clear();
    lcd.print("Wrong PIN");
    BT.println("WRONG PIN");
    if (attempts == 3) {
      lcd.setCursor(0,1);
      lcd.print("ALARM TRIGGERED");
      BT.println("LOCKED OUT");
      // digitalWrite(relayPin, HIGH); 
      attempts = 0;
    }
  }
  delay(2000);
   resetPIN();
}


void OpenGate(){ 
   for(int i=0;i<=90;i+=5){
      myservo2.write(i);
        delay(20);
    }
      delay(1000);
      for(int i=90;i>=0;i-=5){
      myservo2.write(i);
        delay(20);
  } 
}

void OpenSpaces(){
  switch(available){
    case 2:
    digitalWrite(CheckLed1,HIGH);
    digitalWrite(CheckLed2,HIGH);
    break;
    case 1:
    digitalWrite(CheckLed1,HIGH);
    digitalWrite(CheckLed2,LOW);
    break;
    case 0:
    digitalWrite(CheckLed1,LOW);
    digitalWrite(CheckLed2,LOW);
    break;
 }
}


//  long lastEvent = 0;
//  long Time = 800; 
// void Garage() {
//   long now = millis();
 
//   if (now - lastEvent > Time) {
    
//     if ( digitalRead(PIR2) == LOW && available > 0) {
//       available--;
//       lastEvent = now;
      
//     }
    
//     else if (digitalRead(PIR3) == LOW && available < maximum) {
//       available++;
//       lastEvent = now;
     
       
 
//     }
//   }

// }









long lastEvent = 0;
 long Time = 800; 
void Garage() {
  long now = millis();
 
  if (now - lastEvent > Time) {
    
    if ( digitalRead(PIR2) == LOW && available > 0) {
      available--;
      lastEvent = now;                                       
      
   myservo2.write(180);  
   unsigned long unlockTime = millis();
//     while (millis() - unlockTime < 5000) { 
//  }       
delay(5000);   
  myservo2.write(0);     
    }
    else if (digitalRead(PIR3) == LOW && available < maximum) {
      available++;
      lastEvent = now;
      
         myservo2.write(180); 
        unsigned long unlockTime = millis();  
  //       while (millis() - unlockTime < 5000) {
  //  }       
  delay(5000);
   myservo2.write(0);     
 
    }
   }

}




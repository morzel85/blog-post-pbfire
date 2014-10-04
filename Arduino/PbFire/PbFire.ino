const byte fireRelayPin = 2;
const byte fireBuzzerPin = 11;
const byte fireLedPin = 12;
const byte readyLedPin = 13;

const byte readyToFireMessage = 6; // ASCII ACK
const byte fireCommand = 70; // ASCII F
const byte triggerPullDelayInMs = 30;
const byte fireBuzzerHz = 1000;
const byte readyBuzzerHz = 400;

void setup() {  
    pinMode(fireRelayPin, OUTPUT);
    pinMode(fireBuzzerPin, OUTPUT);
    pinMode(fireLedPin, OUTPUT);
    pinMode(readyLedPin, OUTPUT);
  
    Serial.begin(9600);
    
    tone(fireBuzzerPin, readyBuzzerHz);  
    digitalWrite(readyLedPin, HIGH); 

    Serial.write(readyToFireMessage);     
}

void loop() {
   if (Serial.available()) {
        byte data = Serial.read(); 
        
        if (data == fireCommand) {
            pullTrigger();
            delay(triggerPullDelayInMs);  
            releaseTrigger();
        }
    }  
}

void pullTrigger() {
    digitalWrite(fireLedPin, HIGH);    
    digitalWrite(fireRelayPin, HIGH);  
    tone(fireBuzzerPin, fireBuzzerHz);     
}

void releaseTrigger() {
    digitalWrite(fireLedPin, LOW);    
    digitalWrite(fireRelayPin, LOW);  
    tone(fireBuzzerPin, readyBuzzerHz);  

    Serial.write(readyToFireMessage);     
}


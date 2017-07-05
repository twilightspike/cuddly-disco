define led = 13;

void setup(){
  /*to initialize* the digital pin as an output*/
  pinMode(13, OUTPUT); /*Pin 13 has an LED connected*/
}

void loop(){
  digitalWrite(13, HIGH); /*set the LED on*/
  delay(750);
  digitalWrite(13, LOW); /*sest the LED off*/
  delay(1500); /*wait for 1.5 second*/
}

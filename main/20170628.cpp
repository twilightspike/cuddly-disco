int led1 = 13;
int led2 = 10;

void setup(){
  /*to initialize* the digital pin as an output*/
  pinMode(led1, OUTPUT); /*Pin 13 has an LED connected*/
  pinMode(led2, OUTPUT);
}

void loop(){
  digitalWrite(let1, HIGH); /*set the LED on*/
  digitalWrite(let2, LOW);
  delay(750);
  digitalWrite(let1, LOW); /*sest the LED off*/
  digitalWrite(let2, HIGH);
  delay(1500); /*wait for 1.5 second*/
}

const int trigPin1 = 2;
const int echoPin1 = 4;
const int trigPin2 = 7;
const int echoPin2 = 8;
// defines variables
long duration1;
int distance1;
long duration2;
int distance2;
int IRSensor = 12;  // connect ir sensor module to Arduino pin 9

int LED = 13;  // conect LED to Arduino pin 13
void setup() {
  pinMode(trigPin1, OUTPUT);         // Sets the trigPin as an Output
  pinMode(echoPin1, INPUT);          // Sets the echoPin as an Input
  pinMode(trigPin2, OUTPUT);         // Sets the trigPin as an Output
  pinMode(echoPin2, INPUT);          // Sets the echoPin as an Input
  Serial.begin(9600);                // Starts the serial communication
  Serial.println("Serial Working");  // Test to check if serial is working or not
  pinMode(IRSensor, INPUT);          // IR Sensor pin INPUT
  pinMode(LED, OUTPUT);              // LED Pin Output
}
void loop() {
  // Clears the trigPin
  delay(20);
  digitalWrite(trigPin1, LOW);
  // delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin1, HIGH);
  // delayMicroseconds(10);
  digitalWrite(trigPin1, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration1 = pulseIn(echoPin1, HIGH);
  // Calculating the distance
  distance1 = duration1 * 0.034 / 2;
  // Prints the distance on the Serial Monitor

  digitalWrite(trigPin2, LOW);
  // delayMicroseconds(2);
  // Sets the trigPin on HIGH state for 10 micro seconds
  digitalWrite(trigPin2, HIGH);
  // delayMicroseconds(10);
  digitalWrite(trigPin2, LOW);
  // Reads the echoPin, returns the sound wave travel time in microseconds
  duration2 = pulseIn(echoPin2, HIGH);
  // Calculating the distance
  distance2 = duration2 * 0.034 / 2;
  // Prints the distance on the Serial Monitor
  // Serial.print("Distance1: ");
  Serial.print(duration1);
  Serial.print(",");
  Serial.print(duration2);
  Serial.print(",");
  int sensorStatus = digitalRead(IRSensor);  // Set the GPIO as Input



  if (sensorStatus == 1)  // Check if the pin high or not

  {

    // if the pin is high turn off the onboard Led

    digitalWrite(LED, LOW);  // LED LOW
    Serial.print("1");
    // Serial.write(1);  // Unity will read this value
    // Serial.flush();
    // delay(20);  // print Motion Detected! on the serial monitor window

  }

  else

  {

    //else turn on the onboard LED

    digitalWrite(LED, HIGH);  // LED High
    Serial.print("0");
    // Serial.write(0);          // Unity will read this value
    // Serial.flush();
    // delay(20);
    //Serial.println("Motion Detected!");  // print Motion Ended! on the serial monitor window
  }
  Serial.println("");
}
int count,trig;
long adc_value,adc_value_last;
#define trig_pin 2

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(trig_pin,OUTPUT);
  pinMode(7,INPUT);
  pinMode(8,OUTPUT);
  pinMode(A0,INPUT);
  
  digitalWrite(7,1);
  digitalWrite(8,1);  
}

void loop() {
  count++;
  switch(count)
  {
    case 10:
      count=0;
//      Serial.println(analogRead(A0));
      adc_value=analogRead(A0);
      Serial.print(adc_value);
      Serial.print("   ");
      Serial.println(adc_value_last);
      delay(100);
      if(adc_value_last<30 && adc_value>=60)
      {        
        trig=1;
      }      
      adc_value_last=adc_value;
      
      switch(trig)
      {
        case 1:
          trig=0;
          Serial.print("HAHA   ");
          Serial.println(adc_value);
          digitalWrite(trig_pin,1);
          delay(10);
          digitalWrite(trig_pin,0);
        break;
      }
    break;
  }
  
// put your main code here, to run repeatedly:
//  digitalWrite(13,1);
//  delay(1000);
//  digitalWrite(13,0);
//  delay(1000);
 
}

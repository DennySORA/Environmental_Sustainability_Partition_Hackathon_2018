int count,trig;
long adc_value,adc_value_last;
#define trig_pin 2
#define bz 9

void setup() {
  // put your setup code here, to run once:
  Serial.begin(9600);

  pinMode(trig_pin,OUTPUT);
  pinMode(bz,OUTPUT);
  pinMode(7,INPUT);
  pinMode(8,OUTPUT);
  pinMode(A0,INPUT);
  pinMode(13,OUTPUT);
  
  digitalWrite(7,1);
  digitalWrite(8,1);
  digitalWrite(13,0);
  digitalWrite(trig_pin,0);  
}

void loop() {
  count++;
  switch(count)
  {
    case 10:
      count=0;
//      Serial.println(analogRead(A0));
      adc_value=analogRead(A0);
      
      delay(50);
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
          analogWrite(bz,100);
          digitalWrite(trig_pin,1);
          digitalWrite(13,1);
          delay(50);
          analogWrite(bz,0);
          digitalWrite(trig_pin,0);
          digitalWrite(13,0);
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

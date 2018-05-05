# -*- coding:utf-8 -*-


import time
import random
import socket
import RPi.GPIO as GPIO


def main():
    #------------------------------
    
    GPIO.setmode(GPIO.BCM)
    GPIO.setup(17, GPIO.OUT)
    GPIO.setup(27, GPIO.IN)
    HOST = "192.168.1.136"
    PORT = 5472
    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    
    #------------------------------
    
    s.bind((HOST, PORT))
    s.listen(5)
    print('Server start at: {0}:{1}'.format(HOST, PORT))
    print('wait for connection...')
    
    #------------------------------
    
    i = 0
    index = False
    conn, addr = s.accept()
    print('Connected by ', addr)
    
    #------------------------------
    try:
      while True:
          Data = GPIO.input(27)
          if Data == True and index == False:
              GPIO.output(17, 1)
              i += 1
              index = True
              conn.send(str("The time is "+str(i)).encode())
              print("Is send Data")
              time.sleep(0.5)
          elif Data == False and index == True:
              GPIO.output(17, 0)
              index = False
              time.sleep(0.5)
    except KeyboardInterrupt:
      pass
    conn.close()
    GPIO.cleanup()
    
    
    # -----------------------------
    # (setup)
    # GPIO.setup(17, GPIO.OUT)
    # GPIO.setup(27, GPIO.IN)
    # GPIO.setup(22, GPIO.OUT)
    # -----------------------------
    # i = 0
    # R = GPIO.PWM(27, 500)
    # G = GPIO.PWM(22, 500)
    # B = GPIO.PWM(17, 500)
    # R.start(0)
    # G.start(0)
    # B.start(0)
    # try:
    # while 1:
    #         R.ChangeDutyCycle(random.randint(0,99))
    #         G.ChangeDutyCycle(random.randint(0,99))
    #         B.ChangeDutyCycle(random.randint(0,99))
    #         time.sleep(0.5)
    #     # ----------------------------
    # except KeyboardInterrupt:
    #     print("?��???�╭")
    # R.stop()
    # G.stop()
    # B.stop()
    # GPIO.cleanup()

    # ================================


if __name__ == '__main__':
    main()

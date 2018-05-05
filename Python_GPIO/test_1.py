
# -*- coding:utf-8 -*-


import time
import random
import socket
import threading
import RPi.GPIO as GPIO

HOST = "192.168.1.136"
PORT = 5472
s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
s.setsockopt(socket.SOL_SOCKET,socket.SO_REUSEADDR,1) 
i = 0
index_T = {
    "1": False,
    "2": False
}


class Batch_Threading(threading.Thread):

    def __init__(self, ID):
        threading.Thread.__init__(self)
        self.ID = ID

    def run(self):
        while True:
            global i, s, index_T
            conn, addr = s.accept()
            print('Connected by ', addr)

            try:
                while True:
                    time.sleep(0.1)
                    if index_T[self.ID] == True:
                        index_T[self.ID] = False
                        conn.send(str(i).encode())
                        print("Is send Data", i, "\nThis is ID :", self.ID)
                        time.sleep(0.1)
            except:
                pass
            conn.close()


def main():
    global i, s, index_T
    # ------------------------------

    GPIO.setmode(GPIO.BCM)
    GPIO.setup(17, GPIO.OUT)
    GPIO.setup(23, GPIO.OUT)
    GPIO.setup(24, GPIO.OUT)
    GPIO.setup(27, GPIO.IN)
    GPIO.setup(22, GPIO.IN)

    # ------------------------------

    s.bind((HOST, PORT))
    s.listen(5)
    print('Server start at: {0}:{1}'.format(HOST, PORT))
    print('wait for connection...')

    # ------------------------------

    R = GPIO.PWM(24, 500)
    B = GPIO.PWM(17, 500)
    G = GPIO.PWM(23, 500)
    R.start(100)
    B.start(0)
    G.start(50)
    T1 = Batch_Threading('1')
    T2 = Batch_Threading('2')
    T1.start()
    T2.start()
    index = False

    # ------------------------------
    try:
        while True:
            Data = GPIO.input(27)
            if GPIO.input(22) == True and i != 0:
                index_T['1'] = True
                index_T['2'] = True
                time.sleep(0.2)
                i = 0
                time.sleep(0.1)
            if Data == True and index == False:
                GPIO.output(17, 1)
                i += 1
                index = True
                print("Now is ", i)
                R.ChangeDutyCycle(0)
                G.ChangeDutyCycle(0)
                B.ChangeDutyCycle(100)
                time.sleep(0.2)
            elif Data == False and index == True:
                GPIO.output(17, 0)
                index = False
                time.sleep(0.2)
            # -------------------
            R.ChangeDutyCycle(100)
            G.ChangeDutyCycle(50)
            B.ChangeDutyCycle(0)
            # -------------------
    except KeyboardInterrupt:
        pass
    
    GPIO.cleanup()

    # -----------------------------
    # (setup)
    # GPIO.setup(17, GPIO.OUT)
    # GPIO.setup(27, GPIO.IN)
    # GPIO.setup(22, GPIO.OUT)
    # -----------------------------
    # i = 0

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
    #     print("???????╭")
    # R.stop()
    # G.stop()
    # B.stop()
    # GPIO.cleanup()

    # ================================


if __name__ == '__main__':
    main()

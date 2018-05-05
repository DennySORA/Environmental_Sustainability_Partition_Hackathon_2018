# -*- coding:utf-8 -*-


import time
import random
import RPi.GPIO as GPIO


def main():
    GPIO.setmode(GPIO.BCM)

    # -----------------------------
    # (setup)
    GPIO.setup(17, GPIO.OUT)
    GPIO.setup(27, GPIO.OUT)
    GPIO.setup(22, GPIO.OUT)
    # -----------------------------
    i = 0
    R = GPIO.PWM(27, 500)
    G = GPIO.PWM(22, 500)
    B = GPIO.PWM(17, 500)
    R.start(0)
    G.start(0)
    B.start(0)
    try:
        while 1:
            R.ChangeDutyCycle(random.randint(0,99))
            G.ChangeDutyCycle(random.randint(0,99))
            B.ChangeDutyCycle(random.randint(0,99))
            time.sleep(0.5)       
        # ----------------------------
    except KeyboardInterrupt:
        print("以停止~")
    R.stop()
    G.stop()
    B.stop()
    GPIO.cleanup()

# ================================


if __name__ == '__main__':
    main()

# -*- coding:utf-8 -*-


import time
import socket


def main():
    HOST = '192.168.1.3'
    PORT = 1476

    c = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    c.connect((HOST, PORT))


    try:
        while True:
            GoodsList = c.recv(1024).decode()
            print(GoodsList)
            c.send("1")
            MemberList = c.recv(1024).decode()
            print(MemberList)
            c.send("1")
            time.sleep(600)
            c.send("Q")
    except:
        pass
    c.close()

# ================================


if __name__ == '__main__':
    main()

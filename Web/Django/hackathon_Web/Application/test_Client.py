# -*- coding:utf-8 -*-


import time
import socket


def main():
    HOST = '192.168.1.100'
    PORT = 1476

    c = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    c.connect((HOST, PORT))

    while True:
        GoodsList = c.recv(1024).decode()
        print(GoodsList)
        c.send("1".encode())

        MemberList = c.recv(1024).decode()
        print(MemberList)
        c.send("1".encode())

        Data = open("Data.json", "w", encoding='utf-8')
        Data.write("["+GoodsList + "," + MemberList+"]")
        Data.close()

        time.sleep(60)
        c.send("Q".encode())
    c.close()

# ================================


if __name__ == '__main__':
    main()

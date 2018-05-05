# -*- coding:utf-8 -*-


import time
import socket


def main():
    HOST = '192.168.1.136'
    PORT = 5472

    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.connect((HOST, PORT))

    while True:
        data = s.recv(1024)
        if len(data) != 0:
            print(data)


# ================================


if __name__ == '__main__':
    main()

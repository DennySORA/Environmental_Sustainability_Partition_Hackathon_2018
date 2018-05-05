# -*- coding:utf-8 -*-


import time
import socket


def main():
    HOST = '192.168.1.136'
    PORT = 5472

    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind((HOST, PORT))
    s.listen(5)

    print('Server start at: {0}:{1}'.format(HOST, PORT))
    print('wait for connection...')

    try:
        while True:
            conn, addr = s.accept()
            print('Connected by ', addr)
            while True:
                data = conn.recv(1024)
                print(data.decode("utf-8"))
                conn.send("server received you message.".encode())
    except:
        print("close server")
    conn.close()

# ================================


if __name__ == '__main__':
    main()

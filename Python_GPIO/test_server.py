# -*- coding:utf-8 -*-


import time
import socket


def main():
    HOST = ''
    PORT = 1476

    s = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
    s.bind((HOST, PORT))
    s.listen(5)

    print('Server start at: {0}:{1}'.format(HOST, PORT))
    print('wait for connection...')
    
    conn, addr = s.accept() 

    while True:
        
        print('Connected by ', addr)

        List_Data1 = open("GoodsList.txt", "r", encoding='utf-8').read()
        conn.send(List_Data1.encode())
        if conn.recv(1024).decode() != "1":
            continue

        List_Data2 = open("MemberList.txt", "r", encoding='utf-8').read()
        conn.send(List_Data2.encode())
        if conn.recv(1024).decode() != "1":
            continue
        
        if conn.recv(1024) == "Q":
            pass

    print("close server")
    conn.close()

# ================================


if __name__ == '__main__':
    main()

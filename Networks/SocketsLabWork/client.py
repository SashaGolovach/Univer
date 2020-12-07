import os
import socket
import subprocess
import sys

def send_commands(conn):
    while True:
        cmd = input()
        if cmd == 'quit':
            conn.close()
            sys.exit()
        if len(str.encode(cmd)) > 0:
            conn.send(str.encode(cmd))
            response = str(conn.recv(1024), "utf-8")
            print(response, end="")

rhost, rport = '127.0.0.1', 1234
conn = socket.socket()
conn.connect((rhost, rport))
print('Connected to server {}:{}'.format(rhost, rport))
send_commands(conn)
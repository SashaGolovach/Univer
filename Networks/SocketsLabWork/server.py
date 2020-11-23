import socket
import select

IP = "127.0.0.1"
PORT = 1234
METADATA_LENGTH = 10
server_socket = socket.socket(socket.AF_INET, socket.SOCK_STREAM)
server_socket.setsockopt(socket.SOL_SOCKET, socket.SO_REUSEADDR, 1)
server_socket.bind((IP, PORT))

server_socket.listen()
sockets_list = [server_socket]
clients = {}

print(f'Listening for connections on {IP}:{PORT}...')

def receive_message(client_socket):
    try:
        metadata = client_socket.recv(METADATA_LENGTH)
        if not len(metadata):
            return False
        message_length = int(metadata.decode('utf-8').strip())
        return {'username': metadata, 'data': client_socket.recv(message_length)}
    except:
        return False

while True:
    read_sockets, _, exception_sockets = select.select(sockets_list, [], sockets_list)
    for notified_socket in read_sockets:
        if notified_socket == server_socket:
            client_socket, client_address = server_socket.accept()
            user = receive_message(client_socket)
            if user is False:
                continue
            sockets_list.append(client_socket)
            clients[client_socket] = user
            print('New connection from {}:{}, username: {}'.format(*client_address, user['data'].decode('utf-8')))
        else:
            message = receive_message(notified_socket)
            if message is False:
                print('Connection closed: {}'.format(clients[notified_socket]['data'].decode('utf-8')))
                sockets_list.remove(notified_socket)
                del clients[notified_socket]
                continue
            user = clients[notified_socket]
            print(f'Received message from {user["data"].decode("utf-8")}: {message["data"].decode("utf-8")}')
            for client_socket in clients:
                if client_socket != notified_socket:
                    client_socket.send(user['username'] + user['data'] + message['username'] + message['data'])
    for notified_socket in exception_sockets:
        sockets_list.remove(notified_socket)
        del clients[notified_socket]
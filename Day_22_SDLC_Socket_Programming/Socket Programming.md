# Socket Programming

Socket programming is a key technique used for enabling communication between processes over a network. Here’s a brief overview of the concepts involved:

### Key Concepts of Socket Programming

1. **Sockets**: A socket is an abstraction that allows applications to communicate with each other over a network. It serves as an endpoint for sending or receiving data.

2. **Types of Sockets**:
   - **Stream Sockets (TCP)**: Used for reliable, connection-oriented communication. They ensure that data is delivered in the order it was sent.
   - **Datagram Sockets (UDP)**: Used for connectionless communication, which does not guarantee the order or reliability of data delivery. It’s faster but less reliable than TCP.

3. **Client-Server Model**:
   - **Server**: Waits for incoming connections, binds to a specific port, and processes requests from clients.
   - **Client**: Connects to the server, sends requests, and waits for responses.

4. **Socket Lifecycle**:
   - **Creation**: Initiating a socket using a system call.
   - **Binding**: Associating a socket with a local address and port.
   - **Listening**: Waiting for incoming connections.
   - **Accepting Connections**: Accepting a client connection.
   - **Data Transmission**: Sending and receiving data.
   - **Closing**: Terminating the connection when done.

5. **Error Handling**: Robust error handling is essential to manage potential issues during communication, such as connection failures or data transmission errors.

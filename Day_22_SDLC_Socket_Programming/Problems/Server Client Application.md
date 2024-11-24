# Server Client Application

#### Discussed about :

    Concepts of Client and Server Socket Programming.

---

#### Example Code :

```c#

// Server Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class Server
    {
        static void Main(string[] args)
        {
            var serverBuilder = new ServerBuilder();
            serverBuilder.Run();
        }
    }
}

```

```c#

// Server Builder Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class ServerBuilder
    {
        private string _ipAddress = "127.0.0.1";
        private int _port = 800;
        private TcpListener _listener;
        private Socket _socket;

        private void Buider()
        {
            var ip = IPAddress.Parse(_ipAddress);

            _listener = new TcpListener(ip, _port);
            _listener.Start();

            Console.WriteLine("Server started listening...");
        }

        public void Run()
        {
            Buider();

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected...");

            while (true)
            {
                var buffer = new byte[1024];
                var dataClient = _socket.Receive(buffer);
                var messageClient = Encoding.ASCII.GetString(buffer, 0, dataClient);
                Console.WriteLine($"Client : {messageClient}");

                if (messageClient == "exit")
                {
                    _socket.Close();
                    _listener.Stop();
                    break;
                }

                Console.WriteLine("Enter : ");
                string messageServer = Console.ReadLine();
                byte[] dataServer = Encoding.ASCII.GetBytes(messageServer);

                _socket.Send(dataServer);

                Console.WriteLine("Message sent...");

                if (messageServer == "exit")
                {
                    _socket.Close();
                    _listener.Stop();
                    break;
                }
            }
        }
    }
}

```

```c#

// Client Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Client
    {
        static void Main(string[] args)
        {
            var clientBuilder = new ClientBuilder();
            clientBuilder.Run();
        }
    }
}

```

```c#

// Client Builder Class

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class ClientBuilder
    {
        private string _ipAddress = "127.0.0.1";
        private int _port = 800;
        private TcpClient _client;

        private void Builder()
        {
            var _ip = IPAddress.Parse(_ipAddress);

            _client = new TcpClient();
            _client.Connect(_ip, _port);

            Console.WriteLine("Connected to server...");
        }
        public void Run()
        {
            Builder();

            while (true)
            {
                Console.WriteLine("Enter : ");
                string messageClient = Console.ReadLine();
                byte[] dataClient = Encoding.ASCII.GetBytes(messageClient);
                _client.GetStream().Write(dataClient, 0, dataClient.Length);

                Console.WriteLine("Message sent...");

                if (messageClient == "exit")
                {
                    _client.Close();
                    break;
                }

                var buffer = new byte[1024];
                var dataServer = _client.GetStream().Read(buffer, 0, buffer.Length);
                var messageServer = Encoding.ASCII.GetString(buffer, 0, dataServer);

                Console.WriteLine($"Server : {messageServer}");

                if (messageServer == "exit")
                {
                    _client.Close();
                    break;
                }
            }
        }
    }
}

```

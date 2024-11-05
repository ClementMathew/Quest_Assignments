using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_server
{

    internal class Echo_Server
    {
        static void Main(string[] args)
        {
            const string ipAddress = "127.0.0.1";
            const int port = 800;

            var server = new ServerBuilder(ipAddress, port);
            server.Run();
        }
    }
}




using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Echo_server
{
    public class ServerBuilder
    {
        private readonly string _ip;
        private readonly int _port;
        private Socket _socket;
        private TcpListener _listener;

        public ServerBuilder(string ipAddress, int port)
        {
            _ip = ipAddress;
            _port = port;
        }

        private void Builder()
        {
            _listener = new TcpListener(IPAddress.Parse(_ip), _port);

            _listener.Start();
            Console.WriteLine("Server started listening...");
        }

        public void Run()
        {
            Builder();

            _socket = _listener.AcceptSocket();
            Console.WriteLine("Client connected...");

            while (true)
            {
                byte[] bytes = new byte[1024];
                var dataClient = _socket.Receive(bytes);
                var messageClient = Encoding.ASCII.GetString(bytes, 0, dataClient);

                Console.WriteLine($"Client : {messageClient}");


                var messageServer = Encoding.ASCII.GetBytes(messageClient);
                _socket.Send(messageServer);

                Console.WriteLine("Message send....");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echo_Client
{

    internal class Echo_Client
    {
        static void Main(string[] args)
        {
            const string ipAddress = "127.0.0.1";
            const int port = 800;

            var client = new ClientBuilder(ipAddress, port);
            client.Run();
        }
    }
}


using System;
using System.Net.Sockets;
using System.Text;

namespace Echo_Client
{
    public class ClientBuilder
    {
        private readonly string _ip;
        private readonly int _port;
        private TcpClient _client;

        public ClientBuilder(string ipAddress, int port)
        {
            _ip = ipAddress;
            _port = port;
        }

        private void Builder()
        {
            _client = new TcpClient();

            _client.Connect(_ip, _port);
            Console.WriteLine("Connected to server...");
        }

        public void Run()
        {
            Builder();

            while (true)
            {
                Console.Write("Enter : ");
                var messageClient = Console.ReadLine();
                byte[] dataClient = Encoding.ASCII.GetBytes(messageClient);
                _client.GetStream().Write(dataClient, 0, dataClient.Length);

                Console.WriteLine("Message send...");

                byte[] bytes = new byte[1024];
                var dataServer = _client.GetStream().Read(bytes, 0, bytes.Length);
                var messageServer = Encoding.ASCII.GetString(bytes, 0, dataServer);

                Console.WriteLine($"Server : {messageServer}");
            }
        }
    }
}


// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Sockets;
using ChatServer;

class Program
{
     static void Main(string[] args)
    {
        Console.WriteLine("Starting Server..........");
        IPAddress ipAddress = IPAddress.Parse("127.0.0.1");
        TcpListener listener = new TcpListener(ipAddress, 5000);
        listener.Start();

        Console.WriteLine("Server started.........");

        while (true)
        {
            using TcpClient client = listener.AcceptTcpClient();
            ServerSocketHandler socketHandler = new ServerSocketHandler(client);
            Thread thread = new Thread(socketHandler.Run);
            thread.Start();
        }
    }
}
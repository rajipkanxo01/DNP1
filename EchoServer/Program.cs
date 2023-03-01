// See https://aka.ms/new-console-template for more information

using System.Net;
using System.Net.Sockets;
using System.Text;

namespace EchoServer;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Starting server..");

        // The IP address, the server should use, is specified. This example runs both client and server and localhost.
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        // This is the server socket, it is a class, which listens for incoming TCP connections.
        // first argument is the IP address. The second is the port number
        TcpListener listener = new TcpListener(ip, 5000);
        // ready for incoming requests
        listener.Start();

        Console.WriteLine("Server started..");

        // one client is accepted at a time
        while (true)
        {
            // When that client is handled, the method exits, goes back to the while-loop, and starts on the next client
            HandleOneClient(listener);
        }
    }

    private static void HandleOneClient(TcpListener listener)
    {
        // A new connection from a client is accepted. This results in a TcpClient object, which represents the
        // connection to the client. "using" keyword is used to make sure
        // the client is correctly disposed/closed, when the end of the current scope is reached
        using TcpClient client = listener.AcceptTcpClient();

        Console.WriteLine("Client connected");
        // NetworkStream is used for reading and writing to/from client.
        using NetworkStream stream = client.GetStream();


        while (true)
        {
            // read
            // data is sent as bytes. Initially, allocated 1024 bytes of space. If larger than 1024 send, nothing will be received.
            byte[] dataFromClient = new byte[1024];
            // reading data from the client. arguments: buffer array holding incoming data, which index to start inserting data,
            // length of buffer array
            int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
            // buffer array converted to string. arguments: buffer array containing data from client, which index to start inserting
            //data, how many bytes were read from the client, so that we do not convert empty cells to part of the result.
            string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
            Console.WriteLine(s);

            if (s.ToLower().Equals("exit"))
            {
                break;
            }

            // respond
            // respond to the client, by echoing back the data previously received
            byte[] dataToClient = Encoding.ASCII.GetBytes($"Returning {s}");
            // byte array is send to client. arguments: byte array with data, index of where to start in array, 
            // how many cells of the array to send, default to the array-length, i.e. we want the entire array sent
            stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}
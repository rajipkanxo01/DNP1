// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Text;

namespace EchoClient;

class Program
{
    static void Main(string[] args)
    {
        // We instantiate a new TcpClient, which makes a connection to a server located at the provided IP address and
        // port number, the two constructor arguments.  "using" keyword, so that the client object is
        // disposed when no longer used
        using TcpClient client = new TcpClient("127.0.0.1", 5000);

        // Obtaining the stream
        using NetworkStream stream = client.GetStream();
        string? input = "";

        while (true)
        {
            Console.WriteLine("\nInput message to send to server");
            input = Console.ReadLine();

            if (input.ToLower().Equals("exit"))
            {
                break;
            }

            // The message to be sent to the server, Hello from client, is converted to a byte array
            byte[] dataToServer = Encoding.ASCII.GetBytes(input);
            // The byte array is sent to the server
            stream.Write(dataToServer, 0, dataToServer.Length);

            // Identical to how the server side read from the client. Here we just read from the server instead
            byte[] dataFromServer = new byte[1024];
            int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
            Console.WriteLine(response);
        }
    }
}
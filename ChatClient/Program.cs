// See https://aka.ms/new-console-template for more information

using System.Net.Sockets;
using System.Text;

class Program
{
    public static void Main(string[] args)
    {
        using TcpClient client = new TcpClient("127.0.0.1", 5000);
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

            byte[] dataToServer = Encoding.ASCII.GetBytes(input);
            // The byte array is sent to the server
            stream.Write(dataToServer, 0, dataToServer.Length);

            byte[] dataFromServer = new byte[1024];
            int bytesRead = stream.Read(dataFromServer, 0, dataFromServer.Length);
            string response = Encoding.ASCII.GetString(dataFromServer, 0, bytesRead);
            Console.WriteLine(response);
        }
    }
}
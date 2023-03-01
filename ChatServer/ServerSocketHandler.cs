using System.Net.Sockets;
using System.Text;

namespace ChatServer;

public class ServerSocketHandler
{
    private TcpClient client;
    private NetworkStream stream;

    public ServerSocketHandler(TcpClient client)
    {
        this.client = client;
        stream = client.GetStream();
    }

    public void Run()
    {

        Console.WriteLine("Client Connected");
        while (true)
        {
            byte[] dataFromClient = new byte[1024];
            int bytesRead = stream.Read(dataFromClient, 0, dataFromClient.Length);
            string s = Encoding.ASCII.GetString(dataFromClient, 0, bytesRead);
            Console.WriteLine(s);

            if (s.ToLower().Equals("exit"))
            {
                break;
            }

            byte[] dataToClient = Encoding.ASCII.GetBytes("$Returning{s}");
            stream.Write(dataToClient, 0, dataToClient.Length);
        }
    }
}
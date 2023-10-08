using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace MonsterTradingCardsGame_2.Server
{
    internal class Control
    {
        public void ServerControl()
        {
            Console.WriteLine("Our first simple HTTP-Server! http://localhost:10001/");

            var httpServer = new TcpListener(IPAddress.Loopback, 10001);
            httpServer.Start();

            while (true)
            {
                var clientSocket = httpServer.AcceptTcpClient();
                using var writer = new StreamWriter(clientSocket.GetStream()) { AutoFlush = true };
                using var reader = new StreamReader(clientSocket.GetStream());

                //read the request
                string? line;
                bool isBody = false;
                int content_length = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    if (line == "")
                    {
                        isBody = true;
                        break;
                    }

                    //Parse the header
                    if (!isBody)
                    {
                        var parts = line.Split(':');
                        if (parts.Length == 2 && parts[0] == "Content-Length")
                        {
                            content_length = int.Parse(parts[1].Trim());
                        }
                    }
                }

                //read the body if existing
                if (content_length > 0)
                {
                    var data = new StringBuilder(200);
                    char[] chars = new char[1024];
                    int bytesReadTotal = 0;
                    while (bytesReadTotal < content_length)
                    {
                        var bytesRead = reader.Read(chars, 0, chars.Length);
                        bytesReadTotal += bytesRead;
                        if (bytesRead == 0)
                        {
                            break;
                        }
                        data.Append(chars, 0, bytesRead);
                    }
                    Console.WriteLine(data.ToString());
                }

                //write the HTTP response
                writer.WriteLine("HTTP/1.1 200 OK");
                writer.WriteLine("Content-Type: text/html; charset=utf-8");
                writer.WriteLine();
                writer.WriteLine("<html><body><h1>Hello World!</h1></body></html>");
                /*writer.Flush();
                writer.Close();*/
            }
        }
    }
}

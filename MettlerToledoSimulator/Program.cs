﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;      //required
using System.Net.Sockets;    //required

namespace MettlerToledoSimulator
{
    class Program
    {
        static void Main(string[] args)
        {

            TcpListener server = new TcpListener(IPAddress.Any, 9999);
            // we set our IP address as server's address, and we also set the port: 9999

            server.Start();  // this will start the server

            while (true)   //we wait for a connection
            {
                TcpClient client = server.AcceptTcpClient();  //if a connection exists, the server will accept it

                NetworkStream ns = client.GetStream(); //networkstream is used to send/receive messages

                while (client.Connected)  //while the client is connected, we look for incoming messages
                {
                    byte[] msg = new byte[1024];     //the messages arrive as byte array
                    msg = Encoding.ASCII.GetBytes("S S 10000g");
                    ns.Write(msg, 0, msg.Length);
                    
                    System.Threading.Thread.Sleep(1000);

                    /*ns.Read(msg, 0, msg.Length);   //the same networkstream reads the message sent by the client
                    Console.WriteLine(msg.ToString()); //now , we write the message as string*/
                }
            }
        }
    }
}

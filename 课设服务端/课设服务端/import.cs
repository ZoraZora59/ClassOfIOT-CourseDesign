using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Windows.Forms;


namespace 课设服务端
{
    class transducerServer
    {
        public static string ip;
        public static int light;
        public static int port;
        public static int freq;
        public string comLightOn = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 c6 89 00 00 00 00 00 00 08 00 00 01";
        public string comLightOff = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 c6 89 00 00 00 00 00 00 08 00 00 00";
        public Socket socketServer;
        public void socketServerCreate()
        {
            socketServer = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(ip), port);
            socketServer.Connect(point);
            comLightOn.Replace(" ", "");
            comLightOff.Replace(" ", "");
        }
        public  void ctrlLightOn()
        {
            byte[] sendBytes = Encoding.ASCII.GetBytes(comLightOn);
            socketServer.Send(sendBytes);
        }
        public void ctrlLightOff()
        {
            byte[] sendBytes = Encoding.ASCII.GetBytes(comLightOff);
            socketServer.Send(sendBytes);
        }
        public void msgReceive()
        {
            string recStr = "";
            byte[] recBytes = new byte[24];
            int bytes = socketServer.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            Console.WriteLine(recStr);
        }
        public void socketServerClose()
        {
            socketServer.Close();
        }
    }
}
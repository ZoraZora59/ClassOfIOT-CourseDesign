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
        public static int light;
        public static int freq;
        public static string curtainIp;
        public static int curtainPort;
        public static string transIp;
        public static int transPort;

        private static string comCurtainOn1 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 b4 a1 00 00 00 00 00 00 08 00 00 00";
        private static string comCurtainOn2 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 05 3c 00 00 00 00 00 00 08 00 00 00";
        private static string comCurtainOff1 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 b4 a1 00 00 00 00 00 00 08 00 00 01";
        private static string comCurtainOff2 = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 05 3c 00 00 00 00 00 00 08 00 00 01";
        private static string comLightOn = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 c6 89 00 00 00 00 00 00 08 00 00 01";
        private static string comLightOff = "18 00 f1 80 11 53 a5 06 FE 82 0D 02 c6 89 00 00 00 00 00 00 08 00 00 00";

        private String command_query = "08 03 00 2a 00 01 a5 5b";

        public static Socket socketCur;

        public static Socket socketTra;

        public bool socketCurtainCreate()
        {
            socketCur = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(curtainIp), curtainPort);
            socketCur.Connect(point);
            return true;
        }
        public bool socketTransCreate()
        {
            socketTra  = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(transIp), transPort);
            socketTra.Connect(point);
            return true;
        }
        private void ctr(string command,Socket sk)
        {

            byte[] sendBytes = Encoding.ASCII.GetBytes(command.Replace(" ",""));
            sk.Send(sendBytes);
        }

        public void ctrl(string check)
        {
            switch (check)
            {
                /*case "LightOn":
                    ctr(comLightOn,);
                    break;
                case "LightOff":
                    ctr(comLightOff);
                    break;*/
                case "CurtainOn":
                    ctr(comCurtainOn1,socketCur);
                    ctr(comCurtainOn2,socketCur);
                    System.Console.WriteLine("CurtainOn");
                    break;
                case "CurtainOff":
                    ctr(comCurtainOff1,socketCur);
                    ctr(comCurtainOff2,socketCur);
                    break;
                default:
                    break;
            }
        }
 
        public String msgReceive(Socket sk)
        {
            string recStr = "";
            byte[] recBytes = new byte[24];
            //To do 数组清零
            int bytes = sk.Receive(recBytes, recBytes.Length, 0);
            recStr += Encoding.ASCII.GetString(recBytes, 0, bytes);
            Console.WriteLine(recStr);
            return recStr;
        }

        public void socketServerClose()
        {
            socketTra.Close();
            socketCur.Close();
        }
        //System.Convert.ToInt32(十六进制,十进制);十六进制转十进制

        public void thStart()
        {
            Thread backrun = new Thread(new ThreadStart(getLight));
            backrun.Start();
        }
        public void getLight()
        {
            String result = "";

            while (true)
            {
                ctr(command_query,socketTra);
                result = msgReceive(socketTra);
                light = (result[3] << 8) | (result[4] & 0x00ff);
                Thread.Sleep(freq);
            }
        }

    }
}
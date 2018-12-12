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



class transducerServer
{
    public string ip { get; set; }
    public int light { get; set; }
    public int port { get; set; }
    public int freq { get; set; }
    public void socketServerCreate()
    {
        try
        {
            //点击开始监听时 在服务端创建一个负责监听IP和端口号的Socket
            Socket socketWatch = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPAddress ip = IPAddress.Any;
            //创建对象端口
            IPEndPoint point = new IPEndPoint(IPAddress.Parse(this.ip), this.port);

            socketWatch.Bind(point);//绑定端口号
            System.Console.WriteLine("监听成功!");
            socketWatch.Listen(10);//设置监听

            //创建监听线程
            Thread thread = new Thread(Listen);
            thread.IsBackground = true;
            thread.Start(socketWatch);
        }
        catch { }
    }
    Socket socketSend;
    void Listen(object o)
    {
        try
        {
            Socket socketWatch = o as Socket;
            while (true)
            {
                socketSend = socketWatch.Accept();//等待接收客户端连接
                System.Console.WriteLine(socketSend.RemoteEndPoint.ToString() + ":" + "连接成功!");
                //开启一个新线程，执行接收消息方法
                Thread r_thread = new Thread(Received);
                r_thread.IsBackground = true;//r_thread是用来接收消息的线程
                r_thread.Start(socketSend);
            }
        }
        catch { }
    }
    void Received(object o)
    {
        try
        {
            Socket socketSend = o as Socket;
            while (true)
            {
                //客户端连接服务器成功后，服务器接收客户端发送的消息
                byte[] buffer = new byte[14];//接收缓冲区大小
                //实际接收到的有效字节数
                int len = socketSend.Receive(buffer);
                if (len == 0)
                {
                    break;
                }
                string str = Encoding.UTF8.GetString(buffer, 0, len);
                System.Console.WriteLine(socketSend.RemoteEndPoint + ":" + str);
            }
        }
        catch { }
    }
    void Send(string str)
    {
        byte[] buffer = Encoding.UTF8.GetBytes(str);
        socketSend.Send(buffer);
    }
}
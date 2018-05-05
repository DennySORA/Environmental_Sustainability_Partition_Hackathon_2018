using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;

namespace SocketClient  
{  
    class SocketClientClass  
    {
		private Socket clientSocket;
		private static byte[] result = new byte[1024];  
		public SocketClientClass()
		{
			//设定服务器IP地址  
			IPAddress ip = IPAddress.Parse("192.168.1.136");
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				clientSocket.Connect(new IPEndPoint(ip, 5472)); //配置服务器IP与端口  
				Console.WriteLine("连接服务器成功");
			}
			catch
			{
				Console.WriteLine("连接服务器失败，请按回车键退出！");
			}
		}
		private void ReConnect()
		{
			//设定服务器IP地址  
			IPAddress ip = IPAddress.Parse("192.168.1.136");
			clientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
			try
			{
				clientSocket.Connect(new IPEndPoint(ip, 5472)); //配置服务器IP与端口  
				Console.WriteLine("連接服務器成功");
			}
			catch
			{
				Console.WriteLine("連接服務器失敗");
			}
		}
        public int GetValue()
        {
			int receiveLength = 0;
			int value;
			try
			{

				receiveLength = clientSocket.Receive(result);
				Console.ReadLine();
				value = int.Parse(Encoding.ASCII.GetString(result, 0, receiveLength));
			}
			catch
			{
				value = 0;
				ReConnect();
			}
			
			Console.WriteLine(value);
			return value;
        }  
    }  
}  
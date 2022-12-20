using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Net.Sockets;
using System.Data;
using System.Text;
using System.ComponentModel;
using System.Drawing;
using System.Net;
namespace TCP_SERVER
{
	public partial class Form1 : Form
	{
		TcpListener mTcpListener;
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void textBox3_TextChanged(object sender, EventArgs e)
		{

		}

		private void BtStartListening_Click(object sender, EventArgs e)
		{
			IPAddress ipAddr;
			int nPort;

			if (!int.TryParse(TbPort.Text,out nPort))
			{
				nPort = 5555;
			}
			if(!IPAddress.TryParse(TbIPAddres.Text,out ipAddr))
			{
				MessageBox.Show("Invalid IP addres supplied.");
				return;
			}
			mTcpListener = new TcpListener(ipAddr, nPort);
			mTcpListener.Start();

			mTcpListener.BeginAcceptTcpClient(onCompleteAcceptTcpClient, mTcpListener);

		}
		void onCompleteAcceptTcpClient(IAsyncResult iar)
		{
			TcpListener tcpl = (TcpListener)iar.AsyncState;
			tcpl.EndAcceptTcpClient(iar);
		}
	}
}

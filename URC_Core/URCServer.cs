using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace URC_Core
{
    public class URCMasterServer
    {
		private URCLookup lookup;
		private TcpListener conn;

		public URCMasterServer(TcpListener conn, URCLookup lookup)
		{
			this.conn = conn;
			this.lookup = lookup;
		}

		public void Start()
		{
			while (true)
			{
				TcpClient c = conn.AcceptTcpClient();

				Thread t = new Thread(new ThreadStart(() => CreateConnection(c, lookup).Start()));
				t.Start();
			}
		}


		public URCConnection CreateConnection(TcpClient client, URCLookup lookup)
		{
			return new URCConnection(client, lookup);
		}
    }
}

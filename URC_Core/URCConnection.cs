using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace URC_Core
{
	public class URCConnection
	{
		private TcpClient client;
		private URCLookup lookup;

		public URCConnection(TcpClient client, URCLookup lookup)
		{
			this.client = client;
			this.lookup = lookup;
		}
		

		public void Start()
		{
			throw new NotImplementedException();
		}

		public System.Net.IPAddress IP { get; set; }
	}
}

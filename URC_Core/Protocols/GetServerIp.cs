using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using URC_Core.DataPackages;

namespace URC_Core.Protocols
{

	public class GetServerIp : URCProtocol
	{
		public string name { get; set; }

		public override void execute(BinaryFormatter trans, Stream stream)
		{
			URCConnection conn;
			if (this.LookUp.TryFindServer(name, out conn))
			{
				IPAddress ip = conn.IP;
				var package = new IpInfo();
				package.IP = ip;

				trans.Serialize(stream, package);
			
			}
			else
			{
				trans.Serialize(stream, new NoData());
			}
		}


		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("name", this.name);
		}
	}
}

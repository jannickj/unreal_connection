using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace URC_Core.Protocols
{
	public class SetServer : URCProtocol
	{
		public string name { get; set; }


		public override void execute(BinaryFormatter trans, Stream stream)
		{
			this.LookUp.SetServer(name, this.Connection);
		}

		public override void GetObjectData(SerializationInfo info, StreamingContext context)
		{
			info.AddValue("name", name);
		}
	}
}

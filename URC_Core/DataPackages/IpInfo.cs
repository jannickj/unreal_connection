using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace URC_Core.DataPackages
{ 
	public class IpInfo : URCPackage
	{
		public IPAddress IP { get; set; }

		public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
		{
			throw new NotImplementedException();
		}
	}
}

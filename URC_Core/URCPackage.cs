using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace URC_Core
{
	public abstract class URCPackage : ISerializable
	{
		public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}

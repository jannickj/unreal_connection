using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace URC_Core
{
	public abstract class URCProtocol : ISerializable, IDeserializable
	{
		public URCLookup LookUp { get; set; }

		public URCConnection Connection { get; set; }

		public abstract void execute(BinaryFormatter trans, Stream stream);

		public abstract void GetObjectData(SerializationInfo info, StreamingContext context);
	}
}

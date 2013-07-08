using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace URC_Core
{
	public class URCLookup
	{
		private Dictionary<string, URCConnection> lookup = new Dictionary<string,URCConnection>();

		public void SetServer(string name, URCConnection conn)
		{
			lock (this)
			{
				lookup[name] = conn;
			}
		}

		internal bool TryFindServer(string name, out URCConnection conn)
		{
			lock (this)
			{
				return lookup.TryGetValue(name,out conn);
			}
		}
	}
}

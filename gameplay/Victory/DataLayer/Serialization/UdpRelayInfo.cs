using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002BD RID: 701
	public class UdpRelayInfo : IRequestBody
	{
		// Token: 0x0600207F RID: 8319 RVA: 0x0004D5B4 File Offset: 0x0004C5B4
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000789 RID: 1929
		public string Host = "";

		// Token: 0x0400078A RID: 1930
		public int Port;
	}
}

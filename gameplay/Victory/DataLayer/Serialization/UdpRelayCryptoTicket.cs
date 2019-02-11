using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002BC RID: 700
	public class UdpRelayCryptoTicket : IRequestBody
	{
		// Token: 0x0600207D RID: 8317 RVA: 0x0004D574 File Offset: 0x0004C574
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000786 RID: 1926
		public string CryptoTicket = "";

		// Token: 0x04000787 RID: 1927
		public string SessionKey = "";

		// Token: 0x04000788 RID: 1928
		public string TicketIv = "";
	}
}

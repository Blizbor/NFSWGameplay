using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002BB RID: 699
	public class ClientServerCryptoTicket : IRequestBody
	{
		// Token: 0x0600207B RID: 8315 RVA: 0x0004D534 File Offset: 0x0004C534
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000783 RID: 1923
		public string CryptoTicket = "";

		// Token: 0x04000784 RID: 1924
		public string SessionKey = "";

		// Token: 0x04000785 RID: 1925
		public string TicketIv = "";
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F5 RID: 757
	public class P2PCryptoTicket : IRequestBody
	{
		// Token: 0x060020DD RID: 8413 RVA: 0x0004E380 File Offset: 0x0004D380
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000888 RID: 2184
		public long PersonaId;

		// Token: 0x04000889 RID: 2185
		public string SessionKey = "";
	}
}

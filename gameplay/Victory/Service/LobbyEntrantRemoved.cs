using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F3 RID: 755
	public class LobbyEntrantRemoved : IRequestBody
	{
		// Token: 0x060020D9 RID: 8409 RVA: 0x0004E328 File Offset: 0x0004D328
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000882 RID: 2178
		public long LobbyId;

		// Token: 0x04000883 RID: 2179
		public long PersonaId;
	}
}

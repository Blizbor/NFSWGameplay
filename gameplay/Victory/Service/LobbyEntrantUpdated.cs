using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002FF RID: 767
	public class LobbyEntrantUpdated : IRequestBody
	{
		// Token: 0x060020F1 RID: 8433 RVA: 0x0004E518 File Offset: 0x0004D518
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008AD RID: 2221
		public long PersonaId;

		// Token: 0x040008AE RID: 2222
		public LobbyEntrantState State;
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002FC RID: 764
	public class LobbyInvite : IRequestBody
	{
		// Token: 0x060020EB RID: 8427 RVA: 0x0004E4B8 File Offset: 0x0004D4B8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008A2 RID: 2210
		public int EventId;

		// Token: 0x040008A3 RID: 2211
		public int InviteLifetimeInMilliseconds;

		// Token: 0x040008A4 RID: 2212
		public long InvitedByPersonaId;

		// Token: 0x040008A5 RID: 2213
		public bool IsPrivate;

		// Token: 0x040008A6 RID: 2214
		public long LobbyInviteId;
	}
}

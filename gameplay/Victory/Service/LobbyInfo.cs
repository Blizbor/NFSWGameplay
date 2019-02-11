using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000300 RID: 768
	public class LobbyInfo : IRequestBody
	{
		// Token: 0x060020F3 RID: 8435 RVA: 0x0004E538 File Offset: 0x0004D538
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008AF RID: 2223
		public LobbyCountdown Countdown;

		// Token: 0x040008B0 RID: 2224
		public List<LobbyEntrantInfo> Entrants;

		// Token: 0x040008B1 RID: 2225
		public int EventId;

		// Token: 0x040008B2 RID: 2226
		public bool IsInviteEnabled;

		// Token: 0x040008B3 RID: 2227
		public long LobbyId;

		// Token: 0x040008B4 RID: 2228
		public long LobbyInviteId;
	}
}

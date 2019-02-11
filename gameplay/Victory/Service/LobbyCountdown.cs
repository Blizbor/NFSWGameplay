using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002FD RID: 765
	public class LobbyCountdown : IRequestBody
	{
		// Token: 0x060020ED RID: 8429 RVA: 0x0004E4D8 File Offset: 0x0004D4D8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008A7 RID: 2215
		public int EventId;

		// Token: 0x040008A8 RID: 2216
		public bool IsWaiting;

		// Token: 0x040008A9 RID: 2217
		public int LobbyCountdownInMilliseconds;

		// Token: 0x040008AA RID: 2218
		public long LobbyId;

		// Token: 0x040008AB RID: 2219
		public int LobbyStuckDurationInMilliseconds;
	}
}

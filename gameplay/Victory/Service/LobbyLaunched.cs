using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F8 RID: 760
	public class LobbyLaunched : IRequestBody
	{
		// Token: 0x060020E3 RID: 8419 RVA: 0x0004E3EC File Offset: 0x0004D3EC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000892 RID: 2194
		public List<P2PCryptoTicket> CryptoTickets;

		// Token: 0x04000893 RID: 2195
		public List<LobbyEntrantInfo> Entrants;

		// Token: 0x04000894 RID: 2196
		public SessionInfo EventSession;

		// Token: 0x04000895 RID: 2197
		public bool IsNewRelayServer;

		// Token: 0x04000896 RID: 2198
		public long LobbyId;

		// Token: 0x04000897 RID: 2199
		public string UdpRelayHost = "";

		// Token: 0x04000898 RID: 2200
		public int UdpRelayPort;
	}
}

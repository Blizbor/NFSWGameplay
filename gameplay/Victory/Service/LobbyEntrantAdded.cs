using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002FE RID: 766
	public class LobbyEntrantAdded : LobbyEntrantInfo, IRequestBody
	{
		// Token: 0x060020EF RID: 8431 RVA: 0x0004E4F8 File Offset: 0x0004D4F8
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008AC RID: 2220
		public long LobbyId;
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x0200032F RID: 815
	public class FriendPersona : IRequestBody
	{
		// Token: 0x0600214B RID: 8523 RVA: 0x0004EEEC File Offset: 0x0004DEEC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400099E RID: 2462
		public int iconIndex;

		// Token: 0x0400099F RID: 2463
		public int level;

		// Token: 0x040009A0 RID: 2464
		public string name = "";

		// Token: 0x040009A1 RID: 2465
		public string originalName = "";

		// Token: 0x040009A2 RID: 2466
		public long personaId;

		// Token: 0x040009A3 RID: 2467
		public int presence;

		// Token: 0x040009A4 RID: 2468
		public int socialNetwork;

		// Token: 0x040009A5 RID: 2469
		public long userId;
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D1 RID: 721
	public class TreasureHuntEventSession : IRequestBody
	{
		// Token: 0x060020A7 RID: 8359 RVA: 0x0004D884 File Offset: 0x0004C884
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007CC RID: 1996
		public int CoinsCollected;

		// Token: 0x040007CD RID: 1997
		public bool IsStreakBroken;

		// Token: 0x040007CE RID: 1998
		public int NumCoins;

		// Token: 0x040007CF RID: 1999
		public int Seed;

		// Token: 0x040007D0 RID: 2000
		public int Streak;
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C2 RID: 706
	public class LuckyDrawInfo : IRequestBody
	{
		// Token: 0x06002089 RID: 8329 RVA: 0x0004D660 File Offset: 0x0004C660
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000799 RID: 1945
		public List<LuckyDrawBox> Boxes;

		// Token: 0x0400079A RID: 1946
		public string CardDeck = "";

		// Token: 0x0400079B RID: 1947
		public int CurrentStreak;

		// Token: 0x0400079C RID: 1948
		public bool IsStreakBroken;

		// Token: 0x0400079D RID: 1949
		public List<LuckyDrawItem> Items;

		// Token: 0x0400079E RID: 1950
		public int NumBoxAnimations;

		// Token: 0x0400079F RID: 1951
		public int NumCards;
	}
}

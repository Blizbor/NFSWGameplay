using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C3 RID: 707
	public class Accolades : IRequestBody
	{
		// Token: 0x0600208B RID: 8331 RVA: 0x0004D68C File Offset: 0x0004C68C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007A0 RID: 1952
		public Reward FinalRewards;

		// Token: 0x040007A1 RID: 1953
		public bool HasLeveledUp;

		// Token: 0x040007A2 RID: 1954
		public LuckyDrawInfo LuckyDrawInfo;

		// Token: 0x040007A3 RID: 1955
		public Reward OriginalRewards;

		// Token: 0x040007A4 RID: 1956
		public List<RewardPart> RewardInfo;
	}
}

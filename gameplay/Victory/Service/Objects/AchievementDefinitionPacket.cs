using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000318 RID: 792
	public class AchievementDefinitionPacket : IRequestBody
	{
		// Token: 0x06002123 RID: 8483 RVA: 0x0004EAA8 File Offset: 0x0004DAA8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000955 RID: 2389
		public int AchievementDefinitionId;

		// Token: 0x04000956 RID: 2390
		public List<AchievementRankPacket> AchievementRanks;

		// Token: 0x04000957 RID: 2391
		public int BadgeDefinitionId;

		// Token: 0x04000958 RID: 2392
		public bool CanProgress;

		// Token: 0x04000959 RID: 2393
		public long CurrentValue;

		// Token: 0x0400095A RID: 2394
		public bool IsVisible;

		// Token: 0x0400095B RID: 2395
		public string ProgressText = "";

		// Token: 0x0400095C RID: 2396
		public StatConversion StatConversion;
	}
}

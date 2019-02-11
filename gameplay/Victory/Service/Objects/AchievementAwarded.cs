using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000308 RID: 776
	public class AchievementAwarded : IRequestBody
	{
		// Token: 0x06002103 RID: 8451 RVA: 0x0004E7B8 File Offset: 0x0004D7B8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008E1 RID: 2273
		public DateTime AchievedOn = DateTime.FromBinary(0L);

		// Token: 0x040008E2 RID: 2274
		public int AchievementDefinitionId;

		// Token: 0x040008E3 RID: 2275
		public int AchievementRankId;

		// Token: 0x040008E4 RID: 2276
		public string Clip = "";

		// Token: 0x040008E5 RID: 2277
		public float ClipLengthInSeconds;

		// Token: 0x040008E6 RID: 2278
		public string Description = "";

		// Token: 0x040008E7 RID: 2279
		public string Icon = "";

		// Token: 0x040008E8 RID: 2280
		public bool IsRare;

		// Token: 0x040008E9 RID: 2281
		public string Name = "";

		// Token: 0x040008EA RID: 2282
		public short Points;

		// Token: 0x040008EB RID: 2283
		public float Rarity;
	}
}

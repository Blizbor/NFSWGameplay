using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000319 RID: 793
	public class AchievementRankPacket : IRequestBody
	{
		// Token: 0x06002125 RID: 8485 RVA: 0x0004EAD4 File Offset: 0x0004DAD4
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400095D RID: 2397
		public DateTime AchievedOn = DateTime.FromBinary(0L);

		// Token: 0x0400095E RID: 2398
		public int AchievementRankId;

		// Token: 0x0400095F RID: 2399
		public bool IsRare;

		// Token: 0x04000960 RID: 2400
		public short Points;

		// Token: 0x04000961 RID: 2401
		public short Rank;

		// Token: 0x04000962 RID: 2402
		public float Rarity;

		// Token: 0x04000963 RID: 2403
		public string RewardDescription = "";

		// Token: 0x04000964 RID: 2404
		public string RewardType = "";

		// Token: 0x04000965 RID: 2405
		public string RewardVisualStyle = "";

		// Token: 0x04000966 RID: 2406
		public AchievementState State;

		// Token: 0x04000967 RID: 2407
		public long ThresholdValue;
	}
}

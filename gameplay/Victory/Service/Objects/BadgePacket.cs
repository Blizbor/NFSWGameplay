using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000309 RID: 777
	public class BadgePacket : IRequestBody
	{
		// Token: 0x06002105 RID: 8453 RVA: 0x0004E81C File Offset: 0x0004D81C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008EC RID: 2284
		public int AchievementRankId;

		// Token: 0x040008ED RID: 2285
		public int BadgeDefinitionId;

		// Token: 0x040008EE RID: 2286
		public bool IsRare;

		// Token: 0x040008EF RID: 2287
		public float Rarity;

		// Token: 0x040008F0 RID: 2288
		public short SlotId;
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000307 RID: 775
	public class AchievementsAwarded : IRequestBody
	{
		// Token: 0x06002101 RID: 8449 RVA: 0x0004E798 File Offset: 0x0004D798
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008DC RID: 2268
		public List<AchievementAwarded> Achievements;

		// Token: 0x040008DD RID: 2269
		public List<BadgePacket> Badges;

		// Token: 0x040008DE RID: 2270
		public long PersonaId;

		// Token: 0x040008DF RID: 2271
		public List<AchievementProgress> Progressed;

		// Token: 0x040008E0 RID: 2272
		public int Score;
	}
}

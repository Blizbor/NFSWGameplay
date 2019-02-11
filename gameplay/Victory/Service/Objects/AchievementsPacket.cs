using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000316 RID: 790
	public class AchievementsPacket : IRequestBody
	{
		// Token: 0x0600211F RID: 8479 RVA: 0x0004EA30 File Offset: 0x0004DA30
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400094C RID: 2380
		public List<BadgeDefinitionPacket> Badges;

		// Token: 0x0400094D RID: 2381
		public List<AchievementDefinitionPacket> Definitions;

		// Token: 0x0400094E RID: 2382
		public long PersonaId;
	}
}

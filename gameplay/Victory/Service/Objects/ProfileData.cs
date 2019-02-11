using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000315 RID: 789
	public class ProfileData : IRequestBody
	{
		// Token: 0x0600211D RID: 8477 RVA: 0x0004E9F8 File Offset: 0x0004D9F8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000940 RID: 2368
		public List<BadgePacket> Badges;

		// Token: 0x04000941 RID: 2369
		public double Cash;

		// Token: 0x04000942 RID: 2370
		public int IconIndex;

		// Token: 0x04000943 RID: 2371
		public int Level;

		// Token: 0x04000944 RID: 2372
		public string Motto = "";

		// Token: 0x04000945 RID: 2373
		public string Name = "";

		// Token: 0x04000946 RID: 2374
		public float PercentToLevel;

		// Token: 0x04000947 RID: 2375
		public long PersonaId;

		// Token: 0x04000948 RID: 2376
		public double Rating;

		// Token: 0x04000949 RID: 2377
		public double Rep;

		// Token: 0x0400094A RID: 2378
		public int RepAtCurrentLevel;

		// Token: 0x0400094B RID: 2379
		public int Score;
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200030B RID: 779
	public class PersonaBase : IRequestBody
	{
		// Token: 0x06002109 RID: 8457 RVA: 0x0004E85C File Offset: 0x0004D85C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008F3 RID: 2291
		public List<BadgePacket> Badges;

		// Token: 0x040008F4 RID: 2292
		public int IconIndex;

		// Token: 0x040008F5 RID: 2293
		public int Level;

		// Token: 0x040008F6 RID: 2294
		public string Motto = "";

		// Token: 0x040008F7 RID: 2295
		public string Name = "";

		// Token: 0x040008F8 RID: 2296
		public long PersonaId;

		// Token: 0x040008F9 RID: 2297
		public int Presence;

		// Token: 0x040008FA RID: 2298
		public int Score;

		// Token: 0x040008FB RID: 2299
		public long UserId;
	}
}

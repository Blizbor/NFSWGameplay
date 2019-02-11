using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200031D RID: 797
	public class BadgesPacket : IRequestBody
	{
		// Token: 0x0600212D RID: 8493 RVA: 0x0004EB90 File Offset: 0x0004DB90
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400096D RID: 2413
		public List<BadgePacket> Badges;
	}
}

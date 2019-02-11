using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200031B RID: 795
	public class BadgeBundle : IRequestBody
	{
		// Token: 0x06002129 RID: 8489 RVA: 0x0004EB50 File Offset: 0x0004DB50
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400096A RID: 2410
		public List<BadgeInput> Badges;
	}
}

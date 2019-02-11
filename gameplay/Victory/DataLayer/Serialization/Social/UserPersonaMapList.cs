using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Social
{
	// Token: 0x020002E6 RID: 742
	public class UserPersonaMapList : IRequestBody
	{
		// Token: 0x060020C9 RID: 8393 RVA: 0x0004DF70 File Offset: 0x0004CF70
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400084E RID: 2126
		public List<UserPersonaMap> map;
	}
}

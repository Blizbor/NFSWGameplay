using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000314 RID: 788
	public class StatNameList : IRequestBody
	{
		// Token: 0x0600211B RID: 8475 RVA: 0x0004E9D8 File Offset: 0x0004D9D8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400093F RID: 2367
		public List<string> Stats;
	}
}

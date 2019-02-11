using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000305 RID: 773
	public class configuration : IRequestBody
	{
		// Token: 0x060020FD RID: 8445 RVA: 0x0004E734 File Offset: 0x0004D734
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008D6 RID: 2262
		public string gameserver = "";

		// Token: 0x040008D7 RID: 2263
		public string webserver = "";

		// Token: 0x040008D8 RID: 2264
		public List<region> regions;

		// Token: 0x040008D9 RID: 2265
		public Cdn cdn;

		// Token: 0x040008DA RID: 2266
		public TermsOfService termsofservice;
	}
}

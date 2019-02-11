using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000304 RID: 772
	public class TermsOfService : IRequestBody
	{
		// Token: 0x060020FB RID: 8443 RVA: 0x0004E690 File Offset: 0x0004D690
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008CB RID: 2251
		public string en = "";

		// Token: 0x040008CC RID: 2252
		public string de = "";

		// Token: 0x040008CD RID: 2253
		public string es = "";

		// Token: 0x040008CE RID: 2254
		public string fr = "";

		// Token: 0x040008CF RID: 2255
		public string pl = "";

		// Token: 0x040008D0 RID: 2256
		public string pt = "";

		// Token: 0x040008D1 RID: 2257
		public string ru = "";

		// Token: 0x040008D2 RID: 2258
		public string th = "";

		// Token: 0x040008D3 RID: 2259
		public string tr = "";

		// Token: 0x040008D4 RID: 2260
		public string zh = "";

		// Token: 0x040008D5 RID: 2261
		public string zh_chs = "";
	}
}

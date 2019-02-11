using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A7 RID: 679
	public class Token : IRequestBody
	{
		// Token: 0x06002053 RID: 8275 RVA: 0x0004D0DC File Offset: 0x0004C0DC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006FC RID: 1788
		public bool EualaAccepted;

		// Token: 0x040006FD RID: 1789
		public string Region = "";

		// Token: 0x040006FE RID: 1790
		public string Value = "";
	}
}

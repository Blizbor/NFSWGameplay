using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A6 RID: 678
	public class Credentials : IRequestBody
	{
		// Token: 0x06002051 RID: 8273 RVA: 0x0004D09C File Offset: 0x0004C09C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006F9 RID: 1785
		public string Email = "";

		// Token: 0x040006FA RID: 1786
		public string Password = "";

		// Token: 0x040006FB RID: 1787
		public string Region = "";
	}
}

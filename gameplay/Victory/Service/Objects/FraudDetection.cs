using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200030C RID: 780
	public class FraudDetection : IRequestBody
	{
		// Token: 0x0600210B RID: 8459 RVA: 0x0004E894 File Offset: 0x0004D894
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008FC RID: 2300
		public int Checksum;

		// Token: 0x040008FD RID: 2301
		public int IntValue1;

		// Token: 0x040008FE RID: 2302
		public int IntValue2;

		// Token: 0x040008FF RID: 2303
		public int IntValue3;

		// Token: 0x04000900 RID: 2304
		public int IntValue4;

		// Token: 0x04000901 RID: 2305
		public bool IsEncrypted;

		// Token: 0x04000902 RID: 2306
		public string ModuleName = "";

		// Token: 0x04000903 RID: 2307
		public string ModulePath = "";

		// Token: 0x04000904 RID: 2308
		public string ModuleValue = "";

		// Token: 0x04000905 RID: 2309
		public string StringValue1 = "";

		// Token: 0x04000906 RID: 2310
		public string StringValue2 = "";
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002AF RID: 687
	public class LauncherStartTrans : IRequestBody
	{
		// Token: 0x06002063 RID: 8291 RVA: 0x0004D258 File Offset: 0x0004C258
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400073C RID: 1852
		public string autoLogin = "";

		// Token: 0x0400073D RID: 1853
		public string autoStart = "";

		// Token: 0x0400073E RID: 1854
		public string language = "";

		// Token: 0x0400073F RID: 1855
		public string languageCode = "";

		// Token: 0x04000740 RID: 1856
		public string region = "";

		// Token: 0x04000741 RID: 1857
		public string sku = "";

		// Token: 0x04000742 RID: 1858
		public long userID;
	}
}

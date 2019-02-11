using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200031E RID: 798
	public class ShardInfo : IRequestBody
	{
		// Token: 0x0600212F RID: 8495 RVA: 0x0004EBB0 File Offset: 0x0004DBB0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400096E RID: 2414
		public int RegionId;

		// Token: 0x0400096F RID: 2415
		public string RegionName = "";

		// Token: 0x04000970 RID: 2416
		public string ShardName = "";

		// Token: 0x04000971 RID: 2417
		public string Url = "";
	}
}

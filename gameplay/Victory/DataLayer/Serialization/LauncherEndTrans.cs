using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B0 RID: 688
	public class LauncherEndTrans : IRequestBody
	{
		// Token: 0x06002065 RID: 8293 RVA: 0x0004D2C8 File Offset: 0x0004C2C8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000743 RID: 1859
		public string leaveReasonID = "";

		// Token: 0x04000744 RID: 1860
		public string patchTime = "";

		// Token: 0x04000745 RID: 1861
		public long userID;
	}
}

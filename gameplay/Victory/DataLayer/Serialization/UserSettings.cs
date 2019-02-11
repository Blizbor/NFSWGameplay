using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002AD RID: 685
	public class UserSettings : IRequestBody
	{
		// Token: 0x0600205F RID: 8287 RVA: 0x0004D1F8 File Offset: 0x0004C1F8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400072D RID: 1837
		public uint desktopResHeight;

		// Token: 0x0400072E RID: 1838
		public uint desktopResWidth;

		// Token: 0x0400072F RID: 1839
		public bool fullscreen;

		// Token: 0x04000730 RID: 1840
		public uint gameResHeight;

		// Token: 0x04000731 RID: 1841
		public uint gameResWidth;

		// Token: 0x04000732 RID: 1842
		public uint globalDetailLevel;

		// Token: 0x04000733 RID: 1843
		public long userID;
	}
}

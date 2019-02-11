using System;
using server_packet;
using Victory.DataObjects.Objects.LoginAnnouncement;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.LoginAnnouncement
{
	// Token: 0x020002DF RID: 735
	public class LoginAnnouncementDefinition : IRequestBody
	{
		// Token: 0x060020BB RID: 8379 RVA: 0x0004DE78 File Offset: 0x0004CE78
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000838 RID: 2104
		public LoginAnnouncementContext Context;

		// Token: 0x04000839 RID: 2105
		public int Id;

		// Token: 0x0400083A RID: 2106
		public int ImageChecksum;

		// Token: 0x0400083B RID: 2107
		public string ImageUrl = "";

		// Token: 0x0400083C RID: 2108
		public string Target = "";

		// Token: 0x0400083D RID: 2109
		public LoginAnnouncementType Type;
	}
}

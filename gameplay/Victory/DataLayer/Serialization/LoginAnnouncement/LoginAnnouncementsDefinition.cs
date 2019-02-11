using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.LoginAnnouncement
{
	// Token: 0x020002DE RID: 734
	public class LoginAnnouncementsDefinition : IRequestBody
	{
		// Token: 0x060020B9 RID: 8377 RVA: 0x0004DE4C File Offset: 0x0004CE4C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000836 RID: 2102
		public List<LoginAnnouncementDefinition> Announcements;

		// Token: 0x04000837 RID: 2103
		public string ImagesPath = "";
	}
}

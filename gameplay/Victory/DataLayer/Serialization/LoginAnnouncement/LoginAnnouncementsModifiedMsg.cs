using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.LoginAnnouncement
{
	// Token: 0x020002DD RID: 733
	public class LoginAnnouncementsModifiedMsg : IRequestBody
	{
		// Token: 0x060020B7 RID: 8375 RVA: 0x0004DE2C File Offset: 0x0004CE2C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.User
{
	// Token: 0x0200033B RID: 827
	public class UserInfo : IRequestBody
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x0004F3C8 File Offset: 0x0004E3C8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009FB RID: 2555
		public int defaultPersonaIdx;

		// Token: 0x040009FC RID: 2556
		public List<ProfileData> personas;

		// Token: 0x040009FD RID: 2557
		public User user;
	}
}

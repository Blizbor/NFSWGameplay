using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x02000331 RID: 817
	public class PersonaFriendsList : IRequestBody
	{
		// Token: 0x0600214F RID: 8527 RVA: 0x0004EF44 File Offset: 0x0004DF44
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009A8 RID: 2472
		public List<FriendPersona> friendPersona;
	}
}

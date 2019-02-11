using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x02000330 RID: 816
	public class FriendResult : IRequestBody
	{
		// Token: 0x0600214D RID: 8525 RVA: 0x0004EF24 File Offset: 0x0004DF24
		public virtual string Serialize()
		{
			string text;
			XSD2CPP.Writer(this, out text);
			return text;
		}

		// Token: 0x040009A6 RID: 2470
		public FriendPersona persona;

		// Token: 0x040009A7 RID: 2471
		public int result;
	}
}

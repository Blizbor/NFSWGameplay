using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.Session
{
	// Token: 0x02000338 RID: 824
	public class chatServer : IRequestBody
	{
		// Token: 0x06002159 RID: 8537 RVA: 0x0004F224 File Offset: 0x0004E224
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009D7 RID: 2519
		public List<chatRoom> Rooms;

		// Token: 0x040009D8 RID: 2520
		public string ip = "";

		// Token: 0x040009D9 RID: 2521
		public int port;

		// Token: 0x040009DA RID: 2522
		public string prefix = "";
	}
}

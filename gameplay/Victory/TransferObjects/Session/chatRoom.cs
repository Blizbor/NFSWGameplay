using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.Session
{
	// Token: 0x02000339 RID: 825
	public class chatRoom : IRequestBody
	{
		// Token: 0x0600215B RID: 8539 RVA: 0x0004F25C File Offset: 0x0004E25C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009DB RID: 2523
		public int channelCount;

		// Token: 0x040009DC RID: 2524
		public string longName = "";

		// Token: 0x040009DD RID: 2525
		public string shortName = "";
	}
}

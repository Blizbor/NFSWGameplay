using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000302 RID: 770
	public class Cdn : IRequestBody
	{
		// Token: 0x060020F7 RID: 8439 RVA: 0x0004E62C File Offset: 0x0004D62C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008C8 RID: 2248
		public string game = "";

		// Token: 0x040008C9 RID: 2249
		public string launcher = "";
	}
}

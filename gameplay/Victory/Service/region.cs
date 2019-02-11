using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x02000303 RID: 771
	public class region : IRequestBody
	{
		// Token: 0x060020F9 RID: 8441 RVA: 0x0004E664 File Offset: 0x0004D664
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040008CA RID: 2250
		public string name = "";
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000322 RID: 802
	public class ShortcutUsage : IRequestBody
	{
		// Token: 0x06002137 RID: 8503 RVA: 0x0004EC74 File Offset: 0x0004DC74
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400097C RID: 2428
		public string shortCut = "";

		// Token: 0x0400097D RID: 2429
		public int timesUsed;
	}
}

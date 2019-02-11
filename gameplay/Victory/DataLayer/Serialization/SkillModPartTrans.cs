using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A2 RID: 674
	public class SkillModPartTrans : IRequestBody
	{
		// Token: 0x06002049 RID: 8265 RVA: 0x0004D010 File Offset: 0x0004C010
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006DE RID: 1758
		public bool IsFixed;

		// Token: 0x040006DF RID: 1759
		public int SkillModPartAttribHash;
	}
}

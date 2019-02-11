using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A0 RID: 672
	public class CustomPaintTrans : IRequestBody
	{
		// Token: 0x06002045 RID: 8261 RVA: 0x0004CFD0 File Offset: 0x0004BFD0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006D8 RID: 1752
		public int Group;

		// Token: 0x040006D9 RID: 1753
		public int Hue;

		// Token: 0x040006DA RID: 1754
		public int Sat;

		// Token: 0x040006DB RID: 1755
		public int Slot;

		// Token: 0x040006DC RID: 1756
		public int Var;
	}
}

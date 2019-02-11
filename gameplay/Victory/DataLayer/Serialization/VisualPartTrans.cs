using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A4 RID: 676
	public class VisualPartTrans : IRequestBody
	{
		// Token: 0x0600204D RID: 8269 RVA: 0x0004D050 File Offset: 0x0004C050
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006F5 RID: 1781
		public int PartHash;

		// Token: 0x040006F6 RID: 1782
		public int SlotHash;
	}
}

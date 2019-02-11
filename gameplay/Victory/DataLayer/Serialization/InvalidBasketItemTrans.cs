using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x0200029C RID: 668
	public class InvalidBasketItemTrans : IRequestBody
	{
		// Token: 0x0600203D RID: 8253 RVA: 0x0004CEDC File Offset: 0x0004BEDC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006B5 RID: 1717
		public int Index;

		// Token: 0x040006B6 RID: 1718
		public int Reason;
	}
}

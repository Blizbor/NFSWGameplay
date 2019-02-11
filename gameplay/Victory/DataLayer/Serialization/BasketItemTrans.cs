using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x0200029B RID: 667
	public class BasketItemTrans : IRequestBody
	{
		// Token: 0x0600203B RID: 8251 RVA: 0x0004CEB0 File Offset: 0x0004BEB0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006B3 RID: 1715
		public string ProductId = "";

		// Token: 0x040006B4 RID: 1716
		public int Quantity;
	}
}

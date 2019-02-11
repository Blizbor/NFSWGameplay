using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x02000299 RID: 665
	public class InvalidBasketTrans : IRequestBody
	{
		// Token: 0x06002037 RID: 8247 RVA: 0x0004CE70 File Offset: 0x0004BE70
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006AB RID: 1707
		public BasketTrans Basket;

		// Token: 0x040006AC RID: 1708
		public List<InvalidBasketItemTrans> InvalidItems;
	}
}

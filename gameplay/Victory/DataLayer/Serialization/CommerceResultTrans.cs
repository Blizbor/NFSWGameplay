using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x0200029A RID: 666
	public class CommerceResultTrans : IRequestBody
	{
		// Token: 0x06002039 RID: 8249 RVA: 0x0004CE90 File Offset: 0x0004BE90
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006AD RID: 1709
		public List<CommerceItemTrans> CommerceItems;

		// Token: 0x040006AE RID: 1710
		public InvalidBasketTrans InvalidBasket;

		// Token: 0x040006AF RID: 1711
		public List<InventoryItemTrans> InventoryItems;

		// Token: 0x040006B0 RID: 1712
		public List<OwnedCarTrans> PurchasedCars;

		// Token: 0x040006B1 RID: 1713
		public CommerceResultStatus Status;

		// Token: 0x040006B2 RID: 1714
		public List<WalletTrans> Wallets;
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002BA RID: 698
	public class CommerceSessionResultTrans : IRequestBody
	{
		// Token: 0x06002079 RID: 8313 RVA: 0x0004D514 File Offset: 0x0004C514
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400077E RID: 1918
		public InvalidBasketTrans InvalidBasket;

		// Token: 0x0400077F RID: 1919
		public List<InventoryItemTrans> InventoryItems;

		// Token: 0x04000780 RID: 1920
		public CommerceResultStatus Status;

		// Token: 0x04000781 RID: 1921
		public OwnedCarTrans UpdatedCar;

		// Token: 0x04000782 RID: 1922
		public List<WalletTrans> Wallets;
	}
}

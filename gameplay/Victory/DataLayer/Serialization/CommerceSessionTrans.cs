using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B9 RID: 697
	public class CommerceSessionTrans : IRequestBody
	{
		// Token: 0x06002077 RID: 8311 RVA: 0x0004D4F4 File Offset: 0x0004C4F4
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400077B RID: 1915
		public BasketTrans Basket;

		// Token: 0x0400077C RID: 1916
		public EntitlementTrans EntitlementsToSell;

		// Token: 0x0400077D RID: 1917
		public OwnedCarTrans UpdatedCar;
	}
}

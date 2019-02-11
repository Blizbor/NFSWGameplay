using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x0200029D RID: 669
	public class InventoryItemTrans : IRequestBody
	{
		// Token: 0x0600203F RID: 8255 RVA: 0x0004CEFC File Offset: 0x0004BEFC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006B7 RID: 1719
		public string EntitlementTag = "";

		// Token: 0x040006B8 RID: 1720
		public DateTime ExpirationDate = DateTime.FromBinary(0L);

		// Token: 0x040006B9 RID: 1721
		public int Hash;

		// Token: 0x040006BA RID: 1722
		public long InventoryId;

		// Token: 0x040006BB RID: 1723
		public string ProductId = "";

		// Token: 0x040006BC RID: 1724
		public long RemainingUseCount;

		// Token: 0x040006BD RID: 1725
		public double ResellPrice;

		// Token: 0x040006BE RID: 1726
		public string Status = "";

		// Token: 0x040006BF RID: 1727
		public string StringHash = "";

		// Token: 0x040006C0 RID: 1728
		public string VirtualItemType = "";
	}
}

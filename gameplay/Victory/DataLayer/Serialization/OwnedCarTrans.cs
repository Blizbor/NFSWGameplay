using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x0200029F RID: 671
	public class OwnedCarTrans : IRequestBody
	{
		// Token: 0x06002043 RID: 8259 RVA: 0x0004CF98 File Offset: 0x0004BF98
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006D2 RID: 1746
		public CustomCarTrans CustomCar;

		// Token: 0x040006D3 RID: 1747
		public int Durability;

		// Token: 0x040006D4 RID: 1748
		public DateTime ExpirationDate = DateTime.FromBinary(0L);

		// Token: 0x040006D5 RID: 1749
		public float Heat;

		// Token: 0x040006D6 RID: 1750
		public long Id;

		// Token: 0x040006D7 RID: 1751
		public string OwnershipType = "";
	}
}

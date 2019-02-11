using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B7 RID: 695
	public class EntitlementItemTrans : IRequestBody
	{
		// Token: 0x06002073 RID: 8307 RVA: 0x0004D450 File Offset: 0x0004C450
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400076B RID: 1899
		public string EntitlementId = "";

		// Token: 0x0400076C RID: 1900
		public int Quantity;
	}
}

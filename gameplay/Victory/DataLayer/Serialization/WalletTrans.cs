using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A5 RID: 677
	public class WalletTrans : IRequestBody
	{
		// Token: 0x0600204F RID: 8271 RVA: 0x0004D070 File Offset: 0x0004C070
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006F7 RID: 1783
		public double Balance;

		// Token: 0x040006F8 RID: 1784
		public string Currency = "";
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x02000297 RID: 663
	public class BasketTrans : IRequestBody
	{
		// Token: 0x06002033 RID: 8243 RVA: 0x0004CE24 File Offset: 0x0004BE24
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006A8 RID: 1704
		public List<BasketItemTrans> Items;
	}
}

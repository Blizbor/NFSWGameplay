using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B6 RID: 694
	public class EntitlementTrans : IRequestBody
	{
		// Token: 0x06002071 RID: 8305 RVA: 0x0004D430 File Offset: 0x0004C430
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400076A RID: 1898
		public List<EntitlementItemTrans> Items;
	}
}

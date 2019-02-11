using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x02000298 RID: 664
	public class CommerceItemTrans : IRequestBody
	{
		// Token: 0x06002035 RID: 8245 RVA: 0x0004CE44 File Offset: 0x0004BE44
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006A9 RID: 1705
		public int Hash;

		// Token: 0x040006AA RID: 1706
		public string Title = "";
	}
}

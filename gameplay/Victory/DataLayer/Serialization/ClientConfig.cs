using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002AA RID: 682
	public class ClientConfig : IRequestBody
	{
		// Token: 0x06002059 RID: 8281 RVA: 0x0004D160 File Offset: 0x0004C160
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000702 RID: 1794
		public string group = "";

		// Token: 0x04000703 RID: 1795
		public long level;
	}
}

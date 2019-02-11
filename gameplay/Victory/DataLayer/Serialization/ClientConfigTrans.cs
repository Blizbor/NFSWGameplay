using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A9 RID: 681
	public class ClientConfigTrans : IRequestBody
	{
		// Token: 0x06002057 RID: 8279 RVA: 0x0004D140 File Offset: 0x0004C140
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000701 RID: 1793
		public List<ClientConfig> clientConfigs;
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A8 RID: 680
	public class GetPermanentSessionData : IRequestBody
	{
		// Token: 0x06002055 RID: 8277 RVA: 0x0004D114 File Offset: 0x0004C114
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006FF RID: 1791
		public long machineID;

		// Token: 0x04000700 RID: 1792
		public string version = "";
	}
}

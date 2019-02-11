using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B2 RID: 690
	public class HeartBeat : IRequestBody
	{
		// Token: 0x06002069 RID: 8297 RVA: 0x0004D320 File Offset: 0x0004C320
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000749 RID: 1865
		public int MetagameFlags;

		// Token: 0x0400074A RID: 1866
		public int enabledBitField;
	}
}

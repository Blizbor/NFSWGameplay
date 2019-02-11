using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F7 RID: 759
	public class SessionInfo : IRequestBody
	{
		// Token: 0x060020E1 RID: 8417 RVA: 0x0004E3CC File Offset: 0x0004D3CC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400088F RID: 2191
		public SecurityChallenge Challenge;

		// Token: 0x04000890 RID: 2192
		public int EventId;

		// Token: 0x04000891 RID: 2193
		public long SessionId;
	}
}

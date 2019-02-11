using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002C1 RID: 705
	public class Reward : IRequestBody
	{
		// Token: 0x06002087 RID: 8327 RVA: 0x0004D640 File Offset: 0x0004C640
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000797 RID: 1943
		public int Rep;

		// Token: 0x04000798 RID: 1944
		public int Tokens;
	}
}

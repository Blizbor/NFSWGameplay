using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200030E RID: 782
	public class SecurityResponse : IRequestBody
	{
		// Token: 0x0600210F RID: 8463 RVA: 0x0004E90C File Offset: 0x0004D90C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400090D RID: 2317
		public string ChallengeId = "";

		// Token: 0x0400090E RID: 2318
		public long Result;
	}
}

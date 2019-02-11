using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F4 RID: 756
	public class SecurityChallenge : IRequestBody
	{
		// Token: 0x060020DB RID: 8411 RVA: 0x0004E348 File Offset: 0x0004D348
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000884 RID: 2180
		public string ChallengeId = "";

		// Token: 0x04000885 RID: 2181
		public int LeftSize;

		// Token: 0x04000886 RID: 2182
		public string Pattern = "";

		// Token: 0x04000887 RID: 2183
		public int RightSize;
	}
}

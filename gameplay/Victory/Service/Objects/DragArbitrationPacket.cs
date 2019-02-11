using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000312 RID: 786
	public class DragArbitrationPacket : ArbitrationPacket, IRequestBody
	{
		// Token: 0x06002117 RID: 8471 RVA: 0x0004E998 File Offset: 0x0004D998
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400092A RID: 2346
		public float FractionCompleted;

		// Token: 0x0400092B RID: 2347
		public uint LongestJumpDurationInMilliseconds;

		// Token: 0x0400092C RID: 2348
		public int NumberOfCollisions;

		// Token: 0x0400092D RID: 2349
		public int PerfectStart;

		// Token: 0x0400092E RID: 2350
		public uint SumOfJumpsDurationInMilliseconds;

		// Token: 0x0400092F RID: 2351
		public float TopSpeed;
	}
}

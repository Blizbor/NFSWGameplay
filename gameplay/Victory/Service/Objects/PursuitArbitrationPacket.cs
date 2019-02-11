using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000310 RID: 784
	public class PursuitArbitrationPacket : ArbitrationPacket, IRequestBody
	{
		// Token: 0x06002113 RID: 8467 RVA: 0x0004E958 File Offset: 0x0004D958
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000918 RID: 2328
		public int CopsDeployed;

		// Token: 0x04000919 RID: 2329
		public int CopsDisabled;

		// Token: 0x0400091A RID: 2330
		public int CopsRammed;

		// Token: 0x0400091B RID: 2331
		public int CostToState;

		// Token: 0x0400091C RID: 2332
		public float Heat;

		// Token: 0x0400091D RID: 2333
		public int Infractions;

		// Token: 0x0400091E RID: 2334
		public uint LongestJumpDurationInMilliseconds;

		// Token: 0x0400091F RID: 2335
		public int RoadBlocksDodged;

		// Token: 0x04000920 RID: 2336
		public int SpikeStripsDodged;

		// Token: 0x04000921 RID: 2337
		public uint SumOfJumpsDurationInMilliseconds;

		// Token: 0x04000922 RID: 2338
		public float TopSpeed;
	}
}

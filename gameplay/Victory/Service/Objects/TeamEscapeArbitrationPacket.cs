using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000313 RID: 787
	public class TeamEscapeArbitrationPacket : ArbitrationPacket, IRequestBody
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x0004E9B8 File Offset: 0x0004D9B8
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000930 RID: 2352
		public int BustedCount;

		// Token: 0x04000931 RID: 2353
		public int CopsDeployed;

		// Token: 0x04000932 RID: 2354
		public int CopsDisabled;

		// Token: 0x04000933 RID: 2355
		public int CopsRammed;

		// Token: 0x04000934 RID: 2356
		public int CostToState;

		// Token: 0x04000935 RID: 2357
		public float DistanceToFinish;

		// Token: 0x04000936 RID: 2358
		public float FractionCompleted;

		// Token: 0x04000937 RID: 2359
		public int Infractions;

		// Token: 0x04000938 RID: 2360
		public uint LongestJumpDurationInMilliseconds;

		// Token: 0x04000939 RID: 2361
		public int NumberOfCollisions;

		// Token: 0x0400093A RID: 2362
		public int PerfectStart;

		// Token: 0x0400093B RID: 2363
		public int RoadBlocksDodged;

		// Token: 0x0400093C RID: 2364
		public int SpikeStripsDodged;

		// Token: 0x0400093D RID: 2365
		public uint SumOfJumpsDurationInMilliseconds;

		// Token: 0x0400093E RID: 2366
		public float TopSpeed;
	}
}

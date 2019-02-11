using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000311 RID: 785
	public class RouteArbitrationPacket : ArbitrationPacket, IRequestBody
	{
		// Token: 0x06002115 RID: 8469 RVA: 0x0004E978 File Offset: 0x0004D978
		public override string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000923 RID: 2339
		public uint BestLapDurationInMilliseconds;

		// Token: 0x04000924 RID: 2340
		public float FractionCompleted;

		// Token: 0x04000925 RID: 2341
		public uint LongestJumpDurationInMilliseconds;

		// Token: 0x04000926 RID: 2342
		public int NumberOfCollisions;

		// Token: 0x04000927 RID: 2343
		public int PerfectStart;

		// Token: 0x04000928 RID: 2344
		public uint SumOfJumpsDurationInMilliseconds;

		// Token: 0x04000929 RID: 2345
		public float TopSpeed;
	}
}

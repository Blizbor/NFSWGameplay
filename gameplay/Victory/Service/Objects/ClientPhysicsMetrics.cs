using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200030D RID: 781
	public class ClientPhysicsMetrics : IRequestBody
	{
		// Token: 0x0600210D RID: 8461 RVA: 0x0004E8EC File Offset: 0x0004D8EC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000907 RID: 2311
		public float AccelerationAverage;

		// Token: 0x04000908 RID: 2312
		public float AccelerationMaximum;

		// Token: 0x04000909 RID: 2313
		public float AccelerationMedian;

		// Token: 0x0400090A RID: 2314
		public float SpeedAverage;

		// Token: 0x0400090B RID: 2315
		public float SpeedMaximum;

		// Token: 0x0400090C RID: 2316
		public float SpeedMedian;
	}
}

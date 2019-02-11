using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200030F RID: 783
	public class ArbitrationPacket : IRequestBody
	{
		// Token: 0x06002111 RID: 8465 RVA: 0x0004E938 File Offset: 0x0004D938
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400090F RID: 2319
		public uint AlternateEventDurationInMilliseconds;

		// Token: 0x04000910 RID: 2320
		public long CarId;

		// Token: 0x04000911 RID: 2321
		public uint EventDurationInMilliseconds;

		// Token: 0x04000912 RID: 2322
		public int FinishReason;

		// Token: 0x04000913 RID: 2323
		public FraudDetection FraudDetectionInfo;

		// Token: 0x04000914 RID: 2324
		public uint HacksDetected;

		// Token: 0x04000915 RID: 2325
		public ClientPhysicsMetrics PhysicsMetrics;

		// Token: 0x04000916 RID: 2326
		public int Rank;

		// Token: 0x04000917 RID: 2327
		public SecurityResponse Response;
	}
}

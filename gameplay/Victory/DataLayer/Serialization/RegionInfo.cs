using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002BE RID: 702
	public class RegionInfo : IRequestBody
	{
		// Token: 0x06002081 RID: 8321 RVA: 0x0004D5E0 File Offset: 0x0004C5E0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400078B RID: 1931
		public int CountdownProposalInMilliseconds;

		// Token: 0x0400078C RID: 1932
		public int DirectConnectTimeoutInMilliseconds;

		// Token: 0x0400078D RID: 1933
		public int DropOutTimeInMilliseconds;

		// Token: 0x0400078E RID: 1934
		public int EventLoadTimeoutInMilliseconds;

		// Token: 0x0400078F RID: 1935
		public int HeartbeatIntervalInMilliseconds;

		// Token: 0x04000790 RID: 1936
		public int UdpRelayBandwidthInBps;

		// Token: 0x04000791 RID: 1937
		public int UdpRelayTimeoutInMilliseconds;
	}
}

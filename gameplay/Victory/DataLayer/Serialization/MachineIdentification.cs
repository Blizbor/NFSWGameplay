using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002AE RID: 686
	public class MachineIdentification : IRequestBody
	{
		// Token: 0x06002061 RID: 8289 RVA: 0x0004D218 File Offset: 0x0004C218
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000734 RID: 1844
		public uint cpuID;

		// Token: 0x04000735 RID: 1845
		public string diskSerialNumber = "";

		// Token: 0x04000736 RID: 1846
		public uint gpuID;

		// Token: 0x04000737 RID: 1847
		public long mac;

		// Token: 0x04000738 RID: 1848
		public string machineName = "";

		// Token: 0x04000739 RID: 1849
		public long userID;

		// Token: 0x0400073A RID: 1850
		public string volumeName = "";

		// Token: 0x0400073B RID: 1851
		public uint volumeSerialNumber;
	}
}

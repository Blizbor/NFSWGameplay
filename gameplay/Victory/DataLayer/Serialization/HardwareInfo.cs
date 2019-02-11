using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002AC RID: 684
	public class HardwareInfo : IRequestBody
	{
		// Token: 0x0600205D RID: 8285 RVA: 0x0004D1AC File Offset: 0x0004C1AC
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000710 RID: 1808
		public uint availableMem;

		// Token: 0x04000711 RID: 1809
		public string cpuBrand = "";

		// Token: 0x04000712 RID: 1810
		public string cpuid0 = "";

		// Token: 0x04000713 RID: 1811
		public uint cpuid1_0;

		// Token: 0x04000714 RID: 1812
		public uint cpuid1_1;

		// Token: 0x04000715 RID: 1813
		public uint cpuid1_2;

		// Token: 0x04000716 RID: 1814
		public uint cpuid1_3;

		// Token: 0x04000717 RID: 1815
		public uint deviceID;

		// Token: 0x04000718 RID: 1816
		public uint excpuid1_0;

		// Token: 0x04000719 RID: 1817
		public uint excpuid1_1;

		// Token: 0x0400071A RID: 1818
		public uint excpuid1_2;

		// Token: 0x0400071B RID: 1819
		public uint excpuid1_3;

		// Token: 0x0400071C RID: 1820
		public string gpuDescription = "";

		// Token: 0x0400071D RID: 1821
		public uint gpuDriverBuild;

		// Token: 0x0400071E RID: 1822
		public uint gpuDriverSubversion;

		// Token: 0x0400071F RID: 1823
		public uint gpuDriverVersion;

		// Token: 0x04000720 RID: 1824
		public uint gpuMemory;

		// Token: 0x04000721 RID: 1825
		public uint gpuProduct;

		// Token: 0x04000722 RID: 1826
		public uint osBuildNumber;

		// Token: 0x04000723 RID: 1827
		public uint osMajorVersion;

		// Token: 0x04000724 RID: 1828
		public uint osMinorVersion;

		// Token: 0x04000725 RID: 1829
		public uint physicalCores;

		// Token: 0x04000726 RID: 1830
		public uint platformID;

		// Token: 0x04000727 RID: 1831
		public uint processAffinityMask;

		// Token: 0x04000728 RID: 1832
		public string servicePack = "";

		// Token: 0x04000729 RID: 1833
		public uint systemAffinityMask;

		// Token: 0x0400072A RID: 1834
		public uint totalMemory;

		// Token: 0x0400072B RID: 1835
		public long userID;

		// Token: 0x0400072C RID: 1836
		public uint vendorID;
	}
}

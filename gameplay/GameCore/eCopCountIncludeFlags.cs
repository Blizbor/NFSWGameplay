using System;

namespace GameCore
{
	// Token: 0x02000014 RID: 20
	public enum eCopCountIncludeFlags
	{
		// Token: 0x0400004E RID: 78
		kCountCops_Active_Roadblocks = 1,
		// Token: 0x0400004F RID: 79
		kCountCops_Active_Rhinos,
		// Token: 0x04000050 RID: 80
		kCountCops_Active_Patrols = 4,
		// Token: 0x04000051 RID: 81
		kCountCops_Pending_Roadblocks = 8,
		// Token: 0x04000052 RID: 82
		kCountCops_Pending_Rhinos = 16,
		// Token: 0x04000053 RID: 83
		kCountCops_Pending_Patrols = 32,
		// Token: 0x04000054 RID: 84
		kCountCops_Remote_Roadblocks = 64,
		// Token: 0x04000055 RID: 85
		kCountCops_Remote_Rhinos = 128,
		// Token: 0x04000056 RID: 86
		kCountCops_Remote_Patrols = 256,
		// Token: 0x04000057 RID: 87
		kCountCops_Active_All = 7,
		// Token: 0x04000058 RID: 88
		kCountCops_Pending_All = 56,
		// Token: 0x04000059 RID: 89
		kCountCops_Remote_All = 448,
		// Token: 0x0400005A RID: 90
		kCountCops_Roadblocks_All = 9,
		// Token: 0x0400005B RID: 91
		kCountCops_Rhinos_All = 18,
		// Token: 0x0400005C RID: 92
		kCountCops_Patrols_All = 292
	}
}

using System;

namespace GameCore.Workflow
{
	// Token: 0x02000225 RID: 549
	public enum ActivityExecutionStatus
	{
		// Token: 0x04000562 RID: 1378
		Initialized,
		// Token: 0x04000563 RID: 1379
		Executing,
		// Token: 0x04000564 RID: 1380
		Canceled,
		// Token: 0x04000565 RID: 1381
		Faulting,
		// Token: 0x04000566 RID: 1382
		Faulted,
		// Token: 0x04000567 RID: 1383
		Bookmarked,
		// Token: 0x04000568 RID: 1384
		Closed
	}
}

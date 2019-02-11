using System;

namespace GameCore
{
	// Token: 0x02000007 RID: 7
	public enum OpponentStatus
	{
		// Token: 0x04000003 RID: 3
		kOpponent_Free = 1,
		// Token: 0x04000004 RID: 4
		kOpponent_Joining,
		// Token: 0x04000005 RID: 5
		kOpponent_Ready = 4,
		// Token: 0x04000006 RID: 6
		kOpponent_Queued = 8,
		// Token: 0x04000007 RID: 7
		kOpponent_Competing = 16,
		// Token: 0x04000008 RID: 8
		kOpponent_Disposable = 32,
		// Token: 0x04000009 RID: 9
		kOpponent_Disconnected = 1024,
		// Token: 0x0400000A RID: 10
		kOpponent_Described = 2048,
		// Token: 0x0400000B RID: 11
		kOpponent_Loaded = 4096,
		// Token: 0x0400000C RID: 12
		kOpponent_NotSpectatable = 8192,
		// Token: 0x0400000D RID: 13
		kOpponent_FreeRoam = 16384
	}
}

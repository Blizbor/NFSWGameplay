using System;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D4 RID: 724
	public enum FinishReason
	{
		// Token: 0x040007EB RID: 2027
		Unknown,
		// Token: 0x040007EC RID: 2028
		Completed = 2,
		// Token: 0x040007ED RID: 2029
		Succeeded = 6,
		// Token: 0x040007EE RID: 2030
		DidNotFinish = 10,
		// Token: 0x040007EF RID: 2031
		CrossedFinish = 22,
		// Token: 0x040007F0 RID: 2032
		KnockedOut = 42,
		// Token: 0x040007F1 RID: 2033
		Totalled = 74,
		// Token: 0x040007F2 RID: 2034
		EngineBlown = 138,
		// Token: 0x040007F3 RID: 2035
		Busted = 266,
		// Token: 0x040007F4 RID: 2036
		Evaded = 518,
		// Token: 0x040007F5 RID: 2037
		ChallengeCompleted = 1030,
		// Token: 0x040007F6 RID: 2038
		Disconnected = 2058,
		// Token: 0x040007F7 RID: 2039
		FalseStart = 4106,
		// Token: 0x040007F8 RID: 2040
		Aborted = 8202,
		// Token: 0x040007F9 RID: 2041
		TimedOut = 16394,
		// Token: 0x040007FA RID: 2042
		TimeLimitExpired = 32774,
		// Token: 0x040007FB RID: 2043
		PauseDetected = 65546,
		// Token: 0x040007FC RID: 2044
		SpeedHacking = 131082,
		// Token: 0x040007FD RID: 2045
		CodePatchDetected = 262154,
		// Token: 0x040007FE RID: 2046
		BadVerifierResponse = 524298
	}
}

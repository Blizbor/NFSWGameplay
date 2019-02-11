using System;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002ED RID: 749
	public enum CommerceResultStatus
	{
		// Token: 0x04000865 RID: 2149
		Success,
		// Token: 0x04000866 RID: 2150
		Fail_InvalidBasket = 100,
		// Token: 0x04000867 RID: 2151
		Fail_InsufficientFunds,
		// Token: 0x04000868 RID: 2152
		Fail_InsufficientCarSlots,
		// Token: 0x04000869 RID: 2153
		Fail_MaxStackOrRentalLimit,
		// Token: 0x0400086A RID: 2154
		Fail_InvalidPerformanceUpgrade,
		// Token: 0x0400086B RID: 2155
		Fail_ItemNotAvailableStandalone,
		// Token: 0x0400086C RID: 2156
		Fail_PersonaNotRightLevel,
		// Token: 0x0400086D RID: 2157
		Fail_LockedProductNotAccessibleToThisUser,
		// Token: 0x0400086E RID: 2158
		Fail_BoostTransactionsAreDisabled,
		// Token: 0x0400086F RID: 2159
		Fail_InsufficientPerformancePartInventory,
		// Token: 0x04000870 RID: 2160
		Fail_MaxAllowedPurchasesForThisProduct
	}
}

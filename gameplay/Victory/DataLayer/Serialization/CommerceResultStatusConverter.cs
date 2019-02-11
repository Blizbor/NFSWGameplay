using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002EE RID: 750
	public static class CommerceResultStatusConverter
	{
		// Token: 0x060020D3 RID: 8403 RVA: 0x0004E110 File Offset: 0x0004D110
		static CommerceResultStatusConverter()
		{
			CommerceResultStatusConverter.typeMap["Success"] = CommerceResultStatus.Success;
			CommerceResultStatusConverter.typeMap["Fail_InvalidBasket"] = CommerceResultStatus.Fail_InvalidBasket;
			CommerceResultStatusConverter.typeMap["Fail_InsufficientFunds"] = CommerceResultStatus.Fail_InsufficientFunds;
			CommerceResultStatusConverter.typeMap["Fail_InsufficientCarSlots"] = CommerceResultStatus.Fail_InsufficientCarSlots;
			CommerceResultStatusConverter.typeMap["Fail_MaxStackOrRentalLimit"] = CommerceResultStatus.Fail_MaxStackOrRentalLimit;
			CommerceResultStatusConverter.typeMap["Fail_InvalidPerformanceUpgrade"] = CommerceResultStatus.Fail_InvalidPerformanceUpgrade;
			CommerceResultStatusConverter.typeMap["Fail_ItemNotAvailableStandalone"] = CommerceResultStatus.Fail_ItemNotAvailableStandalone;
			CommerceResultStatusConverter.typeMap["Fail_PersonaNotRightLevel"] = CommerceResultStatus.Fail_PersonaNotRightLevel;
			CommerceResultStatusConverter.typeMap["Fail_LockedProductNotAccessibleToThisUser"] = CommerceResultStatus.Fail_LockedProductNotAccessibleToThisUser;
			CommerceResultStatusConverter.typeMap["Fail_BoostTransactionsAreDisabled"] = CommerceResultStatus.Fail_BoostTransactionsAreDisabled;
			CommerceResultStatusConverter.typeMap["Fail_InsufficientPerformancePartInventory"] = CommerceResultStatus.Fail_InsufficientPerformancePartInventory;
			CommerceResultStatusConverter.typeMap["Fail_MaxAllowedPurchasesForThisProduct"] = CommerceResultStatus.Fail_MaxAllowedPurchasesForThisProduct;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0004E1F2 File Offset: 0x0004D1F2
		public static bool Parse(string str, out CommerceResultStatus value)
		{
			if (CommerceResultStatusConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = CommerceResultStatus.Success;
			return false;
		}

		// Token: 0x04000871 RID: 2161
		private static Dictionary<string, CommerceResultStatus> typeMap = new Dictionary<string, CommerceResultStatus>();
	}
}

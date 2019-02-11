using System;
using System.Collections.Generic;

namespace Victory.Service.Objects
{
	// Token: 0x02000326 RID: 806
	public static class AchievementStateConverter
	{
		// Token: 0x0600213D RID: 8509 RVA: 0x0004ECE0 File Offset: 0x0004DCE0
		static AchievementStateConverter()
		{
			AchievementStateConverter.typeMap["Locked"] = AchievementState.Locked;
			AchievementStateConverter.typeMap["InProgress"] = AchievementState.InProgress;
			AchievementStateConverter.typeMap["RewardWaiting"] = AchievementState.RewardWaiting;
			AchievementStateConverter.typeMap["Completed"] = AchievementState.Completed;
		}

		// Token: 0x0600213E RID: 8510 RVA: 0x0004ED37 File Offset: 0x0004DD37
		public static bool Parse(string str, out AchievementState value)
		{
			if (AchievementStateConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = AchievementState.Locked;
			return false;
		}

		// Token: 0x04000987 RID: 2439
		private static Dictionary<string, AchievementState> typeMap = new Dictionary<string, AchievementState>();
	}
}

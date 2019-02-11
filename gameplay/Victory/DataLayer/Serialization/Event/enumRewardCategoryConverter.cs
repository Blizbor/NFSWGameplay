using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D7 RID: 727
	public static class enumRewardCategoryConverter
	{
		// Token: 0x060020AF RID: 8367 RVA: 0x0004DAA4 File Offset: 0x0004CAA4
		static enumRewardCategoryConverter()
		{
			enumRewardCategoryConverter.typeMap["Base"] = enumRewardCategory.Base;
			enumRewardCategoryConverter.typeMap["Rank"] = enumRewardCategory.Rank;
			enumRewardCategoryConverter.typeMap["Bonus"] = enumRewardCategory.Bonus;
			enumRewardCategoryConverter.typeMap["TeamBonus"] = enumRewardCategory.TeamBonus;
			enumRewardCategoryConverter.typeMap["Amplifier"] = enumRewardCategory.Amplifier;
			enumRewardCategoryConverter.typeMap["Skill"] = enumRewardCategory.Skill;
			enumRewardCategoryConverter.typeMap["Pursuit"] = enumRewardCategory.Pursuit;
			enumRewardCategoryConverter.typeMap["Objective"] = enumRewardCategory.Objective;
			enumRewardCategoryConverter.typeMap["SkillMod"] = enumRewardCategory.SkillMod;
		}

		// Token: 0x060020B0 RID: 8368 RVA: 0x0004DB4B File Offset: 0x0004CB4B
		public static bool Parse(string str, out enumRewardCategory value)
		{
			if (enumRewardCategoryConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = enumRewardCategory.Base;
			return false;
		}

		// Token: 0x0400080A RID: 2058
		private static Dictionary<string, enumRewardCategory> typeMap = new Dictionary<string, enumRewardCategory>();
	}
}

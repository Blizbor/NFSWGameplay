using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D9 RID: 729
	public static class enumRewardTypeConverter
	{
		// Token: 0x060020B1 RID: 8369 RVA: 0x0004DB64 File Offset: 0x0004CB64
		static enumRewardTypeConverter()
		{
			enumRewardTypeConverter.typeMap["None"] = enumRewardType.None;
			enumRewardTypeConverter.typeMap["Busted"] = enumRewardType.Busted;
			enumRewardTypeConverter.typeMap["Evaded"] = enumRewardType.Evaded;
			enumRewardTypeConverter.typeMap["RepAmplifier"] = enumRewardType.RepAmplifier;
			enumRewardTypeConverter.typeMap["TokenAmplifier"] = enumRewardType.TokenAmplifier;
			enumRewardTypeConverter.typeMap["SkillMostWanted"] = enumRewardType.SkillMostWanted;
			enumRewardTypeConverter.typeMap["SkillSocialite"] = enumRewardType.SkillSocialite;
			enumRewardTypeConverter.typeMap["SkillTycoon"] = enumRewardType.SkillTycoon;
			enumRewardTypeConverter.typeMap["SkillTerminator"] = enumRewardType.SkillTerminator;
			enumRewardTypeConverter.typeMap["HeatLevel"] = enumRewardType.HeatLevel;
			enumRewardTypeConverter.typeMap["PursuitLength"] = enumRewardType.PursuitLength;
			enumRewardTypeConverter.typeMap["Bounty"] = enumRewardType.Bounty;
			enumRewardTypeConverter.typeMap["CopCarsDeployed"] = enumRewardType.CopCarsDeployed;
			enumRewardTypeConverter.typeMap["CopCarsRammed"] = enumRewardType.CopCarsRammed;
			enumRewardTypeConverter.typeMap["CopCarsDisabled"] = enumRewardType.CopCarsDisabled;
			enumRewardTypeConverter.typeMap["RhinosDisabled"] = enumRewardType.RhinosDisabled;
			enumRewardTypeConverter.typeMap["CostToState"] = enumRewardType.CostToState;
			enumRewardTypeConverter.typeMap["RoadblocksDodged"] = enumRewardType.RoadblocksDodged;
			enumRewardTypeConverter.typeMap["SpikeStripsDodged"] = enumRewardType.SpikeStripsDodged;
			enumRewardTypeConverter.typeMap["Infractions"] = enumRewardType.Infractions;
			enumRewardTypeConverter.typeMap["LevelCap"] = enumRewardType.LevelCap;
			enumRewardTypeConverter.typeMap["EntitlementLevelCap"] = enumRewardType.EntitlementLevelCap;
			enumRewardTypeConverter.typeMap["TopenCap"] = enumRewardType.TopenCap;
			enumRewardTypeConverter.typeMap["SafehouseReached"] = enumRewardType.SafehouseReached;
			enumRewardTypeConverter.typeMap["Finished"] = enumRewardType.Finished;
			enumRewardTypeConverter.typeMap["TimeBonus"] = enumRewardType.TimeBonus;
			enumRewardTypeConverter.typeMap["Player1"] = enumRewardType.Player1;
			enumRewardTypeConverter.typeMap["Player2"] = enumRewardType.Player2;
			enumRewardTypeConverter.typeMap["Player3"] = enumRewardType.Player3;
			enumRewardTypeConverter.typeMap["Player4"] = enumRewardType.Player4;
			enumRewardTypeConverter.typeMap["StrikeFree"] = enumRewardType.StrikeFree;
			enumRewardTypeConverter.typeMap["TeamStrikeBonus"] = enumRewardType.TeamStrikeBonus;
			enumRewardTypeConverter.typeMap["PowerupBonus"] = enumRewardType.PowerupBonus;
			enumRewardTypeConverter.typeMap["SkillMod"] = enumRewardType.SkillMod;
		}

		// Token: 0x060020B2 RID: 8370 RVA: 0x0004DDB4 File Offset: 0x0004CDB4
		public static bool Parse(string str, out enumRewardType value)
		{
			if (enumRewardTypeConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = enumRewardType.None;
			return false;
		}

		// Token: 0x0400082E RID: 2094
		private static Dictionary<string, enumRewardType> typeMap = new Dictionary<string, enumRewardType>();
	}
}

using System;
using System.Collections.Generic;

namespace Victory.Data.Objects.Customization
{
	// Token: 0x02000292 RID: 658
	public static class SkillModEffectTypeConverter
	{
		// Token: 0x0600202C RID: 8236 RVA: 0x0004CBEC File Offset: 0x0004BBEC
		static SkillModEffectTypeConverter()
		{
			SkillModEffectTypeConverter.typeMap["None"] = SkillModEffectType.None;
			SkillModEffectTypeConverter.typeMap["CashRewardExplore"] = SkillModEffectType.CashRewardExplore;
			SkillModEffectTypeConverter.typeMap["PowerupCooldown"] = SkillModEffectType.PowerupCooldown;
			SkillModEffectTypeConverter.typeMap["PowerupDuration"] = SkillModEffectType.PowerupDuration;
			SkillModEffectTypeConverter.typeMap["PowerupPower"] = SkillModEffectType.PowerupPower;
			SkillModEffectTypeConverter.typeMap["CatchUp"] = SkillModEffectType.CatchUp;
			SkillModEffectTypeConverter.typeMap["CollisionMass"] = SkillModEffectType.CollisionMass;
			SkillModEffectTypeConverter.typeMap["HeavyMass"] = SkillModEffectType.HeavyMass;
			SkillModEffectTypeConverter.typeMap["JumpStart"] = SkillModEffectType.JumpStart;
			SkillModEffectTypeConverter.typeMap["EvadeMeter"] = SkillModEffectType.EvadeMeter;
			SkillModEffectTypeConverter.typeMap["PerfectStartRange"] = SkillModEffectType.PerfectStartRange;
			SkillModEffectTypeConverter.typeMap["Radar"] = SkillModEffectType.Radar;
			SkillModEffectTypeConverter.typeMap["TreasureHunter"] = SkillModEffectType.TreasureHunter;
			SkillModEffectTypeConverter.typeMap["OneMoreLapPerformance"] = SkillModEffectType.OneMoreLapPerformance;
			SkillModEffectTypeConverter.typeMap["EmergencyEvadeRange"] = SkillModEffectType.EmergencyEvadeRange;
			SkillModEffectTypeConverter.typeMap["CooldownMeter"] = SkillModEffectType.CooldownMeter;
			SkillModEffectTypeConverter.typeMap["PerfectStartDuration"] = SkillModEffectType.PerfectStartDuration;
			SkillModEffectTypeConverter.typeMap["CashRewardPursuit"] = SkillModEffectType.CashRewardPursuit;
			SkillModEffectTypeConverter.typeMap["CashRewardRace"] = SkillModEffectType.CashRewardRace;
			SkillModEffectTypeConverter.typeMap["GearRatioEnhancement"] = SkillModEffectType.GearRatioEnhancement;
			SkillModEffectTypeConverter.typeMap["LaunchGrip"] = SkillModEffectType.LaunchGrip;
			SkillModEffectTypeConverter.typeMap["AeroDragReduction"] = SkillModEffectType.AeroDragReduction;
			SkillModEffectTypeConverter.typeMap["QuickShift"] = SkillModEffectType.QuickShift;
			SkillModEffectTypeConverter.typeMap["QuickLaneChange"] = SkillModEffectType.QuickLaneChange;
		}

		// Token: 0x0600202D RID: 8237 RVA: 0x0004CD92 File Offset: 0x0004BD92
		public static bool Parse(string str, out SkillModEffectType value)
		{
			if (SkillModEffectTypeConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = SkillModEffectType.None;
			return false;
		}

		// Token: 0x040006A1 RID: 1697
		private static Dictionary<string, SkillModEffectType> typeMap = new Dictionary<string, SkillModEffectType>();
	}
}

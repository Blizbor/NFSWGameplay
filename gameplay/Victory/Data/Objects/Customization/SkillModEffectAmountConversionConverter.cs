using System;
using System.Collections.Generic;

namespace Victory.Data.Objects.Customization
{
	// Token: 0x02000294 RID: 660
	public static class SkillModEffectAmountConversionConverter
	{
		// Token: 0x0600202E RID: 8238 RVA: 0x0004CDA8 File Offset: 0x0004BDA8
		static SkillModEffectAmountConversionConverter()
		{
			SkillModEffectAmountConversionConverter.typeMap["None"] = SkillModEffectAmountConversion.None;
			SkillModEffectAmountConversionConverter.typeMap["Metres2Feet"] = SkillModEffectAmountConversion.Metres2Feet;
		}

		// Token: 0x0600202F RID: 8239 RVA: 0x0004CDD4 File Offset: 0x0004BDD4
		public static bool Parse(string str, out SkillModEffectAmountConversion value)
		{
			if (SkillModEffectAmountConversionConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = SkillModEffectAmountConversion.None;
			return false;
		}

		// Token: 0x040006A5 RID: 1701
		private static Dictionary<string, SkillModEffectAmountConversion> typeMap = new Dictionary<string, SkillModEffectAmountConversion>();
	}
}

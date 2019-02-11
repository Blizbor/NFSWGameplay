using System;
using System.Collections.Generic;

namespace Victory.Service.Objects
{
	// Token: 0x02000328 RID: 808
	public static class StatConversionConverter
	{
		// Token: 0x0600213F RID: 8511 RVA: 0x0004ED50 File Offset: 0x0004DD50
		static StatConversionConverter()
		{
			StatConversionConverter.typeMap["None"] = StatConversion.None;
			StatConversionConverter.typeMap["FromMillisecondsToMinutes"] = StatConversion.FromMillisecondsToMinutes;
			StatConversionConverter.typeMap["FromSecondsToMinutes"] = StatConversion.FromSecondsToMinutes;
			StatConversionConverter.typeMap["FromCentimetersPerSecondToSpeed"] = StatConversion.FromCentimetersPerSecondToSpeed;
			StatConversionConverter.typeMap["FromMetersToDistance"] = StatConversion.FromMetersToDistance;
			StatConversionConverter.typeMap["FromNumberToCurrency"] = StatConversion.FromNumberToCurrency;
		}

		// Token: 0x06002140 RID: 8512 RVA: 0x0004EDC7 File Offset: 0x0004DDC7
		public static bool Parse(string str, out StatConversion value)
		{
			if (StatConversionConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = StatConversion.None;
			return false;
		}

		// Token: 0x0400098F RID: 2447
		private static Dictionary<string, StatConversion> typeMap = new Dictionary<string, StatConversion>();
	}
}

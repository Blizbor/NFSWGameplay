using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002EA RID: 746
	public static class MetagameFlagsConverter
	{
		// Token: 0x060020CF RID: 8399 RVA: 0x0004DFDA File Offset: 0x0004CFDA
		static MetagameFlagsConverter()
		{
			MetagameFlagsConverter.typeMap["RaceNowEnabled"] = MetagameFlags.RaceNowEnabled;
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x0004DFF6 File Offset: 0x0004CFF6
		public static bool Parse(string str, out MetagameFlags value)
		{
			if (MetagameFlagsConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = MetagameFlags.RaceNowEnabled;
			return false;
		}

		// Token: 0x04000854 RID: 2132
		private static Dictionary<string, MetagameFlags> typeMap = new Dictionary<string, MetagameFlags>();
	}
}

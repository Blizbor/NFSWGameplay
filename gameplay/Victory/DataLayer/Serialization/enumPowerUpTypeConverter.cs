using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002EC RID: 748
	public static class enumPowerUpTypeConverter
	{
		// Token: 0x060020D1 RID: 8401 RVA: 0x0004E00C File Offset: 0x0004D00C
		static enumPowerUpTypeConverter()
		{
			enumPowerUpTypeConverter.typeMap["None"] = enumPowerUpType.None;
			enumPowerUpTypeConverter.typeMap["EmergencyEvade"] = enumPowerUpType.EmergencyEvade;
			enumPowerUpTypeConverter.typeMap["InstantCooldown"] = enumPowerUpType.InstantCooldown;
			enumPowerUpTypeConverter.typeMap["Juggernaut"] = enumPowerUpType.Juggernaut;
			enumPowerUpTypeConverter.typeMap["NosShot"] = enumPowerUpType.NosShot;
			enumPowerUpTypeConverter.typeMap["OneMoreLap"] = enumPowerUpType.OneMoreLap;
			enumPowerUpTypeConverter.typeMap["Ready"] = enumPowerUpType.Ready;
			enumPowerUpTypeConverter.typeMap["RunFlatTires"] = enumPowerUpType.RunFlatTires;
			enumPowerUpTypeConverter.typeMap["Shield"] = enumPowerUpType.Shield;
			enumPowerUpTypeConverter.typeMap["Slingshot"] = enumPowerUpType.Slingshot;
			enumPowerUpTypeConverter.typeMap["TeamEmergencyEvade"] = enumPowerUpType.TeamEmergencyEvade;
			enumPowerUpTypeConverter.typeMap["TeamSlingshot"] = enumPowerUpType.TeamSlingshot;
			enumPowerUpTypeConverter.typeMap["TrafficMagnet"] = enumPowerUpType.TrafficMagnet;
		}

		// Token: 0x060020D2 RID: 8402 RVA: 0x0004E0F7 File Offset: 0x0004D0F7
		public static bool Parse(string str, out enumPowerUpType value)
		{
			if (enumPowerUpTypeConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = enumPowerUpType.None;
			return false;
		}

		// Token: 0x04000863 RID: 2147
		private static Dictionary<string, enumPowerUpType> typeMap = new Dictionary<string, enumPowerUpType>();
	}
}

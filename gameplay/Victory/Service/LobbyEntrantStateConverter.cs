using System;
using System.Collections.Generic;

namespace Victory.Service
{
	// Token: 0x0200032A RID: 810
	public static class LobbyEntrantStateConverter
	{
		// Token: 0x06002141 RID: 8513 RVA: 0x0004EDE0 File Offset: 0x0004DDE0
		static LobbyEntrantStateConverter()
		{
			LobbyEntrantStateConverter.typeMap["Unknown"] = LobbyEntrantState.Unknown;
			LobbyEntrantStateConverter.typeMap["InFreeRoam"] = LobbyEntrantState.InFreeRoam;
			LobbyEntrantStateConverter.typeMap["InLobby"] = LobbyEntrantState.InLobby;
			LobbyEntrantStateConverter.typeMap["InEvent"] = LobbyEntrantState.InEvent;
			LobbyEntrantStateConverter.typeMap["InPostEvent"] = LobbyEntrantState.InPostEvent;
		}

		// Token: 0x06002142 RID: 8514 RVA: 0x0004EE47 File Offset: 0x0004DE47
		public static bool Parse(string str, out LobbyEntrantState value)
		{
			if (LobbyEntrantStateConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = LobbyEntrantState.Unknown;
			return false;
		}

		// Token: 0x04000996 RID: 2454
		private static Dictionary<string, LobbyEntrantState> typeMap = new Dictionary<string, LobbyEntrantState>();
	}
}

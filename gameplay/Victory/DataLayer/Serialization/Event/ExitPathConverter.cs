using System;
using System.Collections.Generic;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002DB RID: 731
	public static class ExitPathConverter
	{
		// Token: 0x060020B3 RID: 8371 RVA: 0x0004DDCA File Offset: 0x0004CDCA
		static ExitPathConverter()
		{
			ExitPathConverter.typeMap["ExitToFreeroam"] = ExitPath.ExitToFreeroam;
			ExitPathConverter.typeMap["ExitToLobby"] = ExitPath.ExitToLobby;
		}

		// Token: 0x060020B4 RID: 8372 RVA: 0x0004DDF6 File Offset: 0x0004CDF6
		public static bool Parse(string str, out ExitPath value)
		{
			if (ExitPathConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = ExitPath.ExitToFreeroam;
			return false;
		}

		// Token: 0x04000832 RID: 2098
		private static Dictionary<string, ExitPath> typeMap = new Dictionary<string, ExitPath>();
	}
}

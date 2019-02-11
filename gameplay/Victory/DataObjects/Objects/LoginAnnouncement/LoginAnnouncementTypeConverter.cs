using System;
using System.Collections.Generic;

namespace Victory.DataObjects.Objects.LoginAnnouncement
{
	// Token: 0x020002F2 RID: 754
	public static class LoginAnnouncementTypeConverter
	{
		// Token: 0x060020D7 RID: 8407 RVA: 0x0004E2A8 File Offset: 0x0004D2A8
		static LoginAnnouncementTypeConverter()
		{
			LoginAnnouncementTypeConverter.typeMap["ExternalLink"] = LoginAnnouncementType.ExternalLink;
			LoginAnnouncementTypeConverter.typeMap["SafehouseProduct"] = LoginAnnouncementType.SafehouseProduct;
			LoginAnnouncementTypeConverter.typeMap["ImageOnly"] = LoginAnnouncementType.ImageOnly;
			LoginAnnouncementTypeConverter.typeMap["SafehouseProductNoButton"] = LoginAnnouncementType.SafehouseProductNoButton;
			LoginAnnouncementTypeConverter.typeMap["ExternalLinkNoButton"] = LoginAnnouncementType.ExternalLinkNoButton;
		}

		// Token: 0x060020D8 RID: 8408 RVA: 0x0004E30F File Offset: 0x0004D30F
		public static bool Parse(string str, out LoginAnnouncementType value)
		{
			if (LoginAnnouncementTypeConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = LoginAnnouncementType.ExternalLink;
			return false;
		}

		// Token: 0x04000881 RID: 2177
		private static Dictionary<string, LoginAnnouncementType> typeMap = new Dictionary<string, LoginAnnouncementType>();
	}
}

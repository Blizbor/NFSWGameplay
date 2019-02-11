using System;
using System.Collections.Generic;

namespace Victory.DataObjects.Objects.LoginAnnouncement
{
	// Token: 0x020002F0 RID: 752
	public static class LoginAnnouncementContextConverter
	{
		// Token: 0x060020D5 RID: 8405 RVA: 0x0004E208 File Offset: 0x0004D208
		static LoginAnnouncementContextConverter()
		{
			LoginAnnouncementContextConverter.typeMap["NotApplicable"] = LoginAnnouncementContext.NotApplicable;
			LoginAnnouncementContextConverter.typeMap["CarPurchase"] = LoginAnnouncementContext.CarPurchase;
			LoginAnnouncementContextConverter.typeMap["CardsPack"] = LoginAnnouncementContext.CardsPack;
			LoginAnnouncementContextConverter.typeMap["PaintShop"] = LoginAnnouncementContext.PaintShop;
			LoginAnnouncementContextConverter.typeMap["PerformanceShop"] = LoginAnnouncementContext.PerformanceShop;
			LoginAnnouncementContextConverter.typeMap["AftermarketShop"] = LoginAnnouncementContext.AftermarketShop;
			LoginAnnouncementContextConverter.typeMap["VinylShop"] = LoginAnnouncementContext.VinylShop;
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x0004E28F File Offset: 0x0004D28F
		public static bool Parse(string str, out LoginAnnouncementContext value)
		{
			if (LoginAnnouncementContextConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = LoginAnnouncementContext.NotApplicable;
			return false;
		}

		// Token: 0x0400087A RID: 2170
		private static Dictionary<string, LoginAnnouncementContext> typeMap = new Dictionary<string, LoginAnnouncementContext>();
	}
}

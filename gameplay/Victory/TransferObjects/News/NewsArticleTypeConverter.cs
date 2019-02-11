using System;
using System.Collections.Generic;

namespace Victory.TransferObjects.News
{
	// Token: 0x02000335 RID: 821
	public static class NewsArticleTypeConverter
	{
		// Token: 0x06002155 RID: 8533 RVA: 0x0004EFD4 File Offset: 0x0004DFD4
		static NewsArticleTypeConverter()
		{
			NewsArticleTypeConverter.typeMap["NullNews"] = NewsArticleType.NullNews;
			NewsArticleTypeConverter.typeMap["FriendRequestReceived"] = NewsArticleType.FriendRequestReceived;
			NewsArticleTypeConverter.typeMap["FriendLeveledUp"] = NewsArticleType.FriendLeveledUp;
			NewsArticleTypeConverter.typeMap["TopSpeedEclipsed"] = NewsArticleType.TopSpeedEclipsed;
			NewsArticleTypeConverter.typeMap["LongestPursuitEclipsed"] = NewsArticleType.LongestPursuitEclipsed;
			NewsArticleTypeConverter.typeMap["TotalCostToStateEclipsed"] = NewsArticleType.TotalCostToStateEclipsed;
			NewsArticleTypeConverter.typeMap["WelcomeMessage"] = NewsArticleType.WelcomeMessage;
			NewsArticleTypeConverter.typeMap["AutoRejectedFriendRequest"] = NewsArticleType.AutoRejectedFriendRequest;
			NewsArticleTypeConverter.typeMap["DynamicNews"] = NewsArticleType.DynamicNews;
			NewsArticleTypeConverter.typeMap["RareItemWonLuckyDraw"] = NewsArticleType.RareItemWonLuckyDraw;
			NewsArticleTypeConverter.typeMap["RareItemWonCardPack"] = NewsArticleType.RareItemWonCardPack;
			NewsArticleTypeConverter.typeMap["RepAmplifierExpiring"] = NewsArticleType.RepAmplifierExpiring;
			NewsArticleTypeConverter.typeMap["RepAmplifierExpired"] = NewsArticleType.RepAmplifierExpired;
			NewsArticleTypeConverter.typeMap["CashAmplifierExpiring"] = NewsArticleType.CashAmplifierExpiring;
			NewsArticleTypeConverter.typeMap["CashAmplifierExpired"] = NewsArticleType.CashAmplifierExpired;
			NewsArticleTypeConverter.typeMap["CarRentalExpired"] = NewsArticleType.CarRentalExpired;
			NewsArticleTypeConverter.typeMap["CarInsuranceExpiring"] = NewsArticleType.CarInsuranceExpiring;
			NewsArticleTypeConverter.typeMap["CarInsuranceExpired"] = NewsArticleType.CarInsuranceExpired;
			NewsArticleTypeConverter.typeMap["UnopenedGift"] = NewsArticleType.UnopenedGift;
			NewsArticleTypeConverter.typeMap["RareItemWonStreak"] = NewsArticleType.RareItemWonStreak;
			NewsArticleTypeConverter.typeMap["StreakMilestone"] = NewsArticleType.StreakMilestone;
			NewsArticleTypeConverter.typeMap["CarClassChanged"] = NewsArticleType.CarClassChanged;
			NewsArticleTypeConverter.typeMap["ReferralBoostGiftAwarded"] = NewsArticleType.ReferralBoostGiftAwarded;
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0004F16A File Offset: 0x0004E16A
		public static bool Parse(string str, out NewsArticleType value)
		{
			if (NewsArticleTypeConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = NewsArticleType.NullNews;
			return false;
		}

		// Token: 0x040009CD RID: 2509
		private static Dictionary<string, NewsArticleType> typeMap = new Dictionary<string, NewsArticleType>();
	}
}

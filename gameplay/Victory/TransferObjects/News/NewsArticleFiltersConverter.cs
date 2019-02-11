using System;
using System.Collections.Generic;

namespace Victory.TransferObjects.News
{
	// Token: 0x02000337 RID: 823
	public static class NewsArticleFiltersConverter
	{
		// Token: 0x06002157 RID: 8535 RVA: 0x0004F180 File Offset: 0x0004E180
		static NewsArticleFiltersConverter()
		{
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_None"] = NewsArticleFilters.NEWSFILTERMASK_None;
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_Me"] = NewsArticleFilters.NEWSFILTERMASK_Me;
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_Friends"] = NewsArticleFilters.NEWSFILTERMASK_Friends;
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_System"] = NewsArticleFilters.NEWSFILTERMASK_System;
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_Crew"] = NewsArticleFilters.NEWSFILTERMASK_Crew;
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_All"] = NewsArticleFilters.NEWSFILTERMASK_All;
			NewsArticleFiltersConverter.typeMap["NEWSFILTERMASK_ITEM_COUNT"] = NewsArticleFilters.NEWSFILTERMASK_ITEM_COUNT;
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0004F20B File Offset: 0x0004E20B
		public static bool Parse(string str, out NewsArticleFilters value)
		{
			if (NewsArticleFiltersConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = NewsArticleFilters.NEWSFILTERMASK_None;
			return false;
		}

		// Token: 0x040009D6 RID: 2518
		private static Dictionary<string, NewsArticleFilters> typeMap = new Dictionary<string, NewsArticleFilters>();
	}
}

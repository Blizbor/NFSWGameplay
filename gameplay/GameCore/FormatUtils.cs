using System;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000239 RID: 569
	internal class FormatUtils
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x0002939C File Offset: 0x0002839C
		public static string FormatLapTime(float seconds)
		{
			TimeSpan timeSpan = TimeSpan.FromSeconds((double)seconds);
			return string.Format(FormatUtils.format_string, timeSpan.Minutes, timeSpan.Seconds, timeSpan.Milliseconds);
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000293E0 File Offset: 0x000283E0
		public static string FormatDistance(float distance)
		{
			string localizedString;
			if (Marshal.Get().GetIsMetricUnits())
			{
				localizedString = Localizer.GetLocalizedString("TXT_CMN_DISTANCE_METERS");
			}
			else
			{
				distance = Conversions.METERS2FT(distance);
				localizedString = Localizer.GetLocalizedString("TXT_CMN_DISTANCE_FEET");
			}
			return string.Format(localizedString, distance);
		}

		// Token: 0x040005A1 RID: 1441
		private static string format_string = Localizer.GetLocalizedString("ID_COMMON_LAP_TIME_FORMAT");
	}
}

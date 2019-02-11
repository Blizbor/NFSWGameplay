using System;
using Interop;

namespace GameCore
{
	// Token: 0x02000255 RID: 597
	public static class TimeSpan
	{
		// Token: 0x06001817 RID: 6167 RVA: 0x0002AF40 File Offset: 0x00029F40
		public static void Fill(this System.TimeSpan span, Interop.TimeSpan time)
		{
			if (null != time)
			{
				time.Hours = span.Hours;
				time.Minutes = span.Minutes;
				time.Seconds = span.Seconds;
				time.Milliseconds = span.Milliseconds;
				time.TotalSeconds = span.TotalSeconds;
			}
		}
	}
}

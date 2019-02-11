using System;
using EASharp;

namespace GameCore
{
	// Token: 0x020001F4 RID: 500
	[Export]
	public class TimeFlasher : FlasherBase
	{
		// Token: 0x06001521 RID: 5409 RVA: 0x000259AD File Offset: 0x000249AD
		public TimeFlasher(uint collection_key, float time) : base(collection_key)
		{
			this.mMessage = string.Format(base.Message, FormatUtils.FormatLapTime(time));
		}
	}
}

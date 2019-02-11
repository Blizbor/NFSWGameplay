using System;
using EASharp;
using Interop;

namespace GameCore
{
	// Token: 0x020001EE RID: 494
	[Export]
	internal class HeatLevelFlasher : FlasherBase
	{
		// Token: 0x06001518 RID: 5400 RVA: 0x00025618 File Offset: 0x00024618
		public HeatLevelFlasher(uint heat_level_key) : base(635214959u)
		{
			this.HeatLevel = heat_level_key;
		}

		// Token: 0x06001519 RID: 5401 RVA: 0x0002562C File Offset: 0x0002462C
		public override FrontendFlasher CreateFrontendFlasherObj()
		{
			FrontendFlasher frontendFlasher = new FrontendFlasher();
			frontendFlasher.mId = base.Id;
			frontendFlasher.SetMessage(base.Message);
			frontendFlasher.SetClipName(base.ClipName);
			frontendFlasher.vAlign = base.vAlign;
			frontendFlasher.HeatLevel = this.HeatLevel;
			return frontendFlasher;
		}

		// Token: 0x04000501 RID: 1281
		private uint HeatLevel;
	}
}

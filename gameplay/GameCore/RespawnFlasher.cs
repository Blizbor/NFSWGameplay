using System;
using EASharp;
using Interop;

namespace GameCore
{
	// Token: 0x020001F1 RID: 497
	[Export]
	public class RespawnFlasher : FlasherBase
	{
		// Token: 0x0600151C RID: 5404 RVA: 0x0002580E File Offset: 0x0002480E
		public RespawnFlasher(float time_ms) : base(2369306023u)
		{
			this.mTimer = time_ms;
			base.FlasherIntroComplete += this.RespawnFlasher_OnFlasherIntroComplete;
		}

		// Token: 0x0600151D RID: 5405 RVA: 0x00025834 File Offset: 0x00024834
		private void RespawnFlasher_OnFlasherIntroComplete(object sender, EventArgs e)
		{
			FlasherManager.Get().DequeueFlasher(base.Id);
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x00025848 File Offset: 0x00024848
		public override FrontendFlasher CreateFrontendFlasherObj()
		{
			FrontendFlasher frontendFlasher = new FrontendFlasher();
			frontendFlasher.mId = base.Id;
			frontendFlasher.SetMessage(base.Message);
			frontendFlasher.SetClipName(base.ClipName);
			frontendFlasher.vAlign = base.vAlign;
			frontendFlasher.Timer = this.mTimer;
			return frontendFlasher;
		}

		// Token: 0x04000502 RID: 1282
		private readonly float mTimer;
	}
}

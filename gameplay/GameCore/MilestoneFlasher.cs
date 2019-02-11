using System;
using EASharp;

namespace GameCore
{
	// Token: 0x020001EF RID: 495
	[Export]
	public class MilestoneFlasher : FlasherBase
	{
		// Token: 0x0600151A RID: 5402 RVA: 0x0002567C File Offset: 0x0002467C
		public MilestoneFlasher(string hal_id, uint milestone_count) : base(1618023310u)
		{
			this.mMessage = hal_id + "," + milestone_count.ToString();
		}
	}
}

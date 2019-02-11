using System;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000163 RID: 355
	public class WaitForLoading : SimulationTick
	{
		// Token: 0x060012EF RID: 4847 RVA: 0x0001B2D6 File Offset: 0x0001A2D6
		public WaitForLoading(float period) : base(period)
		{
		}

		// Token: 0x060012F0 RID: 4848 RVA: 0x0001B2DF File Offset: 0x0001A2DF
		protected override void OnExecute(ActivityExecutionContext context)
		{
			LoadingMonitor.RefreshTrackLoading();
		}

		// Token: 0x060012F1 RID: 4849 RVA: 0x0001B2E6 File Offset: 0x0001A2E6
		protected override void Tick(float dT)
		{
			if (!LoadingMonitor.IsLoading())
			{
				this.Close();
			}
		}
	}
}

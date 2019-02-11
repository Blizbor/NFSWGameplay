using System;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000150 RID: 336
	public class ReadySync : SimulationTick
	{
		// Token: 0x06001298 RID: 4760 RVA: 0x0001ABF0 File Offset: 0x00019BF0
		public ReadySync(float period) : base(period)
		{
		}

		// Token: 0x06001299 RID: 4761 RVA: 0x0001ABF9 File Offset: 0x00019BF9
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x0600129A RID: 4762 RVA: 0x0001ABFB File Offset: 0x00019BFB
		protected override void Tick(float dT)
		{
			if (LoadingMonitor.ReachedCountdownTime())
			{
				base.Close();
			}
		}
	}
}

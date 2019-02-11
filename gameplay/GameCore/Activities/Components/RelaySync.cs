using System;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000154 RID: 340
	public class RelaySync : SimulationTick
	{
		// Token: 0x060012A4 RID: 4772 RVA: 0x0001AC48 File Offset: 0x00019C48
		public RelaySync(float period) : base(period)
		{
		}

		// Token: 0x060012A5 RID: 4773 RVA: 0x0001AC51 File Offset: 0x00019C51
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060012A6 RID: 4774 RVA: 0x0001AC53 File Offset: 0x00019C53
		protected override void Tick(float dT)
		{
			if (LoadingMonitor.RelayReady())
			{
				base.Close();
			}
		}
	}
}

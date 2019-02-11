using System;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000147 RID: 327
	public class IsStuckInLobby : SimulationTick
	{
		// Token: 0x0600127C RID: 4732 RVA: 0x0001AA22 File Offset: 0x00019A22
		public IsStuckInLobby(float period) : base(period)
		{
		}

		// Token: 0x0600127D RID: 4733 RVA: 0x0001AA2B File Offset: 0x00019A2B
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x0600127E RID: 4734 RVA: 0x0001AA2D File Offset: 0x00019A2D
		protected override void Tick(float dT)
		{
			if (InternalLobby.Get().IsStuck(dT))
			{
				this.Close();
			}
		}
	}
}

using System;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x0200014A RID: 330
	public class LobbyTick : SimulationTick
	{
		// Token: 0x06001287 RID: 4743 RVA: 0x0001AA9B File Offset: 0x00019A9B
		public LobbyTick(float period) : base(period)
		{
		}

		// Token: 0x06001288 RID: 4744 RVA: 0x0001AAA4 File Offset: 0x00019AA4
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001289 RID: 4745 RVA: 0x0001AAA6 File Offset: 0x00019AA6
		protected override void Tick(float dT)
		{
			InternalLobby.Get().Tick(dT);
		}
	}
}

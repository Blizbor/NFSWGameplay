using System;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000189 RID: 393
	public class OnUpdateTick : SimulationTick
	{
		// Token: 0x0600137F RID: 4991 RVA: 0x0001C415 File Offset: 0x0001B415
		public OnUpdateTick(Event @event, EntrantInfo entrant) : base(@event, entrant, 0.1f)
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0001C424 File Offset: 0x0001B424
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0001C426 File Offset: 0x0001B426
		protected override void Tick(float dT)
		{
			base.Entrant.OnUpdate(base.Event, dT);
		}
	}
}

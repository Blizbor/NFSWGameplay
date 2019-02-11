using System;
using GameCore.Workflow;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000177 RID: 375
	public class EntrantDisconnected : SimulationTick
	{
		// Token: 0x0600133E RID: 4926 RVA: 0x0001BC4F File Offset: 0x0001AC4F
		public EntrantDisconnected(InstancedEvent @event, EntrantInfo entrant) : base(@event, entrant, 0.1f)
		{
		}

		// Token: 0x0600133F RID: 4927 RVA: 0x0001BC5E File Offset: 0x0001AC5E
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001340 RID: 4928 RVA: 0x0001BC60 File Offset: 0x0001AC60
		protected override void Tick(float dT)
		{
			if (base.Entrant.Opponent.IsStatus(OpponentStatus.kOpponent_Disconnected))
			{
				base.Entrant.Opponent.Vehicle.Deactivate();
				base.Entrant.ScoringState.FinishReason = FinishReason.Disconnected;
				base.Entrant.ScoringState.HasArbitrated = true;
			}
		}
	}
}

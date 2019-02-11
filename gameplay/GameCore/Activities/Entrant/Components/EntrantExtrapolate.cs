using System;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000178 RID: 376
	public class EntrantExtrapolate : MessageHandler<OnExtrapolate>
	{
		// Token: 0x06001341 RID: 4929 RVA: 0x0001BCBF File Offset: 0x0001ACBF
		public EntrantExtrapolate(InstancedEvent @event, EntrantInfo entrant, uint port) : base(@event, entrant, port)
		{
		}

		// Token: 0x06001342 RID: 4930 RVA: 0x0001BCCA File Offset: 0x0001ACCA
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001343 RID: 4931 RVA: 0x0001BCCC File Offset: 0x0001ACCC
		protected override void OnMessage(OnExtrapolate message)
		{
			if (base.Entrant.Opponent is LocalArtificalOpponent)
			{
				base.Entrant.ScoringState.FinishReason = FinishReason.DidNotFinish;
			}
		}
	}
}

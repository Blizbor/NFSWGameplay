using System;
using GameCore.Messages;
using GameCore.Workflow;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200017C RID: 380
	public class EntrantInterupt : MessageHandler<OnInterupt>
	{
		// Token: 0x06001353 RID: 4947 RVA: 0x0001BEA4 File Offset: 0x0001AEA4
		public EntrantInterupt(InstancedEvent @event, EntrantInfo entrant, uint port, FinishReason finishReason) : base(@event, entrant, port)
		{
			this.finishReason = finishReason;
		}

		// Token: 0x06001354 RID: 4948 RVA: 0x0001BEB7 File Offset: 0x0001AEB7
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001355 RID: 4949 RVA: 0x0001BEB9 File Offset: 0x0001AEB9
		protected override void OnMessage(OnInterupt message)
		{
			base.Entrant.ScoringState.FinishReason = this.finishReason;
		}

		// Token: 0x04000483 RID: 1155
		private readonly FinishReason finishReason;
	}
}

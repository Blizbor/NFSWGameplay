using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C7 RID: 455
	public class OrderGrid : Component<InstancedEvent>
	{
		// Token: 0x06001460 RID: 5216 RVA: 0x000217C0 File Offset: 0x000207C0
		public OrderGrid(InstancedEvent evnt) : base(evnt)
		{
		}

		// Token: 0x06001461 RID: 5217 RVA: 0x000217CC File Offset: 0x000207CC
		protected internal override void Execute(ActivityExecutionContext context)
		{
			EventGridPacket eventGridPacket = new EventGridPacket();
			foreach (EntrantInfo entrantInfo in base.Event.Entrants)
			{
				eventGridPacket.AddOpponent(entrantInfo.PersonaId, entrantInfo.Opponent.GridIndex);
			}
			InternalLobby.Get().OrderEventGrid(base.Event.ConnectionSupport, eventGridPacket);
			foreach (EntrantInfo entrantInfo2 in base.Event.Entrants)
			{
				int gridIndex = eventGridPacket.GetGridIndex(entrantInfo2.PersonaId);
				entrantInfo2.Opponent.GridIndex = gridIndex;
			}
		}

		// Token: 0x06001462 RID: 5218 RVA: 0x000218AC File Offset: 0x000208AC
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}

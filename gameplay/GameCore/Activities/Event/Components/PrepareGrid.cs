using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001CE RID: 462
	public class PrepareGrid : Component<InstancedEvent>
	{
		// Token: 0x0600147D RID: 5245 RVA: 0x00022103 File Offset: 0x00021103
		public PrepareGrid(InstancedEvent @event) : base(@event)
		{
		}

		// Token: 0x0600147E RID: 5246 RVA: 0x000221D1 File Offset: 0x000211D1
		protected internal override void Execute(ActivityExecutionContext context)
		{
			base.Event.Entrants.ForEach(delegate(EntrantInfo entrant)
			{
				entrant.Opponent.Prepare(base.Event.EventDef.EventModeId() == EventMode.kEventMode_Drag);
				float baseSkill = Math.Min((float)base.Event.EventDef.DifficultyLevel() / 100f, 1f);
				entrant.Opponent.InternalOpponent.SetBaseSkill(baseSkill);
				float baseShortcutTakingChance = Math.Min((float)base.Event.EventDef.AIShortcutPct() / 100f, 1f);
				entrant.Opponent.InternalOpponent.SetBaseShortcutTakingChance(baseShortcutTakingChance);
				float rankingBiasShortcutChance = Math.Min((float)base.Event.EventDef.AIShortcutPositionBias() / 100f, 1f);
				entrant.Opponent.InternalOpponent.SetRankingBiasShortcutChance(rankingBiasShortcutChance);
			});
			Traffic.SetTrafficDensity((int)base.Event.EventDef.TrafficDensity());
		}

		// Token: 0x0600147F RID: 5247 RVA: 0x00022204 File Offset: 0x00021204
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}

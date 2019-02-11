using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000162 RID: 354
	public class VisualEffect : WorkflowElement
	{
		// Token: 0x060012EC RID: 4844 RVA: 0x0001B2B8 File Offset: 0x0001A2B8
		public VisualEffect(EffectType effectType)
		{
			this.effectType = effectType;
		}

		// Token: 0x060012ED RID: 4845 RVA: 0x0001B2C7 File Offset: 0x0001A2C7
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Render.TriggerEffect(this.effectType);
		}

		// Token: 0x060012EE RID: 4846 RVA: 0x0001B2D4 File Offset: 0x0001A2D4
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000460 RID: 1120
		private readonly EffectType effectType;
	}
}

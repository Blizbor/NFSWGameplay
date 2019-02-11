using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000149 RID: 329
	public class LoadEventVault : WorkflowElement
	{
		// Token: 0x06001283 RID: 4739 RVA: 0x0001AA5C File Offset: 0x00019A5C
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Collection collection = new Collection(this.EventKey.Value);
			if (!collection.IsValid())
			{
				collection.LoadVaultSync();
			}
		}

		// Token: 0x06001284 RID: 4740 RVA: 0x0001AA88 File Offset: 0x00019A88
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x1700012D RID: 301
		// (get) Token: 0x06001285 RID: 4741 RVA: 0x0001AA8A File Offset: 0x00019A8A
		// (set) Token: 0x06001286 RID: 4742 RVA: 0x0001AA92 File Offset: 0x00019A92
		public InArgument<uint> EventKey
		{
			get
			{
				return this.eventKey;
			}
			set
			{
				this.eventKey = value;
			}
		}

		// Token: 0x0400043D RID: 1085
		private InArgument<uint> eventKey;
	}
}

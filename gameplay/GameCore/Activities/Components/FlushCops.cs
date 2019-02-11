using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x02000143 RID: 323
	public class FlushCops : WorkflowElement
	{
		// Token: 0x06001266 RID: 4710 RVA: 0x0001A874 File Offset: 0x00019874
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.FlushCops();
		}

		// Token: 0x06001267 RID: 4711 RVA: 0x0001A87B File Offset: 0x0001987B
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}
	}
}

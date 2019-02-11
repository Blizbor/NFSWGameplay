using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200013B RID: 315
	public class EnablePointsOfInterest : WorkflowElement
	{
		// Token: 0x06001245 RID: 4677 RVA: 0x0001A563 File Offset: 0x00019563
		public EnablePointsOfInterest(uint type, bool enable)
		{
			this.type = type;
			this.enable = enable;
		}

		// Token: 0x06001246 RID: 4678 RVA: 0x0001A579 File Offset: 0x00019579
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.enable)
			{
				Engine.Get().PointsOfInterest().EnableAll(this.type);
				return;
			}
			Engine.Get().PointsOfInterest().DisableAll(this.type);
		}

		// Token: 0x06001247 RID: 4679 RVA: 0x0001A5AE File Offset: 0x000195AE
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0400042E RID: 1070
		private readonly uint type;

		// Token: 0x0400042F RID: 1071
		private readonly bool enable;
	}
}

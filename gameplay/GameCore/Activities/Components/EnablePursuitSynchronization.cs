using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200013C RID: 316
	public class EnablePursuitSynchronization : WorkflowElement
	{
		// Token: 0x06001248 RID: 4680 RVA: 0x0001A5B0 File Offset: 0x000195B0
		public EnablePursuitSynchronization(bool enable)
		{
			this.enable = enable;
		}

		// Token: 0x06001249 RID: 4681 RVA: 0x0001A5BF File Offset: 0x000195BF
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cops.EnablePursuitSynchronization(this.enable);
		}

		// Token: 0x0600124A RID: 4682 RVA: 0x0001A5CC File Offset: 0x000195CC
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x04000430 RID: 1072
		private readonly bool enable;
	}
}

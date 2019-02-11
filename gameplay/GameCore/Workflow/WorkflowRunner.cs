using System;
using EASharp;

namespace GameCore.Workflow
{
	// Token: 0x0200022E RID: 558
	[Export]
	public class WorkflowRunner
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x00027CC4 File Offset: 0x00026CC4
		internal WorkflowRunner(WorkflowElement element)
		{
			this.instance = WorkflowInstance.Create(element);
		}

		// Token: 0x060016BE RID: 5822 RVA: 0x00027CD8 File Offset: 0x00026CD8
		public static WorkflowRunner Construct(string workflow, InternalCollection collection)
		{
			WorkflowElement workflowElement = Activator.CreateInstance<WorkflowElement>(workflow);
			if (workflowElement != null)
			{
				ICollectionOwner collectionOwner = workflowElement as ICollectionOwner;
				if (collectionOwner != null)
				{
					collectionOwner.Bind(collection);
				}
				return new WorkflowRunner(workflowElement);
			}
			return null;
		}

		// Token: 0x060016BF RID: 5823 RVA: 0x00027D08 File Offset: 0x00026D08
		public void Start()
		{
			if (!this.instance.IsRunning)
			{
				this.instance.Start();
			}
		}

		// Token: 0x060016C0 RID: 5824 RVA: 0x00027D22 File Offset: 0x00026D22
		public void Stop()
		{
			this.instance.Abort();
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x00027D2F File Offset: 0x00026D2F
		public void Close()
		{
			this.instance.Dispose();
			this.instance = null;
		}

		// Token: 0x0400057D RID: 1405
		private WorkflowInstance instance;
	}
}

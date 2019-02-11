using System;
using System.Collections.Generic;

namespace GameCore.Workflow
{
	// Token: 0x0200022D RID: 557
	public class WorkflowInstance : IDisposable
	{
		// Token: 0x060016AB RID: 5803 RVA: 0x000279E1 File Offset: 0x000269E1
		private WorkflowInstance(WorkflowElement element)
		{
			this.scheduled = new Queue<ActivityExecutionContext>();
			this.element = element;
		}

		// Token: 0x060016AC RID: 5804 RVA: 0x00027A08 File Offset: 0x00026A08
		~WorkflowInstance()
		{
			this.Dispose(false);
		}

		// Token: 0x060016AD RID: 5805 RVA: 0x00027A38 File Offset: 0x00026A38
		internal static WorkflowInstance Create(WorkflowElement element)
		{
			return new WorkflowInstance(element);
		}

		// Token: 0x060016AE RID: 5806 RVA: 0x00027A50 File Offset: 0x00026A50
		public static void UpdateAll(float dt)
		{
			for (int i = 0; i < WorkflowInstance.Instances.Count; i++)
			{
				WorkflowInstance.Instances[i].Update(dt);
			}
		}

		// Token: 0x060016AF RID: 5807 RVA: 0x00027A84 File Offset: 0x00026A84
		internal void Start()
		{
			if (!this.IsRunning)
			{
				WorkflowInstance.Instances.Add(this);
				this.context = new ActivityExecutionContext(this, this.element);
				this.context.Faulted += this.OnFaulted;
				this.context.StatusChanged += this.OnStatusChanged;
				this.ScheduleItem(this.context);
			}
		}

		// Token: 0x060016B0 RID: 5808 RVA: 0x00027AF0 File Offset: 0x00026AF0
		internal void Update(float dt)
		{
			while (this.scheduled.Count != 0)
			{
				ActivityExecutionContext activityExecutionContext = this.scheduled.Dequeue();
				activityExecutionContext.Execute();
			}
		}

		// Token: 0x060016B1 RID: 5809 RVA: 0x00027B20 File Offset: 0x00026B20
		internal void Abort()
		{
			if (this.context != null)
			{
				this.context.Faulted -= this.OnFaulted;
				this.context.StatusChanged -= this.OnStatusChanged;
				this.context.Cancel();
				this.context = null;
				this.scheduled.Clear();
				WorkflowInstance.Instances.Remove(this);
			}
		}

		// Token: 0x060016B2 RID: 5810 RVA: 0x00027B8C File Offset: 0x00026B8C
		protected void OnStatusChanged(ActivityExecutionContext context, ActivityExecutionStatus status)
		{
			if (status == ActivityExecutionStatus.Closed)
			{
				this.Abort();
				if (this.Completed != null)
				{
					this.Completed(this, null);
				}
				Console.WriteLine(string.Format("Workflow Instance Completed: {0}", this.element));
			}
		}

		// Token: 0x060016B3 RID: 5811 RVA: 0x00027BC2 File Offset: 0x00026BC2
		protected void OnFaulted(ActivityExecutionContext context, Exception ex, WorkflowElement sender)
		{
			Console.WriteLine(string.Format("Workflow Instance Faulted: {0}", this.element));
		}

		// Token: 0x060016B4 RID: 5812 RVA: 0x00027BD9 File Offset: 0x00026BD9
		internal void ScheduleItem(ActivityExecutionContext context)
		{
			this.scheduled.Enqueue(context);
		}

		// Token: 0x060016B5 RID: 5813 RVA: 0x00027BE8 File Offset: 0x00026BE8
		public static void PrintAll()
		{
			foreach (WorkflowInstance workflowInstance in WorkflowInstance.Instances)
			{
				workflowInstance.Print();
			}
		}

		// Token: 0x060016B6 RID: 5814 RVA: 0x00027C3C File Offset: 0x00026C3C
		internal void Print()
		{
			this.context.Print(0);
		}

		// Token: 0x060016B7 RID: 5815 RVA: 0x00027C4A File Offset: 0x00026C4A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x00027C59 File Offset: 0x00026C59
		protected void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				if (this.context != null)
				{
					this.Abort();
				}
				this.isDisposed = true;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x060016B9 RID: 5817 RVA: 0x00027C78 File Offset: 0x00026C78
		// (remove) Token: 0x060016BA RID: 5818 RVA: 0x00027C91 File Offset: 0x00026C91
		internal event EventHandler Completed;

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x00027CAA File Offset: 0x00026CAA
		internal bool IsRunning
		{
			get
			{
				return null != this.context;
			}
		}

		// Token: 0x04000576 RID: 1398
		private bool isDisposed;

		// Token: 0x04000577 RID: 1399
		private WorkflowElement element;

		// Token: 0x04000578 RID: 1400
		private ActivityExecutionContext context;

		// Token: 0x04000579 RID: 1401
		private Queue<ActivityExecutionContext> scheduled;

		// Token: 0x0400057A RID: 1402
		internal static List<WorkflowInstance> Instances = new List<WorkflowInstance>();

		// Token: 0x0400057B RID: 1403
		private Dictionary<uint, Signal> signals = new Dictionary<uint, Signal>();
	}
}

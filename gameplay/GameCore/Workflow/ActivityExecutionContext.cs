using System;
using System.Collections.Generic;
using System.Text;

namespace GameCore.Workflow
{
	// Token: 0x0200021C RID: 540
	public class ActivityExecutionContext
	{
		// Token: 0x06001645 RID: 5701 RVA: 0x00026F9C File Offset: 0x00025F9C
		public ActivityExecutionContext(WorkflowInstance instance, WorkflowElement element)
		{
			this.instance = instance;
			this.element = element;
			this.element.OnGetChildren(this.children);
		}

		// Token: 0x06001646 RID: 5702 RVA: 0x00026FF0 File Offset: 0x00025FF0
		public void Execute()
		{
			try
			{
				if (this.Status == ActivityExecutionStatus.Initialized)
				{
					long tick = Simulation.GetTick();
					this.Status = ActivityExecutionStatus.Executing;
					this.element.Execute(this);
					Console.WriteLine("CS: {0} ms spent executing activity {1}.  Time now: {2}", Simulation.GetTickDifference(tick), this.element.ToString(), Simulation.GetTick());
				}
				this.CheckClosed();
			}
			catch (Exception ex)
			{
				this.ThrowFault(ex);
			}
		}

		// Token: 0x06001647 RID: 5703 RVA: 0x0002706C File Offset: 0x0002606C
		public void ThrowFault(Exception ex)
		{
			this.ThrowFault(ex, this.element);
		}

		// Token: 0x06001648 RID: 5704 RVA: 0x0002707B File Offset: 0x0002607B
		private void ThrowFault(Exception ex, WorkflowElement element)
		{
			this.Status = ActivityExecutionStatus.Faulting;
			this.OnFaulting(ex, element);
			if (this.IsFaulting)
			{
				this.Fault();
				this.OnFaulted(ex, element);
			}
		}

		// Token: 0x06001649 RID: 5705 RVA: 0x000270A2 File Offset: 0x000260A2
		public void HandleFault()
		{
			this.Status = ActivityExecutionStatus.Executing;
		}

		// Token: 0x0600164A RID: 5706 RVA: 0x000270AB File Offset: 0x000260AB
		private void Fault()
		{
			this.FaultChildren();
			this.Status = ActivityExecutionStatus.Faulted;
		}

		// Token: 0x0600164B RID: 5707 RVA: 0x000270BC File Offset: 0x000260BC
		private void FaultChildren()
		{
			foreach (ActivityExecutionContext activityExecutionContext in this.scheduled)
			{
				activityExecutionContext.Fault();
			}
		}

		// Token: 0x0600164C RID: 5708 RVA: 0x00027110 File Offset: 0x00026110
		private void CheckClosed()
		{
			if (this.IsCompleted && this.Status == ActivityExecutionStatus.Executing)
			{
				this.Status = ActivityExecutionStatus.Closed;
				this.element.Close();
				this.faultCallback = null;
				this.completionCallback = null;
			}
		}

		// Token: 0x0600164D RID: 5709 RVA: 0x00027143 File Offset: 0x00026143
		public void ScheduleActivity(WorkflowElement element)
		{
			this.ScheduleActivity(element, null);
		}

		// Token: 0x0600164E RID: 5710 RVA: 0x0002714D File Offset: 0x0002614D
		public void ScheduleActivity(WorkflowElement element, CompletionCallback completionCallback)
		{
			this.ScheduleActivity(element, completionCallback, null);
		}

		// Token: 0x0600164F RID: 5711 RVA: 0x00027158 File Offset: 0x00026158
		public void ScheduleActivity(WorkflowElement element, CompletionCallback completionCallback, FaultCallback faultCallback)
		{
			if (element != null)
			{
				ActivityExecutionContext activityExecutionContext = new ActivityExecutionContext(this.instance, element);
				this.completionCallback = completionCallback;
				this.faultCallback = faultCallback;
				ActivityExecutionContext activityExecutionContext2 = activityExecutionContext;
				activityExecutionContext2.StatusChanged = (StatusChangedHandler)Delegate.Combine(activityExecutionContext2.StatusChanged, new StatusChangedHandler(this.OnDependencyStatusChanged));
				ActivityExecutionContext activityExecutionContext3 = activityExecutionContext;
				activityExecutionContext3.Faulted = (FaultCallback)Delegate.Combine(activityExecutionContext3.Faulted, new FaultCallback(this.OnDependencyFaulted));
				if (!this.children.Contains(element))
				{
					this.children.Add(element);
				}
				this.scheduled.Add(activityExecutionContext);
				this.instance.ScheduleItem(activityExecutionContext);
			}
		}

		// Token: 0x06001650 RID: 5712 RVA: 0x000271FC File Offset: 0x000261FC
		public Bookmark CreateNamedBookmark(string name, BookmarkCallback callback)
		{
			return this.CreateNamedBookmark(name, callback, BookmarkOptions.SingleResume);
		}

		// Token: 0x06001651 RID: 5713 RVA: 0x00027208 File Offset: 0x00026208
		public Bookmark CreateNamedBookmark(string name, BookmarkCallback callback, BookmarkOptions options)
		{
			Bookmark bookmark = new Bookmark(name, callback, options, this);
			bookmark.Closed += this.OnBookmarkClosed;
			this.bookmarks.Add(bookmark);
			return bookmark;
		}

		// Token: 0x06001652 RID: 5714 RVA: 0x00027240 File Offset: 0x00026240
		private void OnDependencyStatusChanged(ActivityExecutionContext context, ActivityExecutionStatus status)
		{
			if (status == ActivityExecutionStatus.Closed)
			{
				this.scheduled.Remove(context);
				this.children.Remove(context.element);
				context.StatusChanged = (StatusChangedHandler)Delegate.Remove(context.StatusChanged, new StatusChangedHandler(this.OnDependencyStatusChanged));
				context.Faulted = (FaultCallback)Delegate.Remove(context.Faulted, new FaultCallback(this.OnDependencyFaulted));
				this.OnCompletion(context.element);
			}
			else if (status == ActivityExecutionStatus.Faulted || status == ActivityExecutionStatus.Canceled)
			{
				this.scheduled.Remove(context);
				this.children.Remove(context.element);
				context.StatusChanged = (StatusChangedHandler)Delegate.Remove(context.StatusChanged, new StatusChangedHandler(this.OnDependencyStatusChanged));
				context.Faulted = (FaultCallback)Delegate.Remove(context.Faulted, new FaultCallback(this.OnDependencyFaulted));
			}
			this.CheckClosed();
		}

		// Token: 0x06001653 RID: 5715 RVA: 0x00027333 File Offset: 0x00026333
		private void OnDependencyFaulted(ActivityExecutionContext context, Exception ex, WorkflowElement sender)
		{
			this.ThrowFault(ex, sender);
		}

		// Token: 0x06001654 RID: 5716 RVA: 0x0002733D File Offset: 0x0002633D
		private void OnBookmarkClosed(Bookmark bookmark)
		{
			bookmark.Closed -= this.OnBookmarkClosed;
			this.bookmarks.Remove(bookmark);
			this.CheckClosed();
		}

		// Token: 0x06001655 RID: 5717 RVA: 0x00027364 File Offset: 0x00026364
		protected void OnStatusChanged(ActivityExecutionStatus status)
		{
			if (this.StatusChanged != null)
			{
				this.StatusChanged(this, status);
			}
		}

		// Token: 0x06001656 RID: 5718 RVA: 0x0002737B File Offset: 0x0002637B
		protected virtual void OnCompletion(WorkflowElement sender)
		{
			if (this.completionCallback != null)
			{
				this.completionCallback(this, sender);
			}
		}

		// Token: 0x06001657 RID: 5719 RVA: 0x00027392 File Offset: 0x00026392
		protected virtual void OnFaulting(Exception ex, WorkflowElement sender)
		{
			if (this.faultCallback != null)
			{
				this.faultCallback(this, ex, sender);
			}
		}

		// Token: 0x06001658 RID: 5720 RVA: 0x000273AA File Offset: 0x000263AA
		protected virtual void OnFaulted(Exception ex, WorkflowElement sender)
		{
			if (this.Faulted != null)
			{
				this.Faulted(this, ex, sender);
			}
		}

		// Token: 0x06001659 RID: 5721 RVA: 0x000273C2 File Offset: 0x000263C2
		internal void Cancel()
		{
			this.Status = ActivityExecutionStatus.Canceled;
			this.element.Close();
			this.CancelChildren();
		}

		// Token: 0x0600165A RID: 5722 RVA: 0x000273DC File Offset: 0x000263DC
		public void CancelChildren()
		{
			this.children.Clear();
			if (this.scheduled.Count != 0)
			{
				ActivityExecutionContext[] array = new ActivityExecutionContext[this.scheduled.Count];
				this.scheduled.CopyTo(0, array, 0, this.scheduled.Count);
				foreach (ActivityExecutionContext activityExecutionContext in array)
				{
					activityExecutionContext.Cancel();
				}
			}
		}

		// Token: 0x0600165B RID: 5723 RVA: 0x00027448 File Offset: 0x00026448
		public void Print(int depth)
		{
			StringBuilder stringBuilder = new StringBuilder(depth);
			for (int i = 0; i < depth; i++)
			{
				stringBuilder.Append("  ");
			}
			depth++;
			string text = stringBuilder.ToString();
			Console.WriteLine("{0}{1} : {2} - {3} - {4}", new object[]
			{
				text,
				this.element.ToString(),
				this.Status.ToString(),
				this.children.Count,
				this.bookmarks.Count
			});
			foreach (WorkflowElement workflowElement in this.children)
			{
				Console.WriteLine("{0}Child: {1}", text, workflowElement.ToString());
			}
			foreach (ActivityExecutionContext activityExecutionContext in this.scheduled)
			{
				activityExecutionContext.Print(depth);
			}
		}

		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600165C RID: 5724 RVA: 0x0002757C File Offset: 0x0002657C
		// (remove) Token: 0x0600165D RID: 5725 RVA: 0x00027595 File Offset: 0x00026595
		internal event StatusChangedHandler StatusChanged;

		// Token: 0x14000009 RID: 9
		// (add) Token: 0x0600165E RID: 5726 RVA: 0x000275AE File Offset: 0x000265AE
		// (remove) Token: 0x0600165F RID: 5727 RVA: 0x000275C7 File Offset: 0x000265C7
		internal event FaultCallback Faulted;

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06001660 RID: 5728 RVA: 0x000275E0 File Offset: 0x000265E0
		public bool IsFaulting
		{
			get
			{
				return this.Status == ActivityExecutionStatus.Faulting;
			}
		}

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06001661 RID: 5729 RVA: 0x000275EB File Offset: 0x000265EB
		public bool IsCompleted
		{
			get
			{
				return this.children.Count == 0 && 0 == this.bookmarks.Count;
			}
		}

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06001662 RID: 5730 RVA: 0x0002760A File Offset: 0x0002660A
		// (set) Token: 0x06001663 RID: 5731 RVA: 0x00027612 File Offset: 0x00026612
		public ActivityExecutionStatus Status
		{
			get
			{
				return this.status;
			}
			set
			{
				if (this.status != value)
				{
					this.status = value;
					this.OnStatusChanged(value);
				}
			}
		}

		// Token: 0x04000552 RID: 1362
		private WorkflowInstance instance;

		// Token: 0x04000553 RID: 1363
		private readonly WorkflowElement element;

		// Token: 0x04000554 RID: 1364
		private readonly List<WorkflowElement> children = new List<WorkflowElement>();

		// Token: 0x04000555 RID: 1365
		private readonly List<Bookmark> bookmarks = new List<Bookmark>();

		// Token: 0x04000556 RID: 1366
		private ActivityExecutionStatus status;

		// Token: 0x04000557 RID: 1367
		private CompletionCallback completionCallback;

		// Token: 0x04000558 RID: 1368
		private FaultCallback faultCallback;

		// Token: 0x04000559 RID: 1369
		private List<ActivityExecutionContext> scheduled = new List<ActivityExecutionContext>();
	}
}

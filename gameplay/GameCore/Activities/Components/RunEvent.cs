using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200015B RID: 347
	public class RunEvent : WorkflowElement
	{
		// Token: 0x060012BE RID: 4798 RVA: 0x0001ADB9 File Offset: 0x00019DB9
		public RunEvent(Manager manager)
		{
			this.manager = manager;
		}

		// Token: 0x060012BF RID: 4799 RVA: 0x0001ADC8 File Offset: 0x00019DC8
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (this.EventKey != null)
			{
				this.bookmark = context.CreateNamedBookmark(null, new BookmarkCallback(this.OnResume), BookmarkOptions.MultiResume);
				this.evnt = this.manager.CreateEvent(this.eventSessionId.Value, this.eventKey.Value, this.connectionSupport.Value);
				Console.WriteLine("CS: Running Event Id : {0}", this.evnt.EventId);
				this.evnt.EventCompleted += this.Event_EventCompleted;
				this.evnt.Run();
			}
		}

		// Token: 0x060012C0 RID: 4800 RVA: 0x0001AE68 File Offset: 0x00019E68
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x060012C1 RID: 4801 RVA: 0x0001AE6A File Offset: 0x00019E6A
		private void OnResume(ActivityExecutionContext context, Bookmark bookmark, object target)
		{
		}

		// Token: 0x060012C2 RID: 4802 RVA: 0x0001AE6C File Offset: 0x00019E6C
		protected internal override void Close()
		{
			this.evnt.Dispose();
			this.bookmark.Close();
			this.bookmark = null;
			base.Close();
		}

		// Token: 0x060012C3 RID: 4803 RVA: 0x0001AE91 File Offset: 0x00019E91
		private void Event_EventCompleted(object sender, EventCompletedArgs e)
		{
			this.Close();
		}

		// Token: 0x1700012F RID: 303
		// (get) Token: 0x060012C4 RID: 4804 RVA: 0x0001AE99 File Offset: 0x00019E99
		// (set) Token: 0x060012C5 RID: 4805 RVA: 0x0001AEA1 File Offset: 0x00019EA1
		public InArgument<long> EventSessionId
		{
			get
			{
				return this.eventSessionId;
			}
			set
			{
				this.eventSessionId = value;
			}
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x060012C6 RID: 4806 RVA: 0x0001AEAA File Offset: 0x00019EAA
		// (set) Token: 0x060012C7 RID: 4807 RVA: 0x0001AEB2 File Offset: 0x00019EB2
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

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x060012C8 RID: 4808 RVA: 0x0001AEBB File Offset: 0x00019EBB
		// (set) Token: 0x060012C9 RID: 4809 RVA: 0x0001AEC3 File Offset: 0x00019EC3
		public InArgument<ConnectionSupport> ConnectionSupport
		{
			get
			{
				return this.connectionSupport;
			}
			set
			{
				this.connectionSupport = value;
			}
		}

		// Token: 0x0400044C RID: 1100
		private Bookmark bookmark;

		// Token: 0x0400044D RID: 1101
		private readonly Manager manager;

		// Token: 0x0400044E RID: 1102
		private InArgument<uint> eventKey;

		// Token: 0x0400044F RID: 1103
		private InArgument<ConnectionSupport> connectionSupport;

		// Token: 0x04000450 RID: 1104
		private InArgument<long> eventSessionId;

		// Token: 0x04000451 RID: 1105
		private InstancedEvent evnt;
	}
}

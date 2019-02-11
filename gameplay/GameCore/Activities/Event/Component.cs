using System;
using GameCore.Workflow;

namespace GameCore.Activities.Event
{
	// Token: 0x020001AD RID: 429
	public abstract class Component<T> : WorkflowElement where T : Event
	{
		// Token: 0x0600140B RID: 5131 RVA: 0x00020C83 File Offset: 0x0001FC83
		public Component(T @event)
		{
			this.@event = @event;
		}

		// Token: 0x17000156 RID: 342
		// (get) Token: 0x0600140C RID: 5132 RVA: 0x00020C92 File Offset: 0x0001FC92
		public T Event
		{
			get
			{
				return this.@event;
			}
		}

		// Token: 0x040004B5 RID: 1205
		private readonly T @event;
	}
}

using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D5 RID: 469
	public class SetCameraBounds : Component<Event>
	{
		// Token: 0x06001497 RID: 5271 RVA: 0x000225EE File Offset: 0x000215EE
		public SetCameraBounds(Event evnt, bool set_bounds) : base(evnt)
		{
			this.setBounds = set_bounds;
		}

		// Token: 0x06001498 RID: 5272 RVA: 0x00022600 File Offset: 0x00021600
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Cameras.ClearAllBounds();
			if (this.setBounds)
			{
				Collection collection = new Collection(base.Event.EventDef.CameraBounds());
				Cameras.AssignCylinderBounds(collection.Position().x, collection.Position().y, collection.Position().z, collection.Height(), collection.Radius());
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x00022662 File Offset: 0x00021662
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x040004D8 RID: 1240
		private readonly bool setBounds;
	}
}

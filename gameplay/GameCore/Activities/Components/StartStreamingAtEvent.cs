using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Math;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200015C RID: 348
	public class StartStreamingAtEvent : WorkflowElement
	{
		// Token: 0x060012CB RID: 4811 RVA: 0x0001AED4 File Offset: 0x00019ED4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Collection collection = new Collection(this.EventKey.Value);
			if (!collection.IsValid())
			{
				return;
			}
			Collection collection2 = new Collection(collection.TrackLayout());
			if (!collection2.IsValid())
			{
				return;
			}
			Vector3 render = new Vector3();
			float rotation = 0f;
			Collection collection3 = new Collection(collection2.StartGrid());
			if (collection3.IsValid())
			{
				render = collection3.Position();
				rotation = collection3.Rotation();
			}
			else
			{
				uint num = collection2.Num_SpawnLocation();
				if (num > 0u)
				{
					Collection collection4 = new Collection(collection2.SpawnLocation(0u));
					render = collection4.Position();
					rotation = collection4.Rotation();
				}
			}
			Opponent opponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (opponent != null)
			{
				opponent.InternalOpponent.TeleportTo(CoordSys.RenderToSim(render), CoordSys.Vector3Make(rotation));
			}
		}

		// Token: 0x060012CC RID: 4812 RVA: 0x0001AF9C File Offset: 0x00019F9C
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x060012CD RID: 4813 RVA: 0x0001AF9E File Offset: 0x00019F9E
		// (set) Token: 0x060012CE RID: 4814 RVA: 0x0001AFA6 File Offset: 0x00019FA6
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

		// Token: 0x04000452 RID: 1106
		private InArgument<uint> eventKey;
	}
}

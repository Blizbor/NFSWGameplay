using System;
using System.Collections.Generic;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Components
{
	// Token: 0x0200015D RID: 349
	public class TeleportTo : WorkflowElement
	{
		// Token: 0x060012CF RID: 4815 RVA: 0x0001AFB0 File Offset: 0x00019FB0
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Opponent opponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (opponent != null)
			{
				opponent.InternalOpponent.TeleportTo(this.position.Value, this.direction.Value);
			}
		}

		// Token: 0x060012D0 RID: 4816 RVA: 0x0001AFF1 File Offset: 0x00019FF1
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x060012D1 RID: 4817 RVA: 0x0001AFF3 File Offset: 0x00019FF3
		// (set) Token: 0x060012D2 RID: 4818 RVA: 0x0001AFFB File Offset: 0x00019FFB
		public InArgument<Vector3> Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		// Token: 0x17000134 RID: 308
		// (get) Token: 0x060012D3 RID: 4819 RVA: 0x0001B004 File Offset: 0x0001A004
		// (set) Token: 0x060012D4 RID: 4820 RVA: 0x0001B00C File Offset: 0x0001A00C
		public InArgument<Vector3> Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
			}
		}

		// Token: 0x04000453 RID: 1107
		private InArgument<Vector3> position;

		// Token: 0x04000454 RID: 1108
		private InArgument<Vector3> direction;
	}
}

using System;
using System.Collections.Generic;
using GameCore.Workflow;

namespace GameCore.Activities.Components
{
	// Token: 0x0200014B RID: 331
	public class LockLocalVehicle : WorkflowElement
	{
		// Token: 0x0600128A RID: 4746 RVA: 0x0001AAB3 File Offset: 0x00019AB3
		public LockLocalVehicle(bool locked)
		{
			this.locked = locked;
		}

		// Token: 0x0600128B RID: 4747 RVA: 0x0001AAC4 File Offset: 0x00019AC4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			Opponent opponent = Engine.Get().OpponentManager().FindLocalOpponent();
			if (opponent != null)
			{
				opponent.Vehicle.PinInPlace(this.locked);
			}
		}

		// Token: 0x0600128C RID: 4748 RVA: 0x0001AAF5 File Offset: 0x00019AF5
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600128D RID: 4749 RVA: 0x0001AAF8 File Offset: 0x00019AF8
		public override string ToString()
		{
			return "LockVehicle: " + this.locked.ToString();
		}

		// Token: 0x0400043E RID: 1086
		private readonly bool locked;
	}
}

using System;

namespace GameCore.Routing
{
	// Token: 0x02000274 RID: 628
	public class CircuitRoutingState : RoutingState
	{
		// Token: 0x0600189A RID: 6298 RVA: 0x0002BB38 File Offset: 0x0002AB38
		public override bool CopyTo(RoutingState other)
		{
			CircuitRoutingState circuitRoutingState = other as CircuitRoutingState;
			if (circuitRoutingState != null)
			{
				circuitRoutingState.lap = this.lap;
				return base.CopyTo(other);
			}
			return false;
		}

		// Token: 0x17000243 RID: 579
		// (get) Token: 0x0600189B RID: 6299 RVA: 0x0002BB64 File Offset: 0x0002AB64
		// (set) Token: 0x0600189C RID: 6300 RVA: 0x0002BB6C File Offset: 0x0002AB6C
		public int Lap
		{
			get
			{
				return this.lap;
			}
			set
			{
				this.lap = value;
			}
		}

		// Token: 0x04000625 RID: 1573
		private int lap;
	}
}

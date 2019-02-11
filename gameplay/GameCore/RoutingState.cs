using System;

namespace GameCore
{
	// Token: 0x02000253 RID: 595
	public abstract class RoutingState
	{
		// Token: 0x060017F2 RID: 6130 RVA: 0x0002ACF4 File Offset: 0x00029CF4
		public virtual bool CopyTo(RoutingState other)
		{
			other.currentTarget = this.currentTarget;
			other.previousTarget = this.previousTarget;
			other.nextIndex = this.nextIndex;
			other.routingFinished = this.routingFinished;
			return true;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060017F3 RID: 6131 RVA: 0x0002AD27 File Offset: 0x00029D27
		// (set) Token: 0x060017F4 RID: 6132 RVA: 0x0002AD2F File Offset: 0x00029D2F
		public int NextIndex
		{
			get
			{
				return this.nextIndex;
			}
			set
			{
				this.nextIndex = value;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060017F5 RID: 6133 RVA: 0x0002AD38 File Offset: 0x00029D38
		// (set) Token: 0x060017F6 RID: 6134 RVA: 0x0002AD40 File Offset: 0x00029D40
		public RoutePoint CurrentTarget
		{
			get
			{
				return this.currentTarget;
			}
			set
			{
				this.currentTarget = value;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060017F7 RID: 6135 RVA: 0x0002AD49 File Offset: 0x00029D49
		// (set) Token: 0x060017F8 RID: 6136 RVA: 0x0002AD51 File Offset: 0x00029D51
		public RoutePoint PreviousTarget
		{
			get
			{
				return this.previousTarget;
			}
			set
			{
				this.previousTarget = value;
			}
		}

		// Token: 0x17000208 RID: 520
		// (get) Token: 0x060017F9 RID: 6137 RVA: 0x0002AD5A File Offset: 0x00029D5A
		// (set) Token: 0x060017FA RID: 6138 RVA: 0x0002AD62 File Offset: 0x00029D62
		public bool IsRoutingFinished
		{
			get
			{
				return this.routingFinished;
			}
			set
			{
				this.routingFinished = value;
			}
		}

		// Token: 0x040005DC RID: 1500
		private RoutePoint previousTarget;

		// Token: 0x040005DD RID: 1501
		private RoutePoint currentTarget;

		// Token: 0x040005DE RID: 1502
		private int nextIndex;

		// Token: 0x040005DF RID: 1503
		private bool routingFinished;
	}
}

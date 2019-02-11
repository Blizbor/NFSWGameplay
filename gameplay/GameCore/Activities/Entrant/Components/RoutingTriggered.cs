using System;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000195 RID: 405
	public class RoutingTriggered : MessageHandler<OnTriggerEnter>
	{
		// Token: 0x060013AE RID: 5038 RVA: 0x0001C923 File Offset: 0x0001B923
		public RoutingTriggered(InstancedEvent @event, EntrantInfo entrant, uint port) : base(@event, entrant, port)
		{
		}

		// Token: 0x060013AF RID: 5039 RVA: 0x0001C930 File Offset: 0x0001B930
		protected override void OnExecute(ActivityExecutionContext context)
		{
			this.RoutingState = base.InstancedEvent.RoutingMethod.Prepare(base.InstancedEvent, base.Entrant);
			if (this.RoutingState.CurrentTarget != null)
			{
				base.Entrant.Opponent.SetNextPathPoint(this.RoutingState.CurrentTarget.Position, this.RoutingState.CurrentTarget.Direction);
			}
		}

		// Token: 0x060013B0 RID: 5040 RVA: 0x0001C9BC File Offset: 0x0001B9BC
		protected override void OnMessage(OnTriggerEnter message)
		{
			if (base.Entrant.PersonaId == message.PersonaId)
			{
				if (message.TriggerKey == this.RoutingState.CurrentTarget.Key)
				{
					RoutePoint expectedPreviousTarget = base.InstancedEvent.RoutingMethod.GetExpectedPreviousTarget(base.InstancedEvent, this.RoutingState);
					if (expectedPreviousTarget != null && expectedPreviousTarget != this.RoutingState.PreviousTarget)
					{
						return;
					}
					this.RoutingState = base.InstancedEvent.RoutingMethod.HitTrigger(base.InstancedEvent, base.Entrant, this.RoutingState);
					if (this.RoutingState.CurrentTarget != null)
					{
						base.Entrant.Opponent.SetNextPathPoint(this.RoutingState.CurrentTarget.Position, this.RoutingState.CurrentTarget.Direction);
					}
					if (this.RoutingState.IsRoutingFinished)
					{
						base.InstancedEvent.ScoringMethod.OnRoutingFinished(base.Entrant);
						this.Close();
					}
				}
				RoutePoint routePoint2 = base.InstancedEvent.Route.Find((RoutePoint routePoint) => routePoint.Key == message.TriggerKey);
				if (routePoint2 != null)
				{
					this.RoutingState.PreviousTarget = routePoint2;
				}
			}
		}

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060013B1 RID: 5041 RVA: 0x0001CB01 File Offset: 0x0001BB01
		// (set) Token: 0x060013B2 RID: 5042 RVA: 0x0001CB0E File Offset: 0x0001BB0E
		public RoutingState RoutingState
		{
			get
			{
				return base.Entrant.RoutingState;
			}
			set
			{
				base.Entrant.RoutingState = value;
			}
		}
	}
}

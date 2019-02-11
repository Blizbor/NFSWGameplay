using System;
using GameCore.Messages;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000188 RID: 392
	public class NavigateToGPSUpdater : MessageHandler<OnTriggerEnter>
	{
		// Token: 0x0600137B RID: 4987 RVA: 0x0001C27C File Offset: 0x0001B27C
		public NavigateToGPSUpdater(InstancedEvent @event, EntrantInfo entrant, uint port) : base(@event, entrant, port)
		{
			this.currentTrigger = 0;
			this.useGPS = base.Event.EventDef.GPSArrow();
			if (this.useGPS)
			{
				NavigateTo.NavigatePlayerTo(base.InstancedEvent.Route[this.currentTrigger].Position, Vector3.kZero, 0f, true, false, true);
			}
		}

		// Token: 0x0600137C RID: 4988 RVA: 0x0001C2E4 File Offset: 0x0001B2E4
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x0600137D RID: 4989 RVA: 0x0001C2E6 File Offset: 0x0001B2E6
		protected internal override void Close()
		{
			this.currentTrigger = 0;
			if (this.useGPS)
			{
				NavigateTo.StopNavigatePlayerTo();
			}
			base.Close();
		}

		// Token: 0x0600137E RID: 4990 RVA: 0x0001C304 File Offset: 0x0001B304
		protected override void OnMessage(OnTriggerEnter message)
		{
			if (this.useGPS && base.Entrant.PersonaId == message.PersonaId)
			{
				for (int i = 0; i < base.InstancedEvent.Route.Count; i++)
				{
					if (message.TriggerKey == base.InstancedEvent.Route[i].Key)
					{
						if (i + 1 < base.InstancedEvent.Route.Count && this.currentTrigger != i + 1)
						{
							this.currentTrigger = i + 1;
							NavigateTo.NavigatePlayerTo(base.InstancedEvent.Route[this.currentTrigger].Position, Vector3.kZero, 0f, true, false, true);
						}
						else if (i + 1 >= base.InstancedEvent.Route.Count)
						{
							this.currentTrigger = 0;
							NavigateTo.NavigatePlayerTo(base.InstancedEvent.Route[this.currentTrigger].Position, Vector3.kZero, 0f, true, false, true);
						}
					}
				}
			}
		}

		// Token: 0x04000490 RID: 1168
		private int currentTrigger;

		// Token: 0x04000491 RID: 1169
		private bool useGPS;
	}
}

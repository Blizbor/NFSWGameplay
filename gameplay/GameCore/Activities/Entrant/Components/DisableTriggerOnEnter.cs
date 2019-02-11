using System;
using GameCore.Messages;
using GameCore.Scoring;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000170 RID: 368
	public class DisableTriggerOnEnter : MessageHandler<OnTriggerEnter>
	{
		// Token: 0x06001327 RID: 4903 RVA: 0x0001B909 File Offset: 0x0001A909
		public DisableTriggerOnEnter(Event evnt, EntrantInfo entrant, uint port) : base(evnt, entrant, port)
		{
		}

		// Token: 0x06001328 RID: 4904 RVA: 0x0001B914 File Offset: 0x0001A914
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001329 RID: 4905 RVA: 0x0001B934 File Offset: 0x0001A934
		protected override void OnMessage(OnTriggerEnter message)
		{
			InternalInstance internalInstance = InstanceCatalog.Get().Find(message.TriggerKey);
			if (internalInstance != null && message.PersonaId == base.Event.Entrants[0].PersonaId && internalInstance.IsTypeOf(ObjType.kObjType_Trigger))
			{
				TreasureHuntScoringState treasureHuntScoringState = base.Event.Entrants[0].ScoringState as TreasureHuntScoringState;
				if (treasureHuntScoringState != null)
				{
					for (uint num = 0u; num < base.Event.EventDef.Num_Coins(); num += 1u)
					{
						if (base.Event.EventDef.Coins(num).GetCollectionKey() == message.TriggerKey)
						{
							treasureHuntScoringState.CoinsCollected |= 1u << (int)num;
							InternalEvent.UpdateCoinsCollected(treasureHuntScoringState.CoinsCollected);
							break;
						}
					}
				}
				PointOfInterest pointOfInterest = base.Event.PointsOfInterest.Find((PointOfInterest p) => p.Key == message.TriggerKey);
				if (pointOfInterest != null)
				{
					pointOfInterest.Disable();
					pointOfInterest.Hide();
					base.Event.Manager.PointsOfInterest.Dispose(pointOfInterest);
				}
				this.Close();
			}
		}
	}
}

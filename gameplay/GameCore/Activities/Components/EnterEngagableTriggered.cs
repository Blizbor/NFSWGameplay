using System;
using GameCore.Data;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x0200013E RID: 318
	public class EnterEngagableTriggered : MessageHandler<OnTriggerEnter>
	{
		// Token: 0x0600124E RID: 4686 RVA: 0x0001A5F9 File Offset: 0x000195F9
		public EnterEngagableTriggered(Manager manager, uint port) : base(port)
		{
			this.manager = manager;
		}

		// Token: 0x0600124F RID: 4687 RVA: 0x0001A609 File Offset: 0x00019609
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x0001A60C File Offset: 0x0001960C
		protected override void OnMessage(OnTriggerEnter message)
		{
			if (Cops.IsPursuitActive())
			{
				return;
			}
			InternalInstance internalInstance = InstanceCatalog.Get().Find(message.TriggerKey);
			uint flag = 64u;
			if (internalInstance != null)
			{
				Opponent opponent = this.manager.OpponentManager.FindByPersonaId(message.PersonaId);
				if (opponent != null)
				{
					LocalHumanOpponent localHumanOpponent = opponent as LocalHumanOpponent;
					if (localHumanOpponent != null)
					{
						uint num = 0u;
						if (internalInstance.IsTypeOf(ObjType.kObjType_Trigger) && internalInstance.IsFlagSet(flag))
						{
							Collection collection = new Collection(internalInstance);
							num = collection.TargetActivity().GetCollectionKey();
						}
						else if (internalInstance.IsTypeOf(ObjType.kObjType_Event))
						{
							num = internalInstance.GetCollection();
						}
						if (num != 0u)
						{
							EventDefinition eventDefinition = Engine.Get().EventRepository().FindByEventKey(num);
							localHumanOpponent.Hud.OnEnterEngagable(eventDefinition.EventId);
						}
					}
				}
			}
		}

		// Token: 0x04000433 RID: 1075
		private readonly Manager manager;
	}
}

using System;
using GameCore.Data;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000141 RID: 321
	public class ExitEngagableTriggered : MessageHandler<OnTriggerExit>
	{
		// Token: 0x0600125F RID: 4703 RVA: 0x0001A77A File Offset: 0x0001977A
		public ExitEngagableTriggered(Manager manager, uint port) : base(port)
		{
			this.manager = manager;
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0001A78A File Offset: 0x0001978A
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0001A78C File Offset: 0x0001978C
		protected override void OnMessage(OnTriggerExit message)
		{
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
							localHumanOpponent.Hud.OnExitEngagable(eventDefinition.EventId);
						}
					}
				}
			}
		}

		// Token: 0x04000438 RID: 1080
		private readonly Manager manager;
	}
}

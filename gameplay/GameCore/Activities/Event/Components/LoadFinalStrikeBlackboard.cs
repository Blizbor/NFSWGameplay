using System;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C5 RID: 453
	public class LoadFinalStrikeBlackboard : MessageHandler<OnFinalStrike>
	{
		// Token: 0x0600145A RID: 5210 RVA: 0x00021715 File Offset: 0x00020715
		public LoadFinalStrikeBlackboard(InstancedEvent evnt, uint port, params InternalBlackboardSlot[] slots) : base(evnt, port)
		{
			this.slots = slots;
		}

		// Token: 0x0600145B RID: 5211 RVA: 0x00021726 File Offset: 0x00020726
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x0600145C RID: 5212 RVA: 0x00021728 File Offset: 0x00020728
		protected override void OnMessage(OnFinalStrike message)
		{
			foreach (InternalBlackboardSlot internalBlackboardSlot in this.slots)
			{
				BlackBoard.Get().Change(internalBlackboardSlot.Channel, internalBlackboardSlot.BlackboardKey);
			}
		}

		// Token: 0x040004CA RID: 1226
		private readonly InternalBlackboardSlot[] slots;
	}
}

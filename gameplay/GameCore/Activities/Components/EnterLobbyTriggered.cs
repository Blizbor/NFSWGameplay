using System;
using GameCore.Messages;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000140 RID: 320
	public class EnterLobbyTriggered : MessageHandler<OnEnterLobby>
	{
		// Token: 0x0600125A RID: 4698 RVA: 0x0001A745 File Offset: 0x00019745
		public EnterLobbyTriggered(uint port) : base(port)
		{
		}

		// Token: 0x0600125B RID: 4699 RVA: 0x0001A74E File Offset: 0x0001974E
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0001A750 File Offset: 0x00019750
		protected override void OnMessage(OnEnterLobby message)
		{
			this.eventKey.Value = message.EventKey;
			this.Close();
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0001A769 File Offset: 0x00019769
		// (set) Token: 0x0600125E RID: 4702 RVA: 0x0001A771 File Offset: 0x00019771
		public OutArgument<uint> EventKey
		{
			get
			{
				return this.eventKey;
			}
			set
			{
				this.eventKey = value;
			}
		}

		// Token: 0x04000437 RID: 1079
		private OutArgument<uint> eventKey;
	}
}

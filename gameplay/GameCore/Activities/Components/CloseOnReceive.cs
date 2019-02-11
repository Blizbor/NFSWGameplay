using System;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x02000133 RID: 307
	public class CloseOnReceive<M> : MessageHandler<M> where M : Message
	{
		// Token: 0x0600122E RID: 4654 RVA: 0x0001A454 File Offset: 0x00019454
		public CloseOnReceive(uint port) : base(port)
		{
		}

		// Token: 0x0600122F RID: 4655 RVA: 0x0001A45D File Offset: 0x0001945D
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001230 RID: 4656 RVA: 0x0001A45F File Offset: 0x0001945F
		protected override void OnMessage(M message)
		{
			this.Close();
		}
	}
}

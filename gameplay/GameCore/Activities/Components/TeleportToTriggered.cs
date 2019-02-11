using System;
using GameCore.Messages;
using GameCore.Workflow;
using GameCore.Workflow.Activities;
using UMath;

namespace GameCore.Activities.Components
{
	// Token: 0x0200015E RID: 350
	public class TeleportToTriggered : MessageHandler<OnTeleportTo>
	{
		// Token: 0x060012D6 RID: 4822 RVA: 0x0001B01D File Offset: 0x0001A01D
		public TeleportToTriggered(uint port) : base(port)
		{
		}

		// Token: 0x060012D7 RID: 4823 RVA: 0x0001B026 File Offset: 0x0001A026
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060012D8 RID: 4824 RVA: 0x0001B028 File Offset: 0x0001A028
		protected override void OnMessage(OnTeleportTo message)
		{
			this.position.Value = message.Position;
			this.direction.Value = message.Direction;
			this.Close();
		}

		// Token: 0x17000135 RID: 309
		// (get) Token: 0x060012D9 RID: 4825 RVA: 0x0001B052 File Offset: 0x0001A052
		// (set) Token: 0x060012DA RID: 4826 RVA: 0x0001B05A File Offset: 0x0001A05A
		public OutArgument<Vector3> Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		// Token: 0x17000136 RID: 310
		// (get) Token: 0x060012DB RID: 4827 RVA: 0x0001B063 File Offset: 0x0001A063
		// (set) Token: 0x060012DC RID: 4828 RVA: 0x0001B06B File Offset: 0x0001A06B
		public OutArgument<Vector3> Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
			}
		}

		// Token: 0x04000455 RID: 1109
		private OutArgument<Vector3> position;

		// Token: 0x04000456 RID: 1110
		private OutArgument<Vector3> direction;
	}
}

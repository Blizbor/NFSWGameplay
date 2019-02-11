using System;
using GameCore.Messages;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Components
{
	// Token: 0x0200013F RID: 319
	public class EnterEventTriggered : MessageHandler<OnEnterEvent>
	{
		// Token: 0x06001251 RID: 4689 RVA: 0x0001A6CC File Offset: 0x000196CC
		public EnterEventTriggered(uint port) : base(port)
		{
		}

		// Token: 0x06001252 RID: 4690 RVA: 0x0001A6D5 File Offset: 0x000196D5
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001253 RID: 4691 RVA: 0x0001A6D7 File Offset: 0x000196D7
		protected override void OnMessage(OnEnterEvent message)
		{
			this.eventSessionId.Value = message.EventSessionId;
			this.eventKey.Value = message.EventKey;
			this.connectionSupport.Value = message.ConnectionSupport;
			this.Close();
		}

		// Token: 0x17000127 RID: 295
		// (get) Token: 0x06001254 RID: 4692 RVA: 0x0001A712 File Offset: 0x00019712
		// (set) Token: 0x06001255 RID: 4693 RVA: 0x0001A71A File Offset: 0x0001971A
		public OutArgument<long> EventSessionId
		{
			get
			{
				return this.eventSessionId;
			}
			set
			{
				this.eventSessionId = value;
			}
		}

		// Token: 0x17000128 RID: 296
		// (get) Token: 0x06001256 RID: 4694 RVA: 0x0001A723 File Offset: 0x00019723
		// (set) Token: 0x06001257 RID: 4695 RVA: 0x0001A72B File Offset: 0x0001972B
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

		// Token: 0x17000129 RID: 297
		// (get) Token: 0x06001258 RID: 4696 RVA: 0x0001A734 File Offset: 0x00019734
		// (set) Token: 0x06001259 RID: 4697 RVA: 0x0001A73C File Offset: 0x0001973C
		public OutArgument<ConnectionSupport> ConnectionSupport
		{
			get
			{
				return this.connectionSupport;
			}
			set
			{
				this.connectionSupport = value;
			}
		}

		// Token: 0x04000434 RID: 1076
		private OutArgument<long> eventSessionId;

		// Token: 0x04000435 RID: 1077
		private OutArgument<uint> eventKey;

		// Token: 0x04000436 RID: 1078
		private OutArgument<ConnectionSupport> connectionSupport;
	}
}

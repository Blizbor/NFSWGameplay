using System;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C6 RID: 454
	public class NoCoinsRefreshed : MessageHandler<OnCoinsRefreshed>
	{
		// Token: 0x0600145D RID: 5213 RVA: 0x0002176F File Offset: 0x0002076F
		public NoCoinsRefreshed(Event evnt, uint port) : base(evnt, port)
		{
		}

		// Token: 0x0600145E RID: 5214 RVA: 0x00021779 File Offset: 0x00020779
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x0600145F RID: 5215 RVA: 0x0002177C File Offset: 0x0002077C
		protected override void OnMessage(OnCoinsRefreshed message)
		{
			int num = 0;
			for (int i = 0; i < 32; i++)
			{
				if (((ulong)message.CoinsCollected & (ulong)(1L << (i & 31))) != 0UL)
				{
					num++;
				}
			}
			if ((ulong)message.NumCoins <= (ulong)((long)num))
			{
				this.Close();
			}
		}
	}
}

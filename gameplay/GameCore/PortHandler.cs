using System;

namespace GameCore
{
	// Token: 0x0200024E RID: 590
	internal class PortHandler<T> : IPortHandler where T : Message
	{
		// Token: 0x060017DC RID: 6108 RVA: 0x0002ABF2 File Offset: 0x00029BF2
		public PortHandler(uint port)
		{
			this.port = port;
		}

		// Token: 0x060017DD RID: 6109 RVA: 0x0002AC01 File Offset: 0x00029C01
		public void OnHandleMessage(Message message)
		{
			if (this.Handler != null)
			{
				this.Handler((T)((object)message));
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060017DE RID: 6110 RVA: 0x0002AC1C File Offset: 0x00029C1C
		// (remove) Token: 0x060017DF RID: 6111 RVA: 0x0002AC35 File Offset: 0x00029C35
		public event MessageHandler<T> Handler;

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060017E0 RID: 6112 RVA: 0x0002AC4E File Offset: 0x00029C4E
		public uint Port
		{
			get
			{
				return this.port;
			}
		}

		// Token: 0x040005D7 RID: 1495
		private readonly uint port;
	}
}

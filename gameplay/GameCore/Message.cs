using System;
using System.IO;
using EASharp;

namespace GameCore
{
	// Token: 0x020001F7 RID: 503
	[Export]
	public abstract class Message
	{
		// Token: 0x0600155C RID: 5468 RVA: 0x00025DCA File Offset: 0x00024DCA
		public virtual void Post(uint port)
		{
			Messenger.Post(this, port);
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00025DD3 File Offset: 0x00024DD3
		public virtual void Synchronize(uint port)
		{
			Messenger.Synchronize(this, port);
		}

		// Token: 0x0600155E RID: 5470 RVA: 0x00025DDC File Offset: 0x00024DDC
		public virtual void Serialize(BinaryWriter dest)
		{
			throw new NotImplementedException();
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00025DE3 File Offset: 0x00024DE3
		public static object Construct(BinaryReader source)
		{
			throw new NotImplementedException();
		}

		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06001560 RID: 5472
		public abstract uint Kind { get; }
	}
}

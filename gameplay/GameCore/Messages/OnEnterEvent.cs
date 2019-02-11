using System;
using EASharp;

namespace GameCore.Messages
{
	// Token: 0x02000259 RID: 601
	[Export]
	public class OnEnterEvent : Message
	{
		// Token: 0x0600182F RID: 6191 RVA: 0x0002B2CB File Offset: 0x0002A2CB
		public OnEnterEvent(long eventSessionId, uint eventKey, int connectionSupport)
		{
			this.eventSessionId = eventSessionId;
			this.eventKey = eventKey;
			this.connectionSupport = (ConnectionSupport)connectionSupport;
		}

		// Token: 0x1700021B RID: 539
		// (get) Token: 0x06001830 RID: 6192 RVA: 0x0002B2E8 File Offset: 0x0002A2E8
		public override uint Kind
		{
			get
			{
				return OnEnterEvent.KindHash;
			}
		}

		// Token: 0x1700021C RID: 540
		// (get) Token: 0x06001831 RID: 6193 RVA: 0x0002B2EF File Offset: 0x0002A2EF
		internal long EventSessionId
		{
			get
			{
				return this.eventSessionId;
			}
		}

		// Token: 0x1700021D RID: 541
		// (get) Token: 0x06001832 RID: 6194 RVA: 0x0002B2F7 File Offset: 0x0002A2F7
		internal uint EventKey
		{
			get
			{
				return this.eventKey;
			}
		}

		// Token: 0x1700021E RID: 542
		// (get) Token: 0x06001833 RID: 6195 RVA: 0x0002B2FF File Offset: 0x0002A2FF
		internal ConnectionSupport ConnectionSupport
		{
			get
			{
				return this.connectionSupport;
			}
		}

		// Token: 0x040005F5 RID: 1525
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnEnterEvent");

		// Token: 0x040005F6 RID: 1526
		private readonly long eventSessionId;

		// Token: 0x040005F7 RID: 1527
		private readonly uint eventKey;

		// Token: 0x040005F8 RID: 1528
		private readonly ConnectionSupport connectionSupport;
	}
}

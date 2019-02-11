using System;

namespace GameCore.Messages
{
	// Token: 0x02000271 RID: 625
	public class OnTimingOut : Message
	{
		// Token: 0x06001890 RID: 6288 RVA: 0x0002B788 File Offset: 0x0002A788
		public OnTimingOut(long personaId)
		{
			this.personaId = personaId;
		}

		// Token: 0x17000241 RID: 577
		// (get) Token: 0x06001891 RID: 6289 RVA: 0x0002B797 File Offset: 0x0002A797
		public override uint Kind
		{
			get
			{
				return OnTimingOut.KindHash;
			}
		}

		// Token: 0x17000242 RID: 578
		// (get) Token: 0x06001892 RID: 6290 RVA: 0x0002B79E File Offset: 0x0002A79E
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x0400061B RID: 1563
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnTimingOut");

		// Token: 0x0400061C RID: 1564
		private readonly long personaId;
	}
}

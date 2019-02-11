using System;

namespace GameCore.Collision
{
	// Token: 0x020001E7 RID: 487
	public class TriggerEventArgs : EventArgs
	{
		// Token: 0x060014EF RID: 5359 RVA: 0x00025303 File Offset: 0x00024303
		public TriggerEventArgs(long personaId)
		{
			this.personaId = personaId;
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060014F0 RID: 5360 RVA: 0x00025312 File Offset: 0x00024312
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x040004F1 RID: 1265
		private readonly long personaId;
	}
}

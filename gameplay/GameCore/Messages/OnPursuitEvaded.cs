using System;
using System.IO;
using EASharp;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x0200026C RID: 620
	[Export]
	public class OnPursuitEvaded : Message, IPersonaMessage
	{
		// Token: 0x0600187B RID: 6267 RVA: 0x0002B673 File Offset: 0x0002A673
		public OnPursuitEvaded(long personaId)
		{
			this.personaId = personaId;
		}

		// Token: 0x0600187C RID: 6268 RVA: 0x0002B682 File Offset: 0x0002A682
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
		}

		// Token: 0x0600187D RID: 6269 RVA: 0x0002B690 File Offset: 0x0002A690
		public new static object Construct(BinaryReader source)
		{
			return new OnPursuitEvaded(source.ReadInt64());
		}

		// Token: 0x17000239 RID: 569
		// (get) Token: 0x0600187E RID: 6270 RVA: 0x0002B69D File Offset: 0x0002A69D
		public override uint Kind
		{
			get
			{
				return OnPursuitEvaded.KindHash;
			}
		}

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x0600187F RID: 6271 RVA: 0x0002B6A4 File Offset: 0x0002A6A4
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x04000613 RID: 1555
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnPursuitEvaded");

		// Token: 0x04000614 RID: 1556
		private readonly long personaId;
	}
}

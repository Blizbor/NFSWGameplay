using System;
using System.IO;
using EASharp;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x0200026A RID: 618
	[Export]
	public class OnPursuitCooldown : Message, IPersonaMessage
	{
		// Token: 0x0600186F RID: 6255 RVA: 0x0002B5DF File Offset: 0x0002A5DF
		public OnPursuitCooldown(long personaId)
		{
			this.personaId = personaId;
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x0002B5EE File Offset: 0x0002A5EE
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x0002B5FC File Offset: 0x0002A5FC
		public new static object Construct(BinaryReader source)
		{
			return new OnPursuitCooldown(source.ReadInt64());
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06001872 RID: 6258 RVA: 0x0002B609 File Offset: 0x0002A609
		public override uint Kind
		{
			get
			{
				return OnPursuitCooldown.KindHash;
			}
		}

		// Token: 0x17000236 RID: 566
		// (get) Token: 0x06001873 RID: 6259 RVA: 0x0002B610 File Offset: 0x0002A610
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x0400060F RID: 1551
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnPursuitCooldown");

		// Token: 0x04000610 RID: 1552
		private readonly long personaId;
	}
}

using System;
using System.IO;
using EASharp;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x02000269 RID: 617
	[Export]
	public class OnPursuitBusted : Message, IPersonaMessage
	{
		// Token: 0x06001869 RID: 6249 RVA: 0x0002B595 File Offset: 0x0002A595
		public OnPursuitBusted(long personaId)
		{
			this.personaId = personaId;
		}

		// Token: 0x0600186A RID: 6250 RVA: 0x0002B5A4 File Offset: 0x0002A5A4
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
		}

		// Token: 0x0600186B RID: 6251 RVA: 0x0002B5B2 File Offset: 0x0002A5B2
		public new static object Construct(BinaryReader source)
		{
			return new OnPursuitBusted(source.ReadInt64());
		}

		// Token: 0x17000233 RID: 563
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x0002B5BF File Offset: 0x0002A5BF
		public override uint Kind
		{
			get
			{
				return OnPursuitBusted.KindHash;
			}
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600186D RID: 6253 RVA: 0x0002B5C6 File Offset: 0x0002A5C6
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x0400060D RID: 1549
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnPursuitBusted");

		// Token: 0x0400060E RID: 1550
		private readonly long personaId;
	}
}

using System;
using System.IO;
using EASharp;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x0200026B RID: 619
	[Export]
	public class OnPursuitEngaged : Message, IPersonaMessage
	{
		// Token: 0x06001875 RID: 6261 RVA: 0x0002B629 File Offset: 0x0002A629
		public OnPursuitEngaged(long personaId)
		{
			this.personaId = personaId;
		}

		// Token: 0x06001876 RID: 6262 RVA: 0x0002B638 File Offset: 0x0002A638
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
		}

		// Token: 0x06001877 RID: 6263 RVA: 0x0002B646 File Offset: 0x0002A646
		public new static object Construct(BinaryReader source)
		{
			return new OnPursuitEngaged(source.ReadInt64());
		}

		// Token: 0x17000237 RID: 567
		// (get) Token: 0x06001878 RID: 6264 RVA: 0x0002B653 File Offset: 0x0002A653
		public override uint Kind
		{
			get
			{
				return OnPursuitEngaged.KindHash;
			}
		}

		// Token: 0x17000238 RID: 568
		// (get) Token: 0x06001879 RID: 6265 RVA: 0x0002B65A File Offset: 0x0002A65A
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x04000611 RID: 1553
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnPursuitEngaged");

		// Token: 0x04000612 RID: 1554
		private readonly long personaId;
	}
}

using System;
using System.IO;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x020001FD RID: 509
	public class OnTriggerExit : Message, IPersonaMessage
	{
		// Token: 0x0600157A RID: 5498 RVA: 0x00025F58 File Offset: 0x00024F58
		public OnTriggerExit(uint triggerKey, long personaId)
		{
			this.triggerKey = triggerKey;
			this.personaId = personaId;
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00025F6E File Offset: 0x00024F6E
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.triggerKey);
			dest.Write(this.personaId);
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00025F88 File Offset: 0x00024F88
		public new static object Construct(BinaryReader source)
		{
			return new OnTriggerEnter(source.ReadUInt32(), source.ReadInt64());
		}

		// Token: 0x17000180 RID: 384
		// (get) Token: 0x0600157D RID: 5501 RVA: 0x00025F9B File Offset: 0x00024F9B
		public override uint Kind
		{
			get
			{
				return OnTriggerExit.KindHash;
			}
		}

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x0600157E RID: 5502 RVA: 0x00025FA2 File Offset: 0x00024FA2
		public uint TriggerKey
		{
			get
			{
				return this.triggerKey;
			}
		}

		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600157F RID: 5503 RVA: 0x00025FAA File Offset: 0x00024FAA
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x04000512 RID: 1298
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnTriggerExit");

		// Token: 0x04000513 RID: 1299
		private readonly uint triggerKey;

		// Token: 0x04000514 RID: 1300
		private readonly long personaId;
	}
}

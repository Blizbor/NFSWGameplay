using System;
using System.IO;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x020001FC RID: 508
	public class OnTriggerEnter : Message, IPersonaMessage
	{
		// Token: 0x06001573 RID: 5491 RVA: 0x00025EED File Offset: 0x00024EED
		public OnTriggerEnter(uint triggerKey, long personaId)
		{
			this.triggerKey = triggerKey;
			this.personaId = personaId;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00025F03 File Offset: 0x00024F03
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.triggerKey);
			dest.Write(this.personaId);
		}

		// Token: 0x06001575 RID: 5493 RVA: 0x00025F1D File Offset: 0x00024F1D
		public new static object Construct(BinaryReader source)
		{
			return new OnTriggerEnter(source.ReadUInt32(), source.ReadInt64());
		}

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06001576 RID: 5494 RVA: 0x00025F30 File Offset: 0x00024F30
		public override uint Kind
		{
			get
			{
				return OnTriggerEnter.KindHash;
			}
		}

		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06001577 RID: 5495 RVA: 0x00025F37 File Offset: 0x00024F37
		public uint TriggerKey
		{
			get
			{
				return this.triggerKey;
			}
		}

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06001578 RID: 5496 RVA: 0x00025F3F File Offset: 0x00024F3F
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x0400050F RID: 1295
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnTriggerEnter");

		// Token: 0x04000510 RID: 1296
		private readonly uint triggerKey;

		// Token: 0x04000511 RID: 1297
		private readonly long personaId;
	}
}

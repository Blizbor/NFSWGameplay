using System;
using System.IO;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x020001FA RID: 506
	public class OnPerfectLaunchAchieved : Message, IPersonaMessage
	{
		// Token: 0x06001566 RID: 5478 RVA: 0x00025E12 File Offset: 0x00024E12
		public OnPerfectLaunchAchieved(long personaId, float duration, float torque)
		{
			this.personaId = personaId;
			this.duration = duration;
			this.torque = torque;
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00025E2F File Offset: 0x00024E2F
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
			dest.Write(this.duration);
			dest.Write(this.torque);
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00025E55 File Offset: 0x00024E55
		public new static object Construct(BinaryReader source)
		{
			return new OnPerfectLaunchAchieved(source.ReadInt64(), source.ReadSingle(), source.ReadSingle());
		}

		// Token: 0x17000176 RID: 374
		// (get) Token: 0x06001569 RID: 5481 RVA: 0x00025E6E File Offset: 0x00024E6E
		public override uint Kind
		{
			get
			{
				return OnPerfectLaunchAchieved.KindHash;
			}
		}

		// Token: 0x17000177 RID: 375
		// (get) Token: 0x0600156A RID: 5482 RVA: 0x00025E75 File Offset: 0x00024E75
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x17000178 RID: 376
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00025E7D File Offset: 0x00024E7D
		public float Duration
		{
			get
			{
				return this.duration;
			}
		}

		// Token: 0x17000179 RID: 377
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00025E85 File Offset: 0x00024E85
		public float Torque
		{
			get
			{
				return this.torque;
			}
		}

		// Token: 0x04000508 RID: 1288
		private readonly long personaId;

		// Token: 0x04000509 RID: 1289
		private readonly float duration;

		// Token: 0x0400050A RID: 1290
		private readonly float torque;

		// Token: 0x0400050B RID: 1291
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnPerfectLaunchAchieved");
	}
}

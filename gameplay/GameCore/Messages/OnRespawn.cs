using System;
using System.IO;
using EASharp;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x0200026D RID: 621
	[Export]
	public class OnRespawn : Message, IPersonaMessage
	{
		// Token: 0x06001881 RID: 6273 RVA: 0x0002B6BD File Offset: 0x0002A6BD
		public OnRespawn(long personaId, long respawnTargetPersonaId)
		{
			this.personaId = personaId;
			this.respawnTargetPersonaId = respawnTargetPersonaId;
		}

		// Token: 0x06001882 RID: 6274 RVA: 0x0002B6D3 File Offset: 0x0002A6D3
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
			dest.Write(this.respawnTargetPersonaId);
		}

		// Token: 0x06001883 RID: 6275 RVA: 0x0002B6ED File Offset: 0x0002A6ED
		public new static object Construct(BinaryReader source)
		{
			return new OnRespawn(source.ReadInt64(), source.ReadInt64());
		}

		// Token: 0x1700023B RID: 571
		// (get) Token: 0x06001884 RID: 6276 RVA: 0x0002B700 File Offset: 0x0002A700
		public override uint Kind
		{
			get
			{
				return OnRespawn.KindHash;
			}
		}

		// Token: 0x1700023C RID: 572
		// (get) Token: 0x06001885 RID: 6277 RVA: 0x0002B707 File Offset: 0x0002A707
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x1700023D RID: 573
		// (get) Token: 0x06001886 RID: 6278 RVA: 0x0002B70F File Offset: 0x0002A70F
		public long RespawnTargetPersonaId
		{
			get
			{
				return this.respawnTargetPersonaId;
			}
		}

		// Token: 0x04000615 RID: 1557
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnRespawn");

		// Token: 0x04000616 RID: 1558
		private readonly long personaId;

		// Token: 0x04000617 RID: 1559
		private readonly long respawnTargetPersonaId;
	}
}

using System;
using EASharp;
using GameCore.Math;

namespace GameCore.Messages
{
	// Token: 0x020001FB RID: 507
	[Export]
	public class OnTeleportTo : Message
	{
		// Token: 0x0600156E RID: 5486 RVA: 0x00025E9E File Offset: 0x00024E9E
		public OnTeleportTo(float xPosition, float yPosition, float zPosition, float xDirection, float yDirection, float zDirection)
		{
			this.position = new Vector3(xPosition, yPosition, zPosition);
			this.direction = new Vector3(xDirection, yDirection, zDirection);
		}

		// Token: 0x1700017A RID: 378
		// (get) Token: 0x0600156F RID: 5487 RVA: 0x00025EC5 File Offset: 0x00024EC5
		public override uint Kind
		{
			get
			{
				return OnTeleportTo.KindHash;
			}
		}

		// Token: 0x1700017B RID: 379
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00025ECC File Offset: 0x00024ECC
		public Vector3 Position
		{
			get
			{
				return this.position;
			}
		}

		// Token: 0x1700017C RID: 380
		// (get) Token: 0x06001571 RID: 5489 RVA: 0x00025ED4 File Offset: 0x00024ED4
		public Vector3 Direction
		{
			get
			{
				return this.direction;
			}
		}

		// Token: 0x0400050C RID: 1292
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnTeleportTo");

		// Token: 0x0400050D RID: 1293
		private readonly Vector3 position;

		// Token: 0x0400050E RID: 1294
		private readonly Vector3 direction;
	}
}

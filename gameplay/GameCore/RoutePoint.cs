using System;
using GameCore.Data;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000252 RID: 594
	public class RoutePoint
	{
		// Token: 0x060017EE RID: 6126 RVA: 0x0002ACB4 File Offset: 0x00029CB4
		public RoutePoint(Collection collection)
		{
			this.collection = collection;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060017EF RID: 6127 RVA: 0x0002ACC3 File Offset: 0x00029CC3
		public uint Key
		{
			get
			{
				return this.collection.GetCollection();
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060017F0 RID: 6128 RVA: 0x0002ACD0 File Offset: 0x00029CD0
		public Vector3 Position
		{
			get
			{
				return CoordSys.RenderToSim(this.collection.Position());
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x060017F1 RID: 6129 RVA: 0x0002ACE2 File Offset: 0x00029CE2
		public Vector3 Direction
		{
			get
			{
				return CoordSys.Vector3Make(this.collection.Rotation());
			}
		}

		// Token: 0x040005DB RID: 1499
		private readonly Collection collection;
	}
}

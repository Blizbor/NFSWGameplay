using System;
using System.IO;
using GameCore.Data;
using GameCore.Math;

namespace GameCore.Scripting
{
	// Token: 0x02000288 RID: 648
	public class SpawnTraffic : IScript
	{
		// Token: 0x060019CC RID: 6604 RVA: 0x0002F153 File Offset: 0x0002E153
		public static object Construct(BinaryReader source)
		{
			return new SpawnTraffic();
		}

		// Token: 0x060019CD RID: 6605 RVA: 0x0002F15C File Offset: 0x0002E15C
		public void Execute(Event evnt, EntrantInfo entrant, Collection trigger)
		{
			if (trigger.Num_Marker() < 1u)
			{
				return;
			}
			for (uint num = 0u; num < trigger.Num_Marker(); num += 1u)
			{
				Collection collection = new Collection(trigger.Marker(num));
				if (!collection.IsDerivedFrom(289837591u))
				{
					return;
				}
				Traffic.SpawnTraffic(collection.VehicleKey().GetKey(), CoordSys.RenderToSim(collection.Position()), CoordSys.Vector3Make(collection.Rotation()), collection.InitialSpeed());
			}
		}
	}
}

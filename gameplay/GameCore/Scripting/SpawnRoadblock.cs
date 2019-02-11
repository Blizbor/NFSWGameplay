using System;
using System.IO;
using GameCore.Collections;
using GameCore.Data;
using GameCore.Math;

namespace GameCore.Scripting
{
	// Token: 0x02000287 RID: 647
	public class SpawnRoadblock : IScript
	{
		// Token: 0x060019C9 RID: 6601 RVA: 0x0002F0A9 File Offset: 0x0002E0A9
		public static object Construct(BinaryReader source)
		{
			return new SpawnRoadblock();
		}

		// Token: 0x060019CA RID: 6602 RVA: 0x0002F0B0 File Offset: 0x0002E0B0
		public void Execute(Event evnt, EntrantInfo entrant, Collection trigger)
		{
			if (trigger.Num_Marker() < 1u)
			{
				return;
			}
			for (uint num = 0u; num < trigger.Num_Marker(); num += 1u)
			{
				Collection collection = new Collection(trigger.Marker(num));
				if (!collection.IsDerivedFrom(1001100515u))
				{
					return;
				}
				KeyList keyList = new KeyList(collection.Num_Vehicles());
				for (uint num2 = 0u; num2 < collection.Num_Vehicles(); num2 += 1u)
				{
					keyList.AddKey(collection.Vehicles(num2).GetKey());
				}
				Cops.CreateRoadblock(CoordSys.RenderToSim(collection.Position()), CoordSys.Vector3Make(collection.Rotation()), keyList, collection.ShouldUseSpikeStrips(), collection.MinLifetime());
			}
		}
	}
}

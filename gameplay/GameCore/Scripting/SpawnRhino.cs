using System;
using System.IO;
using GameCore.Data;
using GameCore.Opponents;

namespace GameCore.Scripting
{
	// Token: 0x02000286 RID: 646
	public class SpawnRhino : IScript
	{
		// Token: 0x060019C6 RID: 6598 RVA: 0x0002F068 File Offset: 0x0002E068
		public static object Construct(BinaryReader source)
		{
			return new SpawnRhino();
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0002F06F File Offset: 0x0002E06F
		public void Execute(Event evnt, EntrantInfo entrant, Collection trigger)
		{
			if (entrant == null || !(entrant.Opponent is LocalHumanOpponent))
			{
				return;
			}
			if (trigger.IsDerivedFrom(450779598u))
			{
				Cops.CreateRhinos(trigger.Distance(), trigger.NumRhinos());
			}
		}
	}
}

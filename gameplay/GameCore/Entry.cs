using System;
using GameCore.Activities;
using GameCore.Activities.Event.Modes;
using GameCore.Messages;
using GameCore.Radar;
using GameCore.Routing;
using GameCore.Scoring;
using GameCore.Scripting;
using GameCore.Spectate;

namespace GameCore
{
	// Token: 0x0200028E RID: 654
	public static class Entry
	{
		// Token: 0x060019D8 RID: 6616 RVA: 0x0002F398 File Offset: 0x0002E398
		public static int Main(string[] args)
		{
			Console.WriteLine("Scripting Initialized!");
			Activator.Register<TreasureHuntFlow>(new Activator.ConstructHandler(TreasureHuntFlow.Construct));
			Activator.Register<TeamEscapeFlow>(new Activator.ConstructHandler(TeamEscapeFlow.Construct));
			Activator.Register<BasicMeetingPlaceFlow>(new Activator.ConstructHandler(BasicMeetingPlaceFlow.Construct));
			Activator.Register<BasicEventFlow>(new Activator.ConstructHandler(BasicEventFlow.Construct));
			Activator.Register<DragEventFlow>(new Activator.ConstructHandler(DragEventFlow.Construct));
			Activator.Register<BasicPursuitFlow>(new Activator.ConstructHandler(BasicPursuitFlow.Construct));
			Activator.Register<ResetToPoint>(new Activator.ConstructHandler(ResetToPoint.Construct));
			Activator.Register<CircuitRoutingMethod>(new Activator.ConstructHandler(CircuitRoutingMethod.Construct));
			Activator.Register<P2PRoutingMethod>(new Activator.ConstructHandler(P2PRoutingMethod.Construct));
			Activator.Register<NullScoringMethod>(new Activator.ConstructHandler(NullScoringMethod.Construct));
			Activator.Register<RouteScoringMethod>(new Activator.ConstructHandler(RouteScoringMethod.Construct));
			Activator.Register<PursuitScoringMethod>(new Activator.ConstructHandler(PursuitScoringMethod.Construct));
			Activator.Register<TeamEscapeScoringMethod>(new Activator.ConstructHandler(TeamEscapeScoringMethod.Construct));
			Activator.Register<TreasureHuntScoringMethod>(new Activator.ConstructHandler(TreasureHuntScoringMethod.Construct));
			Activator.Register<DragScoringMethod>(new Activator.ConstructHandler(DragScoringMethod.Construct));
			Activator.Register<CopRadarMethod>(new Activator.ConstructHandler(CopRadarMethod.Construct));
			Activator.Register<CoinRadarMethod>(new Activator.ConstructHandler(CoinRadarMethod.Construct));
			Activator.Register<OnPursuitBusted>(new Activator.ConstructHandler(OnPursuitBusted.Construct));
			Activator.Register<OnPerfectLaunchAchieved>(new Activator.ConstructHandler(OnPerfectLaunchAchieved.Construct));
			Activator.Register<OnPursuitCooldown>(new Activator.ConstructHandler(OnPursuitCooldown.Construct));
			Activator.Register<OnPursuitEngaged>(new Activator.ConstructHandler(OnPursuitEngaged.Construct));
			Activator.Register<OnPursuitEvaded>(new Activator.ConstructHandler(OnPursuitEvaded.Construct));
			Activator.Register<OnRespawn>(new Activator.ConstructHandler(OnRespawn.Construct));
			Activator.Register<OnTriggerEnter>(new Activator.ConstructHandler(OnTriggerEnter.Construct));
			Activator.Register<OnTriggerExit>(new Activator.ConstructHandler(OnTriggerExit.Construct));
			Activator.Register<OnGearShift>(new Activator.ConstructHandler(OnGearShift.Construct));
			Activator.Register<TeamEscapeSpectateMethod>(new Activator.ConstructHandler(TeamEscapeSpectateMethod.Construct));
			Activator.Register<SpawnRhino>(new Activator.ConstructHandler(SpawnRhino.Construct));
			Activator.Register<SpawnRoadblock>(new Activator.ConstructHandler(SpawnRoadblock.Construct));
			Activator.Register<SpawnTraffic>(new Activator.ConstructHandler(SpawnTraffic.Construct));
			return 0;
		}
	}
}

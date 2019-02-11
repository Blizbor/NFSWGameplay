using System;
using System.IO;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Graphs;
using GameCore.Activities.Event.Components;
using GameCore.Messages;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event.Modes
{
	// Token: 0x020001E0 RID: 480
	public class TeamEscapeFlow : Mode
	{
		// Token: 0x060014BA RID: 5306 RVA: 0x00023A43 File Offset: 0x00022A43
		private TeamEscapeFlow()
		{
			this.allBustedSignal = Signal.CreateNamedSignal("TeamEscape.AllBusted");
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x00023A5B File Offset: 0x00022A5B
		public static object Construct(BinaryReader source)
		{
			return new TeamEscapeFlow();
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x00023A64 File Offset: 0x00022A64
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph("TeamEscapeFlow");
			State state = new State("running");
			State state2 = new State("loading");
			State state3 = new State("disconnected");
			State state4 = new State("done");
			EnableLoadingScreen item = new EnableLoadingScreen(true);
			RelaySync item2 = new RelaySync(0.1f);
			BeginEventSecurity item3 = new BeginEventSecurity();
			LoadBlackBoards item4 = new LoadBlackBoards(base.InstancedEvent, BlackBoardFlag.kBlackBoardFlag_Loading);
			ActivateReferencedTriggers item5 = new ActivateReferencedTriggers(base.InstancedEvent);
			PlaceRoute item6 = new PlaceRoute(base.InstancedEvent);
			FlushTraffic item7 = new FlushTraffic();
			FlushCops item8 = new FlushCops();
			PrimeCopVehicleCache item9 = new PrimeCopVehicleCache(base.InstancedEvent, Hash.Hash32("copsuv"), 12);
			PrimeCopVehicleCache item10 = new PrimeCopVehicleCache(base.InstancedEvent, Hash.Hash32("copcarmus08gh"), 4);
			AddOpponents item11 = new AddOpponents(base.InstancedEvent);
			PadGrid item12 = new PadGrid(base.InstancedEvent);
			OrderGrid item13 = new OrderGrid(base.InstancedEvent);
			EventBarriers item14 = new EventBarriers(base.InstancedEvent, true);
			ResolveBarriers item15 = new ResolveBarriers();
			FinalizeTrackLayout item16 = new FinalizeTrackLayout(base.InstancedEvent);
			WaitForOpponentsReady item17 = new WaitForOpponentsReady(base.InstancedEvent, 0.1f);
			PrepareGrid item18 = new PrepareGrid(base.InstancedEvent);
			CommitAllAssets item19 = new CommitAllAssets();
			PlaceGrid item20 = new PlaceGrid(base.InstancedEvent);
			EnableHud item21 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Enable);
			GameCore.Activities.Event.Components.AssignPowerupConfiguration item22 = new GameCore.Activities.Event.Components.AssignPowerupConfiguration(base.InstancedEvent);
			OverrideHeat item23 = new OverrideHeat((float)base.Event.EventDef.InitialHeat());
			ScriptTriggerListener activity = new ScriptTriggerListener(base.InstancedEvent, Ports.Gameplay);
			LoadFinalStrikeBlackboard activity2 = new LoadFinalStrikeBlackboard(base.InstancedEvent, Ports.Gameplay, new InternalBlackboardSlot[]
			{
				new InternalBlackboardSlot(BlackBoardChannel.kBlackBoard_Audio, 2580886883u)
			});
			PerfectLaunchAchieved activity3 = new PerfectLaunchAchieved(base.InstancedEvent, Ports.Gameplay);
			SynchronizeOnReceive<OnPerfectLaunchAchieved> activity4 = new SynchronizeOnReceive<OnPerfectLaunchAchieved>(base.InstancedEvent, Ports.Gameplay);
			Running<EntrantTeamEscape> activity5 = new Running<EntrantTeamEscape>(base.InstancedEvent, new string[]
			{
				"Entrants.Countdown",
				"Entrants.Loading"
			});
			CleanupRoute item24 = new CleanupRoute(base.InstancedEvent);
			DeactivateReferencedTriggers item25 = new DeactivateReferencedTriggers(base.InstancedEvent);
			EventBarriers item26 = new EventBarriers(base.InstancedEvent, false);
			ResetBarriers item27 = new ResetBarriers();
			CleanupTrackLayout item28 = new CleanupTrackLayout(base.InstancedEvent);
			RemoveAllOpponentsExceptLocalPlayer item29 = new RemoveAllOpponentsExceptLocalPlayer(base.InstancedEvent);
			EnableMinimapTrackLayout item30 = new EnableMinimapTrackLayout(base.InstancedEvent, true);
			EnableMinimapTrackLayout item31 = new EnableMinimapTrackLayout(base.InstancedEvent, false);
			CleanupEvent item32 = new CleanupEvent(base.InstancedEvent);
			EnableHud item33 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Dispose);
			CleanupGrid item34 = new CleanupGrid(base.InstancedEvent);
			CheckOpponentDisconnected activity6 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, false);
			CheckOpponentDisconnected activity7 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, true);
			state2.EnterActivity.Activities.Add(item);
			state2.EnterActivity.Activities.Add(item3);
			state2.EnterActivity.Activities.Add(item4);
			state2.EnterActivity.Activities.Add(item5);
			state2.EnterActivity.Activities.Add(item6);
			state2.EnterActivity.Activities.Add(item8);
			state2.EnterActivity.Activities.Add(item9);
			state2.EnterActivity.Activities.Add(item10);
			state2.EnterActivity.Activities.Add(item2);
			state2.EnterActivity.Activities.Add(item11);
			state2.EnterActivity.Activities.Add(item12);
			state2.EnterActivity.Activities.Add(item13);
			state2.EnterActivity.Activities.Add(item14);
			state2.EnterActivity.Activities.Add(item15);
			state2.EnterActivity.Activities.Add(item16);
			state2.EnterActivity.Activities.Add(item30);
			state2.EnterActivity.Activities.Add(item17);
			state2.EnterActivity.Activities.Add(item18);
			state2.EnterActivity.Activities.Add(item7);
			state2.EnterActivity.Activities.Add(item20);
			state2.EnterActivity.Activities.Add(item19);
			state2.EnterActivity.Activities.Add(item21);
			state2.EnterActivity.Activities.Add(item22);
			state2.EnterActivity.Activities.Add(item23);
			state2.Transitions.Add(new Transition("disconnected", activity7));
			state2.Transitions.Add(new Transition("running", activity6));
			state.Transitions.Add(new Transition(activity));
			state.Transitions.Add(new Transition(activity2));
			state.Transitions.Add(new Transition(activity3));
			state.Transitions.Add(new Transition(activity4));
			state.Transitions.Add(new Transition("done", activity5));
			EnableLoadingScreen item35 = new EnableLoadingScreen(false);
			state3.EnterActivity.Activities.Add(item35);
			state3.Transitions.Add(new Transition("done"));
			state4.EnterActivity.Activities.Add(item33);
			state4.EnterActivity.Activities.Add(item34);
			state4.EnterActivity.Activities.Add(item8);
			state4.EnterActivity.Activities.Add(item25);
			state4.EnterActivity.Activities.Add(item24);
			state4.EnterActivity.Activities.Add(item26);
			state4.EnterActivity.Activities.Add(item27);
			state4.EnterActivity.Activities.Add(item31);
			state4.EnterActivity.Activities.Add(item28);
			state4.EnterActivity.Activities.Add(item29);
			state4.EnterActivity.Activities.Add(item32);
			stateGraph.InitialState = "loading";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state4);
			return stateGraph;
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x000240A5 File Offset: 0x000230A5
		protected internal override void Close()
		{
			this.allBustedSignal.Release();
			base.Close();
		}

		// Token: 0x040004DB RID: 1243
		private Signal allBustedSignal;
	}
}

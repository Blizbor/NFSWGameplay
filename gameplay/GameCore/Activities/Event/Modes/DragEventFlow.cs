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
	// Token: 0x020001DF RID: 479
	public class DragEventFlow : Mode
	{
		// Token: 0x060014B8 RID: 5304 RVA: 0x0002345F File Offset: 0x0002245F
		public static object Construct(BinaryReader source)
		{
			return new DragEventFlow();
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x00023468 File Offset: 0x00022468
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph("DragEventFlow");
			State state = new State("loading");
			State state2 = new State("running");
			State state3 = new State("disconnected");
			State state4 = new State("done");
			EnableLoadingScreen item = new EnableLoadingScreen(true);
			RelaySync item2 = new RelaySync(0.1f);
			BeginEventSecurity item3 = new BeginEventSecurity();
			LoadBlackBoards item4 = new LoadBlackBoards(base.InstancedEvent, BlackBoardFlag.kBlackBoardFlag_Loading);
			ActivateReferencedTriggers item5 = new ActivateReferencedTriggers(base.InstancedEvent);
			PlaceRoute item6 = new PlaceRoute(base.InstancedEvent);
			FlushTraffic item7 = new FlushTraffic();
			AddOpponents item8 = new AddOpponents(base.InstancedEvent);
			PadGrid item9 = new PadGrid(base.InstancedEvent);
			OrderGrid item10 = new OrderGrid(base.InstancedEvent);
			EventBarriers item11 = new EventBarriers(base.InstancedEvent, true);
			ResolveBarriers item12 = new ResolveBarriers();
			FinalizeTrackLayout item13 = new FinalizeTrackLayout(base.InstancedEvent);
			FlushCops item14 = new FlushCops();
			PrimeTrafficVehicleCache item15 = new PrimeTrafficVehicleCache(base.InstancedEvent, Hash.Hash32("carreragt"), 4);
			WaitForOpponentsReady item16 = new WaitForOpponentsReady(base.InstancedEvent, 0.1f);
			PrepareGrid item17 = new PrepareGrid(base.InstancedEvent);
			CommitAllAssets item18 = new CommitAllAssets();
			PlaceGrid item19 = new PlaceGrid(base.InstancedEvent);
			EnableHud item20 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Enable);
			GameCore.Activities.Event.Components.AssignPowerupConfiguration item21 = new GameCore.Activities.Event.Components.AssignPowerupConfiguration(base.InstancedEvent);
			Running<EntrantDrag> activity = new Running<EntrantDrag>(base.InstancedEvent, new string[]
			{
				"Entrants.Countdown",
				"Entrants.Loading"
			});
			ScriptTriggerListener activity2 = new ScriptTriggerListener(base.InstancedEvent, Ports.Gameplay);
			PerfectLaunchAchieved activity3 = new PerfectLaunchAchieved(base.InstancedEvent, Ports.Gameplay);
			GearShift activity4 = new GearShift(base.InstancedEvent, Ports.Gameplay);
			SynchronizeOnReceive<OnPerfectLaunchAchieved> activity5 = new SynchronizeOnReceive<OnPerfectLaunchAchieved>(base.InstancedEvent, Ports.Gameplay);
			SynchronizeOnReceive<OnGearShift> activity6 = new SynchronizeOnReceive<OnGearShift>(base.InstancedEvent, Ports.Gameplay);
			CleanupRoute item22 = new CleanupRoute(base.InstancedEvent);
			DeactivateReferencedTriggers item23 = new DeactivateReferencedTriggers(base.InstancedEvent);
			EventBarriers item24 = new EventBarriers(base.InstancedEvent, false);
			ResetBarriers item25 = new ResetBarriers();
			CleanupTrackLayout item26 = new CleanupTrackLayout(base.InstancedEvent);
			RemoveAllOpponentsExceptLocalPlayer item27 = new RemoveAllOpponentsExceptLocalPlayer(base.InstancedEvent);
			EnableMinimapTrackLayout item28 = new EnableMinimapTrackLayout(base.InstancedEvent, true);
			EnableMinimapTrackLayout item29 = new EnableMinimapTrackLayout(base.InstancedEvent, false);
			CleanupEvent item30 = new CleanupEvent(base.InstancedEvent);
			CleanupGrid item31 = new CleanupGrid(base.InstancedEvent);
			EnableHud item32 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Dispose);
			CheckOpponentDisconnected activity7 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, false);
			CheckOpponentDisconnected activity8 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, true);
			state.EnterActivity.Activities.Add(item);
			state.EnterActivity.Activities.Add(item3);
			state.EnterActivity.Activities.Add(item4);
			state.EnterActivity.Activities.Add(item5);
			state.EnterActivity.Activities.Add(item6);
			state.EnterActivity.Activities.Add(item2);
			state.EnterActivity.Activities.Add(item8);
			state.EnterActivity.Activities.Add(item9);
			state.EnterActivity.Activities.Add(item10);
			state.EnterActivity.Activities.Add(item11);
			state.EnterActivity.Activities.Add(item12);
			state.EnterActivity.Activities.Add(item13);
			state.EnterActivity.Activities.Add(item28);
			state.EnterActivity.Activities.Add(item16);
			state.EnterActivity.Activities.Add(item17);
			state.EnterActivity.Activities.Add(item7);
			state.EnterActivity.Activities.Add(item14);
			state.EnterActivity.Activities.Add(item15);
			state.EnterActivity.Activities.Add(item19);
			state.EnterActivity.Activities.Add(item18);
			state.EnterActivity.Activities.Add(item20);
			state.EnterActivity.Activities.Add(item21);
			state.Transitions.Add(new Transition("disconnected", activity8));
			state.Transitions.Add(new Transition("running", activity7));
			state2.Transitions.Add(new Transition(activity2));
			state2.Transitions.Add(new Transition(activity5));
			state2.Transitions.Add(new Transition(activity6));
			state2.Transitions.Add(new Transition(activity3));
			state2.Transitions.Add(new Transition(activity4));
			state2.Transitions.Add(new Transition("done", activity));
			EnableLoadingScreen item33 = new EnableLoadingScreen(false);
			state3.EnterActivity.Activities.Add(item33);
			state3.Transitions.Add(new Transition("done"));
			state4.EnterActivity.Activities.Add(item32);
			state4.EnterActivity.Activities.Add(item31);
			state4.EnterActivity.Activities.Add(item23);
			state4.EnterActivity.Activities.Add(item22);
			state4.EnterActivity.Activities.Add(item24);
			state4.EnterActivity.Activities.Add(item25);
			state4.EnterActivity.Activities.Add(item29);
			state4.EnterActivity.Activities.Add(item26);
			state4.EnterActivity.Activities.Add(item27);
			state4.EnterActivity.Activities.Add(item30);
			stateGraph.InitialState = "loading";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state4);
			return stateGraph;
		}
	}
}

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
	// Token: 0x020001DC RID: 476
	public class BasicEventFlow : Mode
	{
		// Token: 0x060014AF RID: 5295 RVA: 0x0002287D File Offset: 0x0002187D
		public static object Construct(BinaryReader source)
		{
			return new BasicEventFlow();
		}

		// Token: 0x060014B0 RID: 5296 RVA: 0x00022884 File Offset: 0x00021884
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph("BasicEventFlow");
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
			AddOpponents item8 = new AddOpponents(base.InstancedEvent);
			PadGrid item9 = new PadGrid(base.InstancedEvent);
			OrderGrid item10 = new OrderGrid(base.InstancedEvent);
			EventBarriers item11 = new EventBarriers(base.InstancedEvent, true);
			ResolveBarriers item12 = new ResolveBarriers();
			FinalizeTrackLayout item13 = new FinalizeTrackLayout(base.InstancedEvent);
			FlushCops item14 = new FlushCops();
			WaitForOpponentsReady item15 = new WaitForOpponentsReady(base.InstancedEvent, 0.1f);
			PrepareGrid item16 = new PrepareGrid(base.InstancedEvent);
			CommitAllAssets item17 = new CommitAllAssets();
			PlaceGrid item18 = new PlaceGrid(base.InstancedEvent);
			EnableHud item19 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Enable);
			GameCore.Activities.Event.Components.AssignPowerupConfiguration item20 = new GameCore.Activities.Event.Components.AssignPowerupConfiguration(base.InstancedEvent);
			Running<EntrantNormal> activity = new Running<EntrantNormal>(base.InstancedEvent, new string[]
			{
				"Entrants.Countdown",
				"Entrants.Loading"
			});
			PerfectLaunchAchieved activity2 = new PerfectLaunchAchieved(base.InstancedEvent, Ports.Gameplay);
			SynchronizeOnReceive<OnPerfectLaunchAchieved> activity3 = new SynchronizeOnReceive<OnPerfectLaunchAchieved>(base.InstancedEvent, Ports.Gameplay);
			CleanupRoute item21 = new CleanupRoute(base.InstancedEvent);
			DeactivateReferencedTriggers item22 = new DeactivateReferencedTriggers(base.InstancedEvent);
			EventBarriers item23 = new EventBarriers(base.InstancedEvent, false);
			ResetBarriers item24 = new ResetBarriers();
			CleanupTrackLayout item25 = new CleanupTrackLayout(base.InstancedEvent);
			RemoveAllOpponentsExceptLocalPlayer item26 = new RemoveAllOpponentsExceptLocalPlayer(base.InstancedEvent);
			EnableMinimapTrackLayout item27 = new EnableMinimapTrackLayout(base.InstancedEvent, true);
			EnableMinimapTrackLayout item28 = new EnableMinimapTrackLayout(base.InstancedEvent, false);
			CleanupEvent item29 = new CleanupEvent(base.InstancedEvent);
			CleanupGrid item30 = new CleanupGrid(base.InstancedEvent);
			CheckOpponentDisconnected activity4 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, false);
			CheckOpponentDisconnected activity5 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, true);
			state2.EnterActivity.Activities.Add(item);
			state2.EnterActivity.Activities.Add(item3);
			state2.EnterActivity.Activities.Add(item4);
			state2.EnterActivity.Activities.Add(item5);
			state2.EnterActivity.Activities.Add(item6);
			state2.EnterActivity.Activities.Add(item2);
			state2.EnterActivity.Activities.Add(item8);
			state2.EnterActivity.Activities.Add(item9);
			state2.EnterActivity.Activities.Add(item10);
			state2.EnterActivity.Activities.Add(item11);
			state2.EnterActivity.Activities.Add(item12);
			state2.EnterActivity.Activities.Add(item13);
			state2.EnterActivity.Activities.Add(item27);
			state2.EnterActivity.Activities.Add(item15);
			state2.EnterActivity.Activities.Add(item16);
			state2.EnterActivity.Activities.Add(item7);
			state2.EnterActivity.Activities.Add(item14);
			state2.EnterActivity.Activities.Add(item18);
			state2.EnterActivity.Activities.Add(item17);
			state2.EnterActivity.Activities.Add(item19);
			state2.EnterActivity.Activities.Add(item20);
			state2.Transitions.Add(new Transition("disconnected", activity5));
			state2.Transitions.Add(new Transition("running", activity4));
			state.Transitions.Add(new Transition(activity3));
			state.Transitions.Add(new Transition(activity2));
			state.Transitions.Add(new Transition("done", activity));
			EnableLoadingScreen item31 = new EnableLoadingScreen(false);
			state3.EnterActivity.Activities.Add(item31);
			state3.Transitions.Add(new Transition("done"));
			EnableHud item32 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Dispose);
			state4.EnterActivity.Activities.Add(item32);
			state4.EnterActivity.Activities.Add(item30);
			state4.EnterActivity.Activities.Add(item22);
			state4.EnterActivity.Activities.Add(item21);
			state4.EnterActivity.Activities.Add(item23);
			state4.EnterActivity.Activities.Add(item24);
			state4.EnterActivity.Activities.Add(item28);
			state4.EnterActivity.Activities.Add(item25);
			state4.EnterActivity.Activities.Add(item26);
			state4.EnterActivity.Activities.Add(item29);
			stateGraph.InitialState = "loading";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state4);
			return stateGraph;
		}
	}
}

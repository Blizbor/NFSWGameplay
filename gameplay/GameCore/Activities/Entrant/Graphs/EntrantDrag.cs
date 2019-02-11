using System;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Components;
using GameCore.Activities.Event.Components;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Graphs
{
	// Token: 0x020001A5 RID: 421
	public class EntrantDrag : Activity
	{
		// Token: 0x060013F8 RID: 5112 RVA: 0x0001D2B4 File Offset: 0x0001C2B4
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph(string.Format("OpponentNormal: {0}", base.Entrant.Opponent.OpponentName));
			State state = new State("initial");
			State state2 = new State("countdown");
			State state3 = new State("running");
			State state4 = new State("raceover");
			State state5 = new State("post");
			State state6 = new State("paused");
			State state7 = new State("aborted");
			State state8 = new State("done");
			state.Transitions.Add(new Transition("countdown"));
			PrepareScoringMethod item = new PrepareScoringMethod(base.InstancedEvent, base.Entrant);
			LockEntrant item2 = new LockEntrant(base.InstancedEvent, base.Entrant, true);
			EntrantLoaded item3 = new EntrantLoaded(base.InstancedEvent, base.Entrant, "Entrants.Loading");
			EnableKeyboard item4 = new EnableKeyboard(true);
			EnableLoadingScreen item5 = new EnableLoadingScreen(false);
			FlushTraffic item6 = new FlushTraffic();
			FlushCops item7 = new FlushCops();
			HandleTutorial item8 = new HandleTutorial(base.InstancedEvent, base.Entrant, TutorialSource.kTutorialSource_Race);
			Countdown activity = new Countdown(base.InstancedEvent, base.Entrant);
			TryPerfectLaunch item9 = new TryPerfectLaunch(base.InstancedEvent, base.Entrant);
			LockEntrant item10 = new LockEntrant(base.InstancedEvent, base.Entrant, false);
			GameCore.Workflow.Activities.WaitAll item11 = new GameCore.Workflow.Activities.WaitAll("Entrants.Countdown");
			SetSignal item12 = new SetSignal("Entrants.Countdown");
			UnSetSignal item13 = new UnSetSignal("Entrants.Countdown");
			Launch item14 = new Launch(base.InstancedEvent, base.Entrant);
			RoutingTriggered activity2 = new RoutingTriggered(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			OnUpdateTick activity3 = new OnUpdateTick(base.InstancedEvent, base.Entrant);
			EntrantInterupt activity4 = new EntrantInterupt(base.InstancedEvent, base.Entrant, Ports.Gameplay, FinishReason.TimedOut);
			EntrantExtrapolate activity5 = new EntrantExtrapolate(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			EntrantDisconnected activity6 = new EntrantDisconnected(base.InstancedEvent, base.Entrant);
			EntrantFinished activity7 = new EntrantFinished(base.InstancedEvent, base.Entrant, -8193);
			EntrantFinished activity8 = new EntrantFinished(base.InstancedEvent, base.Entrant, 8202);
			KillAllFlashers item15 = new KillAllFlashers(base.InstancedEvent, base.Entrant);
			Conclude item16 = new Conclude(base.InstancedEvent, base.Entrant);
			SortEntrants item17 = new SortEntrants(base.InstancedEvent);
			ReportEntrantFinished item18 = new ReportEntrantFinished(base.InstancedEvent, base.Entrant);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerEnter> activity9 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerEnter>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerExit> activity10 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerExit>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			VehicleSpeedBasedReset activity11 = new VehicleSpeedBasedReset(base.Entrant, 0.1f);
			LoadBlackBoards item19 = new LoadBlackBoards(base.InstancedEvent, BlackBoardFlag.kBlackBoardFlag_Countdown);
			PauseDetected activity12 = new PauseDetected(base.InstancedEvent);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state2.EnterActivity.Activities.Add(item2);
				state2.EnterActivity.Activities.Add(item);
				state2.EnterActivity.Activities.Add(item3);
				state2.EnterActivity.Activities.Add(item4);
				state2.EnterActivity.Activities.Add(item6);
				state2.EnterActivity.Activities.Add(item7);
				state2.EnterActivity.Activities.Add(item5);
				state2.EnterActivity.Activities.Add(item8);
				state2.EnterActivity.Activities.Add(item19);
				state2.Transitions.Add(new Transition("running", activity));
				state2.Transitions.Add(new Transition("aborted", activity12));
				state2.ExitActivity.Activities.Add(item9);
				state2.ExitActivity.Activities.Add(item12);
				state2.ExitActivity.Activities.Add(item11);
				state2.ExitActivity.Activities.Add(item13);
				state2.ExitActivity.Activities.Add(item14);
			}
			else
			{
				state2.EnterActivity.Activities.Add(item2);
				state2.EnterActivity.Activities.Add(item);
				state2.EnterActivity.Activities.Add(item3);
				state2.EnterActivity.Activities.Add(item5);
				state2.Transitions.Add(new Transition("running", activity));
				state2.ExitActivity.Activities.Add(item12);
				state2.ExitActivity.Activities.Add(item11);
				state2.ExitActivity.Activities.Add(item13);
				state2.ExitActivity.Activities.Add(item14);
			}
			state3.EnterActivity.Activities.Add(item10);
			state3.Transitions.Add(new Transition(activity2));
			state3.Transitions.Add(new Transition(activity3));
			state3.Transitions.Add(new Transition(activity4));
			state3.Transitions.Add(new Transition(activity5));
			state3.Transitions.Add(new Transition(activity6));
			state3.Transitions.Add(new Transition(activity9));
			state3.Transitions.Add(new Transition(activity10));
			state3.Transitions.Add(new Transition(activity11));
			state3.Transitions.Add(new Transition("raceover", activity7));
			state3.Transitions.Add(new Transition("aborted", activity8));
			state3.ExitActivity.Activities.Add(item15);
			OverrideVehicleControl item20 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Stop);
			EnableReplication item21 = new EnableReplication(base.Entrant.Opponent.Vehicle, false);
			state4.EnterActivity.Activities.Add(item16);
			state4.EnterActivity.Activities.Add(item17);
			state4.EnterActivity.Activities.Add(item18);
			state4.EnterActivity.Activities.Add(item20);
			Abort item22 = new Abort(base.InstancedEvent, base.Entrant);
			state7.EnterActivity.Activities.Add(item22);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				LoadBlackBoards item23 = new LoadBlackBoards(base.Event, BlackBoardFlag.kBlackBoardFlag_Running);
				state3.EnterActivity.Activities.Add(item23);
				WrongWayNotification activity13 = new WrongWayNotification(base.InstancedEvent, base.Entrant);
				NavigateToGPSUpdater activity14 = new NavigateToGPSUpdater(base.InstancedEvent, base.Entrant, Ports.Gameplay);
				state3.Transitions.Add(new Transition(activity13));
				state3.Transitions.Add(new Transition(activity14));
				state4.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 2046860387u));
				state4.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_AI, 331198907u));
				state4.EnterActivity.Activities.Add(item6);
				state4.Transitions.Add(new Transition("post"));
				PostEventScreen activity15 = new PostEventScreen(base.InstancedEvent, base.Entrant, Ports.Gameplay);
				AbortEvent item24 = new AbortEvent(base.InstancedEvent);
				LobbyTick activity16 = new LobbyTick(0.25f);
				state5.Transitions.Add(new Transition(activity16));
				state5.Transitions.Add(new Transition("done", activity15));
				FinishEntrant item25 = new FinishEntrant(base.InstancedEvent, base.Entrant, FinishReason.PauseDetected);
				OverrideVehicleControl item26 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Release);
				state6.EnterActivity.Activities.Add(item25);
				state6.EnterActivity.Activities.Add(item15);
				state6.Transitions.Add(new Transition("aborted"));
				state7.EnterActivity.Activities.Add(item10);
				state8.EnterActivity.Activities.Add(item24);
				state8.EnterActivity.Activities.Add(item26);
			}
			else
			{
				state4.EnterActivity.Activities.Add(item21);
				state4.Transitions.Add(new Transition("done"));
			}
			state7.Transitions.Add(new Transition("done"));
			CleanupScoringMethod item27 = new CleanupScoringMethod(base.InstancedEvent, base.Entrant);
			state8.EnterActivity.Activities.Add(item27);
			stateGraph.InitialState = "initial";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state4);
			stateGraph.States.Add(state5);
			stateGraph.States.Add(state7);
			stateGraph.States.Add(state6);
			stateGraph.States.Add(state8);
			return stateGraph;
		}
	}
}

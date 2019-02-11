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
	// Token: 0x020001AA RID: 426
	public class EntrantTeamEscape : Activity
	{
		// Token: 0x06001403 RID: 5123 RVA: 0x0001FB4C File Offset: 0x0001EB4C
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph(string.Format("EntrantTeamEscape: {0}", base.Entrant.Opponent.OpponentName));
			State state = new State("initial");
			State state2 = new State("countdown");
			State state3 = new State("running");
			State state4 = new State("crossedfinish");
			State state5 = new State("raceover");
			State state6 = new State("post");
			State state7 = new State("aborted");
			State state8 = new State("done");
			AssignPursuitEscalation item = new AssignPursuitEscalation(base.InstancedEvent.EventDef.PursuitEscalation().GetKey());
			state.EnterActivity.Activities.Add(item);
			state.Transitions.Add(new Transition("countdown"));
			LockEntrant item2 = new LockEntrant(base.InstancedEvent, base.Entrant, true);
			PrepareScoringMethod item3 = new PrepareScoringMethod(base.InstancedEvent, base.Entrant);
			EntrantLoaded item4 = new EntrantLoaded(base.InstancedEvent, base.Entrant, "Entrants.Loading");
			EnableKeyboard item5 = new EnableKeyboard(true);
			EnableLoadingScreen item6 = new EnableLoadingScreen(false);
			FlushTraffic item7 = new FlushTraffic();
			LoadBlackBoards item8 = new LoadBlackBoards(base.Event, BlackBoardFlag.kBlackBoardFlag_Running);
			Countdown activity = new Countdown(base.InstancedEvent, base.Entrant);
			TryPerfectLaunch item9 = new TryPerfectLaunch(base.InstancedEvent, base.Entrant);
			GameCore.Workflow.Activities.WaitAll item10 = new GameCore.Workflow.Activities.WaitAll("Entrants.Countdown");
			SetSignal item11 = new SetSignal("Entrants.Countdown");
			UnSetSignal item12 = new UnSetSignal("Entrants.Countdown");
			Launch item13 = new Launch(base.InstancedEvent, base.Entrant);
			LockEntrant item14 = new LockEntrant(base.InstancedEvent, base.Entrant, false);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state2.EnterActivity.Activities.Add(item2);
				state2.EnterActivity.Activities.Add(item3);
				state2.EnterActivity.Activities.Add(item4);
				state2.EnterActivity.Activities.Add(item5);
				state2.EnterActivity.Activities.Add(item7);
				state2.EnterActivity.Activities.Add(item6);
				state2.EnterActivity.Activities.Add(item8);
				state2.Transitions.Add(new Transition("running", activity));
				state2.ExitActivity.Activities.Add(item9);
				state2.ExitActivity.Activities.Add(item11);
				state2.ExitActivity.Activities.Add(item10);
				state2.ExitActivity.Activities.Add(item12);
				state2.ExitActivity.Activities.Add(item13);
				state2.ExitActivity.Activities.Add(item14);
			}
			else
			{
				state2.EnterActivity.Activities.Add(item2);
				state2.EnterActivity.Activities.Add(item3);
				state2.EnterActivity.Activities.Add(item4);
				state2.EnterActivity.Activities.Add(item5);
				state2.EnterActivity.Activities.Add(item6);
				state2.Transitions.Add(new Transition("running", activity));
				state2.ExitActivity.Activities.Add(item11);
				state2.ExitActivity.Activities.Add(item10);
				state2.ExitActivity.Activities.Add(item12);
				state2.ExitActivity.Activities.Add(item13);
				state2.ExitActivity.Activities.Add(item14);
			}
			RoutingTriggered activity2 = new RoutingTriggered(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			Sequence sequence = new Sequence();
			GameCore.Workflow.Activities.WaitAll item15 = new GameCore.Workflow.Activities.WaitAll("TeamEscape.AllBusted");
			SetSignal item16 = new SetSignal("TeamEscape.AllBusted");
			FinishEntrant item17 = new FinishEntrant(base.InstancedEvent, base.Entrant, FinishReason.Busted);
			sequence.Activities.Add(item15);
			sequence.Activities.Add(item17);
			OnUpdateTick activity3 = new OnUpdateTick(base.InstancedEvent, base.Entrant);
			EntrantInterupt activity4 = new EntrantInterupt(base.InstancedEvent, base.Entrant, Ports.Gameplay, FinishReason.TimedOut);
			EntrantExtrapolate activity5 = new EntrantExtrapolate(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			EntrantDisconnected activity6 = new EntrantDisconnected(base.InstancedEvent, base.Entrant);
			EntrantFinishedFlasher activity7 = new EntrantFinishedFlasher(base.InstancedEvent, base.Entrant);
			WrongWayNotification activity8 = new WrongWayNotification(base.InstancedEvent, base.Entrant);
			NavigateToGPSUpdater activity9 = new NavigateToGPSUpdater(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			Sequence sequence2 = new Sequence();
			Timer item18 = new Timer(new InArgument<float>(new InArgumentHandler<float>(base.Event.EventDef.TimeLimit)));
			FinishEntrant item19 = new FinishEntrant(base.InstancedEvent, base.Entrant, FinishReason.TimeLimitExpired);
			sequence2.Activities.Add(item18);
			sequence2.Activities.Add(item19);
			EntrantPursuitSubgraph activity10 = new EntrantPursuitSubgraph(base.InstancedEvent, base.Entrant);
			Conclude item20 = new Conclude(base.InstancedEvent, base.Entrant);
			SortEntrants item21 = new SortEntrants(base.InstancedEvent);
			ReportEntrantFinished item22 = new ReportEntrantFinished(base.InstancedEvent, base.Entrant);
			KillPursuit item23 = new KillPursuit();
			Sequence sequence3 = new Sequence();
			GameCore.Activities.Components.CloseOnReceive<OnTimingOut> item24 = new GameCore.Activities.Components.CloseOnReceive<OnTimingOut>(Ports.Gameplay);
			ChangeBlackBoard item25 = new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 1482065563u);
			DisplayFlasher item26 = new DisplayFlasher(base.InstancedEvent, base.Entrant, new FormattedFlasher(758313117u, (int)base.Event.EventDef.TimeLimitWarning()));
			sequence3.Activities.Add(item24);
			sequence3.Activities.Add(item25);
			sequence3.Activities.Add(item26);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitEngaged> activity11 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitEngaged>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitCooldown> activity12 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitCooldown>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitEvaded> activity13 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitEvaded>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitBusted> activity14 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnPursuitBusted>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerEnter> activity15 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerEnter>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerExit> activity16 = new GameCore.Activities.Entrant.Components.SynchronizeOnReceive<OnTriggerExit>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			SetOpponentStatus item27 = new SetOpponentStatus(base.InstancedEvent, base.Entrant, OpponentStatus.kOpponent_NotSpectatable, true);
			ActivateSuddenDeath item28 = new ActivateSuddenDeath(base.InstancedEvent);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state3.Transitions.Add(new Transition(activity11));
				state3.Transitions.Add(new Transition(activity12));
				state3.Transitions.Add(new Transition(activity13));
				state3.Transitions.Add(new Transition(activity14));
				state3.Transitions.Add(new Transition(activity15));
				state3.Transitions.Add(new Transition(activity16));
				state3.Transitions.Add(new Transition(activity2));
				state3.Transitions.Add(new Transition(activity3));
				state3.Transitions.Add(new Transition(activity4));
				state3.Transitions.Add(new Transition(activity5));
				state3.Transitions.Add(new Transition(activity6));
				state3.Transitions.Add(new Transition(sequence));
				state3.Transitions.Add(new Transition(sequence2));
				state3.Transitions.Add(new Transition(sequence3));
				state3.Transitions.Add(new Transition(activity8));
				state3.Transitions.Add(new Transition(activity9));
				state3.Transitions.Add(new Transition("raceover", activity10));
				state3.ExitActivity.Activities.Add(item27);
				state3.ExitActivity.Activities.Add(item16);
				state3.ExitActivity.Activities.Add(item20);
				state3.ExitActivity.Activities.Add(item21);
				state3.ExitActivity.Activities.Add(item22);
				state3.ExitActivity.Activities.Add(item23);
			}
			else
			{
				state3.EnterActivity.Activities.Add(item14);
				state3.Transitions.Add(new Transition(activity2));
				state3.Transitions.Add(new Transition(activity3));
				state3.Transitions.Add(new Transition(activity4));
				state3.Transitions.Add(new Transition(activity5));
				state3.Transitions.Add(new Transition(activity6));
				state3.Transitions.Add(new Transition(activity7));
				state3.Transitions.Add(new Transition(sequence));
				state3.Transitions.Add(new Transition(sequence2));
				state3.Transitions.Add(new Transition("raceover", activity10));
				state3.ExitActivity.Activities.Add(item27);
				state3.ExitActivity.Activities.Add(item16);
				state3.ExitActivity.Activities.Add(item20);
				state3.ExitActivity.Activities.Add(item21);
				state3.ExitActivity.Activities.Add(item22);
			}
			EntrantFinished activity17 = new EntrantFinished(base.InstancedEvent, base.Entrant, -8209);
			EntrantFinished activity18 = new EntrantFinished(base.InstancedEvent, base.Entrant, 8202);
			EntrantFinished activity19 = new EntrantFinished(base.InstancedEvent, base.Entrant, 22);
			OverrideVehicleControl item29 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Coast);
			EnableReplication item30 = new EnableReplication(base.Entrant.Opponent.Vehicle, false);
			state5.EnterActivity.Activities.Add(item29);
			state5.EnterActivity.Activities.Add(item30);
			state5.Transitions.Add(new Transition("crossedfinish", activity19));
			state5.Transitions.Add(new Transition("post", activity17));
			state5.Transitions.Add(new Transition("aborted", activity18));
			state4.EnterActivity.Activities.Add(item28);
			state4.Transitions.Add(new Transition("post"));
			if (base.Entrant.Opponent is RemoteHumanOpponent)
			{
				Abort item31 = new Abort(base.InstancedEvent, base.Entrant);
				state7.EnterActivity.Activities.Add(item31);
			}
			state7.Transitions.Add(new Transition("done"));
			PostEventScreen activity20 = new PostEventScreen(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			ChangeBlackBoard item32 = new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 4088298651u);
			EntrantBustedAudio item33 = new EntrantBustedAudio(base.InstancedEvent, base.Entrant);
			AbortEvent item34 = new AbortEvent(base.InstancedEvent);
			FlushCops item35 = new FlushCops();
			ChangeBlackBoard item36 = new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_AI, 331198907u);
			LobbyTick activity21 = new LobbyTick(0.25f);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state6.EnterActivity.Activities.Add(item32);
				state6.EnterActivity.Activities.Add(item36);
				state6.EnterActivity.Activities.Add(item35);
				state6.EnterActivity.Activities.Add(item7);
				state6.Transitions.Add(new Transition(activity21));
				state6.Transitions.Add(new Transition(activity6));
				state6.Transitions.Add(new Transition("done", activity20));
				state6.EnterActivity.Activities.Add(item33);
				state6.ExitActivity.Activities.Add(item34);
			}
			else
			{
				state6.Transitions.Add(new Transition("done"));
			}
			CleanupScoringMethod item37 = new CleanupScoringMethod(base.InstancedEvent, base.Entrant);
			OverrideVehicleControl item38 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Release);
			RefreshPersona item39 = new RefreshPersona(base.Event, base.Entrant);
			state8.EnterActivity.Activities.Add(item38);
			state8.EnterActivity.Activities.Add(item37);
			state8.EnterActivity.Activities.Add(item39);
			stateGraph.InitialState = "initial";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state5);
			stateGraph.States.Add(state4);
			stateGraph.States.Add(state6);
			stateGraph.States.Add(state7);
			stateGraph.States.Add(state8);
			return stateGraph;
		}
	}
}

using System;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Components;
using GameCore.Activities.Event.Components;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Entrant.Graphs
{
	// Token: 0x020001A6 RID: 422
	public class EntrantMeeting : Activity
	{
		// Token: 0x060013FA RID: 5114 RVA: 0x0001DBBC File Offset: 0x0001CBBC
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph(string.Format("EntrantMeeting: {0}", base.Entrant.Opponent.OpponentName));
			State state = new State("initial");
			State state2 = new State("running");
			State state3 = new State("done");
			LockEntrant item = new LockEntrant(base.InstancedEvent, base.Entrant, true);
			PrepareScoringMethod item2 = new PrepareScoringMethod(base.InstancedEvent, base.Entrant);
			EntrantLoaded item3 = new EntrantLoaded(base.InstancedEvent, base.Entrant, "Entrants.Loading");
			EnableKeyboard item4 = new EnableKeyboard(true);
			EnableLoadingScreen item5 = new EnableLoadingScreen(false);
			LoadBlackBoards item6 = new LoadBlackBoards(base.Event, BlackBoardFlag.kBlackBoardFlag_Running);
			state.EnterActivity.Activities.Add(item);
			state.EnterActivity.Activities.Add(item2);
			state.EnterActivity.Activities.Add(item3);
			state.EnterActivity.Activities.Add(item4);
			state.EnterActivity.Activities.Add(item5);
			state.EnterActivity.Activities.Add(item6);
			state.Transitions.Add(new Transition("running"));
			LockEntrant item7 = new LockEntrant(base.InstancedEvent, base.Entrant, false);
			Abort item8 = new Abort(base.InstancedEvent, base.Entrant);
			EntrantDisconnected activity = new EntrantDisconnected(base.InstancedEvent, base.Entrant);
			EntrantFinished activity2 = new EntrantFinished(base.InstancedEvent, base.Entrant, -1);
			state2.EnterActivity.Activities.Add(item7);
			state2.Transitions.Add(new Transition(activity));
			state2.Transitions.Add(new Transition("done", activity2));
			state2.ExitActivity.Activities.Add(item8);
			CleanupScoringMethod item9 = new CleanupScoringMethod(base.InstancedEvent, base.Entrant);
			OverrideVehicleControl item10 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Release);
			state3.EnterActivity.Activities.Add(item10);
			state3.EnterActivity.Activities.Add(item9);
			stateGraph.InitialState = "initial";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			return stateGraph;
		}
	}
}

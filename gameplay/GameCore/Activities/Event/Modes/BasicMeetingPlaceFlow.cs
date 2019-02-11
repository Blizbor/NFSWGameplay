using System;
using System.IO;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Graphs;
using GameCore.Activities.Event.Components;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event.Modes
{
	// Token: 0x020001DD RID: 477
	public class BasicMeetingPlaceFlow : Mode
	{
		// Token: 0x060014B2 RID: 5298 RVA: 0x00022DD1 File Offset: 0x00021DD1
		public static object Construct(BinaryReader source)
		{
			return new BasicMeetingPlaceFlow();
		}

		// Token: 0x060014B3 RID: 5299 RVA: 0x00022DD8 File Offset: 0x00021DD8
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph("BasicMeetingPlaceFlow");
			State state = new State("running");
			State state2 = new State("loading");
			State state3 = new State("disconnected");
			State state4 = new State("done");
			new Sequence();
			EnableLoadingScreen item = new EnableLoadingScreen(true);
			RelaySync item2 = new RelaySync(0.1f);
			BeginEventSecurity item3 = new BeginEventSecurity();
			LoadBlackBoards item4 = new LoadBlackBoards(base.InstancedEvent, BlackBoardFlag.kBlackBoardFlag_Loading);
			AddOpponents item5 = new AddOpponents(base.InstancedEvent);
			EventBarriers item6 = new EventBarriers(base.InstancedEvent, true);
			WaitForOpponentsReady item7 = new WaitForOpponentsReady(base.InstancedEvent, 0.1f);
			CommitAllAssets item8 = new CommitAllAssets();
			PlaceAtLocators item9 = new PlaceAtLocators(base.InstancedEvent);
			EnableHud item10 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Enable);
			GameCore.Activities.Event.Components.AssignPowerupConfiguration item11 = new GameCore.Activities.Event.Components.AssignPowerupConfiguration(base.InstancedEvent);
			SetCameraBounds item12 = new SetCameraBounds(base.InstancedEvent, true);
			Running<EntrantMeeting> activity = new Running<EntrantMeeting>(base.InstancedEvent, new string[]
			{
				"Entrants.Loading"
			});
			SetCameraBounds item13 = new SetCameraBounds(base.InstancedEvent, false);
			EnableHud item14 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Dispose);
			EventBarriers item15 = new EventBarriers(base.InstancedEvent, false);
			RemoveAllOpponentsExceptLocalPlayer item16 = new RemoveAllOpponentsExceptLocalPlayer(base.InstancedEvent);
			CleanupEvent item17 = new CleanupEvent(base.InstancedEvent);
			CleanupGrid item18 = new CleanupGrid(base.InstancedEvent);
			CheckOpponentDisconnected activity2 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, false);
			CheckOpponentDisconnected activity3 = new CheckOpponentDisconnected(base.InstancedEvent.Manager, true);
			state2.EnterActivity.Activities.Add(item);
			state2.EnterActivity.Activities.Add(item3);
			state2.EnterActivity.Activities.Add(item4);
			state2.EnterActivity.Activities.Add(item2);
			state2.EnterActivity.Activities.Add(item5);
			state2.EnterActivity.Activities.Add(item6);
			state2.EnterActivity.Activities.Add(item7);
			state2.EnterActivity.Activities.Add(item8);
			state2.EnterActivity.Activities.Add(item9);
			state2.EnterActivity.Activities.Add(item12);
			state2.EnterActivity.Activities.Add(item10);
			state2.EnterActivity.Activities.Add(item11);
			state2.Transitions.Add(new Transition("disconnected", activity3));
			state2.Transitions.Add(new Transition("running", activity2));
			state.Transitions.Add(new Transition("done", activity));
			EnableLoadingScreen item19 = new EnableLoadingScreen(false);
			state3.EnterActivity.Activities.Add(item19);
			state3.Transitions.Add(new Transition("done"));
			state4.EnterActivity.Activities.Add(item14);
			state4.EnterActivity.Activities.Add(item18);
			state4.EnterActivity.Activities.Add(item15);
			state4.EnterActivity.Activities.Add(item16);
			state4.EnterActivity.Activities.Add(item13);
			state4.EnterActivity.Activities.Add(item17);
			state3.EnterActivity.Activities.Add(item19);
			state3.Transitions.Add(new Transition("done"));
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

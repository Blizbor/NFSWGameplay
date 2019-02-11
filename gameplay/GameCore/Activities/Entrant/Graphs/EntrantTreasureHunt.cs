using System;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Components;
using GameCore.Activities.Event.Components;
using GameCore.Messages;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Entrant.Graphs
{
	// Token: 0x020001AB RID: 427
	public class EntrantTreasureHunt : Activity
	{
		// Token: 0x06001405 RID: 5125 RVA: 0x00020834 File Offset: 0x0001F834
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph(string.Format("OpponentTreasureHunt: {0}", base.Entrant.Opponent.OpponentName));
			State state = new State("initial");
			State state2 = new State("hunting");
			State state3 = new State("collected");
			State state4 = new State("huntover");
			State item = new State("done");
			PrepareScoringMethod item2 = new PrepareScoringMethod(base.Event, base.Entrant);
			SendNews item3 = new SendNews(base.Event, base.Entrant);
			EnableHud item4 = new EnableHud(base.Event, EnableHud.HudToggle.Enable);
			OnUpdateTick activity = new OnUpdateTick(base.Event, base.Entrant);
			DisableTriggerOnEnter activity2 = new DisableTriggerOnEnter(base.Event, base.Entrant, Ports.Gameplay);
			DisplayFlasher item5 = new DisplayFlasher(base.Event, base.Entrant, this.allCoinsCollectedFlasher);
			RemoveFlasher item6 = new RemoveFlasher(base.Event, base.Entrant, this.allCoinsCollectedFlasher);
			EnableHud item7 = new EnableHud(base.Event, EnableHud.HudToggle.Dispose);
			CleanupScoringMethod item8 = new CleanupScoringMethod(base.Event, base.Entrant);
			EntrantFinished activity3 = new EntrantFinished(base.Event, base.Entrant, 8202);
			PostEventScreen activity4 = new PostEventScreen(base.Event, base.Entrant, Ports.Gameplay);
			RefreshPersona item9 = new RefreshPersona(base.Event, base.Entrant);
			VisualEffect item10 = new VisualEffect(EffectType.TREASURE_HUNT_ICON_PICKUP);
			GameCore.Activities.Components.CloseOnReceive<OnHuntCompleted> activity5 = new GameCore.Activities.Components.CloseOnReceive<OnHuntCompleted>(Ports.Gameplay);
			GameCore.Activities.Components.CloseOnReceive<OnHuntContinued> activity6 = new GameCore.Activities.Components.CloseOnReceive<OnHuntContinued>(Ports.Gameplay);
			CoinCollected item11 = new CoinCollected(base.Event, base.Entrant);
			OverrideVehicleControl item12 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Coast);
			OverrideVehicleControl item13 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Release);
			ChangeBlackBoard item14 = new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_AI, 331198907u);
			DisconnectFromRoaming item15 = new DisconnectFromRoaming();
			state.EnterActivity.Activities.Add(item4);
			state.EnterActivity.Activities.Add(item2);
			state.EnterActivity.Activities.Add(item3);
			state.Transitions.Add(new Transition("hunting"));
			state2.Transitions.Add(new Transition(activity));
			state2.Transitions.Add(new Transition("collected", activity2));
			state2.Transitions.Add(new Transition("done", activity3));
			state3.EnterActivity.Activities.Add(item4);
			state3.EnterActivity.Activities.Add(item10);
			state3.Transitions.Add(new Transition("huntover", activity5));
			state3.Transitions.Add(new Transition("hunting", activity6));
			state3.ExitActivity.Activities.Add(item11);
			state4.EnterActivity.Activities.Add(item15);
			state4.EnterActivity.Activities.Add(item12);
			state4.EnterActivity.Activities.Add(item14);
			state4.EnterActivity.Activities.Add(item5);
			state4.EnterActivity.Activities.Add(new Timer(new InArgument<float>(() => 3f)));
			state4.EnterActivity.Activities.Add(item6);
			state4.Transitions.Add(new Transition("done", activity4));
			state4.ExitActivity.Activities.Add(item9);
			state4.ExitActivity.Activities.Add(item7);
			state4.ExitActivity.Activities.Add(item8);
			state4.ExitActivity.Activities.Add(item13);
			stateGraph.InitialState = "initial";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state4);
			stateGraph.States.Add(item);
			return stateGraph;
		}

		// Token: 0x040004B2 RID: 1202
		private FlasherBase allCoinsCollectedFlasher = new FlasherBase(1267292714u);
	}
}

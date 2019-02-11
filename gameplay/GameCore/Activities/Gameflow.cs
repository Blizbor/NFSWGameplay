using System;
using GameCore.Activities.Components;
using GameCore.Messages;
using GameCore.Workflow;
using GameCore.Workflow.Activities;
using UMath;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities
{
	// Token: 0x020001E3 RID: 483
	public class Gameflow : StateGraph
	{
		// Token: 0x060014CE RID: 5326 RVA: 0x000244BC File Offset: 0x000234BC
		public Gameflow(Manager manager) : base("Gameflow.StateGraph")
		{
			this.manager = manager;
		}

		// Token: 0x060014CF RID: 5327 RVA: 0x00024520 File Offset: 0x00023520
		protected internal override void BuildGraph()
		{
			State state = new State("initial");
			State state2 = new State("safehouse");
			State state3 = new State("store");
			State state4 = new State("freeroam");
			State state5 = new State("lobby");
			State state6 = new State("recover");
			State state7 = new State("reset");
			State state8 = new State("event");
			State state9 = new State("done");
			ResetProps item = new ResetProps();
			CloseOnReceive<OnEnterStore> activity = new CloseOnReceive<OnEnterStore>(Ports.Gameplay);
			CloseOnReceive<OnReturnToPreviousState> activity2 = new CloseOnReceive<OnReturnToPreviousState>(Ports.Gameplay);
			CloseOnReceive<OnEnterFreeroam> activity3 = new CloseOnReceive<OnEnterFreeroam>(Ports.Gameplay);
			EnableGadget item2 = new EnableGadget("Overlay", EnableGadget.HudToggle.Enable);
			EnableGadget item3 = new EnableGadget("Overlay", EnableGadget.HudToggle.Dispose);
			EnableGadget item4 = new EnableGadget("PowerupBuffBar", EnableGadget.HudToggle.Dispose);
			EnableGadget item5 = new EnableGadget("PowerupBuffBar", EnableGadget.HudToggle.Enable);
			EnableLoadingScreen item6 = new EnableLoadingScreen(false);
			state.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 2215583664u));
			state.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_AI, 1667320711u));
			state.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Frontend, 1039281932u));
			state.Transitions.Add(new Transition("freeroam", activity3));
			state.ExitActivity.Activities.Add(item5);
			state.ExitActivity.Activities.Add(item2);
			state2.EnterActivity.Activities.Add(item4);
			state2.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 2215583664u));
			state2.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_AI, 1667320711u));
			state2.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Frontend, 1039281932u));
			state2.Transitions.Add(new Transition("store", activity));
			state2.Transitions.Add(new Transition("freeroam", activity3));
			state2.ExitActivity.Activities.Add(item5);
			ClearAllBuff item7 = new ClearAllBuff();
			state3.EnterActivity.Activities.Add(item7);
			state3.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 1950424019u));
			state3.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Frontend, 2145842197u));
			state3.Transitions.Add(new ReturnTransition(activity2));
			ResetLobby item8 = new ResetLobby();
			CloseOnReceive<OnEnterSafeHouse> activity4 = new CloseOnReceive<OnEnterSafeHouse>(Ports.Gameplay);
			RefreshEvents item9 = new RefreshEvents();
			GetAndTriggerAvailableLevelGifts item10 = new GetAndTriggerAvailableLevelGifts();
			ResetHeat item11 = new ResetHeat();
			EnablePointsOfInterest item12 = new EnablePointsOfInterest(3312964337u, true);
			ConnectToRoaming item13 = new ConnectToRoaming();
			LockLocalVehicle item14 = new LockLocalVehicle(false);
			AssignPowerupConfiguration item15 = new AssignPowerupConfiguration(PowerupConfiguration.kPowerupConfigFreeRoam);
			RechargeAllPowerups item16 = new RechargeAllPowerups();
			EnterEngagableTriggered activity5 = new EnterEngagableTriggered(this.manager, Ports.Gameplay);
			EnterEventTriggered enterEventTriggered = new EnterEventTriggered(Ports.Gameplay);
			enterEventTriggered.EventSessionId = new OutArgument<long>(this.eventSessionId);
			enterEventTriggered.EventKey = new OutArgument<uint>(this.eventKey);
			enterEventTriggered.ConnectionSupport = new OutArgument<ConnectionSupport>(this.connectionSupport);
			ExitEngagableTriggered activity6 = new ExitEngagableTriggered(this.manager, Ports.Gameplay);
			Loop loop = new Loop();
			TeleportToTriggered teleportToTriggered = new TeleportToTriggered(Ports.Gameplay);
			teleportToTriggered.Position = new OutArgument<Vector3>(this.teleportPosition);
			teleportToTriggered.Direction = new OutArgument<Vector3>(this.teleportDirection);
			EnableLoadingScreen item17 = new EnableLoadingScreen(true);
			TeleportTo teleportTo = new TeleportTo();
			teleportTo.Position = new InArgument<Vector3>(this.teleportPosition);
			teleportTo.Direction = new InArgument<Vector3>(this.teleportDirection);
			WaitForLoading item18 = new WaitForLoading(0f);
			loop.Activities.Add(teleportToTriggered);
			loop.Activities.Add(item17);
			loop.Activities.Add(teleportTo);
			loop.Activities.Add(item18);
			loop.Activities.Add(item6);
			DisconnectFromRoaming item19 = new DisconnectFromRoaming();
			EnablePointsOfInterest item20 = new EnablePointsOfInterest(3312964337u, false);
			RunAsyncEvent runAsyncEvent = new RunAsyncEvent(this.manager);
			runAsyncEvent.EventKey = new InArgument<uint>(Hash.Hash32("events/treasure_hunt_001"));
			AssignPursuitEscalation item21 = new AssignPursuitEscalation(4085894198u);
			EnterLobbyTriggered enterLobbyTriggered = new EnterLobbyTriggered(Ports.Gameplay);
			enterLobbyTriggered.EventKey = new OutArgument<uint>(this.eventKey);
			state4.EnterActivity.Activities.Add(item8);
			state4.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 2781049312u));
			state4.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_AI, 2681735821u));
			state4.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Frontend, 3615492632u));
			state4.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_WorldMap, "worldmap_freeroam"));
			state4.EnterActivity.Activities.Add(item);
			state4.EnterActivity.Activities.Add(item9);
			state4.EnterActivity.Activities.Add(item10);
			state4.EnterActivity.Activities.Add(item11);
			state4.EnterActivity.Activities.Add(item12);
			state4.EnterActivity.Activities.Add(item13);
			state4.EnterActivity.Activities.Add(item15);
			state4.EnterActivity.Activities.Add(item16);
			state4.EnterActivity.Activities.Add(item21);
			state4.EnterActivity.Activities.Add(item14);
			state4.EnterActivity.Activities.Add(item18);
			state4.EnterActivity.Activities.Add(item6);
			state4.Transitions.Add(new Transition(activity5));
			state4.Transitions.Add(new Transition("event", enterEventTriggered));
			state4.Transitions.Add(new Transition(activity6));
			state4.Transitions.Add(new Transition("safehouse", activity4));
			state4.Transitions.Add(new Transition("store", activity));
			state4.Transitions.Add(new Transition("reset", runAsyncEvent));
			state4.Transitions.Add(new Transition("lobby", enterLobbyTriggered));
			state4.Transitions.Add(new Transition(loop));
			state4.ExitActivity.Activities.Add(item19);
			state4.ExitActivity.Activities.Add(item20);
			state4.ExitActivity.Activities.Add(item16);
			state7.Transitions.Add(new Transition("freeroam"));
			LoadEventVault loadEventVault = new LoadEventVault();
			loadEventVault.EventKey = new InArgument<uint>(this.eventKey);
			StartStreamingAtEvent startStreamingAtEvent = new StartStreamingAtEvent();
			startStreamingAtEvent.EventKey = new InArgument<uint>(this.eventKey);
			AcceptInvite item22 = new AcceptInvite();
			CloseOnReceive<OnLobbyCancelled> activity7 = new CloseOnReceive<OnLobbyCancelled>(Ports.Gameplay);
			CloseOnReceive<OnLobbyFailed> activity8 = new CloseOnReceive<OnLobbyFailed>(Ports.Gameplay);
			CloseOnReceive<OnLobbyExited> activity9 = new CloseOnReceive<OnLobbyExited>(Ports.Gameplay);
			IsStuckInLobby activity10 = new IsStuckInLobby(0.25f);
			LobbyTick activity11 = new LobbyTick(0.25f);
			LockLocalVehicle item23 = new LockLocalVehicle(true);
			state5.EnterActivity.Activities.Add(item22);
			state5.EnterActivity.Activities.Add(item23);
			state5.EnterActivity.Activities.Add(item6);
			state5.EnterActivity.Activities.Add(new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Frontend, 701743214u));
			state5.EnterActivity.Activities.Add(loadEventVault);
			state5.EnterActivity.Activities.Add(startStreamingAtEvent);
			state5.Transitions.Add(new Transition("event", enterEventTriggered));
			state5.Transitions.Add(new Transition("freeroam", activity7));
			state5.Transitions.Add(new Transition("freeroam", activity8));
			state5.Transitions.Add(new Transition("freeroam", activity9));
			state5.Transitions.Add(new Transition("freeroam", activity10));
			state5.Transitions.Add(new Transition(activity11));
			state5.ExitActivity.Activities.Add(item17);
			RunEvent runEvent = new RunEvent(this.manager);
			runEvent.EventSessionId = new InArgument<long>(this.eventSessionId);
			runEvent.EventKey = new InArgument<uint>(this.eventKey);
			runEvent.ConnectionSupport = new InArgument<ConnectionSupport>(this.connectionSupport);
			state8.EnterActivity.Activities.Add(item);
			state8.Transitions.Add(new Transition("recover", runEvent));
			CloseOnExitPath activity12 = new CloseOnExitPath(ExitPath.ExitToLobby, false);
			CloseOnExitPath activity13 = new CloseOnExitPath(ExitPath.ExitToFreeroam, true);
			state6.Transitions.Add(new Transition("lobby", activity12));
			state6.Transitions.Add(new Transition("freeroam", activity13));
			state9.EnterActivity.Activities.Add(item3);
			base.InitialState = "initial";
			base.DoneState = "done";
			base.States.Add(state);
			base.States.Add(state2);
			base.States.Add(state3);
			base.States.Add(state4);
			base.States.Add(state5);
			base.States.Add(state6);
			base.States.Add(state7);
			base.States.Add(state8);
			base.States.Add(state9);
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00024E8D File Offset: 0x00023E8D
		public static WorkflowElement Create(Manager manager)
		{
			return new Gameflow(manager);
		}

		// Token: 0x040004E0 RID: 1248
		private readonly Manager manager;

		// Token: 0x040004E1 RID: 1249
		private Variable<long> eventSessionId = new Variable<long>();

		// Token: 0x040004E2 RID: 1250
		private Variable<uint> eventKey = new Variable<uint>();

		// Token: 0x040004E3 RID: 1251
		private Variable<ConnectionSupport> connectionSupport = new Variable<ConnectionSupport>();

		// Token: 0x040004E4 RID: 1252
		private Variable<int> heat = new Variable<int>();

		// Token: 0x040004E5 RID: 1253
		private Variable<Vector3> teleportPosition = new Variable<Vector3>();

		// Token: 0x040004E6 RID: 1254
		private Variable<Vector3> teleportDirection = new Variable<Vector3>();
	}
}

using System;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Components;
using GameCore.Activities.Event.Components;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;
using UMath;
using Victory.DataLayer.Serialization.Event;

namespace GameCore.Activities.Entrant.Graphs
{
	// Token: 0x020001A9 RID: 425
	public class EntrantPursuitSubgraph : Activity
	{
		// Token: 0x060013FF RID: 5119 RVA: 0x0001EF18 File Offset: 0x0001DF18
		public EntrantPursuitSubgraph(InstancedEvent evnt, EntrantInfo entrant) : base(evnt, entrant)
		{
		}

		// Token: 0x06001400 RID: 5120 RVA: 0x0001EF78 File Offset: 0x0001DF78
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph(string.Format("OpponentPursuitSubgraph: {0}", base.Entrant.Opponent.OpponentName));
			State state = new State("initial");
			State state2 = new State("inpursuit");
			State state3 = new State("busted");
			State state4 = new State("spectate");
			State state5 = new State("respawn");
			State state6 = new State("ghost");
			State state7 = new State("post");
			State item = new State("done");
			LaunchPursuitByEventHeat item2 = new LaunchPursuitByEventHeat(base.Event);
			new GameCore.Activities.Entrant.Components.CloseOnReceive<OnPursuitEngaged>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			GameCore.Activities.Entrant.Components.CloseOnReceive<OnPursuitBusted> activity = new GameCore.Activities.Entrant.Components.CloseOnReceive<OnPursuitBusted>(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			EntrantFinished activity2 = new EntrantFinished(base.InstancedEvent, base.Entrant, -1);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state.EnterActivity.Activities.Add(item2);
				state.Transitions.Add(new Transition("inpursuit"));
			}
			else
			{
				state.Transitions.Add(new Transition("inpursuit"));
			}
			ReinitiatePursuit item3 = new ReinitiatePursuit();
			RadialBustMeterLogic activity3 = new RadialBustMeterLogic(base.InstancedEvent, base.Entrant);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state2.EnterActivity.Activities.Add(item3);
				state2.Transitions.Add(new Transition("busted", activity));
				state2.Transitions.Add(new Transition("post", activity2));
				state2.Transitions.Add(new Transition(activity3));
			}
			else
			{
				state2.Transitions.Add(new Transition("busted", activity));
				state2.Transitions.Add(new Transition("post", activity2));
			}
			Timer activity4 = new Timer(new InArgument<float>(new InArgumentHandler<float>(base.Event.EventDef.SpectateTime)));
			SetSignal item4 = new SetSignal("TeamEscape.AllBusted");
			UnSetSignal item5 = new UnSetSignal("TeamEscape.AllBusted");
			RespawnFlasher flasher = new RespawnFlasher(base.Event.EventDef.SpectateTime() * 1000f);
			SetOpponentStatus item6 = new SetOpponentStatus(base.InstancedEvent, base.Entrant, OpponentStatus.kOpponent_NotSpectatable, true);
			SetOpponentStatus item7 = new SetOpponentStatus(base.InstancedEvent, base.Entrant, OpponentStatus.kOpponent_NotSpectatable, false);
			EntrantHighlight item8 = new EntrantHighlight(base.InstancedEvent, base.Entrant, EntrantHighlight.kHighlight_Red);
			DisplayFlasher item9 = new DisplayFlasher(base.InstancedEvent, base.Entrant, this.localBustedFlasher, true);
			HideFlasher item10 = new HideFlasher(base.InstancedEvent, base.Entrant, this.localBustedFlasher);
			DisplayFlasher item11 = new DisplayFlasher(base.InstancedEvent, base.Entrant, new FormattedFlasher(2571601381u, base.Entrant.Opponent.ToString()));
			GameCore.Activities.Entrant.Components.EnableGadget item12 = new GameCore.Activities.Entrant.Components.EnableGadget(base.InstancedEvent, base.Entrant, "TeamEscapePursuitBarGadget", GameCore.Activities.Entrant.Components.EnableGadget.GadgetToggle.Disable);
			HideAllGadgetsButThese item13 = new HideAllGadgetsButThese(base.InstancedEvent, base.Entrant, new string[]
			{
				"FlasherGadget",
				"Chat",
				"MultiplayerPursuitHUD",
				"Options"
			});
			SetCamera item14 = new SetCamera(base.InstancedEvent, base.Entrant, "CDActionSpectate");
			WaitForLoading item15 = new WaitForLoading(0.25f);
			GetSpectateTargetPosition getSpectateTargetPosition = new GetSpectateTargetPosition(base.InstancedEvent);
			getSpectateTargetPosition.SpectateTargetPersonaId = new OutArgument<long>(this.spectateTargetPersonaId);
			getSpectateTargetPosition.Position = new OutArgument<Vector3>(this.warpPosition);
			getSpectateTargetPosition.Direction = new OutArgument<Vector3>(this.warpDirection);
			getSpectateTargetPosition.Mps = new OutArgument<float>(this.warpMps);
			OverrideVehicleControl item16 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Stop);
			DisplayFlasher item17 = new DisplayFlasher(base.InstancedEvent, base.Entrant, flasher);
			HideFlasher item18 = new HideFlasher(base.InstancedEvent, base.Entrant, flasher);
			SendRespawnMessage item19 = new SendRespawnMessage(base.InstancedEvent, base.Entrant, new InArgument<long>(this.spectateTargetPersonaId));
			WaitForRespawnMessage activity5 = new WaitForRespawnMessage(base.InstancedEvent, base.Entrant, Ports.Gameplay, new OutArgument<long>(this.spectateTargetPersonaId));
			WaitForAvailableStrike activity6 = new WaitForAvailableStrike(base.InstancedEvent, base.Entrant, Ports.Gameplay);
			FinishEntrant activity7 = new FinishEntrant(base.InstancedEvent, base.Entrant, FinishReason.Busted);
			EntrantBustedAudio item20 = new EntrantBustedAudio(base.InstancedEvent, base.Entrant);
			state3.EnterActivity.Activities.Add(item4);
			state3.EnterActivity.Activities.Add(item8);
			state3.EnterActivity.Activities.Add(item6);
			state3.EnterActivity.Activities.Add(item20);
			state3.Transitions.Add(new Transition("spectate", activity6));
			state3.Transitions.Add(new Transition(activity7));
			state3.Transitions.Add(new Transition("post", activity2));
			state3.ExitActivity.Activities.Add(item5);
			ChangeBlackBoard item21 = new ChangeBlackBoard(BlackBoardChannel.kBlackBoard_Audio, 3285804633u);
			CacheBlackBoard cacheBlackBoard = new CacheBlackBoard(BlackBoardChannel.kBlackBoard_Audio);
			cacheBlackBoard.BlackboardKey = new OutArgument<uint>(this.cachedAudioBlackBoard);
			UncacheBlackBoard uncacheBlackBoard = new UncacheBlackBoard(BlackBoardChannel.kBlackBoard_Audio);
			uncacheBlackBoard.BlackboardKey = new InArgument<uint>(this.cachedAudioBlackBoard);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state4.EnterActivity.Activities.Add(item4);
				state4.EnterActivity.Activities.Add(item16);
				state4.EnterActivity.Activities.Add(item12);
				state4.EnterActivity.Activities.Add(item9);
				state4.EnterActivity.Activities.Add(item13);
				state4.EnterActivity.Activities.Add(item14);
				state4.EnterActivity.Activities.Add(item15);
				state4.EnterActivity.Activities.Add(item10);
				state4.EnterActivity.Activities.Add(item17);
				state4.EnterActivity.Activities.Add(cacheBlackBoard);
				state4.EnterActivity.Activities.Add(item21);
				state4.Transitions.Add(new Transition("ghost", activity4));
				state4.Transitions.Add(new Transition("post", activity2));
				state4.ExitActivity.Activities.Add(getSpectateTargetPosition);
				state4.ExitActivity.Activities.Add(item19);
				state4.ExitActivity.Activities.Add(item18);
				state4.ExitActivity.Activities.Add(item5);
				state4.ExitActivity.Activities.Add(uncacheBlackBoard);
			}
			else
			{
				state4.EnterActivity.Activities.Add(item4);
				state4.EnterActivity.Activities.Add(item16);
				state4.EnterActivity.Activities.Add(item11);
				state4.Transitions.Add(new Transition("ghost", activity5));
				state4.Transitions.Add(new Transition("post", activity2));
				state4.ExitActivity.Activities.Add(item5);
			}
			Timer activity8 = new Timer(new InArgument<float>(() => 0.5f));
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state5.Transitions.Add(new Transition("ghost", activity8));
			}
			else
			{
				state5.Transitions.Add(new Transition("ghost"));
			}
			UnHideAllGadgets item22 = new UnHideAllGadgets(base.InstancedEvent, base.Entrant);
			Timer activity9 = new Timer(new InArgument<float>(new InArgumentHandler<float>(base.Event.EventDef.GhostDebuffTime)));
			EnableGhosting item23 = new EnableGhosting(base.InstancedEvent, base.Entrant, true, base.Event.EventDef.GhostDebuffTime());
			GameCore.Activities.Entrant.Components.EnableGadget item24 = new GameCore.Activities.Entrant.Components.EnableGadget(base.InstancedEvent, base.Entrant, "TeamEscapePursuitBarGadget", GameCore.Activities.Entrant.Components.EnableGadget.GadgetToggle.Enable);
			EnableGhosting item25 = new EnableGhosting(base.InstancedEvent, base.Entrant, false);
			RepairTires item26 = new RepairTires(base.InstancedEvent, base.Entrant, base.InstancedEvent.EventDef.GhostDebuffTime());
			EntrantHighlight item27 = new EntrantHighlight(base.InstancedEvent, base.Entrant, EntrantHighlight.kHighlight_None);
			SetCamera item28 = new SetCamera(base.InstancedEvent, base.Entrant, "CDActionDrive");
			GameCore.Activities.Entrant.Components.WarpTo warpTo = new GameCore.Activities.Entrant.Components.WarpTo(base.InstancedEvent, base.Entrant);
			warpTo.Position = new InArgument<Vector3>(this.warpPosition);
			warpTo.Direction = new InArgument<Vector3>(this.warpDirection);
			warpTo.Mps = new InArgument<float>(this.warpMps);
			OverrideVehicleControl item29 = new OverrideVehicleControl(base.Entrant.Opponent.Vehicle, OverrideVehicleControl.Control.Release);
			CopyRoutingState item30 = new CopyRoutingState(base.InstancedEvent, base.Entrant, new InArgument<long>(this.spectateTargetPersonaId));
			RechargeAllPowerups item31 = new RechargeAllPowerups();
			OverridePursuitBar item32 = new OverridePursuitBar(base.InstancedEvent, base.Entrant, 0f);
			if (base.Entrant.Opponent is LocalHumanOpponent)
			{
				state6.EnterActivity.Activities.Add(item22);
				state6.EnterActivity.Activities.Add(item32);
				state6.EnterActivity.Activities.Add(item29);
				state6.EnterActivity.Activities.Add(warpTo);
				state6.EnterActivity.Activities.Add(item23);
				state6.EnterActivity.Activities.Add(item30);
				state6.EnterActivity.Activities.Add(item12);
				state6.EnterActivity.Activities.Add(item31);
				state6.EnterActivity.Activities.Add(item28);
				state6.EnterActivity.Activities.Add(item7);
				state6.EnterActivity.Activities.Add(item27);
				state6.EnterActivity.Activities.Add(item26);
				state6.Transitions.Add(new Transition("inpursuit", activity9));
				state6.Transitions.Add(new Transition("post", activity2));
				state6.ExitActivity.Activities.Add(item24);
				state6.ExitActivity.Activities.Add(item25);
			}
			else
			{
				state6.EnterActivity.Activities.Add(item30);
				state6.EnterActivity.Activities.Add(item29);
				state6.EnterActivity.Activities.Add(item7);
				state6.EnterActivity.Activities.Add(item27);
				state6.Transitions.Add(new Transition("inpursuit", activity9));
				state6.Transitions.Add(new Transition("post", activity2));
			}
			ReleaseBehavior item33 = new ReleaseBehavior(base.InstancedEvent, base.Entrant, "BEHAVIOR_GAMEPLAY_PURSUIT");
			state7.EnterActivity.Activities.Add(item22);
			state7.EnterActivity.Activities.Add(item6);
			state7.EnterActivity.Activities.Add(item33);
			state7.Transitions.Add(new Transition("done"));
			stateGraph.InitialState = "initial";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(state4);
			stateGraph.States.Add(state5);
			stateGraph.States.Add(state6);
			stateGraph.States.Add(state7);
			stateGraph.States.Add(item);
			return stateGraph;
		}

		// Token: 0x040004AB RID: 1195
		public Variable<Vector3> warpPosition = new Variable<Vector3>();

		// Token: 0x040004AC RID: 1196
		public Variable<Vector3> warpDirection = new Variable<Vector3>();

		// Token: 0x040004AD RID: 1197
		public Variable<long> spectateTargetPersonaId = new Variable<long>();

		// Token: 0x040004AE RID: 1198
		public Variable<float> warpMps = new Variable<float>();

		// Token: 0x040004AF RID: 1199
		private TeamEscapeBustedFlasher localBustedFlasher = new TeamEscapeBustedFlasher();

		// Token: 0x040004B0 RID: 1200
		private Variable<uint> cachedAudioBlackBoard = new Variable<uint>();
	}
}

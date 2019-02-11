using System;
using System.IO;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Graphs;
using GameCore.Activities.Event.Components;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event.Modes
{
	// Token: 0x020001DE RID: 478
	public class BasicPursuitFlow : Mode
	{
		// Token: 0x060014B4 RID: 5300 RVA: 0x0002317A File Offset: 0x0002217A
		private BasicPursuitFlow()
		{
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00023182 File Offset: 0x00022182
		public static object Construct(BinaryReader source)
		{
			return new BasicPursuitFlow();
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0002318C File Offset: 0x0002218C
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph("BasicPursuitFlow");
			State state = new State("running");
			State state2 = new State("done");
			EnableLoadingScreen item = new EnableLoadingScreen(true);
			RelaySync item2 = new RelaySync(0.1f);
			LoadBlackBoards item3 = new LoadBlackBoards(base.InstancedEvent, BlackBoardFlag.kBlackBoardFlag_Running);
			BeginEventSecurity item4 = new BeginEventSecurity();
			FlushCops item5 = new FlushCops();
			PrimeCopVehicleCache item6 = new PrimeCopVehicleCache(base.InstancedEvent, Hash.Hash32("copsuv"), 12);
			PrimeCopVehicleCache item7 = new PrimeCopVehicleCache(base.InstancedEvent, Hash.Hash32("copcarmus08gh"), 4);
			SpawnCops item8 = new SpawnCops(base.InstancedEvent);
			AddOpponents item9 = new AddOpponents(base.InstancedEvent);
			WaitForOpponentsReady item10 = new WaitForOpponentsReady(base.InstancedEvent, 0.1f);
			PrepareGrid item11 = new PrepareGrid(base.InstancedEvent);
			CommitAllAssets item12 = new CommitAllAssets();
			PlaceAtLocators item13 = new PlaceAtLocators(base.InstancedEvent);
			EnableHud item14 = new EnableHud(base.InstancedEvent, EnableHud.HudToggle.Enable);
			GameCore.Activities.Event.Components.AssignPowerupConfiguration item15 = new GameCore.Activities.Event.Components.AssignPowerupConfiguration(base.InstancedEvent);
			Running<EntrantPursuit> activity = new Running<EntrantPursuit>(base.InstancedEvent, new string[]
			{
				"Entrants.Loading"
			});
			PerfectLaunchAchieved activity2 = new PerfectLaunchAchieved(base.InstancedEvent, Ports.Gameplay);
			CleanupEvent item16 = new CleanupEvent(base.InstancedEvent);
			CleanupGrid item17 = new CleanupGrid(base.InstancedEvent);
			state.EnterActivity.Activities.Add(item);
			state.EnterActivity.Activities.Add(item3);
			state.EnterActivity.Activities.Add(item4);
			state.EnterActivity.Activities.Add(item5);
			state.EnterActivity.Activities.Add(item6);
			state.EnterActivity.Activities.Add(item7);
			state.EnterActivity.Activities.Add(item2);
			state.EnterActivity.Activities.Add(item8);
			state.EnterActivity.Activities.Add(item9);
			state.EnterActivity.Activities.Add(item10);
			state.EnterActivity.Activities.Add(item11);
			state.EnterActivity.Activities.Add(item12);
			state.EnterActivity.Activities.Add(item13);
			state.EnterActivity.Activities.Add(item14);
			state.EnterActivity.Activities.Add(item15);
			state.Transitions.Add(new Transition(activity2));
			state.Transitions.Add(new Transition("done", activity));
			state2.EnterActivity.Activities.Add(item16);
			state2.EnterActivity.Activities.Add(item17);
			stateGraph.InitialState = "running";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			return stateGraph;
		}
	}
}

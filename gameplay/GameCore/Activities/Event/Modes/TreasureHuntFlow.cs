using System;
using System.IO;
using GameCore.Activities.Components;
using GameCore.Activities.Entrant.Graphs;
using GameCore.Activities.Event.Components;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Event.Modes
{
	// Token: 0x020001E1 RID: 481
	public class TreasureHuntFlow : Mode
	{
		// Token: 0x060014BE RID: 5310 RVA: 0x000240B8 File Offset: 0x000230B8
		private TreasureHuntFlow()
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x000240C0 File Offset: 0x000230C0
		public static object Construct(BinaryReader source)
		{
			return new TreasureHuntFlow();
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x000240C8 File Offset: 0x000230C8
		protected override WorkflowElement CreateBody()
		{
			StateGraph stateGraph = new StateGraph("TreasureHuntFlow");
			State state = new State("initial");
			State state2 = new State("boot");
			State state3 = new State("running");
			State item = new State("empty");
			State item2 = new State("done");
			BeginEventSecurity item3 = new BeginEventSecurity();
			RefreshCoins item4 = new RefreshCoins(base.Event);
			CoinsRefreshed activity = new CoinsRefreshed(base.Event, Ports.Gameplay);
			NoCoinsRefreshed activity2 = new NoCoinsRefreshed(base.Event, Ports.Gameplay);
			ActivateReferencedTriggers item5 = new ActivateReferencedTriggers(base.Event);
			CommitAllAssets item6 = new CommitAllAssets();
			AddLocalOpponent item7 = new AddLocalOpponent(base.Event);
			Running<EntrantTreasureHunt> activity3 = new Running<EntrantTreasureHunt>(base.Event, new string[]
			{
				"Entrants.Loading"
			});
			DeactivateReferencedTriggers item8 = new DeactivateReferencedTriggers(base.Event);
			CheckPersonaLevel activity4 = new CheckPersonaLevel(1u, 1u);
			CheckPersonaLevel activity5 = new CheckPersonaLevel(2u, 100u);
			state.EnterActivity.Activities.Add(item3);
			state.Transitions.Add(new Transition("empty", activity4));
			state.Transitions.Add(new Transition("boot", activity5));
			state2.EnterActivity.Activities.Add(item4);
			state2.Transitions.Add(new Transition("empty", activity2));
			state2.Transitions.Add(new Transition("running", activity));
			state3.EnterActivity.Activities.Add(item5);
			state3.EnterActivity.Activities.Add(item6);
			state3.EnterActivity.Activities.Add(item7);
			state3.Transitions.Add(new Transition("done", activity3));
			state3.ExitActivity.Activities.Add(item8);
			stateGraph.InitialState = "initial";
			stateGraph.DoneState = "done";
			stateGraph.States.Add(state);
			stateGraph.States.Add(state2);
			stateGraph.States.Add(state3);
			stateGraph.States.Add(item);
			stateGraph.States.Add(item2);
			return stateGraph;
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x000242E6 File Offset: 0x000232E6
		protected internal override void Close()
		{
			base.Close();
		}
	}
}

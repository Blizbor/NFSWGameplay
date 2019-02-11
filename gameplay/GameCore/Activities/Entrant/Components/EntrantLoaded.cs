using System;
using GameCore.Workflow;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200017D RID: 381
	public class EntrantLoaded : SimulationTick
	{
		// Token: 0x06001356 RID: 4950 RVA: 0x0001BED1 File Offset: 0x0001AED1
		public EntrantLoaded(InstancedEvent evnt, EntrantInfo entrant, string name) : base(evnt, entrant, 0f)
		{
			this.signal = Signal.OpenExistingSignal(name);
			this.signal.WaitAll += this.OnSignal;
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x0001BF03 File Offset: 0x0001AF03
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001358 RID: 4952 RVA: 0x0001BF08 File Offset: 0x0001AF08
		protected override void Tick(float dT)
		{
			if (base.Entrant.Opponent.IsLoaded() && !this.signaledOnce)
			{
				Console.WriteLine("Entrant {0} is loaded.", base.Entrant.Opponent.OpponentName);
				this.signal.Set();
				this.signaledOnce = true;
			}
			if (base.Entrant.Opponent.IsStatus(OpponentStatus.kOpponent_Disconnected) && !this.signaledOnce)
			{
				Console.WriteLine("Entrant {0} is disconnected.", base.Entrant.Opponent.OpponentName);
				this.signal.Set();
				this.signaledOnce = true;
			}
		}

		// Token: 0x06001359 RID: 4953 RVA: 0x0001BFA6 File Offset: 0x0001AFA6
		private void OnSignal(Signal signal)
		{
			this.signal.WaitAll -= this.OnSignal;
			LoadingMonitor.ResetBlock();
			this.Close();
		}

		// Token: 0x0600135A RID: 4954 RVA: 0x0001BFCA File Offset: 0x0001AFCA
		public override string ToString()
		{
			return string.Format("EntrantLoaded: {0}", base.Entrant);
		}

		// Token: 0x04000484 RID: 1156
		private readonly Signal signal;

		// Token: 0x04000485 RID: 1157
		private bool signaledOnce;
	}
}

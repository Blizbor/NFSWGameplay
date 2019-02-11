using System;
using EASharp;

namespace GameCore
{
	// Token: 0x02000233 RID: 563
	[Export]
	public class EntrantInfo
	{
		// Token: 0x060016E1 RID: 5857 RVA: 0x00027FA5 File Offset: 0x00026FA5
		public EntrantInfo(Opponent opponent)
		{
			this.opponent = opponent;
		}

		// Token: 0x060016E2 RID: 5858 RVA: 0x00027FB4 File Offset: 0x00026FB4
		public void Prepare(Event evnt)
		{
			this.scoringState = evnt.ScoringMethod.Prepare(this, evnt);
			this.scoringState.Level = this.Opponent.Level;
		}

		// Token: 0x060016E3 RID: 5859 RVA: 0x00027FDF File Offset: 0x00026FDF
		public void Launch(IScoringMethod method)
		{
			method.Launch(this.scoringState);
		}

		// Token: 0x060016E4 RID: 5860 RVA: 0x00027FED File Offset: 0x00026FED
		public void Conclude(IScoringMethod method)
		{
			method.Conclude(this.scoringState);
		}

		// Token: 0x060016E5 RID: 5861 RVA: 0x00027FFB File Offset: 0x00026FFB
		internal void Cleanup()
		{
			this.scoringState.Dispose();
		}

		// Token: 0x060016E6 RID: 5862 RVA: 0x00028008 File Offset: 0x00027008
		public void OnUpdate(Event evnt, float dt)
		{
			this.Opponent.InternalOpponent.SetRank(this.ScoringState.Rank);
			if (this.scoringState.HasFinishReason)
			{
				return;
			}
			evnt.ScoringMethod.OnUpdate(this, evnt, dt);
		}

		// Token: 0x060016E7 RID: 5863 RVA: 0x00028041 File Offset: 0x00027041
		public override string ToString()
		{
			return this.opponent.ToString();
		}

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x060016E8 RID: 5864 RVA: 0x0002804E File Offset: 0x0002704E
		public long PersonaId
		{
			get
			{
				return this.Opponent.PersonaId;
			}
		}

		// Token: 0x170001CE RID: 462
		// (get) Token: 0x060016E9 RID: 5865 RVA: 0x0002805B File Offset: 0x0002705B
		public uint Id
		{
			get
			{
				return this.Opponent.Id;
			}
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x060016EA RID: 5866 RVA: 0x00028068 File Offset: 0x00027068
		internal Opponent Opponent
		{
			get
			{
				return this.opponent;
			}
		}

		// Token: 0x170001D0 RID: 464
		// (get) Token: 0x060016EB RID: 5867 RVA: 0x00028070 File Offset: 0x00027070
		// (set) Token: 0x060016EC RID: 5868 RVA: 0x00028078 File Offset: 0x00027078
		internal RoutingState RoutingState
		{
			get
			{
				return this.routingState;
			}
			set
			{
				this.routingState = value;
			}
		}

		// Token: 0x170001D1 RID: 465
		// (get) Token: 0x060016ED RID: 5869 RVA: 0x00028081 File Offset: 0x00027081
		// (set) Token: 0x060016EE RID: 5870 RVA: 0x00028089 File Offset: 0x00027089
		internal ScoringState ScoringState
		{
			get
			{
				return this.scoringState;
			}
			set
			{
				this.scoringState = value;
			}
		}

		// Token: 0x04000585 RID: 1413
		private readonly Opponent opponent;

		// Token: 0x04000586 RID: 1414
		private RoutingState routingState;

		// Token: 0x04000587 RID: 1415
		private ScoringState scoringState;
	}
}

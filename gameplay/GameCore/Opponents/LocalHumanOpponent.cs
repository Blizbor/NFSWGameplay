using System;

namespace GameCore.Opponents
{
	// Token: 0x02000202 RID: 514
	public class LocalHumanOpponent : LocalOpponent
	{
		// Token: 0x0600159A RID: 5530 RVA: 0x0002615A File Offset: 0x0002515A
		public LocalHumanOpponent(InternalOpponent internalOpponent) : base(internalOpponent)
		{
			this.hud = new Hud();
		}

		// Token: 0x0600159B RID: 5531 RVA: 0x00026170 File Offset: 0x00025170
		public override bool IsLoaded()
		{
			if (!LoadingMonitor.IsLoading())
			{
				if (!base.IsStatus(OpponentStatus.kOpponent_Loaded))
				{
					LoadingMonitor.HitBlock();
				}
				base.SetStatus(OpponentStatus.kOpponent_Loaded);
			}
			return base.IsLoaded() && base.IsStatus(OpponentStatus.kOpponent_Loaded) && !LoadingMonitor.IsBlocking();
		}

		// Token: 0x0600159C RID: 5532 RVA: 0x000261C3 File Offset: 0x000251C3
		public void AssignPursuitEscalation(uint pursuitEscalationKey)
		{
			this.InternalLocalHumanOpponent.AssignPursuitEscalation(pursuitEscalationKey);
		}

		// Token: 0x0600159D RID: 5533 RVA: 0x000261D1 File Offset: 0x000251D1
		public void RefreshPersona()
		{
			this.InternalLocalHumanOpponent.RefreshPersona();
		}

		// Token: 0x1700018D RID: 397
		// (get) Token: 0x0600159E RID: 5534 RVA: 0x000261DE File Offset: 0x000251DE
		protected InternalLocalHumanOpponent InternalLocalHumanOpponent
		{
			get
			{
				return base.InternalOpponent as InternalLocalHumanOpponent;
			}
		}

		// Token: 0x1700018E RID: 398
		// (get) Token: 0x0600159F RID: 5535 RVA: 0x000261EB File Offset: 0x000251EB
		public uint DriverLevel
		{
			get
			{
				return this.InternalLocalHumanOpponent.GetDriverLevel();
			}
		}

		// Token: 0x1700018F RID: 399
		// (get) Token: 0x060015A0 RID: 5536 RVA: 0x000261F8 File Offset: 0x000251F8
		// (set) Token: 0x060015A1 RID: 5537 RVA: 0x00026205 File Offset: 0x00025205
		public float Heat
		{
			get
			{
				return this.InternalLocalHumanOpponent.GetHeat();
			}
			set
			{
				this.InternalLocalHumanOpponent.SetHeat(value);
			}
		}

		// Token: 0x17000190 RID: 400
		// (get) Token: 0x060015A2 RID: 5538 RVA: 0x00026213 File Offset: 0x00025213
		internal PursuitInfo PursuitData
		{
			get
			{
				return this.InternalLocalHumanOpponent.GetPursuitData();
			}
		}

		// Token: 0x17000191 RID: 401
		// (get) Token: 0x060015A3 RID: 5539 RVA: 0x00026220 File Offset: 0x00025220
		internal Hud Hud
		{
			get
			{
				return this.hud;
			}
		}

		// Token: 0x04000518 RID: 1304
		private readonly Hud hud;
	}
}

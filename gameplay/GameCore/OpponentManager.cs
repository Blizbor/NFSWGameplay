using System;
using System.Collections.Generic;
using EASharp;
using GameCore.Data;
using GameCore.Opponents;

namespace GameCore
{
	// Token: 0x02000249 RID: 585
	[Export]
	public class OpponentManager : IDisposable
	{
		// Token: 0x060017AC RID: 6060 RVA: 0x0002A300 File Offset: 0x00029300
		public OpponentManager(InternalOpponentManager internalOpponentManager)
		{
			this.internalOpponentManager = internalOpponentManager;
			this.internalOpponentManager.Reset(this);
		}

		// Token: 0x060017AD RID: 6061 RVA: 0x0002A328 File Offset: 0x00029328
		~OpponentManager()
		{
			this.Dispose(false);
		}

		// Token: 0x060017AE RID: 6062 RVA: 0x0002A364 File Offset: 0x00029364
		internal LocalHumanOpponent FindLocalOpponent()
		{
			int num = this.opponents.FindIndex((Opponent opponent) => opponent is LocalHumanOpponent);
			if (num != -1)
			{
				return this.opponents[num] as LocalHumanOpponent;
			}
			return null;
		}

		// Token: 0x060017AF RID: 6063 RVA: 0x0002A3CC File Offset: 0x000293CC
		internal Opponent FindByPersonaId(long personaId)
		{
			int num = this.opponents.FindIndex((Opponent opponent) => opponent.PersonaId == personaId);
			if (num != -1)
			{
				return this.opponents[num];
			}
			return null;
		}

		// Token: 0x060017B0 RID: 6064 RVA: 0x0002A428 File Offset: 0x00029428
		internal Opponent FindByOpponentId(uint opponentId)
		{
			int num = this.opponents.FindIndex((Opponent opponent) => opponent.Id == opponentId);
			if (num != -1)
			{
				return this.opponents[num];
			}
			return null;
		}

		// Token: 0x060017B1 RID: 6065 RVA: 0x0002A46C File Offset: 0x0002946C
		internal void Ready()
		{
		}

		// Token: 0x060017B2 RID: 6066 RVA: 0x0002A46E File Offset: 0x0002946E
		internal void Cleanup()
		{
			this.RemoveAllOpponents();
		}

		// Token: 0x060017B3 RID: 6067 RVA: 0x0002A476 File Offset: 0x00029476
		internal void RemoveAllOpponents()
		{
			this.opponents.Clear();
		}

		// Token: 0x060017B4 RID: 6068 RVA: 0x0002A483 File Offset: 0x00029483
		internal void RemoveAllOpponentsExceptLocalPlayer()
		{
			this.internalOpponentManager.RemoveAllOpponentsExceptLocalPlayer();
		}

		// Token: 0x060017B5 RID: 6069 RVA: 0x0002A490 File Offset: 0x00029490
		public IOpponent CreateLocalHuman(InternalLocalHumanOpponent internalOpponent)
		{
			LocalHumanOpponent localHumanOpponent = new LocalHumanOpponent(internalOpponent);
			this.opponents.Add(localHumanOpponent);
			return localHumanOpponent;
		}

		// Token: 0x060017B6 RID: 6070 RVA: 0x0002A4B4 File Offset: 0x000294B4
		public Opponent CreateLocalAI(uint characterKey, uint presetIndex)
		{
			Collection collection = new Collection(characterKey);
			LocalArtificalOpponent localArtificalOpponent = new LocalArtificalOpponent(characterKey, this.internalOpponentManager.CreateLocalAI(collection.Localization().Hash, collection.PresetRides(presetIndex)));
			this.opponents.Add(localArtificalOpponent);
			return localArtificalOpponent;
		}

		// Token: 0x060017B7 RID: 6071 RVA: 0x0002A4FC File Offset: 0x000294FC
		public IOpponent CreateRemoteHuman(InternalRemoteHumanOpponent internalOpponent)
		{
			RemoteHumanOpponent remoteHumanOpponent = new RemoteHumanOpponent(internalOpponent);
			this.opponents.Add(remoteHumanOpponent);
			return remoteHumanOpponent;
		}

		// Token: 0x060017B8 RID: 6072 RVA: 0x0002A538 File Offset: 0x00029538
		public void Remove(uint opponentId)
		{
			int num = this.opponents.FindIndex((Opponent opponent) => opponent.Id == opponentId);
			if (num != -1)
			{
				this.opponents.RemoveAt(num);
			}
		}

		// Token: 0x060017B9 RID: 6073 RVA: 0x0002A57A File Offset: 0x0002957A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060017BA RID: 6074 RVA: 0x0002A589 File Offset: 0x00029589
		protected void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.internalOpponentManager.Reset();
				this.isDisposed = true;
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x0002A5A5 File Offset: 0x000295A5
		internal List<Opponent> Opponents
		{
			get
			{
				return this.opponents;
			}
		}

		// Token: 0x040005C4 RID: 1476
		private readonly InternalOpponentManager internalOpponentManager;

		// Token: 0x040005C5 RID: 1477
		private List<Opponent> opponents = new List<Opponent>();

		// Token: 0x040005C6 RID: 1478
		private bool isDisposed;
	}
}

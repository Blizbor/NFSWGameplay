using System;
using GameCore.Math;
using Interop;

namespace GameCore
{
	// Token: 0x020001FF RID: 511
	public abstract class Opponent : IOpponent
	{
		// Token: 0x06001581 RID: 5505 RVA: 0x00025FC3 File Offset: 0x00024FC3
		public Opponent(InternalOpponent internalOpponent)
		{
			this.internalOpponent = internalOpponent;
			this.vehicle = this.internalOpponent.GetWrappedVehicle();
		}

		// Token: 0x06001582 RID: 5506 RVA: 0x00025FE3 File Offset: 0x00024FE3
		public virtual void Prepare(bool isDragEvent)
		{
			this.internalOpponent.Prepare(isDragEvent);
		}

		// Token: 0x06001583 RID: 5507 RVA: 0x00025FF1 File Offset: 0x00024FF1
		public virtual void Cleanup()
		{
			this.internalOpponent.ClearStatus(OpponentStatus.kOpponent_Loaded);
			this.internalOpponent.Cleanup();
		}

		// Token: 0x06001584 RID: 5508 RVA: 0x0002600E File Offset: 0x0002500E
		public virtual bool IsLoaded()
		{
			return !this.Vehicle.IsLoading() && this.IsStatus(OpponentStatus.kOpponent_Ready);
		}

		// Token: 0x06001585 RID: 5509 RVA: 0x00026026 File Offset: 0x00025026
		public bool IsStatus(OpponentStatus status)
		{
			return this.internalOpponent.IsStatus(status);
		}

		// Token: 0x06001586 RID: 5510 RVA: 0x00026034 File Offset: 0x00025034
		public void SetStatus(OpponentStatus status)
		{
			this.internalOpponent.SetStatus(status);
		}

		// Token: 0x06001587 RID: 5511 RVA: 0x00026042 File Offset: 0x00025042
		public void ClearStatus(OpponentStatus status)
		{
			this.internalOpponent.ClearStatus(status);
		}

		// Token: 0x06001588 RID: 5512 RVA: 0x00026050 File Offset: 0x00025050
		public void SetNextPathPoint(Vector3 position, Vector3 direction)
		{
			this.internalOpponent.SetNextPathPoint(position, direction);
		}

		// Token: 0x06001589 RID: 5513 RVA: 0x0002605F File Offset: 0x0002505F
		public override string ToString()
		{
			return this.OpponentName;
		}

		// Token: 0x0600158A RID: 5514 RVA: 0x00026067 File Offset: 0x00025067
		public void LoadBehavior(string channel, string type)
		{
			this.internalOpponent.LoadBehavior(Hash.Hash32(channel), Hash.Hash32(type));
		}

		// Token: 0x0600158B RID: 5515 RVA: 0x00026080 File Offset: 0x00025080
		public void ReleaseBehavior(string channel)
		{
			this.internalOpponent.ReleaseBehavior(Hash.Hash32(channel));
		}

		// Token: 0x0600158C RID: 5516 RVA: 0x00026093 File Offset: 0x00025093
		public void FillCarData(FECarData carData)
		{
			this.Vehicle.Fill(carData);
			carData.Heat = this.internalOpponent.GetHeat();
		}

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600158D RID: 5517 RVA: 0x000260B2 File Offset: 0x000250B2
		internal InternalOpponent InternalOpponent
		{
			get
			{
				return this.internalOpponent;
			}
		}

		// Token: 0x17000184 RID: 388
		// (get) Token: 0x0600158E RID: 5518 RVA: 0x000260BA File Offset: 0x000250BA
		public Vehicle Vehicle
		{
			get
			{
				return this.vehicle;
			}
		}

		// Token: 0x17000185 RID: 389
		// (get) Token: 0x0600158F RID: 5519 RVA: 0x000260C2 File Offset: 0x000250C2
		public string OpponentName
		{
			get
			{
				return this.internalOpponent.GetOpponentName();
			}
		}

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06001590 RID: 5520 RVA: 0x000260CF File Offset: 0x000250CF
		public string Motto
		{
			get
			{
				return this.internalOpponent.GetMotto() ?? string.Empty;
			}
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06001591 RID: 5521 RVA: 0x000260E5 File Offset: 0x000250E5
		public uint Id
		{
			get
			{
				return this.internalOpponent.Id();
			}
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06001592 RID: 5522 RVA: 0x000260F2 File Offset: 0x000250F2
		// (set) Token: 0x06001593 RID: 5523 RVA: 0x000260FF File Offset: 0x000250FF
		public int GridIndex
		{
			get
			{
				return this.internalOpponent.GetGridIndex();
			}
			set
			{
				this.internalOpponent.SetGridIndex(value);
			}
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06001594 RID: 5524 RVA: 0x0002610D File Offset: 0x0002510D
		public long PersonaId
		{
			get
			{
				return this.internalOpponent.GetPersonaId();
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06001595 RID: 5525 RVA: 0x0002611A File Offset: 0x0002511A
		public uint IconIndex
		{
			get
			{
				return this.internalOpponent.GetIconIndex();
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06001596 RID: 5526 RVA: 0x00026127 File Offset: 0x00025127
		public uint Level
		{
			get
			{
				return this.internalOpponent.GetLevel();
			}
		}

		// Token: 0x04000515 RID: 1301
		private readonly InternalOpponent internalOpponent;

		// Token: 0x04000516 RID: 1302
		private readonly Vehicle vehicle;
	}
}

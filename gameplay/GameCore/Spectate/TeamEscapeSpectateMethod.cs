using System;
using System.IO;
using GameCore.Opponents;
using GameCore.Scoring;

namespace GameCore.Spectate
{
	// Token: 0x02000289 RID: 649
	public class TeamEscapeSpectateMethod : ISpectateMethod
	{
		// Token: 0x060019CF RID: 6607 RVA: 0x0002F1D3 File Offset: 0x0002E1D3
		public static object Construct(BinaryReader source)
		{
			return new TeamEscapeSpectateMethod();
		}

		// Token: 0x060019D0 RID: 6608 RVA: 0x0002F1DA File Offset: 0x0002E1DA
		public void ClearTarget()
		{
			this.target = null;
		}

		// Token: 0x060019D1 RID: 6609 RVA: 0x0002F1E4 File Offset: 0x0002E1E4
		public uint UpdateTarget(InstancedEvent evt)
		{
			if (this.target != null && !this.target.Opponent.IsStatus(OpponentStatus.kOpponent_NotSpectatable))
			{
				return this.target.Opponent.InternalOpponent.GetWrappedVehicle().GetWorldID();
			}
			LocalHumanOpponent localHumanOpponent = evt.Manager.OpponentManager.FindLocalOpponent();
			EntrantInfo entrantInfo = evt.FindEntrant(localHumanOpponent.PersonaId);
			TeamEscapeScoringState teamEscapeScoringState = entrantInfo.ScoringState as TeamEscapeScoringState;
			this.target = entrantInfo;
			float fractionCompleted = teamEscapeScoringState.FractionCompleted;
			EntrantInfo entrantInfo2 = entrantInfo;
			float num = float.MaxValue;
			EntrantInfo entrantInfo3 = entrantInfo;
			float num2 = float.MinValue;
			foreach (EntrantInfo entrantInfo4 in evt.Entrants)
			{
				if (entrantInfo4.PersonaId != entrantInfo.PersonaId && !entrantInfo4.Opponent.IsStatus(OpponentStatus.kOpponent_NotSpectatable))
				{
					TeamEscapeScoringState teamEscapeScoringState2 = entrantInfo4.ScoringState as TeamEscapeScoringState;
					if (teamEscapeScoringState2.FractionCompleted >= fractionCompleted && teamEscapeScoringState2.FractionCompleted <= num)
					{
						entrantInfo2 = entrantInfo4;
						num = teamEscapeScoringState2.FractionCompleted;
					}
					else if (teamEscapeScoringState2.FractionCompleted <= fractionCompleted && teamEscapeScoringState2.FractionCompleted >= num2)
					{
						entrantInfo3 = entrantInfo4;
						num2 = teamEscapeScoringState2.FractionCompleted;
					}
				}
			}
			if (entrantInfo3 != entrantInfo)
			{
				this.target = entrantInfo3;
			}
			if (entrantInfo2 != entrantInfo)
			{
				this.target = entrantInfo2;
			}
			return this.target.Opponent.InternalOpponent.GetWrappedVehicle().GetWorldID();
		}

		// Token: 0x17000288 RID: 648
		// (get) Token: 0x060019D2 RID: 6610 RVA: 0x0002F368 File Offset: 0x0002E368
		public EntrantInfo Target
		{
			get
			{
				return this.target;
			}
		}

		// Token: 0x0400065D RID: 1629
		private EntrantInfo target;
	}
}

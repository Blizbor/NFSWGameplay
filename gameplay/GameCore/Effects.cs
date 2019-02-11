using System;
using Attrib.Gen;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000231 RID: 561
	[Export]
	public class Effects
	{
		// Token: 0x060016CF RID: 5839 RVA: 0x00027DFE File Offset: 0x00026DFE
		internal Effects(Manager manager)
		{
			this.manager = manager;
		}

		// Token: 0x060016D0 RID: 5840 RVA: 0x00027E0D File Offset: 0x00026E0D
		public void Ready()
		{
			InternalEffects.Get().Ready(this);
		}

		// Token: 0x060016D1 RID: 5841 RVA: 0x00027E1A File Offset: 0x00026E1A
		public void Cleanup()
		{
			InternalEffects.Get().Cleanup();
		}

		// Token: 0x060016D2 RID: 5842 RVA: 0x00027E28 File Offset: 0x00026E28
		public void Do(long personaId, uint effectKey)
		{
			if (this.Event is InstancedEvent)
			{
				EntrantInfo entrantInfo = this.InstancedEvent.FindEntrant(personaId);
				if (entrantInfo != null)
				{
					powerup_gamegroup powerup_gamegroup = new powerup_gamegroup(effectKey);
					uint rank = (uint)entrantInfo.ScoringState.Rank;
					uint indexMagnitude = GameCore.Math.Math.Clamp<uint>(rank, 0u, powerup_gamegroup.Num_magnitude() - 1u);
					uint indexRange = GameCore.Math.Math.Clamp<uint>(rank, 0u, powerup_gamegroup.Num_range() - 1u);
					this.InstancedEvent.DoEffect(entrantInfo, powerup_gamegroup, indexMagnitude, indexRange);
				}
			}
		}

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x060016D3 RID: 5843 RVA: 0x00027E97 File Offset: 0x00026E97
		// (set) Token: 0x060016D4 RID: 5844 RVA: 0x00027E9F File Offset: 0x00026E9F
		internal Event Event { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x060016D5 RID: 5845 RVA: 0x00027EA8 File Offset: 0x00026EA8
		internal InstancedEvent InstancedEvent
		{
			get
			{
				return this.Event as InstancedEvent;
			}
		}

		// Token: 0x0400057F RID: 1407
		private readonly Manager manager;
	}
}

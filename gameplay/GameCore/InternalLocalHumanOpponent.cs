using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000073 RID: 115
	[ExportOnlyCreate(false)]
	public class InternalLocalHumanOpponent : InternalOpponent
	{
		// Token: 0x060005C6 RID: 1478 RVA: 0x00008274 File Offset: 0x00007274
		public new unsafe static InternalLocalHumanOpponent CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalLocalHumanOpponent(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005C7 RID: 1479 RVA: 0x00008297 File Offset: 0x00007297
		public unsafe InternalLocalHumanOpponent(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005C8 RID: 1480 RVA: 0x000082A1 File Offset: 0x000072A1
		protected internal InternalLocalHumanOpponent(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005C9 RID: 1481 RVA: 0x000082AA File Offset: 0x000072AA
		protected internal unsafe InternalLocalHumanOpponent(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005CA RID: 1482
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_583(void* self);

		// Token: 0x060005CB RID: 1483 RVA: 0x000082B4 File Offset: 0x000072B4
		[DisableExceptionHandling]
		~InternalLocalHumanOpponent()
		{
			InternalLocalHumanOpponent._EASharpBinding_583(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060005CC RID: 1484
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_584(void* _ThisPtr, uint driverLevel);

		// Token: 0x060005CD RID: 1485 RVA: 0x000082F0 File Offset: 0x000072F0
		public virtual void SetDriverLevel(uint driverLevel)
		{
			InternalLocalHumanOpponent._EASharpBinding_584(this.mSelf, driverLevel);
		}

		// Token: 0x060005CE RID: 1486
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_585(void* _ThisPtr);

		// Token: 0x060005CF RID: 1487 RVA: 0x00008300 File Offset: 0x00007300
		public virtual uint GetDriverLevel()
		{
			return InternalLocalHumanOpponent._EASharpBinding_585(this.mSelf);
		}

		// Token: 0x060005D0 RID: 1488
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_586(void* _ThisPtr, float heat);

		// Token: 0x060005D1 RID: 1489 RVA: 0x0000831A File Offset: 0x0000731A
		public virtual void SetHeat(float heat)
		{
			InternalLocalHumanOpponent._EASharpBinding_586(this.mSelf, heat);
		}

		// Token: 0x060005D2 RID: 1490
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_587(void* _ThisPtr);

		// Token: 0x060005D3 RID: 1491 RVA: 0x00008328 File Offset: 0x00007328
		public override float GetHeat()
		{
			return InternalLocalHumanOpponent._EASharpBinding_587(this.mSelf);
		}

		// Token: 0x060005D4 RID: 1492
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_588(void* _ThisPtr, uint pursuitEscalationKey);

		// Token: 0x060005D5 RID: 1493 RVA: 0x00008342 File Offset: 0x00007342
		public virtual void AssignPursuitEscalation(uint pursuitEscalationKey)
		{
			InternalLocalHumanOpponent._EASharpBinding_588(this.mSelf, pursuitEscalationKey);
		}

		// Token: 0x060005D6 RID: 1494
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_589(void* _ThisPtr);

		// Token: 0x060005D7 RID: 1495 RVA: 0x00008350 File Offset: 0x00007350
		public virtual PursuitInfo GetPursuitData()
		{
			return PursuitInfo.CreateInitUnowned(InternalLocalHumanOpponent._EASharpBinding_589(this.mSelf));
		}

		// Token: 0x060005D8 RID: 1496
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_590(void* _ThisPtr);

		// Token: 0x060005D9 RID: 1497 RVA: 0x0000836F File Offset: 0x0000736F
		public virtual void RefreshPersona()
		{
			InternalLocalHumanOpponent._EASharpBinding_590(this.mSelf);
		}
	}
}

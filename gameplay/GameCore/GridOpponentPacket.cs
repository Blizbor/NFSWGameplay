using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000076 RID: 118
	[ExportOnlyCreate(false)]
	public class GridOpponentPacket : ExposedCommonBase
	{
		// Token: 0x060005EE RID: 1518 RVA: 0x000084AC File Offset: 0x000074AC
		public unsafe static GridOpponentPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new GridOpponentPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005EF RID: 1519 RVA: 0x000084CF File Offset: 0x000074CF
		public unsafe GridOpponentPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005F0 RID: 1520 RVA: 0x000084D9 File Offset: 0x000074D9
		protected internal GridOpponentPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005F1 RID: 1521 RVA: 0x000084E2 File Offset: 0x000074E2
		protected internal unsafe GridOpponentPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005F2 RID: 1522
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_597(void* self);

		// Token: 0x060005F3 RID: 1523 RVA: 0x000084EC File Offset: 0x000074EC
		[DisableExceptionHandling]
		~GridOpponentPacket()
		{
			GridOpponentPacket._EASharpBinding_597(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060005F4 RID: 1524
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_598(long personaId, int gridIndex);

		// Token: 0x060005F5 RID: 1525 RVA: 0x00008528 File Offset: 0x00007528
		public GridOpponentPacket(long personaId, int gridIndex) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = GridOpponentPacket._EASharpBinding_598(personaId, gridIndex);
		}

		// Token: 0x060005F6 RID: 1526
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_599(void* _ThisPtr, int gridIndex);

		// Token: 0x060005F7 RID: 1527 RVA: 0x00008551 File Offset: 0x00007551
		public void SetGridIndex(int gridIndex)
		{
			GridOpponentPacket._EASharpBinding_599(this.mSelf, gridIndex);
		}

		// Token: 0x060005F8 RID: 1528
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_600(void* _ThisPtr);

		// Token: 0x060005F9 RID: 1529 RVA: 0x00008560 File Offset: 0x00007560
		public int GetGridIndex()
		{
			return GridOpponentPacket._EASharpBinding_600(this.mSelf);
		}

		// Token: 0x060005FA RID: 1530
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_601(void* _ThisPtr);

		// Token: 0x060005FB RID: 1531 RVA: 0x0000857C File Offset: 0x0000757C
		public long GetPersonaId()
		{
			return GridOpponentPacket._EASharpBinding_601(this.mSelf);
		}
	}
}

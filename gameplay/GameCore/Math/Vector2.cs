using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore.Math
{
	// Token: 0x02000080 RID: 128
	[ExportOnlyCreate(false)]
	public class Vector2 : Vector2
	{
		// Token: 0x0600066E RID: 1646 RVA: 0x00008CDC File Offset: 0x00007CDC
		public new unsafe static Vector2 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Vector2(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600066F RID: 1647 RVA: 0x00008CFF File Offset: 0x00007CFF
		public unsafe Vector2(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000670 RID: 1648 RVA: 0x00008D09 File Offset: 0x00007D09
		protected internal Vector2(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000671 RID: 1649 RVA: 0x00008D12 File Offset: 0x00007D12
		protected internal unsafe Vector2(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000672 RID: 1650
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_631(void* self);

		// Token: 0x06000673 RID: 1651 RVA: 0x00008D1C File Offset: 0x00007D1C
		[DisableExceptionHandling]
		~Vector2()
		{
			Vector2._EASharpBinding_631(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000674 RID: 1652
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_632();

		// Token: 0x06000675 RID: 1653 RVA: 0x00008D58 File Offset: 0x00007D58
		public Vector2() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Vector2._EASharpBinding_632();
		}

		// Token: 0x06000676 RID: 1654
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_633(float _x, float _y);

		// Token: 0x06000677 RID: 1655 RVA: 0x00008D80 File Offset: 0x00007D80
		public Vector2(float _x, float _y) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Vector2._EASharpBinding_633(_x, _y);
		}

		// Token: 0x06000678 RID: 1656
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_634(void* vec);

		// Token: 0x06000679 RID: 1657 RVA: 0x00008DAC File Offset: 0x00007DAC
		public Vector2(Vector2 vec) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Vector2._EASharpBinding_634(object.ReferenceEquals(vec, null) ? null : vec._GetRaw());
		}

		// Token: 0x0600067A RID: 1658
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_635(void* _ThisPtr, void* vec);

		// Token: 0x0600067B RID: 1659 RVA: 0x00008DE8 File Offset: 0x00007DE8
		public bool EqualTo(Vector2 vec)
		{
			return Vector2._EASharpBinding_635(this.mSelf, object.ReferenceEquals(vec, null) ? null : vec._GetRaw());
		}
	}
}

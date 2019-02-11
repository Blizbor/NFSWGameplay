using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore.Math
{
	// Token: 0x0200007E RID: 126
	[ExportOnlyCreate(false)]
	public class Vector3 : Vector3
	{
		// Token: 0x06000650 RID: 1616 RVA: 0x00008ACC File Offset: 0x00007ACC
		public new unsafe static Vector3 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Vector3(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000651 RID: 1617 RVA: 0x00008AEF File Offset: 0x00007AEF
		public unsafe Vector3(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000652 RID: 1618 RVA: 0x00008AF9 File Offset: 0x00007AF9
		protected internal Vector3(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000653 RID: 1619 RVA: 0x00008B02 File Offset: 0x00007B02
		protected internal unsafe Vector3(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000654 RID: 1620
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_626(void* self);

		// Token: 0x06000655 RID: 1621 RVA: 0x00008B0C File Offset: 0x00007B0C
		[DisableExceptionHandling]
		~Vector3()
		{
			Vector3._EASharpBinding_626(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000656 RID: 1622
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_627();

		// Token: 0x06000657 RID: 1623 RVA: 0x00008B48 File Offset: 0x00007B48
		public Vector3() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Vector3._EASharpBinding_627();
		}

		// Token: 0x06000658 RID: 1624
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_628(float _x, float _y, float _z);

		// Token: 0x06000659 RID: 1625 RVA: 0x00008B70 File Offset: 0x00007B70
		public Vector3(float _x, float _y, float _z) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Vector3._EASharpBinding_628(_x, _y, _z);
		}

		// Token: 0x0600065A RID: 1626
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_629(void* vec);

		// Token: 0x0600065B RID: 1627 RVA: 0x00008B9C File Offset: 0x00007B9C
		public Vector3(Vector3 vec) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Vector3._EASharpBinding_629(object.ReferenceEquals(vec, null) ? null : vec._GetRaw());
		}

		// Token: 0x0600065C RID: 1628
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_630(void* _ThisPtr, void* vec);

		// Token: 0x0600065D RID: 1629 RVA: 0x00008BD8 File Offset: 0x00007BD8
		public bool EqualTo(Vector3 vec)
		{
			return Vector3._EASharpBinding_630(this.mSelf, object.ReferenceEquals(vec, null) ? null : vec._GetRaw());
		}
	}
}

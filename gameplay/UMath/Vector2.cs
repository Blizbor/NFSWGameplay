using System;
using System.Runtime.InteropServices;
using EASharp;

namespace UMath
{
	// Token: 0x0200007F RID: 127
	[ExportOnlyCreate(true)]
	public class Vector2 : ExposedCommonBase
	{
		// Token: 0x0600065E RID: 1630 RVA: 0x00008C08 File Offset: 0x00007C08
		public unsafe static Vector2 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Vector2(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600065F RID: 1631 RVA: 0x00008C2B File Offset: 0x00007C2B
		public unsafe Vector2(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000660 RID: 1632 RVA: 0x00008C35 File Offset: 0x00007C35
		protected internal Vector2(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000661 RID: 1633 RVA: 0x00008C3E File Offset: 0x00007C3E
		protected internal unsafe Vector2(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000662 RID: 1634
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1473(void* self);

		// Token: 0x06000663 RID: 1635 RVA: 0x00008C48 File Offset: 0x00007C48
		[DisableExceptionHandling]
		~Vector2()
		{
			Vector2._EASharpBinding_1473(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000664 RID: 1636
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1474(void* self, float val);

		// Token: 0x06000665 RID: 1637
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1475(void* self);

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000666 RID: 1638 RVA: 0x00008C84 File Offset: 0x00007C84
		// (set) Token: 0x06000667 RID: 1639 RVA: 0x00008C91 File Offset: 0x00007C91
		public float x
		{
			get
			{
				return Vector2._EASharpBinding_1475(this.mSelf);
			}
			set
			{
				Vector2._EASharpBinding_1474(this.mSelf, value);
			}
		}

		// Token: 0x06000668 RID: 1640
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1476(void* self, float val);

		// Token: 0x06000669 RID: 1641
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1477(void* self);

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x0600066A RID: 1642 RVA: 0x00008C9F File Offset: 0x00007C9F
		// (set) Token: 0x0600066B RID: 1643 RVA: 0x00008CAC File Offset: 0x00007CAC
		public float y
		{
			get
			{
				return Vector2._EASharpBinding_1477(this.mSelf);
			}
			set
			{
				Vector2._EASharpBinding_1476(this.mSelf, value);
			}
		}

		// Token: 0x0600066C RID: 1644
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1479();

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x0600066D RID: 1645 RVA: 0x00008CBC File Offset: 0x00007CBC
		public static Vector2 kZero
		{
			get
			{
				return new Vector2(default(ExposeTag_InitUnowned), Vector2._EASharpBinding_1479());
			}
		}
	}
}

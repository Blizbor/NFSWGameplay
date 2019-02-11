using System;
using System.Runtime.InteropServices;
using EASharp;

namespace UMath
{
	// Token: 0x0200010E RID: 270
	[ExportOnlyCreate(true)]
	public class Vector4 : ExposedCommonBase
	{
		// Token: 0x06000E78 RID: 3704 RVA: 0x00011214 File Offset: 0x00010214
		public unsafe static Vector4 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Vector4(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000E79 RID: 3705 RVA: 0x00011237 File Offset: 0x00010237
		public unsafe Vector4(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E7A RID: 3706 RVA: 0x00011241 File Offset: 0x00010241
		protected internal Vector4(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000E7B RID: 3707 RVA: 0x0001124A File Offset: 0x0001024A
		protected internal unsafe Vector4(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E7C RID: 3708
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1489(void* self);

		// Token: 0x06000E7D RID: 3709 RVA: 0x00011254 File Offset: 0x00010254
		[DisableExceptionHandling]
		~Vector4()
		{
			Vector4._EASharpBinding_1489(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000E7E RID: 3710
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1490(void* self, float val);

		// Token: 0x06000E7F RID: 3711
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1491(void* self);

		// Token: 0x1700010E RID: 270
		// (get) Token: 0x06000E80 RID: 3712 RVA: 0x00011290 File Offset: 0x00010290
		// (set) Token: 0x06000E81 RID: 3713 RVA: 0x0001129D File Offset: 0x0001029D
		public float x
		{
			get
			{
				return Vector4._EASharpBinding_1491(this.mSelf);
			}
			set
			{
				Vector4._EASharpBinding_1490(this.mSelf, value);
			}
		}

		// Token: 0x06000E82 RID: 3714
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1492(void* self, float val);

		// Token: 0x06000E83 RID: 3715
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1493(void* self);

		// Token: 0x1700010F RID: 271
		// (get) Token: 0x06000E84 RID: 3716 RVA: 0x000112AB File Offset: 0x000102AB
		// (set) Token: 0x06000E85 RID: 3717 RVA: 0x000112B8 File Offset: 0x000102B8
		public float y
		{
			get
			{
				return Vector4._EASharpBinding_1493(this.mSelf);
			}
			set
			{
				Vector4._EASharpBinding_1492(this.mSelf, value);
			}
		}

		// Token: 0x06000E86 RID: 3718
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1494(void* self, float val);

		// Token: 0x06000E87 RID: 3719
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1495(void* self);

		// Token: 0x17000110 RID: 272
		// (get) Token: 0x06000E88 RID: 3720 RVA: 0x000112C6 File Offset: 0x000102C6
		// (set) Token: 0x06000E89 RID: 3721 RVA: 0x000112D3 File Offset: 0x000102D3
		public float z
		{
			get
			{
				return Vector4._EASharpBinding_1495(this.mSelf);
			}
			set
			{
				Vector4._EASharpBinding_1494(this.mSelf, value);
			}
		}

		// Token: 0x06000E8A RID: 3722
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1496(void* self, float val);

		// Token: 0x06000E8B RID: 3723
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1497(void* self);

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x06000E8C RID: 3724 RVA: 0x000112E1 File Offset: 0x000102E1
		// (set) Token: 0x06000E8D RID: 3725 RVA: 0x000112EE File Offset: 0x000102EE
		public float w
		{
			get
			{
				return Vector4._EASharpBinding_1497(this.mSelf);
			}
			set
			{
				Vector4._EASharpBinding_1496(this.mSelf, value);
			}
		}

		// Token: 0x06000E8E RID: 3726
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1499();

		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000E8F RID: 3727 RVA: 0x000112FC File Offset: 0x000102FC
		public static Vector4 kZero
		{
			get
			{
				return new Vector4(default(ExposeTag_InitUnowned), Vector4._EASharpBinding_1499());
			}
		}

		// Token: 0x06000E90 RID: 3728
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1501();

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000E91 RID: 3729 RVA: 0x0001131C File Offset: 0x0001031C
		public static Vector4 kIdentity
		{
			get
			{
				return new Vector4(default(ExposeTag_InitUnowned), Vector4._EASharpBinding_1501());
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

namespace UMath
{
	// Token: 0x0200010F RID: 271
	[ExportOnlyCreate(true)]
	public class Matrix4 : ExposedCommonBase
	{
		// Token: 0x06000E92 RID: 3730 RVA: 0x0001133C File Offset: 0x0001033C
		public unsafe static Matrix4 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Matrix4(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x0001135F File Offset: 0x0001035F
		public unsafe Matrix4(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00011369 File Offset: 0x00010369
		protected internal Matrix4(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000E95 RID: 3733 RVA: 0x00011372 File Offset: 0x00010372
		protected internal unsafe Matrix4(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E96 RID: 3734
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1502(void* self);

		// Token: 0x06000E97 RID: 3735 RVA: 0x0001137C File Offset: 0x0001037C
		[DisableExceptionHandling]
		~Matrix4()
		{
			Matrix4._EASharpBinding_1502(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000E98 RID: 3736
		[DllImport("<internal>")]
		private unsafe static extern float* _EASharpBinding_1503(void* _ThisPtr);

		// Token: 0x06000E99 RID: 3737 RVA: 0x000113B8 File Offset: 0x000103B8
		public unsafe float* GetElements()
		{
			return Matrix4._EASharpBinding_1503(this.mSelf);
		}

		// Token: 0x06000E9A RID: 3738
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1505(void* self, void* val);

		// Token: 0x06000E9B RID: 3739
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1506(void* self);

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000E9C RID: 3740 RVA: 0x000113D4 File Offset: 0x000103D4
		// (set) Token: 0x06000E9D RID: 3741 RVA: 0x000113FA File Offset: 0x000103FA
		public Vector4 v0
		{
			get
			{
				return new Vector4(default(ExposeTag_InitOwned), Matrix4._EASharpBinding_1506(this.mSelf));
			}
			set
			{
				Matrix4._EASharpBinding_1505(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000E9E RID: 3742
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1507(void* self, void* val);

		// Token: 0x06000E9F RID: 3743
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1508(void* self);

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000EA0 RID: 3744 RVA: 0x0001141C File Offset: 0x0001041C
		// (set) Token: 0x06000EA1 RID: 3745 RVA: 0x00011442 File Offset: 0x00010442
		public Vector4 v1
		{
			get
			{
				return new Vector4(default(ExposeTag_InitOwned), Matrix4._EASharpBinding_1508(this.mSelf));
			}
			set
			{
				Matrix4._EASharpBinding_1507(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000EA2 RID: 3746
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1509(void* self, void* val);

		// Token: 0x06000EA3 RID: 3747
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1510(void* self);

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x06000EA4 RID: 3748 RVA: 0x00011464 File Offset: 0x00010464
		// (set) Token: 0x06000EA5 RID: 3749 RVA: 0x0001148A File Offset: 0x0001048A
		public Vector4 v2
		{
			get
			{
				return new Vector4(default(ExposeTag_InitOwned), Matrix4._EASharpBinding_1510(this.mSelf));
			}
			set
			{
				Matrix4._EASharpBinding_1509(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000EA6 RID: 3750
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1511(void* self, void* val);

		// Token: 0x06000EA7 RID: 3751
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1512(void* self);

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x06000EA8 RID: 3752 RVA: 0x000114AC File Offset: 0x000104AC
		// (set) Token: 0x06000EA9 RID: 3753 RVA: 0x000114D2 File Offset: 0x000104D2
		public Vector4 v3
		{
			get
			{
				return new Vector4(default(ExposeTag_InitOwned), Matrix4._EASharpBinding_1512(this.mSelf));
			}
			set
			{
				Matrix4._EASharpBinding_1511(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000EAA RID: 3754
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1514();

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000EAB RID: 3755 RVA: 0x000114F4 File Offset: 0x000104F4
		public static Matrix4 kZero
		{
			get
			{
				return new Matrix4(default(ExposeTag_InitUnowned), Matrix4._EASharpBinding_1514());
			}
		}

		// Token: 0x06000EAC RID: 3756
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1516();

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000EAD RID: 3757 RVA: 0x00011514 File Offset: 0x00010514
		public static Matrix4 kIdentity
		{
			get
			{
				return new Matrix4(default(ExposeTag_InitUnowned), Matrix4._EASharpBinding_1516());
			}
		}
	}
}

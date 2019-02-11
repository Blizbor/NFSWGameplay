using System;
using System.Runtime.InteropServices;
using EASharp;

namespace UMath
{
	// Token: 0x02000110 RID: 272
	[ExportOnlyCreate(true)]
	public class Matrix3 : ExposedCommonBase
	{
		// Token: 0x06000EAE RID: 3758 RVA: 0x00011534 File Offset: 0x00010534
		public unsafe static Matrix3 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Matrix3(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000EAF RID: 3759 RVA: 0x00011557 File Offset: 0x00010557
		public unsafe Matrix3(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00011561 File Offset: 0x00010561
		protected internal Matrix3(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x0001156A File Offset: 0x0001056A
		protected internal unsafe Matrix3(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000EB2 RID: 3762
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1517(void* self);

		// Token: 0x06000EB3 RID: 3763 RVA: 0x00011574 File Offset: 0x00010574
		[DisableExceptionHandling]
		~Matrix3()
		{
			Matrix3._EASharpBinding_1517(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000EB4 RID: 3764
		[DllImport("<internal>")]
		private unsafe static extern float* _EASharpBinding_1518(void* _ThisPtr);

		// Token: 0x06000EB5 RID: 3765 RVA: 0x000115B0 File Offset: 0x000105B0
		public unsafe float* GetElements()
		{
			return Matrix3._EASharpBinding_1518(this.mSelf);
		}

		// Token: 0x06000EB6 RID: 3766
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1520(void* self, void* val);

		// Token: 0x06000EB7 RID: 3767
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1521(void* self);

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000EB8 RID: 3768 RVA: 0x000115CC File Offset: 0x000105CC
		// (set) Token: 0x06000EB9 RID: 3769 RVA: 0x000115F2 File Offset: 0x000105F2
		public Vector3 v0
		{
			get
			{
				return new Vector3(default(ExposeTag_InitOwned), Matrix3._EASharpBinding_1521(this.mSelf));
			}
			set
			{
				Matrix3._EASharpBinding_1520(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000EBA RID: 3770
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1522(void* self, void* val);

		// Token: 0x06000EBB RID: 3771
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1523(void* self);

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000EBC RID: 3772 RVA: 0x00011614 File Offset: 0x00010614
		// (set) Token: 0x06000EBD RID: 3773 RVA: 0x0001163A File Offset: 0x0001063A
		public Vector3 v1
		{
			get
			{
				return new Vector3(default(ExposeTag_InitOwned), Matrix3._EASharpBinding_1523(this.mSelf));
			}
			set
			{
				Matrix3._EASharpBinding_1522(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000EBE RID: 3774
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1524(void* self, void* val);

		// Token: 0x06000EBF RID: 3775
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1525(void* self);

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x06000EC0 RID: 3776 RVA: 0x0001165C File Offset: 0x0001065C
		// (set) Token: 0x06000EC1 RID: 3777 RVA: 0x00011682 File Offset: 0x00010682
		public Vector3 v2
		{
			get
			{
				return new Vector3(default(ExposeTag_InitOwned), Matrix3._EASharpBinding_1525(this.mSelf));
			}
			set
			{
				Matrix3._EASharpBinding_1524(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000EC2 RID: 3778
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1527();

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000EC3 RID: 3779 RVA: 0x000116A4 File Offset: 0x000106A4
		public static Matrix3 kZero
		{
			get
			{
				return new Matrix3(default(ExposeTag_InitUnowned), Matrix3._EASharpBinding_1527());
			}
		}

		// Token: 0x06000EC4 RID: 3780
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1529();

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000EC5 RID: 3781 RVA: 0x000116C4 File Offset: 0x000106C4
		public static Matrix3 kIdentity
		{
			get
			{
				return new Matrix3(default(ExposeTag_InitUnowned), Matrix3._EASharpBinding_1529());
			}
		}
	}
}

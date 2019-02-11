using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000C1 RID: 193
	[ExportOnlyCreate(true)]
	public class PursuitInfo : ISerializable
	{
		// Token: 0x06000B7A RID: 2938 RVA: 0x0000E658 File Offset: 0x0000D658
		public new unsafe static PursuitInfo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PursuitInfo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B7B RID: 2939 RVA: 0x0000E67B File Offset: 0x0000D67B
		public unsafe PursuitInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B7C RID: 2940 RVA: 0x0000E685 File Offset: 0x0000D685
		protected internal PursuitInfo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B7D RID: 2941 RVA: 0x0000E68E File Offset: 0x0000D68E
		protected internal unsafe PursuitInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B7E RID: 2942
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1166();

		// Token: 0x06000B7F RID: 2943 RVA: 0x0000E698 File Offset: 0x0000D698
		public PursuitInfo() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PursuitInfo._EASharpBinding_1166();
		}

		// Token: 0x06000B80 RID: 2944
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1167(void* _ThisPtr);

		// Token: 0x06000B81 RID: 2945 RVA: 0x0000E6C0 File Offset: 0x0000D6C0
		~PursuitInfo()
		{
			PursuitInfo._EASharpBinding_1167(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B82 RID: 2946
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1168(void* self, float val);

		// Token: 0x06000B83 RID: 2947
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1169(void* self);

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x06000B84 RID: 2948 RVA: 0x0000E6FC File Offset: 0x0000D6FC
		// (set) Token: 0x06000B85 RID: 2949 RVA: 0x0000E709 File Offset: 0x0000D709
		public float PursuitStatus
		{
			get
			{
				return PursuitInfo._EASharpBinding_1169(this.mSelf);
			}
			set
			{
				PursuitInfo._EASharpBinding_1168(this.mSelf, value);
			}
		}

		// Token: 0x06000B86 RID: 2950
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1170(void* self, uint val);

		// Token: 0x06000B87 RID: 2951
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1171(void* self);

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000B88 RID: 2952 RVA: 0x0000E717 File Offset: 0x0000D717
		// (set) Token: 0x06000B89 RID: 2953 RVA: 0x0000E724 File Offset: 0x0000D724
		public uint NumCopsEngaged
		{
			get
			{
				return PursuitInfo._EASharpBinding_1171(this.mSelf);
			}
			set
			{
				PursuitInfo._EASharpBinding_1170(this.mSelf, value);
			}
		}

		// Token: 0x06000B8A RID: 2954
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1172(void* self, float val);

		// Token: 0x06000B8B RID: 2955
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1173(void* self);

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x06000B8C RID: 2956 RVA: 0x0000E732 File Offset: 0x0000D732
		// (set) Token: 0x06000B8D RID: 2957 RVA: 0x0000E73F File Offset: 0x0000D73F
		public float Heat
		{
			get
			{
				return PursuitInfo._EASharpBinding_1173(this.mSelf);
			}
			set
			{
				PursuitInfo._EASharpBinding_1172(this.mSelf, value);
			}
		}
	}
}

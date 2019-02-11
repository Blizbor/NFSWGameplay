using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Commerce
{
	// Token: 0x0200010D RID: 269
	[ExportOnlyCreate(true)]
	public class HatBonus : ExposedCommonBase
	{
		// Token: 0x06000E62 RID: 3682 RVA: 0x0001112C File Offset: 0x0001012C
		public unsafe static HatBonus CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new HatBonus(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000E63 RID: 3683 RVA: 0x0001114F File Offset: 0x0001014F
		public unsafe HatBonus(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E64 RID: 3684 RVA: 0x00011159 File Offset: 0x00010159
		protected internal HatBonus(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000E65 RID: 3685 RVA: 0x00011162 File Offset: 0x00010162
		protected internal unsafe HatBonus(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000E66 RID: 3686
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1464(void* self);

		// Token: 0x06000E67 RID: 3687 RVA: 0x0001116C File Offset: 0x0001016C
		[DisableExceptionHandling]
		~HatBonus()
		{
			HatBonus._EASharpBinding_1464(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000E68 RID: 3688
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1465(void* self, int val);

		// Token: 0x06000E69 RID: 3689
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1466(void* self);

		// Token: 0x1700010A RID: 266
		// (get) Token: 0x06000E6A RID: 3690 RVA: 0x000111A8 File Offset: 0x000101A8
		// (set) Token: 0x06000E6B RID: 3691 RVA: 0x000111B5 File Offset: 0x000101B5
		public int handling
		{
			get
			{
				return HatBonus._EASharpBinding_1466(this.mSelf);
			}
			set
			{
				HatBonus._EASharpBinding_1465(this.mSelf, value);
			}
		}

		// Token: 0x06000E6C RID: 3692
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1467(void* self, int val);

		// Token: 0x06000E6D RID: 3693
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1468(void* self);

		// Token: 0x1700010B RID: 267
		// (get) Token: 0x06000E6E RID: 3694 RVA: 0x000111C3 File Offset: 0x000101C3
		// (set) Token: 0x06000E6F RID: 3695 RVA: 0x000111D0 File Offset: 0x000101D0
		public int acceleration
		{
			get
			{
				return HatBonus._EASharpBinding_1468(this.mSelf);
			}
			set
			{
				HatBonus._EASharpBinding_1467(this.mSelf, value);
			}
		}

		// Token: 0x06000E70 RID: 3696
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1469(void* self, int val);

		// Token: 0x06000E71 RID: 3697
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1470(void* self);

		// Token: 0x1700010C RID: 268
		// (get) Token: 0x06000E72 RID: 3698 RVA: 0x000111DE File Offset: 0x000101DE
		// (set) Token: 0x06000E73 RID: 3699 RVA: 0x000111EB File Offset: 0x000101EB
		public int topspeed
		{
			get
			{
				return HatBonus._EASharpBinding_1470(this.mSelf);
			}
			set
			{
				HatBonus._EASharpBinding_1469(this.mSelf, value);
			}
		}

		// Token: 0x06000E74 RID: 3700
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1471(void* self, int val);

		// Token: 0x06000E75 RID: 3701
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1472(void* self);

		// Token: 0x1700010D RID: 269
		// (get) Token: 0x06000E76 RID: 3702 RVA: 0x000111F9 File Offset: 0x000101F9
		// (set) Token: 0x06000E77 RID: 3703 RVA: 0x00011206 File Offset: 0x00010206
		public int requiredPartCount
		{
			get
			{
				return HatBonus._EASharpBinding_1472(this.mSelf);
			}
			set
			{
				HatBonus._EASharpBinding_1471(this.mSelf, value);
			}
		}
	}
}

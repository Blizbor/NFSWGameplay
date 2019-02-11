using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000DC RID: 220
	[ExportOnlyCreate(true)]
	public class FrontendFlasher : ExposedCommonBase
	{
		// Token: 0x06000D8A RID: 3466 RVA: 0x00010550 File Offset: 0x0000F550
		public unsafe static FrontendFlasher CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new FrontendFlasher(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000D8B RID: 3467 RVA: 0x00010573 File Offset: 0x0000F573
		public unsafe FrontendFlasher(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D8C RID: 3468 RVA: 0x0001057D File Offset: 0x0000F57D
		protected internal FrontendFlasher(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000D8D RID: 3469 RVA: 0x00010586 File Offset: 0x0000F586
		protected internal unsafe FrontendFlasher(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000D8E RID: 3470
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1376();

		// Token: 0x06000D8F RID: 3471 RVA: 0x00010590 File Offset: 0x0000F590
		public FrontendFlasher() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = FrontendFlasher._EASharpBinding_1376();
		}

		// Token: 0x06000D90 RID: 3472
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1377(void* _ThisPtr);

		// Token: 0x06000D91 RID: 3473 RVA: 0x000105B8 File Offset: 0x0000F5B8
		~FrontendFlasher()
		{
			FrontendFlasher._EASharpBinding_1377(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000D92 RID: 3474
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1378(void* _ThisPtr, sbyte* value);

		// Token: 0x06000D93 RID: 3475 RVA: 0x000105F4 File Offset: 0x0000F5F4
		public unsafe void SetMessage(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FrontendFlasher._EASharpBinding_1378(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000D94 RID: 3476
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1379(void* _ThisPtr, sbyte* value);

		// Token: 0x06000D95 RID: 3477 RVA: 0x00010654 File Offset: 0x0000F654
		public unsafe void SetClipName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FrontendFlasher._EASharpBinding_1379(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000D96 RID: 3478
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1380(void* self, int val);

		// Token: 0x06000D97 RID: 3479
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1381(void* self);

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000D98 RID: 3480 RVA: 0x000106B1 File Offset: 0x0000F6B1
		// (set) Token: 0x06000D99 RID: 3481 RVA: 0x000106BE File Offset: 0x0000F6BE
		public int mId
		{
			get
			{
				return FrontendFlasher._EASharpBinding_1381(this.mSelf);
			}
			set
			{
				FrontendFlasher._EASharpBinding_1380(this.mSelf, value);
			}
		}

		// Token: 0x06000D9A RID: 3482
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1382(void* self, int val);

		// Token: 0x06000D9B RID: 3483
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1383(void* self);

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x000106CC File Offset: 0x0000F6CC
		// (set) Token: 0x06000D9D RID: 3485 RVA: 0x000106D9 File Offset: 0x0000F6D9
		public FLASHER_ALIGNMENT vAlign
		{
			get
			{
				return (FLASHER_ALIGNMENT)FrontendFlasher._EASharpBinding_1383(this.mSelf);
			}
			set
			{
				FrontendFlasher._EASharpBinding_1382(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000D9E RID: 3486
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1384(void* self, uint val);

		// Token: 0x06000D9F RID: 3487
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1385(void* self);

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x000106E7 File Offset: 0x0000F6E7
		// (set) Token: 0x06000DA1 RID: 3489 RVA: 0x000106F4 File Offset: 0x0000F6F4
		public uint HeatLevel
		{
			get
			{
				return FrontendFlasher._EASharpBinding_1385(this.mSelf);
			}
			set
			{
				FrontendFlasher._EASharpBinding_1384(this.mSelf, value);
			}
		}

		// Token: 0x06000DA2 RID: 3490
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1386(void* self, float val);

		// Token: 0x06000DA3 RID: 3491
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1387(void* self);

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000DA4 RID: 3492 RVA: 0x00010702 File Offset: 0x0000F702
		// (set) Token: 0x06000DA5 RID: 3493 RVA: 0x0001070F File Offset: 0x0000F70F
		public float Timer
		{
			get
			{
				return FrontendFlasher._EASharpBinding_1387(this.mSelf);
			}
			set
			{
				FrontendFlasher._EASharpBinding_1386(this.mSelf, value);
			}
		}
	}
}

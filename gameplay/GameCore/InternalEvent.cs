using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200003C RID: 60
	[ExportOnlyCreate(false)]
	public class InternalEvent : ExposedCommonBase
	{
		// Token: 0x060001C4 RID: 452 RVA: 0x00003EA4 File Offset: 0x00002EA4
		public unsafe static InternalEvent CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalEvent(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x00003EC7 File Offset: 0x00002EC7
		public unsafe InternalEvent(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x00003ED1 File Offset: 0x00002ED1
		protected internal InternalEvent(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00003EDA File Offset: 0x00002EDA
		protected internal unsafe InternalEvent(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060001C8 RID: 456
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_160();

		// Token: 0x060001C9 RID: 457 RVA: 0x00003EE4 File Offset: 0x00002EE4
		public InternalEvent() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalEvent._EASharpBinding_160();
		}

		// Token: 0x060001CA RID: 458
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_161(void* _ThisPtr);

		// Token: 0x060001CB RID: 459 RVA: 0x00003F0C File Offset: 0x00002F0C
		~InternalEvent()
		{
			InternalEvent._EASharpBinding_161(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060001CC RID: 460
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_162(void* _ThisPtr, object evnt);

		// Token: 0x060001CD RID: 461 RVA: 0x00003F48 File Offset: 0x00002F48
		public void Ready(Event evnt)
		{
			InternalEvent._EASharpBinding_162(this.mSelf, evnt);
		}

		// Token: 0x060001CE RID: 462
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_163(void* _ThisPtr);

		// Token: 0x060001CF RID: 463 RVA: 0x00003F56 File Offset: 0x00002F56
		public void Dispose()
		{
			InternalEvent._EASharpBinding_163(this.mSelf);
		}

		// Token: 0x060001D0 RID: 464
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_164(void* _ThisPtr);

		// Token: 0x060001D1 RID: 465 RVA: 0x00003F63 File Offset: 0x00002F63
		public void Cleanup()
		{
			InternalEvent._EASharpBinding_164(this.mSelf);
		}

		// Token: 0x060001D2 RID: 466
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_165(void* _ThisPtr);

		// Token: 0x060001D3 RID: 467 RVA: 0x00003F70 File Offset: 0x00002F70
		public void FetchAccolades()
		{
			InternalEvent._EASharpBinding_165(this.mSelf);
		}

		// Token: 0x060001D4 RID: 468
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_166();

		// Token: 0x060001D5 RID: 469 RVA: 0x00003F7D File Offset: 0x00002F7D
		public static void RefreshCoins()
		{
			InternalEvent._EASharpBinding_166();
		}

		// Token: 0x060001D6 RID: 470
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_167(uint coinFlags);

		// Token: 0x060001D7 RID: 471 RVA: 0x00003F84 File Offset: 0x00002F84
		public static void UpdateCoinsCollected(uint coinFlags)
		{
			InternalEvent._EASharpBinding_167(coinFlags);
		}
	}
}

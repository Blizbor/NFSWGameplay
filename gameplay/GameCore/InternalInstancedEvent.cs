using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore.Security;

namespace GameCore
{
	// Token: 0x02000040 RID: 64
	[ExportOnlyCreate(false)]
	public class InternalInstancedEvent : ExposedCommonBase
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000042F4 File Offset: 0x000032F4
		public unsafe static InternalInstancedEvent CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalInstancedEvent(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x00004317 File Offset: 0x00003317
		public unsafe InternalInstancedEvent(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000210 RID: 528 RVA: 0x00004321 File Offset: 0x00003321
		protected internal InternalInstancedEvent(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000211 RID: 529 RVA: 0x0000432A File Offset: 0x0000332A
		protected internal unsafe InternalInstancedEvent(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000212 RID: 530
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_201();

		// Token: 0x06000213 RID: 531 RVA: 0x00004334 File Offset: 0x00003334
		public InternalInstancedEvent() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalInstancedEvent._EASharpBinding_201();
		}

		// Token: 0x06000214 RID: 532
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_202(void* _ThisPtr);

		// Token: 0x06000215 RID: 533 RVA: 0x0000435C File Offset: 0x0000335C
		~InternalInstancedEvent()
		{
			InternalInstancedEvent._EASharpBinding_202(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000216 RID: 534
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_203(void* _ThisPtr, object evnt);

		// Token: 0x06000217 RID: 535 RVA: 0x00004398 File Offset: 0x00003398
		public void Ready(InstancedEvent evnt)
		{
			InternalInstancedEvent._EASharpBinding_203(this.mSelf, evnt);
		}

		// Token: 0x06000218 RID: 536
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_204(void* _ThisPtr, sbyte* eventResult);

		// Token: 0x06000219 RID: 537 RVA: 0x000043A8 File Offset: 0x000033A8
		public unsafe void RegisterArbitrationListener(string eventResult)
		{
			int byteCount = Encoding.ASCII.GetByteCount(eventResult);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(eventResult, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				InternalInstancedEvent._EASharpBinding_204(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600021A RID: 538
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_205(void* _ThisPtr, sbyte* eventResult);

		// Token: 0x0600021B RID: 539 RVA: 0x00004408 File Offset: 0x00003408
		public unsafe void UnRegisterArbitrationListener(string eventResult)
		{
			int byteCount = Encoding.ASCII.GetByteCount(eventResult);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(eventResult, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				InternalInstancedEvent._EASharpBinding_205(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600021C RID: 540
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_206(void* _ThisPtr);

		// Token: 0x0600021D RID: 541 RVA: 0x00004465 File Offset: 0x00003465
		public void Dispose()
		{
			InternalInstancedEvent._EASharpBinding_206(this.mSelf);
		}

		// Token: 0x0600021E RID: 542
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_207(void* _ThisPtr, long eventSessionId);

		// Token: 0x0600021F RID: 543 RVA: 0x00004472 File Offset: 0x00003472
		public void Launched(long eventSessionId)
		{
			InternalInstancedEvent._EASharpBinding_207(this.mSelf, eventSessionId);
		}

		// Token: 0x06000220 RID: 544
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_208(void* _ThisPtr);

		// Token: 0x06000221 RID: 545 RVA: 0x00004480 File Offset: 0x00003480
		public void Cleanup()
		{
			InternalInstancedEvent._EASharpBinding_208(this.mSelf);
		}

		// Token: 0x06000222 RID: 546
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_209(void* _ThisPtr, long eventSessionId);

		// Token: 0x06000223 RID: 547 RVA: 0x0000448D File Offset: 0x0000348D
		public void FetchAccolades(long eventSessionId)
		{
			InternalInstancedEvent._EASharpBinding_209(this.mSelf, eventSessionId);
		}

		// Token: 0x06000224 RID: 548
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_210(void* _ThisPtr, long eventDurationInMilliseconds, object securityInfo);

		// Token: 0x06000225 RID: 549 RVA: 0x0000449B File Offset: 0x0000349B
		public void FillSecurityInfo(long eventDurationInMilliseconds, SecurityInfo securityInfo)
		{
			InternalInstancedEvent._EASharpBinding_210(this.mSelf, eventDurationInMilliseconds, securityInfo);
		}

		// Token: 0x06000226 RID: 550
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_211(void* _ThisPtr);

		// Token: 0x06000227 RID: 551 RVA: 0x000044AA File Offset: 0x000034AA
		public void ArbitrationSucceeded()
		{
			InternalInstancedEvent._EASharpBinding_211(this.mSelf);
		}

		// Token: 0x06000228 RID: 552
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_212(void* _ThisPtr);

		// Token: 0x06000229 RID: 553 RVA: 0x000044B7 File Offset: 0x000034B7
		public void ArbitrationFailed()
		{
			InternalInstancedEvent._EASharpBinding_212(this.mSelf);
		}
	}
}

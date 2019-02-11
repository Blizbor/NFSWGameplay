using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000035 RID: 53
	[ExportOnlyCreate(false)]
	public class Hud : ExposedCommonBase
	{
		// Token: 0x06000158 RID: 344 RVA: 0x00003790 File Offset: 0x00002790
		public unsafe static Hud CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Hud(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000037B3 File Offset: 0x000027B3
		public unsafe Hud(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000037BD File Offset: 0x000027BD
		protected internal Hud(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000037C6 File Offset: 0x000027C6
		protected internal unsafe Hud(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600015C RID: 348
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_95();

		// Token: 0x0600015D RID: 349 RVA: 0x000037D0 File Offset: 0x000027D0
		public Hud() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Hud._EASharpBinding_95();
		}

		// Token: 0x0600015E RID: 350
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_96(void* _ThisPtr);

		// Token: 0x0600015F RID: 351 RVA: 0x000037F8 File Offset: 0x000027F8
		~Hud()
		{
			Hud._EASharpBinding_96(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000160 RID: 352
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_97(void* _ThisPtr, bool on);

		// Token: 0x06000161 RID: 353 RVA: 0x00003834 File Offset: 0x00002834
		public void DisplayStandingsGadget(bool on)
		{
			Hud._EASharpBinding_97(this.mSelf, on);
		}

		// Token: 0x06000162 RID: 354
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_98(void* _ThisPtr, uint eventId);

		// Token: 0x06000163 RID: 355 RVA: 0x00003842 File Offset: 0x00002842
		public void OnEnterEngagable(uint eventId)
		{
			Hud._EASharpBinding_98(this.mSelf, eventId);
		}

		// Token: 0x06000164 RID: 356
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_99(void* _ThisPtr, uint eventId);

		// Token: 0x06000165 RID: 357 RVA: 0x00003850 File Offset: 0x00002850
		public void OnExitEngagable(uint eventId)
		{
			Hud._EASharpBinding_99(this.mSelf, eventId);
		}

		// Token: 0x06000166 RID: 358
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_100(void* _ThisPtr);

		// Token: 0x06000167 RID: 359 RVA: 0x0000385E File Offset: 0x0000285E
		public void HideAllGadgets()
		{
			Hud._EASharpBinding_100(this.mSelf);
		}

		// Token: 0x06000168 RID: 360
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_101(void* _ThisPtr, sbyte* name, bool hide);

		// Token: 0x06000169 RID: 361 RVA: 0x0000386C File Offset: 0x0000286C
		public unsafe void HideGadget(string name, bool hide)
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Hud._EASharpBinding_101(this.mSelf, (sbyte*)ptr, hide);
			}
		}

		// Token: 0x0600016A RID: 362
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_102(void* _ThisPtr);

		// Token: 0x0600016B RID: 363 RVA: 0x000038CA File Offset: 0x000028CA
		public void UnHideAllGadgets()
		{
			Hud._EASharpBinding_102(this.mSelf);
		}

		// Token: 0x0600016C RID: 364
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_103(void* _ThisPtr, int personaId);

		// Token: 0x0600016D RID: 365 RVA: 0x000038D7 File Offset: 0x000028D7
		public void OnPerfectLaunchAchieved(int personaId)
		{
			Hud._EASharpBinding_103(this.mSelf, personaId);
		}

		// Token: 0x0600016E RID: 366
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_104(bool enable);

		// Token: 0x0600016F RID: 367 RVA: 0x000038E5 File Offset: 0x000028E5
		public static void EnableMinimapTrackLayout(bool enable)
		{
			Hud._EASharpBinding_104(enable);
		}

		// Token: 0x06000170 RID: 368
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_105(sbyte* gadget, bool enable);

		// Token: 0x06000171 RID: 369 RVA: 0x000038F0 File Offset: 0x000028F0
		public unsafe static void EnableGadget(string gadget, bool enable)
		{
			int byteCount = Encoding.ASCII.GetByteCount(gadget);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(gadget, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Hud._EASharpBinding_105((sbyte*)ptr, enable);
			}
		}

		// Token: 0x06000172 RID: 370
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_106(sbyte* gadget);

		// Token: 0x06000173 RID: 371 RVA: 0x00003948 File Offset: 0x00002948
		public unsafe static void DisposeGadget(string gadget)
		{
			int byteCount = Encoding.ASCII.GetByteCount(gadget);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(gadget, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Hud._EASharpBinding_106((sbyte*)ptr);
			}
		}

		// Token: 0x06000174 RID: 372
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_107(int streak, bool isStreakBroken);

		// Token: 0x06000175 RID: 373 RVA: 0x0000399F File Offset: 0x0000299F
		public static void ShowTreasureStreakBuff(int streak, bool isStreakBroken)
		{
			Hud._EASharpBinding_107(streak, isStreakBroken);
		}

		// Token: 0x06000176 RID: 374
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_108();

		// Token: 0x06000177 RID: 375 RVA: 0x000039A8 File Offset: 0x000029A8
		public static void ClearAllBuff()
		{
			Hud._EASharpBinding_108();
		}
	}
}

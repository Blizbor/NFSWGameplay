using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using Interop;

namespace GameCore
{
	// Token: 0x0200002F RID: 47
	[ExportOnlyCreate(false)]
	public class Marshal : ExposedCommonBase
	{
		// Token: 0x06000104 RID: 260 RVA: 0x00003104 File Offset: 0x00002104
		public unsafe static Marshal CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Marshal(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00003127 File Offset: 0x00002127
		public unsafe Marshal(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00003131 File Offset: 0x00002131
		protected internal Marshal(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000313A File Offset: 0x0000213A
		protected internal unsafe Marshal(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000108 RID: 264
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_65(void* self);

		// Token: 0x06000109 RID: 265 RVA: 0x00003144 File Offset: 0x00002144
		[DisableExceptionHandling]
		~Marshal()
		{
			Marshal._EASharpBinding_65(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600010A RID: 266
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_66();

		// Token: 0x0600010B RID: 267 RVA: 0x00003180 File Offset: 0x00002180
		public static Marshal Get()
		{
			return Marshal.CreateInitUnowned(Marshal._EASharpBinding_66());
		}

		// Token: 0x0600010C RID: 268
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_67(void* _ThisPtr, int source);

		// Token: 0x0600010D RID: 269 RVA: 0x0000319C File Offset: 0x0000219C
		public bool HandleTutorial(TutorialSource source)
		{
			return Marshal._EASharpBinding_67(this.mSelf, (int)source);
		}

		// Token: 0x0600010E RID: 270
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_68(void* _ThisPtr, int source);

		// Token: 0x0600010F RID: 271 RVA: 0x000031B8 File Offset: 0x000021B8
		public bool IsTutorialComplete(TutorialSource source)
		{
			return Marshal._EASharpBinding_68(this.mSelf, (int)source);
		}

		// Token: 0x06000110 RID: 272
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_69(void* _ThisPtr, sbyte* name);

		// Token: 0x06000111 RID: 273 RVA: 0x000031D4 File Offset: 0x000021D4
		public unsafe bool CheckFirstClick(string name)
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return Marshal._EASharpBinding_69(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000112 RID: 274
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_70(void* _ThisPtr, bool enable, float time);

		// Token: 0x06000113 RID: 275 RVA: 0x00003239 File Offset: 0x00002239
		public void EnableGhosting(bool enable, float time)
		{
			Marshal._EASharpBinding_70(this.mSelf, enable, time);
		}

		// Token: 0x06000114 RID: 276
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_71(void* _ThisPtr, bool enable);

		// Token: 0x06000115 RID: 277 RVA: 0x00003248 File Offset: 0x00002248
		public void EnableKeyboard(bool enable)
		{
			Marshal._EASharpBinding_71(this.mSelf, enable);
		}

		// Token: 0x06000116 RID: 278
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_72(void* _ThisPtr, ulong newsId, sbyte* shortDesc, sbyte* longDesc);

		// Token: 0x06000117 RID: 279 RVA: 0x00003258 File Offset: 0x00002258
		public unsafe void SendNews(ulong newsId, string shortDesc, string longDesc)
		{
			int byteCount = Encoding.ASCII.GetByteCount(shortDesc);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(shortDesc, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				int byteCount2 = Encoding.ASCII.GetByteCount(longDesc);
				byte[] array2 = new byte[byteCount2 + 1];
				Encoding.ASCII.GetBytes(longDesc, 0, byteCount2, array2, 0);
				array2[byteCount2] = 0;
				fixed (byte* ptr2 = array2)
				{
					Marshal._EASharpBinding_72(this.mSelf, newsId, (sbyte*)ptr, (sbyte*)ptr2);
				}
			}
		}

		// Token: 0x06000118 RID: 280
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_73(void* _ThisPtr, uint eventId, void* callback);

		// Token: 0x06000119 RID: 281 RVA: 0x00003309 File Offset: 0x00002309
		public void GetEventInfoById(uint eventId, ICallback callback)
		{
			Marshal._EASharpBinding_73(this.mSelf, eventId, object.ReferenceEquals(callback, null) ? null : callback._GetRaw());
		}

		// Token: 0x0600011A RID: 282
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_74(void* _ThisPtr, uint eventId, void* eventInfo);

		// Token: 0x0600011B RID: 283 RVA: 0x0000332A File Offset: 0x0000232A
		public void GetEventInfoById(uint eventId, EventInfo eventInfo)
		{
			Marshal._EASharpBinding_74(this.mSelf, eventId, object.ReferenceEquals(eventInfo, null) ? null : eventInfo._GetRaw());
		}

		// Token: 0x0600011C RID: 284
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_75(void* _ThisPtr);

		// Token: 0x0600011D RID: 285 RVA: 0x0000334C File Offset: 0x0000234C
		public bool GetIsMetricUnits()
		{
			return Marshal._EASharpBinding_75(this.mSelf);
		}

		// Token: 0x0600011E RID: 286
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_76(void* _ThisPtr, int carDurability);

		// Token: 0x0600011F RID: 287 RVA: 0x00003366 File Offset: 0x00002366
		public void SetLocalPlayersDurability(int carDurability)
		{
			Marshal._EASharpBinding_76(this.mSelf, carDurability);
		}

		// Token: 0x06000120 RID: 288
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_77(void* _ThisPtr, int boostGiftAmount, bool checkIfAlreadyShown);

		// Token: 0x06000121 RID: 289 RVA: 0x00003374 File Offset: 0x00002374
		public void ShowSpeedBoostTutorial(int boostGiftAmount, bool checkIfAlreadyShown)
		{
			Marshal._EASharpBinding_77(this.mSelf, boostGiftAmount, checkIfAlreadyShown);
		}

		// Token: 0x06000122 RID: 290
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_78(void* _ThisPtr, long personaId, void* persona);

		// Token: 0x06000123 RID: 291 RVA: 0x00003384 File Offset: 0x00002384
		public bool FillFEPlayerPersona(long personaId, FEPlayerPersona persona)
		{
			return Marshal._EASharpBinding_78(this.mSelf, personaId, object.ReferenceEquals(persona, null) ? null : persona._GetRaw());
		}
	}
}

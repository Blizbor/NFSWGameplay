using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000CA RID: 202
	[ExportOnlyCreate(true)]
	public class LuckyDraw : ISerializable
	{
		// Token: 0x06000C1C RID: 3100 RVA: 0x0000F1D4 File Offset: 0x0000E1D4
		public new unsafe static LuckyDraw CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LuckyDraw(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000C1D RID: 3101 RVA: 0x0000F1F7 File Offset: 0x0000E1F7
		public unsafe LuckyDraw(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C1E RID: 3102 RVA: 0x0000F201 File Offset: 0x0000E201
		protected internal LuckyDraw(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000C1F RID: 3103 RVA: 0x0000F20A File Offset: 0x0000E20A
		protected internal unsafe LuckyDraw(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C20 RID: 3104
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1229();

		// Token: 0x06000C21 RID: 3105 RVA: 0x0000F214 File Offset: 0x0000E214
		public LuckyDraw() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = LuckyDraw._EASharpBinding_1229();
		}

		// Token: 0x06000C22 RID: 3106
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1230(void* _ThisPtr);

		// Token: 0x06000C23 RID: 3107 RVA: 0x0000F23C File Offset: 0x0000E23C
		~LuckyDraw()
		{
			LuckyDraw._EASharpBinding_1230(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000C24 RID: 3108
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1231(void* _ThisPtr, sbyte* value);

		// Token: 0x06000C25 RID: 3109 RVA: 0x0000F278 File Offset: 0x0000E278
		public unsafe void SetCardDeck(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				LuckyDraw._EASharpBinding_1231(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000C26 RID: 3110
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1232(void* _ThisPtr, void* value);

		// Token: 0x06000C27 RID: 3111 RVA: 0x0000F2D5 File Offset: 0x0000E2D5
		public void AddItems(LuckyItem value)
		{
			LuckyDraw._EASharpBinding_1232(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000C28 RID: 3112
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1233(void* _ThisPtr, void* value);

		// Token: 0x06000C29 RID: 3113 RVA: 0x0000F2F5 File Offset: 0x0000E2F5
		public void AddBoxes(LuckyBox value)
		{
			LuckyDraw._EASharpBinding_1233(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000C2A RID: 3114
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1234(void* self, int val);

		// Token: 0x06000C2B RID: 3115
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1235(void* self);

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000C2C RID: 3116 RVA: 0x0000F315 File Offset: 0x0000E315
		// (set) Token: 0x06000C2D RID: 3117 RVA: 0x0000F322 File Offset: 0x0000E322
		public int NumCards
		{
			get
			{
				return LuckyDraw._EASharpBinding_1235(this.mSelf);
			}
			set
			{
				LuckyDraw._EASharpBinding_1234(this.mSelf, value);
			}
		}

		// Token: 0x06000C2E RID: 3118
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1236(void* self, int val);

		// Token: 0x06000C2F RID: 3119
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1237(void* self);

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000C30 RID: 3120 RVA: 0x0000F330 File Offset: 0x0000E330
		// (set) Token: 0x06000C31 RID: 3121 RVA: 0x0000F33D File Offset: 0x0000E33D
		public int NumBoxAnimations
		{
			get
			{
				return LuckyDraw._EASharpBinding_1237(this.mSelf);
			}
			set
			{
				LuckyDraw._EASharpBinding_1236(this.mSelf, value);
			}
		}

		// Token: 0x06000C32 RID: 3122
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1238(void* self, int val);

		// Token: 0x06000C33 RID: 3123
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1239(void* self);

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x06000C34 RID: 3124 RVA: 0x0000F34B File Offset: 0x0000E34B
		// (set) Token: 0x06000C35 RID: 3125 RVA: 0x0000F358 File Offset: 0x0000E358
		public int CurrentStreak
		{
			get
			{
				return LuckyDraw._EASharpBinding_1239(this.mSelf);
			}
			set
			{
				LuckyDraw._EASharpBinding_1238(this.mSelf, value);
			}
		}

		// Token: 0x06000C36 RID: 3126
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1240(void* self, bool val);

		// Token: 0x06000C37 RID: 3127
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1241(void* self);

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x06000C38 RID: 3128 RVA: 0x0000F366 File Offset: 0x0000E366
		// (set) Token: 0x06000C39 RID: 3129 RVA: 0x0000F373 File Offset: 0x0000E373
		public bool IsStreakBroken
		{
			get
			{
				return LuckyDraw._EASharpBinding_1241(this.mSelf);
			}
			set
			{
				LuckyDraw._EASharpBinding_1240(this.mSelf, value);
			}
		}

		// Token: 0x06000C3A RID: 3130
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1242(void* self, bool val);

		// Token: 0x06000C3B RID: 3131
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1243(void* self);

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000C3C RID: 3132 RVA: 0x0000F381 File Offset: 0x0000E381
		// (set) Token: 0x06000C3D RID: 3133 RVA: 0x0000F38E File Offset: 0x0000E38E
		public bool HasLuckyDraw
		{
			get
			{
				return LuckyDraw._EASharpBinding_1243(this.mSelf);
			}
			set
			{
				LuckyDraw._EASharpBinding_1242(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000CB RID: 203
	[ExportOnlyCreate(true)]
	public class Accolades : ISerializable
	{
		// Token: 0x06000C3E RID: 3134 RVA: 0x0000F39C File Offset: 0x0000E39C
		public new unsafe static Accolades CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Accolades(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000C3F RID: 3135 RVA: 0x0000F3BF File Offset: 0x0000E3BF
		public unsafe Accolades(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C40 RID: 3136 RVA: 0x0000F3C9 File Offset: 0x0000E3C9
		protected internal Accolades(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000C41 RID: 3137 RVA: 0x0000F3D2 File Offset: 0x0000E3D2
		protected internal unsafe Accolades(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C42 RID: 3138
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1244();

		// Token: 0x06000C43 RID: 3139 RVA: 0x0000F3DC File Offset: 0x0000E3DC
		public Accolades() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Accolades._EASharpBinding_1244();
		}

		// Token: 0x06000C44 RID: 3140
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1245(void* _ThisPtr);

		// Token: 0x06000C45 RID: 3141 RVA: 0x0000F404 File Offset: 0x0000E404
		~Accolades()
		{
			Accolades._EASharpBinding_1245(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000C46 RID: 3142
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1246(void* _ThisPtr, void* value);

		// Token: 0x06000C47 RID: 3143 RVA: 0x0000F440 File Offset: 0x0000E440
		public void AddRewardParts(RewardPart value)
		{
			Accolades._EASharpBinding_1246(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000C48 RID: 3144
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1247(void* _ThisPtr);

		// Token: 0x06000C49 RID: 3145 RVA: 0x0000F460 File Offset: 0x0000E460
		public LuckyDraw GetLuckyDraw()
		{
			return LuckyDraw.CreateInitUnowned(Accolades._EASharpBinding_1247(this.mSelf));
		}

		// Token: 0x06000C4A RID: 3146
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1248(void* self, int val);

		// Token: 0x06000C4B RID: 3147
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1249(void* self);

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000C4C RID: 3148 RVA: 0x0000F47F File Offset: 0x0000E47F
		// (set) Token: 0x06000C4D RID: 3149 RVA: 0x0000F48C File Offset: 0x0000E48C
		public int Reputation
		{
			get
			{
				return Accolades._EASharpBinding_1249(this.mSelf);
			}
			set
			{
				Accolades._EASharpBinding_1248(this.mSelf, value);
			}
		}

		// Token: 0x06000C4E RID: 3150
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1250(void* self, int val);

		// Token: 0x06000C4F RID: 3151
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1251(void* self);

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000C50 RID: 3152 RVA: 0x0000F49A File Offset: 0x0000E49A
		// (set) Token: 0x06000C51 RID: 3153 RVA: 0x0000F4A7 File Offset: 0x0000E4A7
		public int Tokens
		{
			get
			{
				return Accolades._EASharpBinding_1251(this.mSelf);
			}
			set
			{
				Accolades._EASharpBinding_1250(this.mSelf, value);
			}
		}

		// Token: 0x06000C52 RID: 3154
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1252(void* self, int val);

		// Token: 0x06000C53 RID: 3155
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1253(void* self);

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000C54 RID: 3156 RVA: 0x0000F4B5 File Offset: 0x0000E4B5
		// (set) Token: 0x06000C55 RID: 3157 RVA: 0x0000F4C2 File Offset: 0x0000E4C2
		public int OriginalReputation
		{
			get
			{
				return Accolades._EASharpBinding_1253(this.mSelf);
			}
			set
			{
				Accolades._EASharpBinding_1252(this.mSelf, value);
			}
		}

		// Token: 0x06000C56 RID: 3158
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1254(void* self, int val);

		// Token: 0x06000C57 RID: 3159
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1255(void* self);

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000C58 RID: 3160 RVA: 0x0000F4D0 File Offset: 0x0000E4D0
		// (set) Token: 0x06000C59 RID: 3161 RVA: 0x0000F4DD File Offset: 0x0000E4DD
		public int OriginalTokens
		{
			get
			{
				return Accolades._EASharpBinding_1255(this.mSelf);
			}
			set
			{
				Accolades._EASharpBinding_1254(this.mSelf, value);
			}
		}

		// Token: 0x06000C5A RID: 3162
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1256(void* self, bool val);

		// Token: 0x06000C5B RID: 3163
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1257(void* self);

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000C5C RID: 3164 RVA: 0x0000F4EB File Offset: 0x0000E4EB
		// (set) Token: 0x06000C5D RID: 3165 RVA: 0x0000F4F8 File Offset: 0x0000E4F8
		public bool HasLeveledUp
		{
			get
			{
				return Accolades._EASharpBinding_1257(this.mSelf);
			}
			set
			{
				Accolades._EASharpBinding_1256(this.mSelf, value);
			}
		}
	}
}

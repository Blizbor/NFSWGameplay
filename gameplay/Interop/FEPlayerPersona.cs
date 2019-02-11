using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000A4 RID: 164
	[ExportOnlyCreate(true)]
	public class FEPlayerPersona : ISerializable
	{
		// Token: 0x060008D0 RID: 2256 RVA: 0x0000BB1C File Offset: 0x0000AB1C
		public new unsafe static FEPlayerPersona CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new FEPlayerPersona(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060008D1 RID: 2257 RVA: 0x0000BB3F File Offset: 0x0000AB3F
		public unsafe FEPlayerPersona(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060008D2 RID: 2258 RVA: 0x0000BB49 File Offset: 0x0000AB49
		protected internal FEPlayerPersona(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060008D3 RID: 2259 RVA: 0x0000BB52 File Offset: 0x0000AB52
		protected internal unsafe FEPlayerPersona(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060008D4 RID: 2260
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_882();

		// Token: 0x060008D5 RID: 2261 RVA: 0x0000BB5C File Offset: 0x0000AB5C
		public FEPlayerPersona() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = FEPlayerPersona._EASharpBinding_882();
		}

		// Token: 0x060008D6 RID: 2262
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_883(void* _ThisPtr);

		// Token: 0x060008D7 RID: 2263 RVA: 0x0000BB84 File Offset: 0x0000AB84
		~FEPlayerPersona()
		{
			FEPlayerPersona._EASharpBinding_883(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060008D8 RID: 2264
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_884(void* _ThisPtr);

		// Token: 0x060008D9 RID: 2265 RVA: 0x0000BBC0 File Offset: 0x0000ABC0
		public void Reset()
		{
			FEPlayerPersona._EASharpBinding_884(this.mSelf);
		}

		// Token: 0x060008DA RID: 2266
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_885(void* _ThisPtr, void* value);

		// Token: 0x060008DB RID: 2267 RVA: 0x0000BBCD File Offset: 0x0000ABCD
		public void AddBadges(BadgePacket value)
		{
			FEPlayerPersona._EASharpBinding_885(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x060008DC RID: 2268
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_886(void* _ThisPtr, sbyte* value);

		// Token: 0x060008DD RID: 2269 RVA: 0x0000BBF0 File Offset: 0x0000ABF0
		public unsafe void SetPersonaName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				FEPlayerPersona._EASharpBinding_886(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060008DE RID: 2270
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_887(void* self, int val);

		// Token: 0x060008DF RID: 2271
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_888(void* self);

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x060008E0 RID: 2272 RVA: 0x0000BC4D File Offset: 0x0000AC4D
		// (set) Token: 0x060008E1 RID: 2273 RVA: 0x0000BC5A File Offset: 0x0000AC5A
		public int DefaultIndex
		{
			get
			{
				return FEPlayerPersona._EASharpBinding_888(this.mSelf);
			}
			set
			{
				FEPlayerPersona._EASharpBinding_887(this.mSelf, value);
			}
		}

		// Token: 0x060008E2 RID: 2274
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_889(void* self, long val);

		// Token: 0x060008E3 RID: 2275
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_890(void* self);

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x060008E4 RID: 2276 RVA: 0x0000BC68 File Offset: 0x0000AC68
		// (set) Token: 0x060008E5 RID: 2277 RVA: 0x0000BC75 File Offset: 0x0000AC75
		public long PersonaId
		{
			get
			{
				return FEPlayerPersona._EASharpBinding_890(this.mSelf);
			}
			set
			{
				FEPlayerPersona._EASharpBinding_889(this.mSelf, value);
			}
		}

		// Token: 0x060008E6 RID: 2278
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_891(void* self, long val);

		// Token: 0x060008E7 RID: 2279
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_892(void* self);

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x060008E8 RID: 2280 RVA: 0x0000BC83 File Offset: 0x0000AC83
		// (set) Token: 0x060008E9 RID: 2281 RVA: 0x0000BC90 File Offset: 0x0000AC90
		public long IconIndex
		{
			get
			{
				return FEPlayerPersona._EASharpBinding_892(this.mSelf);
			}
			set
			{
				FEPlayerPersona._EASharpBinding_891(this.mSelf, value);
			}
		}

		// Token: 0x060008EA RID: 2282
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_893(void* self, int val);

		// Token: 0x060008EB RID: 2283
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_894(void* self);

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x060008EC RID: 2284 RVA: 0x0000BC9E File Offset: 0x0000AC9E
		// (set) Token: 0x060008ED RID: 2285 RVA: 0x0000BCAB File Offset: 0x0000ACAB
		public int Score
		{
			get
			{
				return FEPlayerPersona._EASharpBinding_894(this.mSelf);
			}
			set
			{
				FEPlayerPersona._EASharpBinding_893(this.mSelf, value);
			}
		}

		// Token: 0x060008EE RID: 2286
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_895(void* self, uint val);

		// Token: 0x060008EF RID: 2287
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_896(void* self);

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x060008F0 RID: 2288 RVA: 0x0000BCB9 File Offset: 0x0000ACB9
		// (set) Token: 0x060008F1 RID: 2289 RVA: 0x0000BCC6 File Offset: 0x0000ACC6
		public uint Level
		{
			get
			{
				return FEPlayerPersona._EASharpBinding_896(this.mSelf);
			}
			set
			{
				FEPlayerPersona._EASharpBinding_895(this.mSelf, value);
			}
		}

		// Token: 0x060008F2 RID: 2290
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_897(void* self, bool val);

		// Token: 0x060008F3 RID: 2291
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_898(void* self);

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x060008F4 RID: 2292 RVA: 0x0000BCD4 File Offset: 0x0000ACD4
		// (set) Token: 0x060008F5 RID: 2293 RVA: 0x0000BCE1 File Offset: 0x0000ACE1
		public bool IsLocal
		{
			get
			{
				return FEPlayerPersona._EASharpBinding_898(this.mSelf);
			}
			set
			{
				FEPlayerPersona._EASharpBinding_897(this.mSelf, value);
			}
		}
	}
}

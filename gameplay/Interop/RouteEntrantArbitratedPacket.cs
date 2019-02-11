using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D0 RID: 208
	[ExportOnlyCreate(true)]
	public class RouteEntrantArbitratedPacket : EntrantArbitratedPacket
	{
		// Token: 0x06000CB0 RID: 3248 RVA: 0x0000F9DC File Offset: 0x0000E9DC
		public new unsafe static RouteEntrantArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RouteEntrantArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000CB1 RID: 3249 RVA: 0x0000F9FF File Offset: 0x0000E9FF
		public unsafe RouteEntrantArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CB2 RID: 3250 RVA: 0x0000FA09 File Offset: 0x0000EA09
		protected internal RouteEntrantArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000CB3 RID: 3251 RVA: 0x0000FA12 File Offset: 0x0000EA12
		protected internal unsafe RouteEntrantArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CB4 RID: 3252
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1291();

		// Token: 0x06000CB5 RID: 3253 RVA: 0x0000FA1C File Offset: 0x0000EA1C
		public RouteEntrantArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RouteEntrantArbitratedPacket._EASharpBinding_1291();
		}

		// Token: 0x06000CB6 RID: 3254
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1292(void* _ThisPtr);

		// Token: 0x06000CB7 RID: 3255 RVA: 0x0000FA44 File Offset: 0x0000EA44
		~RouteEntrantArbitratedPacket()
		{
			RouteEntrantArbitratedPacket._EASharpBinding_1292(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000CB8 RID: 3256
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1293(void* self, float val);

		// Token: 0x06000CB9 RID: 3257
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1294(void* self);

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000CBA RID: 3258 RVA: 0x0000FA80 File Offset: 0x0000EA80
		// (set) Token: 0x06000CBB RID: 3259 RVA: 0x0000FA8D File Offset: 0x0000EA8D
		public float TopSpeed
		{
			get
			{
				return RouteEntrantArbitratedPacket._EASharpBinding_1294(this.mSelf);
			}
			set
			{
				RouteEntrantArbitratedPacket._EASharpBinding_1293(this.mSelf, value);
			}
		}

		// Token: 0x06000CBC RID: 3260
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1295(void* self, float val);

		// Token: 0x06000CBD RID: 3261
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1296(void* self);

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000CBE RID: 3262 RVA: 0x0000FA9B File Offset: 0x0000EA9B
		// (set) Token: 0x06000CBF RID: 3263 RVA: 0x0000FAA8 File Offset: 0x0000EAA8
		public float BestLapDuration
		{
			get
			{
				return RouteEntrantArbitratedPacket._EASharpBinding_1296(this.mSelf);
			}
			set
			{
				RouteEntrantArbitratedPacket._EASharpBinding_1295(this.mSelf, value);
			}
		}
	}
}

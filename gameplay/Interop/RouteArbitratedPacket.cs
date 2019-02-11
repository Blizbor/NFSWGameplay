using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000D1 RID: 209
	[ExportOnlyCreate(true)]
	public class RouteArbitratedPacket : ArbitratedPacket
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x0000FAB8 File Offset: 0x0000EAB8
		public new unsafe static RouteArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RouteArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000CC1 RID: 3265 RVA: 0x0000FADB File Offset: 0x0000EADB
		public unsafe RouteArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CC2 RID: 3266 RVA: 0x0000FAE5 File Offset: 0x0000EAE5
		protected internal RouteArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000CC3 RID: 3267 RVA: 0x0000FAEE File Offset: 0x0000EAEE
		protected internal unsafe RouteArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CC4 RID: 3268
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1297();

		// Token: 0x06000CC5 RID: 3269 RVA: 0x0000FAF8 File Offset: 0x0000EAF8
		public RouteArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RouteArbitratedPacket._EASharpBinding_1297();
		}

		// Token: 0x06000CC6 RID: 3270
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1298(void* _ThisPtr);

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0000FB20 File Offset: 0x0000EB20
		~RouteArbitratedPacket()
		{
			RouteArbitratedPacket._EASharpBinding_1298(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000CC8 RID: 3272
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1299(void* _ThisPtr);

		// Token: 0x06000CC9 RID: 3273 RVA: 0x0000FB5C File Offset: 0x0000EB5C
		public override void Reset()
		{
			RouteArbitratedPacket._EASharpBinding_1299(this.mSelf);
		}

		// Token: 0x06000CCA RID: 3274
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1300(void* _ThisPtr);

		// Token: 0x06000CCB RID: 3275 RVA: 0x0000FB6C File Offset: 0x0000EB6C
		public RouteEntrantArbitratedPacket CreateEntrantArbitratedPacket()
		{
			return RouteEntrantArbitratedPacket.CreateInitUnowned(RouteArbitratedPacket._EASharpBinding_1300(this.mSelf));
		}

		// Token: 0x06000CCC RID: 3276
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1301(void* self, uint val);

		// Token: 0x06000CCD RID: 3277
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1302(void* self);

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000CCE RID: 3278 RVA: 0x0000FB8B File Offset: 0x0000EB8B
		// (set) Token: 0x06000CCF RID: 3279 RVA: 0x0000FB98 File Offset: 0x0000EB98
		public uint NumLaps
		{
			get
			{
				return RouteArbitratedPacket._EASharpBinding_1302(this.mSelf);
			}
			set
			{
				RouteArbitratedPacket._EASharpBinding_1301(this.mSelf, value);
			}
		}
	}
}

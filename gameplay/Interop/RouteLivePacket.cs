using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000AD RID: 173
	[ExportOnlyCreate(true)]
	public class RouteLivePacket : LivePacket
	{
		// Token: 0x060009D4 RID: 2516 RVA: 0x0000CB98 File Offset: 0x0000BB98
		public new unsafe static RouteLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RouteLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060009D5 RID: 2517 RVA: 0x0000CBBB File Offset: 0x0000BBBB
		public unsafe RouteLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009D6 RID: 2518 RVA: 0x0000CBC5 File Offset: 0x0000BBC5
		protected internal RouteLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060009D7 RID: 2519 RVA: 0x0000CBCE File Offset: 0x0000BBCE
		protected internal unsafe RouteLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009D8 RID: 2520
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_995();

		// Token: 0x060009D9 RID: 2521 RVA: 0x0000CBD8 File Offset: 0x0000BBD8
		public RouteLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RouteLivePacket._EASharpBinding_995();
		}

		// Token: 0x060009DA RID: 2522
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_996(void* _ThisPtr);

		// Token: 0x060009DB RID: 2523 RVA: 0x0000CC00 File Offset: 0x0000BC00
		~RouteLivePacket()
		{
			RouteLivePacket._EASharpBinding_996(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060009DC RID: 2524
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_997(void* _ThisPtr);

		// Token: 0x060009DD RID: 2525 RVA: 0x0000CC3C File Offset: 0x0000BC3C
		public override void Reset()
		{
			RouteLivePacket._EASharpBinding_997(this.mSelf);
		}

		// Token: 0x060009DE RID: 2526
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_998(void* _ThisPtr);

		// Token: 0x060009DF RID: 2527 RVA: 0x0000CC4C File Offset: 0x0000BC4C
		public RouteEntrantLivePacket CreateEntrantLivePacket()
		{
			return RouteEntrantLivePacket.CreateInitUnowned(RouteLivePacket._EASharpBinding_998(this.mSelf));
		}

		// Token: 0x060009E0 RID: 2528
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_999(void* self, uint val);

		// Token: 0x060009E1 RID: 2529
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1000(void* self);

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060009E2 RID: 2530 RVA: 0x0000CC6B File Offset: 0x0000BC6B
		// (set) Token: 0x060009E3 RID: 2531 RVA: 0x0000CC78 File Offset: 0x0000BC78
		public uint NumLaps
		{
			get
			{
				return RouteLivePacket._EASharpBinding_1000(this.mSelf);
			}
			set
			{
				RouteLivePacket._EASharpBinding_999(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000AF RID: 175
	[ExportOnlyCreate(true)]
	public class PursuitLivePacket : LivePacket
	{
		// Token: 0x060009F4 RID: 2548 RVA: 0x0000CD64 File Offset: 0x0000BD64
		public new unsafe static PursuitLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PursuitLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060009F5 RID: 2549 RVA: 0x0000CD87 File Offset: 0x0000BD87
		public unsafe PursuitLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009F6 RID: 2550 RVA: 0x0000CD91 File Offset: 0x0000BD91
		protected internal PursuitLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060009F7 RID: 2551 RVA: 0x0000CD9A File Offset: 0x0000BD9A
		protected internal unsafe PursuitLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009F8 RID: 2552
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1007();

		// Token: 0x060009F9 RID: 2553 RVA: 0x0000CDA4 File Offset: 0x0000BDA4
		public PursuitLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PursuitLivePacket._EASharpBinding_1007();
		}

		// Token: 0x060009FA RID: 2554
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1008(void* _ThisPtr);

		// Token: 0x060009FB RID: 2555 RVA: 0x0000CDCC File Offset: 0x0000BDCC
		~PursuitLivePacket()
		{
			PursuitLivePacket._EASharpBinding_1008(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060009FC RID: 2556
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1009(void* _ThisPtr);

		// Token: 0x060009FD RID: 2557 RVA: 0x0000CE08 File Offset: 0x0000BE08
		public override void Reset()
		{
			PursuitLivePacket._EASharpBinding_1009(this.mSelf);
		}

		// Token: 0x060009FE RID: 2558
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1010(void* _ThisPtr);

		// Token: 0x060009FF RID: 2559 RVA: 0x0000CE18 File Offset: 0x0000BE18
		public PursuitEntrantLivePacket CreateEntrantLivePacket()
		{
			return PursuitEntrantLivePacket.CreateInitUnowned(PursuitLivePacket._EASharpBinding_1010(this.mSelf));
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000AE RID: 174
	[ExportOnlyCreate(true)]
	public class PursuitEntrantLivePacket : EntrantLivePacket
	{
		// Token: 0x060009E4 RID: 2532 RVA: 0x0000CC88 File Offset: 0x0000BC88
		public new unsafe static PursuitEntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PursuitEntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060009E5 RID: 2533 RVA: 0x0000CCAB File Offset: 0x0000BCAB
		public unsafe PursuitEntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009E6 RID: 2534 RVA: 0x0000CCB5 File Offset: 0x0000BCB5
		protected internal PursuitEntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060009E7 RID: 2535 RVA: 0x0000CCBE File Offset: 0x0000BCBE
		protected internal unsafe PursuitEntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009E8 RID: 2536
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1001();

		// Token: 0x060009E9 RID: 2537 RVA: 0x0000CCC8 File Offset: 0x0000BCC8
		public PursuitEntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PursuitEntrantLivePacket._EASharpBinding_1001();
		}

		// Token: 0x060009EA RID: 2538
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1002(void* _ThisPtr);

		// Token: 0x060009EB RID: 2539 RVA: 0x0000CCF0 File Offset: 0x0000BCF0
		~PursuitEntrantLivePacket()
		{
			PursuitEntrantLivePacket._EASharpBinding_1002(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060009EC RID: 2540
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1003(void* self, int val);

		// Token: 0x060009ED RID: 2541
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1004(void* self);

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060009EE RID: 2542 RVA: 0x0000CD2C File Offset: 0x0000BD2C
		// (set) Token: 0x060009EF RID: 2543 RVA: 0x0000CD39 File Offset: 0x0000BD39
		public int CopsDisabled
		{
			get
			{
				return PursuitEntrantLivePacket._EASharpBinding_1004(this.mSelf);
			}
			set
			{
				PursuitEntrantLivePacket._EASharpBinding_1003(this.mSelf, value);
			}
		}

		// Token: 0x060009F0 RID: 2544
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1005(void* self, int val);

		// Token: 0x060009F1 RID: 2545
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1006(void* self);

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060009F2 RID: 2546 RVA: 0x0000CD47 File Offset: 0x0000BD47
		// (set) Token: 0x060009F3 RID: 2547 RVA: 0x0000CD54 File Offset: 0x0000BD54
		public int RhinosDisabled
		{
			get
			{
				return PursuitEntrantLivePacket._EASharpBinding_1006(this.mSelf);
			}
			set
			{
				PursuitEntrantLivePacket._EASharpBinding_1005(this.mSelf, value);
			}
		}
	}
}

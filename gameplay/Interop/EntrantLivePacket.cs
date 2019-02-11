using System;
using System.Runtime.InteropServices;
using EASharp;
using Victory.DataLayer.Serialization.Event;

namespace Interop
{
	// Token: 0x020000AA RID: 170
	[ExportOnlyCreate(true)]
	public class EntrantLivePacket : FEPlayerPersona
	{
		// Token: 0x060009A6 RID: 2470 RVA: 0x0000C8EC File Offset: 0x0000B8EC
		public new unsafe static EntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new EntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060009A7 RID: 2471 RVA: 0x0000C90F File Offset: 0x0000B90F
		public unsafe EntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009A8 RID: 2472 RVA: 0x0000C919 File Offset: 0x0000B919
		protected internal EntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060009A9 RID: 2473 RVA: 0x0000C922 File Offset: 0x0000B922
		protected internal unsafe EntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060009AA RID: 2474
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_978();

		// Token: 0x060009AB RID: 2475 RVA: 0x0000C92C File Offset: 0x0000B92C
		public EntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = EntrantLivePacket._EASharpBinding_978();
		}

		// Token: 0x060009AC RID: 2476
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_979(void* _ThisPtr);

		// Token: 0x060009AD RID: 2477 RVA: 0x0000C954 File Offset: 0x0000B954
		~EntrantLivePacket()
		{
			EntrantLivePacket._EASharpBinding_979(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060009AE RID: 2478
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_980(void* self, int val);

		// Token: 0x060009AF RID: 2479
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_981(void* self);

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060009B0 RID: 2480 RVA: 0x0000C990 File Offset: 0x0000B990
		// (set) Token: 0x060009B1 RID: 2481 RVA: 0x0000C99D File Offset: 0x0000B99D
		public int Rank
		{
			get
			{
				return EntrantLivePacket._EASharpBinding_981(this.mSelf);
			}
			set
			{
				EntrantLivePacket._EASharpBinding_980(this.mSelf, value);
			}
		}

		// Token: 0x060009B2 RID: 2482
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_982(void* self, int val);

		// Token: 0x060009B3 RID: 2483
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_983(void* self);

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060009B4 RID: 2484 RVA: 0x0000C9AB File Offset: 0x0000B9AB
		// (set) Token: 0x060009B5 RID: 2485 RVA: 0x0000C9B8 File Offset: 0x0000B9B8
		public FinishReason FinishReason
		{
			get
			{
				return (FinishReason)EntrantLivePacket._EASharpBinding_983(this.mSelf);
			}
			set
			{
				EntrantLivePacket._EASharpBinding_982(this.mSelf, (int)value);
			}
		}
	}
}

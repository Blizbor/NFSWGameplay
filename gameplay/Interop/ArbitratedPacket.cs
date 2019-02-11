using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000CF RID: 207
	[ExportOnlyCreate(true)]
	public class ArbitratedPacket : ISerializable
	{
		// Token: 0x06000CA0 RID: 3232 RVA: 0x0000F8EC File Offset: 0x0000E8EC
		public new unsafe static ArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0000F90F File Offset: 0x0000E90F
		public unsafe ArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0000F919 File Offset: 0x0000E919
		protected internal ArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0000F922 File Offset: 0x0000E922
		protected internal unsafe ArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000CA4 RID: 3236
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1285();

		// Token: 0x06000CA5 RID: 3237 RVA: 0x0000F92C File Offset: 0x0000E92C
		public ArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = ArbitratedPacket._EASharpBinding_1285();
		}

		// Token: 0x06000CA6 RID: 3238
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1286(void* _ThisPtr);

		// Token: 0x06000CA7 RID: 3239 RVA: 0x0000F954 File Offset: 0x0000E954
		~ArbitratedPacket()
		{
			ArbitratedPacket._EASharpBinding_1286(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000CA8 RID: 3240
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1287(void* _ThisPtr);

		// Token: 0x06000CA9 RID: 3241 RVA: 0x0000F990 File Offset: 0x0000E990
		public virtual void Reset()
		{
			ArbitratedPacket._EASharpBinding_1287(this.mSelf);
		}

		// Token: 0x06000CAA RID: 3242
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1288(void* _ThisPtr);

		// Token: 0x06000CAB RID: 3243 RVA: 0x0000F9A0 File Offset: 0x0000E9A0
		public TimeSpan GetEventTimeout()
		{
			return TimeSpan.CreateInitUnowned(ArbitratedPacket._EASharpBinding_1288(this.mSelf));
		}

		// Token: 0x06000CAC RID: 3244
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1289(void* self, bool val);

		// Token: 0x06000CAD RID: 3245
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1290(void* self);

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000CAE RID: 3246 RVA: 0x0000F9BF File Offset: 0x0000E9BF
		// (set) Token: 0x06000CAF RID: 3247 RVA: 0x0000F9CC File Offset: 0x0000E9CC
		public bool HasArbitrated
		{
			get
			{
				return ArbitratedPacket._EASharpBinding_1290(this.mSelf);
			}
			set
			{
				ArbitratedPacket._EASharpBinding_1289(this.mSelf, value);
			}
		}
	}
}

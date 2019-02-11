using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000CC RID: 204
	[ExportOnlyCreate(true)]
	public class TimingOutPacket : ISerializable
	{
		// Token: 0x06000C5E RID: 3166 RVA: 0x0000F508 File Offset: 0x0000E508
		public new unsafe static TimingOutPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TimingOutPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000C5F RID: 3167 RVA: 0x0000F52B File Offset: 0x0000E52B
		public unsafe TimingOutPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C60 RID: 3168 RVA: 0x0000F535 File Offset: 0x0000E535
		protected internal TimingOutPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000C61 RID: 3169 RVA: 0x0000F53E File Offset: 0x0000E53E
		protected internal unsafe TimingOutPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C62 RID: 3170
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1258();

		// Token: 0x06000C63 RID: 3171 RVA: 0x0000F548 File Offset: 0x0000E548
		public TimingOutPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TimingOutPacket._EASharpBinding_1258();
		}

		// Token: 0x06000C64 RID: 3172
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1259(void* _ThisPtr);

		// Token: 0x06000C65 RID: 3173 RVA: 0x0000F570 File Offset: 0x0000E570
		~TimingOutPacket()
		{
			TimingOutPacket._EASharpBinding_1259(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000C66 RID: 3174
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1260(void* _ThisPtr);

		// Token: 0x06000C67 RID: 3175 RVA: 0x0000F5AC File Offset: 0x0000E5AC
		public TimeSpan GetTimeLeft()
		{
			return TimeSpan.CreateInitUnowned(TimingOutPacket._EASharpBinding_1260(this.mSelf));
		}
	}
}

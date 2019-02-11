using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore;

namespace Interop
{
	// Token: 0x020000B0 RID: 176
	[ExportOnlyCreate(true)]
	public class TeamEscapeEntrantLivePacket : EntrantLivePacket
	{
		// Token: 0x06000A00 RID: 2560 RVA: 0x0000CE38 File Offset: 0x0000BE38
		public new unsafe static TeamEscapeEntrantLivePacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TeamEscapeEntrantLivePacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A01 RID: 2561 RVA: 0x0000CE5B File Offset: 0x0000BE5B
		public unsafe TeamEscapeEntrantLivePacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A02 RID: 2562 RVA: 0x0000CE65 File Offset: 0x0000BE65
		protected internal TeamEscapeEntrantLivePacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A03 RID: 2563 RVA: 0x0000CE6E File Offset: 0x0000BE6E
		protected internal unsafe TeamEscapeEntrantLivePacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A04 RID: 2564
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1011();

		// Token: 0x06000A05 RID: 2565 RVA: 0x0000CE78 File Offset: 0x0000BE78
		public TeamEscapeEntrantLivePacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TeamEscapeEntrantLivePacket._EASharpBinding_1011();
		}

		// Token: 0x06000A06 RID: 2566
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1012(void* _ThisPtr);

		// Token: 0x06000A07 RID: 2567 RVA: 0x0000CEA0 File Offset: 0x0000BEA0
		~TeamEscapeEntrantLivePacket()
		{
			TeamEscapeEntrantLivePacket._EASharpBinding_1012(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A08 RID: 2568
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1013(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A09 RID: 2569 RVA: 0x0000CEDC File Offset: 0x0000BEDC
		public unsafe void SetDistanceToFinishString(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				TeamEscapeEntrantLivePacket._EASharpBinding_1013(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A0A RID: 2570
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1014(void* self, float val);

		// Token: 0x06000A0B RID: 2571
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1015(void* self);

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x06000A0C RID: 2572 RVA: 0x0000CF39 File Offset: 0x0000BF39
		// (set) Token: 0x06000A0D RID: 2573 RVA: 0x0000CF46 File Offset: 0x0000BF46
		public float DistanceToFinish
		{
			get
			{
				return TeamEscapeEntrantLivePacket._EASharpBinding_1015(this.mSelf);
			}
			set
			{
				TeamEscapeEntrantLivePacket._EASharpBinding_1014(this.mSelf, value);
			}
		}

		// Token: 0x06000A0E RID: 2574
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1016(void* self, int val);

		// Token: 0x06000A0F RID: 2575
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1017(void* self);

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000A10 RID: 2576 RVA: 0x0000CF54 File Offset: 0x0000BF54
		// (set) Token: 0x06000A11 RID: 2577 RVA: 0x0000CF61 File Offset: 0x0000BF61
		public EntrantHighlight Highlight
		{
			get
			{
				return (EntrantHighlight)TeamEscapeEntrantLivePacket._EASharpBinding_1017(this.mSelf);
			}
			set
			{
				TeamEscapeEntrantLivePacket._EASharpBinding_1016(this.mSelf, (int)value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore;
using Victory.Service;

namespace Interop
{
	// Token: 0x020000BC RID: 188
	[ExportOnlyCreate(true)]
	public class EntrantLobbyPacket : FEPlayerPersona
	{
		// Token: 0x06000B0E RID: 2830 RVA: 0x0000E034 File Offset: 0x0000D034
		public new unsafe static EntrantLobbyPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new EntrantLobbyPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B0F RID: 2831 RVA: 0x0000E057 File Offset: 0x0000D057
		public unsafe EntrantLobbyPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B10 RID: 2832 RVA: 0x0000E061 File Offset: 0x0000D061
		protected internal EntrantLobbyPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B11 RID: 2833 RVA: 0x0000E06A File Offset: 0x0000D06A
		protected internal unsafe EntrantLobbyPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B12 RID: 2834
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1122();

		// Token: 0x06000B13 RID: 2835 RVA: 0x0000E074 File Offset: 0x0000D074
		public EntrantLobbyPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = EntrantLobbyPacket._EASharpBinding_1122();
		}

		// Token: 0x06000B14 RID: 2836
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1123(void* _ThisPtr);

		// Token: 0x06000B15 RID: 2837 RVA: 0x0000E09C File Offset: 0x0000D09C
		~EntrantLobbyPacket()
		{
			EntrantLobbyPacket._EASharpBinding_1123(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B16 RID: 2838
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1124(void* self, int val);

		// Token: 0x06000B17 RID: 2839
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1125(void* self);

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x06000B18 RID: 2840 RVA: 0x0000E0D8 File Offset: 0x0000D0D8
		// (set) Token: 0x06000B19 RID: 2841 RVA: 0x0000E0E5 File Offset: 0x0000D0E5
		public TransmissionMode TransmissionMode
		{
			get
			{
				return (TransmissionMode)EntrantLobbyPacket._EASharpBinding_1125(this.mSelf);
			}
			set
			{
				EntrantLobbyPacket._EASharpBinding_1124(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000B1A RID: 2842
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1126(void* self, int val);

		// Token: 0x06000B1B RID: 2843
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1127(void* self);

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x06000B1C RID: 2844 RVA: 0x0000E0F3 File Offset: 0x0000D0F3
		// (set) Token: 0x06000B1D RID: 2845 RVA: 0x0000E100 File Offset: 0x0000D100
		public LobbyEntrantState State
		{
			get
			{
				return (LobbyEntrantState)EntrantLobbyPacket._EASharpBinding_1127(this.mSelf);
			}
			set
			{
				EntrantLobbyPacket._EASharpBinding_1126(this.mSelf, (int)value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000BD RID: 189
	[ExportOnlyCreate(true)]
	public class LobbyPacket : ISerializable
	{
		// Token: 0x06000B1E RID: 2846 RVA: 0x0000E110 File Offset: 0x0000D110
		public new unsafe static LobbyPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LobbyPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000B1F RID: 2847 RVA: 0x0000E133 File Offset: 0x0000D133
		public unsafe LobbyPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B20 RID: 2848 RVA: 0x0000E13D File Offset: 0x0000D13D
		protected internal LobbyPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000B21 RID: 2849 RVA: 0x0000E146 File Offset: 0x0000D146
		protected internal unsafe LobbyPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000B22 RID: 2850
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1128();

		// Token: 0x06000B23 RID: 2851 RVA: 0x0000E150 File Offset: 0x0000D150
		public LobbyPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = LobbyPacket._EASharpBinding_1128();
		}

		// Token: 0x06000B24 RID: 2852
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1129(void* _ThisPtr);

		// Token: 0x06000B25 RID: 2853 RVA: 0x0000E178 File Offset: 0x0000D178
		~LobbyPacket()
		{
			LobbyPacket._EASharpBinding_1129(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B26 RID: 2854
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1130(void* _ThisPtr);

		// Token: 0x06000B27 RID: 2855 RVA: 0x0000E1B4 File Offset: 0x0000D1B4
		public virtual void Reset()
		{
			LobbyPacket._EASharpBinding_1130(this.mSelf);
		}

		// Token: 0x06000B28 RID: 2856
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1131(void* _ThisPtr);

		// Token: 0x06000B29 RID: 2857 RVA: 0x0000E1C4 File Offset: 0x0000D1C4
		public EntrantLobbyPacket CreateEntrantLobbyPacket()
		{
			return EntrantLobbyPacket.CreateInitUnowned(LobbyPacket._EASharpBinding_1131(this.mSelf));
		}

		// Token: 0x06000B2A RID: 2858
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1132(void* self, uint val);

		// Token: 0x06000B2B RID: 2859
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1133(void* self);

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0000E1E3 File Offset: 0x0000D1E3
		// (set) Token: 0x06000B2D RID: 2861 RVA: 0x0000E1F0 File Offset: 0x0000D1F0
		public uint NumEntrants
		{
			get
			{
				return LobbyPacket._EASharpBinding_1133(this.mSelf);
			}
			set
			{
				LobbyPacket._EASharpBinding_1132(this.mSelf, value);
			}
		}

		// Token: 0x06000B2E RID: 2862
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1134(void* self, uint val);

		// Token: 0x06000B2F RID: 2863
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1135(void* self);

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x06000B30 RID: 2864 RVA: 0x0000E1FE File Offset: 0x0000D1FE
		// (set) Token: 0x06000B31 RID: 2865 RVA: 0x0000E20B File Offset: 0x0000D20B
		public uint MaxNumEntrants
		{
			get
			{
				return LobbyPacket._EASharpBinding_1135(this.mSelf);
			}
			set
			{
				LobbyPacket._EASharpBinding_1134(this.mSelf, value);
			}
		}

		// Token: 0x06000B32 RID: 2866
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1136(void* self, bool val);

		// Token: 0x06000B33 RID: 2867
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1137(void* self);

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x0000E219 File Offset: 0x0000D219
		// (set) Token: 0x06000B35 RID: 2869 RVA: 0x0000E226 File Offset: 0x0000D226
		public bool LeaveEnabled
		{
			get
			{
				return LobbyPacket._EASharpBinding_1137(this.mSelf);
			}
			set
			{
				LobbyPacket._EASharpBinding_1136(this.mSelf, value);
			}
		}

		// Token: 0x06000B36 RID: 2870
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1138(void* self, bool val);

		// Token: 0x06000B37 RID: 2871
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1139(void* self);

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x06000B38 RID: 2872 RVA: 0x0000E234 File Offset: 0x0000D234
		// (set) Token: 0x06000B39 RID: 2873 RVA: 0x0000E241 File Offset: 0x0000D241
		public bool LobbyWaiting
		{
			get
			{
				return LobbyPacket._EASharpBinding_1139(this.mSelf);
			}
			set
			{
				LobbyPacket._EASharpBinding_1138(this.mSelf, value);
			}
		}
	}
}

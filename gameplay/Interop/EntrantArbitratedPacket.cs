using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;
using GameCore;
using Victory.DataLayer.Serialization.Event;

namespace Interop
{
	// Token: 0x020000CE RID: 206
	[ExportOnlyCreate(true)]
	public class EntrantArbitratedPacket : FEPlayerPersona
	{
		// Token: 0x06000C7A RID: 3194 RVA: 0x0000F704 File Offset: 0x0000E704
		public new unsafe static EntrantArbitratedPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new EntrantArbitratedPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000C7B RID: 3195 RVA: 0x0000F727 File Offset: 0x0000E727
		public unsafe EntrantArbitratedPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C7C RID: 3196 RVA: 0x0000F731 File Offset: 0x0000E731
		protected internal EntrantArbitratedPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000C7D RID: 3197 RVA: 0x0000F73A File Offset: 0x0000E73A
		protected internal unsafe EntrantArbitratedPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C7E RID: 3198
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1268();

		// Token: 0x06000C7F RID: 3199 RVA: 0x0000F744 File Offset: 0x0000E744
		public EntrantArbitratedPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = EntrantArbitratedPacket._EASharpBinding_1268();
		}

		// Token: 0x06000C80 RID: 3200
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1269(void* _ThisPtr);

		// Token: 0x06000C81 RID: 3201 RVA: 0x0000F76C File Offset: 0x0000E76C
		~EntrantArbitratedPacket()
		{
			EntrantArbitratedPacket._EASharpBinding_1269(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000C82 RID: 3202
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1270(void* _ThisPtr, sbyte* value);

		// Token: 0x06000C83 RID: 3203 RVA: 0x0000F7A8 File Offset: 0x0000E7A8
		public unsafe void SetMotto(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				EntrantArbitratedPacket._EASharpBinding_1270(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000C84 RID: 3204
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1271(void* _ThisPtr);

		// Token: 0x06000C85 RID: 3205 RVA: 0x0000F808 File Offset: 0x0000E808
		public PowerupUsage CreatePowerup()
		{
			return PowerupUsage.CreateInitUnowned(EntrantArbitratedPacket._EASharpBinding_1271(this.mSelf));
		}

		// Token: 0x06000C86 RID: 3206
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1272(void* _ThisPtr);

		// Token: 0x06000C87 RID: 3207 RVA: 0x0000F828 File Offset: 0x0000E828
		public FECarData GetCarData()
		{
			return FECarData.CreateInitUnowned(EntrantArbitratedPacket._EASharpBinding_1272(this.mSelf));
		}

		// Token: 0x06000C88 RID: 3208
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1273(void* self, int val);

		// Token: 0x06000C89 RID: 3209
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1274(void* self);

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x0000F847 File Offset: 0x0000E847
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x0000F854 File Offset: 0x0000E854
		public TransmissionMode TransmissionMode
		{
			get
			{
				return (TransmissionMode)EntrantArbitratedPacket._EASharpBinding_1274(this.mSelf);
			}
			set
			{
				EntrantArbitratedPacket._EASharpBinding_1273(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000C8C RID: 3212
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1275(void* self, int val);

		// Token: 0x06000C8D RID: 3213
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1276(void* self);

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x0000F862 File Offset: 0x0000E862
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x0000F86F File Offset: 0x0000E86F
		public int Rank
		{
			get
			{
				return EntrantArbitratedPacket._EASharpBinding_1276(this.mSelf);
			}
			set
			{
				EntrantArbitratedPacket._EASharpBinding_1275(this.mSelf, value);
			}
		}

		// Token: 0x06000C90 RID: 3216
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1277(void* self, int val);

		// Token: 0x06000C91 RID: 3217
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1278(void* self);

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000C92 RID: 3218 RVA: 0x0000F87D File Offset: 0x0000E87D
		// (set) Token: 0x06000C93 RID: 3219 RVA: 0x0000F88A File Offset: 0x0000E88A
		public FinishReason FinishReason
		{
			get
			{
				return (FinishReason)EntrantArbitratedPacket._EASharpBinding_1278(this.mSelf);
			}
			set
			{
				EntrantArbitratedPacket._EASharpBinding_1277(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000C94 RID: 3220
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1279(void* self, float val);

		// Token: 0x06000C95 RID: 3221
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1280(void* self);

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000C96 RID: 3222 RVA: 0x0000F898 File Offset: 0x0000E898
		// (set) Token: 0x06000C97 RID: 3223 RVA: 0x0000F8A5 File Offset: 0x0000E8A5
		public float EventDuration
		{
			get
			{
				return EntrantArbitratedPacket._EASharpBinding_1280(this.mSelf);
			}
			set
			{
				EntrantArbitratedPacket._EASharpBinding_1279(this.mSelf, value);
			}
		}

		// Token: 0x06000C98 RID: 3224
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1281(void* self, float val);

		// Token: 0x06000C99 RID: 3225
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1282(void* self);

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0000F8B3 File Offset: 0x0000E8B3
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0000F8C0 File Offset: 0x0000E8C0
		public float TimeDiff
		{
			get
			{
				return EntrantArbitratedPacket._EASharpBinding_1282(this.mSelf);
			}
			set
			{
				EntrantArbitratedPacket._EASharpBinding_1281(this.mSelf, value);
			}
		}

		// Token: 0x06000C9C RID: 3228
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1283(void* self, bool val);

		// Token: 0x06000C9D RID: 3229
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1284(void* self);

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0000F8CE File Offset: 0x0000E8CE
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0000F8DB File Offset: 0x0000E8DB
		public bool HasArbitrated
		{
			get
			{
				return EntrantArbitratedPacket._EASharpBinding_1284(this.mSelf);
			}
			set
			{
				EntrantArbitratedPacket._EASharpBinding_1283(this.mSelf, value);
			}
		}
	}
}

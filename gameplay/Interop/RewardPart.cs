using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000C7 RID: 199
	[ExportOnlyCreate(true)]
	public class RewardPart : ExposedCommonBase
	{
		// Token: 0x06000BD4 RID: 3028 RVA: 0x0000EC18 File Offset: 0x0000DC18
		public unsafe static RewardPart CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new RewardPart(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000BD5 RID: 3029 RVA: 0x0000EC3B File Offset: 0x0000DC3B
		public unsafe RewardPart(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BD6 RID: 3030 RVA: 0x0000EC45 File Offset: 0x0000DC45
		protected internal RewardPart(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000BD7 RID: 3031 RVA: 0x0000EC4E File Offset: 0x0000DC4E
		protected internal unsafe RewardPart(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BD8 RID: 3032
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1199();

		// Token: 0x06000BD9 RID: 3033 RVA: 0x0000EC58 File Offset: 0x0000DC58
		public RewardPart() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = RewardPart._EASharpBinding_1199();
		}

		// Token: 0x06000BDA RID: 3034
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1200(void* _ThisPtr);

		// Token: 0x06000BDB RID: 3035 RVA: 0x0000EC80 File Offset: 0x0000DC80
		~RewardPart()
		{
			RewardPart._EASharpBinding_1200(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000BDC RID: 3036
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1201(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BDD RID: 3037 RVA: 0x0000ECBC File Offset: 0x0000DCBC
		public unsafe void SetName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				RewardPart._EASharpBinding_1201(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BDE RID: 3038
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1202(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BDF RID: 3039 RVA: 0x0000ED1C File Offset: 0x0000DD1C
		public unsafe void SetType(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				RewardPart._EASharpBinding_1202(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BE0 RID: 3040
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1203(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BE1 RID: 3041 RVA: 0x0000ED7C File Offset: 0x0000DD7C
		public unsafe void SetCategory(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				RewardPart._EASharpBinding_1203(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BE2 RID: 3042
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1204(void* self, int val);

		// Token: 0x06000BE3 RID: 3043
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1205(void* self);

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000BE4 RID: 3044 RVA: 0x0000EDD9 File Offset: 0x0000DDD9
		// (set) Token: 0x06000BE5 RID: 3045 RVA: 0x0000EDE6 File Offset: 0x0000DDE6
		public int Value
		{
			get
			{
				return RewardPart._EASharpBinding_1205(this.mSelf);
			}
			set
			{
				RewardPart._EASharpBinding_1204(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000C4 RID: 196
	[ExportOnlyCreate(true)]
	public class Filter : ISerializable
	{
		// Token: 0x06000BB0 RID: 2992 RVA: 0x0000E978 File Offset: 0x0000D978
		public new unsafe static Filter CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Filter(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000BB1 RID: 2993 RVA: 0x0000E99B File Offset: 0x0000D99B
		public unsafe Filter(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BB2 RID: 2994 RVA: 0x0000E9A5 File Offset: 0x0000D9A5
		protected internal Filter(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000BB3 RID: 2995 RVA: 0x0000E9AE File Offset: 0x0000D9AE
		protected internal unsafe Filter(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000BB4 RID: 2996
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1187();

		// Token: 0x06000BB5 RID: 2997 RVA: 0x0000E9B8 File Offset: 0x0000D9B8
		public Filter() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Filter._EASharpBinding_1187();
		}

		// Token: 0x06000BB6 RID: 2998
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1188(void* _ThisPtr);

		// Token: 0x06000BB7 RID: 2999 RVA: 0x0000E9E0 File Offset: 0x0000D9E0
		~Filter()
		{
			Filter._EASharpBinding_1188(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000BB8 RID: 3000
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1189(void* _ThisPtr, sbyte* value);

		// Token: 0x06000BB9 RID: 3001 RVA: 0x0000EA1C File Offset: 0x0000DA1C
		public unsafe void SetText(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				Filter._EASharpBinding_1189(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000BBA RID: 3002
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1190(void* self, uint val);

		// Token: 0x06000BBB RID: 3003
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1191(void* self);

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000BBC RID: 3004 RVA: 0x0000EA79 File Offset: 0x0000DA79
		// (set) Token: 0x06000BBD RID: 3005 RVA: 0x0000EA86 File Offset: 0x0000DA86
		public uint Hash
		{
			get
			{
				return Filter._EASharpBinding_1191(this.mSelf);
			}
			set
			{
				Filter._EASharpBinding_1190(this.mSelf, value);
			}
		}
	}
}

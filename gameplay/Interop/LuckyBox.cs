using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000C9 RID: 201
	[ExportOnlyCreate(true)]
	public class LuckyBox : ISerializable
	{
		// Token: 0x06000C0A RID: 3082 RVA: 0x0000F09C File Offset: 0x0000E09C
		public new unsafe static LuckyBox CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LuckyBox(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000C0B RID: 3083 RVA: 0x0000F0BF File Offset: 0x0000E0BF
		public unsafe LuckyBox(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C0C RID: 3084 RVA: 0x0000F0C9 File Offset: 0x0000E0C9
		protected internal LuckyBox(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000C0D RID: 3085 RVA: 0x0000F0D2 File Offset: 0x0000E0D2
		protected internal unsafe LuckyBox(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000C0E RID: 3086
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1222();

		// Token: 0x06000C0F RID: 3087 RVA: 0x0000F0DC File Offset: 0x0000E0DC
		public LuckyBox() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = LuckyBox._EASharpBinding_1222();
		}

		// Token: 0x06000C10 RID: 3088
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1223(void* _ThisPtr);

		// Token: 0x06000C11 RID: 3089 RVA: 0x0000F104 File Offset: 0x0000E104
		~LuckyBox()
		{
			LuckyBox._EASharpBinding_1223(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000C12 RID: 3090
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1224(void* _ThisPtr, sbyte* value);

		// Token: 0x06000C13 RID: 3091 RVA: 0x0000F140 File Offset: 0x0000E140
		public unsafe void SetCategoryName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				LuckyBox._EASharpBinding_1224(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000C14 RID: 3092
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1225(void* self, int val);

		// Token: 0x06000C15 RID: 3093
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1226(void* self);

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000C16 RID: 3094 RVA: 0x0000F19D File Offset: 0x0000E19D
		// (set) Token: 0x06000C17 RID: 3095 RVA: 0x0000F1AA File Offset: 0x0000E1AA
		public LuckyBoxCategory CategoryId
		{
			get
			{
				return (LuckyBoxCategory)LuckyBox._EASharpBinding_1226(this.mSelf);
			}
			set
			{
				LuckyBox._EASharpBinding_1225(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000C18 RID: 3096
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1227(void* self, bool val);

		// Token: 0x06000C19 RID: 3097
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1228(void* self);

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000C1A RID: 3098 RVA: 0x0000F1B8 File Offset: 0x0000E1B8
		// (set) Token: 0x06000C1B RID: 3099 RVA: 0x0000F1C5 File Offset: 0x0000E1C5
		public bool IsValid
		{
			get
			{
				return LuckyBox._EASharpBinding_1228(this.mSelf);
			}
			set
			{
				LuckyBox._EASharpBinding_1227(this.mSelf, value);
			}
		}
	}
}

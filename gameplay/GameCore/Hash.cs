using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000034 RID: 52
	[ExportOnlyCreate(false)]
	public class Hash : ExposedCommonBase
	{
		// Token: 0x06000150 RID: 336 RVA: 0x000036B4 File Offset: 0x000026B4
		public unsafe static Hash CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Hash(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000036D7 File Offset: 0x000026D7
		public unsafe Hash(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000152 RID: 338 RVA: 0x000036E1 File Offset: 0x000026E1
		protected internal Hash(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000153 RID: 339 RVA: 0x000036EA File Offset: 0x000026EA
		protected internal unsafe Hash(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000154 RID: 340
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_93(void* self);

		// Token: 0x06000155 RID: 341 RVA: 0x000036F4 File Offset: 0x000026F4
		[DisableExceptionHandling]
		~Hash()
		{
			Hash._EASharpBinding_93(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000156 RID: 342
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_94(sbyte* text);

		// Token: 0x06000157 RID: 343 RVA: 0x00003730 File Offset: 0x00002730
		public unsafe static uint Hash32(string text)
		{
			int byteCount = Encoding.ASCII.GetByteCount(text);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(text, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return Hash._EASharpBinding_94((sbyte*)ptr);
			}
		}
	}
}

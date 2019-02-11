using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200004F RID: 79
	[ExportOnlyCreate(false)]
	public class InternalProfile : ExposedCommonBase
	{
		// Token: 0x06000380 RID: 896 RVA: 0x00005778 File Offset: 0x00004778
		public unsafe static InternalProfile CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalProfile(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000579B File Offset: 0x0000479B
		public unsafe InternalProfile(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000382 RID: 898 RVA: 0x000057A5 File Offset: 0x000047A5
		protected internal InternalProfile(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000057AE File Offset: 0x000047AE
		protected internal unsafe InternalProfile(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000384 RID: 900
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_357(void* self);

		// Token: 0x06000385 RID: 901 RVA: 0x000057B8 File Offset: 0x000047B8
		[DisableExceptionHandling]
		~InternalProfile()
		{
			InternalProfile._EASharpBinding_357(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000386 RID: 902
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_358(sbyte* name);

		// Token: 0x06000387 RID: 903 RVA: 0x000057F4 File Offset: 0x000047F4
		public unsafe InternalProfile(string name) : base(default(ExposeTag_NoInitOwned))
		{
			int byteCount = Encoding.ASCII.GetByteCount(name);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(name, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				this.mSelf = InternalProfile._EASharpBinding_358((sbyte*)ptr);
			}
		}

		// Token: 0x06000388 RID: 904
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_359(void* _ThisPtr);

		// Token: 0x06000389 RID: 905 RVA: 0x00005863 File Offset: 0x00004863
		public void End()
		{
			InternalProfile._EASharpBinding_359(this.mSelf);
		}
	}
}

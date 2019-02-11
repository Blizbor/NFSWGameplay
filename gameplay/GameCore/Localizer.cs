using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x0200004B RID: 75
	[ExportOnlyCreate(false)]
	public class Localizer : ExposedCommonBase
	{
		// Token: 0x06000354 RID: 852 RVA: 0x0000546C File Offset: 0x0000446C
		public unsafe static Localizer CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Localizer(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000548F File Offset: 0x0000448F
		public unsafe Localizer(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00005499 File Offset: 0x00004499
		protected internal Localizer(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000357 RID: 855 RVA: 0x000054A2 File Offset: 0x000044A2
		protected internal unsafe Localizer(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000358 RID: 856
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_343(void* self);

		// Token: 0x06000359 RID: 857 RVA: 0x000054AC File Offset: 0x000044AC
		[DisableExceptionHandling]
		~Localizer()
		{
			Localizer._EASharpBinding_343(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600035A RID: 858
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_344(sbyte* hal_id);

		// Token: 0x0600035B RID: 859 RVA: 0x000054E8 File Offset: 0x000044E8
		public unsafe static string GetLocalizedString(string hal_id)
		{
			int byteCount = Encoding.ASCII.GetByteCount(hal_id);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(hal_id, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return InternalUtil.ConvertFromCString(Localizer._EASharpBinding_344((sbyte*)ptr));
			}
		}

		// Token: 0x0600035C RID: 860
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_345(uint hash);

		// Token: 0x0600035D RID: 861 RVA: 0x0000554C File Offset: 0x0000454C
		public static string GetLocalizedString(uint hash)
		{
			return InternalUtil.ConvertFromCString(Localizer._EASharpBinding_345(hash));
		}
	}
}

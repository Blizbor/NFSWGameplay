using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000031 RID: 49
	[ExportOnlyCreate(false)]
	public class Grid : ExposedCommonBase
	{
		// Token: 0x06000130 RID: 304 RVA: 0x000034A8 File Offset: 0x000024A8
		public unsafe static Grid CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Grid(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000131 RID: 305 RVA: 0x000034CB File Offset: 0x000024CB
		public unsafe Grid(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x000034D5 File Offset: 0x000024D5
		protected internal Grid(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000034DE File Offset: 0x000024DE
		protected internal unsafe Grid(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000134 RID: 308
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_83(void* self);

		// Token: 0x06000135 RID: 309 RVA: 0x000034E8 File Offset: 0x000024E8
		[DisableExceptionHandling]
		~Grid()
		{
			Grid._EASharpBinding_83(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000136 RID: 310
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_84(uint collectionKey);

		// Token: 0x06000137 RID: 311 RVA: 0x00003524 File Offset: 0x00002524
		public Grid(uint collectionKey) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Grid._EASharpBinding_84(collectionKey);
		}

		// Token: 0x06000138 RID: 312
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_85(void* _ThisPtr, int index, void* location);

		// Token: 0x06000139 RID: 313 RVA: 0x0000354C File Offset: 0x0000254C
		public void GetLocation(int index, Location location)
		{
			Grid._EASharpBinding_85(this.mSelf, index, object.ReferenceEquals(location, null) ? null : location._GetRaw());
		}
	}
}

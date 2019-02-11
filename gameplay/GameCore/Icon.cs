using System;
using System.Runtime.InteropServices;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000036 RID: 54
	[ExportOnlyCreate(false)]
	public class Icon : ExposedCommonBase
	{
		// Token: 0x06000178 RID: 376 RVA: 0x000039B0 File Offset: 0x000029B0
		public unsafe static Icon CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Icon(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x000039D3 File Offset: 0x000029D3
		public unsafe Icon(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600017A RID: 378 RVA: 0x000039DD File Offset: 0x000029DD
		protected internal Icon(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600017B RID: 379 RVA: 0x000039E6 File Offset: 0x000029E6
		protected internal unsafe Icon(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600017C RID: 380
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_109(void* position, uint type, float rotation);

		// Token: 0x0600017D RID: 381 RVA: 0x000039F0 File Offset: 0x000029F0
		public Icon(Vector3 position, uint type, float rotation) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = Icon._EASharpBinding_109(object.ReferenceEquals(position, null) ? null : position._GetRaw(), type, rotation);
		}

		// Token: 0x0600017E RID: 382
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_110(void* _ThisPtr);

		// Token: 0x0600017F RID: 383 RVA: 0x00003A2C File Offset: 0x00002A2C
		~Icon()
		{
			Icon._EASharpBinding_110(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000180 RID: 384
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_111(void* _ThisPtr);

		// Token: 0x06000181 RID: 385 RVA: 0x00003A68 File Offset: 0x00002A68
		public void Enable()
		{
			Icon._EASharpBinding_111(this.mSelf);
		}

		// Token: 0x06000182 RID: 386
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_112(void* _ThisPtr);

		// Token: 0x06000183 RID: 387 RVA: 0x00003A75 File Offset: 0x00002A75
		public void Disable()
		{
			Icon._EASharpBinding_112(this.mSelf);
		}
	}
}

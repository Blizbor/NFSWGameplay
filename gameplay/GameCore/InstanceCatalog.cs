using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000038 RID: 56
	[ExportOnlyCreate(false)]
	public class InstanceCatalog : ExposedCommonBase
	{
		// Token: 0x0600018E RID: 398 RVA: 0x00003B54 File Offset: 0x00002B54
		public unsafe static InstanceCatalog CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InstanceCatalog(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600018F RID: 399 RVA: 0x00003B77 File Offset: 0x00002B77
		public unsafe InstanceCatalog(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000190 RID: 400 RVA: 0x00003B81 File Offset: 0x00002B81
		protected internal InstanceCatalog(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000191 RID: 401 RVA: 0x00003B8A File Offset: 0x00002B8A
		protected internal unsafe InstanceCatalog(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000192 RID: 402
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_116(void* self);

		// Token: 0x06000193 RID: 403 RVA: 0x00003B94 File Offset: 0x00002B94
		[DisableExceptionHandling]
		~InstanceCatalog()
		{
			InstanceCatalog._EASharpBinding_116(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000194 RID: 404
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_117();

		// Token: 0x06000195 RID: 405 RVA: 0x00003BD0 File Offset: 0x00002BD0
		public static InstanceCatalog Get()
		{
			return InstanceCatalog.CreateInitUnowned(InstanceCatalog._EASharpBinding_117());
		}

		// Token: 0x06000196 RID: 406
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_118(void* _ThisPtr);

		// Token: 0x06000197 RID: 407 RVA: 0x00003BE9 File Offset: 0x00002BE9
		public virtual void ReconnectInstances()
		{
			InstanceCatalog._EASharpBinding_118(this.mSelf);
		}

		// Token: 0x06000198 RID: 408
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_119(void* _ThisPtr, uint key);

		// Token: 0x06000199 RID: 409 RVA: 0x00003BF8 File Offset: 0x00002BF8
		public InternalInstance Find(uint key)
		{
			return InternalInstance.CreateInitUnowned(InstanceCatalog._EASharpBinding_119(this.mSelf, key));
		}
	}
}

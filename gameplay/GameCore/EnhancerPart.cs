using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x0200005B RID: 91
	[ExportOnlyCreate(true)]
	public class EnhancerPart : ExposedCommonBase
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x0000623C File Offset: 0x0000523C
		public unsafe static EnhancerPart CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new EnhancerPart(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000421 RID: 1057 RVA: 0x0000625F File Offset: 0x0000525F
		public unsafe EnhancerPart(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00006269 File Offset: 0x00005269
		protected internal EnhancerPart(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00006272 File Offset: 0x00005272
		protected internal unsafe EnhancerPart(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000424 RID: 1060
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_413(void* self);

		// Token: 0x06000425 RID: 1061 RVA: 0x0000627C File Offset: 0x0000527C
		[DisableExceptionHandling]
		~EnhancerPart()
		{
			EnhancerPart._EASharpBinding_413(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000426 RID: 1062
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_414(void* self, uint val);

		// Token: 0x06000427 RID: 1063
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_415(void* self);

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x000062B8 File Offset: 0x000052B8
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x000062C5 File Offset: 0x000052C5
		public uint Hash
		{
			get
			{
				return EnhancerPart._EASharpBinding_415(this.mSelf);
			}
			set
			{
				EnhancerPart._EASharpBinding_414(this.mSelf, value);
			}
		}
	}
}

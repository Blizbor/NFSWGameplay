using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000042 RID: 66
	[ExportOnlyCreate(false)]
	public class InternalManager : ExposedCommonBase
	{
		// Token: 0x0600028A RID: 650 RVA: 0x0000493C File Offset: 0x0000393C
		public unsafe static InternalManager CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalManager(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600028B RID: 651 RVA: 0x0000495F File Offset: 0x0000395F
		public unsafe InternalManager(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600028C RID: 652 RVA: 0x00004969 File Offset: 0x00003969
		protected internal InternalManager(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600028D RID: 653 RVA: 0x00004972 File Offset: 0x00003972
		protected internal unsafe InternalManager(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600028E RID: 654
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_259(void* owner);

		// Token: 0x0600028F RID: 655 RVA: 0x0000497C File Offset: 0x0000397C
		public unsafe InternalManager(void* owner) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalManager._EASharpBinding_259(owner);
		}

		// Token: 0x06000290 RID: 656
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_260(void* _ThisPtr);

		// Token: 0x06000291 RID: 657 RVA: 0x000049A4 File Offset: 0x000039A4
		~InternalManager()
		{
			InternalManager._EASharpBinding_260(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000292 RID: 658
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_261(void* _ThisPtr);

		// Token: 0x06000293 RID: 659 RVA: 0x000049E0 File Offset: 0x000039E0
		public void Ready()
		{
			InternalManager._EASharpBinding_261(this.mSelf);
		}

		// Token: 0x06000294 RID: 660
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_262(void* _ThisPtr);

		// Token: 0x06000295 RID: 661 RVA: 0x000049ED File Offset: 0x000039ED
		public void Cleanup()
		{
			InternalManager._EASharpBinding_262(this.mSelf);
		}

		// Token: 0x06000296 RID: 662
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_263(void* _ThisPtr);

		// Token: 0x06000297 RID: 663 RVA: 0x000049FC File Offset: 0x000039FC
		public InternalInstancedEvent GetInternalInstancedEvent()
		{
			return InternalInstancedEvent.CreateInitUnowned(InternalManager._EASharpBinding_263(this.mSelf));
		}

		// Token: 0x06000298 RID: 664
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_264(void* _ThisPtr);

		// Token: 0x06000299 RID: 665 RVA: 0x00004A1C File Offset: 0x00003A1C
		public InternalEvent GetInternalEvent()
		{
			return InternalEvent.CreateInitUnowned(InternalManager._EASharpBinding_264(this.mSelf));
		}

		// Token: 0x0600029A RID: 666
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_265(void* _ThisPtr);

		// Token: 0x0600029B RID: 667 RVA: 0x00004A3C File Offset: 0x00003A3C
		public InternalOpponentManager InternalOpponentManager()
		{
			return GameCore.InternalOpponentManager.CreateInitUnowned(InternalManager._EASharpBinding_265(this.mSelf));
		}

		// Token: 0x0600029C RID: 668
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_266(void* _ThisPtr);

		// Token: 0x0600029D RID: 669 RVA: 0x00004A5C File Offset: 0x00003A5C
		public StreamingMonitor StreamingMonitor()
		{
			return GameCore.StreamingMonitor.CreateInitUnowned(InternalManager._EASharpBinding_266(this.mSelf));
		}

		// Token: 0x0600029E RID: 670
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_267(void* _ThisPtr);

		// Token: 0x0600029F RID: 671 RVA: 0x00004A7C File Offset: 0x00003A7C
		public IconManager IconManager()
		{
			return GameCore.IconManager.CreateInitUnowned(InternalManager._EASharpBinding_267(this.mSelf));
		}
	}
}

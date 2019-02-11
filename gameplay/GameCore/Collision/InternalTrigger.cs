using System;
using System.Runtime.InteropServices;
using EASharp;
using UMath;

namespace GameCore.Collision
{
	// Token: 0x0200007B RID: 123
	[ExportOnlyCreate(false)]
	public class InternalTrigger : ExposedCommonBase
	{
		// Token: 0x06000620 RID: 1568 RVA: 0x000087C4 File Offset: 0x000077C4
		public unsafe static InternalTrigger CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalTrigger(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x000087E7 File Offset: 0x000077E7
		public unsafe InternalTrigger(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000622 RID: 1570 RVA: 0x000087F1 File Offset: 0x000077F1
		protected internal InternalTrigger(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x000087FA File Offset: 0x000077FA
		protected internal unsafe InternalTrigger(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000624 RID: 1572
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_616(void* _ThisPtr);

		// Token: 0x06000625 RID: 1573 RVA: 0x00008804 File Offset: 0x00007804
		public void Enable()
		{
			InternalTrigger._EASharpBinding_616(this.mSelf);
		}

		// Token: 0x06000626 RID: 1574
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_617(void* _ThisPtr);

		// Token: 0x06000627 RID: 1575 RVA: 0x00008811 File Offset: 0x00007811
		public void Disable()
		{
			InternalTrigger._EASharpBinding_617(this.mSelf);
		}

		// Token: 0x06000628 RID: 1576
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_618(uint fingerPrint);

		// Token: 0x06000629 RID: 1577 RVA: 0x00008820 File Offset: 0x00007820
		public InternalTrigger(uint fingerPrint) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalTrigger._EASharpBinding_618(fingerPrint);
		}

		// Token: 0x0600062A RID: 1578
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_619(void* _ThisPtr);

		// Token: 0x0600062B RID: 1579 RVA: 0x00008848 File Offset: 0x00007848
		~InternalTrigger()
		{
			InternalTrigger._EASharpBinding_619(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600062C RID: 1580
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_620(void* _ThisPtr, uint trigger, void* position, float radius, float rotation);

		// Token: 0x0600062D RID: 1581 RVA: 0x00008884 File Offset: 0x00007884
		public void ConfigureCylinder(uint trigger, Vector3 position, float radius, float rotation)
		{
			InternalTrigger._EASharpBinding_620(this.mSelf, trigger, object.ReferenceEquals(position, null) ? null : position._GetRaw(), radius, rotation);
		}

		// Token: 0x0600062E RID: 1582
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_621(void* _ThisPtr, uint trigger, void* position, void* dimensions, float rotation);

		// Token: 0x0600062F RID: 1583 RVA: 0x000088A8 File Offset: 0x000078A8
		public void ConfigureBox(uint trigger, Vector3 position, Vector3 dimensions, float rotation)
		{
			InternalTrigger._EASharpBinding_621(this.mSelf, trigger, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(dimensions, null) ? null : dimensions._GetRaw(), rotation);
		}

		// Token: 0x06000630 RID: 1584
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_622(void* _ThisPtr, uint trigger, void* position, float width, float rotation);

		// Token: 0x06000631 RID: 1585 RVA: 0x000088DE File Offset: 0x000078DE
		public void ConfigurePlane(uint trigger, Vector3 position, float width, float rotation)
		{
			InternalTrigger._EASharpBinding_622(this.mSelf, trigger, object.ReferenceEquals(position, null) ? null : position._GetRaw(), width, rotation);
		}
	}
}

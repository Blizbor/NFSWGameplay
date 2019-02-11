using System;
using System.Runtime.InteropServices;
using EASharp;

namespace UMath
{
	// Token: 0x0200007D RID: 125
	[ExportOnlyCreate(true)]
	public class Vector3 : ExposedCommonBase
	{
		// Token: 0x0600063C RID: 1596 RVA: 0x000089DC File Offset: 0x000079DC
		public unsafe static Vector3 CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Vector3(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600063D RID: 1597 RVA: 0x000089FF File Offset: 0x000079FF
		public unsafe Vector3(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600063E RID: 1598 RVA: 0x00008A09 File Offset: 0x00007A09
		protected internal Vector3(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600063F RID: 1599 RVA: 0x00008A12 File Offset: 0x00007A12
		protected internal unsafe Vector3(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000640 RID: 1600
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1480(void* self);

		// Token: 0x06000641 RID: 1601 RVA: 0x00008A1C File Offset: 0x00007A1C
		[DisableExceptionHandling]
		~Vector3()
		{
			Vector3._EASharpBinding_1480(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000642 RID: 1602
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1481(void* self, float val);

		// Token: 0x06000643 RID: 1603
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1482(void* self);

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000644 RID: 1604 RVA: 0x00008A58 File Offset: 0x00007A58
		// (set) Token: 0x06000645 RID: 1605 RVA: 0x00008A65 File Offset: 0x00007A65
		public float x
		{
			get
			{
				return Vector3._EASharpBinding_1482(this.mSelf);
			}
			set
			{
				Vector3._EASharpBinding_1481(this.mSelf, value);
			}
		}

		// Token: 0x06000646 RID: 1606
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1483(void* self, float val);

		// Token: 0x06000647 RID: 1607
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1484(void* self);

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000648 RID: 1608 RVA: 0x00008A73 File Offset: 0x00007A73
		// (set) Token: 0x06000649 RID: 1609 RVA: 0x00008A80 File Offset: 0x00007A80
		public float y
		{
			get
			{
				return Vector3._EASharpBinding_1484(this.mSelf);
			}
			set
			{
				Vector3._EASharpBinding_1483(this.mSelf, value);
			}
		}

		// Token: 0x0600064A RID: 1610
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1485(void* self, float val);

		// Token: 0x0600064B RID: 1611
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_1486(void* self);

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x0600064C RID: 1612 RVA: 0x00008A8E File Offset: 0x00007A8E
		// (set) Token: 0x0600064D RID: 1613 RVA: 0x00008A9B File Offset: 0x00007A9B
		public float z
		{
			get
			{
				return Vector3._EASharpBinding_1486(this.mSelf);
			}
			set
			{
				Vector3._EASharpBinding_1485(this.mSelf, value);
			}
		}

		// Token: 0x0600064E RID: 1614
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1488();

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600064F RID: 1615 RVA: 0x00008AAC File Offset: 0x00007AAC
		public static Vector3 kZero
		{
			get
			{
				return new Vector3(default(ExposeTag_InitUnowned), Vector3._EASharpBinding_1488());
			}
		}
	}
}

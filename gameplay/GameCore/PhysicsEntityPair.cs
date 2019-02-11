using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000075 RID: 117
	[ExportOnlyCreate(true)]
	public class PhysicsEntityPair : ExposedCommonBase
	{
		// Token: 0x060005E0 RID: 1504 RVA: 0x000083F8 File Offset: 0x000073F8
		public unsafe static PhysicsEntityPair CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PhysicsEntityPair(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060005E1 RID: 1505 RVA: 0x0000841B File Offset: 0x0000741B
		public unsafe PhysicsEntityPair(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005E2 RID: 1506 RVA: 0x00008425 File Offset: 0x00007425
		protected internal PhysicsEntityPair(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060005E3 RID: 1507 RVA: 0x0000842E File Offset: 0x0000742E
		protected internal unsafe PhysicsEntityPair(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060005E4 RID: 1508
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_592(void* self);

		// Token: 0x060005E5 RID: 1509 RVA: 0x00008438 File Offset: 0x00007438
		[DisableExceptionHandling]
		~PhysicsEntityPair()
		{
			PhysicsEntityPair._EASharpBinding_592(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060005E6 RID: 1510
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_593(void* self, int val);

		// Token: 0x060005E7 RID: 1511
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_594(void* self);

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060005E8 RID: 1512 RVA: 0x00008474 File Offset: 0x00007474
		// (set) Token: 0x060005E9 RID: 1513 RVA: 0x00008481 File Offset: 0x00007481
		public PhysicsEntity entity1
		{
			get
			{
				return (PhysicsEntity)PhysicsEntityPair._EASharpBinding_594(this.mSelf);
			}
			set
			{
				PhysicsEntityPair._EASharpBinding_593(this.mSelf, (int)value);
			}
		}

		// Token: 0x060005EA RID: 1514
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_595(void* self, int val);

		// Token: 0x060005EB RID: 1515
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_596(void* self);

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060005EC RID: 1516 RVA: 0x0000848F File Offset: 0x0000748F
		// (set) Token: 0x060005ED RID: 1517 RVA: 0x0000849C File Offset: 0x0000749C
		public PhysicsEntity entity2
		{
			get
			{
				return (PhysicsEntity)PhysicsEntityPair._EASharpBinding_596(this.mSelf);
			}
			set
			{
				PhysicsEntityPair._EASharpBinding_595(this.mSelf, (int)value);
			}
		}
	}
}

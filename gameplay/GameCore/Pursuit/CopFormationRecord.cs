using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore.Pursuit
{
	// Token: 0x02000084 RID: 132
	[ExportOnlyCreate(true)]
	public class CopFormationRecord : ExposedCommonBase
	{
		// Token: 0x0600069E RID: 1694 RVA: 0x00009000 File Offset: 0x00008000
		public unsafe static CopFormationRecord CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new CopFormationRecord(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600069F RID: 1695 RVA: 0x00009023 File Offset: 0x00008023
		public unsafe CopFormationRecord(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0000902D File Offset: 0x0000802D
		protected internal CopFormationRecord(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060006A1 RID: 1697 RVA: 0x00009036 File Offset: 0x00008036
		protected internal unsafe CopFormationRecord(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006A2 RID: 1698
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_649(void* self);

		// Token: 0x060006A3 RID: 1699 RVA: 0x00009040 File Offset: 0x00008040
		[DisableExceptionHandling]
		~CopFormationRecord()
		{
			CopFormationRecord._EASharpBinding_649(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060006A4 RID: 1700
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_650(void* self, int val);

		// Token: 0x060006A5 RID: 1701
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_651(void* self);

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060006A6 RID: 1702 RVA: 0x0000907C File Offset: 0x0000807C
		// (set) Token: 0x060006A7 RID: 1703 RVA: 0x00009089 File Offset: 0x00008089
		public FormationType Formation
		{
			get
			{
				return (FormationType)CopFormationRecord._EASharpBinding_651(this.mSelf);
			}
			set
			{
				CopFormationRecord._EASharpBinding_650(this.mSelf, (int)value);
			}
		}

		// Token: 0x060006A8 RID: 1704
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_652(void* self, float val);

		// Token: 0x060006A9 RID: 1705
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_653(void* self);

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060006AA RID: 1706 RVA: 0x00009097 File Offset: 0x00008097
		// (set) Token: 0x060006AB RID: 1707 RVA: 0x000090A4 File Offset: 0x000080A4
		public float Duration
		{
			get
			{
				return CopFormationRecord._EASharpBinding_653(this.mSelf);
			}
			set
			{
				CopFormationRecord._EASharpBinding_652(this.mSelf, value);
			}
		}

		// Token: 0x060006AC RID: 1708
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_654(void* self, float val);

		// Token: 0x060006AD RID: 1709
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_655(void* self);

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060006AE RID: 1710 RVA: 0x000090B2 File Offset: 0x000080B2
		// (set) Token: 0x060006AF RID: 1711 RVA: 0x000090BF File Offset: 0x000080BF
		public float Frequency
		{
			get
			{
				return CopFormationRecord._EASharpBinding_655(this.mSelf);
			}
			set
			{
				CopFormationRecord._EASharpBinding_654(this.mSelf, value);
			}
		}
	}
}

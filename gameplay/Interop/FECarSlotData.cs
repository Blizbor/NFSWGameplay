using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x0200009B RID: 155
	[ExportOnlyCreate(true)]
	public class FECarSlotData : ISerializable
	{
		// Token: 0x06000816 RID: 2070 RVA: 0x0000AC10 File Offset: 0x00009C10
		public new unsafe static FECarSlotData CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new FECarSlotData(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x0000AC33 File Offset: 0x00009C33
		public unsafe FECarSlotData(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x0000AC3D File Offset: 0x00009C3D
		protected internal FECarSlotData(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x0000AC46 File Offset: 0x00009C46
		protected internal unsafe FECarSlotData(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600081A RID: 2074
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_807();

		// Token: 0x0600081B RID: 2075 RVA: 0x0000AC50 File Offset: 0x00009C50
		public FECarSlotData() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = FECarSlotData._EASharpBinding_807();
		}

		// Token: 0x0600081C RID: 2076
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_808(void* _ThisPtr);

		// Token: 0x0600081D RID: 2077 RVA: 0x0000AC78 File Offset: 0x00009C78
		~FECarSlotData()
		{
			FECarSlotData._EASharpBinding_808(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600081E RID: 2078
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_809(void* self, int val);

		// Token: 0x0600081F RID: 2079
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_810(void* self);

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000820 RID: 2080 RVA: 0x0000ACB4 File Offset: 0x00009CB4
		// (set) Token: 0x06000821 RID: 2081 RVA: 0x0000ACC1 File Offset: 0x00009CC1
		public int NumUsed
		{
			get
			{
				return FECarSlotData._EASharpBinding_810(this.mSelf);
			}
			set
			{
				FECarSlotData._EASharpBinding_809(this.mSelf, value);
			}
		}

		// Token: 0x06000822 RID: 2082
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_811(void* self, int val);

		// Token: 0x06000823 RID: 2083
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_812(void* self);

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000824 RID: 2084 RVA: 0x0000ACCF File Offset: 0x00009CCF
		// (set) Token: 0x06000825 RID: 2085 RVA: 0x0000ACDC File Offset: 0x00009CDC
		public int CarSlotLimit
		{
			get
			{
				return FECarSlotData._EASharpBinding_812(this.mSelf);
			}
			set
			{
				FECarSlotData._EASharpBinding_811(this.mSelf, value);
			}
		}

		// Token: 0x06000826 RID: 2086
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_813(void* self, int val);

		// Token: 0x06000827 RID: 2087
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_814(void* self);

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x0000ACEA File Offset: 0x00009CEA
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x0000ACF7 File Offset: 0x00009CF7
		public int CarSlotPrice
		{
			get
			{
				return FECarSlotData._EASharpBinding_814(this.mSelf);
			}
			set
			{
				FECarSlotData._EASharpBinding_813(this.mSelf, value);
			}
		}
	}
}

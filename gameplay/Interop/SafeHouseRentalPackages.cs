using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x0200009E RID: 158
	[ExportOnlyCreate(true)]
	public class SafeHouseRentalPackages : ExposedCommonBase
	{
		// Token: 0x06000854 RID: 2132 RVA: 0x0000B12C File Offset: 0x0000A12C
		public unsafe static SafeHouseRentalPackages CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new SafeHouseRentalPackages(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x0000B14F File Offset: 0x0000A14F
		public unsafe SafeHouseRentalPackages(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x0000B159 File Offset: 0x0000A159
		protected internal SafeHouseRentalPackages(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x0000B162 File Offset: 0x0000A162
		protected internal unsafe SafeHouseRentalPackages(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000858 RID: 2136
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_832();

		// Token: 0x06000859 RID: 2137 RVA: 0x0000B16C File Offset: 0x0000A16C
		public SafeHouseRentalPackages() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = SafeHouseRentalPackages._EASharpBinding_832();
		}

		// Token: 0x0600085A RID: 2138
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_833(void* _ThisPtr);

		// Token: 0x0600085B RID: 2139 RVA: 0x0000B194 File Offset: 0x0000A194
		~SafeHouseRentalPackages()
		{
			SafeHouseRentalPackages._EASharpBinding_833(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600085C RID: 2140
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_834(void* _ThisPtr, void* value);

		// Token: 0x0600085D RID: 2141 RVA: 0x0000B1D0 File Offset: 0x0000A1D0
		public void AddPackageList(SafeHouseRentalPackage value)
		{
			SafeHouseRentalPackages._EASharpBinding_834(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}
	}
}

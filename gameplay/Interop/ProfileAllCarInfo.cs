using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x02000099 RID: 153
	[ExportOnlyCreate(true)]
	public class ProfileAllCarInfo : ISerializable
	{
		// Token: 0x060007FE RID: 2046 RVA: 0x0000AA6C File Offset: 0x00009A6C
		public new unsafe static ProfileAllCarInfo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new ProfileAllCarInfo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0000AA8F File Offset: 0x00009A8F
		public unsafe ProfileAllCarInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x0000AA99 File Offset: 0x00009A99
		protected internal ProfileAllCarInfo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0000AAA2 File Offset: 0x00009AA2
		protected internal unsafe ProfileAllCarInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000802 RID: 2050
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_799();

		// Token: 0x06000803 RID: 2051 RVA: 0x0000AAAC File Offset: 0x00009AAC
		public ProfileAllCarInfo() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = ProfileAllCarInfo._EASharpBinding_799();
		}

		// Token: 0x06000804 RID: 2052
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_800(void* _ThisPtr);

		// Token: 0x06000805 RID: 2053 RVA: 0x0000AAD4 File Offset: 0x00009AD4
		~ProfileAllCarInfo()
		{
			ProfileAllCarInfo._EASharpBinding_800(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000806 RID: 2054
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_801(void* _ThisPtr, void* value);

		// Token: 0x06000807 RID: 2055 RVA: 0x0000AB10 File Offset: 0x00009B10
		public void AddCarInfo(FECarData value)
		{
			ProfileAllCarInfo._EASharpBinding_801(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000808 RID: 2056
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_802(void* self, int val);

		// Token: 0x06000809 RID: 2057
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_803(void* self);

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x0600080A RID: 2058 RVA: 0x0000AB30 File Offset: 0x00009B30
		// (set) Token: 0x0600080B RID: 2059 RVA: 0x0000AB3D File Offset: 0x00009B3D
		public int DefaultCarIndex
		{
			get
			{
				return ProfileAllCarInfo._EASharpBinding_803(this.mSelf);
			}
			set
			{
				ProfileAllCarInfo._EASharpBinding_802(this.mSelf, value);
			}
		}
	}
}

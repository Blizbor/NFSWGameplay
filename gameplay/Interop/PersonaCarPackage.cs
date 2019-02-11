using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x02000091 RID: 145
	[ExportOnlyCreate(true)]
	public class PersonaCarPackage : ExposedCommonBase
	{
		// Token: 0x060006FC RID: 1788 RVA: 0x000095B8 File Offset: 0x000085B8
		public unsafe static PersonaCarPackage CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PersonaCarPackage(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060006FD RID: 1789 RVA: 0x000095DB File Offset: 0x000085DB
		public unsafe PersonaCarPackage(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006FE RID: 1790 RVA: 0x000095E5 File Offset: 0x000085E5
		protected internal PersonaCarPackage(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060006FF RID: 1791 RVA: 0x000095EE File Offset: 0x000085EE
		protected internal unsafe PersonaCarPackage(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000700 RID: 1792
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_686(void* self);

		// Token: 0x06000701 RID: 1793 RVA: 0x000095F8 File Offset: 0x000085F8
		[DisableExceptionHandling]
		~PersonaCarPackage()
		{
			PersonaCarPackage._EASharpBinding_686(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000702 RID: 1794
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_687();

		// Token: 0x06000703 RID: 1795 RVA: 0x00009634 File Offset: 0x00008634
		public PersonaCarPackage() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PersonaCarPackage._EASharpBinding_687();
		}

		// Token: 0x06000704 RID: 1796
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_688(void* _ThisPtr);

		// Token: 0x06000705 RID: 1797 RVA: 0x0000965B File Offset: 0x0000865B
		public void Reset()
		{
			PersonaCarPackage._EASharpBinding_688(this.mSelf);
		}

		// Token: 0x06000706 RID: 1798
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_689(void* _ThisPtr, sbyte* value);

		// Token: 0x06000707 RID: 1799 RVA: 0x00009668 File Offset: 0x00008668
		public unsafe void SetPackageID(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PersonaCarPackage._EASharpBinding_689(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000708 RID: 1800
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_690(void* _ThisPtr, sbyte* value);

		// Token: 0x06000709 RID: 1801 RVA: 0x000096C8 File Offset: 0x000086C8
		public unsafe void SetPackageName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PersonaCarPackage._EASharpBinding_690(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600070A RID: 1802
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_691(void* _ThisPtr, sbyte* value);

		// Token: 0x0600070B RID: 1803 RVA: 0x00009728 File Offset: 0x00008728
		public unsafe void SetCategoryName(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PersonaCarPackage._EASharpBinding_691(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600070C RID: 1804
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_692(void* _ThisPtr, sbyte* value);

		// Token: 0x0600070D RID: 1805 RVA: 0x00009788 File Offset: 0x00008788
		public unsafe void SetPackageIconPath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PersonaCarPackage._EASharpBinding_692(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600070E RID: 1806
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_693(void* _ThisPtr, sbyte* value);

		// Token: 0x0600070F RID: 1807 RVA: 0x000097E8 File Offset: 0x000087E8
		public unsafe void SetCategoryIconPath(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PersonaCarPackage._EASharpBinding_693(this.mSelf, (sbyte*)ptr);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x02000093 RID: 147
	[ExportOnlyCreate(true)]
	public class PerformanceHAT : ISerializable
	{
		// Token: 0x06000734 RID: 1844 RVA: 0x00009AA0 File Offset: 0x00008AA0
		public new unsafe static PerformanceHAT CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PerformanceHAT(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00009AC3 File Offset: 0x00008AC3
		public unsafe PerformanceHAT(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x00009ACD File Offset: 0x00008ACD
		protected internal PerformanceHAT(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00009AD6 File Offset: 0x00008AD6
		protected internal unsafe PerformanceHAT(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000738 RID: 1848
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_710();

		// Token: 0x06000739 RID: 1849 RVA: 0x00009AE0 File Offset: 0x00008AE0
		public PerformanceHAT() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PerformanceHAT._EASharpBinding_710();
		}

		// Token: 0x0600073A RID: 1850
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_711(void* _ThisPtr);

		// Token: 0x0600073B RID: 1851 RVA: 0x00009B08 File Offset: 0x00008B08
		~PerformanceHAT()
		{
			PerformanceHAT._EASharpBinding_711(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600073C RID: 1852
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_712(void* _ThisPtr);

		// Token: 0x0600073D RID: 1853 RVA: 0x00009B44 File Offset: 0x00008B44
		public void Reset()
		{
			PerformanceHAT._EASharpBinding_712(this.mSelf);
		}

		// Token: 0x0600073E RID: 1854
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_713(void* _ThisPtr, sbyte* value);

		// Token: 0x0600073F RID: 1855 RVA: 0x00009B54 File Offset: 0x00008B54
		public unsafe void SetOverallRating(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PerformanceHAT._EASharpBinding_713(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000740 RID: 1856
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_714(void* _ThisPtr, sbyte* value);

		// Token: 0x06000741 RID: 1857 RVA: 0x00009BB4 File Offset: 0x00008BB4
		public unsafe void SetCurrentCarClassIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PerformanceHAT._EASharpBinding_714(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000742 RID: 1858
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_715(void* self, void* val);

		// Token: 0x06000743 RID: 1859
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_716(void* self);

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x00009C14 File Offset: 0x00008C14
		// (set) Token: 0x06000745 RID: 1861 RVA: 0x00009C3A File Offset: 0x00008C3A
		public PerformanceInfo Handling
		{
			get
			{
				return new PerformanceInfo(default(ExposeTag_InitOwned), PerformanceHAT._EASharpBinding_716(this.mSelf));
			}
			set
			{
				PerformanceHAT._EASharpBinding_715(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000746 RID: 1862
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_717(void* self, void* val);

		// Token: 0x06000747 RID: 1863
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_718(void* self);

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x06000748 RID: 1864 RVA: 0x00009C5C File Offset: 0x00008C5C
		// (set) Token: 0x06000749 RID: 1865 RVA: 0x00009C82 File Offset: 0x00008C82
		public PerformanceInfo Acceleration
		{
			get
			{
				return new PerformanceInfo(default(ExposeTag_InitOwned), PerformanceHAT._EASharpBinding_718(this.mSelf));
			}
			set
			{
				PerformanceHAT._EASharpBinding_717(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x0600074A RID: 1866
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_719(void* self, void* val);

		// Token: 0x0600074B RID: 1867
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_720(void* self);

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600074C RID: 1868 RVA: 0x00009CA4 File Offset: 0x00008CA4
		// (set) Token: 0x0600074D RID: 1869 RVA: 0x00009CCA File Offset: 0x00008CCA
		public PerformanceInfo TopSpeed
		{
			get
			{
				return new PerformanceInfo(default(ExposeTag_InitOwned), PerformanceHAT._EASharpBinding_720(this.mSelf));
			}
			set
			{
				PerformanceHAT._EASharpBinding_719(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x0600074E RID: 1870
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_721(void* self, int val);

		// Token: 0x0600074F RID: 1871
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_722(void* self);

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x06000750 RID: 1872 RVA: 0x00009CEA File Offset: 0x00008CEA
		// (set) Token: 0x06000751 RID: 1873 RVA: 0x00009CF7 File Offset: 0x00008CF7
		public HATRatingEffect OverallRatingEffect
		{
			get
			{
				return (HATRatingEffect)PerformanceHAT._EASharpBinding_722(this.mSelf);
			}
			set
			{
				PerformanceHAT._EASharpBinding_721(this.mSelf, (int)value);
			}
		}
	}
}

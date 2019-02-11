using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x02000092 RID: 146
	[ExportOnlyCreate(true)]
	public class PerformanceInfo : ExposedCommonBase
	{
		// Token: 0x06000710 RID: 1808 RVA: 0x00009848 File Offset: 0x00008848
		public unsafe static PerformanceInfo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PerformanceInfo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000711 RID: 1809 RVA: 0x0000986B File Offset: 0x0000886B
		public unsafe PerformanceInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000712 RID: 1810 RVA: 0x00009875 File Offset: 0x00008875
		protected internal PerformanceInfo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000713 RID: 1811 RVA: 0x0000987E File Offset: 0x0000887E
		protected internal unsafe PerformanceInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000714 RID: 1812
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_694();

		// Token: 0x06000715 RID: 1813 RVA: 0x00009888 File Offset: 0x00008888
		public PerformanceInfo() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = PerformanceInfo._EASharpBinding_694();
		}

		// Token: 0x06000716 RID: 1814
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_695(void* _ThisPtr);

		// Token: 0x06000717 RID: 1815 RVA: 0x000098B0 File Offset: 0x000088B0
		~PerformanceInfo()
		{
			PerformanceInfo._EASharpBinding_695(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000718 RID: 1816
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_696(void* _ThisPtr);

		// Token: 0x06000719 RID: 1817 RVA: 0x000098EC File Offset: 0x000088EC
		public void Reset()
		{
			PerformanceInfo._EASharpBinding_696(this.mSelf);
		}

		// Token: 0x0600071A RID: 1818
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_697(void* _ThisPtr, sbyte* value);

		// Token: 0x0600071B RID: 1819 RVA: 0x000098FC File Offset: 0x000088FC
		public unsafe void SetRatingString(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PerformanceInfo._EASharpBinding_697(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600071C RID: 1820
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_698(void* _ThisPtr, sbyte* value);

		// Token: 0x0600071D RID: 1821 RVA: 0x0000995C File Offset: 0x0000895C
		public unsafe void SetRatingGain(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PerformanceInfo._EASharpBinding_698(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x0600071E RID: 1822
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_699(void* _ThisPtr, sbyte* value);

		// Token: 0x0600071F RID: 1823 RVA: 0x000099BC File Offset: 0x000089BC
		public unsafe void SetRatingBonus(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				PerformanceInfo._EASharpBinding_699(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000720 RID: 1824
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_700(void* self, float val);

		// Token: 0x06000721 RID: 1825
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_701(void* self);

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x06000722 RID: 1826 RVA: 0x00009A19 File Offset: 0x00008A19
		// (set) Token: 0x06000723 RID: 1827 RVA: 0x00009A26 File Offset: 0x00008A26
		public float Percentage
		{
			get
			{
				return PerformanceInfo._EASharpBinding_701(this.mSelf);
			}
			set
			{
				PerformanceInfo._EASharpBinding_700(this.mSelf, value);
			}
		}

		// Token: 0x06000724 RID: 1828
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_702(void* self, int val);

		// Token: 0x06000725 RID: 1829
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_703(void* self);

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000726 RID: 1830 RVA: 0x00009A34 File Offset: 0x00008A34
		// (set) Token: 0x06000727 RID: 1831 RVA: 0x00009A41 File Offset: 0x00008A41
		public int Rating
		{
			get
			{
				return PerformanceInfo._EASharpBinding_703(this.mSelf);
			}
			set
			{
				PerformanceInfo._EASharpBinding_702(this.mSelf, value);
			}
		}

		// Token: 0x06000728 RID: 1832
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_704(void* self, int val);

		// Token: 0x06000729 RID: 1833
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_705(void* self);

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x0600072A RID: 1834 RVA: 0x00009A4F File Offset: 0x00008A4F
		// (set) Token: 0x0600072B RID: 1835 RVA: 0x00009A5C File Offset: 0x00008A5C
		public HATRatingEffect RatingDeltaEffect
		{
			get
			{
				return (HATRatingEffect)PerformanceInfo._EASharpBinding_705(this.mSelf);
			}
			set
			{
				PerformanceInfo._EASharpBinding_704(this.mSelf, (int)value);
			}
		}

		// Token: 0x0600072C RID: 1836
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_706(void* self, int val);

		// Token: 0x0600072D RID: 1837
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_707(void* self);

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x0600072E RID: 1838 RVA: 0x00009A6A File Offset: 0x00008A6A
		// (set) Token: 0x0600072F RID: 1839 RVA: 0x00009A77 File Offset: 0x00008A77
		public HATRatingEffect RatingGainEffect
		{
			get
			{
				return (HATRatingEffect)PerformanceInfo._EASharpBinding_707(this.mSelf);
			}
			set
			{
				PerformanceInfo._EASharpBinding_706(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000730 RID: 1840
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_708(void* self, int val);

		// Token: 0x06000731 RID: 1841
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_709(void* self);

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000732 RID: 1842 RVA: 0x00009A85 File Offset: 0x00008A85
		// (set) Token: 0x06000733 RID: 1843 RVA: 0x00009A92 File Offset: 0x00008A92
		public HATRatingEffect RatingBonusEffect
		{
			get
			{
				return (HATRatingEffect)PerformanceInfo._EASharpBinding_709(this.mSelf);
			}
			set
			{
				PerformanceInfo._EASharpBinding_708(this.mSelf, (int)value);
			}
		}
	}
}

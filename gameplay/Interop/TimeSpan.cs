using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x0200008E RID: 142
	[ExportOnlyCreate(true)]
	public class TimeSpan : ISerializable
	{
		// Token: 0x060006B6 RID: 1718 RVA: 0x0000914C File Offset: 0x0000814C
		public new unsafe static TimeSpan CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new TimeSpan(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0000916F File Offset: 0x0000816F
		public unsafe TimeSpan(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x00009179 File Offset: 0x00008179
		protected internal TimeSpan(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060006B9 RID: 1721 RVA: 0x00009182 File Offset: 0x00008182
		protected internal unsafe TimeSpan(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006BA RID: 1722
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_657();

		// Token: 0x060006BB RID: 1723 RVA: 0x0000918C File Offset: 0x0000818C
		public TimeSpan() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = TimeSpan._EASharpBinding_657();
		}

		// Token: 0x060006BC RID: 1724
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_658(void* _ThisPtr);

		// Token: 0x060006BD RID: 1725 RVA: 0x000091B4 File Offset: 0x000081B4
		~TimeSpan()
		{
			TimeSpan._EASharpBinding_658(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060006BE RID: 1726
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_659(void* _ThisPtr);

		// Token: 0x060006BF RID: 1727 RVA: 0x000091F0 File Offset: 0x000081F0
		public virtual void Reset()
		{
			TimeSpan._EASharpBinding_659(this.mSelf);
		}

		// Token: 0x060006C0 RID: 1728
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_660(void* _ThisPtr, sbyte* value);

		// Token: 0x060006C1 RID: 1729 RVA: 0x00009200 File Offset: 0x00008200
		public unsafe void SetTimeString(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				TimeSpan._EASharpBinding_660(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060006C2 RID: 1730
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_661(void* self, int val);

		// Token: 0x060006C3 RID: 1731
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_662(void* self);

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060006C4 RID: 1732 RVA: 0x0000925D File Offset: 0x0000825D
		// (set) Token: 0x060006C5 RID: 1733 RVA: 0x0000926A File Offset: 0x0000826A
		public int Milliseconds
		{
			get
			{
				return TimeSpan._EASharpBinding_662(this.mSelf);
			}
			set
			{
				TimeSpan._EASharpBinding_661(this.mSelf, value);
			}
		}

		// Token: 0x060006C6 RID: 1734
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_663(void* self, int val);

		// Token: 0x060006C7 RID: 1735
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_664(void* self);

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060006C8 RID: 1736 RVA: 0x00009278 File Offset: 0x00008278
		// (set) Token: 0x060006C9 RID: 1737 RVA: 0x00009285 File Offset: 0x00008285
		public int Seconds
		{
			get
			{
				return TimeSpan._EASharpBinding_664(this.mSelf);
			}
			set
			{
				TimeSpan._EASharpBinding_663(this.mSelf, value);
			}
		}

		// Token: 0x060006CA RID: 1738
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_665(void* self, int val);

		// Token: 0x060006CB RID: 1739
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_666(void* self);

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00009293 File Offset: 0x00008293
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x000092A0 File Offset: 0x000082A0
		public int Minutes
		{
			get
			{
				return TimeSpan._EASharpBinding_666(this.mSelf);
			}
			set
			{
				TimeSpan._EASharpBinding_665(this.mSelf, value);
			}
		}

		// Token: 0x060006CE RID: 1742
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_667(void* self, int val);

		// Token: 0x060006CF RID: 1743
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_668(void* self);

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060006D0 RID: 1744 RVA: 0x000092AE File Offset: 0x000082AE
		// (set) Token: 0x060006D1 RID: 1745 RVA: 0x000092BB File Offset: 0x000082BB
		public int Hours
		{
			get
			{
				return TimeSpan._EASharpBinding_668(this.mSelf);
			}
			set
			{
				TimeSpan._EASharpBinding_667(this.mSelf, value);
			}
		}

		// Token: 0x060006D2 RID: 1746
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_669(void* self, double val);

		// Token: 0x060006D3 RID: 1747
		[DllImport("<internal>")]
		private unsafe static extern double _EASharpBinding_670(void* self);

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060006D4 RID: 1748 RVA: 0x000092C9 File Offset: 0x000082C9
		// (set) Token: 0x060006D5 RID: 1749 RVA: 0x000092D6 File Offset: 0x000082D6
		public double TotalSeconds
		{
			get
			{
				return TimeSpan._EASharpBinding_670(this.mSelf);
			}
			set
			{
				TimeSpan._EASharpBinding_669(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x02000090 RID: 144
	[ExportOnlyCreate(true)]
	public class GameplayEnhancer : ExposedCommonBase
	{
		// Token: 0x060006EA RID: 1770 RVA: 0x0000942C File Offset: 0x0000842C
		public unsafe static GameplayEnhancer CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new GameplayEnhancer(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060006EB RID: 1771 RVA: 0x0000944F File Offset: 0x0000844F
		public unsafe GameplayEnhancer(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006EC RID: 1772 RVA: 0x00009459 File Offset: 0x00008459
		protected internal GameplayEnhancer(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060006ED RID: 1773 RVA: 0x00009462 File Offset: 0x00008462
		protected internal unsafe GameplayEnhancer(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060006EE RID: 1774
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_679();

		// Token: 0x060006EF RID: 1775 RVA: 0x0000946C File Offset: 0x0000846C
		public GameplayEnhancer() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = GameplayEnhancer._EASharpBinding_679();
		}

		// Token: 0x060006F0 RID: 1776
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_680(void* _ThisPtr);

		// Token: 0x060006F1 RID: 1777 RVA: 0x00009494 File Offset: 0x00008494
		~GameplayEnhancer()
		{
			GameplayEnhancer._EASharpBinding_680(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060006F2 RID: 1778
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_681(void* _ThisPtr);

		// Token: 0x060006F3 RID: 1779 RVA: 0x000094D0 File Offset: 0x000084D0
		public void Reset()
		{
			GameplayEnhancer._EASharpBinding_681(this.mSelf);
		}

		// Token: 0x060006F4 RID: 1780
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_682(void* _ThisPtr, sbyte* value);

		// Token: 0x060006F5 RID: 1781 RVA: 0x000094E0 File Offset: 0x000084E0
		public unsafe void SetIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				GameplayEnhancer._EASharpBinding_682(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060006F6 RID: 1782
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_683(void* _ThisPtr, sbyte* value);

		// Token: 0x060006F7 RID: 1783 RVA: 0x00009540 File Offset: 0x00008540
		public unsafe void SetToolTip(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				GameplayEnhancer._EASharpBinding_683(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060006F8 RID: 1784
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_684(void* self, bool val);

		// Token: 0x060006F9 RID: 1785
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_685(void* self);

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060006FA RID: 1786 RVA: 0x0000959D File Offset: 0x0000859D
		// (set) Token: 0x060006FB RID: 1787 RVA: 0x000095AA File Offset: 0x000085AA
		public bool IsActivated
		{
			get
			{
				return GameplayEnhancer._EASharpBinding_685(this.mSelf);
			}
			set
			{
				GameplayEnhancer._EASharpBinding_684(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000BB RID: 187
	[ExportOnlyCreate(true)]
	public class GamerScore : ISerializable
	{
		// Token: 0x06000AFA RID: 2810 RVA: 0x0000DEEC File Offset: 0x0000CEEC
		public new unsafe static GamerScore CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new GamerScore(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000AFB RID: 2811 RVA: 0x0000DF0F File Offset: 0x0000CF0F
		public unsafe GamerScore(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AFC RID: 2812 RVA: 0x0000DF19 File Offset: 0x0000CF19
		protected internal GamerScore(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000AFD RID: 2813 RVA: 0x0000DF22 File Offset: 0x0000CF22
		protected internal unsafe GamerScore(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AFE RID: 2814
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1114();

		// Token: 0x06000AFF RID: 2815 RVA: 0x0000DF2C File Offset: 0x0000CF2C
		public GamerScore() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = GamerScore._EASharpBinding_1114();
		}

		// Token: 0x06000B00 RID: 2816
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1115(void* _ThisPtr);

		// Token: 0x06000B01 RID: 2817 RVA: 0x0000DF54 File Offset: 0x0000CF54
		~GamerScore()
		{
			GamerScore._EASharpBinding_1115(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000B02 RID: 2818
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1116(void* _ThisPtr);

		// Token: 0x06000B03 RID: 2819 RVA: 0x0000DF90 File Offset: 0x0000CF90
		public virtual void Reset()
		{
			GamerScore._EASharpBinding_1116(this.mSelf);
		}

		// Token: 0x06000B04 RID: 2820
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1117(void* _ThisPtr, sbyte* value);

		// Token: 0x06000B05 RID: 2821 RVA: 0x0000DFA0 File Offset: 0x0000CFA0
		public unsafe void SetScoreString(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				GamerScore._EASharpBinding_1117(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000B06 RID: 2822
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1118(void* self, int val);

		// Token: 0x06000B07 RID: 2823
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1119(void* self);

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000B08 RID: 2824 RVA: 0x0000DFFD File Offset: 0x0000CFFD
		// (set) Token: 0x06000B09 RID: 2825 RVA: 0x0000E00A File Offset: 0x0000D00A
		public int Score
		{
			get
			{
				return GamerScore._EASharpBinding_1119(this.mSelf);
			}
			set
			{
				GamerScore._EASharpBinding_1118(this.mSelf, value);
			}
		}

		// Token: 0x06000B0A RID: 2826
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1120(void* self, int val);

		// Token: 0x06000B0B RID: 2827
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1121(void* self);

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x06000B0C RID: 2828 RVA: 0x0000E018 File Offset: 0x0000D018
		// (set) Token: 0x06000B0D RID: 2829 RVA: 0x0000E025 File Offset: 0x0000D025
		public int ScoreBefore
		{
			get
			{
				return GamerScore._EASharpBinding_1121(this.mSelf);
			}
			set
			{
				GamerScore._EASharpBinding_1120(this.mSelf, value);
			}
		}
	}
}

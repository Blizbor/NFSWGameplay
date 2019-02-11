using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000B9 RID: 185
	[ExportOnlyCreate(true)]
	public class AchievementPacket : ISerializable
	{
		// Token: 0x06000AC2 RID: 2754 RVA: 0x0000DB00 File Offset: 0x0000CB00
		public new unsafe static AchievementPacket CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new AchievementPacket(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000AC3 RID: 2755 RVA: 0x0000DB23 File Offset: 0x0000CB23
		public unsafe AchievementPacket(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AC4 RID: 2756 RVA: 0x0000DB2D File Offset: 0x0000CB2D
		protected internal AchievementPacket(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000AC5 RID: 2757 RVA: 0x0000DB36 File Offset: 0x0000CB36
		protected internal unsafe AchievementPacket(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AC6 RID: 2758
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1090();

		// Token: 0x06000AC7 RID: 2759 RVA: 0x0000DB40 File Offset: 0x0000CB40
		public AchievementPacket() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = AchievementPacket._EASharpBinding_1090();
		}

		// Token: 0x06000AC8 RID: 2760
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1091(void* _ThisPtr);

		// Token: 0x06000AC9 RID: 2761 RVA: 0x0000DB68 File Offset: 0x0000CB68
		~AchievementPacket()
		{
			AchievementPacket._EASharpBinding_1091(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000ACA RID: 2762
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1092(void* _ThisPtr);

		// Token: 0x06000ACB RID: 2763 RVA: 0x0000DBA4 File Offset: 0x0000CBA4
		public void Reset()
		{
			AchievementPacket._EASharpBinding_1092(this.mSelf);
		}

		// Token: 0x06000ACC RID: 2764
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1093(void* _ThisPtr);

		// Token: 0x06000ACD RID: 2765 RVA: 0x0000DBB1 File Offset: 0x0000CBB1
		public void CompleteStage()
		{
			AchievementPacket._EASharpBinding_1093(this.mSelf);
		}

		// Token: 0x06000ACE RID: 2766
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1094(void* _ThisPtr);

		// Token: 0x06000ACF RID: 2767 RVA: 0x0000DBC0 File Offset: 0x0000CBC0
		public bool Debug_Increment()
		{
			return AchievementPacket._EASharpBinding_1094(this.mSelf);
		}

		// Token: 0x06000AD0 RID: 2768
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1095(void* _ThisPtr);

		// Token: 0x06000AD1 RID: 2769 RVA: 0x0000DBDC File Offset: 0x0000CBDC
		public bool IsComplete()
		{
			return AchievementPacket._EASharpBinding_1095(this.mSelf);
		}

		// Token: 0x06000AD2 RID: 2770
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1096(void* _ThisPtr, sbyte* value);

		// Token: 0x06000AD3 RID: 2771 RVA: 0x0000DBF8 File Offset: 0x0000CBF8
		public unsafe void SetTitle(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementPacket._EASharpBinding_1096(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000AD4 RID: 2772
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1097(void* _ThisPtr, sbyte* value);

		// Token: 0x06000AD5 RID: 2773 RVA: 0x0000DC58 File Offset: 0x0000CC58
		public unsafe void SetDesc(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementPacket._EASharpBinding_1097(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000AD6 RID: 2774
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1098(void* _ThisPtr, sbyte* value);

		// Token: 0x06000AD7 RID: 2775 RVA: 0x0000DCB8 File Offset: 0x0000CCB8
		public unsafe void SetDebug_Icon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementPacket._EASharpBinding_1098(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000AD8 RID: 2776
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1099(void* self, void* val);

		// Token: 0x06000AD9 RID: 2777
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1100(void* self);

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000ADA RID: 2778 RVA: 0x0000DD18 File Offset: 0x0000CD18
		// (set) Token: 0x06000ADB RID: 2779 RVA: 0x0000DD3E File Offset: 0x0000CD3E
		public AchievementReward mAchievementReward
		{
			get
			{
				return new AchievementReward(default(ExposeTag_InitOwned), AchievementPacket._EASharpBinding_1100(this.mSelf));
			}
			set
			{
				AchievementPacket._EASharpBinding_1099(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000ADC RID: 2780
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1101(void* self, bool val);

		// Token: 0x06000ADD RID: 2781
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1102(void* self);

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000ADE RID: 2782 RVA: 0x0000DD5E File Offset: 0x0000CD5E
		// (set) Token: 0x06000ADF RID: 2783 RVA: 0x0000DD6B File Offset: 0x0000CD6B
		public bool isStickied
		{
			get
			{
				return AchievementPacket._EASharpBinding_1102(this.mSelf);
			}
			set
			{
				AchievementPacket._EASharpBinding_1101(this.mSelf, value);
			}
		}

		// Token: 0x06000AE0 RID: 2784
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1103(void* self, int val);

		// Token: 0x06000AE1 RID: 2785
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1104(void* self);

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000AE2 RID: 2786 RVA: 0x0000DD79 File Offset: 0x0000CD79
		// (set) Token: 0x06000AE3 RID: 2787 RVA: 0x0000DD86 File Offset: 0x0000CD86
		public int ID
		{
			get
			{
				return AchievementPacket._EASharpBinding_1104(this.mSelf);
			}
			set
			{
				AchievementPacket._EASharpBinding_1103(this.mSelf, value);
			}
		}
	}
}

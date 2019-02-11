using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace Interop
{
	// Token: 0x020000B7 RID: 183
	[ExportOnlyCreate(true)]
	public class AchievementRewardStage : ISerializable
	{
		// Token: 0x06000A72 RID: 2674 RVA: 0x0000D4F4 File Offset: 0x0000C4F4
		public new unsafe static AchievementRewardStage CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new AchievementRewardStage(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000A73 RID: 2675 RVA: 0x0000D517 File Offset: 0x0000C517
		public unsafe AchievementRewardStage(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A74 RID: 2676 RVA: 0x0000D521 File Offset: 0x0000C521
		protected internal AchievementRewardStage(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000A75 RID: 2677 RVA: 0x0000D52A File Offset: 0x0000C52A
		protected internal unsafe AchievementRewardStage(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000A76 RID: 2678
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1054();

		// Token: 0x06000A77 RID: 2679 RVA: 0x0000D534 File Offset: 0x0000C534
		public AchievementRewardStage() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = AchievementRewardStage._EASharpBinding_1054();
		}

		// Token: 0x06000A78 RID: 2680
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1055(void* _ThisPtr);

		// Token: 0x06000A79 RID: 2681 RVA: 0x0000D55C File Offset: 0x0000C55C
		~AchievementRewardStage()
		{
			AchievementRewardStage._EASharpBinding_1055(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000A7A RID: 2682
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1056(void* _ThisPtr, int val_);

		// Token: 0x06000A7B RID: 2683 RVA: 0x0000D598 File Offset: 0x0000C598
		public void Debug_SetPercent(int val_)
		{
			AchievementRewardStage._EASharpBinding_1056(this.mSelf, val_);
		}

		// Token: 0x06000A7C RID: 2684
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1057(void* _ThisPtr);

		// Token: 0x06000A7D RID: 2685 RVA: 0x0000D5A6 File Offset: 0x0000C5A6
		public void Complete()
		{
			AchievementRewardStage._EASharpBinding_1057(this.mSelf);
		}

		// Token: 0x06000A7E RID: 2686
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1058(void* _ThisPtr);

		// Token: 0x06000A7F RID: 2687 RVA: 0x0000D5B3 File Offset: 0x0000C5B3
		public void Reset()
		{
			AchievementRewardStage._EASharpBinding_1058(this.mSelf);
		}

		// Token: 0x06000A80 RID: 2688
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1059(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A81 RID: 2689 RVA: 0x0000D5C0 File Offset: 0x0000C5C0
		public unsafe void SetTitle(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1059(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A82 RID: 2690
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1060(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A83 RID: 2691 RVA: 0x0000D620 File Offset: 0x0000C620
		public unsafe void SetDesc(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1060(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A84 RID: 2692
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1061(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A85 RID: 2693 RVA: 0x0000D680 File Offset: 0x0000C680
		public unsafe void SetIcon(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1061(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A86 RID: 2694
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1062(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A87 RID: 2695 RVA: 0x0000D6E0 File Offset: 0x0000C6E0
		public unsafe void SetProgressText(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1062(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A88 RID: 2696
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1063(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A89 RID: 2697 RVA: 0x0000D740 File Offset: 0x0000C740
		public unsafe void SetDriverScoreRewardText(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1063(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A8A RID: 2698
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1064(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A8B RID: 2699 RVA: 0x0000D7A0 File Offset: 0x0000C7A0
		public unsafe void SetDateAchieved(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1064(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A8C RID: 2700
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1065(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A8D RID: 2701 RVA: 0x0000D800 File Offset: 0x0000C800
		public unsafe void SetRarityText(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1065(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A8E RID: 2702
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1066(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A8F RID: 2703 RVA: 0x0000D860 File Offset: 0x0000C860
		public unsafe void SetConditionText(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1066(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A90 RID: 2704
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1067(void* _ThisPtr, sbyte* value);

		// Token: 0x06000A91 RID: 2705 RVA: 0x0000D8C0 File Offset: 0x0000C8C0
		public unsafe void SetRewardText(string value)
		{
			int byteCount = Encoding.ASCII.GetByteCount(value);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(value, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				AchievementRewardStage._EASharpBinding_1067(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x06000A92 RID: 2706
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1068(void* self, int val);

		// Token: 0x06000A93 RID: 2707
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1069(void* self);

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0000D91D File Offset: 0x0000C91D
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0000D92A File Offset: 0x0000C92A
		public eAchievementState State
		{
			get
			{
				return (eAchievementState)AchievementRewardStage._EASharpBinding_1069(this.mSelf);
			}
			set
			{
				AchievementRewardStage._EASharpBinding_1068(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000A96 RID: 2710
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1070(void* self, uint val);

		// Token: 0x06000A97 RID: 2711
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1071(void* self);

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0000D938 File Offset: 0x0000C938
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0000D945 File Offset: 0x0000C945
		public uint Percent
		{
			get
			{
				return AchievementRewardStage._EASharpBinding_1071(this.mSelf);
			}
			set
			{
				AchievementRewardStage._EASharpBinding_1070(this.mSelf, value);
			}
		}

		// Token: 0x06000A9A RID: 2714
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1072(void* self, uint val);

		// Token: 0x06000A9B RID: 2715
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1073(void* self);

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x06000A9C RID: 2716 RVA: 0x0000D953 File Offset: 0x0000C953
		// (set) Token: 0x06000A9D RID: 2717 RVA: 0x0000D960 File Offset: 0x0000C960
		public uint PrevPercent
		{
			get
			{
				return AchievementRewardStage._EASharpBinding_1073(this.mSelf);
			}
			set
			{
				AchievementRewardStage._EASharpBinding_1072(this.mSelf, value);
			}
		}

		// Token: 0x06000A9E RID: 2718
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1074(void* self, uint val);

		// Token: 0x06000A9F RID: 2719
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1075(void* self);

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x06000AA0 RID: 2720 RVA: 0x0000D96E File Offset: 0x0000C96E
		// (set) Token: 0x06000AA1 RID: 2721 RVA: 0x0000D97B File Offset: 0x0000C97B
		public uint MaxPercent
		{
			get
			{
				return AchievementRewardStage._EASharpBinding_1075(this.mSelf);
			}
			set
			{
				AchievementRewardStage._EASharpBinding_1074(this.mSelf, value);
			}
		}

		// Token: 0x06000AA2 RID: 2722
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1076(void* self, uint val);

		// Token: 0x06000AA3 RID: 2723
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1077(void* self);

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x06000AA4 RID: 2724 RVA: 0x0000D989 File Offset: 0x0000C989
		// (set) Token: 0x06000AA5 RID: 2725 RVA: 0x0000D996 File Offset: 0x0000C996
		public uint DriverScoreReward
		{
			get
			{
				return AchievementRewardStage._EASharpBinding_1077(this.mSelf);
			}
			set
			{
				AchievementRewardStage._EASharpBinding_1076(this.mSelf, value);
			}
		}

		// Token: 0x06000AA6 RID: 2726
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1078(void* self, uint val);

		// Token: 0x06000AA7 RID: 2727
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_1079(void* self);

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x06000AA8 RID: 2728 RVA: 0x0000D9A4 File Offset: 0x0000C9A4
		// (set) Token: 0x06000AA9 RID: 2729 RVA: 0x0000D9B1 File Offset: 0x0000C9B1
		public uint Rarity
		{
			get
			{
				return AchievementRewardStage._EASharpBinding_1079(this.mSelf);
			}
			set
			{
				AchievementRewardStage._EASharpBinding_1078(this.mSelf, value);
			}
		}
	}
}

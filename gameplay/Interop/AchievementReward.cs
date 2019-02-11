using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000B8 RID: 184
	[ExportOnlyCreate(true)]
	public class AchievementReward : ISerializable
	{
		// Token: 0x06000AAA RID: 2730 RVA: 0x0000D9C0 File Offset: 0x0000C9C0
		public new unsafe static AchievementReward CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new AchievementReward(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000AAB RID: 2731 RVA: 0x0000D9E3 File Offset: 0x0000C9E3
		public unsafe AchievementReward(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AAC RID: 2732 RVA: 0x0000D9ED File Offset: 0x0000C9ED
		protected internal AchievementReward(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000AAD RID: 2733 RVA: 0x0000D9F6 File Offset: 0x0000C9F6
		protected internal unsafe AchievementReward(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AAE RID: 2734
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1080();

		// Token: 0x06000AAF RID: 2735 RVA: 0x0000DA00 File Offset: 0x0000CA00
		public AchievementReward() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = AchievementReward._EASharpBinding_1080();
		}

		// Token: 0x06000AB0 RID: 2736
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1081(void* _ThisPtr);

		// Token: 0x06000AB1 RID: 2737 RVA: 0x0000DA28 File Offset: 0x0000CA28
		~AchievementReward()
		{
			AchievementReward._EASharpBinding_1081(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000AB2 RID: 2738
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1082(void* _ThisPtr, void* value);

		// Token: 0x06000AB3 RID: 2739 RVA: 0x0000DA64 File Offset: 0x0000CA64
		public void AddRewards(AchievementRewardStage value)
		{
			AchievementReward._EASharpBinding_1082(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000AB4 RID: 2740
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1083(void* _ThisPtr);

		// Token: 0x06000AB5 RID: 2741 RVA: 0x0000DA84 File Offset: 0x0000CA84
		public void Debug_UnlockReward()
		{
			AchievementReward._EASharpBinding_1083(this.mSelf);
		}

		// Token: 0x06000AB6 RID: 2742
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1084(void* _ThisPtr);

		// Token: 0x06000AB7 RID: 2743 RVA: 0x0000DA94 File Offset: 0x0000CA94
		public bool Debug_Increment()
		{
			return AchievementReward._EASharpBinding_1084(this.mSelf);
		}

		// Token: 0x06000AB8 RID: 2744
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1085(void* _ThisPtr);

		// Token: 0x06000AB9 RID: 2745 RVA: 0x0000DAAE File Offset: 0x0000CAAE
		public void Reset()
		{
			AchievementReward._EASharpBinding_1085(this.mSelf);
		}

		// Token: 0x06000ABA RID: 2746
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1086(void* _ThisPtr);

		// Token: 0x06000ABB RID: 2747 RVA: 0x0000DABB File Offset: 0x0000CABB
		public void CompleteStage()
		{
			AchievementReward._EASharpBinding_1086(this.mSelf);
		}

		// Token: 0x06000ABC RID: 2748
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_1087(void* _ThisPtr);

		// Token: 0x06000ABD RID: 2749 RVA: 0x0000DAC8 File Offset: 0x0000CAC8
		public bool IsStageComplete()
		{
			return AchievementReward._EASharpBinding_1087(this.mSelf);
		}

		// Token: 0x06000ABE RID: 2750
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1088(void* self, int val);

		// Token: 0x06000ABF RID: 2751
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1089(void* self);

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x06000AC0 RID: 2752 RVA: 0x0000DAE2 File Offset: 0x0000CAE2
		// (set) Token: 0x06000AC1 RID: 2753 RVA: 0x0000DAEF File Offset: 0x0000CAEF
		public int DefaultIndex
		{
			get
			{
				return AchievementReward._EASharpBinding_1089(this.mSelf);
			}
			set
			{
				AchievementReward._EASharpBinding_1088(this.mSelf, value);
			}
		}
	}
}

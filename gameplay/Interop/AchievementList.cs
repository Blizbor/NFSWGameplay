using System;
using System.Runtime.InteropServices;
using EASharp;

namespace Interop
{
	// Token: 0x020000BA RID: 186
	[ExportOnlyCreate(true)]
	public class AchievementList : ISerializable
	{
		// Token: 0x06000AE4 RID: 2788 RVA: 0x0000DD94 File Offset: 0x0000CD94
		public new unsafe static AchievementList CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new AchievementList(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000AE5 RID: 2789 RVA: 0x0000DDB7 File Offset: 0x0000CDB7
		public unsafe AchievementList(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x0000DDC1 File Offset: 0x0000CDC1
		protected internal AchievementList(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000AE7 RID: 2791 RVA: 0x0000DDCA File Offset: 0x0000CDCA
		protected internal unsafe AchievementList(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000AE8 RID: 2792
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1105();

		// Token: 0x06000AE9 RID: 2793 RVA: 0x0000DDD4 File Offset: 0x0000CDD4
		public AchievementList() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = AchievementList._EASharpBinding_1105();
		}

		// Token: 0x06000AEA RID: 2794
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1106(void* _ThisPtr);

		// Token: 0x06000AEB RID: 2795 RVA: 0x0000DDFC File Offset: 0x0000CDFC
		~AchievementList()
		{
			AchievementList._EASharpBinding_1106(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000AEC RID: 2796
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1107(void* _ThisPtr);

		// Token: 0x06000AED RID: 2797 RVA: 0x0000DE38 File Offset: 0x0000CE38
		public virtual void Reset()
		{
			AchievementList._EASharpBinding_1107(this.mSelf);
		}

		// Token: 0x06000AEE RID: 2798
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1108(void* _ThisPtr, void* value);

		// Token: 0x06000AEF RID: 2799 RVA: 0x0000DE45 File Offset: 0x0000CE45
		public void AddAchievements(AchievementPacket value)
		{
			AchievementList._EASharpBinding_1108(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000AF0 RID: 2800
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1109(void* _ThisPtr, void* value);

		// Token: 0x06000AF1 RID: 2801 RVA: 0x0000DE65 File Offset: 0x0000CE65
		public void AddProgressed(AchievementPacket value)
		{
			AchievementList._EASharpBinding_1109(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
		}

		// Token: 0x06000AF2 RID: 2802
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1110(void* self, void* val);

		// Token: 0x06000AF3 RID: 2803
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_1111(void* self);

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000AF4 RID: 2804 RVA: 0x0000DE88 File Offset: 0x0000CE88
		// (set) Token: 0x06000AF5 RID: 2805 RVA: 0x0000DEAE File Offset: 0x0000CEAE
		public FEPlayerPersona PlayerData
		{
			get
			{
				return new FEPlayerPersona(default(ExposeTag_InitOwned), AchievementList._EASharpBinding_1111(this.mSelf));
			}
			set
			{
				AchievementList._EASharpBinding_1110(this.mSelf, object.ReferenceEquals(value, null) ? null : value._GetRaw());
			}
		}

		// Token: 0x06000AF6 RID: 2806
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_1112(void* self, int val);

		// Token: 0x06000AF7 RID: 2807
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_1113(void* self);

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000AF8 RID: 2808 RVA: 0x0000DECE File Offset: 0x0000CECE
		// (set) Token: 0x06000AF9 RID: 2809 RVA: 0x0000DEDB File Offset: 0x0000CEDB
		public int DefaultIndex
		{
			get
			{
				return AchievementList._EASharpBinding_1113(this.mSelf);
			}
			set
			{
				AchievementList._EASharpBinding_1112(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

namespace GameCore
{
	// Token: 0x02000051 RID: 81
	[ExportOnlyCreate(false)]
	public class PursuitInfo : ExposedCommonBase
	{
		// Token: 0x06000394 RID: 916 RVA: 0x0000596C File Offset: 0x0000496C
		public unsafe static PursuitInfo CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new PursuitInfo(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000598F File Offset: 0x0000498F
		public unsafe PursuitInfo(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000396 RID: 918 RVA: 0x00005999 File Offset: 0x00004999
		protected internal PursuitInfo(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000397 RID: 919 RVA: 0x000059A2 File Offset: 0x000049A2
		protected internal unsafe PursuitInfo(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000398 RID: 920
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_363(void* self);

		// Token: 0x06000399 RID: 921 RVA: 0x000059AC File Offset: 0x000049AC
		[DisableExceptionHandling]
		~PursuitInfo()
		{
			PursuitInfo._EASharpBinding_363(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x0600039A RID: 922
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_364(void* _ThisPtr);

		// Token: 0x0600039B RID: 923 RVA: 0x000059E8 File Offset: 0x000049E8
		public int GetNumCopsDisabled()
		{
			return PursuitInfo._EASharpBinding_364(this.mSelf);
		}

		// Token: 0x0600039C RID: 924
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_365(void* _ThisPtr);

		// Token: 0x0600039D RID: 925 RVA: 0x00005A04 File Offset: 0x00004A04
		public int GetNumCopsRammed()
		{
			return PursuitInfo._EASharpBinding_365(this.mSelf);
		}

		// Token: 0x0600039E RID: 926
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_366(void* _ThisPtr);

		// Token: 0x0600039F RID: 927 RVA: 0x00005A20 File Offset: 0x00004A20
		public int GetNumCopsDeployed()
		{
			return PursuitInfo._EASharpBinding_366(this.mSelf);
		}

		// Token: 0x060003A0 RID: 928
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_367(void* _ThisPtr);

		// Token: 0x060003A1 RID: 929 RVA: 0x00005A3C File Offset: 0x00004A3C
		public int GetCostToState()
		{
			return PursuitInfo._EASharpBinding_367(this.mSelf);
		}

		// Token: 0x060003A2 RID: 930
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_368(void* _ThisPtr);

		// Token: 0x060003A3 RID: 931 RVA: 0x00005A58 File Offset: 0x00004A58
		public int GetSpikeStripsDodged()
		{
			return PursuitInfo._EASharpBinding_368(this.mSelf);
		}

		// Token: 0x060003A4 RID: 932
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_369(void* _ThisPtr);

		// Token: 0x060003A5 RID: 933 RVA: 0x00005A74 File Offset: 0x00004A74
		public int GetRoadBlocksDodged()
		{
			return PursuitInfo._EASharpBinding_369(this.mSelf);
		}

		// Token: 0x060003A6 RID: 934
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_370(void* _ThisPtr);

		// Token: 0x060003A7 RID: 935 RVA: 0x00005A90 File Offset: 0x00004A90
		public int GetInfractions()
		{
			return PursuitInfo._EASharpBinding_370(this.mSelf);
		}

		// Token: 0x060003A8 RID: 936
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_371(void* _ThisPtr);

		// Token: 0x060003A9 RID: 937 RVA: 0x00005AAC File Offset: 0x00004AAC
		public uint GetPursuitDuration()
		{
			return PursuitInfo._EASharpBinding_371(this.mSelf);
		}

		// Token: 0x060003AA RID: 938
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_372(void* _ThisPtr);

		// Token: 0x060003AB RID: 939 RVA: 0x00005AC8 File Offset: 0x00004AC8
		public uint GetPursuitLevelKey()
		{
			return PursuitInfo._EASharpBinding_372(this.mSelf);
		}

		// Token: 0x060003AC RID: 940
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_373(void* _ThisPtr);

		// Token: 0x060003AD RID: 941 RVA: 0x00005AE4 File Offset: 0x00004AE4
		public bool IsValid()
		{
			return PursuitInfo._EASharpBinding_373(this.mSelf);
		}

		// Token: 0x060003AE RID: 942
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_374(void* _ThisPtr, float val);

		// Token: 0x060003AF RID: 943 RVA: 0x00005AFE File Offset: 0x00004AFE
		public void HACK_SetPursuitMeter(float val)
		{
			PursuitInfo._EASharpBinding_374(this.mSelf, val);
		}
	}
}

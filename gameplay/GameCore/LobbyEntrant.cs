using System;
using System.Runtime.InteropServices;
using EASharp;
using Victory.Service;

namespace GameCore
{
	// Token: 0x0200004A RID: 74
	[ExportOnlyCreate(true)]
	public class LobbyEntrant : ExposedCommonBase
	{
		// Token: 0x0600033A RID: 826 RVA: 0x00005358 File Offset: 0x00004358
		public unsafe static LobbyEntrant CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new LobbyEntrant(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000537B File Offset: 0x0000437B
		public unsafe LobbyEntrant(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600033C RID: 828 RVA: 0x00005385 File Offset: 0x00004385
		protected internal LobbyEntrant(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600033D RID: 829 RVA: 0x0000538E File Offset: 0x0000438E
		protected internal unsafe LobbyEntrant(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600033E RID: 830
		[DoesNotBlock]
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_332(void* self);

		// Token: 0x0600033F RID: 831 RVA: 0x00005398 File Offset: 0x00004398
		[DisableExceptionHandling]
		~LobbyEntrant()
		{
			LobbyEntrant._EASharpBinding_332(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000340 RID: 832
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_333(void* _ThisPtr);

		// Token: 0x06000341 RID: 833 RVA: 0x000053D4 File Offset: 0x000043D4
		public void Reset()
		{
			LobbyEntrant._EASharpBinding_333(this.mSelf);
		}

		// Token: 0x06000342 RID: 834
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_334(void* _ThisPtr);

		// Token: 0x06000343 RID: 835 RVA: 0x000053E4 File Offset: 0x000043E4
		public bool IsValid()
		{
			return LobbyEntrant._EASharpBinding_334(this.mSelf);
		}

		// Token: 0x06000344 RID: 836
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_335(void* self, long val);

		// Token: 0x06000345 RID: 837
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_336(void* self);

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000346 RID: 838 RVA: 0x000053FE File Offset: 0x000043FE
		// (set) Token: 0x06000347 RID: 839 RVA: 0x0000540B File Offset: 0x0000440B
		public long PersonaId
		{
			get
			{
				return LobbyEntrant._EASharpBinding_336(this.mSelf);
			}
			set
			{
				LobbyEntrant._EASharpBinding_335(this.mSelf, value);
			}
		}

		// Token: 0x06000348 RID: 840
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_337(void* self, int val);

		// Token: 0x06000349 RID: 841
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_338(void* self);

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00005419 File Offset: 0x00004419
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00005426 File Offset: 0x00004426
		public int GridIndex
		{
			get
			{
				return LobbyEntrant._EASharpBinding_338(this.mSelf);
			}
			set
			{
				LobbyEntrant._EASharpBinding_337(this.mSelf, value);
			}
		}

		// Token: 0x0600034C RID: 844
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_339(void* self, int val);

		// Token: 0x0600034D RID: 845
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_340(void* self);

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600034E RID: 846 RVA: 0x00005434 File Offset: 0x00004434
		// (set) Token: 0x0600034F RID: 847 RVA: 0x00005441 File Offset: 0x00004441
		public LobbyEntrantState State
		{
			get
			{
				return (LobbyEntrantState)LobbyEntrant._EASharpBinding_340(this.mSelf);
			}
			set
			{
				LobbyEntrant._EASharpBinding_339(this.mSelf, (int)value);
			}
		}

		// Token: 0x06000350 RID: 848
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_341(void* self, long val);

		// Token: 0x06000351 RID: 849
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_342(void* self);

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000352 RID: 850 RVA: 0x0000544F File Offset: 0x0000444F
		// (set) Token: 0x06000353 RID: 851 RVA: 0x0000545C File Offset: 0x0000445C
		public long LobbyId
		{
			get
			{
				return LobbyEntrant._EASharpBinding_342(this.mSelf);
			}
			set
			{
				LobbyEntrant._EASharpBinding_341(this.mSelf, value);
			}
		}
	}
}

using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000046 RID: 70
	[ExportOnlyCreate(false)]
	public class InternalOpponentManager : ExposedCommonBase
	{
		// Token: 0x060002FE RID: 766 RVA: 0x00004F9C File Offset: 0x00003F9C
		public unsafe static InternalOpponentManager CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalOpponentManager(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060002FF RID: 767 RVA: 0x00004FBF File Offset: 0x00003FBF
		public unsafe InternalOpponentManager(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000300 RID: 768 RVA: 0x00004FC9 File Offset: 0x00003FC9
		protected internal InternalOpponentManager(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000301 RID: 769 RVA: 0x00004FD2 File Offset: 0x00003FD2
		protected internal unsafe InternalOpponentManager(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000302 RID: 770
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_310(void* owner);

		// Token: 0x06000303 RID: 771 RVA: 0x00004FDC File Offset: 0x00003FDC
		public unsafe InternalOpponentManager(void* owner) : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalOpponentManager._EASharpBinding_310(owner);
		}

		// Token: 0x06000304 RID: 772
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_311(void* _ThisPtr);

		// Token: 0x06000305 RID: 773 RVA: 0x00005004 File Offset: 0x00004004
		~InternalOpponentManager()
		{
			InternalOpponentManager._EASharpBinding_311(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000306 RID: 774
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_312(void* _ThisPtr, uint localizationHash, sbyte* preset);

		// Token: 0x06000307 RID: 775 RVA: 0x00005040 File Offset: 0x00004040
		public unsafe InternalLocalArtificalOpponent CreateLocalAI(uint localizationHash, string preset)
		{
			int byteCount = Encoding.ASCII.GetByteCount(preset);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(preset, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return InternalLocalArtificalOpponent.CreateInitUnowned(InternalOpponentManager._EASharpBinding_312(this.mSelf, localizationHash, (sbyte*)ptr));
			}
		}

		// Token: 0x06000308 RID: 776
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_313(void* _ThisPtr);

		// Token: 0x06000309 RID: 777 RVA: 0x000050AB File Offset: 0x000040AB
		public void RemoveFlaggedOpponents()
		{
			InternalOpponentManager._EASharpBinding_313(this.mSelf);
		}

		// Token: 0x0600030A RID: 778
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_314(void* _ThisPtr);

		// Token: 0x0600030B RID: 779 RVA: 0x000050B8 File Offset: 0x000040B8
		public void RemoveAllOpponents()
		{
			InternalOpponentManager._EASharpBinding_314(this.mSelf);
		}

		// Token: 0x0600030C RID: 780
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_315(void* _ThisPtr);

		// Token: 0x0600030D RID: 781 RVA: 0x000050C5 File Offset: 0x000040C5
		public void RemoveAllOpponentsExceptLocalPlayer()
		{
			InternalOpponentManager._EASharpBinding_315(this.mSelf);
		}

		// Token: 0x0600030E RID: 782
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_316(void* _ThisPtr, void* opponent);

		// Token: 0x0600030F RID: 783 RVA: 0x000050D2 File Offset: 0x000040D2
		public void Remove(InternalOpponent opponent)
		{
			InternalOpponentManager._EASharpBinding_316(this.mSelf, object.ReferenceEquals(opponent, null) ? null : opponent._GetRaw());
		}

		// Token: 0x06000310 RID: 784
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_317(void* _ThisPtr);

		// Token: 0x06000311 RID: 785 RVA: 0x000050F2 File Offset: 0x000040F2
		public void Reset()
		{
			InternalOpponentManager._EASharpBinding_317(this.mSelf);
		}

		// Token: 0x06000312 RID: 786
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_318(void* _ThisPtr, object opponentManager);

		// Token: 0x06000313 RID: 787 RVA: 0x000050FF File Offset: 0x000040FF
		public void Reset(OpponentManager opponentManager)
		{
			InternalOpponentManager._EASharpBinding_318(this.mSelf, opponentManager);
		}

		// Token: 0x06000314 RID: 788
		[DllImport("<internal>")]
		private static extern void _EASharpBinding_319();

		// Token: 0x06000315 RID: 789 RVA: 0x0000510D File Offset: 0x0000410D
		public static void ResetNextOfflineId()
		{
			InternalOpponentManager._EASharpBinding_319();
		}
	}
}

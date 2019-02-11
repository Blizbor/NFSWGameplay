using System;
using System.Runtime.InteropServices;
using System.Text;
using EA.WorldMap;
using EASharp;
using UMath;
using Victory.DataLayer.Serialization.Event;

namespace GameCore
{
	// Token: 0x02000045 RID: 69
	[ExportOnlyCreate(false)]
	public class InternalOpponent : ExposedCommonBase
	{
		// Token: 0x060002AC RID: 684 RVA: 0x00004B94 File Offset: 0x00003B94
		public unsafe static InternalOpponent CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalOpponent(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x060002AD RID: 685 RVA: 0x00004BB7 File Offset: 0x00003BB7
		public unsafe InternalOpponent(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00004BC1 File Offset: 0x00003BC1
		protected internal InternalOpponent(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x060002AF RID: 687 RVA: 0x00004BCA File Offset: 0x00003BCA
		protected internal unsafe InternalOpponent(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x060002B0 RID: 688
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_270(void* _ThisPtr);

		// Token: 0x060002B1 RID: 689 RVA: 0x00004BD4 File Offset: 0x00003BD4
		~InternalOpponent()
		{
			InternalOpponent._EASharpBinding_270(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x060002B2 RID: 690
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_271(void* _ThisPtr, bool isDragEvent);

		// Token: 0x060002B3 RID: 691 RVA: 0x00004C10 File Offset: 0x00003C10
		public virtual void Prepare(bool isDragEvent)
		{
			InternalOpponent._EASharpBinding_271(this.mSelf, isDragEvent);
		}

		// Token: 0x060002B4 RID: 692
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_272(void* _ThisPtr);

		// Token: 0x060002B5 RID: 693 RVA: 0x00004C1E File Offset: 0x00003C1E
		public virtual void Cleanup()
		{
			InternalOpponent._EASharpBinding_272(this.mSelf);
		}

		// Token: 0x060002B6 RID: 694
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_273(void* _ThisPtr);

		// Token: 0x060002B7 RID: 695 RVA: 0x00004C2B File Offset: 0x00003C2B
		public virtual void Disconnect()
		{
			InternalOpponent._EASharpBinding_273(this.mSelf);
		}

		// Token: 0x060002B8 RID: 696
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_274(void* _ThisPtr);

		// Token: 0x060002B9 RID: 697 RVA: 0x00004C38 File Offset: 0x00003C38
		public virtual void ClearConnectionStatus()
		{
			InternalOpponent._EASharpBinding_274(this.mSelf);
		}

		// Token: 0x060002BA RID: 698
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_275(void* _ThisPtr, float skill);

		// Token: 0x060002BB RID: 699 RVA: 0x00004C45 File Offset: 0x00003C45
		public virtual void SetBaseSkill(float skill)
		{
			InternalOpponent._EASharpBinding_275(this.mSelf, skill);
		}

		// Token: 0x060002BC RID: 700
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_276(void* _ThisPtr);

		// Token: 0x060002BD RID: 701 RVA: 0x00004C54 File Offset: 0x00003C54
		public virtual uint Id()
		{
			return InternalOpponent._EASharpBinding_276(this.mSelf);
		}

		// Token: 0x060002BE RID: 702
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_277(void* _ThisPtr, uint opponentId);

		// Token: 0x060002BF RID: 703 RVA: 0x00004C6E File Offset: 0x00003C6E
		public virtual void SetId(uint opponentId)
		{
			InternalOpponent._EASharpBinding_277(this.mSelf, opponentId);
		}

		// Token: 0x060002C0 RID: 704
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_278(void* _ThisPtr);

		// Token: 0x060002C1 RID: 705 RVA: 0x00004C7C File Offset: 0x00003C7C
		public virtual long GetPersonaId()
		{
			return InternalOpponent._EASharpBinding_278(this.mSelf);
		}

		// Token: 0x060002C2 RID: 706
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_279(void* _ThisPtr, long personaId);

		// Token: 0x060002C3 RID: 707 RVA: 0x00004C96 File Offset: 0x00003C96
		public virtual void SetPersonaId(long personaId)
		{
			InternalOpponent._EASharpBinding_279(this.mSelf, personaId);
		}

		// Token: 0x060002C4 RID: 708
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_280(void* _ThisPtr, int status);

		// Token: 0x060002C5 RID: 709 RVA: 0x00004CA4 File Offset: 0x00003CA4
		public virtual void SetStatus(OpponentStatus status)
		{
			InternalOpponent._EASharpBinding_280(this.mSelf, (int)status);
		}

		// Token: 0x060002C6 RID: 710
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_281(void* _ThisPtr, int status);

		// Token: 0x060002C7 RID: 711 RVA: 0x00004CB2 File Offset: 0x00003CB2
		public virtual void ClearStatus(OpponentStatus status)
		{
			InternalOpponent._EASharpBinding_281(this.mSelf, (int)status);
		}

		// Token: 0x060002C8 RID: 712
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_282(void* _ThisPtr, int status);

		// Token: 0x060002C9 RID: 713 RVA: 0x00004CC0 File Offset: 0x00003CC0
		public virtual bool IsStatus(OpponentStatus status)
		{
			return InternalOpponent._EASharpBinding_282(this.mSelf, (int)status);
		}

		// Token: 0x060002CA RID: 714
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_283(void* _ThisPtr);

		// Token: 0x060002CB RID: 715 RVA: 0x00004CDC File Offset: 0x00003CDC
		public virtual string GetOpponentName()
		{
			return InternalUtil.ConvertFromCString(InternalOpponent._EASharpBinding_283(this.mSelf));
		}

		// Token: 0x060002CC RID: 716
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_284(void* _ThisPtr, sbyte* opponentName);

		// Token: 0x060002CD RID: 717 RVA: 0x00004CFC File Offset: 0x00003CFC
		public unsafe virtual void SetOpponentName(string opponentName)
		{
			int byteCount = Encoding.ASCII.GetByteCount(opponentName);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(opponentName, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				InternalOpponent._EASharpBinding_284(this.mSelf, (sbyte*)ptr);
			}
		}

		// Token: 0x060002CE RID: 718
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_285(void* _ThisPtr);

		// Token: 0x060002CF RID: 719 RVA: 0x00004D5C File Offset: 0x00003D5C
		public virtual int GetGridIndex()
		{
			return InternalOpponent._EASharpBinding_285(this.mSelf);
		}

		// Token: 0x060002D0 RID: 720
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_286(void* _ThisPtr, int gridIndex);

		// Token: 0x060002D1 RID: 721 RVA: 0x00004D76 File Offset: 0x00003D76
		public virtual void SetGridIndex(int gridIndex)
		{
			InternalOpponent._EASharpBinding_286(this.mSelf, gridIndex);
		}

		// Token: 0x060002D2 RID: 722
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_287(void* _ThisPtr);

		// Token: 0x060002D3 RID: 723 RVA: 0x00004D84 File Offset: 0x00003D84
		public virtual float GetFractionEventComplete()
		{
			return InternalOpponent._EASharpBinding_287(this.mSelf);
		}

		// Token: 0x060002D4 RID: 724
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_288(void* _ThisPtr, float fractionComplete);

		// Token: 0x060002D5 RID: 725 RVA: 0x00004D9E File Offset: 0x00003D9E
		public virtual void SetFractionEventComplete(float fractionComplete)
		{
			InternalOpponent._EASharpBinding_288(this.mSelf, fractionComplete);
		}

		// Token: 0x060002D6 RID: 726
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_289(void* _ThisPtr);

		// Token: 0x060002D7 RID: 727 RVA: 0x00004DAC File Offset: 0x00003DAC
		public virtual eWMFeatureType GetWorldMapFeatureType()
		{
			return (eWMFeatureType)InternalOpponent._EASharpBinding_289(this.mSelf);
		}

		// Token: 0x060002D8 RID: 728
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_290(void* _ThisPtr, uint channel, uint type);

		// Token: 0x060002D9 RID: 729 RVA: 0x00004DC6 File Offset: 0x00003DC6
		public virtual void LoadBehavior(uint channel, uint type)
		{
			InternalOpponent._EASharpBinding_290(this.mSelf, channel, type);
		}

		// Token: 0x060002DA RID: 730
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_291(void* _ThisPtr, uint channel);

		// Token: 0x060002DB RID: 731 RVA: 0x00004DD5 File Offset: 0x00003DD5
		public virtual void ReleaseBehavior(uint channel)
		{
			InternalOpponent._EASharpBinding_291(this.mSelf, channel);
		}

		// Token: 0x060002DC RID: 732
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_292(void* _ThisPtr, float chance);

		// Token: 0x060002DD RID: 733 RVA: 0x00004DE3 File Offset: 0x00003DE3
		public virtual void SetBaseShortcutTakingChance(float chance)
		{
			InternalOpponent._EASharpBinding_292(this.mSelf, chance);
		}

		// Token: 0x060002DE RID: 734
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_293(void* _ThisPtr, float chanceIncrement);

		// Token: 0x060002DF RID: 735 RVA: 0x00004DF1 File Offset: 0x00003DF1
		public virtual void SetRankingBiasShortcutChance(float chanceIncrement)
		{
			InternalOpponent._EASharpBinding_293(this.mSelf, chanceIncrement);
		}

		// Token: 0x060002E0 RID: 736
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_294(void* _ThisPtr, int rank);

		// Token: 0x060002E1 RID: 737 RVA: 0x00004DFF File Offset: 0x00003DFF
		public void SetRank(int rank)
		{
			InternalOpponent._EASharpBinding_294(this.mSelf, rank);
		}

		// Token: 0x060002E2 RID: 738
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_295(void* _ThisPtr);

		// Token: 0x060002E3 RID: 739 RVA: 0x00004E10 File Offset: 0x00003E10
		public virtual int GetRank()
		{
			return InternalOpponent._EASharpBinding_295(this.mSelf);
		}

		// Token: 0x060002E4 RID: 740
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_296(void* _ThisPtr, int reason);

		// Token: 0x060002E5 RID: 741 RVA: 0x00004E2A File Offset: 0x00003E2A
		public void SetFinishReason(FinishReason reason)
		{
			InternalOpponent._EASharpBinding_296(this.mSelf, (int)reason);
		}

		// Token: 0x060002E6 RID: 742
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_297(void* _ThisPtr);

		// Token: 0x060002E7 RID: 743 RVA: 0x00004E38 File Offset: 0x00003E38
		public virtual FinishReason GetFinishReason()
		{
			return (FinishReason)InternalOpponent._EASharpBinding_297(this.mSelf);
		}

		// Token: 0x060002E8 RID: 744
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_298(void* _ThisPtr);

		// Token: 0x060002E9 RID: 745 RVA: 0x00004E54 File Offset: 0x00003E54
		public virtual uint GetIconIndex()
		{
			return InternalOpponent._EASharpBinding_298(this.mSelf);
		}

		// Token: 0x060002EA RID: 746
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_299(void* _ThisPtr);

		// Token: 0x060002EB RID: 747 RVA: 0x00004E70 File Offset: 0x00003E70
		public virtual uint GetLevel()
		{
			return InternalOpponent._EASharpBinding_299(this.mSelf);
		}

		// Token: 0x060002EC RID: 748
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_300(void* _ThisPtr);

		// Token: 0x060002ED RID: 749 RVA: 0x00004E8C File Offset: 0x00003E8C
		public virtual float GetHeat()
		{
			return InternalOpponent._EASharpBinding_300(this.mSelf);
		}

		// Token: 0x060002EE RID: 750
		[DllImport("<internal>")]
		private unsafe static extern sbyte* _EASharpBinding_301(void* _ThisPtr);

		// Token: 0x060002EF RID: 751 RVA: 0x00004EA8 File Offset: 0x00003EA8
		public virtual string GetMotto()
		{
			return InternalUtil.ConvertFromCString(InternalOpponent._EASharpBinding_301(this.mSelf));
		}

		// Token: 0x060002F0 RID: 752
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_302(void* _ThisPtr, void* position, void* direction);

		// Token: 0x060002F1 RID: 753 RVA: 0x00004EC7 File Offset: 0x00003EC7
		public void SetNextPathPoint(Vector3 position, Vector3 direction)
		{
			InternalOpponent._EASharpBinding_302(this.mSelf, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw());
		}

		// Token: 0x060002F2 RID: 754
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_303(void* _ThisPtr);

		// Token: 0x060002F3 RID: 755 RVA: 0x00004EFC File Offset: 0x00003EFC
		public virtual Vehicle GetWrappedVehicle()
		{
			return Vehicle.CreateInitUnowned(InternalOpponent._EASharpBinding_303(this.mSelf));
		}

		// Token: 0x060002F4 RID: 756
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_304(void* _ThisPtr);

		// Token: 0x060002F5 RID: 757 RVA: 0x00004F1C File Offset: 0x00003F1C
		public virtual int GetNumOpponentsCollidedWith()
		{
			return InternalOpponent._EASharpBinding_304(this.mSelf);
		}

		// Token: 0x060002F6 RID: 758
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_305(void* _ThisPtr, void* position, void* direction);

		// Token: 0x060002F7 RID: 759 RVA: 0x00004F36 File Offset: 0x00003F36
		public virtual void TeleportTo(Vector3 position, Vector3 direction)
		{
			InternalOpponent._EASharpBinding_305(this.mSelf, object.ReferenceEquals(position, null) ? null : position._GetRaw(), object.ReferenceEquals(direction, null) ? null : direction._GetRaw());
		}

		// Token: 0x060002F8 RID: 760
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_306(void* _ThisPtr);

		// Token: 0x060002F9 RID: 761 RVA: 0x00004F6C File Offset: 0x00003F6C
		public virtual uint GetWorldMapFeatureID()
		{
			return InternalOpponent._EASharpBinding_306(this.mSelf);
		}

		// Token: 0x060002FA RID: 762
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_307(void* _ThisPtr, uint featureID);

		// Token: 0x060002FB RID: 763 RVA: 0x00004F86 File Offset: 0x00003F86
		public virtual void SetWorldMapFeatureID(uint featureID)
		{
			InternalOpponent._EASharpBinding_307(this.mSelf, featureID);
		}

		// Token: 0x060002FC RID: 764
		[DllImport("<internal>")]
		private static extern int _EASharpBinding_309();

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x060002FD RID: 765 RVA: 0x00004F94 File Offset: 0x00003F94
		public static int NOT_IN_GRID
		{
			get
			{
				return InternalOpponent._EASharpBinding_309();
			}
		}
	}
}

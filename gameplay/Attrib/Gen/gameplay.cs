using System;
using System.Text;
using EA.WorldMap;
using EASharp;
using GameCore;
using GameCore.Collision;
using GameCore.Math;
using PerformanceUpgrades;
using Victory.Data.Objects.Customization;
using Victory.DataLayer.Serialization;

namespace Attrib.Gen
{
	// Token: 0x02000116 RID: 278
	public class gameplay : IDisposable
	{
		// Token: 0x06000EF8 RID: 3832 RVA: 0x00011D77 File Offset: 0x00010D77
		public gameplay(string collectionName) : this(InternalCollection.Hash(collectionName))
		{
		}

		// Token: 0x06000EF9 RID: 3833 RVA: 0x00011D85 File Offset: 0x00010D85
		public gameplay(uint collectionKey)
		{
			this.instance = new InternalCollection(1558879558u, collectionKey);
			if (!this.instance.IsValid())
			{
				this.instance.Load();
			}
		}

		// Token: 0x06000EFA RID: 3834 RVA: 0x00011DB6 File Offset: 0x00010DB6
		public gameplay(InternalCollection instance)
		{
			this.instance = instance;
		}

		// Token: 0x06000EFB RID: 3835 RVA: 0x00011DC5 File Offset: 0x00010DC5
		public void Modify(uint dynamicCollectionKey)
		{
			this.Modify(dynamicCollectionKey, 0u);
		}

		// Token: 0x06000EFC RID: 3836 RVA: 0x00011DCF File Offset: 0x00010DCF
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			this.instance.Modify(dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x06000EFD RID: 3837 RVA: 0x00011DDE File Offset: 0x00010DDE
		public uint GetClass()
		{
			return this.instance.GetClass();
		}

		// Token: 0x06000EFE RID: 3838 RVA: 0x00011DEB File Offset: 0x00010DEB
		public uint GetCollection()
		{
			return this.instance.GetCollection();
		}

		// Token: 0x06000EFF RID: 3839 RVA: 0x00011DF8 File Offset: 0x00010DF8
		public uint GetParent()
		{
			return this.instance.GetParent();
		}

		// Token: 0x06000F00 RID: 3840 RVA: 0x00011E05 File Offset: 0x00010E05
		public void SetParent(uint parent)
		{
			this.instance.SetParent(parent);
		}

		// Token: 0x06000F01 RID: 3841 RVA: 0x00011E13 File Offset: 0x00010E13
		public bool IsValid()
		{
			return this.instance.IsValid();
		}

		// Token: 0x06000F02 RID: 3842 RVA: 0x00011E20 File Offset: 0x00010E20
		public bool IsDynamic()
		{
			return this.instance.IsDynamic();
		}

		// Token: 0x06000F03 RID: 3843 RVA: 0x00011E2D File Offset: 0x00010E2D
		public bool Contains(uint attributeKey)
		{
			return this.instance.Contains(attributeKey);
		}

		// Token: 0x06000F04 RID: 3844 RVA: 0x00011E3B File Offset: 0x00010E3B
		public uint LocalAttribCount()
		{
			return this.instance.LocalAttribCount();
		}

		// Token: 0x06000F05 RID: 3845 RVA: 0x00011E48 File Offset: 0x00010E48
		public bool Add(uint attributeKey, uint count)
		{
			return this.instance.Add(attributeKey, count);
		}

		// Token: 0x06000F06 RID: 3846 RVA: 0x00011E57 File Offset: 0x00010E57
		public bool Remove(uint attributeKey)
		{
			return this.instance.Remove(attributeKey);
		}

		// Token: 0x06000F07 RID: 3847 RVA: 0x00011E65 File Offset: 0x00010E65
		public void Unmodify()
		{
			this.instance.Unmodify();
		}

		// Token: 0x06000F08 RID: 3848 RVA: 0x00011E72 File Offset: 0x00010E72
		public uint GenerateUniqueKey(string name)
		{
			return this.instance.GenerateUniqueKey(name);
		}

		// Token: 0x06000F09 RID: 3849 RVA: 0x00011E80 File Offset: 0x00010E80
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			this.instance.Reserve(spaceForAdditionalAttributes);
		}

		// Token: 0x06000F0A RID: 3850 RVA: 0x00011E8E File Offset: 0x00010E8E
		public void LoadVaultSync()
		{
			this.instance.LoadSync();
		}

		// Token: 0x06000F0B RID: 3851 RVA: 0x00011E9B File Offset: 0x00010E9B
		public bool IsDerivedFrom(uint key)
		{
			return this.instance.IsDerivedFrom(key);
		}

		// Token: 0x06000F0C RID: 3852 RVA: 0x00011EA9 File Offset: 0x00010EA9
		public GameCore.Attribute Get(uint attributeKey)
		{
			return this.instance.Get(attributeKey);
		}

		// Token: 0x06000F0D RID: 3853 RVA: 0x00011EB7 File Offset: 0x00010EB7
		public GameCore.Attribute GetOrClone(uint attributeKey)
		{
			return this.instance.GetOrClone(attributeKey);
		}

		// Token: 0x06000F0E RID: 3854 RVA: 0x00011EC5 File Offset: 0x00010EC5
		public InternalCollection GetInternalCollection()
		{
			return this.instance;
		}

		// Token: 0x06000F0F RID: 3855 RVA: 0x00011ECD File Offset: 0x00010ECD
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000F10 RID: 3856 RVA: 0x00011EDC File Offset: 0x00010EDC
		public void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Unmodify();
				this.isDisposed = true;
			}
		}

		// Token: 0x06000F11 RID: 3857 RVA: 0x00011EF8 File Offset: 0x00010EF8
		public unsafe float Acceleration()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2732768190u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F12 RID: 3858 RVA: 0x00011F24 File Offset: 0x00010F24
		public unsafe bool Acceleration(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2732768190u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F13 RID: 3859 RVA: 0x00011F58 File Offset: 0x00010F58
		public unsafe ushort AIShortcutPct()
		{
			ushort* attributePointer = (ushort*)this.instance.GetAttributePointer(89466197u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F14 RID: 3860 RVA: 0x00011F80 File Offset: 0x00010F80
		public unsafe bool AIShortcutPct(ushort data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(89466197u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F15 RID: 3861 RVA: 0x00011FB4 File Offset: 0x00010FB4
		public unsafe short AIShortcutPositionBias()
		{
			short* attributePointer = (short*)this.instance.GetAttributePointer(1875267950u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F16 RID: 3862 RVA: 0x00011FDC File Offset: 0x00010FDC
		public unsafe bool AIShortcutPositionBias(short data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1875267950u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F17 RID: 3863 RVA: 0x00012010 File Offset: 0x00011010
		public unsafe bool AIUsePowerUps()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(349570620u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000F18 RID: 3864 RVA: 0x00012038 File Offset: 0x00011038
		public unsafe bool AIUsePowerUps(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(349570620u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F19 RID: 3865 RVA: 0x0001206C File Offset: 0x0001106C
		public unsafe LocalizationHash AmountAlternateLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(1087815741u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F1A RID: 3866 RVA: 0x0001209C File Offset: 0x0001109C
		public bool AmountAlternateLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1087815741u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F1B RID: 3867 RVA: 0x000120D4 File Offset: 0x000110D4
		public unsafe LocalizationHash AmountLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(1470855980u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F1C RID: 3868 RVA: 0x00012104 File Offset: 0x00011104
		public bool AmountLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1470855980u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F1D RID: 3869 RVA: 0x0001213C File Offset: 0x0001113C
		public unsafe string AreaName()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(2576684938u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F1E RID: 3870 RVA: 0x0001216C File Offset: 0x0001116C
		public unsafe bool AreaName(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2576684938u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F1F RID: 3871 RVA: 0x000121E8 File Offset: 0x000111E8
		public unsafe IndexedBarrierName Barriers(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3796169323u, index);
			return new IndexedBarrierName(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F20 RID: 3872 RVA: 0x00012218 File Offset: 0x00011218
		public bool Barriers(IndexedBarrierName data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3796169323u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F21 RID: 3873 RVA: 0x0001224D File Offset: 0x0001124D
		public uint Num_Barriers()
		{
			return this.Get(3796169323u).GetLength();
		}

		// Token: 0x06000F22 RID: 3874 RVA: 0x00012260 File Offset: 0x00011260
		public unsafe BehaviorSlot BehaviorMap(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3629572398u, index);
			return new BehaviorSlot(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F23 RID: 3875 RVA: 0x00012290 File Offset: 0x00011290
		public bool BehaviorMap(BehaviorSlot data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3629572398u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F24 RID: 3876 RVA: 0x000122C5 File Offset: 0x000112C5
		public uint Num_BehaviorMap()
		{
			return this.Get(3629572398u).GetLength();
		}

		// Token: 0x06000F25 RID: 3877 RVA: 0x000122D8 File Offset: 0x000112D8
		public unsafe BlackBoardSlot BlackBoardMap(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2428409892u, index);
			return new BlackBoardSlot(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F26 RID: 3878 RVA: 0x00012308 File Offset: 0x00011308
		public bool BlackBoardMap(BlackBoardSlot data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2428409892u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F27 RID: 3879 RVA: 0x0001233D File Offset: 0x0001133D
		public uint Num_BlackBoardMap()
		{
			return this.Get(2428409892u).GetLength();
		}

		// Token: 0x06000F28 RID: 3880 RVA: 0x00012350 File Offset: 0x00011350
		public unsafe int Boost()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(3268040941u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F29 RID: 3881 RVA: 0x00012378 File Offset: 0x00011378
		public unsafe bool Boost(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3268040941u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F2A RID: 3882 RVA: 0x000123AC File Offset: 0x000113AC
		public unsafe int Bounty()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2384004295u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F2B RID: 3883 RVA: 0x000123D4 File Offset: 0x000113D4
		public unsafe bool Bounty(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2384004295u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F2C RID: 3884 RVA: 0x00012408 File Offset: 0x00011408
		public unsafe GCollectionKey CameraBounds()
		{
			void* attributePointer = this.instance.GetAttributePointer(3276707395u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F2D RID: 3885 RVA: 0x00012438 File Offset: 0x00011438
		public bool CameraBounds(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3276707395u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F2E RID: 3886 RVA: 0x00012470 File Offset: 0x00011470
		public unsafe GCollectionKey CameraModelMarker()
		{
			void* attributePointer = this.instance.GetAttributePointer(1390179372u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F2F RID: 3887 RVA: 0x000124A0 File Offset: 0x000114A0
		public bool CameraModelMarker(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1390179372u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F30 RID: 3888 RVA: 0x000124D8 File Offset: 0x000114D8
		public unsafe GCollectionKey CarClass()
		{
			void* attributePointer = this.instance.GetAttributePointer(151128504u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F31 RID: 3889 RVA: 0x00012508 File Offset: 0x00011508
		public bool CarClass(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(151128504u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F32 RID: 3890 RVA: 0x00012540 File Offset: 0x00011540
		public unsafe short CarClassMaxRating()
		{
			short* attributePointer = (short*)this.instance.GetAttributePointer(709025899u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F33 RID: 3891 RVA: 0x00012568 File Offset: 0x00011568
		public unsafe bool CarClassMaxRating(short data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(709025899u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F34 RID: 3892 RVA: 0x0001259C File Offset: 0x0001159C
		public unsafe short CarClassMinRating()
		{
			short* attributePointer = (short*)this.instance.GetAttributePointer(1536432172u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F35 RID: 3893 RVA: 0x000125C4 File Offset: 0x000115C4
		public unsafe bool CarClassMinRating(short data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1536432172u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F36 RID: 3894 RVA: 0x000125F8 File Offset: 0x000115F8
		public unsafe sbyte CatchUpMinRank()
		{
			sbyte* attributePointer = (sbyte*)this.instance.GetAttributePointer(767064605u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F37 RID: 3895 RVA: 0x00012620 File Offset: 0x00011620
		public unsafe bool CatchUpMinRank(sbyte data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(767064605u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F38 RID: 3896 RVA: 0x00012654 File Offset: 0x00011654
		public unsafe uint Category()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(2497542340u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000F39 RID: 3897 RVA: 0x0001267C File Offset: 0x0001167C
		public unsafe bool Category(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2497542340u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F3A RID: 3898 RVA: 0x000126B0 File Offset: 0x000116B0
		public unsafe LocalizationHash CategoryLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(4121058375u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F3B RID: 3899 RVA: 0x000126E0 File Offset: 0x000116E0
		public bool CategoryLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4121058375u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F3C RID: 3900 RVA: 0x00012718 File Offset: 0x00011718
		public unsafe GCollectionKey Checkpoints(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(415344102u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F3D RID: 3901 RVA: 0x00012748 File Offset: 0x00011748
		public bool Checkpoints(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(415344102u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F3E RID: 3902 RVA: 0x0001277D File Offset: 0x0001177D
		public uint Num_Checkpoints()
		{
			return this.Get(415344102u).GetLength();
		}

		// Token: 0x06000F3F RID: 3903 RVA: 0x00012790 File Offset: 0x00011790
		public unsafe GCollectionKey Children(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2439908984u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F40 RID: 3904 RVA: 0x000127C0 File Offset: 0x000117C0
		public bool Children(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2439908984u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F41 RID: 3905 RVA: 0x000127F5 File Offset: 0x000117F5
		public uint Num_Children()
		{
			return this.Get(2439908984u).GetLength();
		}

		// Token: 0x06000F42 RID: 3906 RVA: 0x00012808 File Offset: 0x00011808
		public unsafe int Client_CarCache_Age_limit()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(75053547u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F43 RID: 3907 RVA: 0x00012830 File Offset: 0x00011830
		public unsafe bool Client_CarCache_Age_limit(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(75053547u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F44 RID: 3908 RVA: 0x00012864 File Offset: 0x00011864
		public unsafe int Client_CarCache_Max_size()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2565310949u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F45 RID: 3909 RVA: 0x0001288C File Offset: 0x0001188C
		public unsafe bool Client_CarCache_Max_size(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2565310949u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F46 RID: 3910 RVA: 0x000128C0 File Offset: 0x000118C0
		public unsafe GCollectionKey CoinRegion()
		{
			void* attributePointer = this.instance.GetAttributePointer(3494794592u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F47 RID: 3911 RVA: 0x000128F0 File Offset: 0x000118F0
		public bool CoinRegion(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3494794592u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F48 RID: 3912 RVA: 0x00012928 File Offset: 0x00011928
		public unsafe GCollectionKey Coins(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(479779663u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F49 RID: 3913 RVA: 0x00012958 File Offset: 0x00011958
		public bool Coins(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(479779663u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F4A RID: 3914 RVA: 0x0001298D File Offset: 0x0001198D
		public uint Num_Coins()
		{
			return this.Get(479779663u).GetLength();
		}

		// Token: 0x06000F4B RID: 3915 RVA: 0x000129A0 File Offset: 0x000119A0
		public unsafe string CollectionName()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(2627848441u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F4C RID: 3916 RVA: 0x000129D0 File Offset: 0x000119D0
		public unsafe bool CollectionName(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2627848441u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x00012A4C File Offset: 0x00011A4C
		public unsafe TriggerType CollisionType()
		{
			TriggerType* attributePointer = (TriggerType*)this.instance.GetAttributePointer(2124796506u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return TriggerType.Unknown;
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x00012A74 File Offset: 0x00011A74
		public unsafe bool CollisionType(TriggerType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2124796506u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x00012AA8 File Offset: 0x00011AA8
		public unsafe uint Color()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(3267535198u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000F50 RID: 3920 RVA: 0x00012AD0 File Offset: 0x00011AD0
		public unsafe bool Color(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3267535198u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F51 RID: 3921 RVA: 0x00012B04 File Offset: 0x00011B04
		public unsafe GCollectionKey CopSpawnLocation(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3842938542u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F52 RID: 3922 RVA: 0x00012B34 File Offset: 0x00011B34
		public bool CopSpawnLocation(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3842938542u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000F53 RID: 3923 RVA: 0x00012B69 File Offset: 0x00011B69
		public uint Num_CopSpawnLocation()
		{
			return this.Get(3842938542u).GetLength();
		}

		// Token: 0x06000F54 RID: 3924 RVA: 0x00012B7C File Offset: 0x00011B7C
		public unsafe uint Cost()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(3860231145u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000F55 RID: 3925 RVA: 0x00012BA4 File Offset: 0x00011BA4
		public unsafe bool Cost(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3860231145u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F56 RID: 3926 RVA: 0x00012BD8 File Offset: 0x00011BD8
		public unsafe float DelayInterval()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1726045097u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F57 RID: 3927 RVA: 0x00012C04 File Offset: 0x00011C04
		public unsafe bool DelayInterval(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1726045097u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F58 RID: 3928 RVA: 0x00012C38 File Offset: 0x00011C38
		public unsafe float DelayTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(539333446u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F59 RID: 3929 RVA: 0x00012C64 File Offset: 0x00011C64
		public unsafe bool DelayTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(539333446u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F5A RID: 3930 RVA: 0x00012C98 File Offset: 0x00011C98
		public unsafe string Description()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(1985894880u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F5B RID: 3931 RVA: 0x00012CC8 File Offset: 0x00011CC8
		public unsafe bool Description(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1985894880u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F5C RID: 3932 RVA: 0x00012D44 File Offset: 0x00011D44
		public unsafe LocalizationHash DescriptionLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(1556767770u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F5D RID: 3933 RVA: 0x00012D74 File Offset: 0x00011D74
		public bool DescriptionLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1556767770u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F5E RID: 3934 RVA: 0x00012DAC File Offset: 0x00011DAC
		public unsafe int DifficultyLevel()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2292704190u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F5F RID: 3935 RVA: 0x00012DD4 File Offset: 0x00011DD4
		public unsafe bool DifficultyLevel(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2292704190u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F60 RID: 3936 RVA: 0x00012E08 File Offset: 0x00011E08
		public unsafe GameCore.Math.Vector3 Dimensions()
		{
			void* attributePointer = this.instance.GetAttributePointer(1839079853u, 0u);
			return new GameCore.Math.Vector3(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F61 RID: 3937 RVA: 0x00012E38 File Offset: 0x00011E38
		public bool Dimensions(GameCore.Math.Vector3 data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1839079853u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F62 RID: 3938 RVA: 0x00012E70 File Offset: 0x00011E70
		public unsafe int DisconnectDelayInMilliseconds()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(607974850u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000F63 RID: 3939 RVA: 0x00012E98 File Offset: 0x00011E98
		public unsafe bool DisconnectDelayInMilliseconds(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(607974850u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F64 RID: 3940 RVA: 0x00012ECC File Offset: 0x00011ECC
		public unsafe float Distance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(697754833u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F65 RID: 3941 RVA: 0x00012EF8 File Offset: 0x00011EF8
		public unsafe bool Distance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(697754833u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F66 RID: 3942 RVA: 0x00012F2C File Offset: 0x00011F2C
		public unsafe bool DragModeEnabled()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(1652914547u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000F67 RID: 3943 RVA: 0x00012F54 File Offset: 0x00011F54
		public unsafe bool DragModeEnabled(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1652914547u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F68 RID: 3944 RVA: 0x00012F88 File Offset: 0x00011F88
		public unsafe bool DragModeExclusive()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3566385200u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000F69 RID: 3945 RVA: 0x00012FB0 File Offset: 0x00011FB0
		public unsafe bool DragModeExclusive(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3566385200u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F6A RID: 3946 RVA: 0x00012FE4 File Offset: 0x00011FE4
		public unsafe StringKey EffectHash()
		{
			void* attributePointer = this.instance.GetAttributePointer(2630964193u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F6B RID: 3947 RVA: 0x00013014 File Offset: 0x00012014
		public bool EffectHash(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2630964193u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F6C RID: 3948 RVA: 0x0001304C File Offset: 0x0001204C
		public unsafe long EndDateTime()
		{
			long* attributePointer = (long*)this.instance.GetAttributePointer(2970340876u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0L;
		}

		// Token: 0x06000F6D RID: 3949 RVA: 0x00013078 File Offset: 0x00012078
		public unsafe bool EndDateTime(long data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2970340876u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F6E RID: 3950 RVA: 0x000130AC File Offset: 0x000120AC
		public unsafe float EndTimeInSeconds()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4112295759u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F6F RID: 3951 RVA: 0x000130D8 File Offset: 0x000120D8
		public unsafe bool EndTimeInSeconds(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4112295759u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F70 RID: 3952 RVA: 0x0001310C File Offset: 0x0001210C
		public unsafe GCollectionKey EngageTrigger()
		{
			void* attributePointer = this.instance.GetAttributePointer(1966196428u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F71 RID: 3953 RVA: 0x0001313C File Offset: 0x0001213C
		public bool EngageTrigger(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1966196428u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F72 RID: 3954 RVA: 0x00013174 File Offset: 0x00012174
		public unsafe float EngageTriggerHeight()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(153472802u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F73 RID: 3955 RVA: 0x000131A0 File Offset: 0x000121A0
		public unsafe bool EngageTriggerHeight(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(153472802u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F74 RID: 3956 RVA: 0x000131D4 File Offset: 0x000121D4
		public unsafe GameCore.Math.Vector3 EngageTriggerPosition()
		{
			void* attributePointer = this.instance.GetAttributePointer(3460187031u, 0u);
			return new GameCore.Math.Vector3(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F75 RID: 3957 RVA: 0x00013204 File Offset: 0x00012204
		public bool EngageTriggerPosition(GameCore.Math.Vector3 data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3460187031u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F76 RID: 3958 RVA: 0x0001323C File Offset: 0x0001223C
		public unsafe float EngageTriggerRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(783069415u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F77 RID: 3959 RVA: 0x00013268 File Offset: 0x00012268
		public unsafe bool EngageTriggerRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(783069415u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F78 RID: 3960 RVA: 0x0001329C File Offset: 0x0001229C
		public unsafe LocalizationHash EventCategoryLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(3902931660u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F79 RID: 3961 RVA: 0x000132CC File Offset: 0x000122CC
		public bool EventCategoryLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3902931660u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F7A RID: 3962 RVA: 0x00013304 File Offset: 0x00012304
		public unsafe StringKey EventFlow()
		{
			void* attributePointer = this.instance.GetAttributePointer(2332729963u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F7B RID: 3963 RVA: 0x00013334 File Offset: 0x00012334
		public bool EventFlow(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2332729963u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F7C RID: 3964 RVA: 0x0001336C File Offset: 0x0001236C
		public unsafe EventType EventIconType()
		{
			EventType* attributePointer = (EventType*)this.instance.GetAttributePointer(258723297u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return EventType.kEventType_Unknown;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00013394 File Offset: 0x00012394
		public unsafe bool EventIconType(EventType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(258723297u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F7E RID: 3966 RVA: 0x000133C8 File Offset: 0x000123C8
		public unsafe uint EventId()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(3449837213u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000F7F RID: 3967 RVA: 0x000133F0 File Offset: 0x000123F0
		public unsafe bool EventId(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3449837213u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F80 RID: 3968 RVA: 0x00013424 File Offset: 0x00012424
		public unsafe uint EventIdList(uint index)
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(4181943376u, index);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x0001344C File Offset: 0x0001244C
		public unsafe bool EventIdList(uint data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4181943376u);
			return orClone.IsValid() && orClone.Set(index, (void*)(&data));
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x0001347E File Offset: 0x0001247E
		public uint Num_EventIdList()
		{
			return this.Get(4181943376u).GetLength();
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00013490 File Offset: 0x00012490
		public unsafe LocalizationHash EventModeDescriptionLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(2949134660u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F84 RID: 3972 RVA: 0x000134C0 File Offset: 0x000124C0
		public bool EventModeDescriptionLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2949134660u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F85 RID: 3973 RVA: 0x000134F8 File Offset: 0x000124F8
		public unsafe string EventModeIcon()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(2327657113u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F86 RID: 3974 RVA: 0x00013528 File Offset: 0x00012528
		public unsafe bool EventModeIcon(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2327657113u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F87 RID: 3975 RVA: 0x000135A4 File Offset: 0x000125A4
		public unsafe EventMode EventModeId()
		{
			EventMode* attributePointer = (EventMode*)this.instance.GetAttributePointer(1318307048u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return EventMode.kEventMode_Unknown;
		}

		// Token: 0x06000F88 RID: 3976 RVA: 0x000135CC File Offset: 0x000125CC
		public unsafe bool EventModeId(EventMode data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1318307048u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F89 RID: 3977 RVA: 0x00013600 File Offset: 0x00012600
		public unsafe LocalizationHash EventModeLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(2719305118u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F8A RID: 3978 RVA: 0x00013630 File Offset: 0x00012630
		public bool EventModeLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2719305118u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F8B RID: 3979 RVA: 0x00013668 File Offset: 0x00012668
		public unsafe bool EventModeSupportsRaceNow()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(2603284555u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000F8C RID: 3980 RVA: 0x00013690 File Offset: 0x00012690
		public unsafe bool EventModeSupportsRaceNow(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2603284555u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F8D RID: 3981 RVA: 0x000136C4 File Offset: 0x000126C4
		public unsafe GCollectionKey EventObjectives()
		{
			void* attributePointer = this.instance.GetAttributePointer(2883563915u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F8E RID: 3982 RVA: 0x000136F4 File Offset: 0x000126F4
		public bool EventObjectives(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2883563915u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F8F RID: 3983 RVA: 0x0001372C File Offset: 0x0001272C
		public unsafe eWMFeatureType FeatureType()
		{
			eWMFeatureType* attributePointer = (eWMFeatureType*)this.instance.GetAttributePointer(1787692963u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return eWMFeatureType.WORLDMAP_FEATURE_TYPE_BASICPOINTFEATURE;
		}

		// Token: 0x06000F90 RID: 3984 RVA: 0x00013754 File Offset: 0x00012754
		public unsafe bool FeatureType(eWMFeatureType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1787692963u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F91 RID: 3985 RVA: 0x00013788 File Offset: 0x00012788
		public unsafe string FEIcon()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(60151413u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F92 RID: 3986 RVA: 0x000137B8 File Offset: 0x000127B8
		public unsafe bool FEIcon(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(60151413u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F93 RID: 3987 RVA: 0x00013834 File Offset: 0x00012834
		public unsafe string FEIconLocked()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(1513750799u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F94 RID: 3988 RVA: 0x00013864 File Offset: 0x00012864
		public unsafe bool FEIconLocked(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1513750799u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F95 RID: 3989 RVA: 0x000138E0 File Offset: 0x000128E0
		public unsafe GCollectionKey FinishLine()
		{
			void* attributePointer = this.instance.GetAttributePointer(2613755887u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000F96 RID: 3990 RVA: 0x00013910 File Offset: 0x00012910
		public bool FinishLine(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2613755887u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000F97 RID: 3991 RVA: 0x00013948 File Offset: 0x00012948
		public unsafe float FlareSpacing()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(961199046u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000F98 RID: 3992 RVA: 0x00013974 File Offset: 0x00012974
		public unsafe bool FlareSpacing(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(961199046u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F99 RID: 3993 RVA: 0x000139A8 File Offset: 0x000129A8
		public unsafe string FlasherHALId()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3340186272u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F9A RID: 3994 RVA: 0x000139D8 File Offset: 0x000129D8
		public unsafe bool FlasherHALId(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3340186272u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F9B RID: 3995 RVA: 0x00013A54 File Offset: 0x00012A54
		public unsafe uint GameModeId()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(4019547105u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000F9C RID: 3996 RVA: 0x00013A7C File Offset: 0x00012A7C
		public unsafe bool GameModeId(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4019547105u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000F9D RID: 3997 RVA: 0x00013AB0 File Offset: 0x00012AB0
		public unsafe string gameplayvault()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(2482872282u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000F9E RID: 3998 RVA: 0x00013AE0 File Offset: 0x00012AE0
		public unsafe bool gameplayvault(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2482872282u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000F9F RID: 3999 RVA: 0x00013B5C File Offset: 0x00012B5C
		public unsafe float GhostDebuffTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2767776777u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000FA0 RID: 4000 RVA: 0x00013B88 File Offset: 0x00012B88
		public unsafe bool GhostDebuffTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2767776777u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FA1 RID: 4001 RVA: 0x00013BBC File Offset: 0x00012BBC
		public unsafe bool GPSArrow()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3053560630u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FA2 RID: 4002 RVA: 0x00013BE4 File Offset: 0x00012BE4
		public unsafe bool GPSArrow(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3053560630u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FA3 RID: 4003 RVA: 0x00013C18 File Offset: 0x00012C18
		public unsafe float Handling()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3531645428u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000FA4 RID: 4004 RVA: 0x00013C44 File Offset: 0x00012C44
		public unsafe bool Handling(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3531645428u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FA5 RID: 4005 RVA: 0x00013C78 File Offset: 0x00012C78
		public unsafe bool HasMatchMakingTimeout()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(513414016u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FA6 RID: 4006 RVA: 0x00013CA0 File Offset: 0x00012CA0
		public unsafe bool HasMatchMakingTimeout(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(513414016u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FA7 RID: 4007 RVA: 0x00013CD4 File Offset: 0x00012CD4
		public unsafe bool HasTraffic()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(1615084070u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FA8 RID: 4008 RVA: 0x00013CFC File Offset: 0x00012CFC
		public unsafe bool HasTraffic(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1615084070u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FA9 RID: 4009 RVA: 0x00013D30 File Offset: 0x00012D30
		public unsafe float Height()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3129243749u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000FAA RID: 4010 RVA: 0x00013D5C File Offset: 0x00012D5C
		public unsafe bool Height(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3129243749u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FAB RID: 4011 RVA: 0x00013D90 File Offset: 0x00012D90
		public unsafe string Hud(uint index)
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(4062990711u, index);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000FAC RID: 4012 RVA: 0x00013DC0 File Offset: 0x00012DC0
		public unsafe bool Hud(string data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4062990711u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(index, (void*)ptr);
			}
		}

		// Token: 0x06000FAD RID: 4013 RVA: 0x00013E3B File Offset: 0x00012E3B
		public uint Num_Hud()
		{
			return this.Get(4062990711u).GetLength();
		}

		// Token: 0x06000FAE RID: 4014 RVA: 0x00013E50 File Offset: 0x00012E50
		public unsafe int HurryUpTimeoutInMilliseconds()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(1962144923u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FAF RID: 4015 RVA: 0x00013E78 File Offset: 0x00012E78
		public unsafe bool HurryUpTimeoutInMilliseconds(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1962144923u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FB0 RID: 4016 RVA: 0x00013EAC File Offset: 0x00012EAC
		public unsafe int InitialHeat()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(1829198941u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FB1 RID: 4017 RVA: 0x00013ED4 File Offset: 0x00012ED4
		public unsafe bool InitialHeat(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1829198941u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FB2 RID: 4018 RVA: 0x00013F08 File Offset: 0x00012F08
		public unsafe float InitialSpeed()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(177297773u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000FB3 RID: 4019 RVA: 0x00013F34 File Offset: 0x00012F34
		public unsafe bool InitialSpeed(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(177297773u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FB4 RID: 4020 RVA: 0x00013F68 File Offset: 0x00012F68
		public unsafe bool IsBusted()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(1243277056u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FB5 RID: 4021 RVA: 0x00013F90 File Offset: 0x00012F90
		public unsafe bool IsBusted(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1243277056u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FB6 RID: 4022 RVA: 0x00013FC4 File Offset: 0x00012FC4
		public unsafe bool IsDragEvent()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(2940140705u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FB7 RID: 4023 RVA: 0x00013FEC File Offset: 0x00012FEC
		public unsafe bool IsDragEvent(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2940140705u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FB8 RID: 4024 RVA: 0x00014020 File Offset: 0x00013020
		public unsafe bool IsEnabled()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(604334242u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FB9 RID: 4025 RVA: 0x00014048 File Offset: 0x00013048
		public unsafe bool IsEnabled(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(604334242u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FBA RID: 4026 RVA: 0x0001407C File Offset: 0x0001307C
		public unsafe bool IsEventOnly()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(1059809412u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000FBB RID: 4027 RVA: 0x000140A4 File Offset: 0x000130A4
		public unsafe bool IsEventOnly(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1059809412u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FBC RID: 4028 RVA: 0x000140D8 File Offset: 0x000130D8
		public unsafe Vector2 layoutpos()
		{
			void* attributePointer = this.instance.GetAttributePointer(1081470022u, 0u);
			return new Vector2(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FBD RID: 4029 RVA: 0x00014108 File Offset: 0x00013108
		public bool layoutpos(Vector2 data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1081470022u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000FBE RID: 4030 RVA: 0x00014140 File Offset: 0x00013140
		public unsafe int Level()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(28034814u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FBF RID: 4031 RVA: 0x00014168 File Offset: 0x00013168
		public unsafe bool Level(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(28034814u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FC0 RID: 4032 RVA: 0x0001419C File Offset: 0x0001319C
		public unsafe LocalizationHash Localization()
		{
			void* attributePointer = this.instance.GetAttributePointer(632283268u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FC1 RID: 4033 RVA: 0x000141CC File Offset: 0x000131CC
		public bool Localization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(632283268u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000FC2 RID: 4034 RVA: 0x00014204 File Offset: 0x00013204
		public unsafe int LocalizationTag()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(3683232604u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FC3 RID: 4035 RVA: 0x0001422C File Offset: 0x0001322C
		public unsafe bool LocalizationTag(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3683232604u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FC4 RID: 4036 RVA: 0x00014260 File Offset: 0x00013260
		public unsafe GCollectionKey MapArea()
		{
			void* attributePointer = this.instance.GetAttributePointer(1637793787u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FC5 RID: 4037 RVA: 0x00014290 File Offset: 0x00013290
		public bool MapArea(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1637793787u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000FC6 RID: 4038 RVA: 0x000142C8 File Offset: 0x000132C8
		public unsafe GMapCurve MapCurve(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2130663307u, index);
			return new GMapCurve(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FC7 RID: 4039 RVA: 0x000142F8 File Offset: 0x000132F8
		public bool MapCurve(GMapCurve data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2130663307u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FC8 RID: 4040 RVA: 0x0001432D File Offset: 0x0001332D
		public uint Num_MapCurve()
		{
			return this.Get(2130663307u).GetLength();
		}

		// Token: 0x06000FC9 RID: 4041 RVA: 0x00014340 File Offset: 0x00013340
		public unsafe GMapCurvePoint MapCurvePoint(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(1612033838u, index);
			return new GMapCurvePoint(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FCA RID: 4042 RVA: 0x00014370 File Offset: 0x00013370
		public bool MapCurvePoint(GMapCurvePoint data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1612033838u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FCB RID: 4043 RVA: 0x000143A5 File Offset: 0x000133A5
		public uint Num_MapCurvePoint()
		{
			return this.Get(1612033838u).GetLength();
		}

		// Token: 0x06000FCC RID: 4044 RVA: 0x000143B8 File Offset: 0x000133B8
		public unsafe GMapCurveRef MapCurveRef(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(242883138u, index);
			return new GMapCurveRef(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FCD RID: 4045 RVA: 0x000143E8 File Offset: 0x000133E8
		public bool MapCurveRef(GMapCurveRef data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(242883138u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FCE RID: 4046 RVA: 0x0001441D File Offset: 0x0001341D
		public uint Num_MapCurveRef()
		{
			return this.Get(242883138u).GetLength();
		}

		// Token: 0x06000FCF RID: 4047 RVA: 0x00014430 File Offset: 0x00013430
		public unsafe GMapRegionInfo MapRegion(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3595785332u, index);
			return new GMapRegionInfo(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FD0 RID: 4048 RVA: 0x00014460 File Offset: 0x00013460
		public bool MapRegion(GMapRegionInfo data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3595785332u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FD1 RID: 4049 RVA: 0x00014495 File Offset: 0x00013495
		public uint Num_MapRegion()
		{
			return this.Get(3595785332u).GetLength();
		}

		// Token: 0x06000FD2 RID: 4050 RVA: 0x000144A8 File Offset: 0x000134A8
		public unsafe GMapTriangle MapTriangle(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3847684937u, index);
			return new GMapTriangle(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FD3 RID: 4051 RVA: 0x000144D8 File Offset: 0x000134D8
		public bool MapTriangle(GMapTriangle data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3847684937u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FD4 RID: 4052 RVA: 0x0001450D File Offset: 0x0001350D
		public uint Num_MapTriangle()
		{
			return this.Get(3847684937u).GetLength();
		}

		// Token: 0x06000FD5 RID: 4053 RVA: 0x00014520 File Offset: 0x00013520
		public unsafe GCollectionKey Marker(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(283950628u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FD6 RID: 4054 RVA: 0x00014550 File Offset: 0x00013550
		public bool Marker(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(283950628u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FD7 RID: 4055 RVA: 0x00014585 File Offset: 0x00013585
		public uint Num_Marker()
		{
			return this.Get(283950628u).GetLength();
		}

		// Token: 0x06000FD8 RID: 4056 RVA: 0x00014598 File Offset: 0x00013598
		public unsafe uint MaxLevel()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(1628474510u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000FD9 RID: 4057 RVA: 0x000145C0 File Offset: 0x000135C0
		public unsafe bool MaxLevel(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1628474510u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FDA RID: 4058 RVA: 0x000145F4 File Offset: 0x000135F4
		public unsafe uint MaxRacers()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(65160398u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000FDB RID: 4059 RVA: 0x0001461C File Offset: 0x0001361C
		public unsafe bool MaxRacers(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(65160398u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FDC RID: 4060 RVA: 0x00014650 File Offset: 0x00013650
		public unsafe int MilestoneCount()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2499922812u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FDD RID: 4061 RVA: 0x00014678 File Offset: 0x00013678
		public unsafe bool MilestoneCount(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2499922812u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FDE RID: 4062 RVA: 0x000146AC File Offset: 0x000136AC
		public unsafe GCollectionKey Milestones(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2512090179u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FDF RID: 4063 RVA: 0x000146DC File Offset: 0x000136DC
		public bool Milestones(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2512090179u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FE0 RID: 4064 RVA: 0x00014711 File Offset: 0x00013711
		public uint Num_Milestones()
		{
			return this.Get(2512090179u).GetLength();
		}

		// Token: 0x06000FE1 RID: 4065 RVA: 0x00014724 File Offset: 0x00013724
		public unsafe MilestoneType MilestoneType()
		{
			MilestoneType* attributePointer = (MilestoneType*)this.instance.GetAttributePointer(383727914u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return GameCore.MilestoneType.kMilestone_None;
		}

		// Token: 0x06000FE2 RID: 4066 RVA: 0x0001474C File Offset: 0x0001374C
		public unsafe bool MilestoneType(MilestoneType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(383727914u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FE3 RID: 4067 RVA: 0x00014780 File Offset: 0x00013780
		public unsafe MiniMapIconHash MiniMapIconHash()
		{
			void* attributePointer = this.instance.GetAttributePointer(3957319358u, 0u);
			return new MiniMapIconHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FE4 RID: 4068 RVA: 0x000147B0 File Offset: 0x000137B0
		public bool MiniMapIconHash(MiniMapIconHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3957319358u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000FE5 RID: 4069 RVA: 0x000147E8 File Offset: 0x000137E8
		public unsafe uint MinLevel()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(733958939u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000FE6 RID: 4070 RVA: 0x00014810 File Offset: 0x00013810
		public unsafe bool MinLevel(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(733958939u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FE7 RID: 4071 RVA: 0x00014844 File Offset: 0x00013844
		public unsafe float MinLifetime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(579982168u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000FE8 RID: 4072 RVA: 0x00014870 File Offset: 0x00013870
		public unsafe bool MinLifetime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(579982168u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FE9 RID: 4073 RVA: 0x000148A4 File Offset: 0x000138A4
		public unsafe uint MinRacers()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(4143161692u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06000FEA RID: 4074 RVA: 0x000148CC File Offset: 0x000138CC
		public unsafe bool MinRacers(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4143161692u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FEB RID: 4075 RVA: 0x00014900 File Offset: 0x00013900
		public unsafe string Name()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(1042439873u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000FEC RID: 4076 RVA: 0x00014930 File Offset: 0x00013930
		public unsafe bool Name(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1042439873u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000FED RID: 4077 RVA: 0x000149AC File Offset: 0x000139AC
		public unsafe string NameHAL()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(118578688u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000FEE RID: 4078 RVA: 0x000149DC File Offset: 0x000139DC
		public unsafe bool NameHAL(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(118578688u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000FEF RID: 4079 RVA: 0x00014A58 File Offset: 0x00013A58
		public unsafe LocalizationHash NameLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(1289787416u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FF0 RID: 4080 RVA: 0x00014A88 File Offset: 0x00013A88
		public bool NameLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1289787416u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000FF1 RID: 4081 RVA: 0x00014AC0 File Offset: 0x00013AC0
		public unsafe int NumCoins()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(1101831991u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FF2 RID: 4082 RVA: 0x00014AE8 File Offset: 0x00013AE8
		public unsafe bool NumCoins(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1101831991u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FF3 RID: 4083 RVA: 0x00014B1C File Offset: 0x00013B1C
		public unsafe int NumLaps()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(247316837u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FF4 RID: 4084 RVA: 0x00014B44 File Offset: 0x00013B44
		public unsafe bool NumLaps(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(247316837u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FF5 RID: 4085 RVA: 0x00014B78 File Offset: 0x00013B78
		public unsafe ushort NumRhinos()
		{
			ushort* attributePointer = (ushort*)this.instance.GetAttributePointer(2041862278u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FF6 RID: 4086 RVA: 0x00014BA0 File Offset: 0x00013BA0
		public unsafe bool NumRhinos(ushort data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2041862278u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FF7 RID: 4087 RVA: 0x00014BD4 File Offset: 0x00013BD4
		public unsafe ObjFlags ObjectFlags()
		{
			void* attributePointer = this.instance.GetAttributePointer(3142286341u, 0u);
			return new ObjFlags(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FF8 RID: 4088 RVA: 0x00014C04 File Offset: 0x00013C04
		public bool ObjectFlags(ObjFlags data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3142286341u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000FF9 RID: 4089 RVA: 0x00014C3C File Offset: 0x00013C3C
		public unsafe GCollectionKey Objectives(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(98044419u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000FFA RID: 4090 RVA: 0x00014C6C File Offset: 0x00013C6C
		public bool Objectives(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(98044419u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06000FFB RID: 4091 RVA: 0x00014CA1 File Offset: 0x00013CA1
		public uint Num_Objectives()
		{
			return this.Get(98044419u).GetLength();
		}

		// Token: 0x06000FFC RID: 4092 RVA: 0x00014CB4 File Offset: 0x00013CB4
		public unsafe ObjType ObjectType()
		{
			ObjType* attributePointer = (ObjType*)this.instance.GetAttributePointer(254580502u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return ObjType.kObjType_TrackLayout;
		}

		// Token: 0x06000FFD RID: 4093 RVA: 0x00014CDC File Offset: 0x00013CDC
		public unsafe bool ObjectType(ObjType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(254580502u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000FFE RID: 4094 RVA: 0x00014D10 File Offset: 0x00013D10
		public unsafe short OpponentCount()
		{
			short* attributePointer = (short*)this.instance.GetAttributePointer(2386970327u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000FFF RID: 4095 RVA: 0x00014D38 File Offset: 0x00013D38
		public unsafe bool OpponentCount(short data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2386970327u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001000 RID: 4096 RVA: 0x00014D6C File Offset: 0x00013D6C
		public unsafe GCollectionKey Opponents(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(1480194586u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001001 RID: 4097 RVA: 0x00014D9C File Offset: 0x00013D9C
		public bool Opponents(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1480194586u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001002 RID: 4098 RVA: 0x00014DD1 File Offset: 0x00013DD1
		public uint Num_Opponents()
		{
			return this.Get(1480194586u).GetLength();
		}

		// Token: 0x06001003 RID: 4099 RVA: 0x00014DE4 File Offset: 0x00013DE4
		public unsafe int Order()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(3488875432u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001004 RID: 4100 RVA: 0x00014E0C File Offset: 0x00013E0C
		public unsafe bool Order(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3488875432u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001005 RID: 4101 RVA: 0x00014E40 File Offset: 0x00013E40
		public unsafe PartZone PartZone()
		{
			PartZone* attributePointer = (PartZone*)this.instance.GetAttributePointer(2501138115u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return PerformanceUpgrades.PartZone.PERFSLOT_ENGINE;
		}

		// Token: 0x06001006 RID: 4102 RVA: 0x00014E68 File Offset: 0x00013E68
		public unsafe bool PartZone(PartZone data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2501138115u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001007 RID: 4103 RVA: 0x00014E9C File Offset: 0x00013E9C
		public unsafe float PerfectStartBaseDuration()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3332898579u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001008 RID: 4104 RVA: 0x00014EC8 File Offset: 0x00013EC8
		public unsafe bool PerfectStartBaseDuration(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3332898579u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001009 RID: 4105 RVA: 0x00014EFC File Offset: 0x00013EFC
		public unsafe float PerfectStartBaseRange()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2933020581u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600100A RID: 4106 RVA: 0x00014F28 File Offset: 0x00013F28
		public unsafe bool PerfectStartBaseRange(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2933020581u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600100B RID: 4107 RVA: 0x00014F5C File Offset: 0x00013F5C
		public unsafe bool Personal()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3769523272u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x0600100C RID: 4108 RVA: 0x00014F84 File Offset: 0x00013F84
		public unsafe bool Personal(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3769523272u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600100D RID: 4109 RVA: 0x00014FB8 File Offset: 0x00013FB8
		public unsafe GCollectionKey PointOfInterest()
		{
			void* attributePointer = this.instance.GetAttributePointer(1336353866u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600100E RID: 4110 RVA: 0x00014FE8 File Offset: 0x00013FE8
		public bool PointOfInterest(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1336353866u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x0600100F RID: 4111 RVA: 0x00015020 File Offset: 0x00014020
		public unsafe PoiBehaviorFlags PointOfInterestBehavior()
		{
			void* attributePointer = this.instance.GetAttributePointer(1596302405u, 0u);
			return new PoiBehaviorFlags(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001010 RID: 4112 RVA: 0x00015050 File Offset: 0x00014050
		public bool PointOfInterestBehavior(PoiBehaviorFlags data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1596302405u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001011 RID: 4113 RVA: 0x00015088 File Offset: 0x00014088
		public unsafe POIType PointOfInterestType()
		{
			POIType* attributePointer = (POIType*)this.instance.GetAttributePointer(2530720670u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return POIType.POIType_Cooldown;
		}

		// Token: 0x06001012 RID: 4114 RVA: 0x000150B0 File Offset: 0x000140B0
		public unsafe bool PointOfInterestType(POIType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2530720670u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001013 RID: 4115 RVA: 0x000150E4 File Offset: 0x000140E4
		public unsafe IndexedBarrierName PoliceLines(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(364691926u, index);
			return new IndexedBarrierName(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001014 RID: 4116 RVA: 0x00015114 File Offset: 0x00014114
		public bool PoliceLines(IndexedBarrierName data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(364691926u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001015 RID: 4117 RVA: 0x00015149 File Offset: 0x00014149
		public uint Num_PoliceLines()
		{
			return this.Get(364691926u).GetLength();
		}

		// Token: 0x06001016 RID: 4118 RVA: 0x0001515C File Offset: 0x0001415C
		public unsafe GameCore.Math.Vector3 Position()
		{
			void* attributePointer = this.instance.GetAttributePointer(2675194382u, 0u);
			return new GameCore.Math.Vector3(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001017 RID: 4119 RVA: 0x0001518C File Offset: 0x0001418C
		public bool Position(GameCore.Math.Vector3 data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2675194382u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001018 RID: 4120 RVA: 0x000151C4 File Offset: 0x000141C4
		public unsafe float PowerupBlackoutAtEventStart()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3072216373u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001019 RID: 4121 RVA: 0x000151F0 File Offset: 0x000141F0
		public unsafe bool PowerupBlackoutAtEventStart(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3072216373u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600101A RID: 4122 RVA: 0x00015224 File Offset: 0x00014224
		public unsafe PowerupConfiguration PowerupConfiguration()
		{
			PowerupConfiguration* attributePointer = (PowerupConfiguration*)this.instance.GetAttributePointer(1761214495u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return GameCore.PowerupConfiguration.kPowerupConfigFreeRoam;
		}

		// Token: 0x0600101B RID: 4123 RVA: 0x0001524C File Offset: 0x0001424C
		public unsafe bool PowerupConfiguration(PowerupConfiguration data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1761214495u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600101C RID: 4124 RVA: 0x00015280 File Offset: 0x00014280
		public unsafe enumPowerUpType PowerUpType()
		{
			enumPowerUpType* attributePointer = (enumPowerUpType*)this.instance.GetAttributePointer(635467244u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return enumPowerUpType.None;
		}

		// Token: 0x0600101D RID: 4125 RVA: 0x000152A8 File Offset: 0x000142A8
		public unsafe bool PowerUpType(enumPowerUpType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(635467244u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600101E RID: 4126 RVA: 0x000152DC File Offset: 0x000142DC
		public unsafe string PresetRides(uint index)
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(2323009784u, index);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x0600101F RID: 4127 RVA: 0x0001530C File Offset: 0x0001430C
		public unsafe bool PresetRides(string data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2323009784u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(index, (void*)ptr);
			}
		}

		// Token: 0x06001020 RID: 4128 RVA: 0x00015387 File Offset: 0x00014387
		public uint Num_PresetRides()
		{
			return this.Get(2323009784u).GetLength();
		}

		// Token: 0x06001021 RID: 4129 RVA: 0x0001539C File Offset: 0x0001439C
		public unsafe bool Primary()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3920542741u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001022 RID: 4130 RVA: 0x000153C4 File Offset: 0x000143C4
		public unsafe bool Primary(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3920542741u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001023 RID: 4131 RVA: 0x000153F8 File Offset: 0x000143F8
		public unsafe string ProductIdConfig()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3518578615u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06001024 RID: 4132 RVA: 0x00015428 File Offset: 0x00014428
		public unsafe bool ProductIdConfig(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3518578615u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06001025 RID: 4133 RVA: 0x000154A4 File Offset: 0x000144A4
		public unsafe GCollectionKey PursuitCheckpoint(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(1765971197u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001026 RID: 4134 RVA: 0x000154D4 File Offset: 0x000144D4
		public bool PursuitCheckpoint(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1765971197u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001027 RID: 4135 RVA: 0x00015509 File Offset: 0x00014509
		public uint Num_PursuitCheckpoint()
		{
			return this.Get(1765971197u).GetLength();
		}

		// Token: 0x06001028 RID: 4136 RVA: 0x0001551C File Offset: 0x0001451C
		public unsafe StringKey PursuitEscalation()
		{
			void* attributePointer = this.instance.GetAttributePointer(3354047382u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001029 RID: 4137 RVA: 0x0001554C File Offset: 0x0001454C
		public bool PursuitEscalation(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3354047382u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x0600102A RID: 4138 RVA: 0x00015584 File Offset: 0x00014584
		public unsafe string RacerName()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3198903493u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x0600102B RID: 4139 RVA: 0x000155B4 File Offset: 0x000145B4
		public unsafe bool RacerName(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3198903493u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x0600102C RID: 4140 RVA: 0x00015630 File Offset: 0x00014630
		public unsafe float RadarDistanceFarRangeMax()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(242865969u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600102D RID: 4141 RVA: 0x0001565C File Offset: 0x0001465C
		public unsafe bool RadarDistanceFarRangeMax(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(242865969u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600102E RID: 4142 RVA: 0x00015690 File Offset: 0x00014690
		public unsafe float RadarDistanceFarRangeMin()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4122081824u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600102F RID: 4143 RVA: 0x000156BC File Offset: 0x000146BC
		public unsafe bool RadarDistanceFarRangeMin(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4122081824u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001030 RID: 4144 RVA: 0x000156F0 File Offset: 0x000146F0
		public unsafe float RadarDistanceMediumRangeMin()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(944951864u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001031 RID: 4145 RVA: 0x0001571C File Offset: 0x0001471C
		public unsafe bool RadarDistanceMediumRangeMin(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(944951864u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001032 RID: 4146 RVA: 0x00015750 File Offset: 0x00014750
		public unsafe float RadarDistanceNearRangeMin()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(129800294u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001033 RID: 4147 RVA: 0x0001577C File Offset: 0x0001477C
		public unsafe bool RadarDistanceNearRangeMin(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(129800294u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001034 RID: 4148 RVA: 0x000157B0 File Offset: 0x000147B0
		public unsafe float Radius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(968851458u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x000157DC File Offset: 0x000147DC
		public unsafe bool Radius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(968851458u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00015810 File Offset: 0x00014810
		public unsafe int Rarity()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(865653422u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00015838 File Offset: 0x00014838
		public unsafe bool Rarity(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(865653422u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x0001586C File Offset: 0x0001486C
		public unsafe bool RecoverLobbySupported()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3882197782u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00015894 File Offset: 0x00014894
		public unsafe bool RecoverLobbySupported(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3882197782u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600103A RID: 4154 RVA: 0x000158C8 File Offset: 0x000148C8
		public unsafe GCollectionKey Region()
		{
			void* attributePointer = this.instance.GetAttributePointer(3405898836u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600103B RID: 4155 RVA: 0x000158F8 File Offset: 0x000148F8
		public bool Region(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3405898836u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x0600103C RID: 4156 RVA: 0x00015930 File Offset: 0x00014930
		public unsafe string RegionName()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3775546969u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x0600103D RID: 4157 RVA: 0x00015960 File Offset: 0x00014960
		public unsafe bool RegionName(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3775546969u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x0600103E RID: 4158 RVA: 0x000159DC File Offset: 0x000149DC
		public unsafe string RemoteEntitlementTag()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(619788000u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x0600103F RID: 4159 RVA: 0x00015A0C File Offset: 0x00014A0C
		public unsafe bool RemoteEntitlementTag(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(619788000u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06001040 RID: 4160 RVA: 0x00015A88 File Offset: 0x00014A88
		public unsafe EnhancerPart RemovedByEnhancerWorldMap()
		{
			void* attributePointer = this.instance.GetAttributePointer(3939395938u, 0u);
			return new EnhancerPart(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001041 RID: 4161 RVA: 0x00015AB8 File Offset: 0x00014AB8
		public bool RemovedByEnhancerWorldMap(EnhancerPart data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3939395938u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001042 RID: 4162 RVA: 0x00015AF0 File Offset: 0x00014AF0
		public unsafe uint RequiredLevel()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(2759138175u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x06001043 RID: 4163 RVA: 0x00015B18 File Offset: 0x00014B18
		public unsafe bool RequiredLevel(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2759138175u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001044 RID: 4164 RVA: 0x00015B4C File Offset: 0x00014B4C
		public unsafe EnhancerPart RequiresEnhancerWorldMap()
		{
			void* attributePointer = this.instance.GetAttributePointer(2515416057u, 0u);
			return new EnhancerPart(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001045 RID: 4165 RVA: 0x00015B7C File Offset: 0x00014B7C
		public bool RequiresEnhancerWorldMap(EnhancerPart data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2515416057u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001046 RID: 4166 RVA: 0x00015BB4 File Offset: 0x00014BB4
		public unsafe GCollectionKey ResetMarker()
		{
			void* attributePointer = this.instance.GetAttributePointer(3320596406u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001047 RID: 4167 RVA: 0x00015BE4 File Offset: 0x00014BE4
		public bool ResetMarker(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3320596406u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001048 RID: 4168 RVA: 0x00015C1C File Offset: 0x00014C1C
		public unsafe GCollectionKey RespawnLocation(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(1123412105u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001049 RID: 4169 RVA: 0x00015C4C File Offset: 0x00014C4C
		public bool RespawnLocation(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1123412105u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x00015C81 File Offset: 0x00014C81
		public uint Num_RespawnLocation()
		{
			return this.Get(1123412105u).GetLength();
		}

		// Token: 0x0600104B RID: 4171 RVA: 0x00015C94 File Offset: 0x00014C94
		public unsafe float RespawnSpeedMultiplier()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2240128594u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600104C RID: 4172 RVA: 0x00015CC0 File Offset: 0x00014CC0
		public unsafe bool RespawnSpeedMultiplier(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2240128594u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600104D RID: 4173 RVA: 0x00015CF4 File Offset: 0x00014CF4
		public unsafe int RestoredLobbyDurationInMilliseconds()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(46227903u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x0600104E RID: 4174 RVA: 0x00015D1C File Offset: 0x00014D1C
		public unsafe bool RestoredLobbyDurationInMilliseconds(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(46227903u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600104F RID: 4175 RVA: 0x00015D50 File Offset: 0x00014D50
		public unsafe int Reward_Rep()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2946158018u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x00015D78 File Offset: 0x00014D78
		public unsafe bool Reward_Rep(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2946158018u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001051 RID: 4177 RVA: 0x00015DAC File Offset: 0x00014DAC
		public unsafe int Reward_Tokens()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(407606633u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001052 RID: 4178 RVA: 0x00015DD4 File Offset: 0x00014DD4
		public unsafe bool Reward_Tokens(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(407606633u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x00015E08 File Offset: 0x00014E08
		public unsafe RewardMode RewardMode()
		{
			RewardMode* attributePointer = (RewardMode*)this.instance.GetAttributePointer(2342112074u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return (RewardMode)0;
		}

		// Token: 0x06001054 RID: 4180 RVA: 0x00015E30 File Offset: 0x00014E30
		public unsafe bool RewardMode(RewardMode data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2342112074u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001055 RID: 4181 RVA: 0x00015E64 File Offset: 0x00014E64
		public unsafe LocalizationHash RewardModeLocalization()
		{
			void* attributePointer = this.instance.GetAttributePointer(1272585742u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001056 RID: 4182 RVA: 0x00015E94 File Offset: 0x00014E94
		public bool RewardModeLocalization(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1272585742u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001057 RID: 4183 RVA: 0x00015ECC File Offset: 0x00014ECC
		public unsafe GCollectionKey Rewards(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3381325084u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001058 RID: 4184 RVA: 0x00015EFC File Offset: 0x00014EFC
		public bool Rewards(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3381325084u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001059 RID: 4185 RVA: 0x00015F31 File Offset: 0x00014F31
		public uint Num_Rewards()
		{
			return this.Get(3381325084u).GetLength();
		}

		// Token: 0x0600105A RID: 4186 RVA: 0x00015F44 File Offset: 0x00014F44
		public unsafe float Rotation()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1516918726u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600105B RID: 4187 RVA: 0x00015F70 File Offset: 0x00014F70
		public unsafe bool Rotation(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1516918726u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600105C RID: 4188 RVA: 0x00015FA4 File Offset: 0x00014FA4
		public unsafe StringKey RoutingMethod()
		{
			void* attributePointer = this.instance.GetAttributePointer(501782688u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600105D RID: 4189 RVA: 0x00015FD4 File Offset: 0x00014FD4
		public bool RoutingMethod(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(501782688u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x0600105E RID: 4190 RVA: 0x0001600C File Offset: 0x0001500C
		public unsafe StringKey ScoringMethod()
		{
			void* attributePointer = this.instance.GetAttributePointer(1115233151u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600105F RID: 4191 RVA: 0x0001603C File Offset: 0x0001503C
		public bool ScoringMethod(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1115233151u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001060 RID: 4192 RVA: 0x00016074 File Offset: 0x00015074
		public unsafe StringKey ScriptAction()
		{
			void* attributePointer = this.instance.GetAttributePointer(1571482063u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001061 RID: 4193 RVA: 0x000160A4 File Offset: 0x000150A4
		public bool ScriptAction(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1571482063u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001062 RID: 4194 RVA: 0x000160DC File Offset: 0x000150DC
		public unsafe int SetID()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2948597350u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001063 RID: 4195 RVA: 0x00016104 File Offset: 0x00015104
		public unsafe bool SetID(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2948597350u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001064 RID: 4196 RVA: 0x00016138 File Offset: 0x00015138
		public unsafe float ShortcutMaxChance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(385530385u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001065 RID: 4197 RVA: 0x00016164 File Offset: 0x00015164
		public unsafe bool ShortcutMaxChance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(385530385u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001066 RID: 4198 RVA: 0x00016198 File Offset: 0x00015198
		public unsafe float ShortcutMinChance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1325110538u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001067 RID: 4199 RVA: 0x000161C4 File Offset: 0x000151C4
		public unsafe bool ShortcutMinChance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1325110538u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001068 RID: 4200 RVA: 0x000161F8 File Offset: 0x000151F8
		public unsafe GCollectionKey Shortcuts(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2070751598u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001069 RID: 4201 RVA: 0x00016228 File Offset: 0x00015228
		public bool Shortcuts(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2070751598u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x0600106A RID: 4202 RVA: 0x0001625D File Offset: 0x0001525D
		public uint Num_Shortcuts()
		{
			return this.Get(2070751598u).GetLength();
		}

		// Token: 0x0600106B RID: 4203 RVA: 0x00016270 File Offset: 0x00015270
		public unsafe bool ShouldArbitrate()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(2976488387u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x0600106C RID: 4204 RVA: 0x00016298 File Offset: 0x00015298
		public unsafe bool ShouldArbitrate(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2976488387u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600106D RID: 4205 RVA: 0x000162CC File Offset: 0x000152CC
		public unsafe bool ShouldUseSpikeStrips()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(126660068u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x0600106E RID: 4206 RVA: 0x000162F4 File Offset: 0x000152F4
		public unsafe bool ShouldUseSpikeStrips(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(126660068u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600106F RID: 4207 RVA: 0x00016328 File Offset: 0x00015328
		public unsafe bool ShowFlasher()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(2667984560u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001070 RID: 4208 RVA: 0x00016350 File Offset: 0x00015350
		public unsafe bool ShowFlasher(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2667984560u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001071 RID: 4209 RVA: 0x00016384 File Offset: 0x00015384
		public unsafe GCollectionKey SkillModCategory()
		{
			void* attributePointer = this.instance.GetAttributePointer(662503701u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001072 RID: 4210 RVA: 0x000163B4 File Offset: 0x000153B4
		public bool SkillModCategory(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(662503701u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001073 RID: 4211 RVA: 0x000163EC File Offset: 0x000153EC
		public unsafe float SkillModEffectAmount()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3035516267u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001074 RID: 4212 RVA: 0x00016418 File Offset: 0x00015418
		public unsafe bool SkillModEffectAmount(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3035516267u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001075 RID: 4213 RVA: 0x0001644C File Offset: 0x0001544C
		public unsafe SkillModEffectAmountConversion SkillModEffectAmountImperialConversion()
		{
			SkillModEffectAmountConversion* attributePointer = (SkillModEffectAmountConversion*)this.instance.GetAttributePointer(3317689471u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return SkillModEffectAmountConversion.None;
		}

		// Token: 0x06001076 RID: 4214 RVA: 0x00016474 File Offset: 0x00015474
		public unsafe bool SkillModEffectAmountImperialConversion(SkillModEffectAmountConversion data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3317689471u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001077 RID: 4215 RVA: 0x000164A8 File Offset: 0x000154A8
		public unsafe EventType SkillModEffectEventMode()
		{
			EventType* attributePointer = (EventType*)this.instance.GetAttributePointer(3967921241u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return EventType.kEventType_Unknown;
		}

		// Token: 0x06001078 RID: 4216 RVA: 0x000164D0 File Offset: 0x000154D0
		public unsafe bool SkillModEffectEventMode(EventType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3967921241u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001079 RID: 4217 RVA: 0x00016504 File Offset: 0x00015504
		public unsafe float SkillModEffectMaxAmount()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(182868694u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00016530 File Offset: 0x00015530
		public unsafe bool SkillModEffectMaxAmount(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(182868694u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600107B RID: 4219 RVA: 0x00016564 File Offset: 0x00015564
		public unsafe GCollectionKey SkillModEffects(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(1617241112u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00016594 File Offset: 0x00015594
		public bool SkillModEffects(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1617241112u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x0600107D RID: 4221 RVA: 0x000165C9 File Offset: 0x000155C9
		public uint Num_SkillModEffects()
		{
			return this.Get(1617241112u).GetLength();
		}

		// Token: 0x0600107E RID: 4222 RVA: 0x000165DC File Offset: 0x000155DC
		public unsafe GCollectionKey SkillModEffectType()
		{
			void* attributePointer = this.instance.GetAttributePointer(57575623u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600107F RID: 4223 RVA: 0x0001660C File Offset: 0x0001560C
		public bool SkillModEffectType(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(57575623u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001080 RID: 4224 RVA: 0x00016644 File Offset: 0x00015644
		public unsafe bool SkillModEffectTypeAmountDisplay()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(2163127938u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001081 RID: 4225 RVA: 0x0001666C File Offset: 0x0001566C
		public unsafe bool SkillModEffectTypeAmountDisplay(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2163127938u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001082 RID: 4226 RVA: 0x000166A0 File Offset: 0x000156A0
		public unsafe bool SkillModEffectTypeDisplay()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(4018524620u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001083 RID: 4227 RVA: 0x000166C8 File Offset: 0x000156C8
		public unsafe bool SkillModEffectTypeDisplay(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4018524620u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001084 RID: 4228 RVA: 0x000166FC File Offset: 0x000156FC
		public unsafe SkillModEffectType SkillModEffectTypeId()
		{
			SkillModEffectType* attributePointer = (SkillModEffectType*)this.instance.GetAttributePointer(1958840646u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return Victory.Data.Objects.Customization.SkillModEffectType.None;
		}

		// Token: 0x06001085 RID: 4229 RVA: 0x00016724 File Offset: 0x00015724
		public unsafe bool SkillModEffectTypeId(SkillModEffectType data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1958840646u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001086 RID: 4230 RVA: 0x00016758 File Offset: 0x00015758
		public unsafe short SkillModPartQuality()
		{
			short* attributePointer = (short*)this.instance.GetAttributePointer(1604965660u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001087 RID: 4231 RVA: 0x00016780 File Offset: 0x00015780
		public unsafe bool SkillModPartQuality(short data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1604965660u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001088 RID: 4232 RVA: 0x000167B4 File Offset: 0x000157B4
		public unsafe GCollectionKey SpawnLocation(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2019006145u, index);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001089 RID: 4233 RVA: 0x000167E4 File Offset: 0x000157E4
		public bool SpawnLocation(GCollectionKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2019006145u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x0600108A RID: 4234 RVA: 0x00016819 File Offset: 0x00015819
		public uint Num_SpawnLocation()
		{
			return this.Get(2019006145u).GetLength();
		}

		// Token: 0x0600108B RID: 4235 RVA: 0x0001682C File Offset: 0x0001582C
		public unsafe GCollectionKey SpawnPoint()
		{
			void* attributePointer = this.instance.GetAttributePointer(3723760117u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600108C RID: 4236 RVA: 0x0001685C File Offset: 0x0001585C
		public bool SpawnPoint(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3723760117u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x0600108D RID: 4237 RVA: 0x00016894 File Offset: 0x00015894
		public unsafe StringKey SpectateMethod()
		{
			void* attributePointer = this.instance.GetAttributePointer(1819283086u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600108E RID: 4238 RVA: 0x000168C4 File Offset: 0x000158C4
		public bool SpectateMethod(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1819283086u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x0600108F RID: 4239 RVA: 0x000168FC File Offset: 0x000158FC
		public unsafe float SpectateTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3922468307u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001090 RID: 4240 RVA: 0x00016928 File Offset: 0x00015928
		public unsafe bool SpectateTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3922468307u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001091 RID: 4241 RVA: 0x0001695C File Offset: 0x0001595C
		public unsafe long StartDateTime()
		{
			long* attributePointer = (long*)this.instance.GetAttributePointer(413313663u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0L;
		}

		// Token: 0x06001092 RID: 4242 RVA: 0x00016988 File Offset: 0x00015988
		public unsafe bool StartDateTime(long data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(413313663u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001093 RID: 4243 RVA: 0x000169BC File Offset: 0x000159BC
		public unsafe GCollectionKey StartGrid()
		{
			void* attributePointer = this.instance.GetAttributePointer(3956131054u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001094 RID: 4244 RVA: 0x000169EC File Offset: 0x000159EC
		public bool StartGrid(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3956131054u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06001095 RID: 4245 RVA: 0x00016A24 File Offset: 0x00015A24
		public unsafe float StartGridExtraLaneOffset(uint index)
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(472286254u, index);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001096 RID: 4246 RVA: 0x00016A50 File Offset: 0x00015A50
		public unsafe bool StartGridExtraLaneOffset(float data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(472286254u);
			return orClone.IsValid() && orClone.Set(index, (void*)(&data));
		}

		// Token: 0x06001097 RID: 4247 RVA: 0x00016A82 File Offset: 0x00015A82
		public uint Num_StartGridExtraLaneOffset()
		{
			return this.Get(472286254u).GetLength();
		}

		// Token: 0x06001098 RID: 4248 RVA: 0x00016A94 File Offset: 0x00015A94
		public unsafe bool StartGridIsStaggered()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3603404538u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001099 RID: 4249 RVA: 0x00016ABC File Offset: 0x00015ABC
		public unsafe bool StartGridIsStaggered(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3603404538u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600109A RID: 4250 RVA: 0x00016AF0 File Offset: 0x00015AF0
		public unsafe float StartGridLatOffset()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1397489846u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600109B RID: 4251 RVA: 0x00016B1C File Offset: 0x00015B1C
		public unsafe bool StartGridLatOffset(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1397489846u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600109C RID: 4252 RVA: 0x00016B50 File Offset: 0x00015B50
		public unsafe float StartGridLatSpacing()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(76966922u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600109D RID: 4253 RVA: 0x00016B7C File Offset: 0x00015B7C
		public unsafe bool StartGridLatSpacing(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(76966922u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600109E RID: 4254 RVA: 0x00016BB0 File Offset: 0x00015BB0
		public unsafe float StartGridLongSpacing()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(751135432u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600109F RID: 4255 RVA: 0x00016BDC File Offset: 0x00015BDC
		public unsafe bool StartGridLongSpacing(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(751135432u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010A0 RID: 4256 RVA: 0x00016C10 File Offset: 0x00015C10
		public unsafe uint StartGridWidth()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(1305317699u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x060010A1 RID: 4257 RVA: 0x00016C38 File Offset: 0x00015C38
		public unsafe bool StartGridWidth(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1305317699u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010A2 RID: 4258 RVA: 0x00016C6C File Offset: 0x00015C6C
		public unsafe float StartTimeInSeconds()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2751957363u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010A3 RID: 4259 RVA: 0x00016C98 File Offset: 0x00015C98
		public unsafe bool StartTimeInSeconds(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2751957363u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010A4 RID: 4260 RVA: 0x00016CCC File Offset: 0x00015CCC
		public unsafe int StrikeCount()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(684454336u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060010A5 RID: 4261 RVA: 0x00016CF4 File Offset: 0x00015CF4
		public unsafe bool StrikeCount(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(684454336u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010A6 RID: 4262 RVA: 0x00016D28 File Offset: 0x00015D28
		public unsafe GCollectionKey TargetActivity()
		{
			void* attributePointer = this.instance.GetAttributePointer(662005491u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060010A7 RID: 4263 RVA: 0x00016D58 File Offset: 0x00015D58
		public bool TargetActivity(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(662005491u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x060010A8 RID: 4264 RVA: 0x00016D90 File Offset: 0x00015D90
		public unsafe bool Template()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(1049712330u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x060010A9 RID: 4265 RVA: 0x00016DB8 File Offset: 0x00015DB8
		public unsafe bool Template(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1049712330u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010AA RID: 4266 RVA: 0x00016DEC File Offset: 0x00015DEC
		public unsafe int Tier()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2569603889u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060010AB RID: 4267 RVA: 0x00016E14 File Offset: 0x00015E14
		public unsafe bool Tier(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2569603889u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010AC RID: 4268 RVA: 0x00016E48 File Offset: 0x00015E48
		public unsafe float TimeLimit()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1971712065u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010AD RID: 4269 RVA: 0x00016E74 File Offset: 0x00015E74
		public unsafe bool TimeLimit(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1971712065u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010AE RID: 4270 RVA: 0x00016EA8 File Offset: 0x00015EA8
		public unsafe float TimeLimitWarning()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1229278471u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00016ED4 File Offset: 0x00015ED4
		public unsafe bool TimeLimitWarning(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1229278471u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010B0 RID: 4272 RVA: 0x00016F08 File Offset: 0x00015F08
		public unsafe float TopSpeed()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1437942562u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x00016F34 File Offset: 0x00015F34
		public unsafe bool TopSpeed(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1437942562u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010B2 RID: 4274 RVA: 0x00016F68 File Offset: 0x00015F68
		public unsafe GCollectionKey TrackLayout()
		{
			void* attributePointer = this.instance.GetAttributePointer(1986581929u, 0u);
			return new GCollectionKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060010B3 RID: 4275 RVA: 0x00016F98 File Offset: 0x00015F98
		public bool TrackLayout(GCollectionKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1986581929u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x060010B4 RID: 4276 RVA: 0x00016FD0 File Offset: 0x00015FD0
		public unsafe float TrackLength()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2162707761u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010B5 RID: 4277 RVA: 0x00016FFC File Offset: 0x00015FFC
		public unsafe bool TrackLength(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2162707761u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010B6 RID: 4278 RVA: 0x00017030 File Offset: 0x00016030
		public unsafe string TrackMap()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(57909075u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x060010B7 RID: 4279 RVA: 0x00017060 File Offset: 0x00016060
		public unsafe bool TrackMap(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(57909075u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x060010B8 RID: 4280 RVA: 0x000170DC File Offset: 0x000160DC
		public unsafe ushort TrafficDensity()
		{
			ushort* attributePointer = (ushort*)this.instance.GetAttributePointer(2427375119u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060010B9 RID: 4281 RVA: 0x00017104 File Offset: 0x00016104
		public unsafe bool TrafficDensity(ushort data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2427375119u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010BA RID: 4282 RVA: 0x00017138 File Offset: 0x00016138
		public unsafe bool UseMatchRatings()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3435269404u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x060010BB RID: 4283 RVA: 0x00017160 File Offset: 0x00016160
		public unsafe bool UseMatchRatings(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3435269404u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010BC RID: 4284 RVA: 0x00017194 File Offset: 0x00016194
		public unsafe int Value()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(1526855638u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060010BD RID: 4285 RVA: 0x000171BC File Offset: 0x000161BC
		public unsafe bool Value(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1526855638u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010BE RID: 4286 RVA: 0x000171F0 File Offset: 0x000161F0
		public unsafe float Value1()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(276671006u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010BF RID: 4287 RVA: 0x0001721C File Offset: 0x0001621C
		public unsafe bool Value1(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(276671006u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010C0 RID: 4288 RVA: 0x00017250 File Offset: 0x00016250
		public unsafe float Value2()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(386574432u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010C1 RID: 4289 RVA: 0x0001727C File Offset: 0x0001627C
		public unsafe bool Value2(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(386574432u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010C2 RID: 4290 RVA: 0x000172B0 File Offset: 0x000162B0
		public unsafe StringKey VehicleKey()
		{
			void* attributePointer = this.instance.GetAttributePointer(478177330u, 0u);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060010C3 RID: 4291 RVA: 0x000172E0 File Offset: 0x000162E0
		public bool VehicleKey(StringKey data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(478177330u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x060010C4 RID: 4292 RVA: 0x00017318 File Offset: 0x00016318
		public unsafe StringKey Vehicles(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2497955733u, index);
			return new StringKey(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060010C5 RID: 4293 RVA: 0x00017348 File Offset: 0x00016348
		public bool Vehicles(StringKey data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2497955733u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x060010C6 RID: 4294 RVA: 0x0001737D File Offset: 0x0001637D
		public uint Num_Vehicles()
		{
			return this.Get(2497955733u).GetLength();
		}

		// Token: 0x060010C7 RID: 4295 RVA: 0x00017390 File Offset: 0x00016390
		public unsafe float Width()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1477886460u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010C8 RID: 4296 RVA: 0x000173BC File Offset: 0x000163BC
		public unsafe bool Width(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1477886460u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010C9 RID: 4297 RVA: 0x000173F0 File Offset: 0x000163F0
		public unsafe uint ZoneId()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(2381234453u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x060010CA RID: 4298 RVA: 0x00017418 File Offset: 0x00016418
		public unsafe bool ZoneId(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2381234453u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x060010CB RID: 4299 RVA: 0x0001744C File Offset: 0x0001644C
		public gameplay Parent
		{
			get
			{
				uint parent = this.instance.GetParent();
				InternalCollection internalCollection = new InternalCollection(1558879558u, parent);
				internalCollection.Load();
				if (internalCollection.IsValid())
				{
					return new gameplay(internalCollection);
				}
				return null;
			}
		}

		// Token: 0x040002C6 RID: 710
		public const uint ClassKey = 1558879558u;

		// Token: 0x040002C7 RID: 711
		private readonly InternalCollection instance;

		// Token: 0x040002C8 RID: 712
		private bool isDisposed;
	}
}

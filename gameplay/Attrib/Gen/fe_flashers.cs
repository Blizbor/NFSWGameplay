using System;
using System.Text;
using EASharp;
using GameCore;
using Interop;

namespace Attrib.Gen
{
	// Token: 0x02000113 RID: 275
	public class fe_flashers : IDisposable
	{
		// Token: 0x06000EC6 RID: 3782 RVA: 0x000116E4 File Offset: 0x000106E4
		public fe_flashers(string collectionName) : this(InternalCollection.Hash(collectionName))
		{
		}

		// Token: 0x06000EC7 RID: 3783 RVA: 0x000116F2 File Offset: 0x000106F2
		public fe_flashers(uint collectionKey)
		{
			this.instance = new InternalCollection(2642658075u, collectionKey);
			if (!this.instance.IsValid())
			{
				this.instance.Load();
			}
		}

		// Token: 0x06000EC8 RID: 3784 RVA: 0x00011723 File Offset: 0x00010723
		public fe_flashers(InternalCollection instance)
		{
			this.instance = instance;
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00011732 File Offset: 0x00010732
		public void Modify(uint dynamicCollectionKey)
		{
			this.Modify(dynamicCollectionKey, 0u);
		}

		// Token: 0x06000ECA RID: 3786 RVA: 0x0001173C File Offset: 0x0001073C
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			this.instance.Modify(dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x06000ECB RID: 3787 RVA: 0x0001174B File Offset: 0x0001074B
		public uint GetClass()
		{
			return this.instance.GetClass();
		}

		// Token: 0x06000ECC RID: 3788 RVA: 0x00011758 File Offset: 0x00010758
		public uint GetCollection()
		{
			return this.instance.GetCollection();
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x00011765 File Offset: 0x00010765
		public uint GetParent()
		{
			return this.instance.GetParent();
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00011772 File Offset: 0x00010772
		public void SetParent(uint parent)
		{
			this.instance.SetParent(parent);
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00011780 File Offset: 0x00010780
		public bool IsValid()
		{
			return this.instance.IsValid();
		}

		// Token: 0x06000ED0 RID: 3792 RVA: 0x0001178D File Offset: 0x0001078D
		public bool IsDynamic()
		{
			return this.instance.IsDynamic();
		}

		// Token: 0x06000ED1 RID: 3793 RVA: 0x0001179A File Offset: 0x0001079A
		public bool Contains(uint attributeKey)
		{
			return this.instance.Contains(attributeKey);
		}

		// Token: 0x06000ED2 RID: 3794 RVA: 0x000117A8 File Offset: 0x000107A8
		public uint LocalAttribCount()
		{
			return this.instance.LocalAttribCount();
		}

		// Token: 0x06000ED3 RID: 3795 RVA: 0x000117B5 File Offset: 0x000107B5
		public bool Add(uint attributeKey, uint count)
		{
			return this.instance.Add(attributeKey, count);
		}

		// Token: 0x06000ED4 RID: 3796 RVA: 0x000117C4 File Offset: 0x000107C4
		public bool Remove(uint attributeKey)
		{
			return this.instance.Remove(attributeKey);
		}

		// Token: 0x06000ED5 RID: 3797 RVA: 0x000117D2 File Offset: 0x000107D2
		public void Unmodify()
		{
			this.instance.Unmodify();
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x000117DF File Offset: 0x000107DF
		public uint GenerateUniqueKey(string name)
		{
			return this.instance.GenerateUniqueKey(name);
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x000117ED File Offset: 0x000107ED
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			this.instance.Reserve(spaceForAdditionalAttributes);
		}

		// Token: 0x06000ED8 RID: 3800 RVA: 0x000117FB File Offset: 0x000107FB
		public void LoadVaultSync()
		{
			this.instance.LoadSync();
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00011808 File Offset: 0x00010808
		public bool IsDerivedFrom(uint key)
		{
			return this.instance.IsDerivedFrom(key);
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00011816 File Offset: 0x00010816
		public GameCore.Attribute Get(uint attributeKey)
		{
			return this.instance.Get(attributeKey);
		}

		// Token: 0x06000EDB RID: 3803 RVA: 0x00011824 File Offset: 0x00010824
		public GameCore.Attribute GetOrClone(uint attributeKey)
		{
			return this.instance.GetOrClone(attributeKey);
		}

		// Token: 0x06000EDC RID: 3804 RVA: 0x00011832 File Offset: 0x00010832
		public InternalCollection GetInternalCollection()
		{
			return this.instance;
		}

		// Token: 0x06000EDD RID: 3805 RVA: 0x0001183A File Offset: 0x0001083A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06000EDE RID: 3806 RVA: 0x00011849 File Offset: 0x00010849
		public void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Unmodify();
				this.isDisposed = true;
			}
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00011864 File Offset: 0x00010864
		public unsafe bool cut_when_priority_equal()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(3509612291u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x0001188C File Offset: 0x0001088C
		public unsafe bool cut_when_priority_equal(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3509612291u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000EE1 RID: 3809 RVA: 0x000118C0 File Offset: 0x000108C0
		public unsafe float display_time()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4009528078u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000EE2 RID: 3810 RVA: 0x000118EC File Offset: 0x000108EC
		public unsafe bool display_time(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4009528078u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000EE3 RID: 3811 RVA: 0x00011920 File Offset: 0x00010920
		public unsafe LocalizationHash hal_string()
		{
			void* attributePointer = this.instance.GetAttributePointer(1250773885u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000EE4 RID: 3812 RVA: 0x00011950 File Offset: 0x00010950
		public bool hal_string(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1250773885u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000EE5 RID: 3813 RVA: 0x00011988 File Offset: 0x00010988
		public unsafe LocalizationHash hal_string_actor()
		{
			void* attributePointer = this.instance.GetAttributePointer(2900900206u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000EE6 RID: 3814 RVA: 0x000119B8 File Offset: 0x000109B8
		public bool hal_string_actor(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2900900206u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000EE7 RID: 3815 RVA: 0x000119F0 File Offset: 0x000109F0
		public unsafe LocalizationHash hal_string_spectator()
		{
			void* attributePointer = this.instance.GetAttributePointer(2352900696u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000EE8 RID: 3816 RVA: 0x00011A20 File Offset: 0x00010A20
		public bool hal_string_spectator(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2352900696u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000EE9 RID: 3817 RVA: 0x00011A58 File Offset: 0x00010A58
		public unsafe LocalizationHash hal_string_target()
		{
			void* attributePointer = this.instance.GetAttributePointer(1040272931u, 0u);
			return new LocalizationHash(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06000EEA RID: 3818 RVA: 0x00011A88 File Offset: 0x00010A88
		public bool hal_string_target(LocalizationHash data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1040272931u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x06000EEB RID: 3819 RVA: 0x00011AC0 File Offset: 0x00010AC0
		public unsafe bool kill_when_cut()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(2111278013u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000EEC RID: 3820 RVA: 0x00011AE8 File Offset: 0x00010AE8
		public unsafe bool kill_when_cut(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2111278013u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000EED RID: 3821 RVA: 0x00011B1C File Offset: 0x00010B1C
		public unsafe string movie_clip_name()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3213091772u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000EEE RID: 3822 RVA: 0x00011B4C File Offset: 0x00010B4C
		public unsafe bool movie_clip_name(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3213091772u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x06000EEF RID: 3823 RVA: 0x00011BC8 File Offset: 0x00010BC8
		public unsafe bool notify_spectators()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(444604881u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06000EF0 RID: 3824 RVA: 0x00011BF0 File Offset: 0x00010BF0
		public unsafe bool notify_spectators(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(444604881u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000EF1 RID: 3825 RVA: 0x00011C24 File Offset: 0x00010C24
		public unsafe int priority()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2842676822u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06000EF2 RID: 3826 RVA: 0x00011C4C File Offset: 0x00010C4C
		public unsafe bool priority(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2842676822u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000EF3 RID: 3827 RVA: 0x00011C80 File Offset: 0x00010C80
		public unsafe FLASHER_ALIGNMENT vertical_alignment()
		{
			FLASHER_ALIGNMENT* attributePointer = (FLASHER_ALIGNMENT*)this.instance.GetAttributePointer(1872513167u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return FLASHER_ALIGNMENT.FLASHER_ALIGN_TOP;
		}

		// Token: 0x06000EF4 RID: 3828 RVA: 0x00011CA8 File Offset: 0x00010CA8
		public unsafe bool vertical_alignment(FLASHER_ALIGNMENT data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1872513167u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06000EF5 RID: 3829 RVA: 0x00011CDC File Offset: 0x00010CDC
		public unsafe float wait_limit()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(162299120u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x00011D08 File Offset: 0x00010D08
		public unsafe bool wait_limit(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(162299120u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000EF7 RID: 3831 RVA: 0x00011D3C File Offset: 0x00010D3C
		public fe_flashers Parent
		{
			get
			{
				uint parent = this.instance.GetParent();
				InternalCollection internalCollection = new InternalCollection(2642658075u, parent);
				internalCollection.Load();
				if (internalCollection.IsValid())
				{
					return new fe_flashers(internalCollection);
				}
				return null;
			}
		}

		// Token: 0x040002A0 RID: 672
		public const uint ClassKey = 2642658075u;

		// Token: 0x040002A1 RID: 673
		private readonly InternalCollection instance;

		// Token: 0x040002A2 RID: 674
		private bool isDisposed;
	}
}

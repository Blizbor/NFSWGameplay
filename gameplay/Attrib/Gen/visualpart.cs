using System;
using GameCore;

namespace Attrib.Gen
{
	// Token: 0x02000122 RID: 290
	public class visualpart : IDisposable
	{
		// Token: 0x060011D7 RID: 4567 RVA: 0x00019E0B File Offset: 0x00018E0B
		public visualpart(string collectionName) : this(InternalCollection.Hash(collectionName))
		{
		}

		// Token: 0x060011D8 RID: 4568 RVA: 0x00019E19 File Offset: 0x00018E19
		public visualpart(uint collectionKey)
		{
			this.instance = new InternalCollection(398999498u, collectionKey);
			if (!this.instance.IsValid())
			{
				this.instance.Load();
			}
		}

		// Token: 0x060011D9 RID: 4569 RVA: 0x00019E4A File Offset: 0x00018E4A
		public visualpart(InternalCollection instance)
		{
			this.instance = instance;
		}

		// Token: 0x060011DA RID: 4570 RVA: 0x00019E59 File Offset: 0x00018E59
		public void Modify(uint dynamicCollectionKey)
		{
			this.Modify(dynamicCollectionKey, 0u);
		}

		// Token: 0x060011DB RID: 4571 RVA: 0x00019E63 File Offset: 0x00018E63
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			this.instance.Modify(dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x060011DC RID: 4572 RVA: 0x00019E72 File Offset: 0x00018E72
		public uint GetClass()
		{
			return this.instance.GetClass();
		}

		// Token: 0x060011DD RID: 4573 RVA: 0x00019E7F File Offset: 0x00018E7F
		public uint GetCollection()
		{
			return this.instance.GetCollection();
		}

		// Token: 0x060011DE RID: 4574 RVA: 0x00019E8C File Offset: 0x00018E8C
		public uint GetParent()
		{
			return this.instance.GetParent();
		}

		// Token: 0x060011DF RID: 4575 RVA: 0x00019E99 File Offset: 0x00018E99
		public void SetParent(uint parent)
		{
			this.instance.SetParent(parent);
		}

		// Token: 0x060011E0 RID: 4576 RVA: 0x00019EA7 File Offset: 0x00018EA7
		public bool IsValid()
		{
			return this.instance.IsValid();
		}

		// Token: 0x060011E1 RID: 4577 RVA: 0x00019EB4 File Offset: 0x00018EB4
		public bool IsDynamic()
		{
			return this.instance.IsDynamic();
		}

		// Token: 0x060011E2 RID: 4578 RVA: 0x00019EC1 File Offset: 0x00018EC1
		public bool Contains(uint attributeKey)
		{
			return this.instance.Contains(attributeKey);
		}

		// Token: 0x060011E3 RID: 4579 RVA: 0x00019ECF File Offset: 0x00018ECF
		public uint LocalAttribCount()
		{
			return this.instance.LocalAttribCount();
		}

		// Token: 0x060011E4 RID: 4580 RVA: 0x00019EDC File Offset: 0x00018EDC
		public bool Add(uint attributeKey, uint count)
		{
			return this.instance.Add(attributeKey, count);
		}

		// Token: 0x060011E5 RID: 4581 RVA: 0x00019EEB File Offset: 0x00018EEB
		public bool Remove(uint attributeKey)
		{
			return this.instance.Remove(attributeKey);
		}

		// Token: 0x060011E6 RID: 4582 RVA: 0x00019EF9 File Offset: 0x00018EF9
		public void Unmodify()
		{
			this.instance.Unmodify();
		}

		// Token: 0x060011E7 RID: 4583 RVA: 0x00019F06 File Offset: 0x00018F06
		public uint GenerateUniqueKey(string name)
		{
			return this.instance.GenerateUniqueKey(name);
		}

		// Token: 0x060011E8 RID: 4584 RVA: 0x00019F14 File Offset: 0x00018F14
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			this.instance.Reserve(spaceForAdditionalAttributes);
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x00019F22 File Offset: 0x00018F22
		public void LoadVaultSync()
		{
			this.instance.LoadSync();
		}

		// Token: 0x060011EA RID: 4586 RVA: 0x00019F2F File Offset: 0x00018F2F
		public bool IsDerivedFrom(uint key)
		{
			return this.instance.IsDerivedFrom(key);
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x00019F3D File Offset: 0x00018F3D
		public GameCore.Attribute Get(uint attributeKey)
		{
			return this.instance.Get(attributeKey);
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x00019F4B File Offset: 0x00018F4B
		public GameCore.Attribute GetOrClone(uint attributeKey)
		{
			return this.instance.GetOrClone(attributeKey);
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x00019F59 File Offset: 0x00018F59
		public InternalCollection GetInternalCollection()
		{
			return this.instance;
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x00019F61 File Offset: 0x00018F61
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x00019F70 File Offset: 0x00018F70
		public void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Unmodify();
				this.isDisposed = true;
			}
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x00019F8C File Offset: 0x00018F8C
		public unsafe uint baseCarHashes(uint index)
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(56198732u, index);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x060011F1 RID: 4593 RVA: 0x00019FB4 File Offset: 0x00018FB4
		public unsafe bool baseCarHashes(uint data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(56198732u);
			return orClone.IsValid() && orClone.Set(index, (void*)(&data));
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x00019FE6 File Offset: 0x00018FE6
		public uint Num_baseCarHashes()
		{
			return this.Get(56198732u).GetLength();
		}

		// Token: 0x060011F3 RID: 4595 RVA: 0x00019FF8 File Offset: 0x00018FF8
		public unsafe uint visualPartHash()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(1096977847u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x060011F4 RID: 4596 RVA: 0x0001A020 File Offset: 0x00019020
		public unsafe bool visualPartHash(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1096977847u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0001A054 File Offset: 0x00019054
		public visualpart Parent
		{
			get
			{
				uint parent = this.instance.GetParent();
				InternalCollection internalCollection = new InternalCollection(398999498u, parent);
				internalCollection.Load();
				if (internalCollection.IsValid())
				{
					return new visualpart(internalCollection);
				}
				return null;
			}
		}

		// Token: 0x04000411 RID: 1041
		public const uint ClassKey = 398999498u;

		// Token: 0x04000412 RID: 1042
		private readonly InternalCollection instance;

		// Token: 0x04000413 RID: 1043
		private bool isDisposed;
	}
}

using System;
using GameCore;
using PowerUps;

namespace Attrib.Gen
{
	// Token: 0x02000119 RID: 281
	public class powerup_gamegroup : IDisposable
	{
		// Token: 0x060010CC RID: 4300 RVA: 0x00017487 File Offset: 0x00016487
		public powerup_gamegroup(string collectionName) : this(InternalCollection.Hash(collectionName))
		{
		}

		// Token: 0x060010CD RID: 4301 RVA: 0x00017495 File Offset: 0x00016495
		public powerup_gamegroup(uint collectionKey)
		{
			this.instance = new InternalCollection(2996496194u, collectionKey);
			if (!this.instance.IsValid())
			{
				this.instance.Load();
			}
		}

		// Token: 0x060010CE RID: 4302 RVA: 0x000174C6 File Offset: 0x000164C6
		public powerup_gamegroup(InternalCollection instance)
		{
			this.instance = instance;
		}

		// Token: 0x060010CF RID: 4303 RVA: 0x000174D5 File Offset: 0x000164D5
		public void Modify(uint dynamicCollectionKey)
		{
			this.Modify(dynamicCollectionKey, 0u);
		}

		// Token: 0x060010D0 RID: 4304 RVA: 0x000174DF File Offset: 0x000164DF
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			this.instance.Modify(dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x060010D1 RID: 4305 RVA: 0x000174EE File Offset: 0x000164EE
		public uint GetClass()
		{
			return this.instance.GetClass();
		}

		// Token: 0x060010D2 RID: 4306 RVA: 0x000174FB File Offset: 0x000164FB
		public uint GetCollection()
		{
			return this.instance.GetCollection();
		}

		// Token: 0x060010D3 RID: 4307 RVA: 0x00017508 File Offset: 0x00016508
		public uint GetParent()
		{
			return this.instance.GetParent();
		}

		// Token: 0x060010D4 RID: 4308 RVA: 0x00017515 File Offset: 0x00016515
		public void SetParent(uint parent)
		{
			this.instance.SetParent(parent);
		}

		// Token: 0x060010D5 RID: 4309 RVA: 0x00017523 File Offset: 0x00016523
		public bool IsValid()
		{
			return this.instance.IsValid();
		}

		// Token: 0x060010D6 RID: 4310 RVA: 0x00017530 File Offset: 0x00016530
		public bool IsDynamic()
		{
			return this.instance.IsDynamic();
		}

		// Token: 0x060010D7 RID: 4311 RVA: 0x0001753D File Offset: 0x0001653D
		public bool Contains(uint attributeKey)
		{
			return this.instance.Contains(attributeKey);
		}

		// Token: 0x060010D8 RID: 4312 RVA: 0x0001754B File Offset: 0x0001654B
		public uint LocalAttribCount()
		{
			return this.instance.LocalAttribCount();
		}

		// Token: 0x060010D9 RID: 4313 RVA: 0x00017558 File Offset: 0x00016558
		public bool Add(uint attributeKey, uint count)
		{
			return this.instance.Add(attributeKey, count);
		}

		// Token: 0x060010DA RID: 4314 RVA: 0x00017567 File Offset: 0x00016567
		public bool Remove(uint attributeKey)
		{
			return this.instance.Remove(attributeKey);
		}

		// Token: 0x060010DB RID: 4315 RVA: 0x00017575 File Offset: 0x00016575
		public void Unmodify()
		{
			this.instance.Unmodify();
		}

		// Token: 0x060010DC RID: 4316 RVA: 0x00017582 File Offset: 0x00016582
		public uint GenerateUniqueKey(string name)
		{
			return this.instance.GenerateUniqueKey(name);
		}

		// Token: 0x060010DD RID: 4317 RVA: 0x00017590 File Offset: 0x00016590
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			this.instance.Reserve(spaceForAdditionalAttributes);
		}

		// Token: 0x060010DE RID: 4318 RVA: 0x0001759E File Offset: 0x0001659E
		public void LoadVaultSync()
		{
			this.instance.LoadSync();
		}

		// Token: 0x060010DF RID: 4319 RVA: 0x000175AB File Offset: 0x000165AB
		public bool IsDerivedFrom(uint key)
		{
			return this.instance.IsDerivedFrom(key);
		}

		// Token: 0x060010E0 RID: 4320 RVA: 0x000175B9 File Offset: 0x000165B9
		public GameCore.Attribute Get(uint attributeKey)
		{
			return this.instance.Get(attributeKey);
		}

		// Token: 0x060010E1 RID: 4321 RVA: 0x000175C7 File Offset: 0x000165C7
		public GameCore.Attribute GetOrClone(uint attributeKey)
		{
			return this.instance.GetOrClone(attributeKey);
		}

		// Token: 0x060010E2 RID: 4322 RVA: 0x000175D5 File Offset: 0x000165D5
		public InternalCollection GetInternalCollection()
		{
			return this.instance;
		}

		// Token: 0x060010E3 RID: 4323 RVA: 0x000175DD File Offset: 0x000165DD
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060010E4 RID: 4324 RVA: 0x000175EC File Offset: 0x000165EC
		public void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Unmodify();
				this.isDisposed = true;
			}
		}

		// Token: 0x060010E5 RID: 4325 RVA: 0x00017608 File Offset: 0x00016608
		public unsafe GameplayEffect effect()
		{
			GameplayEffect* attributePointer = (GameplayEffect*)this.instance.GetAttributePointer(2682717733u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return GameplayEffect.kGameplayEffect_None;
		}

		// Token: 0x060010E6 RID: 4326 RVA: 0x00017630 File Offset: 0x00016630
		public unsafe bool effect(GameplayEffect data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2682717733u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060010E7 RID: 4327 RVA: 0x00017664 File Offset: 0x00016664
		public unsafe float magnitude(uint index)
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3467684272u, index);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010E8 RID: 4328 RVA: 0x00017690 File Offset: 0x00016690
		public unsafe bool magnitude(float data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3467684272u);
			return orClone.IsValid() && orClone.Set(index, (void*)(&data));
		}

		// Token: 0x060010E9 RID: 4329 RVA: 0x000176C2 File Offset: 0x000166C2
		public uint Num_magnitude()
		{
			return this.Get(3467684272u).GetLength();
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x000176D4 File Offset: 0x000166D4
		public unsafe float range(uint index)
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2392866720u, index);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00017700 File Offset: 0x00016700
		public unsafe bool range(float data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2392866720u);
			return orClone.IsValid() && orClone.Set(index, (void*)(&data));
		}

		// Token: 0x060010EC RID: 4332 RVA: 0x00017732 File Offset: 0x00016732
		public uint Num_range()
		{
			return this.Get(2392866720u).GetLength();
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x060010ED RID: 4333 RVA: 0x00017744 File Offset: 0x00016744
		public powerup_gamegroup Parent
		{
			get
			{
				uint parent = this.instance.GetParent();
				InternalCollection internalCollection = new InternalCollection(2996496194u, parent);
				internalCollection.Load();
				if (internalCollection.IsValid())
				{
					return new powerup_gamegroup(internalCollection);
				}
				return null;
			}
		}

		// Token: 0x040003A8 RID: 936
		public const uint ClassKey = 2996496194u;

		// Token: 0x040003A9 RID: 937
		private readonly InternalCollection instance;

		// Token: 0x040003AA RID: 938
		private bool isDisposed;
	}
}

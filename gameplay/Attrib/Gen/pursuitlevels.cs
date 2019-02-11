using System;
using System.Text;
using EASharp;
using GameCore;
using GameCore.Pursuit;

namespace Attrib.Gen
{
	// Token: 0x0200011E RID: 286
	public class pursuitlevels : IDisposable
	{
		// Token: 0x060010EE RID: 4334 RVA: 0x0001777F File Offset: 0x0001677F
		public pursuitlevels(string collectionName) : this(InternalCollection.Hash(collectionName))
		{
		}

		// Token: 0x060010EF RID: 4335 RVA: 0x0001778D File Offset: 0x0001678D
		public pursuitlevels(uint collectionKey)
		{
			this.instance = new InternalCollection(1428038323u, collectionKey);
			if (!this.instance.IsValid())
			{
				this.instance.Load();
			}
		}

		// Token: 0x060010F0 RID: 4336 RVA: 0x000177BE File Offset: 0x000167BE
		public pursuitlevels(InternalCollection instance)
		{
			this.instance = instance;
		}

		// Token: 0x060010F1 RID: 4337 RVA: 0x000177CD File Offset: 0x000167CD
		public void Modify(uint dynamicCollectionKey)
		{
			this.Modify(dynamicCollectionKey, 0u);
		}

		// Token: 0x060010F2 RID: 4338 RVA: 0x000177D7 File Offset: 0x000167D7
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			this.instance.Modify(dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x060010F3 RID: 4339 RVA: 0x000177E6 File Offset: 0x000167E6
		public uint GetClass()
		{
			return this.instance.GetClass();
		}

		// Token: 0x060010F4 RID: 4340 RVA: 0x000177F3 File Offset: 0x000167F3
		public uint GetCollection()
		{
			return this.instance.GetCollection();
		}

		// Token: 0x060010F5 RID: 4341 RVA: 0x00017800 File Offset: 0x00016800
		public uint GetParent()
		{
			return this.instance.GetParent();
		}

		// Token: 0x060010F6 RID: 4342 RVA: 0x0001780D File Offset: 0x0001680D
		public void SetParent(uint parent)
		{
			this.instance.SetParent(parent);
		}

		// Token: 0x060010F7 RID: 4343 RVA: 0x0001781B File Offset: 0x0001681B
		public bool IsValid()
		{
			return this.instance.IsValid();
		}

		// Token: 0x060010F8 RID: 4344 RVA: 0x00017828 File Offset: 0x00016828
		public bool IsDynamic()
		{
			return this.instance.IsDynamic();
		}

		// Token: 0x060010F9 RID: 4345 RVA: 0x00017835 File Offset: 0x00016835
		public bool Contains(uint attributeKey)
		{
			return this.instance.Contains(attributeKey);
		}

		// Token: 0x060010FA RID: 4346 RVA: 0x00017843 File Offset: 0x00016843
		public uint LocalAttribCount()
		{
			return this.instance.LocalAttribCount();
		}

		// Token: 0x060010FB RID: 4347 RVA: 0x00017850 File Offset: 0x00016850
		public bool Add(uint attributeKey, uint count)
		{
			return this.instance.Add(attributeKey, count);
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x0001785F File Offset: 0x0001685F
		public bool Remove(uint attributeKey)
		{
			return this.instance.Remove(attributeKey);
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x0001786D File Offset: 0x0001686D
		public void Unmodify()
		{
			this.instance.Unmodify();
		}

		// Token: 0x060010FE RID: 4350 RVA: 0x0001787A File Offset: 0x0001687A
		public uint GenerateUniqueKey(string name)
		{
			return this.instance.GenerateUniqueKey(name);
		}

		// Token: 0x060010FF RID: 4351 RVA: 0x00017888 File Offset: 0x00016888
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			this.instance.Reserve(spaceForAdditionalAttributes);
		}

		// Token: 0x06001100 RID: 4352 RVA: 0x00017896 File Offset: 0x00016896
		public void LoadVaultSync()
		{
			this.instance.LoadSync();
		}

		// Token: 0x06001101 RID: 4353 RVA: 0x000178A3 File Offset: 0x000168A3
		public bool IsDerivedFrom(uint key)
		{
			return this.instance.IsDerivedFrom(key);
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x000178B1 File Offset: 0x000168B1
		public GameCore.Attribute Get(uint attributeKey)
		{
			return this.instance.Get(attributeKey);
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x000178BF File Offset: 0x000168BF
		public GameCore.Attribute GetOrClone(uint attributeKey)
		{
			return this.instance.GetOrClone(attributeKey);
		}

		// Token: 0x06001104 RID: 4356 RVA: 0x000178CD File Offset: 0x000168CD
		public InternalCollection GetInternalCollection()
		{
			return this.instance;
		}

		// Token: 0x06001105 RID: 4357 RVA: 0x000178D5 File Offset: 0x000168D5
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001106 RID: 4358 RVA: 0x000178E4 File Offset: 0x000168E4
		public void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Unmodify();
				this.isDisposed = true;
			}
		}

		// Token: 0x06001107 RID: 4359 RVA: 0x00017900 File Offset: 0x00016900
		public unsafe float BackupCallTimer()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2892897991u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001108 RID: 4360 RVA: 0x0001792C File Offset: 0x0001692C
		public unsafe bool BackupCallTimer(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2892897991u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001109 RID: 4361 RVA: 0x00017960 File Offset: 0x00016960
		public unsafe float BoxinDuration()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2240483479u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600110A RID: 4362 RVA: 0x0001798C File Offset: 0x0001698C
		public unsafe bool BoxinDuration(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2240483479u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600110B RID: 4363 RVA: 0x000179C0 File Offset: 0x000169C0
		public unsafe float BoxinTightness()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1738626896u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600110C RID: 4364 RVA: 0x000179EC File Offset: 0x000169EC
		public unsafe bool BoxinTightness(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1738626896u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600110D RID: 4365 RVA: 0x00017A20 File Offset: 0x00016A20
		public unsafe float BustedCopDistance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(194841752u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600110E RID: 4366 RVA: 0x00017A4C File Offset: 0x00016A4C
		public unsafe bool BustedCopDistance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(194841752u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600110F RID: 4367 RVA: 0x00017A80 File Offset: 0x00016A80
		public unsafe float BustedTimeout()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2257544648u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001110 RID: 4368 RVA: 0x00017AAC File Offset: 0x00016AAC
		public unsafe bool BustedTimeout(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2257544648u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x00017AE0 File Offset: 0x00016AE0
		public unsafe float BustSpeed()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1990102430u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x00017B0C File Offset: 0x00016B0C
		public unsafe bool BustSpeed(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1990102430u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x00017B40 File Offset: 0x00016B40
		public unsafe float CollapseAggression()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1498289298u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x00017B6C File Offset: 0x00016B6C
		public unsafe bool CollapseAggression(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1498289298u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x00017BA0 File Offset: 0x00016BA0
		public unsafe int CollapseInnerRadius()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(504034914u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x00017BC8 File Offset: 0x00016BC8
		public unsafe bool CollapseInnerRadius(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(504034914u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x00017BFC File Offset: 0x00016BFC
		public unsafe float CollapseOuterRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2490712818u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x00017C28 File Offset: 0x00016C28
		public unsafe bool CollapseOuterRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2490712818u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x00017C5C File Offset: 0x00016C5C
		public unsafe float CollapseSpeed()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3680933132u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x00017C88 File Offset: 0x00016C88
		public unsafe bool CollapseSpeed(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3680933132u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x00017CBC File Offset: 0x00016CBC
		public unsafe string CollectionName()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(2627848441u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x00017CEC File Offset: 0x00016CEC
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

		// Token: 0x0600111D RID: 4381 RVA: 0x00017D68 File Offset: 0x00016D68
		public unsafe CopFormationRecord CopFormations(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(1546287474u, index);
			return new CopFormationRecord(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x00017D98 File Offset: 0x00016D98
		public bool CopFormations(CopFormationRecord data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1546287474u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x00017DCD File Offset: 0x00016DCD
		public uint Num_CopFormations()
		{
			return this.Get(1546287474u).GetLength();
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x00017DE0 File Offset: 0x00016DE0
		public unsafe CopCountRecord cops(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(2843810707u, index);
			return new CopCountRecord(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x00017E10 File Offset: 0x00016E10
		public bool cops(CopCountRecord data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2843810707u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x00017E45 File Offset: 0x00016E45
		public uint Num_cops()
		{
			return this.Get(2843810707u).GetLength();
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x00017E58 File Offset: 0x00016E58
		public unsafe int CTSFor911()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2685266227u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x00017E80 File Offset: 0x00016E80
		public unsafe bool CTSFor911(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2685266227u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x00017EB4 File Offset: 0x00016EB4
		public unsafe float DestroyCopBonusTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3203892754u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x00017EE0 File Offset: 0x00016EE0
		public unsafe bool DestroyCopBonusTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3203892754u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001127 RID: 4391 RVA: 0x00017F14 File Offset: 0x00016F14
		public unsafe float evadetimeout()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2701769934u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001128 RID: 4392 RVA: 0x00017F40 File Offset: 0x00016F40
		public unsafe bool evadetimeout(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2701769934u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x00017F74 File Offset: 0x00016F74
		public unsafe float frontLOSdistance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2418449093u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600112A RID: 4394 RVA: 0x00017FA0 File Offset: 0x00016FA0
		public unsafe bool frontLOSdistance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2418449093u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600112B RID: 4395 RVA: 0x00017FD4 File Offset: 0x00016FD4
		public unsafe int FullEngagementCopCount()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(1946068699u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x0600112C RID: 4396 RVA: 0x00017FFC File Offset: 0x00016FFC
		public unsafe bool FullEngagementCopCount(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1946068699u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600112D RID: 4397 RVA: 0x00018030 File Offset: 0x00017030
		public unsafe float FullEngagementRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(30327476u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600112E RID: 4398 RVA: 0x0001805C File Offset: 0x0001705C
		public unsafe bool FullEngagementRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(30327476u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600112F RID: 4399 RVA: 0x00018090 File Offset: 0x00017090
		public unsafe float HeavySupportCheckTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2143696304u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001130 RID: 4400 RVA: 0x000180BC File Offset: 0x000170BC
		public unsafe bool HeavySupportCheckTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2143696304u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001131 RID: 4401 RVA: 0x000180F0 File Offset: 0x000170F0
		public unsafe float HeliFuelTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3882281848u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001132 RID: 4402 RVA: 0x0001811C File Offset: 0x0001711C
		public unsafe bool HeliFuelTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3882281848u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001133 RID: 4403 RVA: 0x00018150 File Offset: 0x00017150
		public unsafe float heliLOSdistance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2688850802u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001134 RID: 4404 RVA: 0x0001817C File Offset: 0x0001717C
		public unsafe bool heliLOSdistance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2688850802u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001135 RID: 4405 RVA: 0x000181B0 File Offset: 0x000171B0
		public unsafe float HiddenZoneTimeMultiplier()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2144264784u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001136 RID: 4406 RVA: 0x000181DC File Offset: 0x000171DC
		public unsafe bool HiddenZoneTimeMultiplier(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2144264784u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001137 RID: 4407 RVA: 0x00018210 File Offset: 0x00017210
		public unsafe bool IgnorePerpInSightForHeavySupportRequest()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(802856596u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x06001138 RID: 4408 RVA: 0x00018238 File Offset: 0x00017238
		public unsafe bool IgnorePerpInSightForHeavySupportRequest(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(802856596u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001139 RID: 4409 RVA: 0x0001826C File Offset: 0x0001726C
		public unsafe float Lifetime911()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(243413799u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600113A RID: 4410 RVA: 0x00018298 File Offset: 0x00017298
		public unsafe bool Lifetime911(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(243413799u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600113B RID: 4411 RVA: 0x000182CC File Offset: 0x000172CC
		public unsafe float MaxActiveCopCars()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4183955182u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600113C RID: 4412 RVA: 0x000182F8 File Offset: 0x000172F8
		public unsafe bool MaxActiveCopCars(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4183955182u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600113D RID: 4413 RVA: 0x0001832C File Offset: 0x0001732C
		public unsafe int MaxCopsCollapsing()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(209179747u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x0600113E RID: 4414 RVA: 0x00018354 File Offset: 0x00017354
		public unsafe bool MaxCopsCollapsing(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(209179747u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600113F RID: 4415 RVA: 0x00018388 File Offset: 0x00017388
		public unsafe float MeterBustDecrement()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1356940510u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001140 RID: 4416 RVA: 0x000183B4 File Offset: 0x000173B4
		public unsafe bool MeterBustDecrement(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1356940510u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001141 RID: 4417 RVA: 0x000183E8 File Offset: 0x000173E8
		public unsafe float MeterBustIncrement()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(357095096u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001142 RID: 4418 RVA: 0x00018414 File Offset: 0x00017414
		public unsafe bool MeterBustIncrement(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(357095096u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001143 RID: 4419 RVA: 0x00018448 File Offset: 0x00017448
		public unsafe float MeterBustRadiusSpeedThreshold()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3489172983u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001144 RID: 4420 RVA: 0x00018474 File Offset: 0x00017474
		public unsafe bool MeterBustRadiusSpeedThreshold(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3489172983u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001145 RID: 4421 RVA: 0x000184A8 File Offset: 0x000174A8
		public unsafe float MeterDeadZoneBustedDistance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2363695519u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001146 RID: 4422 RVA: 0x000184D4 File Offset: 0x000174D4
		public unsafe bool MeterDeadZoneBustedDistance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2363695519u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001147 RID: 4423 RVA: 0x00018508 File Offset: 0x00017508
		public unsafe float MeterDeadZoneEvadeDist()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3986743964u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001148 RID: 4424 RVA: 0x00018534 File Offset: 0x00017534
		public unsafe bool MeterDeadZoneEvadeDist(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3986743964u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001149 RID: 4425 RVA: 0x00018568 File Offset: 0x00017568
		public unsafe float MeterMaxBustRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1560323819u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600114A RID: 4426 RVA: 0x00018594 File Offset: 0x00017594
		public unsafe bool MeterMaxBustRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1560323819u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600114B RID: 4427 RVA: 0x000185C8 File Offset: 0x000175C8
		public unsafe byte MeterMaxNumCopsBustMultiplier()
		{
			byte* attributePointer = (byte*)this.instance.GetAttributePointer(788593569u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x0600114C RID: 4428 RVA: 0x000185F0 File Offset: 0x000175F0
		public unsafe bool MeterMaxNumCopsBustMultiplier(byte data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(788593569u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600114D RID: 4429 RVA: 0x00018624 File Offset: 0x00017624
		public unsafe float MeterMinBustRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2693180149u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600114E RID: 4430 RVA: 0x00018650 File Offset: 0x00017650
		public unsafe bool MeterMinBustRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2693180149u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600114F RID: 4431 RVA: 0x00018684 File Offset: 0x00017684
		public unsafe float MeterMinEvadeRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1589910891u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001150 RID: 4432 RVA: 0x000186B0 File Offset: 0x000176B0
		public unsafe bool MeterMinEvadeRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1589910891u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001151 RID: 4433 RVA: 0x000186E4 File Offset: 0x000176E4
		public unsafe sbyte NumCiviHitsFor911()
		{
			sbyte* attributePointer = (sbyte*)this.instance.GetAttributePointer(1851330391u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001152 RID: 4434 RVA: 0x0001870C File Offset: 0x0001770C
		public unsafe bool NumCiviHitsFor911(sbyte data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1851330391u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001153 RID: 4435 RVA: 0x00018740 File Offset: 0x00017740
		public unsafe int NumCopsToTriggerBackup()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(3295084892u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001154 RID: 4436 RVA: 0x00018768 File Offset: 0x00017768
		public unsafe bool NumCopsToTriggerBackup(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3295084892u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001155 RID: 4437 RVA: 0x0001879C File Offset: 0x0001779C
		public unsafe int NumPatrolCars()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(620208572u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001156 RID: 4438 RVA: 0x000187C4 File Offset: 0x000177C4
		public unsafe bool NumPatrolCars(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(620208572u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001157 RID: 4439 RVA: 0x000187F8 File Offset: 0x000177F8
		public unsafe KeyValuePair PursuitWave_CopTypes(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(477991609u, index);
			return new KeyValuePair(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001158 RID: 4440 RVA: 0x00018828 File Offset: 0x00017828
		public bool PursuitWave_CopTypes(KeyValuePair data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(477991609u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001159 RID: 4441 RVA: 0x0001885D File Offset: 0x0001785D
		public uint Num_PursuitWave_CopTypes()
		{
			return this.Get(477991609u).GetLength();
		}

		// Token: 0x0600115A RID: 4442 RVA: 0x00018870 File Offset: 0x00017870
		public unsafe int PursuitWave_NumLocalCops()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(3898412579u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x0600115B RID: 4443 RVA: 0x00018898 File Offset: 0x00017898
		public unsafe bool PursuitWave_NumLocalCops(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3898412579u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600115C RID: 4444 RVA: 0x000188CC File Offset: 0x000178CC
		public unsafe float PursuitWave_Time()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(443187748u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600115D RID: 4445 RVA: 0x000188F8 File Offset: 0x000178F8
		public unsafe bool PursuitWave_Time(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(443187748u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600115E RID: 4446 RVA: 0x0001892C File Offset: 0x0001792C
		public unsafe float rearLOSdistance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3698032427u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600115F RID: 4447 RVA: 0x00018958 File Offset: 0x00017958
		public unsafe bool rearLOSdistance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3698032427u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001160 RID: 4448 RVA: 0x0001898C File Offset: 0x0001798C
		public unsafe KeyValuePair RhinoWave_CopTypes(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(3912764944u, index);
			return new KeyValuePair(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001161 RID: 4449 RVA: 0x000189BC File Offset: 0x000179BC
		public bool RhinoWave_CopTypes(KeyValuePair data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3912764944u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001162 RID: 4450 RVA: 0x000189F1 File Offset: 0x000179F1
		public uint Num_RhinoWave_CopTypes()
		{
			return this.Get(3912764944u).GetLength();
		}

		// Token: 0x06001163 RID: 4451 RVA: 0x00018A04 File Offset: 0x00017A04
		public unsafe int RhinoWave_NumLocalCops()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(1546874944u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x00018A2C File Offset: 0x00017A2C
		public unsafe bool RhinoWave_NumLocalCops(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1546874944u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x00018A60 File Offset: 0x00017A60
		public unsafe float RhinoWave_Time()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(721050678u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001166 RID: 4454 RVA: 0x00018A8C File Offset: 0x00017A8C
		public unsafe bool RhinoWave_Time(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(721050678u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001167 RID: 4455 RVA: 0x00018AC0 File Offset: 0x00017AC0
		public unsafe KeyValuePair Roadblock_CopTypes(uint index)
		{
			void* attributePointer = this.instance.GetAttributePointer(485533817u, index);
			return new KeyValuePair(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x06001168 RID: 4456 RVA: 0x00018AF0 File Offset: 0x00017AF0
		public bool Roadblock_CopTypes(KeyValuePair data, uint index)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(485533817u);
			return orClone.IsValid() && orClone.Set(index, data._GetRaw());
		}

		// Token: 0x06001169 RID: 4457 RVA: 0x00018B25 File Offset: 0x00017B25
		public uint Num_Roadblock_CopTypes()
		{
			return this.Get(485533817u).GetLength();
		}

		// Token: 0x0600116A RID: 4458 RVA: 0x00018B38 File Offset: 0x00017B38
		public unsafe uint Roadblock_MaxBlocks()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(1262513653u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x0600116B RID: 4459 RVA: 0x00018B60 File Offset: 0x00017B60
		public unsafe bool Roadblock_MaxBlocks(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1262513653u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600116C RID: 4460 RVA: 0x00018B94 File Offset: 0x00017B94
		public unsafe float Roadblock_SpikeChance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(726943927u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600116D RID: 4461 RVA: 0x00018BC0 File Offset: 0x00017BC0
		public unsafe bool Roadblock_SpikeChance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(726943927u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600116E RID: 4462 RVA: 0x00018BF4 File Offset: 0x00017BF4
		public unsafe float Roadblock_Time()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4021271370u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600116F RID: 4463 RVA: 0x00018C20 File Offset: 0x00017C20
		public unsafe bool Roadblock_Time(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4021271370u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001170 RID: 4464 RVA: 0x00018C54 File Offset: 0x00017C54
		public unsafe float roadblockbreakofftimer()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3962952840u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001171 RID: 4465 RVA: 0x00018C80 File Offset: 0x00017C80
		public unsafe bool roadblockbreakofftimer(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3962952840u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001172 RID: 4466 RVA: 0x00018CB4 File Offset: 0x00017CB4
		public unsafe float roadblockheavyintervaltimer()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(951536938u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001173 RID: 4467 RVA: 0x00018CE0 File Offset: 0x00017CE0
		public unsafe bool roadblockheavyintervaltimer(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(951536938u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001174 RID: 4468 RVA: 0x00018D14 File Offset: 0x00017D14
		public unsafe float roadblockhelichance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1410702065u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001175 RID: 4469 RVA: 0x00018D40 File Offset: 0x00017D40
		public unsafe bool roadblockhelichance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1410702065u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001176 RID: 4470 RVA: 0x00018D74 File Offset: 0x00017D74
		public unsafe float roadblockintervaltimer()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1717572540u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00018DA0 File Offset: 0x00017DA0
		public unsafe bool roadblockintervaltimer(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1717572540u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00018DD4 File Offset: 0x00017DD4
		public unsafe float roadblockprobability()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2963084989u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00018E00 File Offset: 0x00017E00
		public unsafe bool roadblockprobability(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2963084989u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00018E34 File Offset: 0x00017E34
		public unsafe float roadblockspikechance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1513196278u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00018E60 File Offset: 0x00017E60
		public unsafe bool roadblockspikechance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1513196278u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00018E94 File Offset: 0x00017E94
		public unsafe float RollingBlockDuration()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1553948501u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00018EC0 File Offset: 0x00017EC0
		public unsafe bool RollingBlockDuration(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1553948501u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00018EF4 File Offset: 0x00017EF4
		public unsafe float RollingBlockTightness()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3242654723u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600117F RID: 4479 RVA: 0x00018F20 File Offset: 0x00017F20
		public unsafe bool RollingBlockTightness(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3242654723u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00018F54 File Offset: 0x00017F54
		public unsafe float SearchModeHeliSpawnChance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1058143228u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00018F80 File Offset: 0x00017F80
		public unsafe bool SearchModeHeliSpawnChance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1058143228u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00018FB4 File Offset: 0x00017FB4
		public unsafe float SearchModeRoadblockChance()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4103289293u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00018FE0 File Offset: 0x00017FE0
		public unsafe bool SearchModeRoadblockChance(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4103289293u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001184 RID: 4484 RVA: 0x00019014 File Offset: 0x00018014
		public unsafe float SearchModeRoadblockRadius()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2294541977u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001185 RID: 4485 RVA: 0x00019040 File Offset: 0x00018040
		public unsafe bool SearchModeRoadblockRadius(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2294541977u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001186 RID: 4486 RVA: 0x00019074 File Offset: 0x00018074
		public unsafe float SirenInitMinPeriod()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1083613841u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001187 RID: 4487 RVA: 0x000190A0 File Offset: 0x000180A0
		public unsafe bool SirenInitMinPeriod(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1083613841u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001188 RID: 4488 RVA: 0x000190D4 File Offset: 0x000180D4
		public unsafe float SirenInitVariation()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3125466005u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00019100 File Offset: 0x00018100
		public unsafe bool SirenInitVariation(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3125466005u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00019134 File Offset: 0x00018134
		public unsafe float SirenMaxScreamTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(3143663401u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00019160 File Offset: 0x00018160
		public unsafe bool SirenMaxScreamTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3143663401u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00019194 File Offset: 0x00018194
		public unsafe float SirenMaxYelpTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2132101845u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x000191C0 File Offset: 0x000181C0
		public unsafe bool SirenMaxYelpTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2132101845u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x000191F4 File Offset: 0x000181F4
		public unsafe float SirenScreamPeriod()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1441289301u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600118F RID: 4495 RVA: 0x00019220 File Offset: 0x00018220
		public unsafe bool SirenScreamPeriod(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1441289301u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001190 RID: 4496 RVA: 0x00019254 File Offset: 0x00018254
		public unsafe float SirenWailPeriod()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1014411645u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001191 RID: 4497 RVA: 0x00019280 File Offset: 0x00018280
		public unsafe bool SirenWailPeriod(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1014411645u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001192 RID: 4498 RVA: 0x000192B4 File Offset: 0x000182B4
		public unsafe float SpeedReactionTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(257383268u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001193 RID: 4499 RVA: 0x000192E0 File Offset: 0x000182E0
		public unsafe bool SpeedReactionTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(257383268u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001194 RID: 4500 RVA: 0x00019314 File Offset: 0x00018314
		public unsafe float StaggerFormationTime()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1984481412u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001195 RID: 4501 RVA: 0x00019340 File Offset: 0x00018340
		public unsafe bool StaggerFormationTime(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1984481412u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001196 RID: 4502 RVA: 0x00019374 File Offset: 0x00018374
		public unsafe float TimeBetweenCopSpawn()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2671610862u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001197 RID: 4503 RVA: 0x000193A0 File Offset: 0x000183A0
		public unsafe bool TimeBetweenCopSpawn(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2671610862u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x06001198 RID: 4504 RVA: 0x000193D4 File Offset: 0x000183D4
		public unsafe float TimeBetweenFirstFourSpawn()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(2616259635u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x06001199 RID: 4505 RVA: 0x00019400 File Offset: 0x00018400
		public unsafe bool TimeBetweenFirstFourSpawn(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2616259635u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600119A RID: 4506 RVA: 0x00019434 File Offset: 0x00018434
		public unsafe float TimeBetweenHeliActive()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(722815013u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600119B RID: 4507 RVA: 0x00019460 File Offset: 0x00018460
		public unsafe bool TimeBetweenHeliActive(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(722815013u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600119C RID: 4508 RVA: 0x00019494 File Offset: 0x00018494
		public unsafe float TimeInactiveFor911()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(113995989u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600119D RID: 4509 RVA: 0x000194C0 File Offset: 0x000184C0
		public unsafe bool TimeInactiveFor911(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(113995989u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x0600119E RID: 4510 RVA: 0x000194F4 File Offset: 0x000184F4
		public unsafe float TimePerHeatLevel()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(1011776206u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x0600119F RID: 4511 RVA: 0x00019520 File Offset: 0x00018520
		public unsafe bool TimePerHeatLevel(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1011776206u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060011A0 RID: 4512 RVA: 0x00019554 File Offset: 0x00018554
		public unsafe float TimeToHideInZone()
		{
			float* attributePointer = (float*)this.instance.GetAttributePointer(4285928580u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0f;
		}

		// Token: 0x060011A1 RID: 4513 RVA: 0x00019580 File Offset: 0x00018580
		public unsafe bool TimeToHideInZone(float data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(4285928580u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x060011A2 RID: 4514 RVA: 0x000195B4 File Offset: 0x000185B4
		public pursuitlevels Parent
		{
			get
			{
				uint parent = this.instance.GetParent();
				InternalCollection internalCollection = new InternalCollection(1428038323u, parent);
				internalCollection.Load();
				if (internalCollection.IsValid())
				{
					return new pursuitlevels(internalCollection);
				}
				return null;
			}
		}

		// Token: 0x040003B3 RID: 947
		public const uint ClassKey = 1428038323u;

		// Token: 0x040003B4 RID: 948
		private readonly InternalCollection instance;

		// Token: 0x040003B5 RID: 949
		private bool isDisposed;
	}
}

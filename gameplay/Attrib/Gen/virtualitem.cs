using System;
using System.Text;
using Commerce;
using EASharp;
using GameCore;

namespace Attrib.Gen
{
	// Token: 0x02000120 RID: 288
	public class virtualitem : IDisposable
	{
		// Token: 0x060011A3 RID: 4515 RVA: 0x000195EF File Offset: 0x000185EF
		public virtualitem(string collectionName) : this(InternalCollection.Hash(collectionName))
		{
		}

		// Token: 0x060011A4 RID: 4516 RVA: 0x000195FD File Offset: 0x000185FD
		public virtualitem(uint collectionKey)
		{
			this.instance = new InternalCollection(3148742299u, collectionKey);
			if (!this.instance.IsValid())
			{
				this.instance.Load();
			}
		}

		// Token: 0x060011A5 RID: 4517 RVA: 0x0001962E File Offset: 0x0001862E
		public virtualitem(InternalCollection instance)
		{
			this.instance = instance;
		}

		// Token: 0x060011A6 RID: 4518 RVA: 0x0001963D File Offset: 0x0001863D
		public void Modify(uint dynamicCollectionKey)
		{
			this.Modify(dynamicCollectionKey, 0u);
		}

		// Token: 0x060011A7 RID: 4519 RVA: 0x00019647 File Offset: 0x00018647
		public void Modify(uint dynamicCollectionKey, uint spaceForAdditionalAttributes)
		{
			this.instance.Modify(dynamicCollectionKey, spaceForAdditionalAttributes);
		}

		// Token: 0x060011A8 RID: 4520 RVA: 0x00019656 File Offset: 0x00018656
		public uint GetClass()
		{
			return this.instance.GetClass();
		}

		// Token: 0x060011A9 RID: 4521 RVA: 0x00019663 File Offset: 0x00018663
		public uint GetCollection()
		{
			return this.instance.GetCollection();
		}

		// Token: 0x060011AA RID: 4522 RVA: 0x00019670 File Offset: 0x00018670
		public uint GetParent()
		{
			return this.instance.GetParent();
		}

		// Token: 0x060011AB RID: 4523 RVA: 0x0001967D File Offset: 0x0001867D
		public void SetParent(uint parent)
		{
			this.instance.SetParent(parent);
		}

		// Token: 0x060011AC RID: 4524 RVA: 0x0001968B File Offset: 0x0001868B
		public bool IsValid()
		{
			return this.instance.IsValid();
		}

		// Token: 0x060011AD RID: 4525 RVA: 0x00019698 File Offset: 0x00018698
		public bool IsDynamic()
		{
			return this.instance.IsDynamic();
		}

		// Token: 0x060011AE RID: 4526 RVA: 0x000196A5 File Offset: 0x000186A5
		public bool Contains(uint attributeKey)
		{
			return this.instance.Contains(attributeKey);
		}

		// Token: 0x060011AF RID: 4527 RVA: 0x000196B3 File Offset: 0x000186B3
		public uint LocalAttribCount()
		{
			return this.instance.LocalAttribCount();
		}

		// Token: 0x060011B0 RID: 4528 RVA: 0x000196C0 File Offset: 0x000186C0
		public bool Add(uint attributeKey, uint count)
		{
			return this.instance.Add(attributeKey, count);
		}

		// Token: 0x060011B1 RID: 4529 RVA: 0x000196CF File Offset: 0x000186CF
		public bool Remove(uint attributeKey)
		{
			return this.instance.Remove(attributeKey);
		}

		// Token: 0x060011B2 RID: 4530 RVA: 0x000196DD File Offset: 0x000186DD
		public void Unmodify()
		{
			this.instance.Unmodify();
		}

		// Token: 0x060011B3 RID: 4531 RVA: 0x000196EA File Offset: 0x000186EA
		public uint GenerateUniqueKey(string name)
		{
			return this.instance.GenerateUniqueKey(name);
		}

		// Token: 0x060011B4 RID: 4532 RVA: 0x000196F8 File Offset: 0x000186F8
		public void Reserve(uint spaceForAdditionalAttributes)
		{
			this.instance.Reserve(spaceForAdditionalAttributes);
		}

		// Token: 0x060011B5 RID: 4533 RVA: 0x00019706 File Offset: 0x00018706
		public void LoadVaultSync()
		{
			this.instance.LoadSync();
		}

		// Token: 0x060011B6 RID: 4534 RVA: 0x00019713 File Offset: 0x00018713
		public bool IsDerivedFrom(uint key)
		{
			return this.instance.IsDerivedFrom(key);
		}

		// Token: 0x060011B7 RID: 4535 RVA: 0x00019721 File Offset: 0x00018721
		public GameCore.Attribute Get(uint attributeKey)
		{
			return this.instance.Get(attributeKey);
		}

		// Token: 0x060011B8 RID: 4536 RVA: 0x0001972F File Offset: 0x0001872F
		public GameCore.Attribute GetOrClone(uint attributeKey)
		{
			return this.instance.GetOrClone(attributeKey);
		}

		// Token: 0x060011B9 RID: 4537 RVA: 0x0001973D File Offset: 0x0001873D
		public InternalCollection GetInternalCollection()
		{
			return this.instance;
		}

		// Token: 0x060011BA RID: 4538 RVA: 0x00019745 File Offset: 0x00018745
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060011BB RID: 4539 RVA: 0x00019754 File Offset: 0x00018754
		public void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.Unmodify();
				this.isDisposed = true;
			}
		}

		// Token: 0x060011BC RID: 4540 RVA: 0x00019770 File Offset: 0x00018770
		public unsafe string brand()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(1729623538u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x060011BD RID: 4541 RVA: 0x000197A0 File Offset: 0x000187A0
		public unsafe bool brand(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1729623538u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x060011BE RID: 4542 RVA: 0x0001981C File Offset: 0x0001881C
		public unsafe uint hash()
		{
			uint* attributePointer = (uint*)this.instance.GetAttributePointer(3298218316u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0u;
		}

		// Token: 0x060011BF RID: 4543 RVA: 0x00019844 File Offset: 0x00018844
		public unsafe bool hash(uint data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3298218316u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x00019878 File Offset: 0x00018878
		public unsafe string icon()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3329150777u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x000198A8 File Offset: 0x000188A8
		public unsafe bool icon(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3329150777u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x00019924 File Offset: 0x00018924
		public unsafe string itemName()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(1700518351u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00019954 File Offset: 0x00018954
		public unsafe bool itemName(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1700518351u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x000199D0 File Offset: 0x000189D0
		public unsafe LocalizedString longdescription()
		{
			void* attributePointer = this.instance.GetAttributePointer(1008583737u, 0u);
			return new LocalizedString(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00019A00 File Offset: 0x00018A00
		public bool longdescription(LocalizedString data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1008583737u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00019A38 File Offset: 0x00018A38
		public unsafe int rarity()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(92694061u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060011C7 RID: 4551 RVA: 0x00019A60 File Offset: 0x00018A60
		public unsafe bool rarity(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(92694061u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060011C8 RID: 4552 RVA: 0x00019A94 File Offset: 0x00018A94
		public unsafe int resellprice()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(2050761042u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060011C9 RID: 4553 RVA: 0x00019ABC File Offset: 0x00018ABC
		public unsafe bool resellprice(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2050761042u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060011CA RID: 4554 RVA: 0x00019AF0 File Offset: 0x00018AF0
		public unsafe LocalizedString shortdescription()
		{
			void* attributePointer = this.instance.GetAttributePointer(1599529799u, 0u);
			return new LocalizedString(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060011CB RID: 4555 RVA: 0x00019B20 File Offset: 0x00018B20
		public bool shortdescription(LocalizedString data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1599529799u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x060011CC RID: 4556 RVA: 0x00019B58 File Offset: 0x00018B58
		public unsafe int tier()
		{
			int* attributePointer = (int*)this.instance.GetAttributePointer(863620991u, 0u);
			if (attributePointer != null)
			{
				return *attributePointer;
			}
			return 0;
		}

		// Token: 0x060011CD RID: 4557 RVA: 0x00019B80 File Offset: 0x00018B80
		public unsafe bool tier(int data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(863620991u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x060011CE RID: 4558 RVA: 0x00019BB4 File Offset: 0x00018BB4
		public unsafe string subType()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(3480675381u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x060011CF RID: 4559 RVA: 0x00019BE4 File Offset: 0x00018BE4
		public unsafe bool subType(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(3480675381u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x060011D0 RID: 4560 RVA: 0x00019C60 File Offset: 0x00018C60
		public unsafe LocalizedString title()
		{
			void* attributePointer = this.instance.GetAttributePointer(2044095736u, 0u);
			return new LocalizedString(default(ExposeTag_InitUnowned), attributePointer);
		}

		// Token: 0x060011D1 RID: 4561 RVA: 0x00019C90 File Offset: 0x00018C90
		public bool title(LocalizedString data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(2044095736u);
			return orClone.IsValid() && orClone.Set(0u, data._GetRaw());
		}

		// Token: 0x060011D2 RID: 4562 RVA: 0x00019CC8 File Offset: 0x00018CC8
		public unsafe string type()
		{
			sbyte** attributePointer = (sbyte**)this.instance.GetAttributePointer(1623348937u, 0u);
			return new string(*(IntPtr*)attributePointer, 0, -1, Encoding.ASCII);
		}

		// Token: 0x060011D3 RID: 4563 RVA: 0x00019CF8 File Offset: 0x00018CF8
		public unsafe bool type(string data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(1623348937u);
			int byteCount = Encoding.ASCII.GetByteCount(data);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(data, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return orClone.IsValid() && orClone.Set(0u, (void*)ptr);
			}
		}

		// Token: 0x060011D4 RID: 4564 RVA: 0x00019D74 File Offset: 0x00018D74
		public unsafe bool warnondelete()
		{
			bool* attributePointer = (bool*)this.instance.GetAttributePointer(280598481u, 0u);
			return attributePointer != null && *attributePointer;
		}

		// Token: 0x060011D5 RID: 4565 RVA: 0x00019D9C File Offset: 0x00018D9C
		public unsafe bool warnondelete(bool data)
		{
			GameCore.Attribute orClone = this.instance.GetOrClone(280598481u);
			return orClone.IsValid() && orClone.Set(0u, (void*)(&data));
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x060011D6 RID: 4566 RVA: 0x00019DD0 File Offset: 0x00018DD0
		public virtualitem Parent
		{
			get
			{
				uint parent = this.instance.GetParent();
				InternalCollection internalCollection = new InternalCollection(3148742299u, parent);
				internalCollection.Load();
				if (internalCollection.IsValid())
				{
					return new virtualitem(internalCollection);
				}
				return null;
			}
		}

		// Token: 0x04000401 RID: 1025
		public const uint ClassKey = 3148742299u;

		// Token: 0x04000402 RID: 1026
		private readonly InternalCollection instance;

		// Token: 0x04000403 RID: 1027
		private bool isDisposed;
	}
}

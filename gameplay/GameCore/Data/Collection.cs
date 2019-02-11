using System;
using Attrib.Gen;

namespace GameCore.Data
{
	// Token: 0x020001E9 RID: 489
	public class Collection : gameplay
	{
		// Token: 0x060014F3 RID: 5363 RVA: 0x00025331 File Offset: 0x00024331
		public Collection(GCollectionKey collectionKey) : this(collectionKey.GetCollectionKey())
		{
		}

		// Token: 0x060014F4 RID: 5364 RVA: 0x0002533F File Offset: 0x0002433F
		public Collection(uint collectionKey) : base(Collection.Find(collectionKey))
		{
		}

		// Token: 0x060014F5 RID: 5365 RVA: 0x0002534D File Offset: 0x0002434D
		public Collection(InternalInstance internalInstance) : base(internalInstance)
		{
		}

		// Token: 0x060014F6 RID: 5366 RVA: 0x00025356 File Offset: 0x00024356
		public Collection(InternalCollection internalCollection) : base(internalCollection)
		{
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x00025360 File Offset: 0x00024360
		private static InternalCollection Find(uint collectionKey)
		{
			InternalCollection internalCollection = InstanceCatalog.Get().Find(collectionKey);
			if (null == internalCollection)
			{
				internalCollection = new InternalCollection(1558879558u, collectionKey);
				internalCollection.Load();
				return internalCollection;
			}
			return internalCollection;
		}
	}
}

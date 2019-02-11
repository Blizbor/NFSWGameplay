using System;
using System.Collections.Generic;

namespace GameCore
{
	// Token: 0x0200023B RID: 571
	public abstract class Instancable<T> : IInstanceable, IDisposable where T : IInstanceable
	{
		// Token: 0x06001735 RID: 5941 RVA: 0x00029444 File Offset: 0x00028444
		public Instancable()
		{
			this.handle = (Instancable<T>.counter += 1u);
			Instancable<T>.dictionary.Add(this.handle, this);
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x00029470 File Offset: 0x00028470
		~Instancable()
		{
			this.Dispose(false);
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x000294A0 File Offset: 0x000284A0
		public static T FindInstance(uint handle)
		{
			if (Instancable<T>.dictionary.ContainsKey(handle))
			{
				return (T)((object)Instancable<T>.dictionary[handle]);
			}
			return default(T);
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x000294D4 File Offset: 0x000284D4
		public uint GetInstanceHandle()
		{
			return this.handle;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x000294DC File Offset: 0x000284DC
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x000294EB File Offset: 0x000284EB
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				Instancable<T>.dictionary.Remove(this.handle);
				this.disposed = true;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x0002950F File Offset: 0x0002850F
		public static int InstanceCount
		{
			get
			{
				return Instancable<T>.dictionary.Count;
			}
		}

		// Token: 0x040005A2 RID: 1442
		private uint handle;

		// Token: 0x040005A3 RID: 1443
		private bool disposed;

		// Token: 0x040005A4 RID: 1444
		private static Dictionary<uint, IInstanceable> dictionary = new Dictionary<uint, IInstanceable>();

		// Token: 0x040005A5 RID: 1445
		private static uint counter = 0u;
	}
}

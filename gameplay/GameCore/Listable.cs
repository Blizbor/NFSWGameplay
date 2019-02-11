using System;
using System.Collections.Generic;

namespace GameCore
{
	// Token: 0x0200020E RID: 526
	public abstract class Listable<T> : IListable, IDisposable where T : IListable
	{
		// Token: 0x060015EB RID: 5611 RVA: 0x0002657E File Offset: 0x0002557E
		public Listable()
		{
			Listable<T>.List.Add(this);
		}

		// Token: 0x060015EC RID: 5612 RVA: 0x00026594 File Offset: 0x00025594
		~Listable()
		{
			this.Dispose(false);
		}

		// Token: 0x060015ED RID: 5613 RVA: 0x000265C4 File Offset: 0x000255C4
		public static void ForEach(Action<T> action)
		{
			foreach (IListable listable in Listable<T>.List)
			{
				action((T)((object)listable));
			}
		}

		// Token: 0x060015EE RID: 5614 RVA: 0x0002661C File Offset: 0x0002561C
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060015EF RID: 5615 RVA: 0x0002662B File Offset: 0x0002562B
		protected virtual void Dispose(bool disposing)
		{
			if (!this.disposed)
			{
				Listable<T>.List.Remove(this);
				this.disposed = true;
			}
		}

		// Token: 0x04000536 RID: 1334
		private static List<IListable> List = new List<IListable>();

		// Token: 0x04000537 RID: 1335
		private bool disposed;
	}
}

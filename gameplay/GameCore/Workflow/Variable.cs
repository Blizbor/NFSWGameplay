using System;

namespace GameCore.Workflow
{
	// Token: 0x0200022B RID: 555
	public class Variable<T>
	{
		// Token: 0x0600169E RID: 5790 RVA: 0x000278D4 File Offset: 0x000268D4
		public Variable() : this(default(T))
		{
		}

		// Token: 0x0600169F RID: 5791 RVA: 0x000278F0 File Offset: 0x000268F0
		public Variable(T val)
		{
			this.val = val;
		}

		// Token: 0x060016A0 RID: 5792 RVA: 0x0002790B File Offset: 0x0002690B
		public T GetValue()
		{
			return this.Value;
		}

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x060016A1 RID: 5793 RVA: 0x00027913 File Offset: 0x00026913
		// (set) Token: 0x060016A2 RID: 5794 RVA: 0x0002791B File Offset: 0x0002691B
		public T Value
		{
			get
			{
				return this.val;
			}
			set
			{
				this.val = value;
			}
		}

		// Token: 0x04000574 RID: 1396
		private T val = default(T);
	}
}

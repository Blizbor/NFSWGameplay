using System;

namespace GameCore.Workflow
{
	// Token: 0x02000213 RID: 531
	public class InOutArgument<T>
	{
		// Token: 0x0600160F RID: 5647 RVA: 0x00026A02 File Offset: 0x00025A02
		public InOutArgument(Variable<T> variable)
		{
			this.variable = variable;
		}

		// Token: 0x06001610 RID: 5648 RVA: 0x00026A11 File Offset: 0x00025A11
		public InOutArgument(T value) : this(new Variable<T>(value))
		{
		}

		// Token: 0x170001B7 RID: 439
		// (get) Token: 0x06001611 RID: 5649 RVA: 0x00026A1F File Offset: 0x00025A1F
		// (set) Token: 0x06001612 RID: 5650 RVA: 0x00026A2C File Offset: 0x00025A2C
		public T Value
		{
			get
			{
				return this.variable.Value;
			}
			set
			{
				this.variable.Value = value;
			}
		}

		// Token: 0x04000541 RID: 1345
		private Variable<T> variable;
	}
}

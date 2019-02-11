using System;

namespace GameCore.Workflow
{
	// Token: 0x02000229 RID: 553
	public class OutArgument<T>
	{
		// Token: 0x0600168F RID: 5775 RVA: 0x00027714 File Offset: 0x00026714
		public OutArgument(Variable<T> variable)
		{
			this.variable = variable;
			this.variable.Value = default(T);
		}

		// Token: 0x170001C7 RID: 455
		// (set) Token: 0x06001690 RID: 5776 RVA: 0x00027742 File Offset: 0x00026742
		public T Value
		{
			set
			{
				this.variable.Value = value;
			}
		}

		// Token: 0x0400056D RID: 1389
		private Variable<T> variable;
	}
}

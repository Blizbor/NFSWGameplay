using System;

namespace GameCore.Workflow
{
	// Token: 0x02000228 RID: 552
	public class InArgument<T>
	{
		// Token: 0x0600168B RID: 5771 RVA: 0x000276D6 File Offset: 0x000266D6
		public InArgument(InArgumentHandler<T> handler)
		{
			this.handler = handler;
		}

		// Token: 0x0600168C RID: 5772 RVA: 0x000276E5 File Offset: 0x000266E5
		public InArgument(Variable<T> variable) : this(new InArgumentHandler<T>(variable.GetValue))
		{
		}

		// Token: 0x0600168D RID: 5773 RVA: 0x000276F9 File Offset: 0x000266F9
		public InArgument(T value) : this(new Variable<T>(value))
		{
		}

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x0600168E RID: 5774 RVA: 0x00027707 File Offset: 0x00026707
		public T Value
		{
			get
			{
				return this.handler();
			}
		}

		// Token: 0x0400056C RID: 1388
		private InArgumentHandler<T> handler;
	}
}

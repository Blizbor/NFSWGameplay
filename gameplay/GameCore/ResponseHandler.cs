using System;
using EASharp;

namespace GameCore
{
	// Token: 0x0200024F RID: 591
	[Export]
	public class ResponseHandler
	{
		// Token: 0x060017E1 RID: 6113 RVA: 0x0002AC56 File Offset: 0x00029C56
		public ResponseHandler(ResponseHandler.SuccessHandler successHandler, ResponseHandler.FailHandler failHandler)
		{
			this.mSuccessHandler = successHandler;
			this.mFailHandler = failHandler;
		}

		// Token: 0x060017E2 RID: 6114 RVA: 0x0002AC6C File Offset: 0x00029C6C
		public void OnSucceeded(XmlString response)
		{
			if (this.HasSucceededFunction())
			{
				this.mSuccessHandler(response);
			}
		}

		// Token: 0x060017E3 RID: 6115 RVA: 0x0002AC82 File Offset: 0x00029C82
		public void OnFailed(int status)
		{
			if (this.HasFailedFunction())
			{
				this.mFailHandler(status);
			}
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x0002AC98 File Offset: 0x00029C98
		public bool HasSucceededFunction()
		{
			return this.mSuccessHandler != null;
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x0002ACA6 File Offset: 0x00029CA6
		public bool HasFailedFunction()
		{
			return this.mFailHandler != null;
		}

		// Token: 0x040005D9 RID: 1497
		private readonly ResponseHandler.SuccessHandler mSuccessHandler;

		// Token: 0x040005DA RID: 1498
		private readonly ResponseHandler.FailHandler mFailHandler;

		// Token: 0x02000250 RID: 592
		// (Invoke) Token: 0x060017E7 RID: 6119
		public delegate void SuccessHandler(XmlString response);

		// Token: 0x02000251 RID: 593
		// (Invoke) Token: 0x060017EB RID: 6123
		public delegate void FailHandler(int status);
	}
}

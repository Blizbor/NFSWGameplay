using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002FA RID: 762
	public class EngineExceptionTrans : IRequestBody
	{
		// Token: 0x060020E7 RID: 8423 RVA: 0x0004E458 File Offset: 0x0004D458
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400089D RID: 2205
		public string Description = "";

		// Token: 0x0400089E RID: 2206
		public int ErrorCode;

		// Token: 0x0400089F RID: 2207
		public EngineInnerExceptionTrans InnerException;

		// Token: 0x040008A0 RID: 2208
		public string Message = "";

		// Token: 0x040008A1 RID: 2209
		public string StackTrace = "";
	}
}

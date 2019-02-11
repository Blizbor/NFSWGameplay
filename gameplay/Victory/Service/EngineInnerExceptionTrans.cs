using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service
{
	// Token: 0x020002F9 RID: 761
	public class EngineInnerExceptionTrans : IRequestBody
	{
		// Token: 0x060020E5 RID: 8421 RVA: 0x0004E418 File Offset: 0x0004D418
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000899 RID: 2201
		public string Description = "";

		// Token: 0x0400089A RID: 2202
		public int ErrorCode;

		// Token: 0x0400089B RID: 2203
		public string Message = "";

		// Token: 0x0400089C RID: 2204
		public string StackTrace = "";
	}
}

using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000321 RID: 801
	public class ErrorReport : IRequestBody
	{
		// Token: 0x06002135 RID: 8501 RVA: 0x0004EC48 File Offset: 0x0004DC48
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400097A RID: 2426
		public int errorCode;

		// Token: 0x0400097B RID: 2427
		public string errorDescription = "";
	}
}

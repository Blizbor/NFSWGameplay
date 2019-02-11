using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x02000320 RID: 800
	public class ChatTranscript : IRequestBody
	{
		// Token: 0x06002133 RID: 8499 RVA: 0x0004EC10 File Offset: 0x0004DC10
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000976 RID: 2422
		public string Message = "";

		// Token: 0x04000977 RID: 2423
		public long PersonaId;

		// Token: 0x04000978 RID: 2424
		public string TargetPersonaId = "";

		// Token: 0x04000979 RID: 2425
		public long UserId;
	}
}

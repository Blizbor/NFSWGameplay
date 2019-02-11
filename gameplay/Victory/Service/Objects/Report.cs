using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects
{
	// Token: 0x0200031F RID: 799
	public class Report : IRequestBody
	{
		// Token: 0x06002131 RID: 8497 RVA: 0x0004EBF0 File Offset: 0x0004DBF0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000972 RID: 2418
		public List<ChatTranscript> chatTranscripts;

		// Token: 0x04000973 RID: 2419
		public List<ErrorReport> errorReport;

		// Token: 0x04000974 RID: 2420
		public List<FraudDetection> fraudDetectionReport;

		// Token: 0x04000975 RID: 2421
		public List<ShortcutUsage> shortcutUsage;
	}
}

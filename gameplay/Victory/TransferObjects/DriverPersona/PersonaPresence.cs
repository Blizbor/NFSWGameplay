using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x0200032D RID: 813
	public class PersonaPresence : IRequestBody
	{
		// Token: 0x06002147 RID: 8519 RVA: 0x0004EEA0 File Offset: 0x0004DEA0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000999 RID: 2457
		public long personaId;

		// Token: 0x0400099A RID: 2458
		public int presence;

		// Token: 0x0400099B RID: 2459
		public long userId;
	}
}

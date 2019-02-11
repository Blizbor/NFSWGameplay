using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.DriverPersona
{
	// Token: 0x0200032B RID: 811
	public class PersonaDeleted : IRequestBody
	{
		// Token: 0x06002143 RID: 8515 RVA: 0x0004EE60 File Offset: 0x0004DE60
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000997 RID: 2455
		public long personaId;
	}
}

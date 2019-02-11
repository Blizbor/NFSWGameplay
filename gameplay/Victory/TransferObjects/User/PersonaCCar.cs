using System;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.User
{
	// Token: 0x0200033D RID: 829
	public class PersonaCCar : IRequestBody
	{
		// Token: 0x06002163 RID: 8547 RVA: 0x0004F420 File Offset: 0x0004E420
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000A0A RID: 2570
		public int CCID;

		// Token: 0x04000A0B RID: 2571
		public int Durability;

		// Token: 0x04000A0C RID: 2572
		public float Heat;

		// Token: 0x04000A0D RID: 2573
		public bool IsDefault;

		// Token: 0x04000A0E RID: 2574
		public long PersonaId;
	}
}

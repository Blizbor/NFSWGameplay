using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.TransferObjects.User
{
	// Token: 0x0200033C RID: 828
	public class ProfileData : IRequestBody
	{
		// Token: 0x06002161 RID: 8545 RVA: 0x0004F3E8 File Offset: 0x0004E3E8
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040009FE RID: 2558
		public double Boost;

		// Token: 0x040009FF RID: 2559
		public double Cash;

		// Token: 0x04000A00 RID: 2560
		public int IconIndex;

		// Token: 0x04000A01 RID: 2561
		public int Level;

		// Token: 0x04000A02 RID: 2562
		public string Motto = "";

		// Token: 0x04000A03 RID: 2563
		public string Name = "";

		// Token: 0x04000A04 RID: 2564
		public float PercentToLevel;

		// Token: 0x04000A05 RID: 2565
		public long PersonaId;

		// Token: 0x04000A06 RID: 2566
		public double Rating;

		// Token: 0x04000A07 RID: 2567
		public double Rep;

		// Token: 0x04000A08 RID: 2568
		public int RepAtCurrentLevel;

		// Token: 0x04000A09 RID: 2569
		public List<PersonaCCar> ccar;
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002BF RID: 703
	public class CarSlotInfoTrans : IRequestBody
	{
		// Token: 0x06002083 RID: 8323 RVA: 0x0004D600 File Offset: 0x0004C600
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000792 RID: 1938
		public List<OwnedCarTrans> CarsOwnedByPersona;

		// Token: 0x04000793 RID: 1939
		public int DefaultOwnedCarIndex;

		// Token: 0x04000794 RID: 1940
		public List<ProductTrans> ObtainableSlots;

		// Token: 0x04000795 RID: 1941
		public int OwnedCarSlotsCount;
	}
}

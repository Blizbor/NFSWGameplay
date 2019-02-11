using System;
using server_packet;
using xsd2cpp;

namespace Victory.Service.Objects.Event
{
	// Token: 0x02000324 RID: 804
	public class CarClass : IRequestBody
	{
		// Token: 0x0600213B RID: 8507 RVA: 0x0004ECC0 File Offset: 0x0004DCC0
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400097F RID: 2431
		public int CarClassHash;

		// Token: 0x04000980 RID: 2432
		public short MaxRating;

		// Token: 0x04000981 RID: 2433
		public short MinRating;
	}
}

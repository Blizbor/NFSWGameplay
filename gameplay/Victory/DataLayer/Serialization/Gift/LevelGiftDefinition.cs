using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Gift
{
	// Token: 0x020002DC RID: 732
	public class LevelGiftDefinition : IRequestBody
	{
		// Token: 0x060020B5 RID: 8373 RVA: 0x0004DE0C File Offset: 0x0004CE0C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000833 RID: 2099
		public int Boost;

		// Token: 0x04000834 RID: 2100
		public int Level;

		// Token: 0x04000835 RID: 2101
		public int LevelGiftId;
	}
}

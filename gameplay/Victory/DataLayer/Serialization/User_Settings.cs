using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002AB RID: 683
	public class User_Settings : IRequestBody
	{
		// Token: 0x0600205B RID: 8283 RVA: 0x0004D18C File Offset: 0x0004C18C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000704 RID: 1796
		public int CarCacheAgeLimit;

		// Token: 0x04000705 RID: 1797
		public bool IsRaceNowEnabled;

		// Token: 0x04000706 RID: 1798
		public int MaxCarCacheSize;

		// Token: 0x04000707 RID: 1799
		public int MinRaceNowLevel;

		// Token: 0x04000708 RID: 1800
		public bool VoipAvailable;

		// Token: 0x04000709 RID: 1801
		public List<string> activatedHolidaySceneryGroups;

		// Token: 0x0400070A RID: 1802
		public List<long> activeHolidayIds;

		// Token: 0x0400070B RID: 1803
		public List<string> disactivatedHolidaySceneryGroups;

		// Token: 0x0400070C RID: 1804
		public bool firstTimeLogin;

		// Token: 0x0400070D RID: 1805
		public int maxLevel;

		// Token: 0x0400070E RID: 1806
		public bool starterPackApplied;

		// Token: 0x0400070F RID: 1807
		public long userId;
	}
}

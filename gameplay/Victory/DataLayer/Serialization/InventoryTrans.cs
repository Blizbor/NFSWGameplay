using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B5 RID: 693
	public class InventoryTrans : IRequestBody
	{
		// Token: 0x0600206F RID: 8303 RVA: 0x0004D410 File Offset: 0x0004C410
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000763 RID: 1891
		public List<InventoryItemTrans> InventoryItems;

		// Token: 0x04000764 RID: 1892
		public long PerformancePartsCapacity;

		// Token: 0x04000765 RID: 1893
		public long PerformancePartsUsedSlotCount;

		// Token: 0x04000766 RID: 1894
		public long SkillModPartsCapacity;

		// Token: 0x04000767 RID: 1895
		public long SkillModPartsUsedSlotCount;

		// Token: 0x04000768 RID: 1896
		public long VisualPartsCapacity;

		// Token: 0x04000769 RID: 1897
		public long VisualPartsUsedSlotCount;
	}
}

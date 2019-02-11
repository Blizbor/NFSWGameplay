using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x0200029E RID: 670
	public class CustomCarTrans : IRequestBody
	{
		// Token: 0x06002041 RID: 8257 RVA: 0x0004CF6C File Offset: 0x0004BF6C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006C1 RID: 1729
		public int BaseCar;

		// Token: 0x040006C2 RID: 1730
		public int CarClassHash;

		// Token: 0x040006C3 RID: 1731
		public int Id;

		// Token: 0x040006C4 RID: 1732
		public bool IsPreset;

		// Token: 0x040006C5 RID: 1733
		public int Level;

		// Token: 0x040006C6 RID: 1734
		public string Name = "";

		// Token: 0x040006C7 RID: 1735
		public List<CustomPaintTrans> Paints;

		// Token: 0x040006C8 RID: 1736
		public List<PerformancePartTrans> PerformanceParts;

		// Token: 0x040006C9 RID: 1737
		public int PhysicsProfileHash;

		// Token: 0x040006CA RID: 1738
		public int Rating;

		// Token: 0x040006CB RID: 1739
		public float ResalePrice;

		// Token: 0x040006CC RID: 1740
		public float RideHeightDrop;

		// Token: 0x040006CD RID: 1741
		public List<SkillModPartTrans> SkillModParts;

		// Token: 0x040006CE RID: 1742
		public int SkillModSlotCount;

		// Token: 0x040006CF RID: 1743
		public int Version;

		// Token: 0x040006D0 RID: 1744
		public List<CustomVinylTrans> Vinyls;

		// Token: 0x040006D1 RID: 1745
		public List<VisualPartTrans> VisualParts;
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B4 RID: 692
	public class ProductTrans : IRequestBody
	{
		// Token: 0x0600206D RID: 8301 RVA: 0x0004D360 File Offset: 0x0004C360
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x04000750 RID: 1872
		public List<ProductTrans> BundleItems;

		// Token: 0x04000751 RID: 1873
		public string CategoryId = "";

		// Token: 0x04000752 RID: 1874
		public string Currency = "";

		// Token: 0x04000753 RID: 1875
		public string Description = "";

		// Token: 0x04000754 RID: 1876
		public int DurationMinute;

		// Token: 0x04000755 RID: 1877
		public int Hash;

		// Token: 0x04000756 RID: 1878
		public string Icon = "";

		// Token: 0x04000757 RID: 1879
		public int Level;

		// Token: 0x04000758 RID: 1880
		public string LongDescription = "";

		// Token: 0x04000759 RID: 1881
		public double Price;

		// Token: 0x0400075A RID: 1882
		public int Priority;

		// Token: 0x0400075B RID: 1883
		public string ProductId = "";

		// Token: 0x0400075C RID: 1884
		public string ProductTitle = "";

		// Token: 0x0400075D RID: 1885
		public string ProductType = "";

		// Token: 0x0400075E RID: 1886
		public string SecondaryIcon = "";

		// Token: 0x0400075F RID: 1887
		public int UseCount;

		// Token: 0x04000760 RID: 1888
		public string VisualStyle = "";

		// Token: 0x04000761 RID: 1889
		public string WebIcon = "";

		// Token: 0x04000762 RID: 1890
		public string WebLocation = "";
	}
}

using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002B8 RID: 696
	public class CategoryTrans : IRequestBody
	{
		// Token: 0x06002075 RID: 8309 RVA: 0x0004D47C File Offset: 0x0004C47C
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x0400076D RID: 1901
		public int CatalogVersion;

		// Token: 0x0400076E RID: 1902
		public List<CategoryTrans> Categories;

		// Token: 0x0400076F RID: 1903
		public string DisplayName = "";

		// Token: 0x04000770 RID: 1904
		public int FilterType;

		// Token: 0x04000771 RID: 1905
		public string Icon = "";

		// Token: 0x04000772 RID: 1906
		public string Id = "";

		// Token: 0x04000773 RID: 1907
		public string LongDescription = "";

		// Token: 0x04000774 RID: 1908
		public string Name = "";

		// Token: 0x04000775 RID: 1909
		public int Priority;

		// Token: 0x04000776 RID: 1910
		public List<ProductTrans> Products;

		// Token: 0x04000777 RID: 1911
		public string ShortDescription = "";

		// Token: 0x04000778 RID: 1912
		public bool ShowInNavigationPane;

		// Token: 0x04000779 RID: 1913
		public bool ShowPromoPage;

		// Token: 0x0400077A RID: 1914
		public string WebIcon = "";
	}
}

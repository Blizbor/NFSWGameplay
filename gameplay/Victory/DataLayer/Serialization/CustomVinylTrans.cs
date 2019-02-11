using System;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization
{
	// Token: 0x020002A3 RID: 675
	public class CustomVinylTrans : IRequestBody
	{
		// Token: 0x0600204B RID: 8267 RVA: 0x0004D030 File Offset: 0x0004C030
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040006E0 RID: 1760
		public int Hash;

		// Token: 0x040006E1 RID: 1761
		public int Hue1;

		// Token: 0x040006E2 RID: 1762
		public int Hue2;

		// Token: 0x040006E3 RID: 1763
		public int Hue3;

		// Token: 0x040006E4 RID: 1764
		public int Hue4;

		// Token: 0x040006E5 RID: 1765
		public int Layer;

		// Token: 0x040006E6 RID: 1766
		public bool Mir;

		// Token: 0x040006E7 RID: 1767
		public int Rot;

		// Token: 0x040006E8 RID: 1768
		public int Sat1;

		// Token: 0x040006E9 RID: 1769
		public int Sat2;

		// Token: 0x040006EA RID: 1770
		public int Sat3;

		// Token: 0x040006EB RID: 1771
		public int Sat4;

		// Token: 0x040006EC RID: 1772
		public int ScaleX;

		// Token: 0x040006ED RID: 1773
		public int ScaleY;

		// Token: 0x040006EE RID: 1774
		public int Shear;

		// Token: 0x040006EF RID: 1775
		public int TranX;

		// Token: 0x040006F0 RID: 1776
		public int TranY;

		// Token: 0x040006F1 RID: 1777
		public int Var1;

		// Token: 0x040006F2 RID: 1778
		public int Var2;

		// Token: 0x040006F3 RID: 1779
		public int Var3;

		// Token: 0x040006F4 RID: 1780
		public int Var4;
	}
}

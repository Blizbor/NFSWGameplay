using System;

namespace GameCore.Data
{
	// Token: 0x020001E8 RID: 488
	public class AttributeChangedEventArgs : EventArgs
	{
		// Token: 0x060014F1 RID: 5361 RVA: 0x0002531A File Offset: 0x0002431A
		public AttributeChangedEventArgs(uint attribKey)
		{
			this.attribKey = attribKey;
		}

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060014F2 RID: 5362 RVA: 0x00025329 File Offset: 0x00024329
		public uint AttribKey
		{
			get
			{
				return this.attribKey;
			}
		}

		// Token: 0x040004F2 RID: 1266
		private readonly uint attribKey;
	}
}

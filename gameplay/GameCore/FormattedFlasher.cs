using System;
using EASharp;

namespace GameCore
{
	// Token: 0x020001ED RID: 493
	[Export]
	public class FormattedFlasher : FlasherBase
	{
		// Token: 0x06001517 RID: 5399 RVA: 0x000255FD File Offset: 0x000245FD
		public FormattedFlasher(uint collection_key, object arg0) : base(collection_key)
		{
			this.mMessage = string.Format(base.Message, arg0);
		}
	}
}

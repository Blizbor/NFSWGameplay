using System;
using EASharp;

namespace GameCore.Streaming
{
	// Token: 0x0200020A RID: 522
	[Export]
	public interface ITokenListener
	{
		// Token: 0x060015DB RID: 5595
		void OnActivated();

		// Token: 0x060015DC RID: 5596
		void OnDeactivated();
	}
}

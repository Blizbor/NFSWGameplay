using System;
using EASharp;

namespace GameCore
{
	// Token: 0x02000241 RID: 577
	[Export]
	public interface ISpectateMethod
	{
		// Token: 0x06001786 RID: 6022
		void ClearTarget();

		// Token: 0x06001787 RID: 6023
		uint UpdateTarget(InstancedEvent evnt);

		// Token: 0x170001F3 RID: 499
		// (get) Token: 0x06001788 RID: 6024
		EntrantInfo Target { get; }
	}
}

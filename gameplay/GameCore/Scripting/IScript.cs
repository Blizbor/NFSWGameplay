using System;
using GameCore.Data;

namespace GameCore.Scripting
{
	// Token: 0x02000205 RID: 517
	public interface IScript
	{
		// Token: 0x060015A8 RID: 5544
		void Execute(Event evt, EntrantInfo entrant, Collection data);
	}
}

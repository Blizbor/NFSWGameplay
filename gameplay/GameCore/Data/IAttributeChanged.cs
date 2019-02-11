using System;
using EASharp;

namespace GameCore.Data
{
	// Token: 0x020001EA RID: 490
	[Export]
	public interface IAttributeChanged
	{
		// Token: 0x060014F8 RID: 5368
		void OnChanged(uint attribKey);
	}
}

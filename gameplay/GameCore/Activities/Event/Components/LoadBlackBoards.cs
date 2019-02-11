using System;
using System.Collections.Generic;
using Attrib.Gen;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C4 RID: 452
	public class LoadBlackBoards : Component<Event>
	{
		// Token: 0x06001457 RID: 5207 RVA: 0x0002166F File Offset: 0x0002066F
		public LoadBlackBoards(Event evnt, BlackBoardFlag flags) : base(evnt)
		{
			this.flags = (uint)flags;
		}

		// Token: 0x06001458 RID: 5208 RVA: 0x00021680 File Offset: 0x00020680
		protected internal override void Execute(ActivityExecutionContext context)
		{
			List<int> list = new List<int>();
			for (gameplay gameplay = base.Event.EventDef; gameplay != null; gameplay = gameplay.Parent)
			{
				uint num = gameplay.Num_BlackBoardMap();
				for (uint num2 = 0u; num2 < num; num2 += 1u)
				{
					BlackBoardSlot blackBoardSlot = gameplay.BlackBoardMap(num2);
					uint mBits = blackBoardSlot.mFlags.mBits;
					if ((mBits & this.flags) != 0u)
					{
						BlackBoardChannel mChannel = blackBoardSlot.mChannel;
						if (!list.Contains((int)mChannel))
						{
							BlackBoard.Get().Change(mChannel, blackBoardSlot.mBlackBoardKey.GetKey());
							list.Add((int)mChannel);
						}
					}
				}
			}
		}

		// Token: 0x06001459 RID: 5209 RVA: 0x00021713 File Offset: 0x00020713
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x040004C9 RID: 1225
		private readonly uint flags;
	}
}

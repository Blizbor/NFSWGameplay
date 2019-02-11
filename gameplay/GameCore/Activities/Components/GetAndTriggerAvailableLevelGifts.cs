using System;
using System.Collections.Generic;
using GameCore.Workflow;
using server_packet;
using Victory.DataLayer.Serialization.Gift;
using xsd2cpp;

namespace GameCore.Activities.Components
{
	// Token: 0x02000145 RID: 325
	public class GetAndTriggerAvailableLevelGifts : WorkflowElement
	{
		// Token: 0x0600126C RID: 4716 RVA: 0x0001A896 File Offset: 0x00019896
		protected internal override void Execute(ActivityExecutionContext context)
		{
			MyBinding.Gifts_GetAndTriggerAvailableLevelGifts(new ResponseHandler(new ResponseHandler.SuccessHandler(this.OnSucceeded), null));
		}

		// Token: 0x0600126D RID: 4717 RVA: 0x0001A8B0 File Offset: 0x000198B0
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x0600126E RID: 4718 RVA: 0x0001A8B4 File Offset: 0x000198B4
		private void OnSucceeded(XmlString response)
		{
			List<LevelGiftDefinition> list;
			bool flag = XSD2CPP.ReadArrayOfLevelGiftDefinition(response, out list);
			if (flag && list.Count > 0)
			{
				Marshal.Get().ShowSpeedBoostTutorial(list[0].Boost, false);
			}
		}
	}
}

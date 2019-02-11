using System;
using GameCore.Activities.Components;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x0200016F RID: 367
	public class Countdown : Sequence
	{
		// Token: 0x06001322 RID: 4898 RVA: 0x0001B710 File Offset: 0x0001A710
		public Countdown(InstancedEvent evnt, EntrantInfo entrant)
		{
			LocalHumanOpponent localHumanOpponent = entrant.Opponent as LocalHumanOpponent;
			if (localHumanOpponent != null)
			{
				FlasherBase flasher = new FlasherBase(1031321970u);
				FlasherBase flasher2 = new FlasherBase(2997328623u);
				FlasherBase flasher3 = new FlasherBase(3512998001u);
				FlasherBase flasher4 = new FlasherBase(2140919479u);
				FlasherBase flasher5 = new FlasherBase(2926395083u);
				base.Activities.Add(new DisplayFlasher(evnt, entrant, flasher, false));
				if (evnt.ConnectionSupport == ConnectionSupport.kConnectionOnline)
				{
					base.Activities.Add(new ReadySync(0.0166666675f));
				}
				else
				{
					base.Activities.Add(new Timer(new InArgument<float>(() => 3f)));
				}
				base.Activities.Add(new RemoveFlasher(evnt, entrant, flasher));
				base.Activities.Add(new DisplayFlasher(evnt, entrant, flasher2, false));
				base.Activities.Add(new Timer(new InArgument<float>(() => 1f)));
				base.Activities.Add(new RemoveFlasher(evnt, entrant, flasher2));
				base.Activities.Add(new DisplayFlasher(evnt, entrant, flasher3, false));
				base.Activities.Add(new Timer(new InArgument<float>(() => 1f)));
				base.Activities.Add(new RemoveFlasher(evnt, entrant, flasher3));
				base.Activities.Add(new DisplayFlasher(evnt, entrant, flasher4, false));
				base.Activities.Add(new Timer(new InArgument<float>(() => 1f)));
				base.Activities.Add(new RemoveFlasher(evnt, entrant, flasher4));
				base.Activities.Add(new DisplayFlasher(evnt, entrant, flasher5, false));
			}
		}
	}
}

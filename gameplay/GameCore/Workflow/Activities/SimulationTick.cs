using System;
using System.Collections.Generic;

namespace GameCore.Workflow.Activities
{
	// Token: 0x02000146 RID: 326
	public abstract class SimulationTick : WorkflowElement
	{
		// Token: 0x1700012B RID: 299
		// (get) Token: 0x0600126F RID: 4719 RVA: 0x0001A8ED File Offset: 0x000198ED
		// (set) Token: 0x06001270 RID: 4720 RVA: 0x0001A8F5 File Offset: 0x000198F5
		public float Period
		{
			get
			{
				return this.period;
			}
			set
			{
				this.period = value;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x06001271 RID: 4721 RVA: 0x0001A8FE File Offset: 0x000198FE
		// (set) Token: 0x06001272 RID: 4722 RVA: 0x0001A906 File Offset: 0x00019906
		public float TimeUntilNextTick
		{
			get
			{
				return this.timeUntilNextTick;
			}
			set
			{
				this.timeUntilNextTick = value;
			}
		}

		// Token: 0x06001273 RID: 4723 RVA: 0x0001A90F File Offset: 0x0001990F
		public SimulationTick(float period)
		{
			this.period = period;
			this.timeUntilNextTick = 0f;
		}

		// Token: 0x06001274 RID: 4724 RVA: 0x0001A929 File Offset: 0x00019929
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (!SimulationTick.Ticks.Contains(this))
			{
				this.bookmark = context.CreateNamedBookmark(null, new BookmarkCallback(this.OnResume), BookmarkOptions.MultiResume);
				SimulationTick.Ticks.Add(this);
				this.OnExecute(context);
			}
		}

		// Token: 0x06001275 RID: 4725
		protected abstract void OnExecute(ActivityExecutionContext context);

		// Token: 0x06001276 RID: 4726 RVA: 0x0001A964 File Offset: 0x00019964
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001277 RID: 4727 RVA: 0x0001A966 File Offset: 0x00019966
		private void OnResume(ActivityExecutionContext context, Bookmark bookmark, object target)
		{
		}

		// Token: 0x06001278 RID: 4728 RVA: 0x0001A968 File Offset: 0x00019968
		public static void TickAll(float dT)
		{
			SimulationTick[] array = new SimulationTick[SimulationTick.Ticks.Count];
			SimulationTick.Ticks.CopyTo(0, array, 0, SimulationTick.Ticks.Count);
			foreach (SimulationTick simulationTick in array)
			{
				if (simulationTick.TimeUntilNextTick <= 0f)
				{
					simulationTick.Tick(simulationTick.Period);
					simulationTick.TimeUntilNextTick += simulationTick.Period;
				}
				simulationTick.TimeUntilNextTick -= dT;
			}
		}

		// Token: 0x06001279 RID: 4729
		protected abstract void Tick(float dT);

		// Token: 0x0600127A RID: 4730 RVA: 0x0001A9EA File Offset: 0x000199EA
		protected internal override void Close()
		{
			if (SimulationTick.Ticks.Contains(this))
			{
				SimulationTick.Ticks.Remove(this);
				this.bookmark.Close();
			}
			base.Close();
		}

		// Token: 0x04000439 RID: 1081
		private Bookmark bookmark;

		// Token: 0x0400043A RID: 1082
		private static List<SimulationTick> Ticks = new List<SimulationTick>();

		// Token: 0x0400043B RID: 1083
		private float period;

		// Token: 0x0400043C RID: 1084
		private float timeUntilNextTick;
	}
}

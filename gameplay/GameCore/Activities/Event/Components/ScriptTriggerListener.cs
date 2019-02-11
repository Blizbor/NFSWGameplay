using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Messages;
using GameCore.Scripting;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001D4 RID: 468
	public class ScriptTriggerListener : MessageHandler<OnTriggerEnter>
	{
		// Token: 0x06001494 RID: 5268 RVA: 0x000224E0 File Offset: 0x000214E0
		public ScriptTriggerListener(Event evnt, uint port) : base(evnt, port)
		{
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00022500 File Offset: 0x00021500
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00022504 File Offset: 0x00021504
		protected override void OnMessage(OnTriggerEnter message)
		{
			Collection collection = new Collection(message.TriggerKey);
			if (collection.IsDerivedFrom(3085914478u))
			{
				if (this.fired.ContainsKey(collection.GetCollection()))
				{
					if (collection.DelayInterval() < 0f)
					{
						return;
					}
					if (TimeSpan.FromMilliseconds(Simulation.GetTickDifference(this.fired[collection.GetCollection()])).TotalSeconds < (double)collection.DelayInterval())
					{
						return;
					}
				}
				uint key = collection.ScriptAction().GetKey();
				IScript script = null;
				if (!this.scripts.TryGetValue(key, out script))
				{
					script = Activator.CreateInstance<IScript>(key);
					this.scripts.Add(key, script);
				}
				if (script != null)
				{
					EntrantInfo entrantInfo = base.Event.FindEntrant(message.PersonaId);
					if (entrantInfo != null)
					{
						script.Execute(base.Event, entrantInfo, collection);
						this.fired[collection.GetCollection()] = Simulation.GetTick();
					}
				}
			}
		}

		// Token: 0x040004D6 RID: 1238
		private Dictionary<uint, IScript> scripts = new Dictionary<uint, IScript>();

		// Token: 0x040004D7 RID: 1239
		private Dictionary<uint, long> fired = new Dictionary<uint, long>();
	}
}

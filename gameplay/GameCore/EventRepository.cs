using System;
using System.Collections.Generic;
using EASharp;

namespace GameCore
{
	// Token: 0x02000237 RID: 567
	[Export]
	public class EventRepository
	{
		// Token: 0x06001720 RID: 5920 RVA: 0x00028DA0 File Offset: 0x00027DA0
		public EventRepository(InternalEventRepository internalEventRepository, Manager manager)
		{
			this.internalEventRepository = internalEventRepository;
			this.manager = manager;
			this.eventInventory = new Dictionary<uint, EventDefinition>(internalEventRepository.Count());
		}

		// Token: 0x06001721 RID: 5921 RVA: 0x00028DC7 File Offset: 0x00027DC7
		public void RefreshEvents()
		{
			this.internalEventRepository.RefreshEvents();
		}

		// Token: 0x06001722 RID: 5922 RVA: 0x00028DD4 File Offset: 0x00027DD4
		public void Add(InternalEventDefinition internalEventDefinition)
		{
			this.eventInventory.Add(internalEventDefinition.GetEventId(), new EventDefinition(internalEventDefinition, this.manager));
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x00028DF3 File Offset: 0x00027DF3
		public EventDefinition FindByEventId(uint eventId)
		{
			if (this.eventInventory.ContainsKey(eventId))
			{
				return this.eventInventory[eventId];
			}
			return null;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x00028E14 File Offset: 0x00027E14
		public EventDefinition FindByEventKey(uint eventKey)
		{
			foreach (EventDefinition eventDefinition in this.eventInventory.Values)
			{
				if (eventDefinition.EventKey == eventKey)
				{
					return eventDefinition;
				}
			}
			return null;
		}

		// Token: 0x0400059B RID: 1435
		private Dictionary<uint, EventDefinition> eventInventory;

		// Token: 0x0400059C RID: 1436
		private readonly Manager manager;

		// Token: 0x0400059D RID: 1437
		private readonly InternalEventRepository internalEventRepository;
	}
}

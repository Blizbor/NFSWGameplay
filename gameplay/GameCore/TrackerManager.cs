using System;
using System.Collections.Generic;

namespace GameCore
{
	// Token: 0x02000256 RID: 598
	public class TrackerManager
	{
		// Token: 0x06001818 RID: 6168 RVA: 0x0002AF97 File Offset: 0x00029F97
		public TrackerManager()
		{
			this.entity_counter = 0;
		}

		// Token: 0x06001819 RID: 6169 RVA: 0x0002AFB1 File Offset: 0x00029FB1
		public static TrackerManager Get()
		{
			return TrackerManager.Instance;
		}

		// Token: 0x0600181A RID: 6170 RVA: 0x0002AFB8 File Offset: 0x00029FB8
		public TrackerEntity CreateEntity(Opponent opponent)
		{
			this.entity_counter++;
			return new TrackerEntity(this.entity_counter, opponent);
		}

		// Token: 0x0600181B RID: 6171 RVA: 0x0002AFE1 File Offset: 0x00029FE1
		public void AddEntity(TrackerEntity entity)
		{
			if (!this.mEntityCollection.Contains(entity))
			{
				this.mEntityCollection.Add(entity);
				TrackerSystem.AddEntity(entity.GetInteropObj());
			}
		}

		// Token: 0x0600181C RID: 6172 RVA: 0x0002B008 File Offset: 0x0002A008
		public void RemoveEntity(TrackerEntity entity)
		{
			if (this.mEntityCollection.Remove(entity))
			{
				TrackerSystem.RemoveEntity(entity.GetInteropObj());
			}
		}

		// Token: 0x0600181D RID: 6173 RVA: 0x0002B024 File Offset: 0x0002A024
		internal void Update(float dT)
		{
			foreach (TrackerEntity trackerEntity in this.mEntityCollection)
			{
				TrackerSystem.UpdateEntity(trackerEntity.GetInteropObj());
			}
		}

		// Token: 0x040005EA RID: 1514
		private static readonly TrackerManager Instance = new TrackerManager();

		// Token: 0x040005EB RID: 1515
		private int entity_counter;

		// Token: 0x040005EC RID: 1516
		private List<TrackerEntity> mEntityCollection = new List<TrackerEntity>();
	}
}

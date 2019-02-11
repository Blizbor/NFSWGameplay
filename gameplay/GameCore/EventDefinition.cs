using System;
using EASharp;
using GameCore.Math;

namespace GameCore
{
	// Token: 0x02000236 RID: 566
	[Export]
	public class EventDefinition
	{
		// Token: 0x06001718 RID: 5912 RVA: 0x00028C8B File Offset: 0x00027C8B
		public EventDefinition(InternalEventDefinition internalEventDefinition, Manager manager)
		{
			this.internalEventDefinition = internalEventDefinition;
			this.manager = manager;
		}

		// Token: 0x06001719 RID: 5913 RVA: 0x00028CA4 File Offset: 0x00027CA4
		public void Activate()
		{
			if (!this.activated)
			{
				this.poi = this.manager.PointsOfInterest.Create(this.EventKey, 3312964337u, this.Position, this.Rotation);
				if (this.poi != null)
				{
					this.poi.LoadBehaviors(this.internalEventDefinition.BehaviorOwner());
					this.poi.Enable();
					this.activated = true;
				}
			}
		}

		// Token: 0x0600171A RID: 5914 RVA: 0x00028D18 File Offset: 0x00027D18
		public void Deactivate()
		{
			if (this.activated)
			{
				if (this.poi != null)
				{
					this.poi.Disable();
					this.manager.PointsOfInterest.Dispose(this.poi);
					this.poi = null;
				}
				this.activated = false;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x0600171B RID: 5915 RVA: 0x00028D64 File Offset: 0x00027D64
		internal uint EventKey
		{
			get
			{
				return this.internalEventDefinition.GetCollection();
			}
		}

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x0600171C RID: 5916 RVA: 0x00028D71 File Offset: 0x00027D71
		internal uint EventId
		{
			get
			{
				return this.internalEventDefinition.GetEventId();
			}
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x00028D7E File Offset: 0x00027D7E
		internal InternalEventDefinition InternalEventDef
		{
			get
			{
				return this.internalEventDefinition;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x0600171E RID: 5918 RVA: 0x00028D86 File Offset: 0x00027D86
		internal Vector3 Position
		{
			get
			{
				return this.internalEventDefinition.GetPosition();
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x00028D93 File Offset: 0x00027D93
		internal float Rotation
		{
			get
			{
				return this.internalEventDefinition.GetRotation();
			}
		}

		// Token: 0x04000597 RID: 1431
		private bool activated;

		// Token: 0x04000598 RID: 1432
		private readonly InternalEventDefinition internalEventDefinition;

		// Token: 0x04000599 RID: 1433
		private readonly Manager manager;

		// Token: 0x0400059A RID: 1434
		private PointOfInterest poi;
	}
}

using System;
using GameCore.Data;

namespace GameCore
{
	// Token: 0x02000243 RID: 579
	public class Manager
	{
		// Token: 0x0600178E RID: 6030 RVA: 0x00029E5C File Offset: 0x00028E5C
		public Manager(InternalManager internalManager)
		{
			this.internalManager = internalManager;
			this.streamingMonitor = internalManager.StreamingMonitor();
			this.opponentManager = new OpponentManager(internalManager.InternalOpponentManager());
			this.pointsOfInterest = new PoiManager(this);
			this.effects = new Effects(this);
		}

		// Token: 0x0600178F RID: 6031 RVA: 0x00029EAB File Offset: 0x00028EAB
		public void Ready()
		{
			this.internalManager.Ready();
			this.OpponentManager.Ready();
			this.StreamingMonitor.Enable();
			this.PointsOfInterest.Ready();
			this.effects.Ready();
		}

		// Token: 0x06001790 RID: 6032 RVA: 0x00029EE4 File Offset: 0x00028EE4
		public void Cleanup()
		{
			this.effects.Cleanup();
			this.PointsOfInterest.Cleanup();
			this.StreamingMonitor.Disable();
			this.OpponentManager.Cleanup();
			this.internalManager.Cleanup();
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x00029F20 File Offset: 0x00028F20
		public InstancedEvent CreateEvent(long eventSessionId, uint collectionKey, ConnectionSupport connectionSupport)
		{
			Collection collection = new Collection(collectionKey);
			if (!collection.IsValid())
			{
				collection.LoadVaultSync();
			}
			return new InstancedEvent(this.internalManager.GetInternalInstancedEvent(), this.internalManager.GetInternalEvent(), eventSessionId, this, collection, connectionSupport);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x00029F64 File Offset: 0x00028F64
		public Event CreateAsyncEvent(uint collectionKey)
		{
			Collection eventDef = new Collection(collectionKey);
			return new Event(this.internalManager.GetInternalEvent(), this, eventDef);
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06001793 RID: 6035 RVA: 0x00029F8A File Offset: 0x00028F8A
		internal OpponentManager OpponentManager
		{
			get
			{
				return this.opponentManager;
			}
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x00029F92 File Offset: 0x00028F92
		internal StreamingMonitor StreamingMonitor
		{
			get
			{
				return this.streamingMonitor;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06001795 RID: 6037 RVA: 0x00029F9A File Offset: 0x00028F9A
		internal IconManager IconManager
		{
			get
			{
				return this.internalManager.IconManager();
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00029FA7 File Offset: 0x00028FA7
		internal PoiManager PointsOfInterest
		{
			get
			{
				return this.pointsOfInterest;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x06001797 RID: 6039 RVA: 0x00029FAF File Offset: 0x00028FAF
		internal Effects Effects
		{
			get
			{
				return this.effects;
			}
		}

		// Token: 0x040005BA RID: 1466
		private readonly InternalManager internalManager;

		// Token: 0x040005BB RID: 1467
		private readonly OpponentManager opponentManager;

		// Token: 0x040005BC RID: 1468
		private readonly StreamingMonitor streamingMonitor;

		// Token: 0x040005BD RID: 1469
		private readonly PoiManager pointsOfInterest;

		// Token: 0x040005BE RID: 1470
		private readonly Effects effects;
	}
}

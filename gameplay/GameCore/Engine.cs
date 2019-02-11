using System;
using EASharp;
using GameCore.Activities;
using GameCore.Timers;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore
{
	// Token: 0x02000232 RID: 562
	[Export]
	public class Engine
	{
		// Token: 0x060016D6 RID: 5846 RVA: 0x00027EB5 File Offset: 0x00026EB5
		internal Engine(InternalEventRepository internalEventRepository, InternalManager internalManager)
		{
			this.manager = new Manager(internalManager);
			this.eventRepository = new EventRepository(internalEventRepository, this.manager);
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x00027EDB File Offset: 0x00026EDB
		public static Engine Construct(InternalEventRepository internalEventRepository, InternalManager internalManager)
		{
			Engine.Instance = new Engine(internalEventRepository, internalManager);
			return Engine.Instance;
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x00027EEE File Offset: 0x00026EEE
		public void Ready()
		{
			this.manager.Ready();
			this.gameflow = WorkflowInstance.Create(Gameflow.Create(this.manager));
			this.gameflow.Start();
		}

		// Token: 0x060016D9 RID: 5849 RVA: 0x00027F1C File Offset: 0x00026F1C
		public void Cleanup()
		{
			this.gameflow.Dispose();
			this.gameflow = null;
			this.manager.Cleanup();
		}

		// Token: 0x060016DA RID: 5850 RVA: 0x00027F3B File Offset: 0x00026F3B
		public void Update(float dt)
		{
			Timer.Update();
			SimulationTick.TickAll(dt);
			Messenger.PostRemoteMessages();
			Messenger.Flush();
			WorkflowInstance.UpdateAll(dt);
			FlasherManager.Get().Update(dt);
			TrackerManager.Get().Update(dt);
		}

		// Token: 0x060016DB RID: 5851 RVA: 0x00027F6E File Offset: 0x00026F6E
		public void PrintAll()
		{
			WorkflowInstance.PrintAll();
		}

		// Token: 0x060016DC RID: 5852 RVA: 0x00027F75 File Offset: 0x00026F75
		public void GCCollect()
		{
			GC.Collect();
		}

		// Token: 0x060016DD RID: 5853 RVA: 0x00027F7C File Offset: 0x00026F7C
		internal static Engine Get()
		{
			return Engine.Instance;
		}

		// Token: 0x060016DE RID: 5854 RVA: 0x00027F83 File Offset: 0x00026F83
		public OpponentManager OpponentManager()
		{
			return this.manager.OpponentManager;
		}

		// Token: 0x060016DF RID: 5855 RVA: 0x00027F90 File Offset: 0x00026F90
		public EventRepository EventRepository()
		{
			return this.eventRepository;
		}

		// Token: 0x060016E0 RID: 5856 RVA: 0x00027F98 File Offset: 0x00026F98
		public PoiManager PointsOfInterest()
		{
			return this.manager.PointsOfInterest;
		}

		// Token: 0x04000581 RID: 1409
		private readonly Manager manager;

		// Token: 0x04000582 RID: 1410
		private readonly EventRepository eventRepository;

		// Token: 0x04000583 RID: 1411
		private WorkflowInstance gameflow;

		// Token: 0x04000584 RID: 1412
		private static Engine Instance;
	}
}

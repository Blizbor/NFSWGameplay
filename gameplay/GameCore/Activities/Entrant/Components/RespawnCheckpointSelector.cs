using System;
using GameCore.Data;
using GameCore.Math;
using GameCore.Messages;
using GameCore.Workflow;
using UMath;

namespace GameCore.Activities.Entrant.Components
{
	// Token: 0x02000194 RID: 404
	public class RespawnCheckpointSelector : MessageHandler<OnTriggerEnter>
	{
		// Token: 0x060013A3 RID: 5027 RVA: 0x0001C801 File Offset: 0x0001B801
		public RespawnCheckpointSelector(InstancedEvent evt, EntrantInfo entrant, uint port) : base(evt, entrant, port)
		{
		}

		// Token: 0x060013A4 RID: 5028 RVA: 0x0001C80C File Offset: 0x0001B80C
		private void SetRespawnLocation()
		{
			Collection collection = new Collection(base.Event.EventDef.Checkpoints(this.checkpointIndex));
			this.Position.Value = CoordSys.RenderToSim(collection.Position());
			this.Rotation = collection.Rotation();
			this.Mps.Value = 0f;
		}

		// Token: 0x060013A5 RID: 5029 RVA: 0x0001C867 File Offset: 0x0001B867
		protected override void OnExecute(ActivityExecutionContext context)
		{
			this.SetRespawnLocation();
		}

		// Token: 0x060013A6 RID: 5030 RVA: 0x0001C870 File Offset: 0x0001B870
		protected override void OnMessage(OnTriggerEnter message)
		{
			if (message.PersonaId == base.Entrant.PersonaId)
			{
				for (uint num = this.checkpointIndex + 1u; num < base.Event.EventDef.Num_Checkpoints(); num += 1u)
				{
					if (base.Event.EventDef.Checkpoints(num).GetCollectionKey() == message.TriggerKey)
					{
						this.checkpointIndex = num;
						this.SetRespawnLocation();
					}
				}
			}
		}

		// Token: 0x17000147 RID: 327
		// (get) Token: 0x060013A7 RID: 5031 RVA: 0x0001C8DD File Offset: 0x0001B8DD
		// (set) Token: 0x060013A8 RID: 5032 RVA: 0x0001C8E5 File Offset: 0x0001B8E5
		public OutArgument<UMath.Vector3> Position
		{
			get
			{
				return this.position;
			}
			set
			{
				this.position = value;
			}
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060013A9 RID: 5033 RVA: 0x0001C8EE File Offset: 0x0001B8EE
		// (set) Token: 0x060013AA RID: 5034 RVA: 0x0001C8F6 File Offset: 0x0001B8F6
		public OutArgument<UMath.Vector3> Direction
		{
			get
			{
				return this.direction;
			}
			set
			{
				this.direction = value;
			}
		}

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060013AB RID: 5035 RVA: 0x0001C8FF File Offset: 0x0001B8FF
		// (set) Token: 0x060013AC RID: 5036 RVA: 0x0001C907 File Offset: 0x0001B907
		public OutArgument<float> Mps
		{
			get
			{
				return this.mps;
			}
			set
			{
				this.mps = value;
			}
		}

		// Token: 0x1700014A RID: 330
		// (set) Token: 0x060013AD RID: 5037 RVA: 0x0001C910 File Offset: 0x0001B910
		public float Rotation
		{
			set
			{
				this.direction.Value = CoordSys.Vector3Make(value);
			}
		}

		// Token: 0x04000497 RID: 1175
		private OutArgument<UMath.Vector3> position;

		// Token: 0x04000498 RID: 1176
		private OutArgument<UMath.Vector3> direction;

		// Token: 0x04000499 RID: 1177
		private OutArgument<float> mps;

		// Token: 0x0400049A RID: 1178
		private uint checkpointIndex;
	}
}

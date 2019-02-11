using System;
using System.IO;
using GameCore.Data;
using GameCore.Math;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Workflow;
using GameCore.Workflow.Activities;

namespace GameCore.Activities
{
	// Token: 0x020001E5 RID: 485
	public class ResetToPoint : MessageHandler<OnTriggerEnter>, ICollectionOwner
	{
		// Token: 0x060014D2 RID: 5330 RVA: 0x00024E95 File Offset: 0x00023E95
		public ResetToPoint() : base(Ports.Gameplay)
		{
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x00024EA2 File Offset: 0x00023EA2
		public static ResetToPoint Construct(BinaryReader source)
		{
			return new ResetToPoint();
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x00024EA9 File Offset: 0x00023EA9
		public void Bind(InternalCollection collection)
		{
			this.collection = collection;
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00024EB2 File Offset: 0x00023EB2
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x00024EB4 File Offset: 0x00023EB4
		protected override void OnMessage(OnTriggerEnter message)
		{
			if (this.collection.GetCollection() == message.TriggerKey)
			{
				Opponent opponent = Engine.Get().OpponentManager().FindByPersonaId(message.PersonaId);
				if (opponent != null && opponent is LocalHumanOpponent)
				{
					Collection collection = new Collection(this.collection);
					Collection collection2 = new Collection(collection.ResetMarker());
					opponent.Vehicle.WarpTo(CoordSys.RenderToSim(collection2.Position()), CoordSys.Vector3Make(collection2.Rotation()), 0f);
				}
			}
		}

		// Token: 0x040004E7 RID: 1255
		private InternalCollection collection;
	}
}

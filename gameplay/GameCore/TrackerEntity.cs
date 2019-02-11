using System;
using GameCore.Math;
using Interop;

namespace GameCore
{
	// Token: 0x02000211 RID: 529
	public class TrackerEntity
	{
		// Token: 0x06001606 RID: 5638 RVA: 0x00026884 File Offset: 0x00025884
		public TrackerEntity(int id, Opponent opponent)
		{
			this.mOpponent = opponent;
			this.mFEEntityObj.mId = id;
			this.mFEEntityObj.SetEntityName(opponent.OpponentName);
			this.mFEEntityObj.SetClipName("TeamMate");
			this.mFEEntityObj._x = 0f;
			this.mFEEntityObj._y = 0f;
			this.mFEEntityObj.distance = 0f;
			this.mFEEntityObj._visible = true;
		}

		// Token: 0x170001B4 RID: 436
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00026912 File Offset: 0x00025912
		public int Id
		{
			get
			{
				return this.mFEEntityObj.mId;
			}
		}

		// Token: 0x170001B5 RID: 437
		// (get) Token: 0x06001608 RID: 5640 RVA: 0x0002691F File Offset: 0x0002591F
		// (set) Token: 0x06001609 RID: 5641 RVA: 0x0002692C File Offset: 0x0002592C
		public bool Visible
		{
			get
			{
				return this.mFEEntityObj._visible;
			}
			set
			{
				this.mFEEntityObj._visible = value;
			}
		}

		// Token: 0x170001B6 RID: 438
		// (set) Token: 0x0600160A RID: 5642 RVA: 0x0002693A File Offset: 0x0002593A
		public Opponent Opponent
		{
			set
			{
				this.mOpponent = value;
			}
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00026944 File Offset: 0x00025944
		public TrackerEntity GetInteropObj()
		{
			Vector3 world_position = new Vector3(this.mOpponent.Vehicle.GetPosition());
			Vector2 vector = Cameras.WorldToScreenPosition(world_position);
			float angle_to_camera = Cameras.TopDownAngleToCamera(world_position);
			Vector2 vector2 = Cameras.TopDownDirectionToCamera(world_position);
			this.mFEEntityObj._x = vector.x;
			this.mFEEntityObj._y = vector.y;
			this.mFEEntityObj.angle_to_camera = angle_to_camera;
			this.mFEEntityObj.distance = Cameras.GetDistanceToCamera(world_position);
			this.mFEEntityObj.direction_x = vector2.x;
			this.mFEEntityObj.direction_y = -vector2.y;
			return this.mFEEntityObj;
		}

		// Token: 0x0400053E RID: 1342
		private Opponent mOpponent;

		// Token: 0x0400053F RID: 1343
		private TrackerEntity mFEEntityObj = new TrackerEntity();
	}
}

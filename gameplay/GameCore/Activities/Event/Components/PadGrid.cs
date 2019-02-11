using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Opponents;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001C8 RID: 456
	public class PadGrid : Component<InstancedEvent>
	{
		// Token: 0x06001463 RID: 5219 RVA: 0x000218AE File Offset: 0x000208AE
		public PadGrid(InstancedEvent @event) : base(@event)
		{
			this.mRand = new Random();
		}

		// Token: 0x06001464 RID: 5220 RVA: 0x000218C4 File Offset: 0x000208C4
		protected internal override void Execute(ActivityExecutionContext context)
		{
			if (base.Event.ConnectionSupport == ConnectionSupport.kConnectionOffline)
			{
				InternalOpponentManager.ResetNextOfflineId();
				int num = (int)base.Event.EventDef.OpponentCount();
				int num2 = (int)base.Event.EventDef.Num_Opponents();
				int num3 = num - num2;
				List<uint> list = new List<uint>();
				for (int i = 0; i < num2; i++)
				{
					if (base.Event.Entrants.Count < base.Event.DesiredOpponentCount)
					{
						uint collectionKey = base.Event.EventDef.Opponents((uint)i).GetCollectionKey();
						int num4 = this.PickOpponentPreset(collectionKey, true);
						if (num4 >= 0)
						{
							Opponent opponent = base.Event.Manager.OpponentManager.CreateLocalAI(collectionKey, (uint)num4);
							if (opponent != null)
							{
								list.Add(collectionKey);
								base.Event.AddOpponent(opponent);
							}
						}
					}
				}
				int num5 = this.AddGenericOpponents(list, num3, false);
				if (num5 < num3)
				{
					int numDesired = num3 - num5;
					this.AddGenericOpponents(list, numDesired, true);
				}
				int num6 = 1;
				foreach (EntrantInfo entrantInfo in base.Event.Entrants)
				{
					entrantInfo.Opponent.GridIndex = num6;
					num6++;
				}
			}
		}

		// Token: 0x06001465 RID: 5221 RVA: 0x00021A24 File Offset: 0x00020A24
		protected internal override void OnGetChildren(IList<WorkflowElement> children)
		{
		}

		// Token: 0x06001466 RID: 5222 RVA: 0x00021A28 File Offset: 0x00020A28
		private int AddGenericOpponents(List<uint> usedOpponentKeys, int numDesired, bool forceSelect)
		{
			int num = 0;
			for (int i = 0; i < numDesired; i++)
			{
				if (base.Event.Entrants.Count < base.Event.DesiredOpponentCount)
				{
					int presetIndex = -1;
					uint num2 = 0u;
					bool flag = this.PickGenericOpponent(usedOpponentKeys, forceSelect, ref num2, ref presetIndex);
					if (flag)
					{
						Opponent opponent = base.Event.Manager.OpponentManager.CreateLocalAI(num2, (uint)presetIndex);
						usedOpponentKeys.Add(num2);
						base.Event.AddOpponent(opponent);
						num++;
					}
				}
			}
			return num;
		}

		// Token: 0x06001467 RID: 5223 RVA: 0x00021AAC File Offset: 0x00020AAC
		private bool PickGenericOpponent(List<uint> usedOpponentKeys, bool forceSelect, ref uint collectionKey, ref int selectedPresetIndex)
		{
			bool result = false;
			Collection collection = new Collection(115800560u);
			uint num = collection.Num_Children();
			uint num2 = (uint)this.mRand.Next((int)num);
			int num3 = 0;
			while ((long)num3 < (long)((ulong)num))
			{
				Collection collection2 = new Collection(collection.Children(num2));
				if (!usedOpponentKeys.Contains(collection2.GetCollection()))
				{
					selectedPresetIndex = this.PickOpponentPreset(collection2.GetCollection(), forceSelect);
					if (selectedPresetIndex >= 0)
					{
						result = true;
						collectionKey = collection2.GetCollection();
						break;
					}
				}
				num2 = (num2 + 1u) % num;
				num3++;
			}
			return result;
		}

		// Token: 0x06001468 RID: 5224 RVA: 0x00021B34 File Offset: 0x00020B34
		private int PickOpponentPreset(uint opponentKey, bool forceSelect)
		{
			float playerRating = this.GetPlayerRating();
			Collection collection = new Collection(opponentKey);
			uint num = collection.Num_PresetRides();
			IList<int> list = new List<int>();
			IList<int> list2 = new List<int>();
			int num2 = 0;
			while ((long)num2 < (long)((ulong)num))
			{
				string presetName = collection.PresetRides((uint)num2);
				float performanceRating = Vehicle.GetPerformanceRating(presetName);
				if (performanceRating >= (float)base.Event.MinRating && performanceRating <= (float)base.Event.MaxRating)
				{
					list2.Add(num2);
					float num3 = Math.Abs(playerRating - performanceRating);
					if ((num3 / playerRating <= 0.17f && num3 < 200f) || num3 < 70f)
					{
						list.Add(num2);
					}
				}
				num2++;
			}
			int result;
			if (list.Count > 0)
			{
				int index = this.mRand.Next(list.Count);
				result = list[index];
			}
			else
			{
				int index2 = this.mRand.Next(list2.Count);
				result = list2[index2];
			}
			return result;
		}

		// Token: 0x06001469 RID: 5225 RVA: 0x00021C30 File Offset: 0x00020C30
		private float GetPlayerRating()
		{
			float result = 0f;
			for (int i = 0; i < base.Event.Entrants.Count; i++)
			{
				if (base.Event.Entrants[i].Opponent is LocalHumanOpponent)
				{
					result = base.Event.Entrants[i].Opponent.Vehicle.GetPerformanceRating();
					break;
				}
			}
			return result;
		}

		// Token: 0x040004CB RID: 1227
		private Random mRand;
	}
}

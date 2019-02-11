using System;
using System.Collections.Generic;
using GameCore.Data;
using GameCore.Messages;
using GameCore.Workflow;

namespace GameCore.Activities.Event.Components
{
	// Token: 0x020001BA RID: 442
	public class CoinsRefreshed : MessageHandler<OnCoinsRefreshed>
	{
		// Token: 0x06001432 RID: 5170 RVA: 0x00020F10 File Offset: 0x0001FF10
		public CoinsRefreshed(Event evnt, uint port) : base(evnt, port)
		{
		}

		// Token: 0x06001433 RID: 5171 RVA: 0x00020F1A File Offset: 0x0001FF1A
		protected override void OnExecute(ActivityExecutionContext context)
		{
		}

		// Token: 0x06001434 RID: 5172 RVA: 0x00020F1C File Offset: 0x0001FF1C
		protected override void OnMessage(OnCoinsRefreshed message)
		{
			int num = 0;
			for (int i = 0; i < 32; i++)
			{
				if (((ulong)message.CoinsCollected & (ulong)(1L << (i & 31))) != 0UL)
				{
					num++;
				}
			}
			if ((ulong)message.NumCoins > (ulong)((long)num))
			{
				Random random = new Random(message.Seed);
				Collection collection = new Collection(206219054u);
				List<uint> list = new List<uint>();
				for (uint num2 = 0u; num2 < collection.Num_Children(); num2 += 1u)
				{
					Collection collection2 = new Collection(collection.Children(num2).GetCollectionKey());
					if (collection2.IsDerivedFrom(737698526u))
					{
						list.Add(collection2.GetCollection());
					}
				}
				Collection collection3 = new Collection(list[random.Next(list.Count)]);
				if (message.ForcedBucket >= 0)
				{
					collection3 = new Collection(list[message.ForcedBucket]);
				}
				for (uint num3 = 0u; num3 < collection3.Num_Children(); num3 += 1u)
				{
					Collection collection4 = new Collection(collection3.Children(num3).GetCollectionKey());
					if (collection4.IsDerivedFrom(2297065609u))
					{
						base.Event.EventDef.CoinRegion(new GCollectionKey(collection4.GetCollection()));
					}
				}
				List<uint> list2 = new List<uint>();
				for (uint num4 = 0u; num4 < collection3.Num_Children(); num4 += 1u)
				{
					Collection collection5 = new Collection(collection3.Children(num4).GetCollectionKey());
					if (collection5.IsDerivedFrom(3452982098u))
					{
						list2.Add(collection5.GetCollection());
					}
				}
				Attribute orClone = base.Event.EventDef.GetOrClone(479779663u);
				orClone.SetLength(Math.Min(message.NumCoins, (uint)list2.Count));
				int num5 = 0;
				while ((long)num5 < (long)((ulong)message.NumCoins) && list2.Count > 0)
				{
					int index = random.Next(list2.Count);
					if (((ulong)message.CoinsCollected & (ulong)(1L << (num5 & 31))) == 0UL)
					{
						base.Event.EventDef.Coins(new GCollectionKey(list2[index]), (uint)num5);
					}
					else
					{
						base.Event.EventDef.Coins(new GCollectionKey(0u), (uint)num5);
					}
					list2.RemoveAt(index);
					num5++;
				}
				InstanceCatalog.Get().ReconnectInstances();
				this.Close();
			}
		}
	}
}

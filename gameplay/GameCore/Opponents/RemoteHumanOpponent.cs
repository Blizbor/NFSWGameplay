using System;

namespace GameCore.Opponents
{
	// Token: 0x02000204 RID: 516
	public class RemoteHumanOpponent : RemoteOpponent
	{
		// Token: 0x060015A5 RID: 5541 RVA: 0x00026231 File Offset: 0x00025231
		public RemoteHumanOpponent(InternalRemoteHumanOpponent internalOpponent) : base(internalOpponent)
		{
		}

		// Token: 0x17000192 RID: 402
		// (get) Token: 0x060015A6 RID: 5542 RVA: 0x0002623A File Offset: 0x0002523A
		protected InternalRemoteHumanOpponent InternalRemoteHumanOpponent
		{
			get
			{
				return base.InternalOpponent as InternalRemoteHumanOpponent;
			}
		}

		// Token: 0x060015A7 RID: 5543 RVA: 0x00026247 File Offset: 0x00025247
		public override bool IsLoaded()
		{
			return base.IsStatus(OpponentStatus.kOpponent_Disconnected) || ((base.IsStatus(OpponentStatus.kOpponent_Loaded) || !LoadingMonitor.IsBlocking()) && base.IsLoaded());
		}
	}
}

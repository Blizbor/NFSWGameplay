using System;
using EASharp;
using GameCore.Opponents;

namespace GameCore
{
	// Token: 0x020001F0 RID: 496
	[Export]
	public class PowerupFlasher : FlasherBase
	{
		// Token: 0x0600151B RID: 5403 RVA: 0x000256A4 File Offset: 0x000246A4
		public PowerupFlasher(uint collection_key, uint caller_id, uint target_id) : base(collection_key)
		{
			OpponentManager opponentManager = Engine.Get().OpponentManager();
			Opponent opponent = opponentManager.FindByPersonaId((long)((ulong)caller_id));
			Opponent opponent2 = opponentManager.FindByPersonaId((long)((ulong)target_id));
			if (opponent != null && opponent is LocalHumanOpponent)
			{
				this.mMessage = Localizer.GetLocalizedString(base.Attributes.hal_string_actor().Hash);
				if (opponent2 != null)
				{
					this.mMessage = string.Format(this.mMessage, opponent2.ToString());
				}
				else
				{
					this.mMessage = string.Format(this.mMessage, opponent.ToString());
				}
				FlasherManager.Get().EnqueueFlasher(this);
				return;
			}
			if (opponent2 != null && opponent2 is LocalHumanOpponent)
			{
				this.mMessage = Localizer.GetLocalizedString(base.Attributes.hal_string_target().Hash);
				if (opponent != null)
				{
					this.mMessage = string.Format(this.mMessage, opponent.ToString());
				}
				else
				{
					this.mMessage = string.Format(this.mMessage, opponent2.ToString());
				}
				FlasherManager.Get().EnqueueFlasher(this);
				return;
			}
			if (base.Attributes.notify_spectators() && (opponent != null || opponent2 != null))
			{
				this.mMessage = Localizer.GetLocalizedString(base.Attributes.hal_string_spectator().Hash);
				if (opponent2 != null)
				{
					this.mMessage = string.Format(this.mMessage, opponent2.ToString());
				}
				else
				{
					this.mMessage = string.Format(this.mMessage, opponent.ToString());
				}
				FlasherManager.Get().EnqueueFlasher(this);
			}
		}
	}
}

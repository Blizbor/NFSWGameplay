using System;
using Attrib.Gen;
using EASharp;
using GameCore.Opponents;

namespace GameCore
{
	// Token: 0x020001F2 RID: 498
	[Export]
	public class ShieldedFlasher : FlasherBase
	{
		// Token: 0x0600151F RID: 5407 RVA: 0x00025898 File Offset: 0x00024898
		public ShieldedFlasher(uint powerup_fe_flasher_hash, int caller_id, int target_id) : base(2977220007u)
		{
			fe_flashers fe_flashers = new fe_flashers(powerup_fe_flasher_hash);
			OpponentManager opponentManager = Engine.Get().OpponentManager();
			Opponent opponent = opponentManager.FindByPersonaId((long)caller_id);
			Opponent opponent2 = opponentManager.FindByPersonaId((long)target_id);
			if (opponent != null && opponent is LocalHumanOpponent)
			{
				this.mMessage = Localizer.GetLocalizedString(base.Attributes.hal_string_actor().Hash);
				this.mMessage = string.Format(this.mMessage, Localizer.GetLocalizedString(fe_flashers.hal_string().Hash));
				return;
			}
			if (opponent2 != null && opponent2 is LocalHumanOpponent)
			{
				this.mMessage = Localizer.GetLocalizedString(base.Attributes.hal_string_target().Hash);
				this.mMessage = string.Format(this.mMessage, Localizer.GetLocalizedString(fe_flashers.hal_string().Hash));
				return;
			}
			this.mMessage = Localizer.GetLocalizedString(base.Attributes.hal_string_spectator().Hash);
			this.mMessage = string.Format(this.mMessage, Localizer.GetLocalizedString(fe_flashers.hal_string().Hash));
		}
	}
}

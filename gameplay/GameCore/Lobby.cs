using System;
using EASharp;
using GameCore.Messages;

namespace GameCore
{
	// Token: 0x02000242 RID: 578
	[Export]
	public class Lobby
	{
		// Token: 0x06001789 RID: 6025 RVA: 0x00029DDF File Offset: 0x00028DDF
		public Lobby(InternalLobby internalLobby)
		{
			this.internalLobby = internalLobby;
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x00029DF0 File Offset: 0x00028DF0
		public void EnterLobby(uint eventId)
		{
			EventDefinition eventDefinition = Engine.Get().EventRepository().FindByEventId(eventId);
			if (eventDefinition != null)
			{
				new OnEnterLobby(eventDefinition.EventKey).Post(Ports.Gameplay);
			}
		}

		// Token: 0x0600178B RID: 6027 RVA: 0x00029E26 File Offset: 0x00028E26
		public void OnFailed()
		{
			new OnLobbyFailed().Post(Ports.Gameplay);
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00029E37 File Offset: 0x00028E37
		public void OnCancelled()
		{
			new OnLobbyCancelled().Post(Ports.Gameplay);
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x00029E48 File Offset: 0x00028E48
		public void OnExited()
		{
			new OnLobbyExited().Post(Ports.Gameplay);
		}

		// Token: 0x040005B9 RID: 1465
		private readonly InternalLobby internalLobby;
	}
}

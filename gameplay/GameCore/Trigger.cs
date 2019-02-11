using System;
using EASharp;
using GameCore.Collision;
using GameCore.Math;
using GameCore.Messages;
using GameCore.Opponents;

namespace GameCore
{
	// Token: 0x02000257 RID: 599
	[Export]
	public class Trigger : IDisposable
	{
		// Token: 0x0600181F RID: 6175 RVA: 0x0002B088 File Offset: 0x0002A088
		public Trigger(uint key, TriggerType type, Vector3 position, Vector3 dimensions, float rotation)
		{
			this.key = key;
			switch (type)
			{
			case TriggerType.Cylinder:
				this.collisionTrigger = new Trigger(key, type, position, dimensions.x, 0f);
				break;
			case TriggerType.Box:
				this.collisionTrigger = new Trigger(key, type, position, dimensions, rotation);
				break;
			case TriggerType.Plane:
				this.collisionTrigger = new Trigger(key, type, position, dimensions.x, rotation);
				break;
			}
			this.collisionTrigger.Entered += this.OnEntered;
			this.collisionTrigger.Exited += this.OnExited;
		}

		// Token: 0x06001820 RID: 6176 RVA: 0x0002B130 File Offset: 0x0002A130
		~Trigger()
		{
			this.Dispose(false);
		}

		// Token: 0x06001821 RID: 6177 RVA: 0x0002B160 File Offset: 0x0002A160
		public virtual void Enable()
		{
			this.collisionTrigger.Enable();
		}

		// Token: 0x06001822 RID: 6178 RVA: 0x0002B16D File Offset: 0x0002A16D
		public virtual void Disable()
		{
			this.collisionTrigger.Disable();
		}

		// Token: 0x06001823 RID: 6179 RVA: 0x0002B17A File Offset: 0x0002A17A
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x06001824 RID: 6180 RVA: 0x0002B18C File Offset: 0x0002A18C
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				if (disposing)
				{
					this.collisionTrigger.Entered -= this.OnEntered;
					this.collisionTrigger.Exited -= this.OnExited;
					this.collisionTrigger.Dispose();
					this.collisionTrigger = null;
				}
				this.isDisposed = true;
			}
		}

		// Token: 0x06001825 RID: 6181 RVA: 0x0002B1EB File Offset: 0x0002A1EB
		protected void OnEntered(object sender, TriggerEventArgs e)
		{
			if (Engine.Get().OpponentManager().FindByPersonaId(e.PersonaId) is LocalOpponent)
			{
				new OnTriggerEnter(this.Key, e.PersonaId).Post(Ports.Gameplay);
			}
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x0002B224 File Offset: 0x0002A224
		protected void OnExited(object sender, TriggerEventArgs e)
		{
			if (Engine.Get().OpponentManager().FindByPersonaId(e.PersonaId) is LocalOpponent)
			{
				new OnTriggerExit(this.Key, e.PersonaId).Post(Ports.Gameplay);
			}
		}

		// Token: 0x17000215 RID: 533
		// (get) Token: 0x06001827 RID: 6183 RVA: 0x0002B25D File Offset: 0x0002A25D
		public uint Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x040005ED RID: 1517
		private Trigger collisionTrigger;

		// Token: 0x040005EE RID: 1518
		private uint key;

		// Token: 0x040005EF RID: 1519
		private bool isDisposed;
	}
}

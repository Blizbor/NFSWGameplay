using System;
using EASharp;
using GameCore.Collision;
using GameCore.Data;
using GameCore.Math;
using GameCore.Messages;
using GameCore.Opponents;
using GameCore.Streaming;

namespace GameCore
{
	// Token: 0x0200024B RID: 587
	[Export]
	public class PointOfInterest : IDisposable, ITokenListener
	{
		// Token: 0x060017C8 RID: 6088 RVA: 0x0002A870 File Offset: 0x00029870
		internal PointOfInterest(Manager manager, uint key, InternalInstance poiType, Vector3 position, float rotation)
		{
			this.manager = manager;
			this.key = key;
			this.poi = new Collection(poiType);
			this.token = manager.StreamingMonitor.Create(position, 0f);
			this.token.Listen(this);
			this.behaviorContainer = new InternalBehaviorContainer(poiType);
			uint mBits = this.poi.PointOfInterestBehavior().mBits;
			if ((mBits & 1u) != 0u)
			{
				this.icon = manager.IconManager.Create(position, poiType.GetCollection(), rotation);
			}
		}

		// Token: 0x060017C9 RID: 6089 RVA: 0x0002A900 File Offset: 0x00029900
		~PointOfInterest()
		{
			this.Dispose(false);
		}

		// Token: 0x060017CA RID: 6090 RVA: 0x0002A930 File Offset: 0x00029930
		public void LoadBehaviors(IInternalBehaviorOwner owner)
		{
			this.behaviorContainer.Load(owner);
		}

		// Token: 0x060017CB RID: 6091 RVA: 0x0002A93E File Offset: 0x0002993E
		public void OnActivated()
		{
			if ((this.flags & PointOfInterest.Flags.Enabled) != PointOfInterest.Flags.None && (this.flags & PointOfInterest.Flags.Hidden) == PointOfInterest.Flags.None)
			{
				if (null != this.behaviorContainer)
				{
					this.behaviorContainer.Activate();
					return;
				}
			}
			else
			{
				this.OnDeactivated();
			}
		}

		// Token: 0x060017CC RID: 6092 RVA: 0x0002A974 File Offset: 0x00029974
		public void OnDeactivated()
		{
			if (null != this.behaviorContainer)
			{
				this.behaviorContainer.Deactivate();
			}
		}

		// Token: 0x060017CD RID: 6093 RVA: 0x0002A98F File Offset: 0x0002998F
		public virtual bool IsEnabled()
		{
			return (this.flags & PointOfInterest.Flags.Enabled) == PointOfInterest.Flags.Enabled;
		}

		// Token: 0x060017CE RID: 6094 RVA: 0x0002A99C File Offset: 0x0002999C
		public virtual void Enable()
		{
			this.flags |= PointOfInterest.Flags.Enabled;
			if ((this.flags & PointOfInterest.Flags.Hidden) == PointOfInterest.Flags.None)
			{
				if (null != this.icon)
				{
					this.icon.Enable();
				}
				this.manager.StreamingMonitor.RefreshToken(this.token);
			}
		}

		// Token: 0x060017CF RID: 6095 RVA: 0x0002A9F1 File Offset: 0x000299F1
		public virtual void Disable()
		{
			this.flags &= ~PointOfInterest.Flags.Enabled;
			if (null != this.icon)
			{
				this.icon.Disable();
			}
			this.OnDeactivated();
		}

		// Token: 0x060017D0 RID: 6096 RVA: 0x0002AA21 File Offset: 0x00029A21
		public virtual void Hide()
		{
			this.flags |= PointOfInterest.Flags.Hidden;
			if (null != this.icon)
			{
				this.icon.Disable();
			}
			this.OnDeactivated();
		}

		// Token: 0x060017D1 RID: 6097 RVA: 0x0002AA50 File Offset: 0x00029A50
		public virtual void Show()
		{
			this.flags &= ~PointOfInterest.Flags.Hidden;
			if ((this.flags & PointOfInterest.Flags.Enabled) != PointOfInterest.Flags.None)
			{
				if (null != this.icon)
				{
					this.icon.Enable();
				}
				this.manager.StreamingMonitor.RefreshToken(this.token);
			}
		}

		// Token: 0x060017D2 RID: 6098 RVA: 0x0002AAA6 File Offset: 0x00029AA6
		internal bool Equals(uint key, uint type)
		{
			return this.key == key && this.poi.GetCollection() == type;
		}

		// Token: 0x060017D3 RID: 6099 RVA: 0x0002AAC1 File Offset: 0x00029AC1
		public bool IsTypeOf(uint type)
		{
			return this.poi.GetCollection() == type || this.poi.IsDerivedFrom(type);
		}

		// Token: 0x060017D4 RID: 6100 RVA: 0x0002AADF File Offset: 0x00029ADF
		public void Dispose()
		{
			this.Dispose(true);
			GC.SuppressFinalize(this);
		}

		// Token: 0x060017D5 RID: 6101 RVA: 0x0002AAF0 File Offset: 0x00029AF0
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				if (disposing)
				{
					if (null != this.icon)
					{
						this.manager.IconManager.Destroy(this.icon);
						this.icon = null;
					}
					this.manager.StreamingMonitor.Destroy(this.token);
					this.token = null;
				}
				this.poi = null;
				this.behaviorContainer.Unload();
				this.behaviorContainer = null;
				this.isDisposed = true;
			}
		}

		// Token: 0x060017D6 RID: 6102 RVA: 0x0002AB70 File Offset: 0x00029B70
		protected void OnEntered(object sender, TriggerEventArgs e)
		{
			if (Engine.Get().OpponentManager().FindByPersonaId(e.PersonaId) is LocalOpponent)
			{
				new OnTriggerEnter(this.Key, e.PersonaId).Post(Ports.Gameplay);
			}
		}

		// Token: 0x060017D7 RID: 6103 RVA: 0x0002ABA9 File Offset: 0x00029BA9
		protected void OnExited(object sender, TriggerEventArgs e)
		{
			if (Engine.Get().OpponentManager().FindByPersonaId(e.PersonaId) is LocalOpponent)
			{
				new OnTriggerExit(this.Key, e.PersonaId).Post(Ports.Gameplay);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x060017D8 RID: 6104 RVA: 0x0002ABE2 File Offset: 0x00029BE2
		public uint Key
		{
			get
			{
				return this.key;
			}
		}

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x060017D9 RID: 6105 RVA: 0x0002ABEA File Offset: 0x00029BEA
		public StreamingToken Token
		{
			get
			{
				return this.token;
			}
		}

		// Token: 0x040005CA RID: 1482
		private readonly Manager manager;

		// Token: 0x040005CB RID: 1483
		private StreamingToken token;

		// Token: 0x040005CC RID: 1484
		private Icon icon;

		// Token: 0x040005CD RID: 1485
		private Collection poi;

		// Token: 0x040005CE RID: 1486
		private InternalBehaviorContainer behaviorContainer;

		// Token: 0x040005CF RID: 1487
		private bool isDisposed;

		// Token: 0x040005D0 RID: 1488
		private PointOfInterest.Flags flags;

		// Token: 0x040005D1 RID: 1489
		private readonly uint key;

		// Token: 0x0200024C RID: 588
		[Flags]
		public enum Flags
		{
			// Token: 0x040005D3 RID: 1491
			None = 0,
			// Token: 0x040005D4 RID: 1492
			Enabled = 1,
			// Token: 0x040005D5 RID: 1493
			Hidden = 2,
			// Token: 0x040005D6 RID: 1494
			Disposable = 3
		}
	}
}

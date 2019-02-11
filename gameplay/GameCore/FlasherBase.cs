using System;
using Attrib.Gen;
using EASharp;
using Interop;

namespace GameCore
{
	// Token: 0x020001EB RID: 491
	[Export]
	public class FlasherBase : IComparable<FlasherBase>
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060014F9 RID: 5369 RVA: 0x00025397 File Offset: 0x00024397
		public string Message
		{
			get
			{
				return this.mMessage;
			}
		}

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060014FA RID: 5370 RVA: 0x0002539F File Offset: 0x0002439F
		public string ClipName
		{
			get
			{
				return this.mAttributes.movie_clip_name();
			}
		}

		// Token: 0x17000168 RID: 360
		// (get) Token: 0x060014FB RID: 5371 RVA: 0x000253AC File Offset: 0x000243AC
		public FLASHER_ALIGNMENT vAlign
		{
			get
			{
				return this.mAttributes.vertical_alignment();
			}
		}

		// Token: 0x17000169 RID: 361
		// (get) Token: 0x060014FC RID: 5372 RVA: 0x000253B9 File Offset: 0x000243B9
		public int Id
		{
			get
			{
				return this.mId;
			}
		}

		// Token: 0x1700016A RID: 362
		// (get) Token: 0x060014FD RID: 5373 RVA: 0x000253C1 File Offset: 0x000243C1
		// (set) Token: 0x060014FE RID: 5374 RVA: 0x000253C9 File Offset: 0x000243C9
		public float EnqueueTimer
		{
			get
			{
				return this.mEnqueueTimer;
			}
			set
			{
				this.mEnqueueTimer = value;
			}
		}

		// Token: 0x1700016B RID: 363
		// (get) Token: 0x060014FF RID: 5375 RVA: 0x000253D2 File Offset: 0x000243D2
		// (set) Token: 0x06001500 RID: 5376 RVA: 0x000253DA File Offset: 0x000243DA
		public float RunningTimer
		{
			get
			{
				return this.mRunningTimer;
			}
			set
			{
				this.mRunningTimer = value;
			}
		}

		// Token: 0x1700016C RID: 364
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x000253E3 File Offset: 0x000243E3
		// (set) Token: 0x06001502 RID: 5378 RVA: 0x000253EB File Offset: 0x000243EB
		internal FlasherBase.eFlasherStatus Status
		{
			get
			{
				return this.mStatus;
			}
			set
			{
				this.mStatus = value;
			}
		}

		// Token: 0x1700016D RID: 365
		// (get) Token: 0x06001503 RID: 5379 RVA: 0x000253F4 File Offset: 0x000243F4
		public int Priority
		{
			get
			{
				return this.mAttributes.priority();
			}
		}

		// Token: 0x1700016E RID: 366
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x00025401 File Offset: 0x00024401
		public float DisplayTime
		{
			get
			{
				return this.mAttributes.display_time();
			}
		}

		// Token: 0x1700016F RID: 367
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0002540E File Offset: 0x0002440E
		public float WaitingLimit
		{
			get
			{
				return this.mAttributes.wait_limit();
			}
		}

		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06001506 RID: 5382 RVA: 0x0002541B File Offset: 0x0002441B
		public bool KillWhenCut
		{
			get
			{
				return this.mAttributes.kill_when_cut();
			}
		}

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06001507 RID: 5383 RVA: 0x00025428 File Offset: 0x00024428
		public bool CutWhenPriorityEqual
		{
			get
			{
				return this.mAttributes.cut_when_priority_equal();
			}
		}

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06001508 RID: 5384 RVA: 0x00025435 File Offset: 0x00024435
		public fe_flashers Attributes
		{
			get
			{
				return this.mAttributes;
			}
		}

		// Token: 0x06001509 RID: 5385 RVA: 0x0002543D File Offset: 0x0002443D
		public FlasherBase(uint collection_key)
		{
			this.mAttributes = new fe_flashers(collection_key);
			this.mMessage = Localizer.GetLocalizedString(this.Attributes.hal_string().Hash);
			this.Reset();
		}

		// Token: 0x0600150A RID: 5386 RVA: 0x00025479 File Offset: 0x00024479
		public void Init(int id)
		{
			this.Reset();
			this.mId = id;
		}

		// Token: 0x0600150B RID: 5387 RVA: 0x00025488 File Offset: 0x00024488
		public void Reset()
		{
			this.mId = -1;
			this.mEnqueueTimer = 0f;
			this.mRunningTimer = 0f;
			this.mStatus = FlasherBase.eFlasherStatus.eIdle;
		}

		// Token: 0x0600150C RID: 5388 RVA: 0x000254B0 File Offset: 0x000244B0
		public virtual FrontendFlasher CreateFrontendFlasherObj()
		{
			FrontendFlasher frontendFlasher = new FrontendFlasher();
			frontendFlasher.mId = this.Id;
			frontendFlasher.SetMessage(this.Message);
			frontendFlasher.SetClipName(this.ClipName);
			frontendFlasher.vAlign = this.vAlign;
			return frontendFlasher;
		}

		// Token: 0x0600150D RID: 5389 RVA: 0x000254F4 File Offset: 0x000244F4
		public void OnFlasherStarted()
		{
			if (this.FlasherStarted != null)
			{
				this.FlasherStarted(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600150E RID: 5390 RVA: 0x0002550F File Offset: 0x0002450F
		public void OnFlasherIntroComplete()
		{
			if (this.FlasherIntroComplete != null)
			{
				this.FlasherIntroComplete(this, EventArgs.Empty);
			}
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0002552A File Offset: 0x0002452A
		public void OnFlasherFinished()
		{
			if (this.FlasherFinished != null)
			{
				this.FlasherFinished(this, EventArgs.Empty);
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06001510 RID: 5392 RVA: 0x00025545 File Offset: 0x00024545
		// (remove) Token: 0x06001511 RID: 5393 RVA: 0x0002555E File Offset: 0x0002455E
		public event EventHandler FlasherStarted;

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06001512 RID: 5394 RVA: 0x00025577 File Offset: 0x00024577
		// (remove) Token: 0x06001513 RID: 5395 RVA: 0x00025590 File Offset: 0x00024590
		public event EventHandler FlasherIntroComplete;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06001514 RID: 5396 RVA: 0x000255A9 File Offset: 0x000245A9
		// (remove) Token: 0x06001515 RID: 5397 RVA: 0x000255C2 File Offset: 0x000245C2
		public event EventHandler FlasherFinished;

		// Token: 0x06001516 RID: 5398 RVA: 0x000255DC File Offset: 0x000245DC
		public int CompareTo(FlasherBase obj)
		{
			return this.Priority.CompareTo(obj.Priority);
		}

		// Token: 0x040004F3 RID: 1267
		private FlasherBase.eFlasherStatus mStatus;

		// Token: 0x040004F4 RID: 1268
		protected string mMessage;

		// Token: 0x040004F5 RID: 1269
		private int mId = -1;

		// Token: 0x040004F6 RID: 1270
		private float mEnqueueTimer;

		// Token: 0x040004F7 RID: 1271
		private float mRunningTimer;

		// Token: 0x040004F8 RID: 1272
		private fe_flashers mAttributes;

		// Token: 0x020001EC RID: 492
		internal enum eFlasherStatus
		{
			// Token: 0x040004FD RID: 1277
			eIdle,
			// Token: 0x040004FE RID: 1278
			eRunning,
			// Token: 0x040004FF RID: 1279
			eCanceled,
			// Token: 0x04000500 RID: 1280
			eMarkedForDeletion
		}
	}
}

using System;
using System.Collections.Generic;
using EASharp;

namespace GameCore
{
	// Token: 0x02000238 RID: 568
	[Export]
	public class FlasherManager
	{
		// Token: 0x06001725 RID: 5925 RVA: 0x00028E78 File Offset: 0x00027E78
		public FlasherManager()
		{
			this.flasher_counter = 0;
		}

		// Token: 0x06001726 RID: 5926 RVA: 0x00028E92 File Offset: 0x00027E92
		public static FlasherManager Get()
		{
			return FlasherManager.Instance;
		}

		// Token: 0x06001727 RID: 5927 RVA: 0x00028EB8 File Offset: 0x00027EB8
		public int EnqueueFlasher(FlasherBase new_flasher)
		{
			if (this.mFlasherQueue.Find((FlasherBase f) => f.Id == new_flasher.Id) == null)
			{
				this.flasher_counter++;
				new_flasher.Init(this.flasher_counter);
				for (int i = this.mFlasherQueue.Count - 1; i >= 0; i--)
				{
					FlasherBase flasherBase = this.mFlasherQueue[i];
					if (flasherBase.CutWhenPriorityEqual && flasherBase.Priority == new_flasher.Priority)
					{
						this.KillFlasher(flasherBase.Id);
					}
				}
				this.mFlasherQueue.Add(new_flasher);
				Console.WriteLine("FlasherManager.EnqueueFlasher() id: {0:d}", new_flasher.Id);
				return this.flasher_counter;
			}
			return -1;
		}

		// Token: 0x06001728 RID: 5928 RVA: 0x00028FA8 File Offset: 0x00027FA8
		public void DequeueFlasher(int flasher_id)
		{
			FlasherBase flasherBase = this.mFlasherQueue.Find((FlasherBase f) => f.Id == flasher_id);
			if (flasherBase != null)
			{
				if (flasherBase.Status == FlasherBase.eFlasherStatus.eRunning)
				{
					flasherBase.Status = FlasherBase.eFlasherStatus.eCanceled;
					Flashers.CancelFlasher(flasherBase.Id);
					return;
				}
				if (flasherBase.Status == FlasherBase.eFlasherStatus.eIdle)
				{
					flasherBase.Status = FlasherBase.eFlasherStatus.eMarkedForDeletion;
				}
			}
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x00029008 File Offset: 0x00028008
		public void KillAllFlashers()
		{
			foreach (FlasherBase flasherBase in this.mFlasherQueue)
			{
				this.KillFlasher(flasherBase.Id);
			}
		}

		// Token: 0x0600172A RID: 5930 RVA: 0x00029078 File Offset: 0x00028078
		public void KillFlasher(int flasher_id)
		{
			FlasherBase flasherBase = this.mFlasherQueue.Find((FlasherBase f) => f.Id == flasher_id);
			if (flasherBase != null)
			{
				if (flasherBase.Status == FlasherBase.eFlasherStatus.eRunning)
				{
					flasherBase.Status = FlasherBase.eFlasherStatus.eMarkedForDeletion;
					Flashers.KillFlasher(flasherBase.Id);
					return;
				}
				if (flasherBase.Status == FlasherBase.eFlasherStatus.eIdle)
				{
					flasherBase.Status = FlasherBase.eFlasherStatus.eMarkedForDeletion;
				}
			}
		}

		// Token: 0x0600172B RID: 5931 RVA: 0x000290D8 File Offset: 0x000280D8
		internal void Update(float dT)
		{
			this.mFlasherQueue.Sort();
			foreach (FlasherBase flasherBase in this.mFlasherQueue)
			{
				if (flasherBase.Status == FlasherBase.eFlasherStatus.eRunning)
				{
					flasherBase.RunningTimer += dT;
					if (flasherBase.DisplayTime >= 0f && flasherBase.RunningTimer > flasherBase.DisplayTime)
					{
						flasherBase.Status = FlasherBase.eFlasherStatus.eCanceled;
						Flashers.CancelFlasher(flasherBase.Id);
					}
					else if (flasherBase != this.mFlasherQueue[0])
					{
						if (flasherBase.KillWhenCut)
						{
							flasherBase.Status = FlasherBase.eFlasherStatus.eMarkedForDeletion;
							Flashers.KillFlasher(flasherBase.Id);
						}
						else
						{
							Flashers.CancelFlasher(flasherBase.Id);
							flasherBase.Init(flasherBase.Id);
						}
					}
				}
				else
				{
					flasherBase.EnqueueTimer += dT;
					if ((double)flasherBase.WaitingLimit >= 0.0 && flasherBase.EnqueueTimer > flasherBase.WaitingLimit)
					{
						flasherBase.Status = FlasherBase.eFlasherStatus.eCanceled;
						Flashers.CancelFlasher(flasherBase.Id);
					}
				}
			}
			for (int i = this.mFlasherQueue.Count - 1; i >= 0; i--)
			{
				FlasherBase flasherBase2 = this.mFlasherQueue[i];
				if (flasherBase2.Status == FlasherBase.eFlasherStatus.eMarkedForDeletion)
				{
					flasherBase2.Reset();
					this.mFlasherQueue.RemoveAt(i);
				}
			}
			if (this.mFlasherQueue.Count > 0)
			{
				FlasherBase flasherBase3 = this.mFlasherQueue[0];
				if (flasherBase3.Status == FlasherBase.eFlasherStatus.eIdle)
				{
					flasherBase3.Status = FlasherBase.eFlasherStatus.eRunning;
					Flashers.AddFlasher(flasherBase3.CreateFrontendFlasherObj());
				}
			}
		}

		// Token: 0x0600172C RID: 5932 RVA: 0x00029294 File Offset: 0x00028294
		public void OnFlasherStarted(int flasher_id)
		{
			FlasherBase flasherBase = this.mFlasherQueue.Find((FlasherBase f) => f.Id == flasher_id);
			if (flasherBase != null)
			{
				flasherBase.OnFlasherStarted();
			}
		}

		// Token: 0x0600172D RID: 5933 RVA: 0x000292E8 File Offset: 0x000282E8
		public void OnFlasherIntroComplete(int flasher_id)
		{
			FlasherBase flasherBase = this.mFlasherQueue.Find((FlasherBase f) => f.Id == flasher_id);
			if (flasherBase != null)
			{
				flasherBase.OnFlasherIntroComplete();
			}
		}

		// Token: 0x0600172E RID: 5934 RVA: 0x0002933C File Offset: 0x0002833C
		public void OnFlasherFinished(int flasher_id)
		{
			FlasherBase flasherBase = this.mFlasherQueue.Find((FlasherBase f) => f.Id == flasher_id);
			if (flasherBase != null)
			{
				flasherBase.OnFlasherFinished();
				if (flasherBase.Status == FlasherBase.eFlasherStatus.eCanceled || flasherBase.Status == FlasherBase.eFlasherStatus.eRunning)
				{
					flasherBase.Status = FlasherBase.eFlasherStatus.eMarkedForDeletion;
				}
			}
		}

		// Token: 0x0400059E RID: 1438
		private static readonly FlasherManager Instance = new FlasherManager();

		// Token: 0x0400059F RID: 1439
		private List<FlasherBase> mFlasherQueue = new List<FlasherBase>();

		// Token: 0x040005A0 RID: 1440
		private int flasher_counter;
	}
}

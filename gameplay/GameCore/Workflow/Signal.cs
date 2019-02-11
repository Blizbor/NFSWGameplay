using System;
using System.Collections.Generic;

namespace GameCore.Workflow
{
	// Token: 0x0200022A RID: 554
	public class Signal
	{
		// Token: 0x06001691 RID: 5777 RVA: 0x00027750 File Offset: 0x00026750
		private Signal(uint hash)
		{
			this.hash = hash;
		}

		// Token: 0x06001692 RID: 5778 RVA: 0x0002775F File Offset: 0x0002675F
		protected void OnWaitAll()
		{
			if (this.internalWaitAll != null)
			{
				this.internalWaitAll(this);
			}
		}

		// Token: 0x06001693 RID: 5779 RVA: 0x00027775 File Offset: 0x00026775
		protected void OnWaitAny()
		{
			if (this.internalWaitAny != null)
			{
				this.internalWaitAny(this);
			}
		}

		// Token: 0x06001694 RID: 5780 RVA: 0x0002778B File Offset: 0x0002678B
		public void Set()
		{
			this.setCount += 1u;
			this.OnWaitAny();
			if (this.setCount == this.waitCount)
			{
				this.OnWaitAll();
				this.setCount = 0u;
			}
		}

		// Token: 0x06001695 RID: 5781 RVA: 0x000277BC File Offset: 0x000267BC
		public void UnSet()
		{
			this.setCount -= 1u;
		}

		// Token: 0x06001696 RID: 5782 RVA: 0x000277CC File Offset: 0x000267CC
		public void Release()
		{
			this.internalWaitAll = null;
			this.internalWaitAny = null;
			Signal.Signals.Remove(this.hash);
		}

		// Token: 0x06001697 RID: 5783 RVA: 0x000277F0 File Offset: 0x000267F0
		public static Signal CreateNamedSignal(string name)
		{
			uint key = Hash.Hash32(name);
			Signal signal = new Signal(key);
			Signal.Signals.Add(key, signal);
			return signal;
		}

		// Token: 0x06001698 RID: 5784 RVA: 0x00027818 File Offset: 0x00026818
		public static Signal OpenExistingSignal(string name)
		{
			uint key = Hash.Hash32(name);
			if (Signal.Signals.ContainsKey(key))
			{
				return Signal.Signals[key];
			}
			return null;
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x06001699 RID: 5785 RVA: 0x00027846 File Offset: 0x00026846
		// (remove) Token: 0x0600169A RID: 5786 RVA: 0x0002786D File Offset: 0x0002686D
		public event SignalCallback WaitAll
		{
			add
			{
				this.waitCount += 1u;
				this.internalWaitAll = (SignalCallback)Delegate.Combine(this.internalWaitAll, value);
			}
			remove
			{
				this.waitCount -= 1u;
				this.internalWaitAll = (SignalCallback)Delegate.Remove(this.internalWaitAll, value);
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600169B RID: 5787 RVA: 0x00027894 File Offset: 0x00026894
		// (remove) Token: 0x0600169C RID: 5788 RVA: 0x000278AD File Offset: 0x000268AD
		public event SignalCallback WaitAny
		{
			add
			{
				this.internalWaitAny = (SignalCallback)Delegate.Combine(this.internalWaitAny, value);
			}
			remove
			{
				this.internalWaitAny = (SignalCallback)Delegate.Remove(this.internalWaitAny, value);
			}
		}

		// Token: 0x0400056E RID: 1390
		private SignalCallback internalWaitAll;

		// Token: 0x0400056F RID: 1391
		private SignalCallback internalWaitAny;

		// Token: 0x04000570 RID: 1392
		private readonly uint hash;

		// Token: 0x04000571 RID: 1393
		private uint waitCount;

		// Token: 0x04000572 RID: 1394
		private uint setCount;

		// Token: 0x04000573 RID: 1395
		private static Dictionary<uint, Signal> Signals = new Dictionary<uint, Signal>();
	}
}

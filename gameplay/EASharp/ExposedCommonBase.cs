using System;

namespace EASharp
{
	// Token: 0x02000006 RID: 6
	public class ExposedCommonBase
	{
		// Token: 0x06000004 RID: 4 RVA: 0x0000207D File Offset: 0x0000107D
		protected internal unsafe void* _GetRaw()
		{
			return this.mSelf;
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002085 File Offset: 0x00001085
		protected unsafe ExposedCommonBase(ExposeTag_InitUnowned tag, void* self)
		{
			GC.SuppressFinalize(this);
			this.mSelf = self;
		}

		// Token: 0x06000006 RID: 6 RVA: 0x0000209A File Offset: 0x0000109A
		protected ExposedCommonBase(ExposeTag_NoInitOwned tag)
		{
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020A2 File Offset: 0x000010A2
		protected unsafe ExposedCommonBase(ExposeTag_InitOwned tag, void* self)
		{
			this.mSelf = self;
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020B1 File Offset: 0x000010B1
		public static bool operator ==(ExposedCommonBase a, ExposedCommonBase b)
		{
			return (object.ReferenceEquals(a, null) && object.ReferenceEquals(b, null)) || (!object.ReferenceEquals(a, null) && !object.ReferenceEquals(b, null) && a._GetRaw() == b._GetRaw());
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020E9 File Offset: 0x000010E9
		public static bool operator !=(ExposedCommonBase a, ExposedCommonBase b)
		{
			return !(a == b);
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020F5 File Offset: 0x000010F5
		public override int GetHashCode()
		{
			return (int)((IntPtr)this.mSelf);
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002107 File Offset: 0x00001107
		public override bool Equals(object o)
		{
			return o != null && o.GetType() == base.GetType() && this == (ExposedCommonBase)o;
		}

		// Token: 0x04000001 RID: 1
		protected unsafe void* mSelf;
	}
}

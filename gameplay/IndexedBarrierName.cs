using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000E9 RID: 233
[ExportOnlyCreate(true)]
public class IndexedBarrierName : ExposedCommonBase
{
	// Token: 0x06000DF4 RID: 3572 RVA: 0x00010B68 File Offset: 0x0000FB68
	public unsafe static IndexedBarrierName CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new IndexedBarrierName(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000DF5 RID: 3573 RVA: 0x00010B8B File Offset: 0x0000FB8B
	public unsafe IndexedBarrierName(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000DF6 RID: 3574 RVA: 0x00010B95 File Offset: 0x0000FB95
	protected internal IndexedBarrierName(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000DF7 RID: 3575 RVA: 0x00010B9E File Offset: 0x0000FB9E
	protected internal unsafe IndexedBarrierName(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000DF8 RID: 3576
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1419(void* self);

	// Token: 0x06000DF9 RID: 3577 RVA: 0x00010BA8 File Offset: 0x0000FBA8
	[DisableExceptionHandling]
	~IndexedBarrierName()
	{
		IndexedBarrierName._EASharpBinding_1419(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000DFA RID: 3578
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1420(void* self, int val);

	// Token: 0x06000DFB RID: 3579
	[DllImport("<internal>")]
	private unsafe static extern int _EASharpBinding_1421(void* self);

	// Token: 0x170000FB RID: 251
	// (get) Token: 0x06000DFC RID: 3580 RVA: 0x00010BE4 File Offset: 0x0000FBE4
	// (set) Token: 0x06000DFD RID: 3581 RVA: 0x00010BF1 File Offset: 0x0000FBF1
	public int mIndex
	{
		get
		{
			return IndexedBarrierName._EASharpBinding_1421(this.mSelf);
		}
		set
		{
			IndexedBarrierName._EASharpBinding_1420(this.mSelf, value);
		}
	}
}

using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000EC RID: 236
[ExportOnlyCreate(true)]
public class GMapCurveRef : ExposedCommonBase
{
	// Token: 0x06000E16 RID: 3606 RVA: 0x00010D4C File Offset: 0x0000FD4C
	public unsafe static GMapCurveRef CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GMapCurveRef(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000E17 RID: 3607 RVA: 0x00010D6F File Offset: 0x0000FD6F
	public unsafe GMapCurveRef(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E18 RID: 3608 RVA: 0x00010D79 File Offset: 0x0000FD79
	protected internal GMapCurveRef(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000E19 RID: 3609 RVA: 0x00010D82 File Offset: 0x0000FD82
	protected internal unsafe GMapCurveRef(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E1A RID: 3610
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1430(void* self);

	// Token: 0x06000E1B RID: 3611 RVA: 0x00010D8C File Offset: 0x0000FD8C
	[DisableExceptionHandling]
	~GMapCurveRef()
	{
		GMapCurveRef._EASharpBinding_1430(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000E1C RID: 3612
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1431(void* self, ushort val);

	// Token: 0x06000E1D RID: 3613
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1432(void* self);

	// Token: 0x170000FF RID: 255
	// (get) Token: 0x06000E1E RID: 3614 RVA: 0x00010DC8 File Offset: 0x0000FDC8
	// (set) Token: 0x06000E1F RID: 3615 RVA: 0x00010DD5 File Offset: 0x0000FDD5
	public ushort mCurveIndex
	{
		get
		{
			return GMapCurveRef._EASharpBinding_1432(this.mSelf);
		}
		set
		{
			GMapCurveRef._EASharpBinding_1431(this.mSelf, value);
		}
	}

	// Token: 0x06000E20 RID: 3616
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1433(void* self, ushort val);

	// Token: 0x06000E21 RID: 3617
	[DllImport("<internal>")]
	private unsafe static extern ushort _EASharpBinding_1434(void* self);

	// Token: 0x17000100 RID: 256
	// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00010DE3 File Offset: 0x0000FDE3
	// (set) Token: 0x06000E23 RID: 3619 RVA: 0x00010DF0 File Offset: 0x0000FDF0
	public ushort mFlags
	{
		get
		{
			return GMapCurveRef._EASharpBinding_1434(this.mSelf);
		}
		set
		{
			GMapCurveRef._EASharpBinding_1433(this.mSelf, value);
		}
	}

	// Token: 0x020000ED RID: 237
	public enum Enum6
	{
		// Token: 0x0400019E RID: 414
		kFlag_Reversed = 1
	}
}

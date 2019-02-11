using System;
using System.Runtime.InteropServices;
using EASharp;

// Token: 0x020000EA RID: 234
[ExportOnlyCreate(true)]
public class GStringHash : ExposedCommonBase
{
	// Token: 0x06000DFE RID: 3582 RVA: 0x00010C00 File Offset: 0x0000FC00
	public unsafe static GStringHash CreateInitUnowned(void* self)
	{
		if (self != null)
		{
			return new GStringHash(default(ExposeTag_InitUnowned), self);
		}
		return null;
	}

	// Token: 0x06000DFF RID: 3583 RVA: 0x00010C23 File Offset: 0x0000FC23
	public unsafe GStringHash(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E00 RID: 3584 RVA: 0x00010C2D File Offset: 0x0000FC2D
	protected internal GStringHash(ExposeTag_NoInitOwned tag) : base(tag)
	{
	}

	// Token: 0x06000E01 RID: 3585 RVA: 0x00010C36 File Offset: 0x0000FC36
	protected internal unsafe GStringHash(ExposeTag_InitOwned tag, void* self) : base(tag, self)
	{
	}

	// Token: 0x06000E02 RID: 3586
	[DoesNotBlock]
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1422(void* self);

	// Token: 0x06000E03 RID: 3587 RVA: 0x00010C40 File Offset: 0x0000FC40
	[DisableExceptionHandling]
	~GStringHash()
	{
		GStringHash._EASharpBinding_1422(this.mSelf);
		this.mSelf = null;
	}

	// Token: 0x06000E04 RID: 3588
	[DllImport("<internal>")]
	private unsafe static extern void _EASharpBinding_1423(void* self, uint val);

	// Token: 0x06000E05 RID: 3589
	[DllImport("<internal>")]
	private unsafe static extern uint _EASharpBinding_1424(void* self);

	// Token: 0x170000FC RID: 252
	// (get) Token: 0x06000E06 RID: 3590 RVA: 0x00010C7C File Offset: 0x0000FC7C
	// (set) Token: 0x06000E07 RID: 3591 RVA: 0x00010C89 File Offset: 0x0000FC89
	public uint hash
	{
		get
		{
			return GStringHash._EASharpBinding_1424(this.mSelf);
		}
		set
		{
			GStringHash._EASharpBinding_1423(this.mSelf, value);
		}
	}
}

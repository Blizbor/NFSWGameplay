using System;
using System.IO;
using EASharp;
using GameCore.Interfaces;

namespace GameCore.Messages
{
	// Token: 0x02000263 RID: 611
	[Export]
	public class OnGearShift : Message, IPersonaMessage
	{
		// Token: 0x06001851 RID: 6225 RVA: 0x0002B447 File Offset: 0x0002A447
		public OnGearShift(long personaId, ShiftPotential shiftStatus, uint gear, float rpm)
		{
			this.personaId = personaId;
			this.shiftStatus = shiftStatus;
			this.gear = gear;
			this.rpm = rpm;
		}

		// Token: 0x06001852 RID: 6226 RVA: 0x0002B46C File Offset: 0x0002A46C
		public override void Serialize(BinaryWriter dest)
		{
			dest.Write(this.personaId);
			dest.Write((uint)this.shiftStatus);
			dest.Write(this.gear);
			dest.Write(this.rpm);
		}

		// Token: 0x06001853 RID: 6227 RVA: 0x0002B49E File Offset: 0x0002A49E
		public new static object Construct(BinaryReader source)
		{
			return new OnGearShift(source.ReadInt64(), (ShiftPotential)source.ReadUInt32(), source.ReadUInt32(), source.ReadSingle());
		}

		// Token: 0x17000229 RID: 553
		// (get) Token: 0x06001854 RID: 6228 RVA: 0x0002B4BD File Offset: 0x0002A4BD
		public override uint Kind
		{
			get
			{
				return OnGearShift.KindHash;
			}
		}

		// Token: 0x1700022A RID: 554
		// (get) Token: 0x06001855 RID: 6229 RVA: 0x0002B4C4 File Offset: 0x0002A4C4
		public long PersonaId
		{
			get
			{
				return this.personaId;
			}
		}

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x06001856 RID: 6230 RVA: 0x0002B4CC File Offset: 0x0002A4CC
		public ShiftPotential ShiftStatus
		{
			get
			{
				return this.shiftStatus;
			}
		}

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06001857 RID: 6231 RVA: 0x0002B4D4 File Offset: 0x0002A4D4
		public uint Gear
		{
			get
			{
				return this.gear;
			}
		}

		// Token: 0x1700022D RID: 557
		// (get) Token: 0x06001858 RID: 6232 RVA: 0x0002B4DC File Offset: 0x0002A4DC
		public float RPM
		{
			get
			{
				return this.rpm;
			}
		}

		// Token: 0x04000603 RID: 1539
		private static uint KindHash = Hash.Hash32("GameCore.Messages.OnGearShift");

		// Token: 0x04000604 RID: 1540
		private readonly long personaId;

		// Token: 0x04000605 RID: 1541
		private readonly ShiftPotential shiftStatus;

		// Token: 0x04000606 RID: 1542
		private readonly uint gear;

		// Token: 0x04000607 RID: 1543
		private readonly float rpm;
	}
}

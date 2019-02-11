using System;
using System.Collections.Generic;
using server_packet;
using xsd2cpp;

namespace Victory.DataLayer.Serialization.Event
{
	// Token: 0x020002D3 RID: 723
	public class EventDefinition : IRequestBody
	{
		// Token: 0x060020AB RID: 8363 RVA: 0x0004D8C4 File Offset: 0x0004C8C4
		public virtual string Serialize()
		{
			string result;
			XSD2CPP.Writer(this, out result);
			return result;
		}

		// Token: 0x040007D2 RID: 2002
		public int CarClassHash;

		// Token: 0x040007D3 RID: 2003
		public int Coins;

		// Token: 0x040007D4 RID: 2004
		public Vector3 EngagePoint;

		// Token: 0x040007D5 RID: 2005
		public int EventId;

		// Token: 0x040007D6 RID: 2006
		public int EventLocalization;

		// Token: 0x040007D7 RID: 2007
		public int EventModeDescriptionLocalization;

		// Token: 0x040007D8 RID: 2008
		public string EventModeIcon = "";

		// Token: 0x040007D9 RID: 2009
		public int EventModeId;

		// Token: 0x040007DA RID: 2010
		public int EventModeLocalization;

		// Token: 0x040007DB RID: 2011
		public bool IsEnabled;

		// Token: 0x040007DC RID: 2012
		public bool IsLocked;

		// Token: 0x040007DD RID: 2013
		public int Laps;

		// Token: 0x040007DE RID: 2014
		public float Length;

		// Token: 0x040007DF RID: 2015
		public int MaxClassRating;

		// Token: 0x040007E0 RID: 2016
		public int MaxEntrants;

		// Token: 0x040007E1 RID: 2017
		public int MaxLevel;

		// Token: 0x040007E2 RID: 2018
		public int MinClassRating;

		// Token: 0x040007E3 RID: 2019
		public int MinEntrants;

		// Token: 0x040007E4 RID: 2020
		public int MinLevel;

		// Token: 0x040007E5 RID: 2021
		public int RegionLocalization;

		// Token: 0x040007E6 RID: 2022
		public List<int> RewardModes;

		// Token: 0x040007E7 RID: 2023
		public float TimeLimit;

		// Token: 0x040007E8 RID: 2024
		public string TrackLayoutMap = "";

		// Token: 0x040007E9 RID: 2025
		public int TrackLocalization;
	}
}

using System;
using System.Text;

namespace EASharp
{
	// Token: 0x02000002 RID: 2
	public class InternalUtil
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00001050
		public unsafe static string ConvertFromCString(sbyte* str)
		{
			if (str == null)
			{
				return null;
			}
			return new string(str, 0, -1, Encoding.ASCII);
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002066 File Offset: 0x00001066
		public unsafe static string ConvertFromWCString(char* str)
		{
			if (str == null)
			{
				return null;
			}
			return new string(str);
		}
	}
}

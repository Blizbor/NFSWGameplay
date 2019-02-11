using System;
using System.Runtime.InteropServices;
using System.Text;
using EASharp;

namespace GameCore
{
	// Token: 0x02000060 RID: 96
	[ExportOnlyCreate(false)]
	public class Server : ExposedCommonBase
	{
		// Token: 0x06000456 RID: 1110 RVA: 0x000065D8 File Offset: 0x000055D8
		public unsafe static Server CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new Server(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x06000457 RID: 1111 RVA: 0x000065FB File Offset: 0x000055FB
		public unsafe Server(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x06000458 RID: 1112 RVA: 0x00006605 File Offset: 0x00005605
		protected internal Server(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x06000459 RID: 1113 RVA: 0x0000660E File Offset: 0x0000560E
		protected internal unsafe Server(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600045A RID: 1114
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_430();

		// Token: 0x0600045B RID: 1115 RVA: 0x00006618 File Offset: 0x00005618
		public static XmlString GetBaseUrl()
		{
			return new XmlString(default(ExposeTag_InitOwned), Server._EASharpBinding_430());
		}

		// Token: 0x0600045C RID: 1116
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_431();

		// Token: 0x0600045D RID: 1117 RVA: 0x0000663C File Offset: 0x0000563C
		public static XmlString GetBaseRawUrl()
		{
			return new XmlString(default(ExposeTag_InitOwned), Server._EASharpBinding_431());
		}

		// Token: 0x0600045E RID: 1118
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_432(sbyte* source);

		// Token: 0x0600045F RID: 1119 RVA: 0x00006660 File Offset: 0x00005660
		public unsafe static XmlString UrlEncode(string source)
		{
			int byteCount = Encoding.ASCII.GetByteCount(source);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(source, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return new XmlString(default(ExposeTag_InitOwned), Server._EASharpBinding_432((sbyte*)ptr));
			}
		}

		// Token: 0x06000460 RID: 1120
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_433(sbyte* restUri, object responseHandler);

		// Token: 0x06000461 RID: 1121 RVA: 0x000066D0 File Offset: 0x000056D0
		public unsafe static int SendGetRequest(string restUri, ResponseHandler responseHandler)
		{
			int byteCount = Encoding.ASCII.GetByteCount(restUri);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(restUri, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return Server._EASharpBinding_433((sbyte*)ptr, responseHandler);
			}
		}

		// Token: 0x06000462 RID: 1122
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_434(sbyte* restUri, object responseHandler);

		// Token: 0x06000463 RID: 1123 RVA: 0x00006730 File Offset: 0x00005730
		public unsafe static int SendDeleteRequest(string restUri, ResponseHandler responseHandler)
		{
			int byteCount = Encoding.ASCII.GetByteCount(restUri);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(restUri, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				return Server._EASharpBinding_434((sbyte*)ptr, responseHandler);
			}
		}

		// Token: 0x06000464 RID: 1124
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_435(sbyte* restUri, sbyte* body, object responseHandler);

		// Token: 0x06000465 RID: 1125 RVA: 0x00006790 File Offset: 0x00005790
		public unsafe static int SendPostRequest(string restUri, string body, ResponseHandler responseHandler)
		{
			int byteCount = Encoding.ASCII.GetByteCount(restUri);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(restUri, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				int byteCount2 = Encoding.ASCII.GetByteCount(body);
				byte[] array2 = new byte[byteCount2 + 1];
				Encoding.ASCII.GetBytes(body, 0, byteCount2, array2, 0);
				array2[byteCount2] = 0;
				fixed (byte* ptr2 = array2)
				{
					return Server._EASharpBinding_435((sbyte*)ptr, (sbyte*)ptr2, responseHandler);
				}
			}
		}

		// Token: 0x06000466 RID: 1126
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_436(sbyte* restUri, sbyte* body, object responseHandler);

		// Token: 0x06000467 RID: 1127 RVA: 0x00006840 File Offset: 0x00005840
		public unsafe static int SendPutRequest(string restUri, string body, ResponseHandler responseHandler)
		{
			int byteCount = Encoding.ASCII.GetByteCount(restUri);
			byte[] array = new byte[byteCount + 1];
			Encoding.ASCII.GetBytes(restUri, 0, byteCount, array, 0);
			array[byteCount] = 0;
			fixed (byte* ptr = array)
			{
				int byteCount2 = Encoding.ASCII.GetByteCount(body);
				byte[] array2 = new byte[byteCount2 + 1];
				Encoding.ASCII.GetBytes(body, 0, byteCount2, array2, 0);
				array2[byteCount2] = 0;
				fixed (byte* ptr2 = array2)
				{
					return Server._EASharpBinding_436((sbyte*)ptr, (sbyte*)ptr2, responseHandler);
				}
			}
		}
	}
}

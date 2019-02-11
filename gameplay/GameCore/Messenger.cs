using System;
using System.Collections.Generic;
using System.IO;

namespace GameCore
{
	// Token: 0x02000246 RID: 582
	public static class Messenger
	{
		// Token: 0x060017A0 RID: 6048 RVA: 0x00029FB8 File Offset: 0x00028FB8
		public static void Subscribe<T>(MessageHandler<T> messageHandler, uint port) where T : Message
		{
			uint key = Hash.Hash32(typeof(T).ToString());
			List<IPortHandler> list;
			if (Messenger.MessageHandlers.TryGetValue(key, out list))
			{
				using (List<IPortHandler>.Enumerator enumerator = list.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						IPortHandler portHandler = enumerator.Current;
						PortHandler<T> portHandler2 = (PortHandler<T>)portHandler;
						if (portHandler2.Port == port)
						{
							portHandler2.Handler += messageHandler;
							return;
						}
					}
					goto IL_78;
				}
			}
			list = new List<IPortHandler>();
			Messenger.MessageHandlers.Add(key, list);
			IL_78:
			PortHandler<T> portHandler3 = new PortHandler<T>(port);
			portHandler3.Handler += messageHandler;
			list.Add(portHandler3);
		}

		// Token: 0x060017A1 RID: 6049 RVA: 0x0002A064 File Offset: 0x00029064
		public static void Unsubscribe<T>(MessageHandler<T> messageHandler, uint port) where T : Message
		{
			uint key = Hash.Hash32(typeof(T).ToString());
			List<IPortHandler> list;
			if (Messenger.MessageHandlers.TryGetValue(key, out list))
			{
				foreach (IPortHandler portHandler in list)
				{
					PortHandler<T> portHandler2 = (PortHandler<T>)portHandler;
					if (portHandler2.Port == port)
					{
						portHandler2.Handler -= messageHandler;
						break;
					}
				}
			}
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x0002A0E8 File Offset: 0x000290E8
		public static void Flush()
		{
			while (Messenger.MessageQueue.Count != 0)
			{
				Messenger.Envelope envelope = Messenger.MessageQueue[0];
				Messenger.MessageQueue.RemoveAt(0);
				List<IPortHandler> list;
				if (Messenger.MessageHandlers.TryGetValue(envelope.Kind, out list))
				{
					foreach (IPortHandler portHandler in list)
					{
						if (portHandler.Port == envelope.Port)
						{
							portHandler.OnHandleMessage(envelope.Message);
						}
					}
				}
			}
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x0002A184 File Offset: 0x00029184
		internal static void Post(Message message, uint port)
		{
			Messenger.MessageQueue.Add(new Messenger.Envelope(message, port));
		}

		// Token: 0x060017A4 RID: 6052 RVA: 0x0002A198 File Offset: 0x00029198
		internal unsafe static void Synchronize(Message message, uint port)
		{
			MemoryStream memoryStream = new MemoryStream(Messenger.buffer);
			memoryStream.SetLength(0L);
			BinaryWriter binaryWriter = new BinaryWriter(memoryStream);
			binaryWriter.Write(port);
			binaryWriter.Write(message.Kind);
			message.Serialize(binaryWriter);
			fixed (byte* ptr = memoryStream.GetBuffer())
			{
				Net.SendGameplayMessage((void*)ptr, (uint)memoryStream.Length);
			}
		}

		// Token: 0x060017A5 RID: 6053 RVA: 0x0002A208 File Offset: 0x00029208
		public unsafe static void PostRemoteMessages()
		{
			for (;;)
			{
				uint num = 0u;
				try
				{
					fixed (byte* ptr = Messenger.buffer)
					{
						num = Net.RecvGameplayMessage((void*)ptr, (uint)Messenger.buffer.Length);
						if (num == 0u)
						{
							break;
						}
					}
				}
				finally
				{
					byte* ptr = null;
				}
				MemoryStream input = new MemoryStream(Messenger.buffer, 0, (int)num);
				BinaryReader binaryReader = new BinaryReader(input);
				uint port = binaryReader.ReadUInt32();
				uint typeHash = binaryReader.ReadUInt32();
				Message message = Activator.CreateInstance<Message>(typeHash, binaryReader);
				Messenger.Post(message, port);
			}
		}

		// Token: 0x040005BF RID: 1471
		private static byte[] buffer = new byte[1024];

		// Token: 0x040005C0 RID: 1472
		private static List<Messenger.Envelope> MessageQueue = new List<Messenger.Envelope>();

		// Token: 0x040005C1 RID: 1473
		private static Dictionary<uint, List<IPortHandler>> MessageHandlers = new Dictionary<uint, List<IPortHandler>>();

		// Token: 0x02000247 RID: 583
		internal class Envelope
		{
			// Token: 0x060017A7 RID: 6055 RVA: 0x0002A2C5 File Offset: 0x000292C5
			public Envelope(Message message, uint port)
			{
				this.message = message;
				this.port = port;
			}

			// Token: 0x170001F9 RID: 505
			// (get) Token: 0x060017A8 RID: 6056 RVA: 0x0002A2DB File Offset: 0x000292DB
			public Message Message
			{
				get
				{
					return this.message;
				}
			}

			// Token: 0x170001FA RID: 506
			// (get) Token: 0x060017A9 RID: 6057 RVA: 0x0002A2E3 File Offset: 0x000292E3
			public uint Kind
			{
				get
				{
					return this.message.Kind;
				}
			}

			// Token: 0x170001FB RID: 507
			// (get) Token: 0x060017AA RID: 6058 RVA: 0x0002A2F0 File Offset: 0x000292F0
			public uint Port
			{
				get
				{
					return this.port;
				}
			}

			// Token: 0x040005C2 RID: 1474
			private readonly Message message;

			// Token: 0x040005C3 RID: 1475
			private readonly uint port;
		}
	}
}

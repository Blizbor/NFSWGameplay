using System;
using System.Runtime.InteropServices;
using EASharp;
using Interop;
using Victory.DataLayer.Serialization.Event;

namespace GameCore
{
	// Token: 0x02000041 RID: 65
	[ExportOnlyCreate(false)]
	public class InternalLobby : ExposedCommonBase
	{
		// Token: 0x0600022A RID: 554 RVA: 0x000044C4 File Offset: 0x000034C4
		public unsafe static InternalLobby CreateInitUnowned(void* self)
		{
			if (self != null)
			{
				return new InternalLobby(default(ExposeTag_InitUnowned), self);
			}
			return null;
		}

		// Token: 0x0600022B RID: 555 RVA: 0x000044E7 File Offset: 0x000034E7
		public unsafe InternalLobby(ExposeTag_InitUnowned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600022C RID: 556 RVA: 0x000044F1 File Offset: 0x000034F1
		protected internal InternalLobby(ExposeTag_NoInitOwned tag) : base(tag)
		{
		}

		// Token: 0x0600022D RID: 557 RVA: 0x000044FA File Offset: 0x000034FA
		protected internal unsafe InternalLobby(ExposeTag_InitOwned tag, void* self) : base(tag, self)
		{
		}

		// Token: 0x0600022E RID: 558
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_213();

		// Token: 0x0600022F RID: 559 RVA: 0x00004504 File Offset: 0x00003504
		public InternalLobby() : base(default(ExposeTag_NoInitOwned))
		{
			this.mSelf = InternalLobby._EASharpBinding_213();
		}

		// Token: 0x06000230 RID: 560
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_214(void* _ThisPtr);

		// Token: 0x06000231 RID: 561 RVA: 0x0000452C File Offset: 0x0000352C
		~InternalLobby()
		{
			InternalLobby._EASharpBinding_214(this.mSelf);
			this.mSelf = null;
		}

		// Token: 0x06000232 RID: 562
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_215(void* _ThisPtr);

		// Token: 0x06000233 RID: 563 RVA: 0x00004568 File Offset: 0x00003568
		public virtual void Ready()
		{
			InternalLobby._EASharpBinding_215(this.mSelf);
		}

		// Token: 0x06000234 RID: 564
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_216(void* _ThisPtr);

		// Token: 0x06000235 RID: 565 RVA: 0x00004575 File Offset: 0x00003575
		public virtual void Cleanup()
		{
			InternalLobby._EASharpBinding_216(this.mSelf);
		}

		// Token: 0x06000236 RID: 566
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_217(void* _ThisPtr, uint eventId);

		// Token: 0x06000237 RID: 567 RVA: 0x00004582 File Offset: 0x00003582
		public virtual void CacheEventId(uint eventId)
		{
			InternalLobby._EASharpBinding_217(this.mSelf, eventId);
		}

		// Token: 0x06000238 RID: 568
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_218(void* _ThisPtr);

		// Token: 0x06000239 RID: 569 RVA: 0x00004590 File Offset: 0x00003590
		public virtual uint GetCacheEventId()
		{
			return InternalLobby._EASharpBinding_218(this.mSelf);
		}

		// Token: 0x0600023A RID: 570
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_219(void* _ThisPtr, uint eventId);

		// Token: 0x0600023B RID: 571 RVA: 0x000045AA File Offset: 0x000035AA
		public virtual void WarpTo(uint eventId)
		{
			InternalLobby._EASharpBinding_219(this.mSelf, eventId);
		}

		// Token: 0x0600023C RID: 572
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_220(void* _ThisPtr, void* frontend);

		// Token: 0x0600023D RID: 573 RVA: 0x000045B8 File Offset: 0x000035B8
		public unsafe virtual void RegisterFrontend(void* frontend)
		{
			InternalLobby._EASharpBinding_220(this.mSelf, frontend);
		}

		// Token: 0x0600023E RID: 574
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_221(void* _ThisPtr, uint eventId, int lobbyType);

		// Token: 0x0600023F RID: 575 RVA: 0x000045C8 File Offset: 0x000035C8
		public virtual bool EnterQueue(uint eventId, LobbyType lobbyType)
		{
			return InternalLobby._EASharpBinding_221(this.mSelf, eventId, (int)lobbyType);
		}

		// Token: 0x06000240 RID: 576
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_222(void* _ThisPtr);

		// Token: 0x06000241 RID: 577 RVA: 0x000045E4 File Offset: 0x000035E4
		public virtual bool LeaveQueue()
		{
			return InternalLobby._EASharpBinding_222(this.mSelf);
		}

		// Token: 0x06000242 RID: 578
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_223(void* _ThisPtr);

		// Token: 0x06000243 RID: 579 RVA: 0x00004600 File Offset: 0x00003600
		public virtual bool IsInQueue()
		{
			return InternalLobby._EASharpBinding_223(this.mSelf);
		}

		// Token: 0x06000244 RID: 580
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_224(void* _ThisPtr, long personaId);

		// Token: 0x06000245 RID: 581 RVA: 0x0000461C File Offset: 0x0000361C
		public virtual bool Invite(long personaId)
		{
			return InternalLobby._EASharpBinding_224(this.mSelf, personaId);
		}

		// Token: 0x06000246 RID: 582
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_225(void* _ThisPtr);

		// Token: 0x06000247 RID: 583 RVA: 0x00004638 File Offset: 0x00003638
		public virtual bool DeclineInvite()
		{
			return InternalLobby._EASharpBinding_225(this.mSelf);
		}

		// Token: 0x06000248 RID: 584
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_226(void* _ThisPtr);

		// Token: 0x06000249 RID: 585 RVA: 0x00004654 File Offset: 0x00003654
		public virtual bool EnterLobby()
		{
			return InternalLobby._EASharpBinding_226(this.mSelf);
		}

		// Token: 0x0600024A RID: 586
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_227(void* _ThisPtr);

		// Token: 0x0600024B RID: 587 RVA: 0x00004670 File Offset: 0x00003670
		public virtual bool LeaveLobby()
		{
			return InternalLobby._EASharpBinding_227(this.mSelf);
		}

		// Token: 0x0600024C RID: 588
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_228(void* _ThisPtr);

		// Token: 0x0600024D RID: 589 RVA: 0x0000468C File Offset: 0x0000368C
		public virtual bool AcceptInvite()
		{
			return InternalLobby._EASharpBinding_228(this.mSelf);
		}

		// Token: 0x0600024E RID: 590
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_229(void* _ThisPtr);

		// Token: 0x0600024F RID: 591 RVA: 0x000046A8 File Offset: 0x000036A8
		public virtual bool PlayNowSearching()
		{
			return InternalLobby._EASharpBinding_229(this.mSelf);
		}

		// Token: 0x06000250 RID: 592
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_230(void* _ThisPtr);

		// Token: 0x06000251 RID: 593 RVA: 0x000046C4 File Offset: 0x000036C4
		public virtual bool PlayNowFound()
		{
			return InternalLobby._EASharpBinding_230(this.mSelf);
		}

		// Token: 0x06000252 RID: 594
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_231(void* _ThisPtr);

		// Token: 0x06000253 RID: 595 RVA: 0x000046E0 File Offset: 0x000036E0
		public virtual long GetEventSessionId()
		{
			return InternalLobby._EASharpBinding_231(this.mSelf);
		}

		// Token: 0x06000254 RID: 596
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_232(void* _ThisPtr, long eventSessionId);

		// Token: 0x06000255 RID: 597 RVA: 0x000046FA File Offset: 0x000036FA
		public virtual void SetEventSessionId(long eventSessionId)
		{
			InternalLobby._EASharpBinding_232(this.mSelf, eventSessionId);
		}

		// Token: 0x06000256 RID: 598
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_233(void* _ThisPtr, long lobbyInviteId);

		// Token: 0x06000257 RID: 599 RVA: 0x00004708 File Offset: 0x00003708
		public virtual void SetLobbyInviteId(long lobbyInviteId)
		{
			InternalLobby._EASharpBinding_233(this.mSelf, lobbyInviteId);
		}

		// Token: 0x06000258 RID: 600
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_234(void* _ThisPtr, float timeoutInSeconds);

		// Token: 0x06000259 RID: 601 RVA: 0x00004716 File Offset: 0x00003716
		public virtual void SetEventTimeoutInSeconds(float timeoutInSeconds)
		{
			InternalLobby._EASharpBinding_234(this.mSelf, timeoutInSeconds);
		}

		// Token: 0x0600025A RID: 602
		[DllImport("<internal>")]
		private unsafe static extern float _EASharpBinding_235(void* _ThisPtr);

		// Token: 0x0600025B RID: 603 RVA: 0x00004724 File Offset: 0x00003724
		public virtual float GetEventTimeoutInSeconds()
		{
			return InternalLobby._EASharpBinding_235(this.mSelf);
		}

		// Token: 0x0600025C RID: 604
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_236(void* _ThisPtr, int exitPath);

		// Token: 0x0600025D RID: 605 RVA: 0x0000473E File Offset: 0x0000373E
		public virtual void SetExitPath(ExitPath exitPath)
		{
			InternalLobby._EASharpBinding_236(this.mSelf, (int)exitPath);
		}

		// Token: 0x0600025E RID: 606
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_237(void* _ThisPtr);

		// Token: 0x0600025F RID: 607 RVA: 0x0000474C File Offset: 0x0000374C
		public virtual ExitPath GetExitPath()
		{
			return (ExitPath)InternalLobby._EASharpBinding_237(this.mSelf);
		}

		// Token: 0x06000260 RID: 608
		[DllImport("<internal>")]
		private unsafe static extern uint _EASharpBinding_238(void* _ThisPtr);

		// Token: 0x06000261 RID: 609 RVA: 0x00004768 File Offset: 0x00003768
		public virtual uint PrivateEventId()
		{
			return InternalLobby._EASharpBinding_238(this.mSelf);
		}

		// Token: 0x06000262 RID: 610
		[DllImport("<internal>")]
		private unsafe static extern long _EASharpBinding_239(void* _ThisPtr);

		// Token: 0x06000263 RID: 611 RVA: 0x00004784 File Offset: 0x00003784
		public virtual long PrivateHostId()
		{
			return InternalLobby._EASharpBinding_239(this.mSelf);
		}

		// Token: 0x06000264 RID: 612
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_240(void* _ThisPtr);

		// Token: 0x06000265 RID: 613 RVA: 0x000047A0 File Offset: 0x000037A0
		public virtual LobbyType GetLobbyType()
		{
			return (LobbyType)InternalLobby._EASharpBinding_240(this.mSelf);
		}

		// Token: 0x06000266 RID: 614
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_241(void* _ThisPtr, int connectionSupport, void* eventGrid);

		// Token: 0x06000267 RID: 615 RVA: 0x000047BA File Offset: 0x000037BA
		public virtual void OrderEventGrid(ConnectionSupport connectionSupport, EventGridPacket eventGrid)
		{
			InternalLobby._EASharpBinding_241(this.mSelf, (int)connectionSupport, object.ReferenceEquals(eventGrid, null) ? null : eventGrid._GetRaw());
		}

		// Token: 0x06000268 RID: 616
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_242(void* _ThisPtr, long personaId);

		// Token: 0x06000269 RID: 617 RVA: 0x000047DB File Offset: 0x000037DB
		public virtual void AddInvited(long personaId)
		{
			InternalLobby._EASharpBinding_242(this.mSelf, personaId);
		}

		// Token: 0x0600026A RID: 618
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_243(void* _ThisPtr, long personaId);

		// Token: 0x0600026B RID: 619 RVA: 0x000047E9 File Offset: 0x000037E9
		public virtual void RemoveInvited(long personaId)
		{
			InternalLobby._EASharpBinding_243(this.mSelf, personaId);
		}

		// Token: 0x0600026C RID: 620
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_244(void* _ThisPtr, long personaId);

		// Token: 0x0600026D RID: 621 RVA: 0x000047F8 File Offset: 0x000037F8
		public virtual bool IsInvited(long personaId)
		{
			return InternalLobby._EASharpBinding_244(this.mSelf, personaId);
		}

		// Token: 0x0600026E RID: 622
		[DllImport("<internal>")]
		private unsafe static extern int _EASharpBinding_245(void* _ThisPtr);

		// Token: 0x0600026F RID: 623 RVA: 0x00004814 File Offset: 0x00003814
		public virtual int InviteCount()
		{
			return InternalLobby._EASharpBinding_245(this.mSelf);
		}

		// Token: 0x06000270 RID: 624
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_246(void* _ThisPtr);

		// Token: 0x06000271 RID: 625 RVA: 0x00004830 File Offset: 0x00003830
		public virtual bool IsInviteEnabled()
		{
			return InternalLobby._EASharpBinding_246(this.mSelf);
		}

		// Token: 0x06000272 RID: 626
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_247(void* _ThisPtr, void* lobbyPacket);

		// Token: 0x06000273 RID: 627 RVA: 0x0000484A File Offset: 0x0000384A
		public virtual void FillLobbyPacket(LobbyPacket lobbyPacket)
		{
			InternalLobby._EASharpBinding_247(this.mSelf, object.ReferenceEquals(lobbyPacket, null) ? null : lobbyPacket._GetRaw());
		}

		// Token: 0x06000274 RID: 628
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_248(void* _ThisPtr, void* time_span);

		// Token: 0x06000275 RID: 629 RVA: 0x0000486A File Offset: 0x0000386A
		public virtual void FillEventTimeout(Interop.TimeSpan time_span)
		{
			InternalLobby._EASharpBinding_248(this.mSelf, object.ReferenceEquals(time_span, null) ? null : time_span._GetRaw());
		}

		// Token: 0x06000276 RID: 630
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_249(void* _ThisPtr);

		// Token: 0x06000277 RID: 631 RVA: 0x0000488A File Offset: 0x0000388A
		public virtual void OnQuitEvent()
		{
			InternalLobby._EASharpBinding_249(this.mSelf);
		}

		// Token: 0x06000278 RID: 632
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_250(void* _ThisPtr);

		// Token: 0x06000279 RID: 633 RVA: 0x00004897 File Offset: 0x00003897
		public virtual void OnEventArbitrated()
		{
			InternalLobby._EASharpBinding_250(this.mSelf);
		}

		// Token: 0x0600027A RID: 634
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_251(void* _ThisPtr);

		// Token: 0x0600027B RID: 635 RVA: 0x000048A4 File Offset: 0x000038A4
		public virtual void OnEventCleanup()
		{
			InternalLobby._EASharpBinding_251(this.mSelf);
		}

		// Token: 0x0600027C RID: 636
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_252(void* _ThisPtr, uint eventId);

		// Token: 0x0600027D RID: 637 RVA: 0x000048B1 File Offset: 0x000038B1
		public virtual void OnConnectionsFinalized(uint eventId)
		{
			InternalLobby._EASharpBinding_252(this.mSelf, eventId);
		}

		// Token: 0x0600027E RID: 638
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_253(void* _ThisPtr);

		// Token: 0x0600027F RID: 639 RVA: 0x000048BF File Offset: 0x000038BF
		public virtual void OnConnectionsFailed()
		{
			InternalLobby._EASharpBinding_253(this.mSelf);
		}

		// Token: 0x06000280 RID: 640
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_254(void* _ThisPtr, float dT);

		// Token: 0x06000281 RID: 641 RVA: 0x000048CC File Offset: 0x000038CC
		public virtual bool IsStuck(float dT)
		{
			return InternalLobby._EASharpBinding_254(this.mSelf, dT);
		}

		// Token: 0x06000282 RID: 642
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_255(void* _ThisPtr, float dT);

		// Token: 0x06000283 RID: 643 RVA: 0x000048E7 File Offset: 0x000038E7
		public virtual void Tick(float dT)
		{
			InternalLobby._EASharpBinding_255(this.mSelf, dT);
		}

		// Token: 0x06000284 RID: 644
		[DllImport("<internal>")]
		private unsafe static extern void _EASharpBinding_256(void* _ThisPtr);

		// Token: 0x06000285 RID: 645 RVA: 0x000048F5 File Offset: 0x000038F5
		public virtual void Reset()
		{
			InternalLobby._EASharpBinding_256(this.mSelf);
		}

		// Token: 0x06000286 RID: 646
		[DllImport("<internal>")]
		private unsafe static extern bool _EASharpBinding_257(void* _ThisPtr);

		// Token: 0x06000287 RID: 647 RVA: 0x00004904 File Offset: 0x00003904
		public virtual bool CanIRaceAgain()
		{
			return InternalLobby._EASharpBinding_257(this.mSelf);
		}

		// Token: 0x06000288 RID: 648
		[DllImport("<internal>")]
		private unsafe static extern void* _EASharpBinding_258();

		// Token: 0x06000289 RID: 649 RVA: 0x00004920 File Offset: 0x00003920
		public static InternalLobby Get()
		{
			return InternalLobby.CreateInitUnowned(InternalLobby._EASharpBinding_258());
		}
	}
}

using System;
using GameCore;
using Victory.DataLayer.Serialization;
using Victory.DataLayer.Serialization.Social;
using Victory.Service.Objects;
using Victory.TransferObjects.DriverPersona;

namespace server_packet
{
	// Token: 0x02000341 RID: 833
	public static class MyBinding
	{
		// Token: 0x06002169 RID: 8553 RVA: 0x00050366 File Offset: 0x0004F366
		private static string Serialize()
		{
			return string.Empty;
		}

		// Token: 0x0600216A RID: 8554 RVA: 0x0005036D File Offset: 0x0004F36D
		private static string Serialize(IRequestBody requestBody)
		{
			return requestBody.Serialize();
		}

		// Token: 0x0600216B RID: 8555 RVA: 0x00050378 File Offset: 0x0004F378
		public static int AcceptInvite(ResponseHandler responseHandler, long lobbyInviteId)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/acceptinvite?lobbyInviteId={1}", Server.GetBaseRawUrl().GetString(), lobbyInviteId);
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x0600216C RID: 8556 RVA: 0x000503B0 File Offset: 0x0004F3B0
		public static int Achievements_LoadAll(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/achievements/loadall", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600216D RID: 8557 RVA: 0x000503DC File Offset: 0x0004F3DC
		public static int Achievements_RedeemReward(ResponseHandler responseHandler, int achievementRankId)
		{
			string restUri = string.Format("{0}/Engine.svc/achievements/redeemreward?achievementRankId={1}", Server.GetBaseRawUrl().GetString(), achievementRankId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600216E RID: 8558 RVA: 0x0005040C File Offset: 0x0004F40C
		public static int AddFriendRequest(ResponseHandler responseHandler, long personaId, string displayName, string reqMessage)
		{
			string restUri = string.Format("{0}/Engine.svc/addfriendrequest?personaId={1}&displayName={2}&reqMessage={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				Server.UrlEncode(displayName).GetString(),
				Server.UrlEncode(reqMessage).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600216F RID: 8559 RVA: 0x00050468 File Offset: 0x0004F468
		public static int Badges_Set(ResponseHandler responseHandler, BadgeBundle badgeBundle)
		{
			string restUri = string.Format("{0}/Engine.svc/badges/set", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(badgeBundle);
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002170 RID: 8560 RVA: 0x0005049C File Offset: 0x0004F49C
		public static int BlockPlayer(ResponseHandler responseHandler, long personaId, long otherPersonaId)
		{
			string restUri = string.Format("{0}/Engine.svc/blockplayer?personaId={1}&otherPersonaId={2}", Server.GetBaseRawUrl().GetString(), personaId, otherPersonaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002171 RID: 8561 RVA: 0x000504D4 File Offset: 0x0004F4D4
		public static int Catalog_GetCatalogVersion(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/catalog/catalogVersion", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002172 RID: 8562 RVA: 0x00050500 File Offset: 0x0004F500
		public static int Catalog_GetPersonalizedCategoriesInCategory(ResponseHandler responseHandler, long personaId, string categoryName, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/catalog/categories?personaId={1}&categoryName={2}&language={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				Server.UrlEncode(categoryName).GetString(),
				Server.UrlEncode(language).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0005055C File Offset: 0x0004F55C
		public static int Catalog_GetPersonalizedProductsWithClientProductType(ResponseHandler responseHandler, long personaId, string clientProductType, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/catalog/personalizedProducts?personaId={1}&clientProductType={2}&language={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				Server.UrlEncode(clientProductType).GetString(),
				Server.UrlEncode(language).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x000505B8 File Offset: 0x0004F5B8
		public static int Catalog_GetProductsInCategoryWithClientProductType(ResponseHandler responseHandler, long userId, string categoryName, string clientProductType, string currencyType, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/catalog/productsInCategory?userId={1}&categoryName={2}&clientProductType={3}&currencyType={4}&language={5}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				userId,
				Server.UrlEncode(categoryName).GetString(),
				Server.UrlEncode(clientProductType).GetString(),
				Server.UrlEncode(currencyType).GetString(),
				Server.UrlEncode(language).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x00050630 File Offset: 0x0004F630
		public static int Catalog_GetProductsWithClientProductType(ResponseHandler responseHandler, long userId, string clientProductType, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/catalog/products?userId={1}&clientProductType={2}&language={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				userId,
				Server.UrlEncode(clientProductType).GetString(),
				Server.UrlEncode(language).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0005068C File Offset: 0x0004F68C
		public static int DeclineInvite(ResponseHandler responseHandler, long lobbyInviteId)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/declineinvite?lobbyInviteId={1}", Server.GetBaseRawUrl().GetString(), lobbyInviteId);
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002177 RID: 8567 RVA: 0x000506C4 File Offset: 0x0004F6C4
		public static int DriverPersona_CreatePersona(ResponseHandler responseHandler, long userId, string name, int iconIndex, string clan, string clanIcon)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/CreatePersona?userId={1}&name={2}&iconIndex={3}&clan={4}&clanIcon={5}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				userId,
				Server.UrlEncode(name).GetString(),
				iconIndex,
				Server.UrlEncode(clan).GetString(),
				Server.UrlEncode(clanIcon).GetString()
			});
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x00050740 File Offset: 0x0004F740
		public static int DriverPersona_DeletePersona(ResponseHandler responseHandler, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/DeletePersona?personaId={1}", Server.GetBaseRawUrl().GetString(), personaId);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x00050778 File Offset: 0x0004F778
		public static int DriverPersona_GetExpLevelPointsMap(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/GetExpLevelPointsMap", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000507A4 File Offset: 0x0004F7A4
		public static int DriverPersona_GetPersonaBaseFromList(ResponseHandler responseHandler, PersonaIdArray personaIds)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/GetPersonaBaseFromList", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(personaIds);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000507D8 File Offset: 0x0004F7D8
		public static int DriverPersona_GetPersonaInfo(ResponseHandler responseHandler, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/GetPersonaInfo?personaId={1}", Server.GetBaseRawUrl().GetString(), personaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00050808 File Offset: 0x0004F808
		public static int DriverPersona_GetPersonaPresenceByName(ResponseHandler responseHandler, string displayName)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/GetPersonaPresenceByName?displayName={1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(displayName).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x0005083C File Offset: 0x0004F83C
		public static int DriverPersona_ReserveName(ResponseHandler responseHandler, long userId, string name)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/ReserveName?userId={1}&name={2}", Server.GetBaseRawUrl().GetString(), userId, Server.UrlEncode(name).GetString());
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00050880 File Offset: 0x0004F880
		public static int DriverPersona_UnreserveName(ResponseHandler responseHandler, long userId)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/UnreserveName?userId={1}", Server.GetBaseRawUrl().GetString(), userId);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x000508B8 File Offset: 0x0004F8B8
		public static int DriverPersona_UpdatePersonaPresence(ResponseHandler responseHandler, long personaId, int presence)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/UpdatePersonaPresence?personaId={1}&presence={2}", Server.GetBaseRawUrl().GetString(), personaId, presence);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x000508F4 File Offset: 0x0004F8F4
		public static int DriverPersona_UpdateStatusMessage(ResponseHandler responseHandler, PersonaMotto motto)
		{
			string restUri = string.Format("{0}/Engine.svc/DriverPersona/UpdateStatusMessage", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(motto);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002181 RID: 8577 RVA: 0x00050928 File Offset: 0x0004F928
		public static int Event_Abort(ResponseHandler responseHandler, long eventSessionId, ArbitrationPacket arbitrationRecord)
		{
			string restUri = string.Format("{0}/Engine.svc/event/abort?eventSessionId={1}", Server.GetBaseRawUrl().GetString(), eventSessionId);
			string body = MyBinding.Serialize(arbitrationRecord);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00050960 File Offset: 0x0004F960
		public static int Event_Arbitration(ResponseHandler responseHandler, long eventSessionId, ArbitrationPacket arbitrationRecord)
		{
			string restUri = string.Format("{0}/Engine.svc/event/arbitration?eventSessionId={1}", Server.GetBaseRawUrl().GetString(), eventSessionId);
			string body = MyBinding.Serialize(arbitrationRecord);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00050998 File Offset: 0x0004F998
		public static int Event_Busted(ResponseHandler responseHandler, long eventSessionId, ArbitrationPacket arbitrationRecord)
		{
			string restUri = string.Format("{0}/Engine.svc/event/bust?eventSessionId={1}", Server.GetBaseRawUrl().GetString(), eventSessionId);
			string body = MyBinding.Serialize(arbitrationRecord);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x000509D0 File Offset: 0x0004F9D0
		public static int Event_FetchAccolades(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/events/accolades", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x000509FC File Offset: 0x0004F9FC
		public static int Event_FetchInstancedAccolades(ResponseHandler responseHandler, long eventSessionId)
		{
			string restUri = string.Format("{0}/Engine.svc/events/instancedaccolades?eventSessionId={1}", Server.GetBaseRawUrl().GetString(), eventSessionId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x00050A2C File Offset: 0x0004FA2C
		public static int Event_GetEventsAvailableAtLevel(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/events/availableatlevel", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x00050A58 File Offset: 0x0004FA58
		public static int Event_GetTreasureHuntEventSession(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/events/gettreasurehunteventsession", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x00050A84 File Offset: 0x0004FA84
		public static int Event_Launched(ResponseHandler responseHandler, long eventSessionId)
		{
			string restUri = string.Format("{0}/Engine.svc/event/launched?eventSessionId={1}", Server.GetBaseRawUrl().GetString(), eventSessionId);
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002189 RID: 8585 RVA: 0x00050ABC File Offset: 0x0004FABC
		public static int Event_NotifyTreasureHuntCoinCollected(ResponseHandler responseHandler, uint coinsCollected)
		{
			string restUri = string.Format("{0}/Engine.svc/events/notifycoincollected?coins={1}", Server.GetBaseRawUrl().GetString(), coinsCollected);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x00050AEC File Offset: 0x0004FAEC
		public static int GenerateWebToken(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/security/generateWebToken", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x00050B1C File Offset: 0x0004FB1C
		public static int GetAllPowerUpItemsForPersona(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/powerups", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600218C RID: 8588 RVA: 0x00050B48 File Offset: 0x0004FB48
		public static int GetBlockedUsersList(ResponseHandler responseHandler, long userId)
		{
			string restUri = string.Format("{0}/Engine.svc/getblockeduserlist?userId={1}", Server.GetBaseRawUrl().GetString(), userId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x00050B78 File Offset: 0x0004FB78
		public static int GetBlockersByUsers(ResponseHandler responseHandler, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/getblockersbyusers?personaId={1}", Server.GetBaseRawUrl().GetString(), personaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x00050BA8 File Offset: 0x0004FBA8
		public static int GetCarClasses(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/carclasses", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x00050BD4 File Offset: 0x0004FBD4
		public static int GetCarOwnedByPersona(ResponseHandler responseHandler, string personaId, string ownedcarId)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/cars/{2}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString(), Server.UrlEncode(ownedcarId).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x00050C14 File Offset: 0x0004FC14
		public static int GetCarSlotInfoForPersona(ResponseHandler responseHandler, string personaId, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/carslots?language={2}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString(), Server.UrlEncode(language).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x00050C54 File Offset: 0x0004FC54
		public static int GetCarsOwnedByPersona(ResponseHandler responseHandler, string personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/cars", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x00050C88 File Offset: 0x0004FC88
		public static int GetClientServerCryptoTicket(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/crypto/cryptoticket", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x00050CB4 File Offset: 0x0004FCB4
		public static int GetDefaultCarForPersona(ResponseHandler responseHandler, string personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/defaultcar", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002194 RID: 8596 RVA: 0x00050CE8 File Offset: 0x0004FCE8
		public static int GetDefaultCarForPersonas(ResponseHandler responseHandler, PersonaIdArray personaIds)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/defaultcars", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(personaIds);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x06002195 RID: 8597 RVA: 0x00050D1C File Offset: 0x0004FD1C
		public static int GetFraudConfig(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/security/fraudConfig", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002196 RID: 8598 RVA: 0x00050D48 File Offset: 0x0004FD48
		public static int GetFriendsListFromUserId(ResponseHandler responseHandler, long userId)
		{
			string restUri = string.Format("{0}/Engine.svc/getfriendlistfromuserid?userId={1}", Server.GetBaseRawUrl().GetString(), userId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002197 RID: 8599 RVA: 0x00050D78 File Offset: 0x0004FD78
		public static int GetMyDefaultCar(ResponseHandler responseHandler, string personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/mydefaultcar", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002198 RID: 8600 RVA: 0x00050DAC File Offset: 0x0004FDAC
		public static int GetPerformanceUpgradesForBaseCar(ResponseHandler responseHandler, string baseCarHash, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/performanceUpgrades/{1}?language={2}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(baseCarHash).GetString(), Server.UrlEncode(language).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x06002199 RID: 8601 RVA: 0x00050DEC File Offset: 0x0004FDEC
		public static int GetPersonaIdsFromUserIds(ResponseHandler responseHandler, UserIdArray userIds)
		{
			string restUri = string.Format("{0}/Engine.svc/getpersonaidsfromuserids", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(userIds);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x0600219A RID: 8602 RVA: 0x00050E20 File Offset: 0x0004FE20
		public static int GetRebroadcasters(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/getrebroadcasters", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600219B RID: 8603 RVA: 0x00050E4C File Offset: 0x0004FE4C
		public static int GetRegionInfo(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/getregioninfo", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600219C RID: 8604 RVA: 0x00050E78 File Offset: 0x0004FE78
		public static int GetServerTime(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/servertime", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600219D RID: 8605 RVA: 0x00050EA4 File Offset: 0x0004FEA4
		public static int GetShardInfo(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/getshardinfo", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600219E RID: 8606 RVA: 0x00050ED0 File Offset: 0x0004FED0
		public static int GetSocialNetworkInfo(ResponseHandler responseHandler, long userId)
		{
			string restUri = string.Format("{0}/Engine.svc/getsocialnetworkinfo?userId={1}", Server.GetBaseRawUrl().GetString(), userId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x0600219F RID: 8607 RVA: 0x00050F00 File Offset: 0x0004FF00
		public static int GetSocialSettings(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/getsocialsettings", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021A0 RID: 8608 RVA: 0x00050F2C File Offset: 0x0004FF2C
		public static int GetUdpRelayCryptoTicket(ResponseHandler responseHandler, string strPersonaId)
		{
			string restUri = string.Format("{0}/Engine.svc/crypto/relaycryptoticket/{1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strPersonaId).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021A1 RID: 8609 RVA: 0x00050F60 File Offset: 0x0004FF60
		public static int GetUserSettings(ResponseHandler responseHandler, long userId)
		{
			string restUri = string.Format("{0}/Engine.svc/getusersettings?userId={1}", Server.GetBaseRawUrl().GetString(), userId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021A2 RID: 8610 RVA: 0x00050F90 File Offset: 0x0004FF90
		public static int Gifts_GetAndTriggerAvailableLevelGifts(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/Gifts/GetAndTriggerAvailableLevelGifts", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021A3 RID: 8611 RVA: 0x00050FC0 File Offset: 0x0004FFC0
		public static int Heartbeat(ResponseHandler responseHandler, Report report)
		{
			string restUri = string.Format("{0}/Engine.svc/heartbeat", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(report);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021A4 RID: 8612 RVA: 0x00050FF4 File Offset: 0x0004FFF4
		public static int HeartbeatLauncher(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/heartbeatLauncher", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021A5 RID: 8613 RVA: 0x00051024 File Offset: 0x00050024
		public static int Inventory_GetPersonaInventoryObject(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/inventory/objects", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021A6 RID: 8614 RVA: 0x00051050 File Offset: 0x00050050
		public static int Inventory_SellPersonaEntitlementList(ResponseHandler responseHandler, EntitlementTrans entitlements)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/inventory/sell/entitlements", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(entitlements);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021A7 RID: 8615 RVA: 0x00051084 File Offset: 0x00050084
		public static int Inventory_SellPersonaEntitlementTag(ResponseHandler responseHandler, string strEntitlementTag)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/inventory/sell/{1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strEntitlementTag).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021A8 RID: 8616 RVA: 0x000510B8 File Offset: 0x000500B8
		public static int InviteToPrivateLobby(ResponseHandler responseHandler, long invitePersonaId)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/invitetoprivatelobby?invitePersonaId={1}", Server.GetBaseRawUrl().GetString(), invitePersonaId);
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021A9 RID: 8617 RVA: 0x000510F0 File Offset: 0x000500F0
		public static int JoinQueueEvent(ResponseHandler responseHandler, string strEventId)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/joinqueueevent/{1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strEventId).GetString());
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021AA RID: 8618 RVA: 0x0005112C File Offset: 0x0005012C
		public static int JoinQueueRaceNow(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/joinqueueracenow", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021AB RID: 8619 RVA: 0x0005115C File Offset: 0x0005015C
		public static int LauncherInfo(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/launcherinfo", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021AC RID: 8620 RVA: 0x00051188 File Offset: 0x00050188
		public static int LaunchEvent(ResponseHandler responseHandler, string strEventId)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/launchevent/{1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strEventId).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021AD RID: 8621 RVA: 0x000511BC File Offset: 0x000501BC
		public static int LeaveLobby(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/leavelobby", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021AE RID: 8622 RVA: 0x000511EC File Offset: 0x000501EC
		public static int LeaveQueue(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/leavequeue", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021AF RID: 8623 RVA: 0x0005121C File Offset: 0x0005021C
		public static int LogFraudDetectionEvents(ResponseHandler responseHandler, FraudDetectionCollection fraudDetectionObjectCollection)
		{
			string restUri = string.Format("{0}/Engine.svc/security/logFraudDetectionEvents", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(fraudDetectionObjectCollection);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021B0 RID: 8624 RVA: 0x00051250 File Offset: 0x00050250
		public static int LoginAnnouncements_GetImagesPath(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/LoginAnnouncements/ImagesPath", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021B1 RID: 8625 RVA: 0x0005127C File Offset: 0x0005027C
		public static int LoginAnnouncements_GetLoginAnnouncements(ResponseHandler responseHandler, string language)
		{
			string restUri = string.Format("{0}/Engine.svc/LoginAnnouncements?language={1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(language).GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021B2 RID: 8626 RVA: 0x000512B0 File Offset: 0x000502B0
		public static int MakePrivateLobby(ResponseHandler responseHandler, string strEventId)
		{
			string restUri = string.Format("{0}/Engine.svc/matchmaking/makeprivatelobby/{1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strEventId).GetString());
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021B3 RID: 8627 RVA: 0x000512EC File Offset: 0x000502EC
		public static int News_TriggerCarRentalExpired(ResponseHandler responseHandler, long personaId, int hashId)
		{
			string restUri = string.Format("{0}/Engine.svc/News/TriggerCarRentalExpired?personaId={1}&hash={2}", Server.GetBaseRawUrl().GetString(), personaId, hashId);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021B4 RID: 8628 RVA: 0x00051328 File Offset: 0x00050328
		public static int PetitionRequest(ResponseHandler responseHandler, long personaId, long abuserPersonaId, int petitionType, string description, int chatMinutes, int customCarID)
		{
			string restUri = string.Format("{0}/Engine.svc/Social/petition?personaId={1}&abuserPersonaId={2}&petitionType={3}&description={4}&chatMinutes={5}&customCarID={6}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				abuserPersonaId,
				petitionType,
				Server.UrlEncode(description).GetString(),
				chatMinutes,
				customCarID
			});
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021B5 RID: 8629 RVA: 0x000513A4 File Offset: 0x000503A4
		public static int PowerUpActivated(ResponseHandler responseHandler, string powerupKey, long targetId, string receivers, long eventSessionId)
		{
			string restUri = string.Format("{0}/Engine.svc/powerups/activated/{1}?targetId={2}&receivers={3}&eventSessionId={4}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				Server.UrlEncode(powerupKey).GetString(),
				targetId,
				Server.UrlEncode(receivers).GetString(),
				eventSessionId
			});
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x00051410 File Offset: 0x00050410
		public static int ReapplyProgressionAmplifiers(ResponseHandler responseHandler, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/ProgressionAmplifiers/Reapply?personaId={1}", Server.GetBaseRawUrl().GetString(), personaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x00051440 File Offset: 0x00050440
		public static int RemoveFriend(ResponseHandler responseHandler, long personaId, long friendPersonaId)
		{
			string restUri = string.Format("{0}/Engine.svc/removefriend?personaId={1}&friendPersonaId={2}", Server.GetBaseRawUrl().GetString(), personaId, friendPersonaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x00051478 File Offset: 0x00050478
		public static int RepairDefaultOwnedCar(ResponseHandler responseHandler, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/car/repair?personaId={1}", Server.GetBaseRawUrl().GetString(), personaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x000514A8 File Offset: 0x000504A8
		public static int Reporting_LauncherPatcherEnd(ResponseHandler responseHandler, LauncherEndTrans endObject)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/LauncherPatcherEnd/", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(endObject);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x000514DC File Offset: 0x000504DC
		public static int Reporting_LauncherPatcherStart(ResponseHandler responseHandler, LauncherStartTrans startObject)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/LauncherPatcherStart/", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(startObject);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x00051510 File Offset: 0x00050510
		public static int Reporting_LoginAnnouncementClicked(ResponseHandler responseHandler, long userId, int announcementId)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/LoginAnnouncementClicked?userId={1}&announcementId={2}", Server.GetBaseRawUrl().GetString(), userId, announcementId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x00051548 File Offset: 0x00050548
		public static int Reporting_SendClientPingTime(ResponseHandler responseHandler, long personaId, int pingTime, string UDPR_IP)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/SendClientPingTime?personaId={1}&pingTime={2}&udpr_ip={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				pingTime,
				Server.UrlEncode(UDPR_IP).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0005159C File Offset: 0x0005059C
		public static int Reporting_SendHardwareInfo(ResponseHandler responseHandler, HardwareInfo hardwareInfo)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/SendHardwareInfo", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(hardwareInfo);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021BE RID: 8638 RVA: 0x000515D0 File Offset: 0x000505D0
		public static int Reporting_SendMachineIndetification(ResponseHandler responseHandler, MachineIdentification machineIndetification)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/SendExtraHardwareInfo", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(machineIndetification);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x00051604 File Offset: 0x00050604
		public static int Reporting_SendMultiplayerConnect(ResponseHandler responseHandler, long personaId, int netErrorCode, uint duration)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/SendMultiplayerConnect?personaId={1}&netErrorCode={2}&duration={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				netErrorCode,
				duration
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x00051654 File Offset: 0x00050654
		public static int Reporting_SendUserSettings(ResponseHandler responseHandler, UserSettings userSettings)
		{
			string restUri = string.Format("{0}/Engine.svc/Reporting/SendUserSettings", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(userSettings);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021C1 RID: 8641 RVA: 0x00051688 File Offset: 0x00050688
		public static int ReportStoreFailure(ResponseHandler responseHandler, string errorMessage)
		{
			string restUri = string.Format("{0}/Engine.svc/commerce/reportStoreFailure?errorMessage={1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(errorMessage).GetString());
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021C2 RID: 8642 RVA: 0x000516C4 File Offset: 0x000506C4
		public static int RequestArticles(ResponseHandler responseHandler, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/NewsArticles?personaId={1}", Server.GetBaseRawUrl().GetString(), personaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021C3 RID: 8643 RVA: 0x000516F4 File Offset: 0x000506F4
		public static int ResolveFriendRequest(ResponseHandler responseHandler, long personaId, long friendPersonaId, int resolution)
		{
			string restUri = string.Format("{0}/Engine.svc/resolvefriendsrequest?personaId={1}&friendPersonaId={2}&resolution={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				personaId,
				friendPersonaId,
				resolution
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x00051744 File Offset: 0x00050744
		public static int SellCar(ResponseHandler responseHandler, string personaId, string ownedcarId)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/cars?serialNumber={2}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString(), Server.UrlEncode(ownedcarId).GetString());
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021C5 RID: 8645 RVA: 0x0005178C File Offset: 0x0005078C
		public static int Session_GetChatInfo(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/Session/GetChatInfo", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021C6 RID: 8646 RVA: 0x000517B8 File Offset: 0x000507B8
		public static int SetDefaultCarForPersona(ResponseHandler responseHandler, string personaId, string ownedcarId)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/defaultcar/{2}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString(), Server.UrlEncode(ownedcarId).GetString());
			string body = MyBinding.Serialize();
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x00051800 File Offset: 0x00050800
		public static int SetSocialSettings(ResponseHandler responseHandler, SocialSettings settings)
		{
			string restUri = string.Format("{0}/Engine.svc/setsocialsettings", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(settings);
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021C8 RID: 8648 RVA: 0x00051834 File Offset: 0x00050834
		public static int SetUserSettings(ResponseHandler responseHandler, User_Settings settings)
		{
			string restUri = string.Format("{0}/Engine.svc/setusersettings", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(settings);
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021C9 RID: 8649 RVA: 0x00051868 File Offset: 0x00050868
		public static int SubmitCommerceSession(ResponseHandler responseHandler, string strPersonaId, CommerceSessionTrans Commerce)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/commerce", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strPersonaId).GetString());
			string body = MyBinding.Serialize(Commerce);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021CA RID: 8650 RVA: 0x000518A4 File Offset: 0x000508A4
		public static int SubmitNewBasket(ResponseHandler responseHandler, string strPersonaId, BasketTrans basket)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/baskets", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(strPersonaId).GetString());
			string body = MyBinding.Serialize(basket);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021CB RID: 8651 RVA: 0x000518E0 File Offset: 0x000508E0
		public static int SystemDescription(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/description", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021CC RID: 8652 RVA: 0x0005190C File Offset: 0x0005090C
		public static int SystemInfo(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/systeminfo", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021CD RID: 8653 RVA: 0x00051938 File Offset: 0x00050938
		public static int UnblockPlayer(ResponseHandler responseHandler, long personaId, long otherPersonaId)
		{
			string restUri = string.Format("{0}/Engine.svc/unblockplayer?personaId={1}&otherPersonaId={2}", Server.GetBaseRawUrl().GetString(), personaId, otherPersonaId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021CE RID: 8654 RVA: 0x00051970 File Offset: 0x00050970
		public static int UpdateCar(ResponseHandler responseHandler, string personaId, OwnedCarTrans car)
		{
			string restUri = string.Format("{0}/Engine.svc/personas/{1}/cars", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(personaId).GetString());
			string body = MyBinding.Serialize(car);
			return Server.SendPutRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021CF RID: 8655 RVA: 0x000519AC File Offset: 0x000509AC
		public static int User_AuthenticateUser(ResponseHandler responseHandler, Credentials credentials)
		{
			string restUri = string.Format("{0}/Engine.svc/User/AuthenticateUser2", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(credentials);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D0 RID: 8656 RVA: 0x000519E0 File Offset: 0x000509E0
		public static int User_AuthenticateUserByToken(ResponseHandler responseHandler, Token token)
		{
			string restUri = string.Format("{0}/Engine.svc/User/AuthenticateUserByToken", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(token);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D1 RID: 8657 RVA: 0x00051A14 File Offset: 0x00050A14
		public static int User_ClientConfig(ResponseHandler responseHandler)
		{
			string restUri = string.Format("{0}/Engine.svc/logging/client", Server.GetBaseRawUrl().GetString());
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x00051A40 File Offset: 0x00050A40
		public static int User_GetPermanentSession(ResponseHandler responseHandler, GetPermanentSessionData data)
		{
			string restUri = string.Format("{0}/Engine.svc/User/GetPermanentSession", Server.GetBaseRawUrl().GetString());
			string body = MyBinding.Serialize(data);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x00051A74 File Offset: 0x00050A74
		public static int User_GetUserInfoFromSecurityToken(ResponseHandler responseHandler, long userId)
		{
			string restUri = string.Format("{0}/Engine.svc/User/GetUserInfoFromSecurityToken?userId={1}", Server.GetBaseRawUrl().GetString(), userId);
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021D4 RID: 8660 RVA: 0x00051AA4 File Offset: 0x00050AA4
		public static int User_Logging(ResponseHandler responseHandler, string group, ClientLog log)
		{
			string restUri = string.Format("{0}/Engine.svc/logging/client/{1}", Server.GetBaseRawUrl().GetString(), Server.UrlEncode(group).GetString());
			string body = MyBinding.Serialize(log);
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D5 RID: 8661 RVA: 0x00051AE0 File Offset: 0x00050AE0
		public static int User_SecureLogin(ResponseHandler responseHandler, string authKey, string localIp, string localPort, string publicIp, string publicPort, string natBehavior, string natIncrement, string natType)
		{
			string restUri = string.Format("{0}/Engine.svc/User/SecureLogin?authKey={1}&localIp={2}&localPort={3}&publicIp={4}&publicPort={5}&natBehavior={6}&natIncrement={7}&natType={8}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				Server.UrlEncode(authKey).GetString(),
				Server.UrlEncode(localIp).GetString(),
				Server.UrlEncode(localPort).GetString(),
				Server.UrlEncode(publicIp).GetString(),
				Server.UrlEncode(publicPort).GetString(),
				Server.UrlEncode(natBehavior).GetString(),
				Server.UrlEncode(natIncrement).GetString(),
				Server.UrlEncode(natType).GetString()
			});
			return Server.SendGetRequest(restUri, responseHandler);
		}

		// Token: 0x060021D6 RID: 8662 RVA: 0x00051B8C File Offset: 0x00050B8C
		public static int User_SecureLoginPersona(ResponseHandler responseHandler, long userId, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/User/SecureLoginPersona?userId={1}&personaId={2}", Server.GetBaseRawUrl().GetString(), userId, personaId);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D7 RID: 8663 RVA: 0x00051BC8 File Offset: 0x00050BC8
		public static int User_SecureLogout(ResponseHandler responseHandler, long userId, long personaId, int exitCode)
		{
			string restUri = string.Format("{0}/Engine.svc/User/SecureLogout?userId={1}&personaId={2}&exitCode={3}", new object[]
			{
				Server.GetBaseRawUrl().GetString(),
				userId,
				personaId,
				exitCode
			});
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D8 RID: 8664 RVA: 0x00051C20 File Offset: 0x00050C20
		public static int User_SecureLogoutPersona(ResponseHandler responseHandler, long userId, long personaId)
		{
			string restUri = string.Format("{0}/Engine.svc/User/SecureLogoutPersona?userId={1}&personaId={2}", Server.GetBaseRawUrl().GetString(), userId, personaId);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}

		// Token: 0x060021D9 RID: 8665 RVA: 0x00051C5C File Offset: 0x00050C5C
		public static int User_SetRegion(ResponseHandler responseHandler, long userId, int regionId)
		{
			string restUri = string.Format("{0}/Engine.svc/User/SetRegion?userId={1}&regionId={2}", Server.GetBaseRawUrl().GetString(), userId, regionId);
			string body = MyBinding.Serialize();
			return Server.SendPostRequest(restUri, body, responseHandler);
		}
	}
}

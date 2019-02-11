using System;
using System.Collections.Generic;

namespace Victory
{
	// Token: 0x02000340 RID: 832
	public static class EngineErrorCodeConverter
	{
		// Token: 0x06002167 RID: 8551 RVA: 0x0004F46C File Offset: 0x0004E46C
		static EngineErrorCodeConverter()
		{
			EngineErrorCodeConverter.typeMap["Undefined"] = EngineErrorCode.Undefined;
			EngineErrorCodeConverter.typeMap["Unknown"] = EngineErrorCode.Unknown;
			EngineErrorCodeConverter.typeMap["MissingMethodInputData"] = EngineErrorCode.MissingMethodInputData;
			EngineErrorCodeConverter.typeMap["ValuesAreNotEqual"] = EngineErrorCode.ValuesAreNotEqual;
			EngineErrorCodeConverter.typeMap["ArgumentNullOrEmpty"] = EngineErrorCode.ArgumentNullOrEmpty;
			EngineErrorCodeConverter.typeMap["XmlDeserializationError"] = EngineErrorCode.XmlDeserializationError;
			EngineErrorCodeConverter.typeMap["UnknownRemoteAccountManagementError"] = EngineErrorCode.UnknownRemoteAccountManagementError;
			EngineErrorCodeConverter.typeMap["ValuesAreEqual"] = EngineErrorCode.ValuesAreEqual;
			EngineErrorCodeConverter.typeMap["InvalidOperation"] = EngineErrorCode.InvalidOperation;
			EngineErrorCodeConverter.typeMap["LeftIsGreaterThanRight"] = EngineErrorCode.LeftIsGreaterThanRight;
			EngineErrorCodeConverter.typeMap["LeftIsLessThanRight"] = EngineErrorCode.LeftIsLessThanRight;
			EngineErrorCodeConverter.typeMap["ChatConnectionError"] = EngineErrorCode.ChatConnectionError;
			EngineErrorCodeConverter.typeMap["GameServerRegionDoesntExist"] = EngineErrorCode.GameServerRegionDoesntExist;
			EngineErrorCodeConverter.typeMap["ServerConfigDoesntExist"] = EngineErrorCode.ServerConfigDoesntExist;
			EngineErrorCodeConverter.typeMap["CustomCarDoesntExist"] = EngineErrorCode.CustomCarDoesntExist;
			EngineErrorCodeConverter.typeMap["CarNotOwnedByDriver"] = EngineErrorCode.CarNotOwnedByDriver;
			EngineErrorCodeConverter.typeMap["CarIsntPresetCar"] = EngineErrorCode.CarIsntPresetCar;
			EngineErrorCodeConverter.typeMap["CarIsntCustomCar"] = EngineErrorCode.CarIsntCustomCar;
			EngineErrorCodeConverter.typeMap["CarDataInvalid"] = EngineErrorCode.CarDataInvalid;
			EngineErrorCodeConverter.typeMap["PowerUpItemInfoDoesntExist"] = EngineErrorCode.PowerUpItemInfoDoesntExist;
			EngineErrorCodeConverter.typeMap["MultiplePaintsInSameSlot"] = EngineErrorCode.MultiplePaintsInSameSlot;
			EngineErrorCodeConverter.typeMap["InvalidPaintGroupForPaintSlot"] = EngineErrorCode.InvalidPaintGroupForPaintSlot;
			EngineErrorCodeConverter.typeMap["CantDeleteLastOwnedCar"] = EngineErrorCode.CantDeleteLastOwnedCar;
			EngineErrorCodeConverter.typeMap["PresetCarDoesntExist"] = EngineErrorCode.PresetCarDoesntExist;
			EngineErrorCodeConverter.typeMap["InvalidCurrencyType"] = EngineErrorCode.InvalidCurrencyType;
			EngineErrorCodeConverter.typeMap["WalletDoesntExist"] = EngineErrorCode.WalletDoesntExist;
			EngineErrorCodeConverter.typeMap["InsufficientFunds"] = EngineErrorCode.InsufficientFunds;
			EngineErrorCodeConverter.typeMap["WalletAlreadyExists"] = EngineErrorCode.WalletAlreadyExists;
			EngineErrorCodeConverter.typeMap["UnsupportedCurrency"] = EngineErrorCode.UnsupportedCurrency;
			EngineErrorCodeConverter.typeMap["InvalidDebitAmount"] = EngineErrorCode.InvalidDebitAmount;
			EngineErrorCodeConverter.typeMap["InvalidCreditAmount"] = EngineErrorCode.InvalidCreditAmount;
			EngineErrorCodeConverter.typeMap["InvalidWalletType"] = EngineErrorCode.InvalidWalletType;
			EngineErrorCodeConverter.typeMap["WalletNotUserWallet"] = EngineErrorCode.WalletNotUserWallet;
			EngineErrorCodeConverter.typeMap["InventoryItemDoesntExist"] = EngineErrorCode.InventoryItemDoesntExist;
			EngineErrorCodeConverter.typeMap["VirtualItemTypeDoesntExist"] = EngineErrorCode.VirtualItemTypeDoesntExist;
			EngineErrorCodeConverter.typeMap["InsufficientInventory"] = EngineErrorCode.InsufficientInventory;
			EngineErrorCodeConverter.typeMap["ItemIsForAnotherTier"] = EngineErrorCode.ItemIsForAnotherTier;
			EngineErrorCodeConverter.typeMap["RecursiveCatalog"] = EngineErrorCode.RecursiveCatalog;
			EngineErrorCodeConverter.typeMap["InvalidCatalog"] = EngineErrorCode.InvalidCatalog;
			EngineErrorCodeConverter.typeMap["InvalidBasket"] = EngineErrorCode.InvalidBasket;
			EngineErrorCodeConverter.typeMap["GameIsPrivate"] = EngineErrorCode.GameIsPrivate;
			EngineErrorCodeConverter.typeMap["GameLocked"] = EngineErrorCode.GameLocked;
			EngineErrorCodeConverter.typeMap["NotInGame"] = EngineErrorCode.NotInGame;
			EngineErrorCodeConverter.typeMap["NotEnoughSpace"] = EngineErrorCode.NotEnoughSpace;
			EngineErrorCodeConverter.typeMap["GameDoesNotExist"] = EngineErrorCode.GameDoesNotExist;
			EngineErrorCodeConverter.typeMap["NotPrivateGame"] = EngineErrorCode.NotPrivateGame;
			EngineErrorCodeConverter.typeMap["InviteAutoDeclined"] = EngineErrorCode.InviteAutoDeclined;
			EngineErrorCodeConverter.typeMap["MaxStackOrRentalLimitErrorCode"] = EngineErrorCode.MaxStackOrRentalLimitErrorCode;
			EngineErrorCodeConverter.typeMap["UnspecifiedError"] = EngineErrorCode.UnspecifiedError;
			EngineErrorCodeConverter.typeMap["RequiredHeadersNotFound"] = EngineErrorCode.RequiredHeadersNotFound;
			EngineErrorCodeConverter.typeMap["InvalidHeaderValues"] = EngineErrorCode.InvalidHeaderValues;
			EngineErrorCodeConverter.typeMap["FailedSessionSecurityPolicy"] = EngineErrorCode.FailedSessionSecurityPolicy;
			EngineErrorCodeConverter.typeMap["FailedUserIdComparison"] = EngineErrorCode.FailedUserIdComparison;
			EngineErrorCodeConverter.typeMap["FailedPersonaIdComparison"] = EngineErrorCode.FailedPersonaIdComparison;
			EngineErrorCodeConverter.typeMap["FailedSessionInsertion"] = EngineErrorCode.FailedSessionInsertion;
			EngineErrorCodeConverter.typeMap["FailedPresenceCheck"] = EngineErrorCode.FailedPresenceCheck;
			EngineErrorCodeConverter.typeMap["FailedDeleteSession"] = EngineErrorCode.FailedDeleteSession;
			EngineErrorCodeConverter.typeMap["FailedUpdateSession"] = EngineErrorCode.FailedUpdateSession;
			EngineErrorCodeConverter.typeMap["FailedReadSession"] = EngineErrorCode.FailedReadSession;
			EngineErrorCodeConverter.typeMap["NoSuchSessionInSessionStore"] = EngineErrorCode.NoSuchSessionInSessionStore;
			EngineErrorCodeConverter.typeMap["InvalidUserId"] = EngineErrorCode.InvalidUserId;
			EngineErrorCodeConverter.typeMap["InvalidPresence"] = EngineErrorCode.InvalidPresence;
			EngineErrorCodeConverter.typeMap["NoSuchInfoValueInSessionCurrentTable"] = EngineErrorCode.NoSuchInfoValueInSessionCurrentTable;
			EngineErrorCodeConverter.typeMap["FailedPlayGameEntitlementCheck"] = EngineErrorCode.FailedPlayGameEntitlementCheck;
			EngineErrorCodeConverter.typeMap["NotPermanentSessionKey"] = EngineErrorCode.NotPermanentSessionKey;
			EngineErrorCodeConverter.typeMap["WebTokenCheckFailed"] = EngineErrorCode.WebTokenCheckFailed;
			EngineErrorCodeConverter.typeMap["ConfigFilesAuthenticationException"] = EngineErrorCode.ConfigFilesAuthenticationException;
			EngineErrorCodeConverter.typeMap["LoginFailureLimitReached"] = EngineErrorCode.LoginFailureLimitReached;
			EngineErrorCodeConverter.typeMap["MaximumUsersLoggedInHardCapReached"] = EngineErrorCode.MaximumUsersLoggedInHardCapReached;
			EngineErrorCodeConverter.typeMap["MaximumUsersLoggedInSoftCapReached"] = EngineErrorCode.MaximumUsersLoggedInSoftCapReached;
			EngineErrorCodeConverter.typeMap["MaximumUsersLoggedInUnspecified"] = EngineErrorCode.MaximumUsersLoggedInUnspecified;
			EngineErrorCodeConverter.typeMap["SessionRequestThresholdReached"] = EngineErrorCode.SessionRequestThresholdReached;
			EngineErrorCodeConverter.typeMap["InvalidEntrantEventSession"] = EngineErrorCode.InvalidEntrantEventSession;
			EngineErrorCodeConverter.typeMap["InvalidFinishReason"] = EngineErrorCode.InvalidFinishReason;
			EngineErrorCodeConverter.typeMap["InvalidRaceTimeInResult"] = EngineErrorCode.InvalidRaceTimeInResult;
			EngineErrorCodeConverter.typeMap["InvalidSpeedInResult"] = EngineErrorCode.InvalidSpeedInResult;
			EngineErrorCodeConverter.typeMap["InvalidPlacingInResult"] = EngineErrorCode.InvalidPlacingInResult;
			EngineErrorCodeConverter.typeMap["InvalidFractionCompletedInResult"] = EngineErrorCode.InvalidFractionCompletedInResult;
			EngineErrorCodeConverter.typeMap["InvalidRequestorIdHeader"] = EngineErrorCode.InvalidRequestorIdHeader;
			EngineErrorCodeConverter.typeMap["UsernameIsNotAllowed"] = EngineErrorCode.UsernameIsNotAllowed;
			EngineErrorCodeConverter.typeMap["EmailInvalid"] = EngineErrorCode.EmailInvalid;
			EngineErrorCodeConverter.typeMap["EmailInvalidDomain"] = EngineErrorCode.EmailInvalidDomain;
			EngineErrorCodeConverter.typeMap["EmailMissing"] = EngineErrorCode.EmailMissing;
			EngineErrorCodeConverter.typeMap["EmailDuplicate"] = EngineErrorCode.EmailDuplicate;
			EngineErrorCodeConverter.typeMap["PasswordMissing"] = EngineErrorCode.PasswordMissing;
			EngineErrorCodeConverter.typeMap["PasswordTooShort"] = EngineErrorCode.PasswordTooShort;
			EngineErrorCodeConverter.typeMap["PasswordTooLong"] = EngineErrorCode.PasswordTooLong;
			EngineErrorCodeConverter.typeMap["PasswordNoSpacesAllowed"] = EngineErrorCode.PasswordNoSpacesAllowed;
			EngineErrorCodeConverter.typeMap["PasswordEmailCombinationDuplicate"] = EngineErrorCode.PasswordEmailCombinationDuplicate;
			EngineErrorCodeConverter.typeMap["DateOfBirthMissing"] = EngineErrorCode.DateOfBirthMissing;
			EngineErrorCodeConverter.typeMap["DateOfBirthInvalid"] = EngineErrorCode.DateOfBirthInvalid;
			EngineErrorCodeConverter.typeMap["DateOfBirthTooYoung"] = EngineErrorCode.DateOfBirthTooYoung;
			EngineErrorCodeConverter.typeMap["CountryMissing"] = EngineErrorCode.CountryMissing;
			EngineErrorCodeConverter.typeMap["CountryInvalid"] = EngineErrorCode.CountryInvalid;
			EngineErrorCodeConverter.typeMap["CountryBanned"] = EngineErrorCode.CountryBanned;
			EngineErrorCodeConverter.typeMap["LanguageMissing"] = EngineErrorCode.LanguageMissing;
			EngineErrorCodeConverter.typeMap["LanguageInvalid"] = EngineErrorCode.LanguageInvalid;
			EngineErrorCodeConverter.typeMap["TosVersionMissing"] = EngineErrorCode.TosVersionMissing;
			EngineErrorCodeConverter.typeMap["TosVersionTooLong"] = EngineErrorCode.TosVersionTooLong;
			EngineErrorCodeConverter.typeMap["StatusMissing"] = EngineErrorCode.StatusMissing;
			EngineErrorCodeConverter.typeMap["StatusInvalid"] = EngineErrorCode.StatusInvalid;
			EngineErrorCodeConverter.typeMap["StatusIllegalValue"] = EngineErrorCode.StatusIllegalValue;
			EngineErrorCodeConverter.typeMap["GlobalOptInMissing"] = EngineErrorCode.GlobalOptInMissing;
			EngineErrorCodeConverter.typeMap["GlobalOptInInvalid"] = EngineErrorCode.GlobalOptInInvalid;
			EngineErrorCodeConverter.typeMap["ThirdPartyOptInMissing"] = EngineErrorCode.ThirdPartyOptInMissing;
			EngineErrorCodeConverter.typeMap["ThirdPartyOptInInvalid"] = EngineErrorCode.ThirdPartyOptInInvalid;
			EngineErrorCodeConverter.typeMap["LastAuthenticatedOnDateInvalid"] = EngineErrorCode.LastAuthenticatedOnDateInvalid;
			EngineErrorCodeConverter.typeMap["RemoteUserDoesNotExist"] = EngineErrorCode.RemoteUserDoesNotExist;
			EngineErrorCodeConverter.typeMap["PasswordIncorrect"] = EngineErrorCode.PasswordIncorrect;
			EngineErrorCodeConverter.typeMap["RemoteUserIsBanned"] = EngineErrorCode.RemoteUserIsBanned;
			EngineErrorCodeConverter.typeMap["RegistrationSourceTooLong"] = EngineErrorCode.RegistrationSourceTooLong;
			EngineErrorCodeConverter.typeMap["RemoteUserIsGameBanned"] = EngineErrorCode.RemoteUserIsGameBanned;
			EngineErrorCodeConverter.typeMap["RemoteUserIsTempGameBanned"] = EngineErrorCode.RemoteUserIsTempGameBanned;
			EngineErrorCodeConverter.typeMap["InvalidGenderErrorCode"] = EngineErrorCode.InvalidGenderErrorCode;
			EngineErrorCodeConverter.typeMap["RemoteNamespaceDoesNotExist"] = EngineErrorCode.RemoteNamespaceDoesNotExist;
			EngineErrorCodeConverter.typeMap["DisplayNameMissing"] = EngineErrorCode.DisplayNameMissing;
			EngineErrorCodeConverter.typeMap["DisplayNameDuplicate"] = EngineErrorCode.DisplayNameDuplicate;
			EngineErrorCodeConverter.typeMap["DisplayNameTooLong"] = EngineErrorCode.DisplayNameTooLong;
			EngineErrorCodeConverter.typeMap["DisplayNameTooShort"] = EngineErrorCode.DisplayNameTooShort;
			EngineErrorCodeConverter.typeMap["DisplayNameNotAllowed"] = EngineErrorCode.DisplayNameNotAllowed;
			EngineErrorCodeConverter.typeMap["DisplayNameSuggestionFailed"] = EngineErrorCode.DisplayNameSuggestionFailed;
			EngineErrorCodeConverter.typeMap["StatusReasonCodeInvalid"] = EngineErrorCode.StatusReasonCodeInvalid;
			EngineErrorCodeConverter.typeMap["LastAuthenticatedDateInvalid"] = EngineErrorCode.LastAuthenticatedDateInvalid;
			EngineErrorCodeConverter.typeMap["MaximumNumberOfPersonasInNamespaceReached"] = EngineErrorCode.MaximumNumberOfPersonasInNamespaceReached;
			EngineErrorCodeConverter.typeMap["PersonaNotFound"] = EngineErrorCode.PersonaNotFound;
			EngineErrorCodeConverter.typeMap["RemotePersonaDoesNotBelongToUser"] = EngineErrorCode.RemotePersonaDoesNotBelongToUser;
			EngineErrorCodeConverter.typeMap["UserNotFound"] = EngineErrorCode.UserNotFound;
			EngineErrorCodeConverter.typeMap["MoreThanOneRemoteUserFound"] = EngineErrorCode.MoreThanOneRemoteUserFound;
			EngineErrorCodeConverter.typeMap["UnableToAuthenticateUserByAuthKey"] = EngineErrorCode.UnableToAuthenticateUserByAuthKey;
			EngineErrorCodeConverter.typeMap["PersonaCarIsNull"] = EngineErrorCode.PersonaCarIsNull;
			EngineErrorCodeConverter.typeMap["PersonaMottoIsTooLong"] = EngineErrorCode.PersonaMottoIsTooLong;
			EngineErrorCodeConverter.typeMap["TooManySuggestionsRequested"] = EngineErrorCode.TooManySuggestionsRequested;
			EngineErrorCodeConverter.typeMap["MaximumNumberOfPersonasForUserReached"] = EngineErrorCode.MaximumNumberOfPersonasForUserReached;
			EngineErrorCodeConverter.typeMap["WrongClientVersion"] = EngineErrorCode.WrongClientVersion;
			EngineErrorCodeConverter.typeMap["AuthenticationTokenMissing"] = EngineErrorCode.AuthenticationTokenMissing;
			EngineErrorCodeConverter.typeMap["TransactionAlreadyActive"] = EngineErrorCode.TransactionAlreadyActive;
			EngineErrorCodeConverter.typeMap["FriendIsSelf"] = EngineErrorCode.FriendIsSelf;
			EngineErrorCodeConverter.typeMap["FriendAlreadyAdded"] = EngineErrorCode.FriendAlreadyAdded;
			EngineErrorCodeConverter.typeMap["FriendDoesNotExist"] = EngineErrorCode.FriendDoesNotExist;
			EngineErrorCodeConverter.typeMap["FriendsListExceededMaximumCount"] = EngineErrorCode.FriendsListExceededMaximumCount;
			EngineErrorCodeConverter.typeMap["TargetFriendsListExceededMaximumCount"] = EngineErrorCode.TargetFriendsListExceededMaximumCount;
			EngineErrorCodeConverter.typeMap["NullValue"] = EngineErrorCode.NullValue;
			EngineErrorCodeConverter.typeMap["LuckyDrawNoTableDefinedForRace"] = EngineErrorCode.LuckyDrawNoTableDefinedForRace;
			EngineErrorCodeConverter.typeMap["LuckyDrawInvalidDraw"] = EngineErrorCode.LuckyDrawInvalidDraw;
			EngineErrorCodeConverter.typeMap["LuckyDrawNoMoreDraws"] = EngineErrorCode.LuckyDrawNoMoreDraws;
			EngineErrorCodeConverter.typeMap["LuckyDrawNoLootTablesNotPopulated"] = EngineErrorCode.LuckyDrawNoLootTablesNotPopulated;
			EngineErrorCodeConverter.typeMap["LuckyDrawCouldNotDrawProduct"] = EngineErrorCode.LuckyDrawCouldNotDrawProduct;
			EngineErrorCodeConverter.typeMap["LuckyDrawCannotDeterminePersonaLevel"] = EngineErrorCode.LuckyDrawCannotDeterminePersonaLevel;
			EngineErrorCodeConverter.typeMap["LuckyDrawContextNotFoundOrEmpty"] = EngineErrorCode.LuckyDrawContextNotFoundOrEmpty;
			EngineErrorCodeConverter.typeMap["EventNotFound"] = EngineErrorCode.EventNotFound;
			EngineErrorCodeConverter.typeMap["SuggestiveSalesInvalidContext"] = EngineErrorCode.SuggestiveSalesInvalidContext;
			EngineErrorCodeConverter.typeMap["SuggestiveSalesInvalidConfiguration"] = EngineErrorCode.SuggestiveSalesInvalidConfiguration;
			EngineErrorCodeConverter.typeMap["SuggestiveSalesCannotDeterminePersonaLevel"] = EngineErrorCode.SuggestiveSalesCannotDeterminePersonaLevel;
			EngineErrorCodeConverter.typeMap["MissingRequiredEntitlements"] = EngineErrorCode.MissingRequiredEntitlements;
			EngineErrorCodeConverter.typeMap["BannedEntitlements"] = EngineErrorCode.BannedEntitlements;
			EngineErrorCodeConverter.typeMap["RemotePersonaIdInvalid"] = EngineErrorCode.RemotePersonaIdInvalid;
			EngineErrorCodeConverter.typeMap["PlayerNotRanked"] = EngineErrorCode.PlayerNotRanked;
			EngineErrorCodeConverter.typeMap["NoWalletErrorCode"] = EngineErrorCode.NoWalletErrorCode;
			EngineErrorCodeConverter.typeMap["WalletBalanceIsNotEnough"] = EngineErrorCode.WalletBalanceIsNotEnough;
			EngineErrorCodeConverter.typeMap["UserHasNoEntitlements"] = EngineErrorCode.UserHasNoEntitlements;
			EngineErrorCodeConverter.typeMap["NotInQueue"] = EngineErrorCode.NotInQueue;
			EngineErrorCodeConverter.typeMap["EntitlementProductIdMissing"] = EngineErrorCode.EntitlementProductIdMissing;
			EngineErrorCodeConverter.typeMap["EntitlementProductIdTooShort"] = EngineErrorCode.EntitlementProductIdTooShort;
			EngineErrorCodeConverter.typeMap["EntitlementProductIdTooLong"] = EngineErrorCode.EntitlementProductIdTooLong;
			EngineErrorCodeConverter.typeMap["EntitlementTagMissing"] = EngineErrorCode.EntitlementTagMissing;
			EngineErrorCodeConverter.typeMap["EntitlementTagTooShort"] = EngineErrorCode.EntitlementTagTooShort;
			EngineErrorCodeConverter.typeMap["EntitlementTagTooLong"] = EngineErrorCode.EntitlementTagTooLong;
			EngineErrorCodeConverter.typeMap["EntitlementGrantDateInvalid"] = EngineErrorCode.EntitlementGrantDateInvalid;
			EngineErrorCodeConverter.typeMap["EntitlementTerminationDateInvalid"] = EngineErrorCode.EntitlementTerminationDateInvalid;
			EngineErrorCodeConverter.typeMap["EntitlementNoSuchGroup"] = EngineErrorCode.EntitlementNoSuchGroup;
			EngineErrorCodeConverter.typeMap["EntitlementConcurrencyFailure"] = EngineErrorCode.EntitlementConcurrencyFailure;
			EngineErrorCodeConverter.typeMap["EntitlementInvalidCount"] = EngineErrorCode.EntitlementInvalidCount;
			EngineErrorCodeConverter.typeMap["NoProductErrorCode"] = EngineErrorCode.NoProductErrorCode;
			EngineErrorCodeConverter.typeMap["NoPricepointErrorCode"] = EngineErrorCode.NoPricepointErrorCode;
			EngineErrorCodeConverter.typeMap["MoreThanOneRemotePersonaFound"] = EngineErrorCode.MoreThanOneRemotePersonaFound;
			EngineErrorCodeConverter.typeMap["ServerConfigNotFound"] = EngineErrorCode.ServerConfigNotFound;
			EngineErrorCodeConverter.typeMap["NoSuchEntitlementExists"] = EngineErrorCode.NoSuchEntitlementExists;
			EngineErrorCodeConverter.typeMap["SessionKeyRequiredButNotFound"] = EngineErrorCode.SessionKeyRequiredButNotFound;
			EngineErrorCodeConverter.typeMap["InvalidRewardModeForTelemetry"] = EngineErrorCode.InvalidRewardModeForTelemetry;
			EngineErrorCodeConverter.typeMap["SocialFriendRequestNotResolvable"] = EngineErrorCode.SocialFriendRequestNotResolvable;
			EngineErrorCodeConverter.typeMap["NotFound"] = EngineErrorCode.NotFound;
			EngineErrorCodeConverter.typeMap["RemoteAccountManagementTimeout"] = EngineErrorCode.RemoteAccountManagementTimeout;
			EngineErrorCodeConverter.typeMap["VoipRemoteCallTimeout"] = EngineErrorCode.VoipRemoteCallTimeout;
			EngineErrorCodeConverter.typeMap["VoipUnknownError"] = EngineErrorCode.VoipUnknownError;
			EngineErrorCodeConverter.typeMap["LiveUpdateAuthenticationFailed"] = EngineErrorCode.LiveUpdateAuthenticationFailed;
			EngineErrorCodeConverter.typeMap["LiveUpdateInvalidCatalogVersion"] = EngineErrorCode.LiveUpdateInvalidCatalogVersion;
			EngineErrorCodeConverter.typeMap["SecurityKickedArbitration"] = EngineErrorCode.SecurityKickedArbitration;
			EngineErrorCodeConverter.typeMap["SecurityKickedRaceTime"] = EngineErrorCode.SecurityKickedRaceTime;
			EngineErrorCodeConverter.typeMap["SecurityKickedRaceTimeRatio"] = EngineErrorCode.SecurityKickedRaceTimeRatio;
			EngineErrorCodeConverter.typeMap["SecurityKickedStatisticalRaceTime"] = EngineErrorCode.SecurityKickedStatisticalRaceTime;
			EngineErrorCodeConverter.typeMap["SecurityKickedStatisticalTopSpeed"] = EngineErrorCode.SecurityKickedStatisticalTopSpeed;
			EngineErrorCodeConverter.typeMap["SecurityKickedInvalidPowerup"] = EngineErrorCode.SecurityKickedInvalidPowerup;
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x00050350 File Offset: 0x0004F350
		public static bool Parse(string str, out EngineErrorCode value)
		{
			if (EngineErrorCodeConverter.typeMap.TryGetValue(str, out value))
			{
				return true;
			}
			value = EngineErrorCode.Undefined;
			return false;
		}

		// Token: 0x04000AD1 RID: 2769
		private static Dictionary<string, EngineErrorCode> typeMap = new Dictionary<string, EngineErrorCode>();
	}
}

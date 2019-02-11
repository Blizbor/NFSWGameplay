using System;

namespace Victory
{
	// Token: 0x0200033F RID: 831
	public enum EngineErrorCode
	{
		// Token: 0x04000A11 RID: 2577
		Undefined,
		// Token: 0x04000A12 RID: 2578
		Unknown,
		// Token: 0x04000A13 RID: 2579
		MissingMethodInputData,
		// Token: 0x04000A14 RID: 2580
		ValuesAreNotEqual,
		// Token: 0x04000A15 RID: 2581
		ArgumentNullOrEmpty,
		// Token: 0x04000A16 RID: 2582
		XmlDeserializationError,
		// Token: 0x04000A17 RID: 2583
		UnknownRemoteAccountManagementError,
		// Token: 0x04000A18 RID: 2584
		ValuesAreEqual,
		// Token: 0x04000A19 RID: 2585
		InvalidOperation,
		// Token: 0x04000A1A RID: 2586
		LeftIsGreaterThanRight,
		// Token: 0x04000A1B RID: 2587
		LeftIsLessThanRight,
		// Token: 0x04000A1C RID: 2588
		ChatConnectionError = -100,
		// Token: 0x04000A1D RID: 2589
		GameServerRegionDoesntExist = 101,
		// Token: 0x04000A1E RID: 2590
		ServerConfigDoesntExist,
		// Token: 0x04000A1F RID: 2591
		CustomCarDoesntExist = -200,
		// Token: 0x04000A20 RID: 2592
		CarNotOwnedByDriver = -201,
		// Token: 0x04000A21 RID: 2593
		CarIsntPresetCar = -202,
		// Token: 0x04000A22 RID: 2594
		CarIsntCustomCar = -203,
		// Token: 0x04000A23 RID: 2595
		CarDataInvalid = -205,
		// Token: 0x04000A24 RID: 2596
		PowerUpItemInfoDoesntExist = -206,
		// Token: 0x04000A25 RID: 2597
		MultiplePaintsInSameSlot = -207,
		// Token: 0x04000A26 RID: 2598
		InvalidPaintGroupForPaintSlot = -208,
		// Token: 0x04000A27 RID: 2599
		CantDeleteLastOwnedCar = -209,
		// Token: 0x04000A28 RID: 2600
		PresetCarDoesntExist = -210,
		// Token: 0x04000A29 RID: 2601
		InvalidCurrencyType = 300,
		// Token: 0x04000A2A RID: 2602
		WalletDoesntExist = -301,
		// Token: 0x04000A2B RID: 2603
		InsufficientFunds = -302,
		// Token: 0x04000A2C RID: 2604
		WalletAlreadyExists = -303,
		// Token: 0x04000A2D RID: 2605
		UnsupportedCurrency = -304,
		// Token: 0x04000A2E RID: 2606
		InvalidDebitAmount = -305,
		// Token: 0x04000A2F RID: 2607
		InvalidCreditAmount = -306,
		// Token: 0x04000A30 RID: 2608
		InvalidWalletType = -307,
		// Token: 0x04000A31 RID: 2609
		WalletNotUserWallet = -308,
		// Token: 0x04000A32 RID: 2610
		InventoryItemDoesntExist = -350,
		// Token: 0x04000A33 RID: 2611
		VirtualItemTypeDoesntExist = -351,
		// Token: 0x04000A34 RID: 2612
		InsufficientInventory = -352,
		// Token: 0x04000A35 RID: 2613
		ItemIsForAnotherTier = -353,
		// Token: 0x04000A36 RID: 2614
		RecursiveCatalog = -354,
		// Token: 0x04000A37 RID: 2615
		InvalidCatalog = -355,
		// Token: 0x04000A38 RID: 2616
		InvalidBasket = -356,
		// Token: 0x04000A39 RID: 2617
		GameIsPrivate = -398,
		// Token: 0x04000A3A RID: 2618
		GameLocked = -399,
		// Token: 0x04000A3B RID: 2619
		NotInGame = -400,
		// Token: 0x04000A3C RID: 2620
		NotEnoughSpace = -401,
		// Token: 0x04000A3D RID: 2621
		GameDoesNotExist = -402,
		// Token: 0x04000A3E RID: 2622
		NotPrivateGame = -403,
		// Token: 0x04000A3F RID: 2623
		InviteAutoDeclined = -404,
		// Token: 0x04000A40 RID: 2624
		MaxStackOrRentalLimitErrorCode = -417,
		// Token: 0x04000A41 RID: 2625
		UnspecifiedError = -500,
		// Token: 0x04000A42 RID: 2626
		RequiredHeadersNotFound = -501,
		// Token: 0x04000A43 RID: 2627
		InvalidHeaderValues = -502,
		// Token: 0x04000A44 RID: 2628
		FailedSessionSecurityPolicy = 1503,
		// Token: 0x04000A45 RID: 2629
		FailedUserIdComparison = -504,
		// Token: 0x04000A46 RID: 2630
		FailedPersonaIdComparison = -505,
		// Token: 0x04000A47 RID: 2631
		FailedSessionInsertion = -506,
		// Token: 0x04000A48 RID: 2632
		FailedPresenceCheck = -507,
		// Token: 0x04000A49 RID: 2633
		FailedDeleteSession = -508,
		// Token: 0x04000A4A RID: 2634
		FailedUpdateSession = -509,
		// Token: 0x04000A4B RID: 2635
		FailedReadSession = -510,
		// Token: 0x04000A4C RID: 2636
		NoSuchSessionInSessionStore = -511,
		// Token: 0x04000A4D RID: 2637
		InvalidUserId = -512,
		// Token: 0x04000A4E RID: 2638
		InvalidPresence = -513,
		// Token: 0x04000A4F RID: 2639
		NoSuchInfoValueInSessionCurrentTable = -514,
		// Token: 0x04000A50 RID: 2640
		FailedPlayGameEntitlementCheck = -516,
		// Token: 0x04000A51 RID: 2641
		NotPermanentSessionKey = -517,
		// Token: 0x04000A52 RID: 2642
		WebTokenCheckFailed = -518,
		// Token: 0x04000A53 RID: 2643
		ConfigFilesAuthenticationException = -519,
		// Token: 0x04000A54 RID: 2644
		LoginFailureLimitReached = -520,
		// Token: 0x04000A55 RID: 2645
		MaximumUsersLoggedInHardCapReached = -521,
		// Token: 0x04000A56 RID: 2646
		MaximumUsersLoggedInSoftCapReached = -522,
		// Token: 0x04000A57 RID: 2647
		MaximumUsersLoggedInUnspecified = -523,
		// Token: 0x04000A58 RID: 2648
		SessionRequestThresholdReached = -524,
		// Token: 0x04000A59 RID: 2649
		InvalidEntrantEventSession = -600,
		// Token: 0x04000A5A RID: 2650
		InvalidFinishReason = -603,
		// Token: 0x04000A5B RID: 2651
		InvalidRaceTimeInResult = -614,
		// Token: 0x04000A5C RID: 2652
		InvalidSpeedInResult = -615,
		// Token: 0x04000A5D RID: 2653
		InvalidPlacingInResult = -616,
		// Token: 0x04000A5E RID: 2654
		InvalidFractionCompletedInResult = -617,
		// Token: 0x04000A5F RID: 2655
		InvalidRequestorIdHeader = -700,
		// Token: 0x04000A60 RID: 2656
		UsernameIsNotAllowed = -708,
		// Token: 0x04000A61 RID: 2657
		EmailInvalid = -710,
		// Token: 0x04000A62 RID: 2658
		EmailInvalidDomain = -711,
		// Token: 0x04000A63 RID: 2659
		EmailMissing = -712,
		// Token: 0x04000A64 RID: 2660
		EmailDuplicate = -713,
		// Token: 0x04000A65 RID: 2661
		PasswordMissing = -714,
		// Token: 0x04000A66 RID: 2662
		PasswordTooShort = -715,
		// Token: 0x04000A67 RID: 2663
		PasswordTooLong = -716,
		// Token: 0x04000A68 RID: 2664
		PasswordNoSpacesAllowed = -717,
		// Token: 0x04000A69 RID: 2665
		PasswordEmailCombinationDuplicate = -718,
		// Token: 0x04000A6A RID: 2666
		DateOfBirthMissing = -720,
		// Token: 0x04000A6B RID: 2667
		DateOfBirthInvalid = -721,
		// Token: 0x04000A6C RID: 2668
		DateOfBirthTooYoung = -722,
		// Token: 0x04000A6D RID: 2669
		CountryMissing = -723,
		// Token: 0x04000A6E RID: 2670
		CountryInvalid = -725,
		// Token: 0x04000A6F RID: 2671
		CountryBanned = -726,
		// Token: 0x04000A70 RID: 2672
		LanguageMissing = -727,
		// Token: 0x04000A71 RID: 2673
		LanguageInvalid = -728,
		// Token: 0x04000A72 RID: 2674
		TosVersionMissing = -729,
		// Token: 0x04000A73 RID: 2675
		TosVersionTooLong = -730,
		// Token: 0x04000A74 RID: 2676
		StatusMissing = -731,
		// Token: 0x04000A75 RID: 2677
		StatusInvalid = -732,
		// Token: 0x04000A76 RID: 2678
		StatusIllegalValue = -733,
		// Token: 0x04000A77 RID: 2679
		GlobalOptInMissing = -737,
		// Token: 0x04000A78 RID: 2680
		GlobalOptInInvalid = -738,
		// Token: 0x04000A79 RID: 2681
		ThirdPartyOptInMissing = -739,
		// Token: 0x04000A7A RID: 2682
		ThirdPartyOptInInvalid = -740,
		// Token: 0x04000A7B RID: 2683
		LastAuthenticatedOnDateInvalid = -744,
		// Token: 0x04000A7C RID: 2684
		RemoteUserDoesNotExist = -746,
		// Token: 0x04000A7D RID: 2685
		PasswordIncorrect = -747,
		// Token: 0x04000A7E RID: 2686
		RemoteUserIsBanned = -748,
		// Token: 0x04000A7F RID: 2687
		RegistrationSourceTooLong = -749,
		// Token: 0x04000A80 RID: 2688
		RemoteUserIsGameBanned = -750,
		// Token: 0x04000A81 RID: 2689
		RemoteUserIsTempGameBanned = -751,
		// Token: 0x04000A82 RID: 2690
		InvalidGenderErrorCode = -758,
		// Token: 0x04000A83 RID: 2691
		RemoteNamespaceDoesNotExist = -760,
		// Token: 0x04000A84 RID: 2692
		DisplayNameMissing = -761,
		// Token: 0x04000A85 RID: 2693
		DisplayNameDuplicate = -762,
		// Token: 0x04000A86 RID: 2694
		DisplayNameTooLong = -763,
		// Token: 0x04000A87 RID: 2695
		DisplayNameTooShort = -764,
		// Token: 0x04000A88 RID: 2696
		DisplayNameNotAllowed = -765,
		// Token: 0x04000A89 RID: 2697
		DisplayNameSuggestionFailed = -766,
		// Token: 0x04000A8A RID: 2698
		StatusReasonCodeInvalid = -768,
		// Token: 0x04000A8B RID: 2699
		LastAuthenticatedDateInvalid = -769,
		// Token: 0x04000A8C RID: 2700
		MaximumNumberOfPersonasInNamespaceReached = -770,
		// Token: 0x04000A8D RID: 2701
		PersonaNotFound = -771,
		// Token: 0x04000A8E RID: 2702
		RemotePersonaDoesNotBelongToUser = -773,
		// Token: 0x04000A8F RID: 2703
		UserNotFound = -774,
		// Token: 0x04000A90 RID: 2704
		MoreThanOneRemoteUserFound = -775,
		// Token: 0x04000A91 RID: 2705
		UnableToAuthenticateUserByAuthKey = -777,
		// Token: 0x04000A92 RID: 2706
		PersonaCarIsNull = -782,
		// Token: 0x04000A93 RID: 2707
		PersonaMottoIsTooLong = -783,
		// Token: 0x04000A94 RID: 2708
		TooManySuggestionsRequested = -787,
		// Token: 0x04000A95 RID: 2709
		MaximumNumberOfPersonasForUserReached = -788,
		// Token: 0x04000A96 RID: 2710
		WrongClientVersion = -799,
		// Token: 0x04000A97 RID: 2711
		AuthenticationTokenMissing = -800,
		// Token: 0x04000A98 RID: 2712
		TransactionAlreadyActive = -880,
		// Token: 0x04000A99 RID: 2713
		FriendIsSelf = -900,
		// Token: 0x04000A9A RID: 2714
		FriendAlreadyAdded = -901,
		// Token: 0x04000A9B RID: 2715
		FriendDoesNotExist = -902,
		// Token: 0x04000A9C RID: 2716
		FriendsListExceededMaximumCount = -903,
		// Token: 0x04000A9D RID: 2717
		TargetFriendsListExceededMaximumCount = -904,
		// Token: 0x04000A9E RID: 2718
		NullValue = -1002,
		// Token: 0x04000A9F RID: 2719
		LuckyDrawNoTableDefinedForRace = -1520,
		// Token: 0x04000AA0 RID: 2720
		LuckyDrawInvalidDraw = -1521,
		// Token: 0x04000AA1 RID: 2721
		LuckyDrawNoMoreDraws = -1522,
		// Token: 0x04000AA2 RID: 2722
		LuckyDrawNoLootTablesNotPopulated = -1523,
		// Token: 0x04000AA3 RID: 2723
		LuckyDrawCouldNotDrawProduct = -1524,
		// Token: 0x04000AA4 RID: 2724
		LuckyDrawCannotDeterminePersonaLevel = -1525,
		// Token: 0x04000AA5 RID: 2725
		LuckyDrawContextNotFoundOrEmpty = -1526,
		// Token: 0x04000AA6 RID: 2726
		EventNotFound = -1550,
		// Token: 0x04000AA7 RID: 2727
		SuggestiveSalesInvalidContext = -1600,
		// Token: 0x04000AA8 RID: 2728
		SuggestiveSalesInvalidConfiguration = -1601,
		// Token: 0x04000AA9 RID: 2729
		SuggestiveSalesCannotDeterminePersonaLevel = -1602,
		// Token: 0x04000AAA RID: 2730
		MissingRequiredEntitlements = -1612,
		// Token: 0x04000AAB RID: 2731
		BannedEntitlements = -1613,
		// Token: 0x04000AAC RID: 2732
		RemotePersonaIdInvalid = -1646,
		// Token: 0x04000AAD RID: 2733
		PlayerNotRanked = -1670,
		// Token: 0x04000AAE RID: 2734
		NoWalletErrorCode = -1683,
		// Token: 0x04000AAF RID: 2735
		WalletBalanceIsNotEnough = -1684,
		// Token: 0x04000AB0 RID: 2736
		UserHasNoEntitlements = -1730,
		// Token: 0x04000AB1 RID: 2737
		NotInQueue = -1801,
		// Token: 0x04000AB2 RID: 2738
		EntitlementProductIdMissing = -1900,
		// Token: 0x04000AB3 RID: 2739
		EntitlementProductIdTooShort = -1901,
		// Token: 0x04000AB4 RID: 2740
		EntitlementProductIdTooLong = -1902,
		// Token: 0x04000AB5 RID: 2741
		EntitlementTagMissing = -1903,
		// Token: 0x04000AB6 RID: 2742
		EntitlementTagTooShort = -1904,
		// Token: 0x04000AB7 RID: 2743
		EntitlementTagTooLong = -1905,
		// Token: 0x04000AB8 RID: 2744
		EntitlementGrantDateInvalid = -1906,
		// Token: 0x04000AB9 RID: 2745
		EntitlementTerminationDateInvalid = -1907,
		// Token: 0x04000ABA RID: 2746
		EntitlementNoSuchGroup = -1908,
		// Token: 0x04000ABB RID: 2747
		EntitlementConcurrencyFailure = -1909,
		// Token: 0x04000ABC RID: 2748
		EntitlementInvalidCount = -1910,
		// Token: 0x04000ABD RID: 2749
		NoProductErrorCode = -1911,
		// Token: 0x04000ABE RID: 2750
		NoPricepointErrorCode = -1917,
		// Token: 0x04000ABF RID: 2751
		MoreThanOneRemotePersonaFound = -2000,
		// Token: 0x04000AC0 RID: 2752
		ServerConfigNotFound = -2500,
		// Token: 0x04000AC1 RID: 2753
		NoSuchEntitlementExists = -3000,
		// Token: 0x04000AC2 RID: 2754
		SessionKeyRequiredButNotFound = -6666,
		// Token: 0x04000AC3 RID: 2755
		InvalidRewardModeForTelemetry = -6667,
		// Token: 0x04000AC4 RID: 2756
		SocialFriendRequestNotResolvable = -10000,
		// Token: 0x04000AC5 RID: 2757
		NotFound = -10404,
		// Token: 0x04000AC6 RID: 2758
		RemoteAccountManagementTimeout = -11000,
		// Token: 0x04000AC7 RID: 2759
		VoipRemoteCallTimeout = -11001,
		// Token: 0x04000AC8 RID: 2760
		VoipUnknownError = -11002,
		// Token: 0x04000AC9 RID: 2761
		LiveUpdateAuthenticationFailed = -100000,
		// Token: 0x04000ACA RID: 2762
		LiveUpdateInvalidCatalogVersion = -100001,
		// Token: 0x04000ACB RID: 2763
		SecurityKickedArbitration = -200000,
		// Token: 0x04000ACC RID: 2764
		SecurityKickedRaceTime = -200001,
		// Token: 0x04000ACD RID: 2765
		SecurityKickedRaceTimeRatio = -200002,
		// Token: 0x04000ACE RID: 2766
		SecurityKickedStatisticalRaceTime = -200003,
		// Token: 0x04000ACF RID: 2767
		SecurityKickedStatisticalTopSpeed = -200004,
		// Token: 0x04000AD0 RID: 2768
		SecurityKickedInvalidPowerup = -200005
	}
}

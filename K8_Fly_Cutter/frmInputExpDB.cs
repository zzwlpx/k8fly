namespace K8_Fly_Cutter
{
    using BLL;
    using System;
    using System.ComponentModel;
    using System.Data;
    using System.Data.OleDb;
    using System.Drawing;
    using System.Text;
    using System.Threading;
    using System.Windows.Forms;

    public class frmInputExpDB : Form
    {
        private Button btn_inputDB;
        private IContainer components = null;
        private Label label1;
        private Label label2;
        private frmMain paf;
        private ProgressBar pb_inputExp;
        private TextBox txt_mdbpath;

        public frmInputExpDB(frmMain parent)
        {
            this.InitializeComponent();
            this.paf = parent;
        }

        public static DataSet BllGetDataSet(string MDBpath)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("select * from K8_ExploitS order by appName asc,id asc;");
            using (OleDbCommand command = new OleDbCommand(builder.ToString()))
            {
                return DALGetDataSet(command, MDBpath);
            }
        }

        private void btn_inputDB_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.K8inputDB));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(new ThreadStart(this.K8inputDB));
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        public static DataSet DALGetDataSet(OleDbCommand cmd, string MDBpath)
        {
            DataSet set2;
            string str = string.Concat(new object[] { '\x0003', "K8team", '\r', '\t', '\n', '\x0002' });
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

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void frmInputExpDB_Load(object sender, EventArgs e)
        {
            base.CenterToParent();
            base.MaximizeBox = false;
            base.MinimizeBox = false;
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(frmInputExpDB));
            this.label1 = new Label();
            this.txt_mdbpath = new TextBox();
            this.btn_inputDB = new Button();
            this.pb_inputExp = new ProgressBar();
            this.label2 = new Label();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x23, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "路径:";
            this.txt_mdbpath.Location = new Point(0x36, 10);
            this.txt_mdbpath.Name = "txt_mdbpath";
            this.txt_mdbpath.Size = new Size(0x13e, 0x15);
            this.txt_mdbpath.TabIndex = 1;
            this.btn_inputDB.Font = new Font("宋体", 10.5f, FontStyle.Regular, GraphicsUnit.Point, 0x86);
            this.btn_inputDB.Location = new Point(0x185, 10);
            this.btn_inputDB.Name = "btn_inputDB";
            this.btn_inputDB.Size = new Size(0x3a, 0x33);
            this.btn_inputDB.TabIndex = 2;
            this.btn_inputDB.Text = "选择";
            this.btn_inputDB.UseVisualStyleBackColor = true;
            this.btn_inputDB.Click += new EventHandler(this.btn_inputDB_Click);
            this.pb_inputExp.Location = new Point(0x36, 0x26);
            this.pb_inputExp.Name = "pb_inputExp";
            this.pb_inputExp.Size = new Size(0x13e, 0x17);
            this.pb_inputExp.TabIndex = 3;
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 0x2b);
            this.label2.Name = "label2";
            this.label2.Size = new Size(0x23, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "进度:";
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x1ce, 0x4b);
            base.Controls.Add(this.label2);
            base.Controls.Add(this.pb_inputExp);
            base.Controls.Add(this.btn_inputDB);
            base.Controls.Add(this.txt_mdbpath);
            base.Controls.Add(this.label1);
            base.Icon = (Icon) resources.GetObject("$this.Icon");
            base.Name = "frmInputExpDB";
            this.Text = "导入飞刀EXP数据库";
            base.Load += new EventHandler(this.frmInputExpDB_Load);
            base.ResumeLayout(false);
            base.PerformLayout();
        }

        private void K8inputDB()
        {
            int num = 0;
            int num2 = 0;
            string text = this.Text;
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "mdb file|*.mdb"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                this.txt_mdbpath.Text = fileName;
                string str3 = "";
                string str4 = "";
                string str5 = "";
                string str6 = "";
                string str7 = "";
                string str8 = "";
                string str9 = "";
                string str10 = "";
                string str11 = "";
                string str12 = "";
                string str13 = "";
                string str = "";
                DataSet set = BllGetDataSet(fileName);
                this.pb_inputExp.Minimum = 0;
                this.pb_inputExp.Value = 0;
                this.pb_inputExp.Maximum = set.Tables[0].Rows.Count;
                foreach (DataRow row in set.Tables[0].Rows)
                {
                    int num3;
                    this.pb_inputExp.Value = (num3 = this.pb_inputExp.Value) + 1;
                    num = num3;
                    string[] strArray = new string[] { text, "   将导入 ", this.pb_inputExp.Maximum.ToString(), "个 检测第 ", (num + 1).ToString(), "个 新增 ", num2.ToString(), "个EXP" };
                    this.Text = string.Concat(strArray);
                    str3 = row["appName"].ToString();
                    str4 = row["btnName"].ToString();
                    str5 = row["btnTip"].ToString();
                    str6 = row["method"].ToString();
                    str7 = row["cookie"].ToString();
                    str8 = row["sumbitData"].ToString();
                    str9 = row["referer"].ToString();
                    str10 = row["userAgent"].ToString();
                    str11 = row["encode"].ToString();
                    str12 = row["allowRedirect"].ToString();
                    try
                    {
                        str = row["addURL"].ToString();
                    }
                    catch (Exception)
                    {
                        str = "[K8WwBLADgAdABlAGEAbQBdAA==team]";
                    }
                    if (str == "")
                    {
                        str = K8crack.K8expBase64(str, 1);
                    }
                    str13 = DateTime.Now.Date.ToShortDateString();
                    if (str13.Contains("/"))
                    {
                        str13 = str13.Replace("/", "-");
                    }
                    if (!BLLk8EXP.ExistsRecord(new string[] { str3, str6, str7, str8, str9, str10, str11, str12, str }))
                    {
                        num2++;
                        BLLk8EXP.InsertRecord(new string[] { str3, str4, str5, str6, str7, str8, str9, str10, str11, str12, str13, str });
                    }
                }
                this.K8msgbox("导入完成,右键可重新加载EXP!");
                this.Text = text;
            }
        }

        private void K8inputDB2()
        {
            OpenFileDialog dialog = new OpenFileDialog {
                Filter = "mdb file|*.mdb"
            };
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string fileName = dialog.FileName;
                this.txt_mdbpath.Text = fileName;
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
                string str13 = "";
                DataSet set = BllGetDataSet(fileName);
                this.pb_inputExp.Minimum = 0;
                this.pb_inputExp.Value = 0;
                this.pb_inputExp.Maximum = set.Tables[0].Rows.Count;
                foreach (DataRow row in set.Tables[0].Rows)
                {
                    this.pb_inputExp.Value++;
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
                    str13 = row["addURL"].ToString();
                    str12 = DateTime.Now.Date.ToShortDateString();
                    if (str12.Contains("/"))
                    {
                        str12 = str12.Replace("/", "-");
                    }
                    if (!BLLk8EXP.ExistsRecord(new string[] { str2, str5, str6, str7, str8, str9, str10, str11, str13 }))
                    {
                        str = K8crack.K8expBase64(str, 0);
                        str4 = K8crack.K8expBase64(str4, 0);
                        str6 = K8crack.K8expBase64(str6, 0);
                        str7 = K8crack.K8expBase64(str7, 0);
                        str8 = K8crack.K8expBase64(str8, 0);
                        str9 = K8crack.K8expBase64(str9, 0);
                        str13 = K8crack.K8expBase64(str13, 0);
                        str = K8crack.K8expBase64(str, 1);
                        str4 = K8crack.K8expBase64(str4, 1);
                        str6 = K8crack.K8expBase64(str6, 1);
                        str7 = K8crack.K8expBase64(str7, 1);
                        str8 = K8crack.K8expBase64(str8, 1);
                        str9 = K8crack.K8expBase64(str9, 1);
                        str13 = K8crack.K8expBase64(K8crack.K8expBase64(str13, 1), 0);
                        BLLk8EXP.InsertRecord(new string[] { str2, str, str4, str5, str6, str7, str8, str9, str10, str11, str12 });
                    }
                }
                this.K8msgbox("EXP导入完成,请重新启动程序!");
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
    }
}


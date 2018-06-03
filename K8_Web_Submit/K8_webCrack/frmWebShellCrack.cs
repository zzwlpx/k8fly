namespace K8_Web_Submit.K8_webCrack
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;

    public class frmWebShellCrack : Form
    {
        private Button button1;
        private IContainer components = null;
        private Label label1;
        private TextBox txt_k8url;

        public frmWebShellCrack()
        {
            this.InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txt_k8url = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            base.SuspendLayout();
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new Size(0x53, 12);
            this.label1.TabIndex = 0x54;
            this.label1.Text = "WebShell地址:";
            this.txt_k8url.Location = new Point(0x65, 6);
            this.txt_k8url.Name = "txt_k8url";
            this.txt_k8url.Size = new Size(0x16c, 0x15);
            this.txt_k8url.TabIndex = 0x55;
            this.txt_k8url.Text = "http://172.16.126.137/phpMyAdmin";
            this.button1.Location = new Point(0x1d7, 4);
            this.button1.Name = "button1";
            this.button1.Size = new Size(0x4b, 0x17);
            this.button1.TabIndex = 0x56;
            this.button1.Text = "给我爆它";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new EventHandler(this.button1_Click);
            base.AutoScaleDimensions = new SizeF(6f, 12f);
            base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            base.ClientSize = new Size(0x22e, 0x155);
            base.Controls.Add(this.button1);
            base.Controls.Add(this.txt_k8url);
            base.Controls.Add(this.label1);
            base.Name = "frmWebShellCrack";
            this.Text = "K8_WebShell密码爆破工具";
            base.ResumeLayout(false);
            base.PerformLayout();
        }
    }
}


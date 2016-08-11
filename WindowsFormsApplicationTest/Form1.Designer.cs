namespace WindowsFormsApplicationTest
{
    partial class loginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginForm));
            this.loginBtn = new System.Windows.Forms.Button();
            this.usrTextBox = new System.Windows.Forms.TextBox();
            this.uLabel = new System.Windows.Forms.Label();
            this.plabel = new System.Windows.Forms.Label();
            this.ipLabel = new System.Windows.Forms.Label();
            this.portField = new System.Windows.Forms.NumericUpDown();
            this.portLabel = new System.Windows.Forms.Label();
            this.passField = new System.Windows.Forms.TextBox();
            this.ipBox = new System.Windows.Forms.TextBox();
            this.fnLabel = new System.Windows.Forms.Label();
            this.lnLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.portField)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginBtn
            // 
            resources.ApplyResources(this.loginBtn, "loginBtn");
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // usrTextBox
            // 
            resources.ApplyResources(this.usrTextBox, "usrTextBox");
            this.usrTextBox.Name = "usrTextBox";
            this.usrTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // uLabel
            // 
            resources.ApplyResources(this.uLabel, "uLabel");
            this.uLabel.Name = "uLabel";
            this.uLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // plabel
            // 
            resources.ApplyResources(this.plabel, "plabel");
            this.plabel.Name = "plabel";
            this.plabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // ipLabel
            // 
            resources.ApplyResources(this.ipLabel, "ipLabel");
            this.ipLabel.Name = "ipLabel";
            this.ipLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // portField
            // 
            resources.ApplyResources(this.portField, "portField");
            this.portField.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.portField.Name = "portField";
            // 
            // portLabel
            // 
            resources.ApplyResources(this.portLabel, "portLabel");
            this.portLabel.Name = "portLabel";
            this.portLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // passField
            // 
            resources.ApplyResources(this.passField, "passField");
            this.passField.Name = "passField";
            this.passField.UseSystemPasswordChar = true;
            this.passField.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // ipBox
            // 
            resources.ApplyResources(this.ipBox, "ipBox");
            this.ipBox.Name = "ipBox";
            this.ipBox.TextChanged += new System.EventHandler(this.ipBox_TextChanged);
            // 
            // fnLabel
            // 
            resources.ApplyResources(this.fnLabel, "fnLabel");
            this.fnLabel.Name = "fnLabel";
            // 
            // lnLabel
            // 
            resources.ApplyResources(this.lnLabel, "lnLabel");
            this.lnLabel.Name = "lnLabel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // fnameBox
            // 
            resources.ApplyResources(this.fnameBox, "fnameBox");
            this.fnameBox.Name = "fnameBox";
            // 
            // lnBox
            // 
            resources.ApplyResources(this.lnBox, "lnBox");
            this.lnBox.Name = "lnBox";
            // 
            // emailBox
            // 
            resources.ApplyResources(this.emailBox, "emailBox");
            this.emailBox.Name = "emailBox";
            // 
            // phoneBox
            // 
            resources.ApplyResources(this.phoneBox, "phoneBox");
            this.phoneBox.Name = "phoneBox";
            // 
            // addBtn
            // 
            resources.ApplyResources(this.addBtn, "addBtn");
            this.addBtn.Name = "addBtn";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // displayBtn
            // 
            resources.ApplyResources(this.displayBtn, "displayBtn");
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            resources.ApplyResources(this.statusLabel, "statusLabel");
            this.statusLabel.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // loginForm
            // 
            this.AcceptButton = this.loginBtn;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.lnBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.ipBox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.portField);
            this.Controls.Add(this.ipLabel);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.plabel);
            this.Controls.Add(this.uLabel);
            this.Controls.Add(this.usrTextBox);
            this.Controls.Add(this.loginBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "loginForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.portField)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label uLabel;
        private System.Windows.Forms.Label plabel;
        private System.Windows.Forms.Label ipLabel;
        private System.Windows.Forms.NumericUpDown portField;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox ipBox;
        public System.Windows.Forms.TextBox usrTextBox;
        public System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button displayBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}


namespace WindowsFormsApplicationTest
{
    partial class addUsr
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
            this.addBtn = new System.Windows.Forms.Button();
            this.usrLbl = new System.Windows.Forms.Label();
            this.passLbl = new System.Windows.Forms.Label();
            this.langLbl = new System.Windows.Forms.Label();
            this.roleLbl = new System.Windows.Forms.Label();
            this.usrBox = new System.Windows.Forms.TextBox();
            this.passBox = new System.Windows.Forms.TextBox();
            this.langBox = new System.Windows.Forms.ComboBox();
            this.roleBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(100, 213);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // usrLbl
            // 
            this.usrLbl.AutoSize = true;
            this.usrLbl.Location = new System.Drawing.Point(30, 31);
            this.usrLbl.Name = "usrLbl";
            this.usrLbl.Size = new System.Drawing.Size(55, 13);
            this.usrLbl.TabIndex = 1;
            this.usrLbl.Text = "Username";
            // 
            // passLbl
            // 
            this.passLbl.AutoSize = true;
            this.passLbl.Location = new System.Drawing.Point(30, 69);
            this.passLbl.Name = "passLbl";
            this.passLbl.Size = new System.Drawing.Size(53, 13);
            this.passLbl.TabIndex = 2;
            this.passLbl.Text = "Password";
            // 
            // langLbl
            // 
            this.langLbl.AutoSize = true;
            this.langLbl.Location = new System.Drawing.Point(30, 104);
            this.langLbl.Name = "langLbl";
            this.langLbl.Size = new System.Drawing.Size(55, 13);
            this.langLbl.TabIndex = 3;
            this.langLbl.Text = "Language";
            // 
            // roleLbl
            // 
            this.roleLbl.AutoSize = true;
            this.roleLbl.Location = new System.Drawing.Point(33, 145);
            this.roleLbl.Name = "roleLbl";
            this.roleLbl.Size = new System.Drawing.Size(29, 13);
            this.roleLbl.TabIndex = 4;
            this.roleLbl.Text = "Role";
            // 
            // usrBox
            // 
            this.usrBox.Location = new System.Drawing.Point(131, 31);
            this.usrBox.Name = "usrBox";
            this.usrBox.Size = new System.Drawing.Size(100, 20);
            this.usrBox.TabIndex = 5;
            // 
            // passBox
            // 
            this.passBox.Location = new System.Drawing.Point(131, 69);
            this.passBox.Name = "passBox";
            this.passBox.Size = new System.Drawing.Size(100, 20);
            this.passBox.TabIndex = 6;
            // 
            // langBox
            // 
            this.langBox.FormattingEnabled = true;
            this.langBox.Items.AddRange(new object[] {
            "English",
            "Chinese"});
            this.langBox.Location = new System.Drawing.Point(131, 104);
            this.langBox.Name = "langBox";
            this.langBox.Size = new System.Drawing.Size(121, 21);
            this.langBox.TabIndex = 7;
            // 
            // roleBox
            // 
            this.roleBox.FormattingEnabled = true;
            this.roleBox.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.roleBox.Items.AddRange(new object[] {
            "public",
            "Admin",
            "tetst1",
            "test2"});
            this.roleBox.Location = new System.Drawing.Point(131, 145);
            this.roleBox.Name = "roleBox";
            this.roleBox.Size = new System.Drawing.Size(121, 21);
            this.roleBox.TabIndex = 8;
            this.roleBox.SelectedIndexChanged += new System.EventHandler(this.roleBox_SelectedIndexChanged);
            // 
            // addUsr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.roleBox);
            this.Controls.Add(this.langBox);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.usrBox);
            this.Controls.Add(this.roleLbl);
            this.Controls.Add(this.langLbl);
            this.Controls.Add(this.passLbl);
            this.Controls.Add(this.usrLbl);
            this.Controls.Add(this.addBtn);
            this.Name = "addUsr";
            this.Text = "addUsr";
            this.Load += new System.EventHandler(this.addUsr_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label usrLbl;
        private System.Windows.Forms.Label passLbl;
        private System.Windows.Forms.Label langLbl;
        private System.Windows.Forms.Label roleLbl;
        private System.Windows.Forms.TextBox usrBox;
        private System.Windows.Forms.TextBox passBox;
        private System.Windows.Forms.ComboBox langBox;
        private System.Windows.Forms.ComboBox roleBox;
    }
}
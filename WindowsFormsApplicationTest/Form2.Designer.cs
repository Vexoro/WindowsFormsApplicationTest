namespace WindowsFormsApplicationTest
{
    partial class CustomerForm
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.fnLabel = new System.Windows.Forms.Label();
            this.lnLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.fnameBox = new System.Windows.Forms.TextBox();
            this.lnBox = new System.Windows.Forms.TextBox();
            this.phoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.displayBtn = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 219);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(253, 22);
            this.statusStrip1.TabIndex = 15;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(39, 17);
            this.statusLabel.Text = "Ready";
            // 
            // fnLabel
            // 
            this.fnLabel.AutoSize = true;
            this.fnLabel.Location = new System.Drawing.Point(36, 25);
            this.fnLabel.Name = "fnLabel";
            this.fnLabel.Size = new System.Drawing.Size(60, 13);
            this.fnLabel.TabIndex = 17;
            this.fnLabel.Text = "First Name:";
            this.fnLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // lnLabel
            // 
            this.lnLabel.AutoSize = true;
            this.lnLabel.Location = new System.Drawing.Point(36, 56);
            this.lnLabel.Name = "lnLabel";
            this.lnLabel.Size = new System.Drawing.Size(61, 13);
            this.lnLabel.TabIndex = 18;
            this.lnLabel.Text = "Last Name:";
            this.lnLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(36, 87);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 19;
            this.phoneLabel.Text = "Phone:";
            this.phoneLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Location = new System.Drawing.Point(36, 118);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(35, 13);
            this.emailLabel.TabIndex = 20;
            this.emailLabel.Text = "Email:";
            this.emailLabel.Click += new System.EventHandler(this.label5_Click);
            // 
            // fnameBox
            // 
            this.fnameBox.Location = new System.Drawing.Point(122, 22);
            this.fnameBox.Name = "fnameBox";
            this.fnameBox.Size = new System.Drawing.Size(100, 20);
            this.fnameBox.TabIndex = 21;
            this.fnameBox.TextChanged += new System.EventHandler(this.fnameBox_TextChanged);
            // 
            // lnBox
            // 
            this.lnBox.Location = new System.Drawing.Point(122, 53);
            this.lnBox.Name = "lnBox";
            this.lnBox.Size = new System.Drawing.Size(100, 20);
            this.lnBox.TabIndex = 22;
            this.lnBox.TextChanged += new System.EventHandler(this.lnBox_TextChanged);
            // 
            // phoneBox
            // 
            this.phoneBox.Location = new System.Drawing.Point(122, 84);
            this.phoneBox.Name = "phoneBox";
            this.phoneBox.Size = new System.Drawing.Size(100, 20);
            this.phoneBox.TabIndex = 23;
            this.phoneBox.TextChanged += new System.EventHandler(this.phoneBox_TextChanged);
            // 
            // emailBox
            // 
            this.emailBox.Location = new System.Drawing.Point(122, 115);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(100, 20);
            this.emailBox.TabIndex = 24;
            this.emailBox.TextChanged += new System.EventHandler(this.emailBox_TextChanged);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(35, 164);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 25;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // displayBtn
            // 
            this.displayBtn.Location = new System.Drawing.Point(138, 164);
            this.displayBtn.Name = "displayBtn";
            this.displayBtn.Size = new System.Drawing.Size(75, 23);
            this.displayBtn.TabIndex = 26;
            this.displayBtn.Text = "Display";
            this.displayBtn.UseVisualStyleBackColor = true;
            this.displayBtn.Click += new System.EventHandler(this.displayBtn_Click);
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(253, 241);
            this.Controls.Add(this.displayBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.phoneBox);
            this.Controls.Add(this.lnBox);
            this.Controls.Add(this.fnameBox);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.lnLabel);
            this.Controls.Add(this.fnLabel);
            this.Controls.Add(this.statusStrip1);
            this.Name = "CustomerForm";
            this.Text = "Register Customer";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
        private System.Windows.Forms.Label fnLabel;
        private System.Windows.Forms.Label lnLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox fnameBox;
        private System.Windows.Forms.TextBox lnBox;
        private System.Windows.Forms.TextBox phoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button displayBtn;
    }
}
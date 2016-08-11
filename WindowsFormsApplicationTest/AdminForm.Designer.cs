namespace WindowsFormsApplicationTest
{
    partial class AdminForm
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
            this.addUsr = new System.Windows.Forms.Button();
            this.manageUsr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addUsr
            // 
            this.addUsr.Location = new System.Drawing.Point(27, 213);
            this.addUsr.Name = "addUsr";
            this.addUsr.Size = new System.Drawing.Size(114, 23);
            this.addUsr.TabIndex = 0;
            this.addUsr.Text = "Add New User";
            this.addUsr.UseVisualStyleBackColor = true;
            this.addUsr.Click += new System.EventHandler(this.button1_Click);
            // 
            // manageUsr
            // 
            this.manageUsr.Location = new System.Drawing.Point(174, 213);
            this.manageUsr.Name = "manageUsr";
            this.manageUsr.Size = new System.Drawing.Size(75, 23);
            this.manageUsr.TabIndex = 1;
            this.manageUsr.Text = "Manage Users";
            this.manageUsr.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.manageUsr);
            this.Controls.Add(this.addUsr);
            this.Name = "AdminForm";
            this.Text = "Admin Form";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addUsr;
        private System.Windows.Forms.Button manageUsr;
    }
}

namespace WindowsFormsApp1
{
    partial class RemoveAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveAccount));
            this.lbRemoveAcc = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbAccount = new System.Windows.Forms.Label();
            this.tbUsernamedel = new System.Windows.Forms.TextBox();
            this.cbAccounttype_del = new System.Windows.Forms.ComboBox();
            this.btRemoveAcc = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btBack = new System.Windows.Forms.Button();
            this.PbUserlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRemoveAcc
            // 
            this.lbRemoveAcc.AutoSize = true;
            this.lbRemoveAcc.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRemoveAcc.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbRemoveAcc.Location = new System.Drawing.Point(328, 24);
            this.lbRemoveAcc.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbRemoveAcc.Name = "lbRemoveAcc";
            this.lbRemoveAcc.Size = new System.Drawing.Size(134, 16);
            this.lbRemoveAcc.TabIndex = 1;
            this.lbRemoveAcc.Text = "Remove Account";
            this.lbRemoveAcc.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbUsername.Location = new System.Drawing.Point(200, 108);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(117, 16);
            this.lbUsername.TabIndex = 2;
            this.lbUsername.Text = "Enter Username";
            // 
            // lbAccount
            // 
            this.lbAccount.AutoSize = true;
            this.lbAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbAccount.Location = new System.Drawing.Point(200, 163);
            this.lbAccount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbAccount.Name = "lbAccount";
            this.lbAccount.Size = new System.Drawing.Size(101, 16);
            this.lbAccount.TabIndex = 3;
            this.lbAccount.Text = "Account Type";
            // 
            // tbUsernamedel
            // 
            this.tbUsernamedel.Location = new System.Drawing.Point(317, 108);
            this.tbUsernamedel.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsernamedel.Name = "tbUsernamedel";
            this.tbUsernamedel.Size = new System.Drawing.Size(212, 20);
            this.tbUsernamedel.TabIndex = 4;
            // 
            // cbAccounttype_del
            // 
            this.cbAccounttype_del.FormattingEnabled = true;
            this.cbAccounttype_del.Items.AddRange(new object[] {
            "RM",
            "creator",
            "IT"});
            this.cbAccounttype_del.Location = new System.Drawing.Point(317, 163);
            this.cbAccounttype_del.Margin = new System.Windows.Forms.Padding(2);
            this.cbAccounttype_del.Name = "cbAccounttype_del";
            this.cbAccounttype_del.Size = new System.Drawing.Size(212, 21);
            this.cbAccounttype_del.TabIndex = 5;
            // 
            // btRemoveAcc
            // 
            this.btRemoveAcc.BackColor = System.Drawing.Color.Red;
            this.btRemoveAcc.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btRemoveAcc.Location = new System.Drawing.Point(395, 240);
            this.btRemoveAcc.Margin = new System.Windows.Forms.Padding(2);
            this.btRemoveAcc.Name = "btRemoveAcc";
            this.btRemoveAcc.Size = new System.Drawing.Size(134, 28);
            this.btRemoveAcc.TabIndex = 6;
            this.btRemoveAcc.Text = "Remove Account";
            this.btRemoveAcc.UseVisualStyleBackColor = false;
            this.btRemoveAcc.Click += new System.EventHandler(this.btRemoveAcc_Click);
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Red;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btClose.Location = new System.Drawing.Point(555, -1);
            this.btClose.Margin = new System.Windows.Forms.Padding(2);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(30, 27);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "X";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBack.Location = new System.Drawing.Point(1, 289);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(177, 39);
            this.btBack.TabIndex = 8;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            // 
            // PbUserlogo
            // 
            this.PbUserlogo.Image = ((System.Drawing.Image)(resources.GetObject("PbUserlogo.Image")));
            this.PbUserlogo.Location = new System.Drawing.Point(1, -1);
            this.PbUserlogo.Name = "PbUserlogo";
            this.PbUserlogo.Size = new System.Drawing.Size(177, 129);
            this.PbUserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserlogo.TabIndex = 9;
            this.PbUserlogo.TabStop = false;
            // 
            // RemoveAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(586, 327);
            this.Controls.Add(this.PbUserlogo);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btRemoveAcc);
            this.Controls.Add(this.cbAccounttype_del);
            this.Controls.Add(this.tbUsernamedel);
            this.Controls.Add(this.lbAccount);
            this.Controls.Add(this.lbUsername);
            this.Controls.Add(this.lbRemoveAcc);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "RemoveAccount";
            this.Text = "RemoveAccount";
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbRemoveAcc;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbAccount;
        private System.Windows.Forms.TextBox tbUsernamedel;
        private System.Windows.Forms.ComboBox cbAccounttype_del;
        private System.Windows.Forms.Button btRemoveAcc;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.PictureBox PbUserlogo;
    }
}
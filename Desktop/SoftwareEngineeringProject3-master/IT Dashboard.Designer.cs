
namespace WindowsFormsApp1
{
    partial class IT_Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IT_Dashboard));
            this.lbDashboard = new System.Windows.Forms.Label();
            this.btCreateAccount = new System.Windows.Forms.Button();
            this.btCreatePassword = new System.Windows.Forms.Button();
            this.bt = new System.Windows.Forms.Button();
            this.bt_Remove_account = new System.Windows.Forms.Button();
            this.pnChangepassword = new System.Windows.Forms.Panel();
            this.tbConPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btSave = new System.Windows.Forms.Button();
            this.lbconfirmPassword = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbusername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btBack = new System.Windows.Forms.Button();
            this.PbUserlogo = new System.Windows.Forms.PictureBox();
            this.pnChangepassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbDashboard
            // 
            this.lbDashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.lbDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDashboard.Location = new System.Drawing.Point(-2, 117);
            this.lbDashboard.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDashboard.Name = "lbDashboard";
            this.lbDashboard.Size = new System.Drawing.Size(194, 37);
            this.lbDashboard.TabIndex = 2;
            this.lbDashboard.Text = "Dashboard";
            this.lbDashboard.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbDashboard.Click += new System.EventHandler(this.label1_Click);
            // 
            // btCreateAccount
            // 
            this.btCreateAccount.BackColor = System.Drawing.Color.SteelBlue;
            this.btCreateAccount.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCreateAccount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCreateAccount.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreateAccount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCreateAccount.Location = new System.Drawing.Point(0, 148);
            this.btCreateAccount.Margin = new System.Windows.Forms.Padding(2);
            this.btCreateAccount.Name = "btCreateAccount";
            this.btCreateAccount.Size = new System.Drawing.Size(192, 36);
            this.btCreateAccount.TabIndex = 4;
            this.btCreateAccount.Text = "Create Account";
            this.btCreateAccount.UseVisualStyleBackColor = false;
            this.btCreateAccount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btCreatePassword
            // 
            this.btCreatePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.btCreatePassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btCreatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCreatePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCreatePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btCreatePassword.Location = new System.Drawing.Point(0, 179);
            this.btCreatePassword.Margin = new System.Windows.Forms.Padding(2);
            this.btCreatePassword.Name = "btCreatePassword";
            this.btCreatePassword.Size = new System.Drawing.Size(192, 36);
            this.btCreatePassword.TabIndex = 5;
            this.btCreatePassword.Text = "Reset Password";
            this.btCreatePassword.UseVisualStyleBackColor = false;
            this.btCreatePassword.Click += new System.EventHandler(this.btCreatePassword_Click);
            // 
            // bt
            // 
            this.bt.BackColor = System.Drawing.Color.Red;
            this.bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt.Location = new System.Drawing.Point(559, 0);
            this.bt.Margin = new System.Windows.Forms.Padding(2);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(41, 27);
            this.bt.TabIndex = 6;
            this.bt.Text = "X";
            this.bt.UseVisualStyleBackColor = false;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // bt_Remove_account
            // 
            this.bt_Remove_account.BackColor = System.Drawing.Color.SteelBlue;
            this.bt_Remove_account.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bt_Remove_account.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bt_Remove_account.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Remove_account.ForeColor = System.Drawing.SystemColors.ControlText;
            this.bt_Remove_account.Location = new System.Drawing.Point(0, 207);
            this.bt_Remove_account.Margin = new System.Windows.Forms.Padding(2);
            this.bt_Remove_account.Name = "bt_Remove_account";
            this.bt_Remove_account.Size = new System.Drawing.Size(192, 36);
            this.bt_Remove_account.TabIndex = 7;
            this.bt_Remove_account.Text = "Remove Account";
            this.bt_Remove_account.UseVisualStyleBackColor = false;
            this.bt_Remove_account.Click += new System.EventHandler(this.bt_Remove_account_Click);
            // 
            // pnChangepassword
            // 
            this.pnChangepassword.Controls.Add(this.tbConPassword);
            this.pnChangepassword.Controls.Add(this.tbUsername);
            this.pnChangepassword.Controls.Add(this.tbPassword);
            this.pnChangepassword.Controls.Add(this.btSave);
            this.pnChangepassword.Controls.Add(this.lbconfirmPassword);
            this.pnChangepassword.Controls.Add(this.label2);
            this.pnChangepassword.Controls.Add(this.lbusername);
            this.pnChangepassword.Controls.Add(this.label1);
            this.pnChangepassword.Location = new System.Drawing.Point(194, 1);
            this.pnChangepassword.Margin = new System.Windows.Forms.Padding(2);
            this.pnChangepassword.Name = "pnChangepassword";
            this.pnChangepassword.Size = new System.Drawing.Size(361, 364);
            this.pnChangepassword.TabIndex = 9;
            // 
            // tbConPassword
            // 
            this.tbConPassword.Location = new System.Drawing.Point(153, 206);
            this.tbConPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbConPassword.Name = "tbConPassword";
            this.tbConPassword.Size = new System.Drawing.Size(182, 20);
            this.tbConPassword.TabIndex = 9;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(153, 116);
            this.tbUsername.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(182, 20);
            this.tbUsername.TabIndex = 8;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(153, 159);
            this.tbPassword.Margin = new System.Windows.Forms.Padding(2);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(182, 20);
            this.tbPassword.TabIndex = 7;
            // 
            // btSave
            // 
            this.btSave.BackColor = System.Drawing.Color.SteelBlue;
            this.btSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSave.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btSave.Location = new System.Drawing.Point(208, 301);
            this.btSave.Margin = new System.Windows.Forms.Padding(2);
            this.btSave.Name = "btSave";
            this.btSave.Size = new System.Drawing.Size(126, 31);
            this.btSave.TabIndex = 5;
            this.btSave.Text = "Save";
            this.btSave.UseVisualStyleBackColor = false;
            this.btSave.Click += new System.EventHandler(this.btSave_Click);
            // 
            // lbconfirmPassword
            // 
            this.lbconfirmPassword.AutoSize = true;
            this.lbconfirmPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbconfirmPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbconfirmPassword.Location = new System.Drawing.Point(16, 206);
            this.lbconfirmPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbconfirmPassword.Name = "lbconfirmPassword";
            this.lbconfirmPassword.Size = new System.Drawing.Size(132, 16);
            this.lbconfirmPassword.TabIndex = 4;
            this.lbconfirmPassword.Text = "Confirm Password\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(16, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Enter Password\r\n";
            // 
            // lbusername
            // 
            this.lbusername.AutoSize = true;
            this.lbusername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbusername.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbusername.Location = new System.Drawing.Point(16, 116);
            this.lbusername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbusername.Name = "lbusername";
            this.lbusername.Size = new System.Drawing.Size(117, 16);
            this.lbusername.TabIndex = 2;
            this.lbusername.Text = "Enter Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(153, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset Password";
            // 
            // btBack
            // 
            this.btBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btBack.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btBack.Location = new System.Drawing.Point(0, 334);
            this.btBack.Margin = new System.Windows.Forms.Padding(2);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(192, 31);
            this.btBack.TabIndex = 10;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = false;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // PbUserlogo
            // 
            this.PbUserlogo.Image = ((System.Drawing.Image)(resources.GetObject("PbUserlogo.Image")));
            this.PbUserlogo.Location = new System.Drawing.Point(12, 12);
            this.PbUserlogo.Name = "PbUserlogo";
            this.PbUserlogo.Size = new System.Drawing.Size(175, 100);
            this.PbUserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserlogo.TabIndex = 11;
            this.PbUserlogo.TabStop = false;
            // 
            // IT_Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.PbUserlogo);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.pnChangepassword);
            this.Controls.Add(this.bt_Remove_account);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.btCreatePassword);
            this.Controls.Add(this.btCreateAccount);
            this.Controls.Add(this.lbDashboard);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IT_Dashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.IT_Dashboard_Load);
            this.pnChangepassword.ResumeLayout(false);
            this.pnChangepassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbDashboard;
        private System.Windows.Forms.Button btCreateAccount;
        private System.Windows.Forms.Button btCreatePassword;
        private System.Windows.Forms.Button bt;
        private System.Windows.Forms.Button bt_Remove_account;
        private System.Windows.Forms.Panel pnChangepassword;
        private System.Windows.Forms.TextBox tbConPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Label lbconfirmPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbusername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.PictureBox PbUserlogo;
    }
}
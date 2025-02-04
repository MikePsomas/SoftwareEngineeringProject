
namespace WindowsFormsApp1
{
    partial class ForgotPassoword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassoword));
            this.btRevealResetCode = new System.Windows.Forms.Button();
            this.BtResetPassword = new System.Windows.Forms.Button();
            this.tbResetCode = new System.Windows.Forms.TextBox();
            this.LbUsername = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.PbLogo1 = new System.Windows.Forms.PictureBox();
            this.tbConfirmNewPassword = new System.Windows.Forms.TextBox();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo1)).BeginInit();
            this.SuspendLayout();
            // 
            // btRevealResetCode
            // 
            this.btRevealResetCode.BackColor = System.Drawing.Color.SteelBlue;
            this.btRevealResetCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRevealResetCode.FlatAppearance.BorderSize = 0;
            this.btRevealResetCode.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btRevealResetCode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btRevealResetCode.Location = new System.Drawing.Point(103, 323);
            this.btRevealResetCode.Name = "btRevealResetCode";
            this.btRevealResetCode.Size = new System.Drawing.Size(177, 47);
            this.btRevealResetCode.TabIndex = 1;
            this.btRevealResetCode.Text = "Reveal Reset Code";
            this.btRevealResetCode.UseVisualStyleBackColor = false;
            this.btRevealResetCode.Click += new System.EventHandler(this.btRevealResetCode_Click);
            // 
            // BtResetPassword
            // 
            this.BtResetPassword.BackColor = System.Drawing.Color.SteelBlue;
            this.BtResetPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtResetPassword.FlatAppearance.BorderSize = 0;
            this.BtResetPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtResetPassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtResetPassword.Location = new System.Drawing.Point(367, 323);
            this.BtResetPassword.Name = "BtResetPassword";
            this.BtResetPassword.Size = new System.Drawing.Size(151, 47);
            this.BtResetPassword.TabIndex = 2;
            this.BtResetPassword.Text = "Reset Password";
            this.BtResetPassword.UseVisualStyleBackColor = false;
            this.BtResetPassword.Click += new System.EventHandler(this.btResetPassword_Click);
            // 
            // tbResetCode
            // 
            this.tbResetCode.Location = new System.Drawing.Point(184, 110);
            this.tbResetCode.Name = "tbResetCode";
            this.tbResetCode.Size = new System.Drawing.Size(199, 20);
            this.tbResetCode.TabIndex = 7;
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(100, 146);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(78, 15);
            this.LbUsername.TabIndex = 8;
            this.LbUsername.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(93, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Reset Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(71, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "New Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Confirm New Password:";
            // 
            // PbLogo1
            // 
            this.PbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo1.Image")));
            this.PbLogo1.Location = new System.Drawing.Point(248, 12);
            this.PbLogo1.Name = "PbLogo1";
            this.PbLogo1.Size = new System.Drawing.Size(270, 92);
            this.PbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo1.TabIndex = 18;
            this.PbLogo1.TabStop = false;
            // 
            // tbConfirmNewPassword
            // 
            this.tbConfirmNewPassword.Location = new System.Drawing.Point(184, 241);
            this.tbConfirmNewPassword.Name = "tbConfirmNewPassword";
            this.tbConfirmNewPassword.Size = new System.Drawing.Size(248, 20);
            this.tbConfirmNewPassword.TabIndex = 19;
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(184, 194);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.Size = new System.Drawing.Size(248, 20);
            this.tbNewPassword.TabIndex = 20;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(184, 146);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(248, 20);
            this.tbUsername.TabIndex = 21;
            // 
            // ForgotPassoword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.tbConfirmNewPassword);
            this.Controls.Add(this.PbLogo1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.tbResetCode);
            this.Controls.Add(this.BtResetPassword);
            this.Controls.Add(this.btRevealResetCode);
            this.Name = "ForgotPassoword";
            this.Text = "ForgotPassowrd";
            this.Load += new System.EventHandler(this.ForgotPassowrd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btRevealResetCode;
        private System.Windows.Forms.Button BtResetPassword;
        private System.Windows.Forms.TextBox tbResetCode;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox PbLogo1;
        private System.Windows.Forms.TextBox tbConfirmNewPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.TextBox tbUsername;
    }
}

namespace WindowsFormsApp1
{
    partial class UpdatePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdatePassword));
            this.TbNewPassword = new System.Windows.Forms.TextBox();
            this.TbNewPasswordConfirm = new System.Windows.Forms.TextBox();
            this.BtUpdatePassword = new System.Windows.Forms.Button();
            this.LbRepeatNewPassword = new System.Windows.Forms.LinkLabel();
            this.LbNewPassword = new System.Windows.Forms.LinkLabel();
            this.TbOldPassword = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LbOldPassword = new System.Windows.Forms.LinkLabel();
            this.PbUserlogo = new System.Windows.Forms.PictureBox();
            this.btnGoBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TbNewPassword
            // 
            this.TbNewPassword.Location = new System.Drawing.Point(346, 237);
            this.TbNewPassword.Name = "TbNewPassword";
            this.TbNewPassword.Size = new System.Drawing.Size(237, 20);
            this.TbNewPassword.TabIndex = 41;
            // 
            // TbNewPasswordConfirm
            // 
            this.TbNewPasswordConfirm.Location = new System.Drawing.Point(346, 291);
            this.TbNewPasswordConfirm.Name = "TbNewPasswordConfirm";
            this.TbNewPasswordConfirm.Size = new System.Drawing.Size(237, 20);
            this.TbNewPasswordConfirm.TabIndex = 40;
            // 
            // BtUpdatePassword
            // 
            this.BtUpdatePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.BtUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtUpdatePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpdatePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtUpdatePassword.Location = new System.Drawing.Point(368, 380);
            this.BtUpdatePassword.Name = "BtUpdatePassword";
            this.BtUpdatePassword.Size = new System.Drawing.Size(215, 35);
            this.BtUpdatePassword.TabIndex = 39;
            this.BtUpdatePassword.Text = "Update Password";
            this.BtUpdatePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtUpdatePassword.UseVisualStyleBackColor = false;
            this.BtUpdatePassword.Click += new System.EventHandler(this.BtUpdatePassword_Click);
            // 
            // LbRepeatNewPassword
            // 
            this.LbRepeatNewPassword.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.LbRepeatNewPassword.AutoSize = true;
            this.LbRepeatNewPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbRepeatNewPassword.LinkColor = System.Drawing.Color.Black;
            this.LbRepeatNewPassword.Location = new System.Drawing.Point(114, 289);
            this.LbRepeatNewPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LbRepeatNewPassword.Name = "LbRepeatNewPassword";
            this.LbRepeatNewPassword.Size = new System.Drawing.Size(222, 22);
            this.LbRepeatNewPassword.TabIndex = 38;
            this.LbRepeatNewPassword.TabStop = true;
            this.LbRepeatNewPassword.Text = "Repeat New Password:";
            // 
            // LbNewPassword
            // 
            this.LbNewPassword.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.LbNewPassword.AutoSize = true;
            this.LbNewPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNewPassword.LinkColor = System.Drawing.Color.Black;
            this.LbNewPassword.Location = new System.Drawing.Point(185, 237);
            this.LbNewPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LbNewPassword.Name = "LbNewPassword";
            this.LbNewPassword.Size = new System.Drawing.Size(151, 22);
            this.LbNewPassword.TabIndex = 37;
            this.LbNewPassword.TabStop = true;
            this.LbNewPassword.Text = "New Password:";
            // 
            // TbOldPassword
            // 
            this.TbOldPassword.Location = new System.Drawing.Point(346, 188);
            this.TbOldPassword.Name = "TbOldPassword";
            this.TbOldPassword.Size = new System.Drawing.Size(237, 20);
            this.TbOldPassword.TabIndex = 36;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(221, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(389, 162);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 34;
            this.pictureBox2.TabStop = false;
            // 
            // LbOldPassword
            // 
            this.LbOldPassword.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.LbOldPassword.AutoSize = true;
            this.LbOldPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbOldPassword.LinkColor = System.Drawing.Color.Black;
            this.LbOldPassword.Location = new System.Drawing.Point(193, 184);
            this.LbOldPassword.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.LbOldPassword.Name = "LbOldPassword";
            this.LbOldPassword.Size = new System.Drawing.Size(143, 22);
            this.LbOldPassword.TabIndex = 33;
            this.LbOldPassword.TabStop = true;
            this.LbOldPassword.Text = "Old Password:";
            this.LbOldPassword.UseMnemonic = false;
            // 
            // PbUserlogo
            // 
            this.PbUserlogo.Image = ((System.Drawing.Image)(resources.GetObject("PbUserlogo.Image")));
            this.PbUserlogo.Location = new System.Drawing.Point(12, 12);
            this.PbUserlogo.Name = "PbUserlogo";
            this.PbUserlogo.Size = new System.Drawing.Size(161, 136);
            this.PbUserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserlogo.TabIndex = 42;
            this.PbUserlogo.TabStop = false;
            // 
            // btnGoBack
            // 
            this.btnGoBack.BackColor = System.Drawing.Color.SteelBlue;
            this.btnGoBack.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGoBack.Location = new System.Drawing.Point(679, 23);
            this.btnGoBack.Name = "btnGoBack";
            this.btnGoBack.Size = new System.Drawing.Size(109, 60);
            this.btnGoBack.TabIndex = 43;
            this.btnGoBack.Text = "Back";
            this.btnGoBack.UseVisualStyleBackColor = false;
            this.btnGoBack.Click += new System.EventHandler(this.btnGoBack_Click);
            // 
            // UpdatePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGoBack);
            this.Controls.Add(this.PbUserlogo);
            this.Controls.Add(this.TbNewPassword);
            this.Controls.Add(this.TbNewPasswordConfirm);
            this.Controls.Add(this.BtUpdatePassword);
            this.Controls.Add(this.LbRepeatNewPassword);
            this.Controls.Add(this.LbNewPassword);
            this.Controls.Add(this.TbOldPassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.LbOldPassword);
            this.Name = "UpdatePassword";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.UpdatePassword_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbNewPassword;
        private System.Windows.Forms.TextBox TbNewPasswordConfirm;
        private System.Windows.Forms.Button BtUpdatePassword;
        private System.Windows.Forms.LinkLabel LbRepeatNewPassword;
        private System.Windows.Forms.LinkLabel LbNewPassword;
        private System.Windows.Forms.TextBox TbOldPassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel LbOldPassword;
        private System.Windows.Forms.PictureBox PbUserlogo;
        private System.Windows.Forms.Button btnGoBack;
    }
}
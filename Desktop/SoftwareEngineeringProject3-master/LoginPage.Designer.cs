
namespace WindowsFormsApp1
{
    partial class LoginPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginPage));
            this.btLogin = new System.Windows.Forms.Button();
            this.LbUsername = new System.Windows.Forms.Label();
            this.LbPassword = new System.Windows.Forms.Label();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.BtForgotPass = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.PbLogo1 = new System.Windows.Forms.PictureBox();
            this.PbPasswordLogo = new System.Windows.Forms.PictureBox();
            this.PbUserlogo = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPasswordLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.SteelBlue;
            this.btLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btLogin.Location = new System.Drawing.Point(443, 347);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(151, 39);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // LbUsername
            // 
            this.LbUsername.AutoSize = true;
            this.LbUsername.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbUsername.Location = new System.Drawing.Point(296, 107);
            this.LbUsername.Name = "LbUsername";
            this.LbUsername.Size = new System.Drawing.Size(78, 15);
            this.LbUsername.TabIndex = 7;
            this.LbUsername.Text = "Username:";
            this.LbUsername.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // LbPassword
            // 
            this.LbPassword.AutoSize = true;
            this.LbPassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPassword.Location = new System.Drawing.Point(296, 230);
            this.LbPassword.Name = "LbPassword";
            this.LbPassword.Size = new System.Drawing.Size(75, 15);
            this.LbPassword.TabIndex = 8;
            this.LbPassword.Text = "Password:";
            this.LbPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // tbUsername
            // 
            this.tbUsername.BackColor = System.Drawing.SystemColors.Info;
            this.tbUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbUsername.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(300, 137);
            this.tbUsername.Multiline = true;
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(294, 27);
            this.tbUsername.TabIndex = 9;
            this.tbUsername.TextChanged += new System.EventHandler(this.txtUsername_TextChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.BackColor = System.Drawing.SystemColors.Info;
            this.tbPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbPassword.Font = new System.Drawing.Font("Arial Narrow", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(299, 261);
            this.tbPassword.Multiline = true;
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(294, 26);
            this.tbPassword.TabIndex = 10;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // BtForgotPass
            // 
            this.BtForgotPass.BackColor = System.Drawing.Color.LightGray;
            this.BtForgotPass.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtForgotPass.Location = new System.Drawing.Point(443, 304);
            this.BtForgotPass.Name = "BtForgotPass";
            this.BtForgotPass.Size = new System.Drawing.Size(151, 37);
            this.BtForgotPass.TabIndex = 11;
            this.BtForgotPass.Text = "Forgot password?";
            this.BtForgotPass.UseVisualStyleBackColor = false;
            this.BtForgotPass.Click += new System.EventHandler(this.BtForgotPassword_Click);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Red;
            this.ExitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(754, -2);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(47, 34);
            this.ExitButton.TabIndex = 15;
            this.ExitButton.Text = "X";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.BtExit_Click);
            // 
            // PbLogo1
            // 
            this.PbLogo1.Image = ((System.Drawing.Image)(resources.GetObject("PbLogo1.Image")));
            this.PbLogo1.Location = new System.Drawing.Point(309, 12);
            this.PbLogo1.Name = "PbLogo1";
            this.PbLogo1.Size = new System.Drawing.Size(270, 92);
            this.PbLogo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbLogo1.TabIndex = 17;
            this.PbLogo1.TabStop = false;
            // 
            // PbPasswordLogo
            // 
            this.PbPasswordLogo.Image = ((System.Drawing.Image)(resources.GetObject("PbPasswordLogo.Image")));
            this.PbPasswordLogo.Location = new System.Drawing.Point(213, 251);
            this.PbPasswordLogo.Name = "PbPasswordLogo";
            this.PbPasswordLogo.Size = new System.Drawing.Size(68, 36);
            this.PbPasswordLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbPasswordLogo.TabIndex = 5;
            this.PbPasswordLogo.TabStop = false;
            this.PbPasswordLogo.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // PbUserlogo
            // 
            this.PbUserlogo.Image = ((System.Drawing.Image)(resources.GetObject("PbUserlogo.Image")));
            this.PbUserlogo.Location = new System.Drawing.Point(213, 123);
            this.PbUserlogo.Name = "PbUserlogo";
            this.PbUserlogo.Size = new System.Drawing.Size(68, 41);
            this.PbUserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserlogo.TabIndex = 3;
            this.PbUserlogo.TabStop = false;
            this.PbUserlogo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Location = new System.Drawing.Point(599, 265);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(54, 17);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "Show";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.PbLogo1);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.BtForgotPass);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.LbPassword);
            this.Controls.Add(this.LbUsername);
            this.Controls.Add(this.PbPasswordLogo);
            this.Controls.Add(this.PbUserlogo);
            this.Controls.Add(this.btLogin);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.White;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbLogo1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbPasswordLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.PictureBox PbUserlogo;
        private System.Windows.Forms.PictureBox PbPasswordLogo;
        private System.Windows.Forms.Label LbUsername;
        private System.Windows.Forms.Label LbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button BtForgotPass;
        private System.Windows.Forms.Button ExitButton;
        private System.Windows.Forms.PictureBox PbLogo1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}



namespace WindowsFormsApp1
{
    partial class CreatorDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreatorDashboard));
            this.BtnDeleteIdeas = new System.Windows.Forms.Button();
            this.BtnViewIdeas = new System.Windows.Forms.Button();
            this.BtnCreateNewIdeas = new System.Windows.Forms.Button();
            this.BtnDashboard = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.BtUpdatePassword = new System.Windows.Forms.Button();
            this.PbUserlogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnDeleteIdeas
            // 
            this.BtnDeleteIdeas.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDeleteIdeas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDeleteIdeas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDeleteIdeas.Location = new System.Drawing.Point(0, 353);
            this.BtnDeleteIdeas.Name = "BtnDeleteIdeas";
            this.BtnDeleteIdeas.Size = new System.Drawing.Size(230, 50);
            this.BtnDeleteIdeas.TabIndex = 4;
            this.BtnDeleteIdeas.Text = "Delete Ideas";
            this.BtnDeleteIdeas.UseVisualStyleBackColor = false;
            this.BtnDeleteIdeas.Visible = false;
            this.BtnDeleteIdeas.Click += new System.EventHandler(this.DeleteIdeas_Click);
            // 
            // BtnViewIdeas
            // 
            this.BtnViewIdeas.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnViewIdeas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewIdeas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnViewIdeas.Location = new System.Drawing.Point(0, 308);
            this.BtnViewIdeas.Name = "BtnViewIdeas";
            this.BtnViewIdeas.Size = new System.Drawing.Size(230, 50);
            this.BtnViewIdeas.TabIndex = 3;
            this.BtnViewIdeas.Text = "View Ideas";
            this.BtnViewIdeas.UseVisualStyleBackColor = false;
            this.BtnViewIdeas.Visible = false;
            this.BtnViewIdeas.Click += new System.EventHandler(this.ViewIdeas_Click);
            // 
            // BtnCreateNewIdeas
            // 
            this.BtnCreateNewIdeas.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnCreateNewIdeas.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateNewIdeas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnCreateNewIdeas.Location = new System.Drawing.Point(0, 262);
            this.BtnCreateNewIdeas.Name = "BtnCreateNewIdeas";
            this.BtnCreateNewIdeas.Size = new System.Drawing.Size(230, 50);
            this.BtnCreateNewIdeas.TabIndex = 2;
            this.BtnCreateNewIdeas.Text = "Create New Ideas";
            this.BtnCreateNewIdeas.UseVisualStyleBackColor = false;
            this.BtnCreateNewIdeas.Visible = false;
            this.BtnCreateNewIdeas.Click += new System.EventHandler(this.CreateNewIdeas_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.BtnDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtnDashboard.Image")));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 217);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.Size = new System.Drawing.Size(230, 53);
            this.BtnDashboard.TabIndex = 1;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtnDashboard.UseVisualStyleBackColor = false;
            this.BtnDashboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.Red;
            this.btExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btExit.ForeColor = System.Drawing.Color.Black;
            this.btExit.Location = new System.Drawing.Point(811, 0);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(57, 35);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "X";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // BtUpdatePassword
            // 
            this.BtUpdatePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.BtUpdatePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpdatePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtUpdatePassword.Location = new System.Drawing.Point(0, 399);
            this.BtUpdatePassword.Name = "BtUpdatePassword";
            this.BtUpdatePassword.Size = new System.Drawing.Size(230, 50);
            this.BtUpdatePassword.TabIndex = 15;
            this.BtUpdatePassword.Text = "Update Password";
            this.BtUpdatePassword.UseVisualStyleBackColor = false;
            this.BtUpdatePassword.Visible = false;
            this.BtUpdatePassword.Click += new System.EventHandler(this.BtUpdatePassword_Click);
            // 
            // PbUserlogo
            // 
            this.PbUserlogo.Image = ((System.Drawing.Image)(resources.GetObject("PbUserlogo.Image")));
            this.PbUserlogo.Location = new System.Drawing.Point(12, 12);
            this.PbUserlogo.Name = "PbUserlogo";
            this.PbUserlogo.Size = new System.Drawing.Size(176, 144);
            this.PbUserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserlogo.TabIndex = 16;
            this.PbUserlogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(267, 74);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(501, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 17;
            this.pictureBox2.TabStop = false;
            // 
            // CreatorDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(858, 466);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.PbUserlogo);
            this.Controls.Add(this.BtUpdatePassword);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.BtnDeleteIdeas);
            this.Controls.Add(this.BtnViewIdeas);
            this.Controls.Add(this.BtnDashboard);
            this.Controls.Add(this.BtnCreateNewIdeas);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "CreatorDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Creator Dashboard";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveBorder;
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button BtnDeleteIdeas;
        private System.Windows.Forms.Button BtnViewIdeas;
        private System.Windows.Forms.Button BtnDashboard;
        private System.Windows.Forms.Button BtnCreateNewIdeas;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.Button BtUpdatePassword;
        private System.Windows.Forms.PictureBox PbUserlogo;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

namespace WindowsFormsApp1
{
    partial class RmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RmDashboard));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.BtClientsProfile = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.BtAssignIdeas = new System.Windows.Forms.Button();
            this.BtDashboard = new System.Windows.Forms.Button();
            this.BtNewIdeas = new System.Windows.Forms.Button();
            this.BtAddClient = new System.Windows.Forms.Button();
            this.BtUpdatePassword = new System.Windows.Forms.Button();
            this.PbUserlogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(260, 101);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(501, 196);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 13;
            this.pictureBox2.TabStop = false;
            // 
            // BtClientsProfile
            // 
            this.BtClientsProfile.BackColor = System.Drawing.Color.SteelBlue;
            this.BtClientsProfile.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtClientsProfile.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtClientsProfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtClientsProfile.Location = new System.Drawing.Point(-1, 362);
            this.BtClientsProfile.Name = "BtClientsProfile";
            this.BtClientsProfile.Size = new System.Drawing.Size(215, 34);
            this.BtClientsProfile.TabIndex = 11;
            this.BtClientsProfile.Text = "View Clients Profile";
            this.BtClientsProfile.UseVisualStyleBackColor = false;
            this.BtClientsProfile.Visible = false;
            this.BtClientsProfile.Click += new System.EventHandler(this.ClientsProfile_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.SystemColors.Highlight;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(3, 204);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(109, 22);
            this.linkLabel1.TabIndex = 7;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Username:";
            // 
            // BtAssignIdeas
            // 
            this.BtAssignIdeas.BackColor = System.Drawing.Color.SteelBlue;
            this.BtAssignIdeas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtAssignIdeas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAssignIdeas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtAssignIdeas.Location = new System.Drawing.Point(-1, 323);
            this.BtAssignIdeas.Name = "BtAssignIdeas";
            this.BtAssignIdeas.Size = new System.Drawing.Size(215, 33);
            this.BtAssignIdeas.TabIndex = 10;
            this.BtAssignIdeas.Text = "Assign Ideas";
            this.BtAssignIdeas.UseVisualStyleBackColor = false;
            this.BtAssignIdeas.Visible = false;
            this.BtAssignIdeas.Click += new System.EventHandler(this.AssignIdeas_Click);
            // 
            // BtDashboard
            // 
            this.BtDashboard.BackColor = System.Drawing.Color.SteelBlue;
            this.BtDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtDashboard.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtDashboard.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtDashboard.Image = ((System.Drawing.Image)(resources.GetObject("BtDashboard.Image")));
            this.BtDashboard.Location = new System.Drawing.Point(-1, 235);
            this.BtDashboard.Name = "BtDashboard";
            this.BtDashboard.Size = new System.Drawing.Size(215, 38);
            this.BtDashboard.TabIndex = 8;
            this.BtDashboard.Text = "    Dashboard";
            this.BtDashboard.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.BtDashboard.UseVisualStyleBackColor = false;
            this.BtDashboard.Click += new System.EventHandler(this.Dashboard_Click_1);
            // 
            // BtNewIdeas
            // 
            this.BtNewIdeas.BackColor = System.Drawing.Color.SteelBlue;
            this.BtNewIdeas.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtNewIdeas.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtNewIdeas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtNewIdeas.Location = new System.Drawing.Point(-1, 279);
            this.BtNewIdeas.Name = "BtNewIdeas";
            this.BtNewIdeas.Size = new System.Drawing.Size(215, 36);
            this.BtNewIdeas.TabIndex = 9;
            this.BtNewIdeas.Text = "View New Ideas";
            this.BtNewIdeas.UseVisualStyleBackColor = false;
            this.BtNewIdeas.Visible = false;
            this.BtNewIdeas.Click += new System.EventHandler(this.NewIdeas_Click_1);
            // 
            // BtAddClient
            // 
            this.BtAddClient.BackColor = System.Drawing.Color.SteelBlue;
            this.BtAddClient.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtAddClient.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAddClient.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtAddClient.Location = new System.Drawing.Point(-1, 411);
            this.BtAddClient.Name = "BtAddClient";
            this.BtAddClient.Size = new System.Drawing.Size(215, 35);
            this.BtAddClient.TabIndex = 14;
            this.BtAddClient.Text = "Add Client";
            this.BtAddClient.UseVisualStyleBackColor = false;
            this.BtAddClient.Visible = false;
            this.BtAddClient.Click += new System.EventHandler(this.BtAddClient_Click);
            // 
            // BtUpdatePassword
            // 
            this.BtUpdatePassword.BackColor = System.Drawing.Color.SteelBlue;
            this.BtUpdatePassword.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtUpdatePassword.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUpdatePassword.ForeColor = System.Drawing.SystemColors.ControlText;
            this.BtUpdatePassword.Location = new System.Drawing.Point(-1, 468);
            this.BtUpdatePassword.Name = "BtUpdatePassword";
            this.BtUpdatePassword.Size = new System.Drawing.Size(215, 35);
            this.BtUpdatePassword.TabIndex = 16;
            this.BtUpdatePassword.Text = "Update Password";
            this.BtUpdatePassword.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BtUpdatePassword.UseVisualStyleBackColor = false;
            this.BtUpdatePassword.Visible = false;
            this.BtUpdatePassword.Click += new System.EventHandler(this.BtUpdatePassword_Click);
            // 
            // PbUserlogo
            // 
            this.PbUserlogo.Image = ((System.Drawing.Image)(resources.GetObject("PbUserlogo.Image")));
            this.PbUserlogo.Location = new System.Drawing.Point(-1, 12);
            this.PbUserlogo.Name = "PbUserlogo";
            this.PbUserlogo.Size = new System.Drawing.Size(215, 168);
            this.PbUserlogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PbUserlogo.TabIndex = 17;
            this.PbUserlogo.TabStop = false;
            // 
            // RmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(981, 515);
            this.ControlBox = false;
            this.Controls.Add(this.PbUserlogo);
            this.Controls.Add(this.BtUpdatePassword);
            this.Controls.Add(this.BtAddClient);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.BtClientsProfile);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.BtAssignIdeas);
            this.Controls.Add(this.BtDashboard);
            this.Controls.Add(this.BtNewIdeas);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "RmDashboard";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rm Dashboard";
            this.Load += new System.EventHandler(this.RmDashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbUserlogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtClientsProfile;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button BtAssignIdeas;
        private System.Windows.Forms.Button BtDashboard;
        private System.Windows.Forms.Button BtNewIdeas;
        private System.Windows.Forms.Button BtAddClient;
        private System.Windows.Forms.Button BtUpdatePassword;
        private System.Windows.Forms.PictureBox PbUserlogo;
    }
}
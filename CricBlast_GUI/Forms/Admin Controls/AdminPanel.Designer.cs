﻿
namespace CricBlast_GUI.Forms.Admin_Controls
{
    partial class AdminPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.adminSubPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.adminMenuPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.availabilityIcon = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.availability = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.userPhoto = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.manageUser = new Guna.UI2.WinForms.Guna2Button();
            this.tournaments = new Guna.UI2.WinForms.Guna2Button();
            this.projectDetails = new Guna.UI2.WinForms.Guna2Button();
            this.addUser = new Guna.UI2.WinForms.Guna2Button();
            this.dashboard = new Guna.UI2.WinForms.Guna2Button();
            this.logout = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.adminMenuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // adminSubPanel
            // 
            this.adminSubPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.adminSubPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.SubHome;
            this.adminSubPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminSubPanel.Location = new System.Drawing.Point(308, 0);
            this.adminSubPanel.Name = "adminSubPanel";
            this.adminSubPanel.ShadowDecoration.Parent = this.adminSubPanel;
            this.adminSubPanel.Size = new System.Drawing.Size(956, 681);
            this.adminSubPanel.TabIndex = 14;
            // 
            // adminMenuPanel
            // 
            this.adminMenuPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminMenuPanel.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Home_Menu;
            this.adminMenuPanel.Controls.Add(this.availabilityIcon);
            this.adminMenuPanel.Controls.Add(this.availability);
            this.adminMenuPanel.Controls.Add(this.usernameLabel);
            this.adminMenuPanel.Controls.Add(this.userPhoto);
            this.adminMenuPanel.Controls.Add(this.manageUser);
            this.adminMenuPanel.Controls.Add(this.tournaments);
            this.adminMenuPanel.Controls.Add(this.projectDetails);
            this.adminMenuPanel.Controls.Add(this.addUser);
            this.adminMenuPanel.Controls.Add(this.dashboard);
            this.adminMenuPanel.Controls.Add(this.logout);
            this.adminMenuPanel.Controls.Add(this.pictureBox1);
            this.adminMenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.adminMenuPanel.Location = new System.Drawing.Point(0, 0);
            this.adminMenuPanel.Name = "adminMenuPanel";
            this.adminMenuPanel.ShadowDecoration.Depth = 5;
            this.adminMenuPanel.ShadowDecoration.Parent = this.adminMenuPanel;
            this.adminMenuPanel.Size = new System.Drawing.Size(308, 681);
            this.adminMenuPanel.TabIndex = 13;
            // 
            // availabilityIcon
            // 
            this.availabilityIcon.FillColor = System.Drawing.Color.LimeGreen;
            this.availabilityIcon.ImageRotate = 0F;
            this.availabilityIcon.Location = new System.Drawing.Point(130, 556);
            this.availabilityIcon.Name = "availabilityIcon";
            this.availabilityIcon.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.availabilityIcon.ShadowDecoration.Parent = this.availabilityIcon;
            this.availabilityIcon.Size = new System.Drawing.Size(14, 14);
            this.availabilityIcon.TabIndex = 7;
            this.availabilityIcon.TabStop = false;
            // 
            // availability
            // 
            this.availability.AutoSize = true;
            this.availability.BackColor = System.Drawing.Color.Transparent;
            this.availability.Cursor = System.Windows.Forms.Cursors.Hand;
            this.availability.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availability.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.availability.Location = new System.Drawing.Point(144, 550);
            this.availability.Name = "availability";
            this.availability.Size = new System.Drawing.Size(68, 25);
            this.availability.TabIndex = 6;
            this.availability.Text = "Online";
            this.availability.Click += new System.EventHandler(this.availability_Click);
            // 
            // usernameLabel
            // 
            this.usernameLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameLabel.Cursor = System.Windows.Forms.Cursors.Default;
            this.usernameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.usernameLabel.Location = new System.Drawing.Point(128, 517);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(151, 32);
            this.usernameLabel.TabIndex = 6;
            this.usernameLabel.Text = "Admin";
            // 
            // userPhoto
            // 
            this.userPhoto.BackColor = System.Drawing.Color.Transparent;
            this.userPhoto.Cursor = System.Windows.Forms.Cursors.Default;
            this.userPhoto.FillColor = System.Drawing.Color.Transparent;
            this.userPhoto.Image = global::CricBlast_GUI.Properties.Resources.Admin;
            this.userPhoto.ImageRotate = 0F;
            this.userPhoto.Location = new System.Drawing.Point(52, 517);
            this.userPhoto.Name = "userPhoto";
            this.userPhoto.ShadowDecoration.Color = System.Drawing.Color.Silver;
            this.userPhoto.ShadowDecoration.Depth = 100;
            this.userPhoto.ShadowDecoration.Enabled = true;
            this.userPhoto.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.userPhoto.ShadowDecoration.Parent = this.userPhoto;
            this.userPhoto.Size = new System.Drawing.Size(64, 64);
            this.userPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPhoto.TabIndex = 5;
            this.userPhoto.TabStop = false;
            this.userPhoto.UseTransparentBackground = true;
            // 
            // manageUser
            // 
            this.manageUser.BackColor = System.Drawing.Color.Transparent;
            this.manageUser.BorderRadius = 10;
            this.manageUser.CheckedState.Parent = this.manageUser;
            this.manageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manageUser.CustomImages.Parent = this.manageUser;
            this.manageUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.manageUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.manageUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.manageUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.manageUser.DisabledState.Parent = this.manageUser;
            this.manageUser.FillColor = System.Drawing.Color.Transparent;
            this.manageUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.manageUser.ForeColor = System.Drawing.Color.White;
            this.manageUser.HoverState.Parent = this.manageUser;
            this.manageUser.Location = new System.Drawing.Point(45, 334);
            this.manageUser.Name = "manageUser";
            this.manageUser.ShadowDecoration.Parent = this.manageUser;
            this.manageUser.Size = new System.Drawing.Size(198, 45);
            this.manageUser.TabIndex = 1;
            this.manageUser.Text = "Manage Users";
            this.manageUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.manageUser.Click += new System.EventHandler(this.manageUser_Click);
            // 
            // tournaments
            // 
            this.tournaments.BackColor = System.Drawing.Color.Transparent;
            this.tournaments.BorderRadius = 10;
            this.tournaments.CheckedState.Parent = this.tournaments;
            this.tournaments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tournaments.CustomImages.Parent = this.tournaments;
            this.tournaments.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.tournaments.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.tournaments.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.tournaments.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.tournaments.DisabledState.Parent = this.tournaments;
            this.tournaments.FillColor = System.Drawing.Color.Transparent;
            this.tournaments.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.tournaments.ForeColor = System.Drawing.Color.White;
            this.tournaments.HoverState.Parent = this.tournaments;
            this.tournaments.Location = new System.Drawing.Point(45, 208);
            this.tournaments.Name = "tournaments";
            this.tournaments.ShadowDecoration.Parent = this.tournaments;
            this.tournaments.Size = new System.Drawing.Size(198, 45);
            this.tournaments.TabIndex = 1;
            this.tournaments.Text = "Tournaments";
            this.tournaments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tournaments.Click += new System.EventHandler(this.tournaments_Click);
            // 
            // projectDetails
            // 
            this.projectDetails.BackColor = System.Drawing.Color.Transparent;
            this.projectDetails.BorderRadius = 10;
            this.projectDetails.CheckedState.Parent = this.projectDetails;
            this.projectDetails.Cursor = System.Windows.Forms.Cursors.Hand;
            this.projectDetails.CustomImages.Parent = this.projectDetails;
            this.projectDetails.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.projectDetails.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.projectDetails.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.projectDetails.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.projectDetails.DisabledState.Parent = this.projectDetails;
            this.projectDetails.FillColor = System.Drawing.Color.Transparent;
            this.projectDetails.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.projectDetails.ForeColor = System.Drawing.Color.White;
            this.projectDetails.HoverState.Parent = this.projectDetails;
            this.projectDetails.Location = new System.Drawing.Point(45, 397);
            this.projectDetails.Name = "projectDetails";
            this.projectDetails.ShadowDecoration.Parent = this.projectDetails;
            this.projectDetails.Size = new System.Drawing.Size(198, 45);
            this.projectDetails.TabIndex = 1;
            this.projectDetails.Text = "Project Details";
            this.projectDetails.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.projectDetails.Click += new System.EventHandler(this.projectDetails_Click);
            // 
            // addUser
            // 
            this.addUser.BackColor = System.Drawing.Color.Transparent;
            this.addUser.BorderRadius = 10;
            this.addUser.CheckedState.Parent = this.addUser;
            this.addUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addUser.CustomImages.Parent = this.addUser;
            this.addUser.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.addUser.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.addUser.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.addUser.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.addUser.DisabledState.Parent = this.addUser;
            this.addUser.FillColor = System.Drawing.Color.Transparent;
            this.addUser.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.addUser.ForeColor = System.Drawing.Color.White;
            this.addUser.HoverState.Parent = this.addUser;
            this.addUser.Location = new System.Drawing.Point(45, 271);
            this.addUser.Name = "addUser";
            this.addUser.ShadowDecoration.Parent = this.addUser;
            this.addUser.Size = new System.Drawing.Size(198, 45);
            this.addUser.TabIndex = 1;
            this.addUser.Text = "Add Users";
            this.addUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.addUser.Click += new System.EventHandler(this.addUser_Click);
            // 
            // dashboard
            // 
            this.dashboard.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dashboard.BackColor = System.Drawing.Color.Transparent;
            this.dashboard.BorderRadius = 10;
            this.dashboard.CheckedState.Parent = this.dashboard;
            this.dashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dashboard.CustomImages.Parent = this.dashboard;
            this.dashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.dashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.dashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.dashboard.DisabledState.Parent = this.dashboard;
            this.dashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(161)))), ((int)(((byte)(47)))));
            this.dashboard.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.dashboard.ForeColor = System.Drawing.Color.White;
            this.dashboard.HoverState.Parent = this.dashboard;
            this.dashboard.Location = new System.Drawing.Point(45, 145);
            this.dashboard.Name = "dashboard";
            this.dashboard.ShadowDecoration.Parent = this.dashboard;
            this.dashboard.Size = new System.Drawing.Size(198, 45);
            this.dashboard.TabIndex = 1;
            this.dashboard.Text = "Dashboard";
            this.dashboard.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboard.Click += new System.EventHandler(this.dashboard_Click);
            // 
            // logout
            // 
            this.logout.AutoSize = true;
            this.logout.BackColor = System.Drawing.Color.Transparent;
            this.logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logout.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logout.ForeColor = System.Drawing.Color.Firebrick;
            this.logout.Location = new System.Drawing.Point(109, 594);
            this.logout.Name = "logout";
            this.logout.Size = new System.Drawing.Size(86, 30);
            this.logout.TabIndex = 4;
            this.logout.Text = "Logout";
            this.logout.Click += new System.EventHandler(this.logout_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::CricBlast_GUI.Properties.Resources.Admin_Panel;
            this.pictureBox1.Location = new System.Drawing.Point(50, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(188, 69);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // AdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.Background;
            this.Controls.Add(this.adminSubPanel);
            this.Controls.Add(this.adminMenuPanel);
            this.Name = "AdminPanel";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.AdminPanel_Load);
            this.adminMenuPanel.ResumeLayout(false);
            this.adminMenuPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.availabilityIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userPhoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel adminSubPanel;
        private Guna.UI2.WinForms.Guna2Panel adminMenuPanel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox availabilityIcon;
        private System.Windows.Forms.Label availability;
        private System.Windows.Forms.Label usernameLabel;
        private Guna.UI2.WinForms.Guna2CirclePictureBox userPhoto;
        private Guna.UI2.WinForms.Guna2Button manageUser;
        private Guna.UI2.WinForms.Guna2Button tournaments;
        private Guna.UI2.WinForms.Guna2Button projectDetails;
        private Guna.UI2.WinForms.Guna2Button addUser;
        private Guna.UI2.WinForms.Guna2Button dashboard;
        private System.Windows.Forms.Label logout;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
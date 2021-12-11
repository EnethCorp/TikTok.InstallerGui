﻿
namespace CricBlast_GUI.Forms.Controls
{
    partial class PlayerStats
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
            this.changeFormatComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.changePlayerComboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.userTeamName = new System.Windows.Forms.Label();
            this.playerName = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.fifties = new System.Windows.Forms.Label();
            this.hundreds = new System.Windows.Forms.Label();
            this.strikeRate = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.playerPhoto = new Guna.UI2.WinForms.Guna2PictureBox();
            this.wickets = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.matches = new System.Windows.Forms.Label();
            this.runs = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.average = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // changeFormatComboBox
            // 
            this.changeFormatComboBox.BackColor = System.Drawing.Color.Transparent;
            this.changeFormatComboBox.BorderRadius = 4;
            this.changeFormatComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.changeFormatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changeFormatComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeFormatComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changeFormatComboBox.FocusedState.Parent = this.changeFormatComboBox;
            this.changeFormatComboBox.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.changeFormatComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.changeFormatComboBox.HoverState.Parent = this.changeFormatComboBox;
            this.changeFormatComboBox.ItemHeight = 30;
            this.changeFormatComboBox.Items.AddRange(new object[] {
            "T20I",
            "ODI",
            "Test"});
            this.changeFormatComboBox.ItemsAppearance.Parent = this.changeFormatComboBox;
            this.changeFormatComboBox.Location = new System.Drawing.Point(625, 247);
            this.changeFormatComboBox.Name = "changeFormatComboBox";
            this.changeFormatComboBox.ShadowDecoration.Parent = this.changeFormatComboBox;
            this.changeFormatComboBox.Size = new System.Drawing.Size(260, 36);
            this.changeFormatComboBox.StartIndex = 0;
            this.changeFormatComboBox.TabIndex = 37;
            this.changeFormatComboBox.SelectedIndexChanged += new System.EventHandler(this.changeFormatComboBox_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label12.Location = new System.Drawing.Point(626, 220);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(142, 21);
            this.label12.TabIndex = 35;
            this.label12.Text = "CHANGE FORMAT";
            // 
            // changePlayerComboBox
            // 
            this.changePlayerComboBox.BackColor = System.Drawing.Color.Transparent;
            this.changePlayerComboBox.BorderRadius = 4;
            this.changePlayerComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.changePlayerComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.changePlayerComboBox.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changePlayerComboBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.changePlayerComboBox.FocusedState.Parent = this.changePlayerComboBox;
            this.changePlayerComboBox.Font = new System.Drawing.Font("Segoe UI", 17F);
            this.changePlayerComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.changePlayerComboBox.HoverState.Parent = this.changePlayerComboBox;
            this.changePlayerComboBox.ItemHeight = 30;
            this.changePlayerComboBox.Items.AddRange(new object[] {
            "Tamim Iqbal",
            "Mohammad Naim",
            "Shakib Al Hasan",
            "Afif Hossain",
            "Mushfiqur Rahim",
            "Mahmudullah",
            "Mahedi Hasan",
            "Taskin Ahmed",
            "Nasum Ahmed",
            "Mustafizur Rahman",
            "Shoriful Islam",
            "Mohammad Mithun",
            "Saifuddin",
            "Nurul Hasan",
            "Aminul Islam"});
            this.changePlayerComboBox.ItemsAppearance.Parent = this.changePlayerComboBox;
            this.changePlayerComboBox.Location = new System.Drawing.Point(625, 168);
            this.changePlayerComboBox.Name = "changePlayerComboBox";
            this.changePlayerComboBox.ShadowDecoration.Parent = this.changePlayerComboBox;
            this.changePlayerComboBox.Size = new System.Drawing.Size(260, 36);
            this.changePlayerComboBox.StartIndex = 0;
            this.changePlayerComboBox.TabIndex = 38;
            this.changePlayerComboBox.SelectedIndexChanged += new System.EventHandler(this.changePlayer_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label10.Location = new System.Drawing.Point(626, 141);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 21);
            this.label10.TabIndex = 36;
            this.label10.Text = "CHANGE PLAYER";
            // 
            // userTeamName
            // 
            this.userTeamName.AutoSize = true;
            this.userTeamName.BackColor = System.Drawing.Color.Transparent;
            this.userTeamName.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.userTeamName.ForeColor = System.Drawing.Color.AliceBlue;
            this.userTeamName.Location = new System.Drawing.Point(258, 255);
            this.userTeamName.Name = "userTeamName";
            this.userTeamName.Size = new System.Drawing.Size(121, 28);
            this.userTeamName.TabIndex = 31;
            this.userTeamName.Text = "Bangladesh";
            // 
            // playerName
            // 
            this.playerName.AutoSize = true;
            this.playerName.BackColor = System.Drawing.Color.Transparent;
            this.playerName.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.playerName.ForeColor = System.Drawing.Color.AliceBlue;
            this.playerName.Location = new System.Drawing.Point(255, 209);
            this.playerName.Name = "playerName";
            this.playerName.Size = new System.Drawing.Size(277, 46);
            this.playerName.TabIndex = 30;
            this.playerName.Text = "Shakib Al Hasan";
            this.playerName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label23.ForeColor = System.Drawing.Color.Silver;
            this.label23.Location = new System.Drawing.Point(521, 413);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(118, 46);
            this.label23.TabIndex = 28;
            this.label23.Text = "Fifties";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label21.ForeColor = System.Drawing.Color.Silver;
            this.label21.Location = new System.Drawing.Point(521, 357);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 46);
            this.label21.TabIndex = 25;
            this.label21.Text = "Hundreds";
            // 
            // fifties
            // 
            this.fifties.AutoSize = true;
            this.fifties.BackColor = System.Drawing.Color.Transparent;
            this.fifties.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.fifties.ForeColor = System.Drawing.Color.AliceBlue;
            this.fifties.Location = new System.Drawing.Point(693, 413);
            this.fifties.Name = "fifties";
            this.fifties.Size = new System.Drawing.Size(60, 46);
            this.fifties.TabIndex = 23;
            this.fifties.Text = "49";
            // 
            // hundreds
            // 
            this.hundreds.AutoSize = true;
            this.hundreds.BackColor = System.Drawing.Color.Transparent;
            this.hundreds.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.hundreds.ForeColor = System.Drawing.Color.AliceBlue;
            this.hundreds.Location = new System.Drawing.Point(693, 357);
            this.hundreds.Name = "hundreds";
            this.hundreds.Size = new System.Drawing.Size(40, 46);
            this.hundreds.TabIndex = 21;
            this.hundreds.Text = "9";
            // 
            // strikeRate
            // 
            this.strikeRate.AutoSize = true;
            this.strikeRate.BackColor = System.Drawing.Color.Transparent;
            this.strikeRate.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.strikeRate.ForeColor = System.Drawing.Color.AliceBlue;
            this.strikeRate.Location = new System.Drawing.Point(311, 525);
            this.strikeRate.Name = "strikeRate";
            this.strikeRate.Size = new System.Drawing.Size(109, 46);
            this.strikeRate.TabIndex = 19;
            this.strikeRate.Text = "82.14";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Silver;
            this.label17.Location = new System.Drawing.Point(154, 525);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(151, 46);
            this.label17.TabIndex = 32;
            this.label17.Text = "Str. Rate";
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BorderRadius = 1;
            this.guna2PictureBox2.FillColor = System.Drawing.Color.DarkGray;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(85, 311);
            this.guna2PictureBox2.Margin = new System.Windows.Forms.Padding(1);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.ShadowDecoration.Parent = this.guna2PictureBox2;
            this.guna2PictureBox2.Size = new System.Drawing.Size(800, 2);
            this.guna2PictureBox2.TabIndex = 34;
            this.guna2PictureBox2.TabStop = false;
            // 
            // playerPhoto
            // 
            this.playerPhoto.BorderRadius = 4;
            this.playerPhoto.FillColor = System.Drawing.Color.Transparent;
            this.playerPhoto.Image = global::CricBlast_GUI.Properties.Resources.Shakib;
            this.playerPhoto.ImageRotate = 0F;
            this.playerPhoto.Location = new System.Drawing.Point(85, 131);
            this.playerPhoto.Name = "playerPhoto";
            this.playerPhoto.ShadowDecoration.Parent = this.playerPhoto;
            this.playerPhoto.Size = new System.Drawing.Size(152, 152);
            this.playerPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.playerPhoto.TabIndex = 33;
            this.playerPhoto.TabStop = false;
            // 
            // wickets
            // 
            this.wickets.AutoSize = true;
            this.wickets.BackColor = System.Drawing.Color.Transparent;
            this.wickets.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.wickets.ForeColor = System.Drawing.Color.AliceBlue;
            this.wickets.Location = new System.Drawing.Point(693, 469);
            this.wickets.Name = "wickets";
            this.wickets.Size = new System.Drawing.Size(80, 46);
            this.wickets.TabIndex = 23;
            this.wickets.Text = "277";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(521, 469);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(145, 46);
            this.label2.TabIndex = 28;
            this.label2.Text = "Wickets";
            // 
            // matches
            // 
            this.matches.AutoSize = true;
            this.matches.BackColor = System.Drawing.Color.Transparent;
            this.matches.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.matches.ForeColor = System.Drawing.Color.AliceBlue;
            this.matches.Location = new System.Drawing.Point(311, 357);
            this.matches.Name = "matches";
            this.matches.Size = new System.Drawing.Size(80, 46);
            this.matches.TabIndex = 20;
            this.matches.Text = "215";
            // 
            // runs
            // 
            this.runs.AutoSize = true;
            this.runs.BackColor = System.Drawing.Color.Transparent;
            this.runs.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.runs.ForeColor = System.Drawing.Color.AliceBlue;
            this.runs.Location = new System.Drawing.Point(311, 413);
            this.runs.Name = "runs";
            this.runs.Size = new System.Drawing.Size(100, 46);
            this.runs.TabIndex = 22;
            this.runs.Text = "6600";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Silver;
            this.label8.Location = new System.Drawing.Point(154, 357);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(153, 46);
            this.label8.TabIndex = 24;
            this.label8.Text = "Matches";
            // 
            // average
            // 
            this.average.AutoSize = true;
            this.average.BackColor = System.Drawing.Color.Transparent;
            this.average.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.average.ForeColor = System.Drawing.Color.AliceBlue;
            this.average.Location = new System.Drawing.Point(311, 469);
            this.average.Name = "average";
            this.average.Size = new System.Drawing.Size(109, 46);
            this.average.TabIndex = 26;
            this.average.Text = "37.71";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Silver;
            this.label9.Location = new System.Drawing.Point(154, 413);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(99, 46);
            this.label9.TabIndex = 17;
            this.label9.Text = "Runs";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Silver;
            this.label16.Location = new System.Drawing.Point(154, 469);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(150, 46);
            this.label16.TabIndex = 29;
            this.label16.Text = "Average";
            // 
            // PlayerStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(44)))), ((int)(((byte)(88)))));
            this.BackgroundImage = global::CricBlast_GUI.Properties.Resources.SubHome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.changeFormatComboBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.changePlayerComboBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.guna2PictureBox2);
            this.Controls.Add(this.playerPhoto);
            this.Controls.Add(this.userTeamName);
            this.Controls.Add(this.playerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.wickets);
            this.Controls.Add(this.fifties);
            this.Controls.Add(this.hundreds);
            this.Controls.Add(this.strikeRate);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.average);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.runs);
            this.Controls.Add(this.matches);
            this.DoubleBuffered = true;
            this.Name = "PlayerStats";
            this.Size = new System.Drawing.Size(956, 681);
            this.Load += new System.EventHandler(this.PlayerStats_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox changeFormatComboBox;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2ComboBox changePlayerComboBox;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox playerPhoto;
        private System.Windows.Forms.Label userTeamName;
        private System.Windows.Forms.Label playerName;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label fifties;
        private System.Windows.Forms.Label hundreds;
        private System.Windows.Forms.Label strikeRate;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label wickets;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label matches;
        private System.Windows.Forms.Label runs;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label average;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label16;
    }
}
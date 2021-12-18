﻿using System.Drawing;
using System.Windows.Forms;
using CricBlast_GUI.Forms.Controls;
using CricBlast_GUI.Home;
using Guna.UI2.WinForms;


namespace CricBlast_GUI.Forms.Admin_Controls
{
    public partial class AdminPanel : UserControl
    {
        public AdminPanel()
        {
            InitializeComponent();
        }

        private void AdminPanel_Load(object sender, System.EventArgs e)
        {
            adminSubPanel.Controls.Clear();
            adminSubPanel.Controls.Add(new Dashboard());
        }

        public int SelectedMenu = 1;

        private void logout_Click(object sender, System.EventArgs e)
        {
            new MessageBoxYesNo(1, "Are you sure you want to log out?").ShowDialog();

            if (!Selected.MessageBox) return;

            Controls.Clear();
            Controls.Add(new Welcome {welcomeLabel = {Text = "Welcome Back!"}});
        }

        private bool _isAvailable = true;

        private void availability_Click(object sender, System.EventArgs e)
        {
            if (_isAvailable)
            {
                availability.Text = "Offline";
                availabilityIcon.FillColor = Color.Gray;
                _isAvailable = false;
            }
            else
            {
                availability.Text = "Online";
                availabilityIcon.FillColor = Color.LimeGreen;
                _isAvailable = true;
            }
        }

        private void dashboard_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 1) return;
            adminSubPanel.Controls.Clear();
            adminSubPanel.Controls.Add(value: new Dashboard());
            ChangeButtonColor(dashboard, 1);
        }

        private void tournaments_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 2) return;
            adminSubPanel.Controls.Clear();
            adminSubPanel.Controls.Add(value: new TournamentsAdmin());
            ChangeButtonColor(tournaments, 2);
        }

        private void addUser_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 3) return;
            adminSubPanel.Controls.Clear();
            adminSubPanel.Controls.Add(value: new AddUser());
            ChangeButtonColor(addUser, 3);
        }

        private void manageUser_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 4) return;
            adminSubPanel.Controls.Clear();
            adminSubPanel.Controls.Add(value: new ManageUser());
            ChangeButtonColor(manageUser, 4);
        }

        private void projectDetails_Click(object sender, System.EventArgs e)
        {
            if (SelectedMenu == 5) return;
            adminSubPanel.Controls.Clear();
            adminSubPanel.Controls.Add(value: new ProjectDetails());
            ChangeButtonColor(projectDetails, 5);
        }

        private void ChangeButtonColor(Guna2Button button, int changeMenu)
        {
            button.FillColor = Color.FromArgb(246, 161, 47);

            switch (SelectedMenu)
            {
                case 1:
                    dashboard.FillColor = Color.Transparent;
                    break;
                case 2:
                    tournaments.FillColor = Color.Transparent;
                    break;
                case 3:
                    addUser.FillColor = Color.Transparent;
                    break;
                case 4:
                    manageUser.FillColor = Color.Transparent;
                    break;
                case 5:
                    projectDetails.FillColor = Color.Transparent;
                    break;
            }

            SelectedMenu = changeMenu;
        }
    }
}
﻿using System;
using System.Windows.Forms;

namespace CricBlast_GUI.UI
{
    public partial class SelectStadium : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }

        public SelectStadium()
        {
            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
            InitializeComponent();
        }

        private void doneButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
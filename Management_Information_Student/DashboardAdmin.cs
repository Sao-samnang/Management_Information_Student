﻿using Management_Information_Student.UserCon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Management_Information_Student
{
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void guna2Button7_Click(object sender, EventArgs e)
        {

        }
        //call user form
        private void CallUerFm(UserControl UC)
        {
            PanelShowMenu.Controls.Clear();
            PanelShowMenu.Controls.Add(UC);
            UC.Dock = DockStyle.Fill;
            UC.Visible = true;
            UC.BringToFront();
        }
        private void PanelShowMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            CallUerFm(new EnrolBasicInfo());
        }
    }
}

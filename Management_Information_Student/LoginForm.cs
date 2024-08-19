using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;


namespace Management_Information_Student
{
    
    public partial class LoginForm : Form
    {
        private bool isPasswordHidden = true;
        public LoginForm()
        {
            InitializeComponent();
            txtPassword.UseSystemPasswordChar= true;
            //picPass.Click += picPass_Click;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if(txtEmail.Text=="Vy_6" && txtPassword.Text == "629")
            {
                MessageBox.Show("Hello Kon Papa");
            }
            else
            {
                MessageBox.Show("Login Faile");
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            PictureBoxImg.Image=Properties.Resources.icon3;
            labelLogtxt1.Text = "MIS Provide Power Full";
            labelLogtxt2.Text = "F  a  s  t  e  r  E  a  s  y  Use🔥";
            
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
           
            PictureBoxImg.Image = Properties.Resources.icon2;
            labelLogtxt1.Text = "MIS Provide Power Full";
            labelLogtxt2.Text = "All Information On Your Hand🔥";
            
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            PictureBoxImg.Image = Properties.Resources.icon4;
            labelLogtxt1.Text = "W    e    l    c    o    m    e";
            labelLogtxt2.Text = "t    o    M  I  S   s  y  s  t  e  m🔥";
            
        }
        
        
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void picPass_Click(object sender, EventArgs e)
        {
      
            if (isPasswordHidden)
            {
                txtPassword.UseSystemPasswordChar = false; // Show text
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true; // Hide text (show as password)
            }

            isPasswordHidden = !isPasswordHidden; // Flip the flag
        }

        private void PictureBoxImg_Click(object sender, EventArgs e)
        {

        }
    }
}

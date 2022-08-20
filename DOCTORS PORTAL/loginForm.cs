using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCTORS_PORTAL
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
            rightEmail.Text = "";
            // placeholders

            // To show star
            passLogin.PasswordChar = '*';
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if (this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void goRegistrationFormBtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            registrationForm registrationForm = new registrationForm();
            registrationForm.Show();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            UserHome userHome = new UserHome();
            userHome.Show();
        }

        private void gunaTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(emailLogin.Text != "")
            {
                placeholderEmail.Text = "";
            } else
            {
                placeholderEmail.Text = "someone@xyz.com";

            }
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(emailLogin.Text, pattern))
            {
                rightEmail.Text = "❌";
            } else
            {
                rightEmail.Text = "✔️";
            }
        }

        private void passLogin_TextChanged(object sender, EventArgs e)
        {
            if (passLogin.Text != "")
            {
                placeholderPass.Text = "";
            } else
            {
                placeholderPass.Text = "123456@abc";
            }
            
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            hide.Show();
            show.Hide();
            passLogin.PasswordChar = '\0';
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            hide.Hide();
            show.Show();
            passLogin.PasswordChar = '*';
        }
    }
}

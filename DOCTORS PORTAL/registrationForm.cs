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
    public partial class registrationForm : Form
    {
        public registrationForm()
        {
            InitializeComponent();
            rightEmail.Text = "";
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

        private void goLoginFormLabel_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            loginForm loginForm = new loginForm();
            loginForm.Show();
        }

        private void registrationBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void nameTextBoxReg_Enter(object sender, EventArgs e)
        {
            if(nameTextBoxReg.Text == "Enter Name")
            {
                nameTextBoxReg.Text = "";
                nameTextBoxReg.ForeColor = Color.Black;
            }
        }

        private void nameTextBoxReg_Leave(object sender, EventArgs e)
        {
            if (nameTextBoxReg.Text == "")
            {
                nameTextBoxReg.Text = "Enter Name";
                nameTextBoxReg.ForeColor = Color.LightGray;
            }
        }

        private void emailTextBoxReg_Enter(object sender, EventArgs e)
        {
            if (emailTextBoxReg.Text == "someone@example.com")
            {
                emailTextBoxReg.Text = "";
                emailTextBoxReg.ForeColor = Color.Black;
            }
        }

        private void emailTextBoxReg_Leave(object sender, EventArgs e)
        {
            if (emailTextBoxReg.Text == "")
            {
                emailTextBoxReg.Text = "someone@example.com";
                emailTextBoxReg.ForeColor = Color.LightGray;
            }
        }

        private void emailTextBoxReg_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
            if (!Regex.IsMatch(emailTextBoxReg.Text, pattern))
            {
                rightEmail.Text = "❌";
            }
            else
            {
                rightEmail.Text = "✔️";
            }
        }

        private void passTextBoxReg_Enter(object sender, EventArgs e)
        {
            if (passTextBoxReg.Text == "Enter Password")
            {
                passTextBoxReg.Text = "";
                passTextBoxReg.PasswordChar = '●';
                passTextBoxReg.ForeColor = Color.Black;
            }
        }

        private void passTextBoxReg_Leave(object sender, EventArgs e)
        {
            if (passTextBoxReg.Text == "Enter Password")
            {
                passTextBoxReg.Text = "";
                passTextBoxReg.ForeColor = Color.LightGray;
            }
        }

        private void rightEmail_Click(object sender, EventArgs e)
        {
            if(rightEmail.Text == "❌")
            {
                emailTextBoxReg.Text = "";
            }
        }

        private void rightEmail_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void eyeOpen_Click(object sender, EventArgs e)
        {
            hide.Show();
            show.Hide();
            passTextBoxReg.PasswordChar = '\0';
        }

        private void eyeClose_Click(object sender, EventArgs e)
        {
            hide.Hide();
            show.Show();
            passTextBoxReg.PasswordChar = '●';
        }

        private void nameTextBoxReg_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

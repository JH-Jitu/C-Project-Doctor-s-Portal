using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DOCTORS_PORTAL
{
    public partial class UserHome : Form
    {
        userSelectDoctor userSelectDoctor = new userSelectDoctor();
        userDashboard userDashboard = new userDashboard();
        private DataSet dsObj;

        private DataAccess Da { get; set; }

        public UserHome()
        {

            InitializeComponent();

            Da = new DataAccess();
            
        }
        

        public UserHome(DataSet dsObj)
        {
            InitializeComponent();
            showEmail.Text = dsObj.Tables[0].Rows[0]["email"].ToString();
            showName.Text = dsObj.Tables[0].Rows[0]["name"].ToString();

        }

        private void UserHome_Load(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            pnlNav.Height = homeBtn.Height;
            pnlNav.Top = homeBtn.Top;
            pnlNav.Left = homeBtn.Left;
            homeBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            userDashboard.Show();
        }

        private void aboutBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void contactBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void maxBtn_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if(this.WindowState == FormWindowState.Maximized)
                this.WindowState = FormWindowState.Normal;
        }

        private void minBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized ;
        }

        private void dhakaBtn_Click(object sender, EventArgs e)
        {
            /*this.Hide();
            userSelectDoctor.Show();*/
            string sql = "insert into [DoctorsPortal].[dbo].[user] (id, name, password, email) values ('006', 'Md Saimon Bolda', 'jjs123456', 'jitu@gmail.com');";
            Da.ExecuteQuery(sql);
        }


    }
}

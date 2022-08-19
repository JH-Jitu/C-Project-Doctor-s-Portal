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
    public partial class userDashboard : Form
    {
        //UserHome userHome = new UserHome();

        public userDashboard()
        {
            InitializeComponent();
        }

        private void userDashboard_Load(object sender, EventArgs e)
        {
            pnlNav.Height = dashboardBtn.Height;
            pnlNav.Top = dashboardBtn.Top;
            pnlNav.Left = dashboardBtn.Left;
            dashboardBtn.BackColor = Color.FromArgb(75, 27, 151);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            //userHome.Show();
        }

        private void dashboardBtn_Click(object sender, EventArgs e)
        {

        }
    }
}

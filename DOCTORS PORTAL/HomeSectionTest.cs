using Guna.UI.WinForms;
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
    public partial class HomeSectionTest : UserControl
    {
        /*public GunaElipsePanel MainPanel
        {
            get { return mainPanel; }
            set { }
        }*/
        public HomeSectionTest()
        {
            InitializeComponent();
        }

        /*public HomeSectionTest(GunaElipsePanel mainPanel)
        {
            MainPanel = mainPanel;
        }*/

        public GunaElipsePanel MainPanel { get; }

        private void dhakaBtn_Click(object sender, EventArgs e)
        {
            UserHome userHomeObj = new UserHome();

            userSelectDoctorControl userSelectDoctorControlObj = new userSelectDoctorControl();
            userHomeObj.MainPanel.Controls.Clear();
            userHomeObj.MainPanel.Controls.Add(userSelectDoctorControlObj);
            userSelectDoctorControlObj.Show();
            Hide();
        }
    }
}

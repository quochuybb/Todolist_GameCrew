using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todolist.src.ui.MainMenu.UserControls;

namespace Todolist.src.ui.MainMenu
{
    public partial class mainMenu : Form
    {
        public mainMenu()
        {
            InitializeComponent();
        }

        private void TodayActivities_Click(object sender, EventArgs e)
        {
            TodayActivities todayActivities = new TodayActivities();
            addUserControl(todayActivities);
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            Setting setting = new Setting();
            addUserControl(setting);
        }
        private void Home_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            addUserControl(home);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panelContainer.Controls.Clear();
            panelContainer.Controls.Add(userControl);
        }
    }
}

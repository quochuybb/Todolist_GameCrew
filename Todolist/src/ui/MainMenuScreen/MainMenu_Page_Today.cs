using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todolist.src.ui.MainMenuScreen
{
    public partial class MainMenu_Page_Today : Form
    {
        public MainMenu_Page_Today(ConnectDb connect)
        {
            InitializeComponent();
            CenterLabelInPanel(Search_Button, Search_Panel);
            CenterLabelInPanel(All_Button, Upcoming_Panel);
            CenterLabelInPanel(Today_Button, Today_Panel);
            CenterLabelInPanel(Calender_Button, All_Panel);
        }

        public void CenterLabelInPanel(Button button, Panel panel)
        {
            int panelWidth = panel.Width;
            int panelHeight = panel.Height;
            int labelWidth = button.Width;
            int labelHeight = button.Height;
            int centerX = (panelWidth - labelWidth) / 3;
            int centerY = (panelHeight - labelHeight) / 2;
            button.Location = new Point(centerX, centerY);
        }

    }
}

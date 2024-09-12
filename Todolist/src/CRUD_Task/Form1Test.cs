using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todolist.src.CRUD_Task
{
    public partial class Form1Test : Form
    {

        private Panel addTaskPanel;
        private bool isAddPanelActive = false;
        public Form1Test()
        {
            InitializeComponent();
            TaskContainer taskContainer = new TaskContainer();
            addTaskPanel = taskContainer.createdAddTaskPanel();

            taskContainer.cancelBut.Click += CancelButton_Click;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(addTaskPanel);
            isAddPanelActive = true;
        }

        private void CancelButton_Click(object sender, EventArgs e) 
        {
            if (isAddPanelActive) 
            { 
                this.Controls.Remove(addTaskPanel);
                isAddPanelActive = false;
            }
        }
    }
}

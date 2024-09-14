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
        private TaskContainer taskContainer = new TaskContainer();
        private Panel addTaskPanel;
        private TreeView listPriority;
        private DateTimePicker datePicker;

        private bool isAddPanelActive = false;
        private bool isPrioListActive = false;
        private bool isPickerActive = false;
        public Form1Test()
        {
            InitializeComponent();
            addTaskPanel = taskContainer.createdAddTaskPanel();

            // main task buttons
            taskContainer.CancelBut.Click += CancelButton_Click;
            taskContainer.PrioBut.Click += PrioBut_Click;
            taskContainer.DateBut.Click += DateBut_Click;
            
            // sub elements
            datePicker = taskContainer.createDatePicker();
            listPriority = taskContainer.createTreeView();
            
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
                if (listPriority != null)
                {
                    this.Controls.Remove(listPriority);
                }
            }
        }

        private void DateBut_Click(object sender, EventArgs e)
        {
            if (!isPickerActive && isAddPanelActive)
            {
                isPickerActive = true;
                this.Controls.Add(datePicker);
                datePicker.BringToFront();
            }
            else
            {
                this.Controls.Remove(datePicker);
                isPickerActive = false;
            }
        }

            private void PrioBut_Click(object sender, EventArgs e)
            {
                if (!isPrioListActive && isAddPanelActive)
                {
                    isPrioListActive = true;
                    this.Controls.Add(listPriority);
                    listPriority.BringToFront();
                }
                else
                {
                    this.Controls.Remove(listPriority);
                    isPrioListActive = false;
                }
            }
    }
}

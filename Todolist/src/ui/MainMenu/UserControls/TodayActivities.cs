﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Todolist.src.CRUD_Task;

namespace Todolist.src.ui.MainMenu.UserControls
{
    public partial class TodayActivities : UserControl
    {
        private TaskContainer taskContainer = new TaskContainer();
        private Panel addTaskPanel;
        private System.Windows.Forms.TreeView listPriority;

        private bool isAddPanelActive = false;
        private bool isPrioListActive = false;
        private bool isPickerActive = false;
        private int count = 0;

        DataTable list = new DataTable(); // task data 
        public TodayActivities()
        {
            InitializeComponent();
            taskContainer.setLocationX(60);
            addTaskPanel = taskContainer.createdAddTaskPanel();
            
            // main task buttons events
            taskContainer.CancelBut.Click += CancelButton_Click;
            taskContainer.PrioBut.Click += PrioBut_Click;
            taskContainer.SavelBut.Click += SaveButton_Click;

            // sub elements
            listPriority = taskContainer.createTreeView();

            // make todolist
            list.Columns.Add("Priority");
            list.Columns.Add("Task name");
            list.Columns.Add("Description");
            list.Columns.Add("Due date");

            DataGridViewCheckBoxColumn checkBoxColumn = new DataGridViewCheckBoxColumn();
            checkBoxColumn.HeaderText = "Done"; // Set header text
            checkBoxColumn.Name = "checkBoxColumn"; // Set column name
            checkBoxColumn.ReadOnly = false; // Allow user to check/uncheck

            taskList.DataSource = list;
            taskList.Columns.Add(checkBoxColumn);
            taskList.CellContentClick += taskList_CellContentClick;
        }
        // add task functions
        private void CancelButton_Click(object sender, EventArgs e)
        {
            if (isAddPanelActive)
            {
                this.Controls.Remove(addTaskPanel);
                isAddPanelActive = false;
                if (listPriority != null)
                {
                    this.Controls.Remove(listPriority);
                    taskList.Location = new Point(3, 146);
                }
            }
        }

        // save task
        private void SaveButton_Click(object sender, EventArgs e)
        {
            string title = taskContainer.getTile();
            string descrip = taskContainer.getDescription();
            DateTime date = taskContainer.getDate();
            int prioIndex = taskContainer.getPriority();

            if (isAddPanelActive)
            {
                if (title.Length == 0)
                    MessageBox.Show("Tile can not be empty!");
                else
                {
                    DataRow newRow = list.NewRow();
                    string s1 = title.Substring(0, 1).ToUpper() + title.Substring(1).ToLower();
                    newRow["Task Name"] = s1;
                    newRow["Description"] = descrip;
                    newRow["Due date"] = date;
                    newRow["Priority"] = prioIndex + 1;

                    list.Rows.Add(newRow);
                    count++;
                    taskContainer.setDescrip("");
                    taskContainer.setTile("");
                }
            }
        }



        // select priority
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


        // check whether the tasks is done ?
        private void taskList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == taskList.Columns["checkBoxColumn"].Index && e.RowIndex >= 0)
            {

                object value = taskList.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;

                // Safely cast to bool
                bool isChecked = value != null && (bool)value;

                // If it was unchecked, remove the row
                if (!isChecked)
                {
                    taskList.Rows.RemoveAt(e.RowIndex);
                    count--;
                    if (count == 0)
                    {
                        MessageBox.Show("Done all tasks");
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Add(addTaskPanel);
            addTaskPanel.BringToFront();
            isAddPanelActive = true;

            taskList.Location = new Point(3, 146 + 80);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Todolist.src.CRUD_Task
{
    internal class TaskContainer : INewTask
    {
        public Panel addPanel = new Panel();
        public TextBox taskName = new TextBox();
        public TextBox taskDescription = new TextBox();
        public Button prioBut = new Button();
        public Button dateBut = new Button();
        public Button cancelBut = new Button();
        public Button saveTaskBut = new Button();
        Label lineSeparator = new Label();

        
        private void elementStyle()
        {
            // addPanel style
            addPanel.Size = new Size(775, 171);
            addPanel.BorderStyle = BorderStyle.FixedSingle;
            addPanel.Name = "addPanel";
            addPanel.Location = new Point(10, 10); // this location will be modified

            // taskName style
            taskName.Size = new Size(751,27);
            taskName.BorderStyle = BorderStyle.None;
            taskName.Name = "taskName";
            taskName.PlaceholderText = "Task name";
            taskName.Location = new Point(10, 10); // this location will be modified
            taskName.TabIndex = 0;

            // taskDescription style
            taskDescription.Size = new Size(751, 27);
            taskDescription.BorderStyle = BorderStyle.None;
            taskDescription.Name = "taskDescription";
            taskDescription.PlaceholderText = "Description";
            taskDescription.Location = new Point(10, 40); // this location will be modified
            taskDescription.TabIndex = 1;

            // Line Separator
            lineSeparator.Size = new Size(751, 1); // Thin height for the line
            lineSeparator.BackColor = Color.Black; // Line color
            lineSeparator.Location = new Point(10, 85);

            //  prioBut style
            prioBut.Size = new Size(101, 37);
            prioBut.Name = "prioBut";
            prioBut.Text = "Priority";
            prioBut.TabIndex = 2;
            prioBut.Location = new Point(10, 105); // this location will be modified

            //  dateBut style
            dateBut.Size = new Size(101, 37);
            dateBut.Name = "dateBut";
            dateBut.Text = "Due date";
            dateBut.TabIndex = 3;
            dateBut.Location = new Point(120, 105); // this location will be modified


            //  cancelBut style
            cancelBut.Size = new Size(101, 37);
            cancelBut.Name = "cancelBut";
            cancelBut.Text = "Cancel";
            cancelBut.TabIndex = 4;
            cancelBut.Location = new Point(230, 105); // this location will be modified

            //  saveTaskBut style
            saveTaskBut.Size = new Size(101, 37);
            saveTaskBut.Name = "saveTaskBut";
            saveTaskBut.Text = "Save";
            saveTaskBut.TabIndex = 5;
            saveTaskBut.Location = new Point(340, 105); // this location will be modified

            // create new panel
            addPanel.Controls.Add(taskName);
            addPanel.Controls.Add(taskDescription);
            addPanel.Controls.Add(lineSeparator);
            addPanel.Controls.Add(prioBut);
            addPanel.Controls.Add(dateBut);
            addPanel.Controls.Add(cancelBut);
            addPanel.Controls.Add(saveTaskBut);
        }


        public Panel createdAddTaskPanel()
        {
            elementStyle();
            return addPanel;
        }

    }
}

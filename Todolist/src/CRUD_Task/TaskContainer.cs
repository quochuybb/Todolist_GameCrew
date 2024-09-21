using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Todolist.src.CRUD_Task
{
    internal partial class TaskContainer
    {
        public Panel createdAddTaskPanel()
        {
            panelStyle();
            return addPanel;
        }

        public DateTimePicker createDatePicker()
        {
            //  dateBut style
            dateBut.Size = new Size(101, 37);
            dateBut.Name = "dateBut";
            dateBut.Text = "Due date";
            dateBut.TabIndex = 3;
            dateBut.Location = new Point(120, 110);
            // this location will be modified
            addPanel.Controls.Add(dateBut);

            dateTimePickerStyle();
            return dateTimePicker;
        }
        
        public void listPriority_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            priority = e.Node.Index;
        }
        public TreeView createTreeView()
        {
            prioListStyle();
            return listPriority;
        }
    }
}

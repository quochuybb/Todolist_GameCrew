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
            dateTimePickerStyle();
            return dateTimePicker;
        }
        
        public void listPriority_NodeMouseDoubleClick_1(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode doubleClickedNode = e.Node;
            // Display the double-clicked node's text
            MessageBox.Show("Double-clicked node text: " + doubleClickedNode.Text);            

        }
        public TreeView createTreeView()
        {
            prioListStyle();
            return listPriority;
        }
    }
}

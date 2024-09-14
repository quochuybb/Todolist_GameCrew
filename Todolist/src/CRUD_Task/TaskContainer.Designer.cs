using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Todolist.src.CRUD_Task
{
    internal partial class TaskContainer
    {
        private Panel addPanel = new Panel();
        private TextBox taskName = new TextBox();
        private TextBox taskDescription = new TextBox();
        private Button prioBut = new Button();
        private Button dateBut = new Button();
        private Button cancelBut = new Button();
        private Button saveTaskBut = new Button();
        private Label lineSeparator = new Label();
        private TreeView listPriority = new TreeView();
        private DateTimePicker dateTimePicker = new DateTimePicker();
        public Button CancelBut { get { return cancelBut; } }       
        public Button PrioBut { get { return prioBut; } }       
        public Button DateBut { get { return dateBut; } }       
        public Button SavelBut { get { return saveTaskBut; } }     
        

        private void panelStyle()
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

        private void prioListStyle()
        {
            // listPriority style 
            listPriority.Name = "listPriority";
            listPriority.Size = new Size(164, 72);
            listPriority.Location = new Point(40, 155);
            listPriority.SelectedImageIndex = 0;
            listPriority.ImageIndex = 0;


            // add images list
            ImageList images = new ImageList();
            images.Images.Add(Image.FromFile("D:\\downloadfile\\star1.png"));
            images.Images.Add(Image.FromFile("D:\\downloadfile\\star2.png"));
            images.Images.Add(Image.FromFile("D:\\downloadfile\\star3.png"));
            images.Images.SetKeyName(0, "star1.png");
            images.Images.SetKeyName(1, "star2.png");
            images.Images.SetKeyName(2, "star3.png");

            // node style
            TreeNode Node1 = new TreeNode("High priority");
            Node1.ImageKey = "star1.png";
            Node1.SelectedImageKey = "star1.png";
            Node1.Name = "Node0";
            Node1.Tag = "highPriority";
            TreeNode Node2 = new TreeNode("Medium priority");
            Node2.ImageKey = "star2.png";
            Node2.SelectedImageKey = "star2.png";
            Node2.Name = "Node1";
            Node2.Tag = "mediumPriority";
            TreeNode Node3 = new TreeNode("Low priority");
            Node3.ImageKey = "star3.png";
            Node3.SelectedImageKey = "star3.png";
            Node3.Name = "Node2";
            Node3.Tag = "lowPriority";

            listPriority.ImageList = images;
            listPriority.Nodes.AddRange(new TreeNode[] { Node1, Node2, Node3 });
            listPriority.NodeMouseClick += listPriority_NodeMouseDoubleClick_1;
        }

        private void dateTimePickerStyle()
        {
            dateTimePicker.Size = new Size(250, 27);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.MinDate = new DateTime(1 / 1 / 1753);
            dateTimePicker.Location = new Point(155, 155); // this location will be modified
        }
    }
}

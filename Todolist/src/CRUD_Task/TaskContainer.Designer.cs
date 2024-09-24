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
        private int priority;
        public Button CancelBut { get { return cancelBut; } }       
        public Button PrioBut { get { return prioBut; } }       
        public Button DateBut { get { return dateBut; } }       
        public Button SavelBut { get { return saveTaskBut; } }

        public string getTile()
        {
            return taskName.Text;
        }
        public void setTile(string tile)
        {
            taskName.Text = tile;
        }

        public void setDescrip(string descrip)
        {
            taskDescription.Text = descrip;
        }
        public string getDescription()
        {
            return taskDescription.Text;
        }

        public DateTime getDate()
        {
            return dateTimePicker.Value;
        }
        public void setPriority(int index)
        {
            this.priority = index;
        }
        public int getPriority()
        {
            return this.priority;
        }
        private int locationX = 170;
        private int locationY = 50;

        public void setLocationX(int x)
        {
            locationX = x;
        }

        public void setLocationY(int y)
        {
            locationY = y;
        }
        private void panelStyle()
        {
            addPanel.Location = new Point(170,50);
            taskName.Location = new Point(10, 10);
            taskDescription.Location = new Point(10, 50);
            lineSeparator.Location = new Point(10, 90);
            prioBut.Location = new Point(10, 110);
            cancelBut.Location = new Point(locationX + 60, 110);
            saveTaskBut.Location = new Point(locationX + 170, 110);


            // addPanel style
            addPanel.Size = new Size(775, 171);
            addPanel.BorderStyle = BorderStyle.FixedSingle;
            addPanel.Name = "addPanel";
            addPanel.BackColor = Color.FromArgb(248, 248, 255);
            // this location will be modified

            // taskName style
            taskName.Size = new Size(751,27);
            taskName.Font = new Font("Segoe UI", 12F);
            taskName.BorderStyle = BorderStyle.None;
            taskName.Name = "taskName";
            taskName.PlaceholderText = "Task name";
            taskName.BackColor = Color.FromArgb(248, 248, 255);
            // this location will be modified
            taskName.TabIndex = 0;

            // taskDescription style
            taskDescription.Size = new Size(751, 27);
            taskDescription.BorderStyle = BorderStyle.None;
            taskDescription.Name = "taskDescription";
            taskDescription.PlaceholderText = "Description";
            taskDescription.BackColor = Color.FromArgb(248, 248, 255);
            // this location will be modified
            taskDescription.TabIndex = 1;


            // Line Separator
            lineSeparator.Size = new Size(751, 1); // Thin height for the line
            lineSeparator.BackColor = Color.Black; // Line color
            

            //  prioBut style
            prioBut.Size = new Size(101, 37);
            prioBut.Name = "prioBut";
            prioBut.Text = "Priority";
            prioBut.TabIndex = 2;
            // this location will be modified

          


            //  cancelBut style
            cancelBut.Size = new Size(101, 37);
            cancelBut.Name = "cancelBut";
            cancelBut.Text = "Cancel";
            cancelBut.TabIndex = 4;
            cancelBut.BackColor = Color.FromArgb(230, 143, 172);
            // this location will be modified

            //  saveTaskBut style
            saveTaskBut.Size = new Size(101, 37);
            saveTaskBut.Name = "saveTaskBut";
            saveTaskBut.Text = "Save";
            saveTaskBut.TabIndex = 5;
            // this location will be modified

            // create new panel
            addPanel.Controls.Add(taskName);
            addPanel.Controls.Add(taskDescription);
            addPanel.Controls.Add(lineSeparator);
            addPanel.Controls.Add(prioBut);
            addPanel.Controls.Add(cancelBut);
            addPanel.Controls.Add(saveTaskBut);
        }

        private void prioListStyle()
        {
            // listPriority style 
            listPriority.Name = "listPriority";
            listPriority.Size = new Size(164, 72);
            listPriority.Location = new Point(locationX + 20, locationY + 145);
            listPriority.SelectedImageIndex = 0;
            listPriority.ImageIndex = 0;


            // add images list
            ImageList images = new ImageList();
            // Construct the path for each image
            string basePath = Application.StartupPath;

            images.Images.Add(Image.FromFile(System.IO.Path.Combine(basePath, "star1.png")));
            images.Images.Add(Image.FromFile(System.IO.Path.Combine(basePath, "star2.png")));
            images.Images.Add(Image.FromFile(System.IO.Path.Combine(basePath, "star3.png")));

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
            dateTimePicker.Location = new Point(locationX + 30, locationY + 145);
        }
    }
}

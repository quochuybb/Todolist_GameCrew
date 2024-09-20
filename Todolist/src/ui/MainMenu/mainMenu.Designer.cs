namespace Todolist.src.ui.MainMenu
{
    partial class mainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainMenu));
            flowLayoutPanel1 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            TodayActivities = new Button();
            Setting = new Button();
            panelMenu = new FlowLayoutPanel();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            Home = new Button();
            panel5 = new Panel();
            panel6 = new Panel();
            panelContainer = new Panel();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.FromArgb(36, 37, 42);
            flowLayoutPanel1.Controls.Add(pictureBox1);
            flowLayoutPanel1.Controls.Add(panel1);
            flowLayoutPanel1.Location = new Point(3, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(155, 102);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(141, 95);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(3, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(141, 0);
            panel1.TabIndex = 1;
            // 
            // TodayActivities
            // 
            TodayActivities.Dock = DockStyle.Fill;
            TodayActivities.Location = new Point(0, 0);
            TodayActivities.Name = "TodayActivities";
            TodayActivities.Size = new Size(155, 75);
            TodayActivities.TabIndex = 2;
            TodayActivities.Text = "Today Activities";
            TodayActivities.UseVisualStyleBackColor = true;
            TodayActivities.Click += TodayActivities_Click;
            // 
            // Setting
            // 
            Setting.Dock = DockStyle.Fill;
            Setting.Location = new Point(0, 0);
            Setting.Name = "Setting";
            Setting.Size = new Size(155, 75);
            Setting.TabIndex = 3;
            Setting.Text = "Setting";
            Setting.UseVisualStyleBackColor = true;
            Setting.Click += Setting_Click;
            // 
            // panelMenu
            // 
            panelMenu.BackColor = SystemColors.ControlDarkDark;
            panelMenu.Controls.Add(pictureBox5);
            panelMenu.Controls.Add(pictureBox2);
            panelMenu.Controls.Add(panel4);
            panelMenu.Controls.Add(panel5);
            panelMenu.Controls.Add(panel6);
            panelMenu.Dock = DockStyle.Left;
            panelMenu.Location = new Point(0, 0);
            panelMenu.Name = "panelMenu";
            panelMenu.Size = new Size(162, 552);
            panelMenu.TabIndex = 4;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(3, 3);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(125, 62);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(3, 71);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(151, 33);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(Home);
            panel4.Location = new Point(3, 110);
            panel4.Name = "panel4";
            panel4.Size = new Size(155, 75);
            panel4.TabIndex = 9;
            // 
            // Home
            // 
            Home.Dock = DockStyle.Fill;
            Home.Location = new Point(0, 0);
            Home.Name = "Home";
            Home.Size = new Size(155, 75);
            Home.TabIndex = 6;
            Home.Text = "Home";
            Home.UseVisualStyleBackColor = true;
            Home.Click += Home_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(TodayActivities);
            panel5.Location = new Point(3, 191);
            panel5.Name = "panel5";
            panel5.Size = new Size(155, 75);
            panel5.TabIndex = 10;
            // 
            // panel6
            // 
            panel6.Controls.Add(Setting);
            panel6.Location = new Point(3, 272);
            panel6.Name = "panel6";
            panel6.Size = new Size(155, 75);
            panel6.TabIndex = 11;
            // 
            // panelContainer
            // 
            panelContainer.BackColor = SystemColors.Control;
            panelContainer.Dock = DockStyle.Fill;
            panelContainer.Location = new Point(162, 0);
            panelContainer.Name = "panelContainer";
            panelContainer.Size = new Size(1079, 552);
            panelContainer.TabIndex = 5;
            // 
            // mainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1241, 552);
            Controls.Add(panelContainer);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panelMenu);
            Name = "mainMenu";
            Text = "mainMenu";
            flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private PictureBox pictureBox1;
        private Panel panel1;
        private Button TodayActivities;
        private Button Setting;
        private FlowLayoutPanel panelMenu;
        private PictureBox pictureBox2;
        private PictureBox pictureBox5;
        private Button Home;
        private Panel panelContainer;
        private Panel panel4;
        private Panel panel5;
        private Panel panel6;
    }
}
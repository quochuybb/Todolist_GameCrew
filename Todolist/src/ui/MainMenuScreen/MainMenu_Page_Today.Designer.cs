namespace Todolist.src.ui.MainMenuScreen
{
    partial class MainMenu_Page_Today
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
            Menu_Panel = new Panel();
            Toolbar_Panel = new Panel();
            Upcoming_Panel = new Panel();
            Calender_Button = new Button();
            Icon_Calendar = new PictureBox();
            Today_Panel = new Panel();
            Today_Button = new Button();
            Icon_Today = new PictureBox();
            All_Panel = new Panel();
            All_Button = new Button();
            Icon_Box = new PictureBox();
            Search_Panel = new Panel();
            Search_Button = new Button();
            Icon_Search = new PictureBox();
            Account_Panel = new Panel();
            Avatar_Usr = new PictureBox();
            dataGridView1 = new DataGridView();
            Menu_Panel.SuspendLayout();
            Toolbar_Panel.SuspendLayout();
            Upcoming_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icon_Calendar).BeginInit();
            Today_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icon_Today).BeginInit();
            All_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icon_Box).BeginInit();
            Search_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Icon_Search).BeginInit();
            Account_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)Avatar_Usr).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Menu_Panel
            // 
            Menu_Panel.BackColor = Color.Gainsboro;
            Menu_Panel.Controls.Add(Toolbar_Panel);
            Menu_Panel.Controls.Add(Account_Panel);
            Menu_Panel.Location = new Point(1, 1);
            Menu_Panel.Name = "Menu_Panel";
            Menu_Panel.Size = new Size(200, 450);
            Menu_Panel.TabIndex = 0;
            // 
            // Toolbar_Panel
            // 
            Toolbar_Panel.Controls.Add(Upcoming_Panel);
            Toolbar_Panel.Controls.Add(Today_Panel);
            Toolbar_Panel.Controls.Add(All_Panel);
            Toolbar_Panel.Controls.Add(Search_Panel);
            Toolbar_Panel.Location = new Point(3, 77);
            Toolbar_Panel.Name = "Toolbar_Panel";
            Toolbar_Panel.Size = new Size(194, 360);
            Toolbar_Panel.TabIndex = 1;
            // 
            // Upcoming_Panel
            // 
            Upcoming_Panel.Controls.Add(Calender_Button);
            Upcoming_Panel.Controls.Add(Icon_Calendar);
            Upcoming_Panel.Location = new Point(3, 129);
            Upcoming_Panel.Name = "Upcoming_Panel";
            Upcoming_Panel.Size = new Size(188, 36);
            Upcoming_Panel.TabIndex = 5;
            // 
            // Calender_Button
            // 
            Calender_Button.Location = new Point(39, 0);
            Calender_Button.Name = "Calender_Button";
            Calender_Button.Size = new Size(146, 36);
            Calender_Button.TabIndex = 8;
            Calender_Button.Text = "Calender";
            Calender_Button.UseVisualStyleBackColor = true;
            // 
            // Icon_Calendar
            // 
            Icon_Calendar.Image = Properties.Resources.Icon_Calendar;
            Icon_Calendar.Location = new Point(3, 3);
            Icon_Calendar.Name = "Icon_Calendar";
            Icon_Calendar.Size = new Size(30, 30);
            Icon_Calendar.SizeMode = PictureBoxSizeMode.Zoom;
            Icon_Calendar.TabIndex = 0;
            Icon_Calendar.TabStop = false;
            // 
            // Today_Panel
            // 
            Today_Panel.Controls.Add(Today_Button);
            Today_Panel.Controls.Add(Icon_Today);
            Today_Panel.Location = new Point(3, 87);
            Today_Panel.Name = "Today_Panel";
            Today_Panel.Size = new Size(188, 36);
            Today_Panel.TabIndex = 4;
            // 
            // Today_Button
            // 
            Today_Button.Location = new Point(39, 0);
            Today_Button.Name = "Today_Button";
            Today_Button.Size = new Size(146, 36);
            Today_Button.TabIndex = 8;
            Today_Button.Text = "Today";
            Today_Button.UseVisualStyleBackColor = true;
            // 
            // Icon_Today
            // 
            Icon_Today.Image = Properties.Resources.Icon_Today;
            Icon_Today.Location = new Point(3, 3);
            Icon_Today.Name = "Icon_Today";
            Icon_Today.Size = new Size(30, 30);
            Icon_Today.SizeMode = PictureBoxSizeMode.Zoom;
            Icon_Today.TabIndex = 0;
            Icon_Today.TabStop = false;
            // 
            // All_Panel
            // 
            All_Panel.Controls.Add(All_Button);
            All_Panel.Controls.Add(Icon_Box);
            All_Panel.Location = new Point(3, 45);
            All_Panel.Name = "All_Panel";
            All_Panel.Size = new Size(188, 36);
            All_Panel.TabIndex = 3;
            // 
            // All_Button
            // 
            All_Button.Location = new Point(39, 0);
            All_Button.Name = "All_Button";
            All_Button.Size = new Size(146, 36);
            All_Button.TabIndex = 7;
            All_Button.Text = "All";
            All_Button.UseVisualStyleBackColor = true;
            // 
            // Icon_Box
            // 
            Icon_Box.Image = Properties.Resources.Icon_Box;
            Icon_Box.Location = new Point(3, 3);
            Icon_Box.Name = "Icon_Box";
            Icon_Box.Size = new Size(30, 30);
            Icon_Box.SizeMode = PictureBoxSizeMode.Zoom;
            Icon_Box.TabIndex = 0;
            Icon_Box.TabStop = false;
            // 
            // Search_Panel
            // 
            Search_Panel.Controls.Add(Search_Button);
            Search_Panel.Controls.Add(Icon_Search);
            Search_Panel.Location = new Point(3, 6);
            Search_Panel.Name = "Search_Panel";
            Search_Panel.Size = new Size(188, 36);
            Search_Panel.TabIndex = 2;
            // 
            // Search_Button
            // 
            Search_Button.Location = new Point(39, 0);
            Search_Button.Name = "Search_Button";
            Search_Button.Size = new Size(146, 36);
            Search_Button.TabIndex = 6;
            Search_Button.Text = "Search";
            Search_Button.UseVisualStyleBackColor = true;
            // 
            // Icon_Search
            // 
            Icon_Search.Image = Properties.Resources.Icon_Search;
            Icon_Search.Location = new Point(3, 3);
            Icon_Search.Name = "Icon_Search";
            Icon_Search.Size = new Size(30, 30);
            Icon_Search.SizeMode = PictureBoxSizeMode.Zoom;
            Icon_Search.TabIndex = 0;
            Icon_Search.TabStop = false;
            // 
            // Account_Panel
            // 
            Account_Panel.Controls.Add(Avatar_Usr);
            Account_Panel.Location = new Point(3, 3);
            Account_Panel.Name = "Account_Panel";
            Account_Panel.Size = new Size(194, 36);
            Account_Panel.TabIndex = 1;
            // 
            // Avatar_Usr
            // 
            Avatar_Usr.Image = Properties.Resources.Avatar_Blank;
            Avatar_Usr.Location = new Point(3, 3);
            Avatar_Usr.Name = "Avatar_Usr";
            Avatar_Usr.Size = new Size(30, 30);
            Avatar_Usr.SizeMode = PictureBoxSizeMode.Zoom;
            Avatar_Usr.TabIndex = 0;
            Avatar_Usr.TabStop = false;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(207, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(481, 426);
            dataGridView1.TabIndex = 1;
            // 
            // MainMenu_Page_Today
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 450);
            Controls.Add(dataGridView1);
            Controls.Add(Menu_Panel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainMenu_Page_Today";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Todolist";
            Menu_Panel.ResumeLayout(false);
            Toolbar_Panel.ResumeLayout(false);
            Upcoming_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icon_Calendar).EndInit();
            Today_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icon_Today).EndInit();
            All_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icon_Box).EndInit();
            Search_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Icon_Search).EndInit();
            Account_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)Avatar_Usr).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Menu_Panel;
        private PictureBox Avatar_Usr;
        private Panel Account_Panel;
        private Panel Toolbar_Panel;
        private Panel Today_Panel;
        private PictureBox Icon_Today;
        private Panel All_Panel;
        private PictureBox Icon_Box;
        private Panel Search_Panel;
        private PictureBox Icon_Search;
        private Panel Upcoming_Panel;
        private PictureBox Icon_Calendar;
        private DataGridView dataGridView1;
        private Button Search_Button;
        private Button Calender_Button;
        private Button Today_Button;
        private Button All_Button;
    }
}
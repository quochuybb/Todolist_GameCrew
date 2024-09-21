namespace Todolist.src.ui.MainMenu.UserControls
{
    partial class TodayActivities
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            button1 = new Button();
            taskList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)taskList).BeginInit();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(0, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(160, 27);
            textBox1.TabIndex = 1;
            textBox1.Text = "TODAY ACTIVITIES";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(418, 81);
            button1.Name = "button1";
            button1.Size = new Size(183, 61);
            button1.TabIndex = 2;
            button1.Text = "Add task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // taskList
            // 
            taskList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskList.BackgroundColor = Color.Gainsboro;
            taskList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskList.Location = new Point(3, 203);
            taskList.Name = "taskList";
            taskList.RowHeadersWidth = 51;
            taskList.Size = new Size(1073, 440);
            taskList.TabIndex = 3;
            // 
            // TodayActivities
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskList);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "TodayActivities";
            Size = new Size(1079, 552);
            ((System.ComponentModel.ISupportInitialize)taskList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Button button1;
        private DataGridView taskList;
    }
}

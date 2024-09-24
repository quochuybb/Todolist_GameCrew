namespace Todolist.src.ui.MainMenu.UserControls
{
    partial class Home
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
            textBox1.Location = new Point(3, 3);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(90, 27);
            textBox1.TabIndex = 0;
            textBox1.Text = "HOME";
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // button1
            // 
            button1.Location = new Point(427, 79);
            button1.Name = "button1";
            button1.Size = new Size(183, 61);
            button1.TabIndex = 1;
            button1.Text = "Add task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // taskList
            // 
            taskList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            taskList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            taskList.BackgroundColor = Color.Gainsboro;
            taskList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            taskList.Location = new Point(3, 172);
            taskList.Name = "taskList";
            taskList.RowHeadersWidth = 51;
            taskList.Size = new Size(1073, 377);
            taskList.TabIndex = 2;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(taskList);
            Controls.Add(button1);
            Controls.Add(textBox1);
            Name = "Home";
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

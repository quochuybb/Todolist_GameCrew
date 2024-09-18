namespace Todolist.src.CRUD_Task
{
    partial class Form1Test
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1Test));
            button1 = new Button();
            imageList1 = new ImageList(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(313, 261);
            button1.Name = "button1";
            button1.Size = new Size(131, 37);
            button1.TabIndex = 0;
            button1.Text = "Add task";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "star1.png");
            imageList1.Images.SetKeyName(1, "star2.png");
            imageList1.Images.SetKeyName(2, "star3.png");
            // 
            // Form1Test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Name = "Form1Test";
            Text = "Form1Test";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private ImageList imageList1;
    }
}
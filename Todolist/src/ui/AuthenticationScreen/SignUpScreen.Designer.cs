namespace Todolist.src.ui.AuthenticationScreen
{
    partial class SignUpScreen
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
            SignIn_Label = new Label();
            panel1 = new Panel();
            textBox3 = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            label2 = new Label();
            textBox1 = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            textBox2 = new TextBox();
            panel5 = new Panel();
            label4 = new Label();
            textBox4 = new TextBox();
            SignUp_Button = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // SignIn_Label
            // 
            SignIn_Label.AutoSize = true;
            SignIn_Label.Font = new Font("Arial Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            SignIn_Label.Location = new Point(3, 0);
            SignIn_Label.Name = "SignIn_Label";
            SignIn_Label.Size = new Size(123, 40);
            SignIn_Label.TabIndex = 2;
            SignIn_Label.Text = "Sign In";
            SignIn_Label.Click += SignIn_Label_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(SignUp_Button);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(SignIn_Label);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(454, 331);
            panel1.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox3.Location = new Point(108, 15);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(312, 25);
            textBox3.TabIndex = 7;
            textBox3.Text = "Username";
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(textBox3);
            panel2.Location = new Point(11, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 56);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 8;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(textBox1);
            panel3.Location = new Point(11, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 56);
            panel3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(7, 15);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(108, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(312, 25);
            textBox1.TabIndex = 7;
            textBox1.Text = "Email";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(textBox2);
            panel4.Location = new Point(11, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(437, 56);
            panel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox2.Location = new Point(108, 15);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(312, 25);
            textBox2.TabIndex = 7;
            textBox2.Text = "Password";
            // 
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox4);
            panel5.Location = new Point(11, 229);
            panel5.Name = "panel5";
            panel5.Size = new Size(437, 56);
            panel5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(7, 15);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 8;
            label4.Text = "Re-Pass";
            // 
            // textBox4
            // 
            textBox4.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            textBox4.Location = new Point(108, 15);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(312, 25);
            textBox4.TabIndex = 7;
            textBox4.Text = "Email";
            // 
            // SignUp_Button
            // 
            SignUp_Button.BackColor = Color.IndianRed;
            SignUp_Button.ForeColor = Color.WhiteSmoke;
            SignUp_Button.Location = new Point(11, 291);
            SignUp_Button.Name = "SignUp_Button";
            SignUp_Button.Size = new Size(437, 28);
            SignUp_Button.TabIndex = 12;
            SignUp_Button.Text = "Sign Up";
            SignUp_Button.UseVisualStyleBackColor = false;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "UserControl1";
            Size = new Size(460, 337);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SignIn_Label;
        private Panel panel1;
        private TextBox textBox3;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label label4;
        private TextBox textBox4;
        private Panel panel4;
        private Label label3;
        private TextBox textBox2;
        private Panel panel3;
        private Label label2;
        private TextBox textBox1;
        private Button SignUp_Button;
    }
}

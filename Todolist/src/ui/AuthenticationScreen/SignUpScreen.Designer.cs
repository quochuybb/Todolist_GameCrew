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
            SignUp_Button = new Button();
            panel5 = new Panel();
            label4 = new Label();
            RePass_TexBox = new TextBox();
            panel4 = new Panel();
            label3 = new Label();
            Pass_TextBox = new TextBox();
            panel3 = new Panel();
            label2 = new Label();
            Email_TextBox = new TextBox();
            panel2 = new Panel();
            label1 = new Label();
            Usr_TextBox = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // SignIn_Label
            // 
            SignIn_Label.AutoSize = true;
            SignIn_Label.Font = new Font("Arial Black", 16.2F, FontStyle.Bold);
            SignIn_Label.Location = new Point(3, 0);
            SignIn_Label.Name = "SignIn_Label";
            SignIn_Label.Size = new Size(135, 40);
            SignIn_Label.TabIndex = 2;
            SignIn_Label.Text = "Sign Up";
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
            // panel5
            // 
            panel5.Controls.Add(label4);
            panel5.Controls.Add(RePass_TexBox);
            panel5.Location = new Point(11, 229);
            panel5.Name = "panel5";
            panel5.Size = new Size(437, 56);
            panel5.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label4.Location = new Point(7, 15);
            label4.Name = "label4";
            label4.Size = new Size(76, 22);
            label4.TabIndex = 8;
            label4.Text = "Re-Pass";
            // 
            // RePass_TexBox
            // 
            RePass_TexBox.Font = new Font("Arial", 9F);
            RePass_TexBox.Location = new Point(108, 15);
            RePass_TexBox.Name = "RePass_TexBox";
            RePass_TexBox.Size = new Size(312, 25);
            RePass_TexBox.TabIndex = 7;
            RePass_TexBox.Text = "Re-Pass";
            // 
            // panel4
            // 
            panel4.Controls.Add(label3);
            panel4.Controls.Add(Pass_TextBox);
            panel4.Location = new Point(11, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(437, 56);
            panel4.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(90, 22);
            label3.TabIndex = 8;
            label3.Text = "Password";
            // 
            // Pass_TextBox
            // 
            Pass_TextBox.Font = new Font("Arial", 9F);
            Pass_TextBox.Location = new Point(108, 15);
            Pass_TextBox.Name = "Pass_TextBox";
            Pass_TextBox.Size = new Size(312, 25);
            Pass_TextBox.TabIndex = 7;
            Pass_TextBox.Text = "Password";
            // 
            // panel3
            // 
            panel3.Controls.Add(label2);
            panel3.Controls.Add(Email_TextBox);
            panel3.Location = new Point(11, 105);
            panel3.Name = "panel3";
            panel3.Size = new Size(437, 56);
            panel3.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label2.Location = new Point(7, 15);
            label2.Name = "label2";
            label2.Size = new Size(56, 22);
            label2.TabIndex = 8;
            label2.Text = "Email";
            // 
            // Email_TextBox
            // 
            Email_TextBox.Font = new Font("Arial", 9F);
            Email_TextBox.Location = new Point(108, 15);
            Email_TextBox.Name = "Email_TextBox";
            Email_TextBox.Size = new Size(312, 25);
            Email_TextBox.TabIndex = 7;
            Email_TextBox.Text = "Email";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Controls.Add(Usr_TextBox);
            panel2.Location = new Point(11, 43);
            panel2.Name = "panel2";
            panel2.Size = new Size(437, 56);
            panel2.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Black", 9F, FontStyle.Bold);
            label1.Location = new Point(7, 15);
            label1.Name = "label1";
            label1.Size = new Size(95, 22);
            label1.TabIndex = 8;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // Usr_TextBox
            // 
            Usr_TextBox.Font = new Font("Arial", 9F);
            Usr_TextBox.Location = new Point(108, 15);
            Usr_TextBox.Name = "Usr_TextBox";
            Usr_TextBox.Size = new Size(312, 25);
            Usr_TextBox.TabIndex = 7;
            Usr_TextBox.Text = "Username";
            Usr_TextBox.TextChanged += textBox3_TextChanged;
            // 
            // SignUpScreen
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "SignUpScreen";
            Size = new Size(460, 337);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label SignIn_Label;
        private Panel panel1;
        private TextBox Usr_TextBox;
        private Panel panel2;
        private Label label1;
        private Panel panel5;
        private Label label4;
        private TextBox RePass_TexBox;
        private Panel panel4;
        private Label label3;
        private TextBox Pass_TextBox;
        private Panel panel3;
        private Label label2;
        private TextBox Email_TextBox;
        private Button SignUp_Button;
    }
}

namespace Todolist;

partial class SignInScreen : Form
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
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
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        SignIn_Label = new Label();
        SignIn_Pass_TextBox = new TextBox();
        fileSystemWatcher1 = new FileSystemWatcher();
        SignIn_Email_TextBox = new TextBox();
        SignIn_Button = new Button();
        Ask_SignUp_Label = new Label();
        SignUp_Button = new Button();
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).BeginInit();
        SuspendLayout();
        // 
        // SignIn_Label
        // 
        SignIn_Label.AutoSize = true;
        SignIn_Label.Font = new Font("Arial Black", 16.2F, FontStyle.Bold);
        SignIn_Label.Location = new Point(14, 9);
        SignIn_Label.Name = "SignIn_Label";
        SignIn_Label.Size = new Size(123, 40);
        SignIn_Label.TabIndex = 1;
        SignIn_Label.Text = "Sign In";
        // 
        // SigIn_Pass_TextBox
        // 
        SignIn_Pass_TextBox.Location = new Point(14, 89);
        SignIn_Pass_TextBox.Name = "SignIn_Pass_TextBox";
        SignIn_Pass_TextBox.Size = new Size(346, 27);
        SignIn_Pass_TextBox.TabIndex = 2;
        SignIn_Pass_TextBox.Text = "Password";
        SignIn_Pass_TextBox.Click += SignIn_Pass_TextBox_Click;
        // 
        // fileSystemWatcher1
        // 
        fileSystemWatcher1.EnableRaisingEvents = true;
        fileSystemWatcher1.SynchronizingObject = this;
        // 
        // SignIn_Email_TextBox
        // 
        SignIn_Email_TextBox.Location = new Point(14, 58);
        SignIn_Email_TextBox.Name = "SignIn_Email_TextBox";
        SignIn_Email_TextBox.Size = new Size(346, 27);
        SignIn_Email_TextBox.TabIndex = 0;
        SignIn_Email_TextBox.Text = "Email";
        SignIn_Email_TextBox.Click += SigIn_Email_TextBox_Click;
        // 
        // SignIn_Button
        // 
        SignIn_Button.BackColor = Color.IndianRed;
        SignIn_Button.ForeColor = Color.WhiteSmoke;
        SignIn_Button.Location = new Point(14, 121);
        SignIn_Button.Name = "SignIn_Button";
        SignIn_Button.Size = new Size(346, 28);
        SignIn_Button.TabIndex = 3;
        SignIn_Button.Text = "Sign In";
        SignIn_Button.UseVisualStyleBackColor = false;
        SignIn_Button.Click += SignIn_Button_Click;
        // 
        // Ask_SignUp_Label
        // 
        Ask_SignUp_Label.AutoSize = true;
        Ask_SignUp_Label.Font = new Font("Arial", 10.2F);
        Ask_SignUp_Label.Location = new Point(14, 159);
        Ask_SignUp_Label.Name = "Ask_SignUp_Label";
        Ask_SignUp_Label.Size = new Size(180, 19);
        Ask_SignUp_Label.TabIndex = 4;
        Ask_SignUp_Label.Text = "Don't have an account?";
        // 
        // SignUp_Button
        // 
        SignUp_Button.BackColor = Color.IndianRed;
        SignUp_Button.ForeColor = Color.WhiteSmoke;
        SignUp_Button.Location = new Point(200, 155);
        SignUp_Button.Name = "SignUp_Button";
        SignUp_Button.Size = new Size(90, 28);
        SignUp_Button.TabIndex = 5;
        SignUp_Button.Text = "Sign Up";
        SignUp_Button.UseVisualStyleBackColor = false;
        SignUp_Button.Click += SignUp_Button_Click;
        // 
        // SignInScreen
        // 
        AutoScaleDimensions = new SizeF(9F, 19F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.WhiteSmoke;
        ClientSize = new Size(503, 196);
        Controls.Add(SignUp_Button);
        Controls.Add(Ask_SignUp_Label);
        Controls.Add(SignIn_Button);
        Controls.Add(SignIn_Email_TextBox);
        Controls.Add(SignIn_Pass_TextBox);
        Controls.Add(SignIn_Label);
        Font = new Font("Arial", 10.2F);
        FormBorderStyle = FormBorderStyle.None;
        Name = "SignInScreen";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "Todolist";
        ((System.ComponentModel.ISupportInitialize)fileSystemWatcher1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion
    private Label SignIn_Label;
    private TextBox SignIn_Pass_TextBox;
    private FileSystemWatcher fileSystemWatcher1;
    private TextBox SignIn_Email_TextBox;
    private Button SignIn_Button;
    private Label Ask_SignUp_Label;
    private Button SignUp_Button;
}
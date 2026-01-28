namespace Assignment3._4
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnLogin = new Button();
            txtuser = new TextBox();
            label1 = new Label();
            txtpass = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(138, 118);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(109, 23);
            btnLogin.TabIndex = 1;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtuser
            // 
            txtuser.Location = new Point(12, 50);
            txtuser.Name = "txtuser";
            txtuser.PlaceholderText = "Enter Username";
            txtuser.Size = new Size(258, 23);
            txtuser.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Yu Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Azure;
            label1.Image = (Image)resources.GetObject("label1.Image");
            label1.Location = new Point(47, 9);
            label1.Name = "label1";
            label1.Size = new Size(182, 27);
            label1.TabIndex = 3;
            label1.Text = "Quiroz INT Login";
            // 
            // txtpass
            // 
            txtpass.Location = new Point(12, 79);
            txtpass.Name = "txtpass";
            txtpass.PasswordChar = '*';
            txtpass.PlaceholderText = "Enter Password";
            txtpass.Size = new Size(258, 23);
            txtpass.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(23, 118);
            button1.Name = "button1";
            button1.Size = new Size(109, 23);
            button1.TabIndex = 5;
            button1.Text = "Forgot Password";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlDarkDark;
            ClientSize = new Size(282, 241);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(label1);
            Controls.Add(txtuser);
            Controls.Add(btnLogin);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnLogin;
        private TextBox txtuser;
        private Label label1;
        private TextBox txtpass;
        private Button button1;
    }
}

namespace WF_ADO
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
            login_btn = new Button();
            show_pass = new CheckBox();
            login_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            login_password = new TextBox();
            label3 = new Label();
            panel1 = new Panel();
            login_signup = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(33, 8, 97);
            login_btn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ControlLightLight;
            login_btn.Location = new Point(299, 321);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(137, 48);
            login_btn.TabIndex = 0;
            login_btn.Text = "LOGIN";
            login_btn.UseVisualStyleBackColor = false;
            login_btn.Click += login_btn_Click;
            // 
            // show_pass
            // 
            show_pass.AutoSize = true;
            show_pass.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_pass.Location = new Point(479, 288);
            show_pass.Name = "show_pass";
            show_pass.Size = new Size(148, 25);
            show_pass.TabIndex = 1;
            show_pass.Text = "Show Password";
            show_pass.UseVisualStyleBackColor = true;
            show_pass.CheckedChanged += show_pass_CheckedChanged;
            // 
            // login_username
            // 
            login_username.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_username.Location = new Point(299, 137);
            login_username.Multiline = true;
            login_username.Name = "login_username";
            login_username.Size = new Size(328, 34);
            login_username.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(299, 97);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(299, 192);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 5;
            label2.Text = "Password";
            // 
            // login_password
            // 
            login_password.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_password.Location = new Point(299, 232);
            login_password.Multiline = true;
            login_password.Name = "login_password";
            login_password.PasswordChar = '*';
            login_password.Size = new Size(328, 34);
            login_password.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(299, 33);
            label3.Name = "label3";
            label3.Size = new Size(159, 28);
            label3.TabIndex = 6;
            label3.Text = "Login Account";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gainsboro;
            panel1.Controls.Add(login_signup);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(248, 456);
            panel1.TabIndex = 7;
            // 
            // login_signup
            // 
            login_signup.BackColor = Color.FromArgb(33, 8, 97);
            login_signup.ForeColor = SystemColors.ButtonHighlight;
            login_signup.Location = new Point(12, 400);
            login_signup.Name = "login_signup";
            login_signup.Size = new Size(218, 53);
            login_signup.TabIndex = 3;
            login_signup.Text = "SIGN UP";
            login_signup.UseVisualStyleBackColor = false;
            login_signup.Click += login_signup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(31, 362);
            label5.Name = "label5";
            label5.Size = new Size(181, 22);
            label5.TabIndex = 2;
            label5.Text = "Register your account";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(3, 192);
            label4.Name = "label4";
            label4.Size = new Size(242, 21);
            label4.TabIndex = 1;
            label4.Text = "Employee Management System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(53, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(763, 9);
            exit.Name = "exit";
            exit.Size = new Size(25, 28);
            exit.TabIndex = 8;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(800, 456);
            Controls.Add(exit);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(login_password);
            Controls.Add(label1);
            Controls.Add(login_username);
            Controls.Add(show_pass);
            Controls.Add(login_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ADO .NET";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button login_btn;
        private CheckBox show_pass;
        private TextBox login_username;
        private Label label1;
        private Label label2;
        private TextBox login_password;
        private Label label3;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Button login_signup;
        private Label label5;
        private Label label4;
        private Label exit;
    }
}

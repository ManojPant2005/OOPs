namespace WF_ADO
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            panel1 = new Panel();
            login_signup = new Button();
            label5 = new Label();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            label2 = new Label();
            textBox2 = new TextBox();
            label1 = new Label();
            textBox1 = new TextBox();
            show_pass = new CheckBox();
            login_btn = new Button();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
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
            panel1.Size = new Size(248, 450);
            panel1.TabIndex = 15;
            // 
            // login_signup
            // 
            login_signup.BackColor = Color.FromArgb(33, 8, 97);
            login_signup.ForeColor = SystemColors.ButtonHighlight;
            login_signup.Location = new Point(12, 400);
            login_signup.Name = "login_signup";
            login_signup.Size = new Size(218, 53);
            login_signup.TabIndex = 3;
            login_signup.Text = "SIGN IN";
            login_signup.UseVisualStyleBackColor = false;
            login_signup.Click += login_signup_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 362);
            label5.Name = "label5";
            label5.Size = new Size(203, 22);
            label5.TabIndex = 2;
            label5.Text = "Already have an account";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(386, 33);
            label3.Name = "label3";
            label3.Size = new Size(189, 28);
            label3.TabIndex = 14;
            label3.Text = "Register Account";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(386, 192);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 13;
            label2.Text = "Password";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(386, 232);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(328, 34);
            textBox2.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(386, 97);
            label1.Name = "label1";
            label1.Size = new Size(88, 22);
            label1.TabIndex = 11;
            label1.Text = "Username";
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Tahoma", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(386, 137);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(328, 34);
            textBox1.TabIndex = 10;
            // 
            // show_pass
            // 
            show_pass.AutoSize = true;
            show_pass.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            show_pass.Location = new Point(566, 288);
            show_pass.Name = "show_pass";
            show_pass.Size = new Size(148, 25);
            show_pass.TabIndex = 9;
            show_pass.Text = "Show Password";
            show_pass.UseVisualStyleBackColor = true;
            show_pass.CheckedChanged += show_pass_CheckedChanged;
            // 
            // login_btn
            // 
            login_btn.BackColor = Color.FromArgb(33, 8, 97);
            login_btn.Font = new Font("Tahoma", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            login_btn.ForeColor = SystemColors.ControlLightLight;
            login_btn.Location = new Point(386, 321);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(137, 48);
            login_btn.TabIndex = 8;
            login_btn.Text = "SIGN UP";
            login_btn.UseVisualStyleBackColor = false;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.Location = new Point(763, 9);
            exit.Name = "exit";
            exit.Size = new Size(25, 28);
            exit.TabIndex = 16;
            exit.Text = "X";
            exit.Click += exit_Click;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(exit);
            Controls.Add(panel1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(show_pass);
            Controls.Add(login_btn);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            Load += Register_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button login_signup;
        private Label label5;
        private Label label4;
        private PictureBox pictureBox1;
        private Label label3;
        private Label label2;
        private TextBox textBox2;
        private Label label1;
        private TextBox textBox1;
        private CheckBox show_pass;
        private Button login_btn;
        private Label exit;
    }
}
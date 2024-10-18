namespace ShoopingCart
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            listViewProducts = new ListView();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(27, 44);
            button1.Name = "button1";
            button1.Size = new Size(135, 119);
            button1.TabIndex = 0;
            button1.Text = "Mobiles";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(27, 221);
            button2.Name = "button2";
            button2.Size = new Size(135, 128);
            button2.TabIndex = 1;
            button2.Text = "IPhones";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(27, 394);
            button3.Name = "button3";
            button3.Size = new Size(135, 130);
            button3.TabIndex = 2;
            button3.Text = "Laptop";
            button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(27, 570);
            button4.Name = "button4";
            button4.Size = new Size(135, 127);
            button4.TabIndex = 3;
            button4.Text = "Hardwares";
            button4.UseVisualStyleBackColor = true;
            // 
            // listViewProducts
            // 
            listViewProducts.Location = new Point(240, 24);
            listViewProducts.Name = "listViewProducts";
            listViewProducts.Size = new Size(944, 688);
            listViewProducts.TabIndex = 4;
            listViewProducts.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(1234, 741);
            Controls.Add(listViewProducts);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Shopping Cart";
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private ListView listViewProducts;
    }
}

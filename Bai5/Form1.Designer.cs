namespace Bai5
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
            richTextBox1 = new RichTextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            clearButton = new Button();
            loginButton = new Button();
            tbpassword = new TextBox();
            tbusername = new TextBox();
            tburl = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(35, 187);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(741, 238);
            richTextBox1.TabIndex = 14;
            richTextBox1.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 143);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 13;
            label3.Text = "Password:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 83);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 12;
            label2.Text = "Username:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 32);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 11;
            label1.Text = "URL:";
            // 
            // clearButton
            // 
            clearButton.Location = new Point(568, 106);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(190, 57);
            clearButton.TabIndex = 9;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(568, 25);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(190, 57);
            loginButton.TabIndex = 10;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(109, 136);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(386, 27);
            tbpassword.TabIndex = 6;
            // 
            // tbusername
            // 
            tbusername.Location = new Point(109, 76);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(386, 27);
            tbusername.TabIndex = 7;
            // 
            // tburl
            // 
            tburl.Location = new Point(109, 25);
            tburl.Name = "tburl";
            tburl.ReadOnly = true;
            tburl.Size = new Size(386, 27);
            tburl.TabIndex = 8;
            tburl.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Controls.Add(loginButton);
            Controls.Add(tbpassword);
            Controls.Add(tbusername);
            Controls.Add(tburl);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button clearButton;
        private Button loginButton;
        private TextBox tbpassword;
        private TextBox tbusername;
        private TextBox tburl;
    }
}

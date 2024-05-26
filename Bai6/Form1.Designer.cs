namespace Bai6
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
            tburl = new TextBox();
            tbusername = new TextBox();
            tbpassword = new TextBox();
            loginButton = new Button();
            clearButton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            richTextBox1 = new RichTextBox();
            SuspendLayout();
            // 
            // tburl
            // 
            tburl.Location = new Point(107, 38);
            tburl.Name = "tburl";
            tburl.ReadOnly = true;
            tburl.Size = new Size(386, 27);
            tburl.TabIndex = 0;
            tburl.Text = "https://nt106.uitiot.vn/auth/token";
            // 
            // tbusername
            // 
            tbusername.Location = new Point(107, 89);
            tbusername.Name = "tbusername";
            tbusername.Size = new Size(386, 27);
            tbusername.TabIndex = 0;
            // 
            // tbpassword
            // 
            tbpassword.Location = new Point(107, 149);
            tbpassword.Name = "tbpassword";
            tbpassword.Size = new Size(386, 27);
            tbpassword.TabIndex = 0;
            // 
            // loginButton
            // 
            loginButton.Location = new Point(566, 38);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(190, 57);
            loginButton.TabIndex = 1;
            loginButton.Text = "Login";
            loginButton.UseVisualStyleBackColor = true;
            loginButton.Click += loginButton_Click;
            // 
            // clearButton
            // 
            clearButton.Location = new Point(566, 119);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(190, 57);
            clearButton.TabIndex = 1;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 45);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 2;
            label1.Text = "URL:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 96);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 3;
            label2.Text = "Username:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 156);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 4;
            label3.Text = "Password:";
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(33, 200);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(741, 238);
            richTextBox1.TabIndex = 5;
            richTextBox1.Text = "";
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

        private TextBox tburl;
        private TextBox tbusername;
        private TextBox tbpassword;
        private Button loginButton;
        private Button clearButton;
        private Label label1;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBox1;
    }
}

namespace Cau3
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
            goBtn = new Button();
            viewSourceBtn = new Button();
            button3 = new Button();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            panel2 = new Panel();
            SuspendLayout();
            // 
            // goBtn
            // 
            goBtn.Location = new Point(548, 12);
            goBtn.Name = "goBtn";
            goBtn.Size = new Size(117, 49);
            goBtn.TabIndex = 0;
            goBtn.Text = "Go Website";
            goBtn.UseVisualStyleBackColor = true;
            goBtn.Click += goBtn_Click;
            // 
            // viewSourceBtn
            // 
            viewSourceBtn.Location = new Point(671, 12);
            viewSourceBtn.Name = "viewSourceBtn";
            viewSourceBtn.Size = new Size(117, 49);
            viewSourceBtn.TabIndex = 1;
            viewSourceBtn.Text = "View-Source";
            viewSourceBtn.UseVisualStyleBackColor = true;
            viewSourceBtn.Click += viewSourceBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(548, 67);
            button3.Name = "button3";
            button3.Size = new Size(240, 49);
            button3.TabIndex = 2;
            button3.Text = "Download HTML File";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(12, 23);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(530, 27);
            textBox6.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(12, 78);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(530, 27);
            textBox5.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 20);
            label1.TabIndex = 5;
            label1.Text = "WEBSITE-LINK";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 55);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 6;
            label2.Text = "SAVE-AS";
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 124);
            panel2.Name = "panel2";
            panel2.Size = new Size(776, 382);
            panel2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 518);
            Controls.Add(panel2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox5);
            Controls.Add(textBox6);
            Controls.Add(button3);
            Controls.Add(viewSourceBtn);
            Controls.Add(goBtn);
            Name = "Form1";
            Text = "Cau3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button goBtn;
        private System.Windows.Forms.Button viewSourceBtn;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
    }
}

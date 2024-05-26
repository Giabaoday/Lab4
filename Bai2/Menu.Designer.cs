namespace Bai2
{
    partial class Menu
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
            this.btn_Bai2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Bai2
            // 
            this.btn_Bai2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Bai2.Location = new System.Drawing.Point(209, 90);
            this.btn_Bai2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_Bai2.Name = "btn_Bai2";
            this.btn_Bai2.Size = new System.Drawing.Size(100, 61);
            this.btn_Bai2.TabIndex = 3;
            this.btn_Bai2.Text = "Bài 2";
            this.btn_Bai2.UseVisualStyleBackColor = true;
            this.btn_Bai2.Click += new System.EventHandler(this.btn_Bai2_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.btn_Bai2);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Bai2;
    }
}
namespace W4_PainterAndROI
{
    partial class frmAskCanvaSize
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
            lbl1 = new Label();
            lbl2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // lbl1
            // 
            lbl1.AutoSize = true;
            lbl1.Font = new Font("Microsoft JhengHei UI", 15F);
            lbl1.Location = new Point(15, 54);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(70, 38);
            lbl1.TabIndex = 1;
            lbl1.Text = "長 : ";
            // 
            // lbl2
            // 
            lbl2.AutoSize = true;
            lbl2.Font = new Font("Microsoft JhengHei UI", 15F);
            lbl2.Location = new Point(15, 159);
            lbl2.Name = "lbl2";
            lbl2.Size = new Size(70, 38);
            lbl2.TabIndex = 1;
            lbl2.Text = "寬 : ";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 54);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(150, 30);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(70, 167);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(150, 30);
            textBox2.TabIndex = 2;
            // 
            // frmAskCanvaSize
            // 
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(239, 215);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lbl2);
            Controls.Add(lbl1);
            Name = "frmAskCanvaSize";
            Text = "frmAskCanvaSize";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl1;
        private Label lbl2;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
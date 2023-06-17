namespace opdracht1
{
    partial class type1
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lab1 = new System.Windows.Forms.Label();
            this.bt1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lab1
            // 
            this.lab1.AutoSize = true;
            this.lab1.Location = new System.Drawing.Point(361, 195);
            this.lab1.Name = "lab1";
            this.lab1.Size = new System.Drawing.Size(50, 20);
            this.lab1.TabIndex = 0;
            this.lab1.Text = "label1";
            // 
            // bt1
            // 
            this.bt1.Location = new System.Drawing.Point(338, 245);
            this.bt1.Name = "bt1";
            this.bt1.Size = new System.Drawing.Size(94, 29);
            this.bt1.TabIndex = 1;
            this.bt1.Text = "button1";
            this.bt1.UseVisualStyleBackColor = true;
            // 
            // type1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt1);
            this.Controls.Add(this.lab1);
            this.Name = "type1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label lab1;
        private Button bt1;
    }
}
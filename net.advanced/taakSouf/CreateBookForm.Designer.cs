namespace taakSouf
{
    partial class CreateBookForm
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
            this.comboBoxAuthors = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TitleTextbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.CreateBookbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxAuthors
            // 
            this.comboBoxAuthors.FormattingEnabled = true;
            this.comboBoxAuthors.Location = new System.Drawing.Point(209, 95);
            this.comboBoxAuthors.Name = "comboBoxAuthors";
            this.comboBoxAuthors.Size = new System.Drawing.Size(191, 28);
            this.comboBoxAuthors.TabIndex = 0;
            this.comboBoxAuthors.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Auteur";
            // 
            // TitleTextbox
            // 
            this.TitleTextbox.Location = new System.Drawing.Point(209, 163);
            this.TitleTextbox.Name = "TitleTextbox";
            this.TitleTextbox.Size = new System.Drawing.Size(191, 27);
            this.TitleTextbox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(212, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titel";
            // 
            // CreateBookbutton
            // 
            this.CreateBookbutton.Location = new System.Drawing.Point(209, 212);
            this.CreateBookbutton.Name = "CreateBookbutton";
            this.CreateBookbutton.Size = new System.Drawing.Size(191, 29);
            this.CreateBookbutton.TabIndex = 4;
            this.CreateBookbutton.Text = "Boek aanmaken";
            this.CreateBookbutton.UseVisualStyleBackColor = true;
            this.CreateBookbutton.Click += new System.EventHandler(this.CreateBookbutton_Click);
            // 
            // CreateBookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 415);
            this.Controls.Add(this.CreateBookbutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TitleTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxAuthors);
            this.Name = "CreateBookForm";
            this.Text = "CreateBookForm";
            this.Load += new System.EventHandler(this.CreateBookForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox comboBoxAuthors;
        private Label label1;
        private TextBox TitleTextbox;
        private Label label2;
        private Button CreateBookbutton;
    }
}
namespace taakSouf
{
    partial class SearchBookByNameForm
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
            this.titleTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.BookDatagridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.BookDatagridView)).BeginInit();
            this.SuspendLayout();
            // 
            // titleTextbox
            // 
            this.titleTextbox.Location = new System.Drawing.Point(262, 55);
            this.titleTextbox.Name = "titleTextbox";
            this.titleTextbox.Size = new System.Drawing.Size(214, 27);
            this.titleTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(262, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Naam :";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(262, 112);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(214, 29);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Zoeken";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // BookDatagridView
            // 
            this.BookDatagridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BookDatagridView.Location = new System.Drawing.Point(126, 172);
            this.BookDatagridView.Name = "BookDatagridView";
            this.BookDatagridView.RowHeadersWidth = 51;
            this.BookDatagridView.RowTemplate.Height = 29;
            this.BookDatagridView.Size = new System.Drawing.Size(529, 188);
            this.BookDatagridView.TabIndex = 3;
            // 
            // SearchBookByNameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BookDatagridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titleTextbox);
            this.Name = "SearchBookByNameForm";
            this.Text = "SearchBookByNameForm";
            ((System.ComponentModel.ISupportInitialize)(this.BookDatagridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox titleTextbox;
        private Label label1;
        private Button searchButton;
        private DataGridView BookDatagridView;
    }
}
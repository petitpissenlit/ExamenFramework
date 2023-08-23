namespace taakSouf
{
    partial class CreateAuthorForm
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
            this.VoornaamTextbox = new System.Windows.Forms.TextBox();
            this.naamTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.naam123Textbox = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // VoornaamTextbox
            // 
            this.VoornaamTextbox.Location = new System.Drawing.Point(174, 72);
            this.VoornaamTextbox.Name = "VoornaamTextbox";
            this.VoornaamTextbox.Size = new System.Drawing.Size(145, 27);
            this.VoornaamTextbox.TabIndex = 0;
            // 
            // naamTextbox
            // 
            this.naamTextbox.Location = new System.Drawing.Point(174, 151);
            this.naamTextbox.Name = "naamTextbox";
            this.naamTextbox.Size = new System.Drawing.Size(145, 27);
            this.naamTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Voornaam";
            // 
            // naam123Textbox
            // 
            this.naam123Textbox.AutoSize = true;
            this.naam123Textbox.Location = new System.Drawing.Point(174, 118);
            this.naam123Textbox.Name = "naam123Textbox";
            this.naam123Textbox.Size = new System.Drawing.Size(49, 20);
            this.naam123Textbox.TabIndex = 3;
            this.naam123Textbox.Text = "Naam";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(174, 201);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Auteur aanmaken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CreateAuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.naam123Textbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.naamTextbox);
            this.Controls.Add(this.VoornaamTextbox);
            this.Name = "CreateAuthorForm";
            this.Text = "CreateAuthorForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox VoornaamTextbox;
        private TextBox naamTextbox;
        private Label label1;
        private Label naam123Textbox;
        private Button button1;
    }
}
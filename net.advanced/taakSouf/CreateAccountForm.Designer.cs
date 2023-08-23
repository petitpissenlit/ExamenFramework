using taakSouf.Database;
using taakSouf.Database.Entities;

namespace taakSouf
{
    partial class CreateAccountForm
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
            this.EmailTextbox = new System.Windows.Forms.TextBox();
            this.GebruikersnaamTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.PasswordTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailTextbox
            // 
            this.EmailTextbox.Location = new System.Drawing.Point(278, 149);
            this.EmailTextbox.Name = "EmailTextbox";
            this.EmailTextbox.Size = new System.Drawing.Size(184, 27);
            this.EmailTextbox.TabIndex = 3;
            // 
            // GebruikersnaamTextbox
            // 
            this.GebruikersnaamTextbox.Location = new System.Drawing.Point(278, 68);
            this.GebruikersnaamTextbox.Name = "GebruikersnaamTextbox";
            this.GebruikersnaamTextbox.Size = new System.Drawing.Size(184, 27);
            this.GebruikersnaamTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Gebruikersnaam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(278, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Wachtwoord";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(278, 281);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 29);
            this.button1.TabIndex = 10;
            this.button1.Text = "Account aanmaken";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PasswordTextbox
            // 
            this.PasswordTextbox.Location = new System.Drawing.Point(278, 232);
            this.PasswordTextbox.Name = "PasswordTextbox";
            this.PasswordTextbox.Size = new System.Drawing.Size(184, 27);
            this.PasswordTextbox.TabIndex = 4;
            // 
            // CreateAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GebruikersnaamTextbox);
            this.Controls.Add(this.PasswordTextbox);
            this.Controls.Add(this.EmailTextbox);
            this.IsMdiContainer = true;
            this.Name = "CreateAccountForm";
            this.Text = "CreateAccountForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox EmailTextbox;
        private TextBox GebruikersnaamTextbox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private TextBox PasswordTextbox;
    }
}
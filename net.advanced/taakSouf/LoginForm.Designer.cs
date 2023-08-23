namespace taakSouf
{
    partial class LoginForm
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
            this.emailTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTextbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.rememberMeButton = new System.Windows.Forms.CheckBox();
            this.createAccountButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // emailTextbox
            // 
            this.emailTextbox.Location = new System.Drawing.Point(284, 137);
            this.emailTextbox.Name = "emailTextbox";
            this.emailTextbox.Size = new System.Drawing.Size(158, 27);
            this.emailTextbox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(284, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(284, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Wachtwoord";
            // 
            // passwordTextbox
            // 
            this.passwordTextbox.Location = new System.Drawing.Point(284, 216);
            this.passwordTextbox.Name = "passwordTextbox";
            this.passwordTextbox.Size = new System.Drawing.Size(158, 27);
            this.passwordTextbox.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(159, 29);
            this.button1.TabIndex = 4;
            this.button1.Text = "Inloggen";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // rememberMeButton
            // 
            this.rememberMeButton.AutoSize = true;
            this.rememberMeButton.Location = new System.Drawing.Point(283, 249);
            this.rememberMeButton.Name = "rememberMeButton";
            this.rememberMeButton.Size = new System.Drawing.Size(139, 24);
            this.rememberMeButton.TabIndex = 5;
            this.rememberMeButton.Text = "Ingelogd blijven";
            this.rememberMeButton.UseVisualStyleBackColor = true;
            // 
            // createAccountButton
            // 
            this.createAccountButton.Location = new System.Drawing.Point(283, 340);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(159, 29);
            this.createAccountButton.TabIndex = 6;
            this.createAccountButton.Text = "Account aanmaken";
            this.createAccountButton.UseVisualStyleBackColor = true;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.createAccountButton);
            this.Controls.Add(this.rememberMeButton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passwordTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.emailTextbox);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox emailTextbox;
        private Label label1;
        private Label label2;
        private TextBox passwordTextbox;
        private Button button1;
        private CheckBox rememberMeButton;
        private Button createAccountButton;
    }
}
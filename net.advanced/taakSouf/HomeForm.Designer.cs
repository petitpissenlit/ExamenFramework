namespace taakSouf
{
    partial class HomeForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AuthorStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateAuthorToolStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.auteursBekijkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boekenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boekAanmakenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.boekenBekijkenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.logoutButton = new System.Windows.Forms.Button();
            this.boekZoekenOpNaamToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AuthorStripMenu,
            this.boekenToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AuthorStripMenu
            // 
            this.AuthorStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateAuthorToolStrip,
            this.auteursBekijkenToolStripMenuItem});
            this.AuthorStripMenu.Name = "AuthorStripMenu";
            this.AuthorStripMenu.Size = new System.Drawing.Size(73, 24);
            this.AuthorStripMenu.Text = "Auteurs";
            // 
            // CreateAuthorToolStrip
            // 
            this.CreateAuthorToolStrip.Name = "CreateAuthorToolStrip";
            this.CreateAuthorToolStrip.Size = new System.Drawing.Size(208, 26);
            this.CreateAuthorToolStrip.Text = "Auteur aanmaken";
            this.CreateAuthorToolStrip.Click += new System.EventHandler(this.CreateAuthorToolStrip_Click);
            // 
            // auteursBekijkenToolStripMenuItem
            // 
            this.auteursBekijkenToolStripMenuItem.Name = "auteursBekijkenToolStripMenuItem";
            this.auteursBekijkenToolStripMenuItem.Size = new System.Drawing.Size(208, 26);
            this.auteursBekijkenToolStripMenuItem.Text = "Auteurs bekijken";
            this.auteursBekijkenToolStripMenuItem.Click += new System.EventHandler(this.auteursBekijkenToolStripMenuItem_Click);
            // 
            // boekenToolStripMenuItem
            // 
            this.boekenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.boekAanmakenToolStripMenuItem,
            this.boekenBekijkenToolStripMenuItem,
            this.boekZoekenOpNaamToolStripMenuItem});
            this.boekenToolStripMenuItem.Name = "boekenToolStripMenuItem";
            this.boekenToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.boekenToolStripMenuItem.Text = "Boeken";
            // 
            // boekAanmakenToolStripMenuItem
            // 
            this.boekAanmakenToolStripMenuItem.Name = "boekAanmakenToolStripMenuItem";
            this.boekAanmakenToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.boekAanmakenToolStripMenuItem.Text = "Boek aanmaken";
            this.boekAanmakenToolStripMenuItem.Click += new System.EventHandler(this.boekAanmakenToolStripMenuItem_Click);
            // 
            // boekenBekijkenToolStripMenuItem
            // 
            this.boekenBekijkenToolStripMenuItem.Name = "boekenBekijkenToolStripMenuItem";
            this.boekenBekijkenToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.boekenBekijkenToolStripMenuItem.Text = "Boeken bekijken";
            this.boekenBekijkenToolStripMenuItem.Click += new System.EventHandler(this.boekenBekijkenToolStripMenuItem_Click);
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataSource = typeof(taakSouf.Database.Entities.Author);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(694, 42);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(94, 29);
            this.logoutButton.TabIndex = 1;
            this.logoutButton.Text = "Uitloggen";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // boekZoekenOpNaamToolStripMenuItem
            // 
            this.boekZoekenOpNaamToolStripMenuItem.Name = "boekZoekenOpNaamToolStripMenuItem";
            this.boekZoekenOpNaamToolStripMenuItem.Size = new System.Drawing.Size(239, 26);
            this.boekZoekenOpNaamToolStripMenuItem.Text = "Boek zoeken op naam";
            this.boekZoekenOpNaamToolStripMenuItem.Click += new System.EventHandler(this.boekZoekenOpNaamToolStripMenuItem_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem AuthorStripMenu;
        private ToolStripMenuItem CreateAuthorToolStrip;
        private BindingSource authorBindingSource;
        private ToolStripMenuItem auteursBekijkenToolStripMenuItem;
        private ToolStripMenuItem boekenToolStripMenuItem;
        private ToolStripMenuItem boekAanmakenToolStripMenuItem;
        private ToolStripMenuItem boekenBekijkenToolStripMenuItem;
        private Button logoutButton;
        private ToolStripMenuItem boekZoekenOpNaamToolStripMenuItem;
    }
}
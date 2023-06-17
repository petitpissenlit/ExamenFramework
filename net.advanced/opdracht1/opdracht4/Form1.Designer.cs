namespace opdracht4
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
            this.calculator = new System.Windows.Forms.Button();
            this.Ex_Price1 = new System.Windows.Forms.TextBox();
            this.Ex_Price2 = new System.Windows.Forms.TextBox();
            this.Ex_Price3 = new System.Windows.Forms.TextBox();
            this.Ex_Price4 = new System.Windows.Forms.TextBox();
            this.shipping = new System.Windows.Forms.TextBox();
            this.saletax = new System.Windows.Forms.TextBox();
            this.taxrate = new System.Windows.Forms.TextBox();
            this.subtot = new System.Windows.Forms.TextBox();
            this.g_tot = new System.Windows.Forms.TextBox();
            this.P_each4 = new System.Windows.Forms.TextBox();
            this.P_each3 = new System.Windows.Forms.TextBox();
            this.P_each2 = new System.Windows.Forms.TextBox();
            this.P_each1 = new System.Windows.Forms.TextBox();
            this.item4 = new System.Windows.Forms.TextBox();
            this.item3 = new System.Windows.Forms.TextBox();
            this.item2 = new System.Windows.Forms.TextBox();
            this.item1 = new System.Windows.Forms.TextBox();
            this.qty1 = new System.Windows.Forms.NumericUpDown();
            this.qty4 = new System.Windows.Forms.NumericUpDown();
            this.qty3 = new System.Windows.Forms.NumericUpDown();
            this.qty2 = new System.Windows.Forms.NumericUpDown();
            this.item = new System.Windows.Forms.Label();
            this.qty = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.qty1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty2)).BeginInit();
            this.SuspendLayout();
            // 
            // calculator
            // 
            this.calculator.Location = new System.Drawing.Point(338, 270);
            this.calculator.Name = "calculator";
            this.calculator.Size = new System.Drawing.Size(94, 29);
            this.calculator.TabIndex = 0;
            this.calculator.Text = "Calculator";
            this.calculator.UseVisualStyleBackColor = true;
            this.calculator.Click += new System.EventHandler(this.calculator_Click);
            // 
            // Ex_Price1
            // 
            this.Ex_Price1.Enabled = false;
            this.Ex_Price1.Location = new System.Drawing.Point(629, 62);
            this.Ex_Price1.Name = "Ex_Price1";
            this.Ex_Price1.Size = new System.Drawing.Size(125, 27);
            this.Ex_Price1.TabIndex = 1;
            // 
            // Ex_Price2
            // 
            this.Ex_Price2.Enabled = false;
            this.Ex_Price2.Location = new System.Drawing.Point(629, 95);
            this.Ex_Price2.Name = "Ex_Price2";
            this.Ex_Price2.Size = new System.Drawing.Size(125, 27);
            this.Ex_Price2.TabIndex = 2;
            // 
            // Ex_Price3
            // 
            this.Ex_Price3.Enabled = false;
            this.Ex_Price3.Location = new System.Drawing.Point(629, 128);
            this.Ex_Price3.Name = "Ex_Price3";
            this.Ex_Price3.Size = new System.Drawing.Size(125, 27);
            this.Ex_Price3.TabIndex = 3;
            // 
            // Ex_Price4
            // 
            this.Ex_Price4.Enabled = false;
            this.Ex_Price4.Location = new System.Drawing.Point(629, 161);
            this.Ex_Price4.Name = "Ex_Price4";
            this.Ex_Price4.Size = new System.Drawing.Size(125, 27);
            this.Ex_Price4.TabIndex = 4;
            // 
            // shipping
            // 
            this.shipping.Location = new System.Drawing.Point(629, 322);
            this.shipping.Name = "shipping";
            this.shipping.Size = new System.Drawing.Size(125, 27);
            this.shipping.TabIndex = 5;
            // 
            // saletax
            // 
            this.saletax.Enabled = false;
            this.saletax.Location = new System.Drawing.Point(629, 289);
            this.saletax.Name = "saletax";
            this.saletax.Size = new System.Drawing.Size(125, 27);
            this.saletax.TabIndex = 6;
            // 
            // taxrate
            // 
            this.taxrate.Location = new System.Drawing.Point(629, 256);
            this.taxrate.Name = "taxrate";
            this.taxrate.Size = new System.Drawing.Size(125, 27);
            this.taxrate.TabIndex = 7;
            // 
            // subtot
            // 
            this.subtot.Enabled = false;
            this.subtot.Location = new System.Drawing.Point(629, 223);
            this.subtot.Name = "subtot";
            this.subtot.Size = new System.Drawing.Size(125, 27);
            this.subtot.TabIndex = 8;
            // 
            // g_tot
            // 
            this.g_tot.Enabled = false;
            this.g_tot.Location = new System.Drawing.Point(629, 355);
            this.g_tot.Name = "g_tot";
            this.g_tot.Size = new System.Drawing.Size(125, 27);
            this.g_tot.TabIndex = 9;
            // 
            // P_each4
            // 
            this.P_each4.Location = new System.Drawing.Point(414, 161);
            this.P_each4.Name = "P_each4";
            this.P_each4.Size = new System.Drawing.Size(125, 27);
            this.P_each4.TabIndex = 10;
            // 
            // P_each3
            // 
            this.P_each3.Location = new System.Drawing.Point(414, 128);
            this.P_each3.Name = "P_each3";
            this.P_each3.Size = new System.Drawing.Size(125, 27);
            this.P_each3.TabIndex = 11;
            // 
            // P_each2
            // 
            this.P_each2.Location = new System.Drawing.Point(414, 95);
            this.P_each2.Name = "P_each2";
            this.P_each2.Size = new System.Drawing.Size(125, 27);
            this.P_each2.TabIndex = 12;
            // 
            // P_each1
            // 
            this.P_each1.Location = new System.Drawing.Point(414, 62);
            this.P_each1.Name = "P_each1";
            this.P_each1.Size = new System.Drawing.Size(125, 27);
            this.P_each1.TabIndex = 13;
            // 
            // item4
            // 
            this.item4.Location = new System.Drawing.Point(83, 161);
            this.item4.Name = "item4";
            this.item4.Size = new System.Drawing.Size(125, 27);
            this.item4.TabIndex = 14;
            // 
            // item3
            // 
            this.item3.Location = new System.Drawing.Point(83, 128);
            this.item3.Name = "item3";
            this.item3.Size = new System.Drawing.Size(125, 27);
            this.item3.TabIndex = 15;
            // 
            // item2
            // 
            this.item2.Location = new System.Drawing.Point(83, 95);
            this.item2.Name = "item2";
            this.item2.Size = new System.Drawing.Size(125, 27);
            this.item2.TabIndex = 16;
            // 
            // item1
            // 
            this.item1.Location = new System.Drawing.Point(83, 62);
            this.item1.Name = "item1";
            this.item1.Size = new System.Drawing.Size(125, 27);
            this.item1.TabIndex = 17;
            // 
            // qty1
            // 
            this.qty1.Location = new System.Drawing.Point(263, 63);
            this.qty1.Name = "qty1";
            this.qty1.Size = new System.Drawing.Size(44, 27);
            this.qty1.TabIndex = 18;
            // 
            // qty4
            // 
            this.qty4.Location = new System.Drawing.Point(263, 162);
            this.qty4.Name = "qty4";
            this.qty4.Size = new System.Drawing.Size(44, 27);
            this.qty4.TabIndex = 22;
            // 
            // qty3
            // 
            this.qty3.Location = new System.Drawing.Point(263, 129);
            this.qty3.Name = "qty3";
            this.qty3.Size = new System.Drawing.Size(44, 27);
            this.qty3.TabIndex = 23;
            // 
            // qty2
            // 
            this.qty2.Location = new System.Drawing.Point(263, 96);
            this.qty2.Name = "qty2";
            this.qty2.Size = new System.Drawing.Size(44, 27);
            this.qty2.TabIndex = 24;
            // 
            // item
            // 
            this.item.AutoSize = true;
            this.item.Location = new System.Drawing.Point(120, 39);
            this.item.Name = "item";
            this.item.Size = new System.Drawing.Size(39, 20);
            this.item.TabIndex = 25;
            this.item.Text = "item";
            // 
            // qty
            // 
            this.qty.AutoSize = true;
            this.qty.Location = new System.Drawing.Point(263, 39);
            this.qty.Name = "qty";
            this.qty.Size = new System.Drawing.Size(65, 20);
            this.qty.TabIndex = 26;
            this.qty.Text = "Quantity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(414, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 27;
            this.label3.Text = "Price Each";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 28;
            this.label4.Text = "Ex Price";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "SubTotaal";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(555, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tax Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(555, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.TabIndex = 31;
            this.label7.Text = "Sale Tax";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(555, 325);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 20);
            this.label8.TabIndex = 32;
            this.label8.Text = "Shipping";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(529, 358);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 20);
            this.label9.TabIndex = 33;
            this.label9.Text = "GrandTotaal";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.qty);
            this.Controls.Add(this.item);
            this.Controls.Add(this.qty2);
            this.Controls.Add(this.qty3);
            this.Controls.Add(this.qty4);
            this.Controls.Add(this.qty1);
            this.Controls.Add(this.item1);
            this.Controls.Add(this.item2);
            this.Controls.Add(this.item3);
            this.Controls.Add(this.item4);
            this.Controls.Add(this.P_each1);
            this.Controls.Add(this.P_each2);
            this.Controls.Add(this.P_each3);
            this.Controls.Add(this.P_each4);
            this.Controls.Add(this.g_tot);
            this.Controls.Add(this.subtot);
            this.Controls.Add(this.taxrate);
            this.Controls.Add(this.saletax);
            this.Controls.Add(this.shipping);
            this.Controls.Add(this.Ex_Price4);
            this.Controls.Add(this.Ex_Price3);
            this.Controls.Add(this.Ex_Price2);
            this.Controls.Add(this.Ex_Price1);
            this.Controls.Add(this.calculator);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.qty1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qty2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button calculator;
        private TextBox Ex_Price1;
        private TextBox Ex_Price2;
        private TextBox Ex_Price3;
        private TextBox Ex_Price4;
        private TextBox shipping;
        private TextBox saletax;
        private TextBox taxrate;
        private TextBox subtot;
        private TextBox g_tot;
        private TextBox P_each4;
        private TextBox P_each3;
        private TextBox P_each2;
        private TextBox P_each1;
        private TextBox item4;
        private TextBox item3;
        private TextBox item2;
        private TextBox item1;
        private NumericUpDown qty1;
        private NumericUpDown qty4;
        private NumericUpDown qty3;
        private NumericUpDown qty2;
        private Label item;
        private Label qty;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
    }
}
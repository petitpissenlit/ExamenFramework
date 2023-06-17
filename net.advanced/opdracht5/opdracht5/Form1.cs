namespace opdracht5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.ForeColor = Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.ForeColor = Color.Blue;
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text.BackColor = Color.Red;
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text.BackColor = Color.Green;
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Text.BackColor = Color.Blue;
        }

        private void smallToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.Font = Font = new Font(Text.Font.Name, 5,
                    Text.Font.Style, Text.Font.Unit);
        }

        private void normalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.Font = Font = new Font(Text.Font.Name, 9,
                    Text.Font.Style, Text.Font.Unit);
        }

        private void largeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Text.Font = Font = new Font(Text.Font.Name, 15,
                    Text.Font.Style, Text.Font.Unit);
        }

        private void redToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem_Click(sender, e);
        }

        private void greenToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem_Click(sender, e);
        }

        private void blueToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem_Click(sender, e);
        }

        private void redToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            redToolStripMenuItem1_Click(sender, e);
        }

        private void greenToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            greenToolStripMenuItem1_Click(sender, e);
        }

        private void blueToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            blueToolStripMenuItem1_Click(sender, e);
        }

        private void smallToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            smallToolStripMenuItem_Click(sender, e);
        }

        private void normalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            normalToolStripMenuItem_Click(sender, e);
        }

        private void largeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            largeToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Fotografie : Form
    {
        public Fotografie()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            tensiuneatb.Maximum = 160;
            tensiuneatb.TickFrequency = 40;
            tensiuneatb.LargeChange = 10;
            tensiuneatb.SmallChange = 1;

            rezistentatb.Maximum = 1100;
            rezistentatb.Minimum = 100;
            rezistentatb.TickFrequency = 100;
            rezistentatb.LargeChange = 10;
            rezistentatb.SmallChange = 1;
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            tensiunetextbox.Text = "" + (float)tensiuneatb.Value / 10;
            rezistentatextbox.Text = "" + (float)rezistentatb.Value / 10;
            intensitatetextbox.Text = "" + Math.Round(((float)tensiuneatb.Value / (float)rezistentatb.Value), 4);
            if (comboBox1.SelectedIndex > 0)
            {
                string t1 = ("" + comboBox1.SelectedItem).Substring(("" + comboBox1.SelectedItem).IndexOf(" "));
                var t = float.Parse(t1, System.Globalization.CultureInfo.InvariantCulture.NumberFormat);
                ampermetru.Text = "" + Math.Round(((float)tensiuneatb.Value / (float)rezistentatb.Value) + (t * 2290), 4);
                voltmetru.Text = "" + Math.Round((((float)tensiuneatb.Value / (float)rezistentatb.Value) + (t * 763)) * (float)rezistentatb.Value / 10, 4);
            }
            else
            {
                ampermetru.Text = intensitatetextbox.Text;
                voltmetru.Text = tensiunetextbox.Text;
            }
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            Grafic.Series["f(U)"].Points.AddXY(tensiunetextbox.Text, Math.Round(((float)tensiuneatb.Value / (float)rezistentatb.Value), 1));
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var m = new Fotografie();
            m.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void schema_Click(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void ampermetru_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click_1(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void intensitatetextbox_Click(object sender, EventArgs e)
        {

        }

        private void Grafic_Click(object sender, EventArgs e)
        {

        }
    }
}

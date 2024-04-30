using System;
using System.Windows.Forms;

namespace theTransitionProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float Y0 = Convert.ToSingle(textBox1.Text);
            float Y1 = Convert.ToSingle(textBox2.Text);
            float Y2 = Convert.ToSingle(textBox3.Text);
            float T1 = Convert.ToSingle(textBox4.Text);
            float T2 = Convert.ToSingle(textBox5.Text);
            float w = Convert.ToSingle(textBox6.Text);
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            chart1.Series[0].Points.Clear();
            while (T1 <= w)
            {
                double y = Y0 + Y1 * (Math.Exp((float)(-Y2 * T1)));
                chart1.Series[0].Points.AddXY(Math.Round(T1, 2), Math.Round(y, 2));
                listBox1.Items.Add(string.Format("{0:0.##}", T1));
                listBox2.Items.Add(string.Format("{0:0.##}", y));

                T1 += T2;
            }
        }
    }
}

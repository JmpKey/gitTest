using System;
using System.Windows.Forms;

namespace PW1_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + Convert.ToString(multiplaication(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + Convert.ToString(devision(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + Convert.ToString(addition(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + " " + Convert.ToString(subtraction(Convert.ToDouble(textBox1.Text), Convert.ToDouble(textBox2.Text)));
        }

        public static double multiplaication(double a, double b)    // умножение
        {
            return a * b;
        }

        public static double devision(double a, double b)    // деление
        {
            return a / b;
        }

        public static double addition(double a, double b)   // сложение
        {
            return a + b;
        }

        public static double subtraction(double a, double b)    // вычитание
        {
            return a - b;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}

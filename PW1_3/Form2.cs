using System;
using System.Windows.Forms;
using System.Media;

namespace PW1_3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SoundPlayer sound = new SoundPlayer("15lp.wav");

        private void Form2_Load(object sender, EventArgs e)
        {
            label5.Text = "Разраб: @JF \nВерсия: 1.0\n";
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sound.PlayLooping();
        }
    }
}
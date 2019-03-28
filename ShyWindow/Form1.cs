using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShyWindow
{
    public partial class Form1 : Form
    {
        private Rectangle bounds;
        private Random rand;
        private int max;

        public Form1()
        {
            InitializeComponent();

            bounds = Screen.PrimaryScreen.Bounds;
            Console.WriteLine( bounds);
            rand = new Random();
            max = 750;
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.Location = new Point(rand.Next(0, max), rand.Next(max));
       
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            button2.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button3_MouseEnter(object sender, EventArgs e)
        {
            button3.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button4_MouseEnter(object sender, EventArgs e)
        {
            button4.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button5_MouseEnter(object sender, EventArgs e)
        {
            button5.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button6_MouseEnter(object sender, EventArgs e)
        {
            button6.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button7_MouseEnter(object sender, EventArgs e)
        {
            button7.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button8_MouseEnter(object sender, EventArgs e)
        {
            button8.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button9_MouseEnter(object sender, EventArgs e)
        {
            button9.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button11_MouseEnter(object sender, EventArgs e)
        {
            button11.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button10_MouseEnter(object sender, EventArgs e)
        {
            button10.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void button12_MouseEnter(object sender, EventArgs e)
        {
            button12.Location = new Point(rand.Next(0, max), rand.Next(max));
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            Form newForm = new Form1();
            newForm.ShowDialog();
        }
    }
}

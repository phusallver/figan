using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace figan
{

    public partial class Form1 : Form
    {
        int yeet =0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "1";
            }
            else
            {
                this.textBox1.Text += "1";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "2";
            }
            else
            {
                this.textBox1.Text += "2";
            }
        }

        private void button3_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "3";
            }
            else
            {
                this.textBox1.Text += "3";
            }
        }

        private void button4_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "4";
            }
            else
            {
                this.textBox1.Text += "4";
            }
        }

        private void button5_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "5";
            }
            else
            {
                this.textBox1.Text += "5";
            }
        }

        private void button6_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "6";
            }
            else
            {
                this.textBox1.Text += "6";
            }
        }

        private void button7_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "7";
            }
            else
            {
                this.textBox1.Text += "7";
            }
        }

        private void button8_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "8";
            }
            else
            {
                this.textBox1.Text += "8";
            }
        }

        private void button9_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "9";
            }
            else
            {
                this.textBox1.Text += "9";
            }
        }

        private void button10_MouseClick(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == null)
            {
                this.textBox1.Text = "0";
            }
            else
            {
                this.textBox1.Text += "0";
            }
        }

        private void button12_MouseClick(object sender, MouseEventArgs e)
        {
           
            int v = Convert.ToInt32(textBox1.Text);
            yeet = v;
            textBox1.Text = null;
            
        }

        private void button11_MouseClick(object sender, MouseEventArgs e)
        {
            yeet = yeet + Convert.ToInt32(textBox1.Text);
            string sheesh = yeet.ToString();
            textBox1.Text = sheesh;
        }
    }
}

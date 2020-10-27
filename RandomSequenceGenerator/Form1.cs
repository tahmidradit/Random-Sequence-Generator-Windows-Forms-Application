using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomSequenceGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void TextReset()
        {
            label0.Text = "*";
            label1.Text = "*";
            label2.Text = "*";
            label3.Text = "*";
            label4.Text = "*";
            label5.Text = "*";
            label6.Text = "*";
            label7.Text = "*";
            label8.Text = "*";
            label9.Text = "*";
            label10.Text = "*";
            label13.Text = "*";
            label14.Text = "*";
            label15.Text = "*";
            pictureBox1.Visible = false;
        }
        public void Label10Text()
        {
            if (label10.Text == "0")
            {
                label0.Text = "0";
            }
            if (label10.Text == "1")
            {
                label1.Text = "1";
            }
            if (label10.Text == "2")
            {
                label2.Text = "2";
            }
            if (label10.Text == "3")
            {
                label3.Text = "3";
            }
            if (label10.Text == "4")
            {
                label4.Text = "4";
            }
            if (label10.Text == "5")
            {
                label5.Text = "5";
            }
            if (label10.Text == "6")
            {
                label6.Text = "6";
            }
            if (label10.Text == "7")
            {
                label7.Text = "7";
            }
            if (label10.Text == "8")
            {
                label8.Text = "8";
            }
            if (label10.Text == "9")
            {
                label9.Text = "9";
            }
            pictureBox1.Visible = true;
        }
        public void Label13Text()
        {
            if (label13.Text == "0")
            {
                label0.Text = "0";
            }
            if (label13.Text == "1")
            {
                label1.Text = "1";
            }
            if (label13.Text == "2")
            {
                label2.Text = "2";
            }
            if (label13.Text == "3")
            {
                label3.Text = "3";
            }
            if (label13.Text == "4")
            {
                label4.Text = "4";
            }
            if (label13.Text == "5")
            {
                label5.Text = "5";
            }
            if (label13.Text == "6")
            {
                label6.Text = "6";
            }
            if (label13.Text == "7")
            {
                label7.Text = "7";
            }
            if (label13.Text == "8")
            {
                label8.Text = "8";
            }
            if (label13.Text == "9")
            {
                label9.Text = "9";
            }
            pictureBox1.Visible = true;
        }
        public void Label14Text()
        {
            if (label14.Text == "0")
            {
                label0.Text = "0";
            }
            if (label14.Text == "1")
            {
                label1.Text = "1";
            }
            if (label14.Text == "2")
            {
                label2.Text = "2";
            }
            if (label14.Text == "3")
            {
                label3.Text = "3";
            }
            if (label14.Text == "4")
            {
                label4.Text = "4";
            }
            if (label14.Text == "5")
            {
                label5.Text = "5";
            }
            if (label14.Text == "6")
            {
                label6.Text = "6";
            }
            if (label14.Text == "7")
            {
                label7.Text = "7";
            }
            if (label14.Text == "8")
            {
                label8.Text = "8";
            }
            if (label14.Text == "9")
            {
                label9.Text = "9";
            }
            pictureBox1.Visible = true;
        }
        public void Label15Text()
        {
            if (label15.Text == "0")
            {
                label0.Text = "0";
            }
            if (label15.Text == "1")
            {
                label1.Text = "1";
            }
            if (label15.Text == "2")
            {
                label2.Text = "2";
            }
            if (label15.Text == "3")
            {
                label3.Text = "3";
            }
            if (label15.Text == "4")
            {
                label4.Text = "4";
            }
            if (label15.Text == "5")
            {
                label5.Text = "5";
            }
            if (label15.Text == "6")
            {
                label6.Text = "6";
            }
            if (label15.Text == "7")
            {
                label7.Text = "7";
            }
            if (label15.Text == "8")
            {
                label8.Text = "8";
            }
            if (label15.Text == "9")
            {
                label9.Text = "9";
            }
            pictureBox1.Visible = true;
        }
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {
            Random random = new Random();
            int randomNumber1 = random.Next(0, 9);
            int randomNumber2 = random.Next(0, 9);
            int randomNumber3 = random.Next(0, 9);
            int randomNumber4 = random.Next(0, 9);
            label10.Text = randomNumber1.ToString();
            label13.Text = randomNumber2.ToString();
            label14.Text = randomNumber3.ToString();
            label15.Text = randomNumber4.ToString();
            Label10Text();
            Label13Text();
            Label14Text();
            Label15Text();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TextReset();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

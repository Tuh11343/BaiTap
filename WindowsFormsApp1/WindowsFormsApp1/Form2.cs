using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            
        }

        private void button11_Click(object sender, EventArgs e)
        {
            string Path = "C:\\Users\\ADMIN\\Desktop\\test.txt";
            switch (Convert.ToInt32(textBox1.Text))
            {
                case 1645:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Techicians\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Techicians");
                    break;
                case 1689:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Techicians\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Techicians");
                    break;
                case 8345:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Custodians\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Custodians");
                    break;
                case 9998:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Scientists\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Scientists");
                    break;
                case 1006:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Scientist\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Scientists");
                    break;
                case 1007:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Scientist\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Scientists");
                    break;
                case 1008:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Scientist\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Scientists");
                    break;
                    default:
                    File.AppendAllText(Path, DateTime.Now.ToString() + " " + " Restricted Access\n");
                    listBox1.Items.Add(DateTime.Now.ToString() + " " + " Restricted Access");
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.D0)
            {
                //e.Handled = true;
                textBox1.Text += "0";
            }
            else if (e.KeyCode == Keys.D1)
            {
                textBox1.Text += "1";
            }
            else if (e.KeyCode == Keys.D2)
            {
                textBox1.Text += "2";
            }
            else if (e.KeyCode == Keys.D3)
            {
                textBox1.Text += "3";
            }
            else if (e.KeyCode == Keys.D4)
            {
                textBox1.Text += "4";
            }
            else if (e.KeyCode == Keys.D5)
            {
                textBox1.Text += "5";
            }
            else if (e.KeyCode == Keys.D6)
            {
                textBox1.Text += "6";
            }
            else if (e.KeyCode == Keys.D7)
            {
                textBox1.Text += "7";
            }
            else if (e.KeyCode == Keys.D8)
            {
                textBox1.Text += "8";
            }
            else if (e.KeyCode == Keys.D9)
            {
                textBox1.Text += "9";
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (textBox1.Text.Length != 0)
                {
                    textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length != 0)
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            }
        }
    }
}

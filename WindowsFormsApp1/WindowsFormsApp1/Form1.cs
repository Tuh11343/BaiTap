using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (Properties.Settings.Default.userName.Length!=0)
            {
                textBox1.Text = Properties.Settings.Default.userName;
            }
            if (Properties.Settings.Default.passWord.Length != 0)
            {
                textBox2.Text = Properties.Settings.Default.passWord;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                Properties.Settings.Default.userName = textBox1.Text;
                Properties.Settings.Default.passWord = textBox2.Text;
                Properties.Settings.Default.Save();
            }
            else
            {
                Properties.Settings.Default.userName = null;
                Properties.Settings.Default.passWord = null;
                Properties.Settings.Default.Save();
            }
        }
    }
}

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
    public partial class LAB01 : Form
    {
        public LAB01()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LAB01_bai01 frombai01 = new LAB01_bai01();
            frombai01.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LAB01_bai02 frombai02 = new LAB01_bai02();
            frombai02.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LAB01_bai03 frombai03 = new LAB01_bai03();
            frombai03.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LAB01_bai05 frombai05 = new LAB01_bai05();
            frombai05.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            LAB01_bai06 frombai06 = new LAB01_bai06();
            frombai06.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            LAB01_bai07 frombai07 = new LAB01_bai07();
            frombai07.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            LAB01_bai08 frombai08 = new LAB01_bai08();
            frombai08.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            LAB01_bai03_1 frombai03_1 = new LAB01_bai03_1();
            frombai03_1.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            LAB01_bai04 frombai04 = new LAB01_bai04();
            frombai04.Show();
        }
    }
}

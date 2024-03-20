using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class LAB01_bai01 : Form
    {
        public LAB01_bai01()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int check1 = 0;
            int check2 = 0;
            int i = 0;
            int j = 0;
            while (i < textBox2.Text.Length) {
                if (textBox2.Text[i] > 57 || textBox2.Text[i] < 48)
                {
                    check1++;
                }
                i++;
            }
            while (j< textBox3.Text.Length)
            {
                if (textBox3.Text[j] > 57 || textBox3.Text[j] < 48) 
                {
                    check2++;
                }
                j++;
            }
            if (check2 >0 || check1 >0)
            {
                MessageBox.Show("Vui long nhap so nguyen!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else if (textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Vui long nhap so nguyen!", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
            }
            else
            {
                int num1, num2;
                long sum = 0;
                num1 = int.Parse(textBox2.Text);
                num2 = int.Parse(textBox3.Text);
                sum = num1 + num2;
                textBox4.Text = sum.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text=String.Empty;
            textBox3.Text=String.Empty; 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

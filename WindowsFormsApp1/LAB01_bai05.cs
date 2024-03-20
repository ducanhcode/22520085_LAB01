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
    public partial class LAB01_bai05 : Form
    {
        public LAB01_bai05()
        {
            InitializeComponent();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private int Factorial(int n)
        {
            if (n == 0)
                return 1;
            else
                return n * Factorial(n - 1);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int A = int.Parse(textBox1.Text);
            int B = int.Parse(textBox2.Text);
       
           
                if (comboBox1.SelectedItem.ToString() == "Tính bảng cửu chương")
                {
                    // Tính bảng cửu chương của B-A
                    string result = "";
                    result += $"Bảng cửu chương của {B-A}:\n";
                    for (int i = 1; i <= 10; i++)
                    {
                        result += $"{B-A}*{i}={(B - A) * i}\n";
                    }
                    label3.Text = result;
                }
                else if (comboBox1.SelectedItem.ToString() == "Tính toán giá trị")
                {
                    // Tính (A – B)!
                    int result = Factorial(A - B);

                    // Tính tổng S = A^1 + A^2 + A^3 + A^4 + … + A^B
                    double sum = 0;
                    for (int i = 1; i <= B; i++)
                    {
                        sum += Math.Pow(A, i);
                    }
                    label3.Text = $"({A}-{B})! = {result} \n Tổng S= {sum}";
                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

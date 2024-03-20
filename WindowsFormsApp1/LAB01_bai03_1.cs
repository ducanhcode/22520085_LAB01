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
    public partial class LAB01_bai03_1 : Form
    {
        public LAB01_bai03_1()
        {
            InitializeComponent();
        }
        private string numToString(long num)
        {
            switch (num)
            {
                case 0:
                    return "";
                case 1:
                    return "một";
                case 2:
                    return "hai";
                case 3:
                    return "ba";
                case 4:
                    return "bốn";
                case 5:
                    return "năm";
                case 6:
                    return "sáu";
                case 7:
                    return "bảy";
                case 8:
                    return "tám";
                case 9:
                    return "chín";
            }
            return "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            long result = long.Parse(textBox1.Text);
            long[] digits = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            int count = 0;
            while (result > 0)
            {
                digits[count++] = result % 10;
                result /= 10;
            }

            string resultString = "";
            for (int i = 0; i < count; i++)
            {
                if (i == 3) resultString = "nghìn " + resultString;
                else if (i == 6) resultString = "triệu " + resultString;
                else if (i == 9) resultString = "tỷ " + resultString;
                if (i % 3 == 1)
                {
                    long digit = digits[i];
                    if (digit == 0)
                    {
                        resultString = "lẻ " + resultString;
                    }
                    else if (digit == 1)
                    {
                        resultString = "mười " + resultString;
                    }
                    else
                    {
                        resultString = numToString(digits[i]) + " mươi " + resultString;
                    }
                }
                else if (i % 3 == 2)
                {
                    resultString = numToString(digits[i]) + " trăm " + resultString;
                }
                else
                {
                    long digit = digits[i];
                    if (digit == 5 && digits[i + 1] != 0) resultString = "lăm " + resultString;
                    else resultString = numToString(digits[i]) + " " + resultString;
                }
            }
            textBox2.Text = resultString;
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

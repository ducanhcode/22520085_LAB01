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
    public partial class LAB01_bai02 : Form
    {
        public LAB01_bai02()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LAP01_bai02_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void tim_Click(object sender, EventArgs e)
        {
            int so1, so2, so3;
            int min, max;
            if (!int.TryParse(textBox1.Text, out so1) || !int.TryParse(textBox2.Text, out so2) || !int.TryParse(textBox3.Text, out so3))
            {
                MessageBox.Show("Vui lòng nhập các số nguyên hợp lệ!");
                return;
            }
            max = Math.Max(so1, Math.Max(so2, so3));
            solonnhat.Text = max.ToString();
            min = Math.Min(so1, Math.Min(so2, so3));
            textBox5.Text = min.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = string.Empty;
            textBox2.Text = string.Empty;
            textBox3.Text = string.Empty;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

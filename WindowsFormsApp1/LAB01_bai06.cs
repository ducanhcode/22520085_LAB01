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
    public partial class LAB01_bai06 : Form
    {
        public LAB01_bai06()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;

            // Tách ngày, tháng, năm từ chuỗi nhập vào
            string[] parts = input.Split('/');
            int day = int.Parse(parts[0]);
            int month = int.Parse(parts[1]);
            int year = int.Parse(parts[2]);

            // Xác định cung hoàng đạo
            string Cung = "";
            switch (month)
            {
                case 1:
                    if (day <= 19)
                        Cung = "Ma Kết";
                    else
                        Cung = "Bảo Bình";
                    break;
                case 2:
                    if (day <= 19)
                        Cung = "Bảo Bình";
                    else
                        Cung = "Song Ngư";
                    break;
                case 3:
                    if (day <= 20)
                        Cung = "Song Ngư";
                    else
                        Cung = "Bạch Dương";
                    break;
                case 4:
                    if (day <= 20)
                        Cung = "Bạch Dương";
                    else
                        Cung = "Kim Ngưu";
                    break;
                case 5:
                    if (day <= 21)
                        Cung = "Kim Ngưu";
                    else
                        Cung = "Song Tử";
                    break;
                case 6:
                    if (day <= 21)
                        Cung = "Song Tử";
                    else
                        Cung = "Cự Giải";
                    break;
                case 7:
                    if (day <= 22)
                        Cung = "Cự Giải";
                    else
                        Cung = "Sư Tử";
                    break;
                case 8:
                    if (day <= 22)
                        Cung = "Sư Tử";
                    else
                        Cung = "Xử Nữ";
                    break;
                case 9:
                    if (day <= 23)
                        Cung = "Xử Nữ";
                    else
                        Cung = "Thiên Bình";
                    break;
                case 10:
                    if (day <= 23)
                        Cung = "Thiên Bình";
                    else
                        Cung = "Thần Nông";
                    break;
                case 11:
                    if (day <= 22)
                        Cung = "Thần Nông";
                    else
                        Cung = "Nhân Mã";
                    break;
                case 12:
                    if (day <= 21)
                        Cung = "Nhân Mã";
                    else
                        Cung = "Ma Kết";
                    break;
                default:
                    textBox2.Text = ("Ngày tháng không hợp lệ.");
                    return;
            }

            textBox2.Text =  Cung;
        }

        private void label2_Click(object sender, EventArgs e)
        {

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

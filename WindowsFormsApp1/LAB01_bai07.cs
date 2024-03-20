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
    public partial class LAB01_bai07 : Form
    {
        public LAB01_bai07()
        {
            InitializeComponent();
        }
        private bool Check(string input)
        {
            // Tách dữ liệu
            string[] data = input.Split(',');

            // Kiểm tra số lượng phần tử
            if (data.Length < 2)
            {
                return false;
            }

            // Kiểm tra phần điểm
            for (int i = 1; i < data.Length; i++)
            {
                float diem;
                if (!float.TryParse(data[i], out diem))
                {
                    return false;
                }

                // Kiểm tra dấu cách phẩy
                if (!data[i].StartsWith(" "))
                {
                    return false;
                }
            }

            return true;
        }
        private string XepLoai(float diemTrungbinh, float[] diem)
        {
            bool coDiemduoi65 = false, coDiemduoi5 = false, coDiemduoi35 = false, coDiemduoi2 = false;
            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] < 6.5)
                {
                    coDiemduoi65 = true;
                }
                if (diem[i] < 5)
                {
                    coDiemduoi5 = true;
                }
                if (diem[i] < 3.5)
                {
                    coDiemduoi35 = true;
                }
                if (diem[i] < 2)
                {
                    coDiemduoi2 = true;
                }
            }
            if (diemTrungbinh >= 8 && !coDiemduoi5)
            {
                return "Giỏi";
            }
            if (diemTrungbinh >= 6.5 && !coDiemduoi5)
            {
                return "Khá";
            }
            else if (diemTrungbinh >= 5 && !coDiemduoi35)
            {
                return "Trung bình";
            }
            else if (diemTrungbinh >= 3.5 && !coDiemduoi2)
            {
                return "Yếu";
            }
            else
            {
                return "Kém";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string input = Nhap.Text;

            //Kiểm tra tính hợp lệ
            bool isValid = Check(input);
            if (!isValid)
            {
                MessageBox.Show(" Định dạng không hợp lệ! ");
                return;
            }

            string[] data = input.Split(',');
            string hoten = data[0];
            float[] diem = new float[data.Length - 1];
            for (int i = 1; i < data.Length; i++)
            {
                diem[i - 1] = float.Parse(data[i]);
            }

            hovaten.Text = hoten;

            danhsachdiem.Text = "";
            for (int i = 0; i < diem.Length; i++)
            {
                danhsachdiem.Text += "Môn " + (i + 1) + ": " + diem[i] + " ";
            }

            float diemTrungbinh = diem.Average();
            float diemMax = diem.Max();
            float diemMin = diem.Min();
            int dau = 0, khongdau = 0;
            for (int i = 0; i < diem.Length; i++)
            {
                if (diem[i] >= 5)
                {
                    dau++;
                }
                else
                {
                    khongdau++;
                }
            }
            string xepLoai = XepLoai(diemTrungbinh, diem);

            // Xuất kết quả
            diemtrungbinh.Text = diemTrungbinh.ToString();
            diemmax.Text = diemMax.ToString();
            diemmin.Text = diemMin.ToString();
            somondau.Text=dau.ToString();
            somonkhongdau.Text=khongdau.ToString();
            xeploai.Text = xepLoai;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nhap.Text = string.Empty;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

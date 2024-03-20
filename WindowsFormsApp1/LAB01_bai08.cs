using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class LAB01_bai08 : Form
    {
        List<string> danhSachMonAn = new List<string>();

        public LAB01_bai08()
        {
            InitializeComponent();
            danhSachMonAn.Add("Phở") ;
            danhSachMonAn.Add("Bún riêu");
            danhSachMonAn.Add("Bún thịt nướng");
            danhSachMonAn.Add("Cơm tấm sườn trứng");
            danhSachMonAn.Add("Gỏi cuốn");
            HienThiDanhSachMonAn();
        }

        private void them_Click(object sender, EventArgs e)
        {
            string monAnMoi = monan.Text.Trim();
            if (danhSachMonAn.Contains(monAnMoi))
            {
                MessageBox.Show("Món ăn này đã có trong danh sách!");
                return;
            }
            // Thêm món ăn mới vào danh sách
            danhSachMonAn.Add(monAnMoi);

            // Xóa textbox món ăn
            monan.Clear();
            
            // Hiển thị danh sách món ăn
            HienThiDanhSachMonAn();
        }

        private void tim_Click(object sender, EventArgs e)
        {
            // Kiểm tra xem danh sách món ăn có rỗng hay không
            if (danhSachMonAn.Count == 0)
            {
                MessageBox.Show("Vui lòng thêm món ăn vào danh sách!");
                return;
            }

            // Tạo số ngẫu nhiên
            Random random = new Random();
            int viTriMonAn = random.Next(danhSachMonAn.Count);

            // Hiển thị món ăn được chọn
            monanhomnay.Text = danhSachMonAn[viTriMonAn].ToString();
        }

        private void HienThiDanhSachMonAn()
        {
            string danhSach = "";
            foreach (string monAn in danhSachMonAn)
            {
                danhSach += (monAn + "\n");
            }
            danhsach.Text = danhSach;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            monan.Text = String.Empty;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TranVanLy_2121110246
{
    public partial class Form1 : Form
    {
        string tentaikhoan = "tranvanly";
        string matkhau = "12345";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if(KiemTraDangNhap(txbTaiKhoan.Text, txbMatKhau.Text))
            {
                Form2 f = new Form2();
                f.Show();
                this.Hide();
                f.DangXuat += F_DangXuat;
            }    
            else
            {
                MessageBox.Show("Sai ten tai khoan hoac mat khau", "Loi");
                txbTaiKhoan.Focus();
            }    
        }

        private void F_DangXuat(object sender, EventArgs e)
        {
            (sender as Form2).isThoat = false;
            (sender as Form2).Close();
            this.Show();
        }

        bool KiemTraDangNhap(string tentaikhoan, string matkhau)
        {
            if (tentaikhoan == this.tentaikhoan && matkhau == this.matkhau)
            {
                return true;
            }    

                return false;
        }

        private void txbTaiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbMatKhau_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

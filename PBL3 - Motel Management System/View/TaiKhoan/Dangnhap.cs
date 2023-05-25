using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System
{
    public partial class Dangnhap : Form
    {
        public Dangnhap()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(QLBLL.Instance.GetIdTk(txtTaiKhoan.Text,txtMatKhau.Text) != null)
            {
                VaiTro vaitro = QLBLL.Instance.CheckVaiTro(txtTaiKhoan.Text, txtMatKhau.Text);
                if(vaitro.TenVaiTro=="Chủ trọ")
                {
                    TrangChu tc = new TrangChu();
                    tc.Show();
                    this.Hide();
                }
                else
                {
                    string matk = vaitro.MaTaiKhoan;
                    TrangChuKhach tc = new TrangChuKhach(matk);
                    tc.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác", "Thông Báo", MessageBoxButtons.OK);
            }

            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if(txtMatKhau.PasswordChar=='*')
            {
                btnChiTiet.BringToFront();
                txtMatKhau.PasswordChar = '\0';
            }
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            if (txtMatKhau.PasswordChar == '\0')
            {
                iconButton1.BringToFront();
                txtMatKhau.PasswordChar = '*';
            }
        }
    }
}

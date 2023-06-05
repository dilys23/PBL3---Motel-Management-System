using PBL3___Motel_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class TaiKhoanPhong : Form
    {
        private string idp;
        private string idct;
        public TaiKhoanPhong(string idp, string idct)
        {
            InitializeComponent();
            this.idp = idp;
            this.idct = idct;
            LoadForm(null);
            
        }
        private void LoadForm(string txt)
        {
            txtTenTaiKhoan.Clear();
            txtMatKhau.Clear();
            if (idp != null && idct == null)
            {
                DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdPhong(idp);
                txtTenTaiKhoan.Text = tk.TenTaiKhoan;
                txtMatKhau.Text = tk.MatKhau;
            }
            else if (idp == null && idct != null) 
            {
                DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdTaiKhoan(this.idct);
                txtTenTaiKhoan.Text += tk.TenTaiKhoan;
                txtMatKhau .Text += tk.MatKhau;
            } 
                
            
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            
            QLBLL.Instance.openChildForm1(new DoiMK(idp, idct,LoadForm), panel1);
        }

        private void btnTrove_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
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

    public partial class ChuTro : Form
    {
        private string matk;
        public ChuTro(string matk)
        {
            InitializeComponent();
            this.matk = matk;
            if(this.matk != null)
            {
                DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdTaiKhoan(this.matk);
                Nguoi ng = QLBLL.Instance.GetNguoiByMaTaiKhoan(this.matk);
                txtTen.Text = ng.Ten;
                txtSdt.Text = ng.Sdt;
                txtDiaChi.Text = ng.Diachi;
                txtCccd.Text = ng.Cccd;
                txtMatKhau.Text = tk.MatKhau;
            }    
            
            
        }
        public void SetGUI ()
        {
            DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdTaiKhoan(this.matk);
            Nguoi ng = QLBLL.Instance.GetNguoiByMaTaiKhoan(this.matk);
            txtTen.Text = ng.Ten;
            txtSdt.Text = ng.Sdt;
            txtDiaChi.Text = ng.Diachi;
            txtCccd.Text = ng.Cccd;
            txtMatKhau.Text = tk.MatKhau;

        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

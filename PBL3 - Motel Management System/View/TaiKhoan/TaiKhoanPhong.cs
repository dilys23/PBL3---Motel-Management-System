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
        public TaiKhoanPhong(string idp)
        {
            InitializeComponent();
            this.idp=idp;
            LoadForm(null);
        }
        private void LoadForm(string txt)
        {
            DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdPhong(idp);
            txtTenTaiKhoan.Text = tk.TenTaiKhoan;
            txtMatKhau.Text = tk.MatKhau;
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new DoiMK(idp, null), panel1);
        }
    }
}

using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
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
        private string idng;
        
        public ChuTro(string matk)
        {
            InitializeComponent();
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, ptAnh.Width - 3, ptAnh.Height - 3);
            Region rg = new Region(gp);
            ptAnh.Region = rg;
            this.matk = matk;
            LoadForm(null);  
        }
        public void LoadForm(string txt)
        {
            if (this.matk != null)
            {
                DAL.TaiKhoan tk = QLBLL.Instance.GetTaiKhoanByIdTaiKhoan(this.matk);
                Nguoi ng = QLBLL.Instance.GetNguoiByMaTaiKhoan(this.matk);
                txtTen.Text = ng.Ten;
                txtSdt.Text = ng.Sdt;
                txtDiaChi.Text = ng.Diachi;
                txtCccd.Text = ng.Cccd;
                if (ng.GioiTinh == true) rdbtnNam.Checked = true;
                else rdbtnNu.Checked = true;
                TenTK.Text = tk.TenTaiKhoan;
                if (ng.HinhAnh != null)
                {
                    ptAnh.Image = ChuyenDoiAnh.Base64ToImage(ng.HinhAnh);
                }

            }
        }
        private void btnTrove_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDoiMK_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new DoiMK(null, matk, LoadForm), panel1);
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
           // Nguoi ng = new Nguoi();
            Nguoi ng = QLBLL.Instance.GetNguoiByMaTaiKhoan(this.matk);
           // this.idng = ng.MaNguoi;
            QLBLL.Instance.openChildForm1(new ThemKhach(null, LoadForm), panel1);
        }

        private void btnSua_Click_1(object sender, EventArgs e)
        {
            Nguoi ng = QLBLL.Instance.GetNguoiByMaTaiKhoan(this.matk);
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaNguoi = ng.MaNguoi;
            QLBLL.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panel1);
        }

       
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            //QLBLL.Instance.openChildForm1(new TaiKhoanPhong(null, matk), panel1);
            QLBLL.Instance.openChildForm1(new DoiMK(null, matk,LoadForm), panel1);
        }
    }
}

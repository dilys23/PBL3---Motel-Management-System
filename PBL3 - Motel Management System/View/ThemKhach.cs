using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
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
    public partial class ThemKhach : Form
    {   private ThuePhong thuePhong;
        private Loader loader;
        public ThemKhach(ThuePhong tp, Loader loader)
        {
            InitializeComponent();
            this.thuePhong = tp;
            this.loader=loader;
        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();
        }

        private void ThemKhach_Load(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        TrangChu tc = new TrangChu();


        private Boolean checkHopLe()
        {
            int i = 0;
            errorProvider1.SetError(txtTen, "");
            errorProvider1.SetError(txtSdt, "");
            errorProvider1.SetError(txtDiaChi, "");
            errorProvider1.SetError(txtCccd, "");
            errorProvider1.SetError(rdbtnNu, "");
            if (txtTen.Text == "")
            {
                errorProvider1.SetError(txtTen, "Vui lòng nhập họ và tên");
                i++;

            }
            if (txtSdt.Text == "")
            {
                errorProvider1.SetError(txtSdt, "Vui lòng nhập số điện thoại");
                i++;

            }
            if (txtDiaChi.Text == "")
            {
                errorProvider1.SetError(txtDiaChi, "Vui lòng nhập địa chỉ");
                i++;

            }
            if (txtCccd.Text == "")
            {
                errorProvider1.SetError(txtCccd, "Vui lòng nhập căn cước công dân");
                i++;

            }
            if(!rdbtnNam.Checked && !rdbtnNu.Checked)
            {
                errorProvider1.SetError(rdbtnNu, "Vui lòng chọn giới tính");
                i++;
            }
            if (i==0) return true;
            else return false;

        }
        
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            if(checkHopLe())
            {
                QLBLL qLBLL = new QLBLL();
                Nguoi nguoi = new Nguoi();
                nguoi.MaNguoi = qLBLL.TaoIdNguoi();
                nguoi.Cccd = txtCccd.Text;
                nguoi.Ten = txtTen.Text;
                nguoi.Sdt = txtSdt.Text;
                nguoi.Diachi = txtDiaChi.Text;
                nguoi.GioiTinh = (rdbtnNam.Checked);
                nguoi.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                if (thuePhong.hopDong.MaHopDong != null)
                {
                thuePhong.hopDong.Nguoi = nguoi;
                tc.openChildForm1(new ThemDVphong(thuePhong, Back), panelKhach);
                }
                else
                {
                    ThanhVienTrongPhong tvtp = new ThanhVienTrongPhong();
                    tvtp.MaThanhVienTrongPhong = qLBLL.TaoIdThanhVienTrongPhong();
                    tvtp.MaNguoi = nguoi.MaNguoi;
                    tvtp.MaPhongTro = thuePhong.hopDong.MaPhongTro;
                    qLBLL.AddNguoiBll(nguoi);
                    qLBLL.AddThanhVienTrongPhongBll(tvtp);
                    MessageBox.Show("Thêm thành viên vào phòng thành công", "Thông báo", MessageBoxButtons.OK);
                    this.loader(null);
                    this.Close();

                }
            }
            
        }
    }
}

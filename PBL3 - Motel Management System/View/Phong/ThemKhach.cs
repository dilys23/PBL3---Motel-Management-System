﻿using PBL3___Motel_Management_System.BLL;
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
using System.Windows.Media.Media3D;

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
            LoadForm();
        }
        private void Back(string txt)
        {
            this.loader(null);
            this.Close();
        }
        private void LoadForm()
        {
            if (thuePhong.hopDong.MaNguoi != null)
            {
                Nguoi nguoi = QLBLLNguoi.Instance.GetNguoiByIdNguoi(thuePhong.hopDong.MaNguoi);
                txtTen.Text = nguoi.Ten;
                txtCccd.Text = nguoi.Cccd;
                txtSdt.Text = nguoi.Sdt;
                txtDiaChi.Text = nguoi.Diachi;
                if (nguoi.GioiTinh == true)
                    rdbtnNam.Checked = true;
                else
                    rdbtnNu.Checked = true;
                if (nguoi.HinhAnh != null)
                {
                    pctKhach.Image = QLBLLChung.Instance.Base64ToImage(nguoi.HinhAnh);
                }
            }
        }

        private void iconButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
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
            if (checkHopLe())
            {
                Nguoi nguoi = new Nguoi();
                if (thuePhong.hopDong.MaNguoi == null)
                {
                    nguoi.MaNguoi = QLBLLNguoi.Instance.TaoIdNguoi();
                }
                else
                {
                    nguoi.MaNguoi = thuePhong.hopDong.MaNguoi;
                }
                nguoi.TonTai = true;
                nguoi.Cccd = txtCccd.Text;
                nguoi.Ten = txtTen.Text;
                nguoi.Sdt = txtSdt.Text;
                nguoi.Diachi = txtDiaChi.Text;
                nguoi.GioiTinh = (rdbtnNam.Checked);
                nguoi.NgaySinh = dtpNgaySinh.Value.ToString("yyyy-MM-dd");
                if (pctKhach.Image != null)
                {
                    nguoi.HinhAnh = QLBLLChung.Instance.ImageToBase64(pctKhach.Image, pctKhach.Image.RawFormat);
                }
                if (thuePhong.hopDong.MaHopDong != null)
                {
                    thuePhong.hopDong.Nguoi = nguoi;
                    QLBLLChung.Instance.openChildForm1(new ThemDVphong(thuePhong, Back), panelKhach);
                }
                else if (this.thuePhong.hopDong.MaNguoi == null)
                {
                    ThanhVienTrongPhong tvtp = new ThanhVienTrongPhong();
                    tvtp.MaThanhVienTrongPhong = QLBLLThanhVienTrongPhong.Instance.TaoIdThanhVienTrongPhong();
                    tvtp.MaNguoi = nguoi.MaNguoi;
                    tvtp.MaPhongTro = thuePhong.hopDong.MaPhongTro;
                    tvtp.TonTai = true;
                    QLBLLNguoi.Instance.AddNguoiBll(nguoi);
                    QLBLLThanhVienTrongPhong.Instance.AddThanhVienTrongPhongBll(tvtp);
                    MessageBox.Show("Thêm thành viên vào phòng thành công", "Thông báo", MessageBoxButtons.OK);
                    this.loader(null);
                    this.Close();

                }
                else
                {
                    QLBLLNguoi.Instance.UpdateNguoiBLL(nguoi);
                    MessageBox.Show("Thay đổi thông tin thành công", "Thông báo", MessageBoxButtons.OK);
                    this.loader(null);
                    this.Close();
                }
                
            }
        }
     
        string imgLocation = "";
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = " ipg files(*.jpg)|*.jpg|jpg files(*.jpg)|*.jpg|All files(*.*)|*.*";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                imgLocation = dialog.FileName.ToString();
                pctKhach.ImageLocation = imgLocation;    
            }    
        }

        private void pctKhach_Click(object sender, EventArgs e)
        {

        }
    }
}

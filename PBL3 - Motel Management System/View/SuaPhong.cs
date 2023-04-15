﻿using PBL3___Motel_Management_System.BLL;
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
    public partial class SuaPhong : Form
    {
        private string IdPhong;
        private Loader Loader;
        public SuaPhong(string IdPhong,Loader Loader)
        {
            InitializeComponent();        
            this.IdPhong = IdPhong;
            this.Loader = Loader;
            FormLoad(IdPhong);
        }
        public void FormLoad(string IdPhong)
        {
            QLBLL qLBLL = new QLBLL();
            PhongTro phongTro= qLBLL.GetPhongTroByIdPhong(IdPhong);
            if(IdPhong != null)
            {
                txtTenPhong.Text = phongTro.TenPhongTro.ToString(); 
                txtDienTich.Text = phongTro.DienTich.ToString();
                txtGiaTien.Text = phongTro.GiaTien.ToString();
                txtToiDa.Text= phongTro.ToiDa.ToString();
            }
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
               this.Close();
        }
        public Boolean CheckHL()
        {
            int i = 0;
            errorProvider1.SetError(txtTenPhong, "");
            errorProvider1.SetError(txtGiaTien, "");
            errorProvider1.SetError(txtDienTich, "");
            errorProvider1.SetError(txtToiDa, "");
            if (txtTenPhong.Text == "")
            {
                i++;
                errorProvider1.SetError(txtTenPhong, "Vui lòng điền tên phòng");
            }
            if (txtGiaTien.Text == "")
            {
                i++;
                errorProvider1.SetError(txtGiaTien, "Vui lòng điền giá phòng");
            }
            if (txtDienTich.Text == "")
            {
                i++;
                errorProvider1.SetError(txtDienTich, "Vui lòng điền diện tích phòng");
            }
            if (txtToiDa.Text == "")
            {
                i++;
                errorProvider1.SetError(txtDienTich, "Vui lòng điền số lượng tối đa");
            }



            if (txtGiaTien.Text != "")
            {
                if (!double.TryParse(txtGiaTien.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtGiaTien, "Giá phòng phải bằng số");
                }
            }
            if (txtDienTich.Text != "")
            {
                if (!double.TryParse(txtDienTich.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtDienTich, "Diện tích phòng phải bằng số");
                }
            }
            if (txtToiDa.Text != "")
            {
                if (!double.TryParse(txtToiDa.Text, out double d))
                {
                    i++;
                    errorProvider1.SetError(txtToiDa, "Số lượng người tối đa phải bằng số");
                }
            }


            if (i == 0) return true;
            return false;
        }
        private void iconButton4_Click(object sender, EventArgs e)
        {
            if (CheckHL())
            {
                QLBLL qLBLL = new QLBLL();
                PhongTro pt = new PhongTro();
                pt.MaPhongTro = IdPhong;
                pt.TenPhongTro = txtTenPhong.Text;
                pt.DienTich = Convert.ToDouble(txtDienTich.Text);
                pt.GiaTien = Convert.ToDouble(txtGiaTien.Text);
                pt.ToiDa = Convert.ToInt32(txtToiDa.Text);
                qLBLL.UpdatePTBLL(pt);
                MessageBox.Show("Thay đổi thông tin thành công", "Thông báo");
                Loader(null);
                this.Close();
            }
        }
    }
}

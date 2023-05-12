using PBL3___Motel_Management_System.BLL;
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
    public partial class ChiTietPT : Form
    {
        private string idPhong;
        public ChiTietPT(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
        }
        public void LoadForm(string a)
        {
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;
            ChitietHD ct = new ChitietHD(tp, LoadForm);
            tc.openChildForm1(ct, panelChitietPT);

        }
        TrangChu tc = new TrangChu();     
        private void btnHopDong_Click_1(object sender, EventArgs e)
        { 
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaPhongTro =idPhong;
            ChitietHD ct= new ChitietHD(tp,LoadForm);
            tc.openChildForm1(ct, panelChitietPT);
           
        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {

            tc.openChildForm1(new ChitietThanhVien(idPhong), panelChitietPT);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietDV(idPhong),panelChitietPT);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new ChitietTB(idPhong), panelChitietPT);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            tc.openChildForm1(new TaiKhoanPhong(), panelChitietPT);
        }
    }
}

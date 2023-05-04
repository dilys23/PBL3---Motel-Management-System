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
            ChitietHopDong ct = new ChitietHopDong(tp, LoadForm);
            tc.openChildForm1(ct, panelChitietPT);
            ct.btnXacNhan.Visible = false;
        }
        TrangChu tc = new TrangChu();
        QLBLL qLBLL = new QLBLL();
        //tp.hopDong.MaHopDong =qLBLL.GetHopDongByIdPhong(idPhong).MaHopDong;
        private void btnHopDong_Click_1(object sender, EventArgs e)
        {
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;
            ChitietHopDong ct = new ChitietHopDong(tp, LoadForm);
            tc.openChildForm1(ct, panelChitietPT);
            ct.btnXacNhan.Visible = false;
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
            tc.openChildForm1(new ChitietDichVu(idPhong),panelChitietPT);
        }
    }
}

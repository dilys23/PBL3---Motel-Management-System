using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChiTietPT : Form
    {
        private string idPhong;
        private _SuKien suKien;
        public ChiTietPT(_SuKien suKien, string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            this.suKien = suKien;
            LoadForm(null);
        }
      
        public void LoadForm(string a)
        {

            panelChitietPT.Controls.Clear();
            if (QLBLL.Instance.TinhTrangPhongById(idPhong) == false)
            {
                string b = "Phòng này chưa được thuê, chưa có hợp đồng";
                QLBLL.Instance.TaoPanel(b, panelChitietPT);
            }
            else
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                ChitietHopDongPhong ct = new ChitietHopDongPhong(tp, LoadForm);
                QLBLL.Instance.openChildForm1(ct, panelChitietPT);
               
            }
        }

        private void btnHopDong_Click_1(object sender, EventArgs e)
        {
           panelChitietPT.Controls.Clear();
            if (QLBLL.Instance.TinhTrangPhongById(idPhong) == false)
            {
                string b = "Phòng này chưa được thuê, chưa có hợp đồng";
                QLBLL.Instance.TaoPanel(b, panelChitietPT);
            }
            else
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                ChitietHopDongPhong ct = new ChitietHopDongPhong(tp, LoadForm);
                QLBLL.Instance.openChildForm1(ct, panelChitietPT);
              
            }
        }


        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new ChitietThanhVien(idPhong), panelChitietPT);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            PhongTro pt = QLBLL.Instance.GetPhongTroByIdPhong(idPhong);
            Button btn = new Button();
            btn.Name = pt.MaDayTro;
            this.Close();
            suKien(btn,EventArgs.Empty);

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new ChitietDV(idPhong),panelChitietPT);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ChitietTB ct = new ChitietTB(idPhong);
            QLBLL.Instance.openChildForm1(ct, panelChitietPT);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new TaiKhoanPhong(idPhong, null), panelChitietPT);
        }

        private void btnCocPhong_Click(object sender, EventArgs e)
        {
            panelChitietPT.Controls.Clear();
           

            if (QLBLL.Instance.PhongDaCocByIdPhong(idPhong) == false && QLBLL.Instance.TinhTrangPhongById(idPhong) == true)
            {
                string b = "Phòng đã được thuê, không có chi tiết cọc";
                QLBLL.Instance.TaoPanel(b, panelChitietPT);
            }
            else if (QLBLL.Instance.PhongDaCocByIdPhong(idPhong) == false && QLBLL.Instance.TinhTrangPhongById(idPhong) == false)
            {
                string b = "Phòng chưa được cọc và còn trống";
                QLBLL.Instance.TaoPanel(b, panelChitietPT);
            }    
            else
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                CocPhong cp = new CocPhong(tp, LoadForm);
                QLBLL.Instance.openChildForm1(cp, panelChitietPT);
               
            }
        }
    }
}

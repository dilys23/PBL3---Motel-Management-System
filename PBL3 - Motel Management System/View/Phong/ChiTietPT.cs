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
            if (QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) == false)
            {
                string b = "Phòng này đang còn trống";
                QLBLLChung.Instance.TaoPanel(b, panelChitietPT);
            }
            else
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                ChitietHopDongPhong ct = new ChitietHopDongPhong(tp, LoadForm);
                QLBLLChung.Instance.openChildForm1(ct, panelChitietPT);
               
            }
        }

        private void btnHopDong_Click_1(object sender, EventArgs e)
        {
           panelChitietPT.Controls.Clear();
            if (QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) == false)
            {
                string b = "Phòng chưa có hợp đồng, đang còn trống";
                QLBLLChung.Instance.TaoPanel(b, panelChitietPT);
            }
            else
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                ChitietHopDongPhong ct = new ChitietHopDongPhong(tp, LoadForm);
                QLBLLChung.Instance.openChildForm1(ct, panelChitietPT);
              
            }
        }


        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new ChitietThanhVien(idPhong), panelChitietPT);
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(idPhong);
            Button btn = new Button();
            btn.Name = pt.MaDayTro;
            this.Close();
            suKien(btn,EventArgs.Empty);

        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new ChitietDV(idPhong),panelChitietPT);
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            ChitietTB ct = new ChitietTB(idPhong);
            QLBLLChung.Instance.openChildForm1(ct, panelChitietPT);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            QLBLLChung.Instance.openChildForm1(new TaiKhoanPhong(idPhong, null), panelChitietPT);
        }

        private void btnCocPhong_Click(object sender, EventArgs e)
        {
            panelChitietPT.Controls.Clear();
           

            if (QLBLLPhongTro.Instance.PhongDaCocByIdPhong(idPhong) == false && QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) == true)
            {
                string b = "Phòng đã được thuê";
                QLBLLChung.Instance.TaoPanel(b, panelChitietPT);
            }
            else if (QLBLLPhongTro.Instance.PhongDaCocByIdPhong(idPhong) == false && QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) == false)
            {
                string b = "Phòng chưa được cọc, đang còn trống";
                QLBLLChung.Instance.TaoPanel(b, panelChitietPT);
            }    
            else
            {
                ThuePhong tp = new ThuePhong();
                tp.hopDong.MaPhongTro = idPhong;
                CocPhong cp = new CocPhong(tp, LoadForm);
                QLBLLChung.Instance.openChildForm1(cp, panelChitietPT);
               
            }
        }
    }
}

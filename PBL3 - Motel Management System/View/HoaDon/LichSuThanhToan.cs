using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.View;
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
using System.Globalization;

namespace PBL3___Motel_Management_System
{
    public partial class LichSuThanhToan : Form
    {
        private Loader loader;
        private string IdHd;
         CultureInfo vietnamCulture = new CultureInfo("vi-VN");

        public LichSuThanhToan(Loader loader, string idHd)
        {
            InitializeComponent();
            QLBLLChung.Instance.customDGV(dgvLichSu);
            this.loader = loader;
            this.IdHd =idHd;
            if(this.IdHd != null)
            {
                dtpThangThanhToan.Enabled = false;
                HoaDon hd = QLBLLHoadon.Instance.GetHoaDonById(this.IdHd);
                DateTime dt = DateTime.ParseExact(hd.ThangChiTra, "MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dtpThangThanhToan.Value = dt;
                double TongThanhToan = 0;
                txtTongTien.Text = QLBLLChung.Instance.ChuyenDoiSangKieuTien(hd.TongTien);
                PhongTro pt = QLBLLPhongTro.Instance.GetPhongTroByMaHoaDon(this.IdHd);
                txtTenPhong.Text = pt.TenPhongTro.ToString();
                int i = 0;
                foreach (string idLs in QLBLLChiTietThanhToanHoaDon.Instance.GetAllIdLichSuThanhToanByIdHoaDon(idHd))
                {
                    ChiTietThanhToanHoaDon cttt = QLBLLChiTietThanhToanHoaDon.Instance.GetChiTietThanhToanHoaDonById(idLs);
                    double tienThanhToan = cttt.TienThanhToan;
                    double tongtien = hd.TongTien;
                    TongThanhToan += cttt.TienThanhToan;
                    double ConNo = hd.TongTien - TongThanhToan;
                    dgvLichSu.Rows.Add( ++i, cttt.NgayThanhToan, QLBLLChung.Instance.ChuyenDoiSangKieuTien(cttt.TienThanhToan), QLBLLChung.Instance.ChuyenDoiSangKieuTien(ConNo));
                }
            }     
        }
        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

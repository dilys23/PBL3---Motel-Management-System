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


        public LichSuThanhToan(Loader loader, string idHd)
        {
            InitializeComponent();
            QLBLL.Instance.customDGV(dgvLichSu);
            this.loader = loader;
            this.IdHd =idHd;
            if(this.IdHd != null)
            {
                dtpThangThanhToan.Enabled = false;
                HoaDon hd = QLBLL.Instance.GetHoaDonById(this.IdHd);
                int index = -1;
                DateTime dt = DateTime.ParseExact(hd.ThangChiTra, "MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dtpThangThanhToan.Value = dt;
                txtTongTien.Text = hd.TongTien.ToString();
                PhongTro pt = QLBLL.Instance.GetPhongTroByMaHoaDon(this.IdHd);
                txtTenPhong.Text = pt.TenPhongTro.ToString();
                int i = 0;
                double conNoMoi = Convert.ToDouble(txtTongTien.Text) - hd.DaThanhToan;
                foreach (string idLs in QLBLL.Instance.GetAllIdLichSuThanhToanByIdHoaDon(idHd))
                {
                    //double conNoMoi = Convert.ToDouble(txtTongTien.Text) - hd.DaThanhToan;
                    ChiTietThanhToanHoaDon cttt = QLBLL.Instance.GetChiTietThanhToanHoaDonById(idLs);
                    double tienThanhToan = cttt.TienThanhToan;
                    CultureInfo vietnamCulture = new CultureInfo("vi-VN");
                    dgvLichSu.Rows.Add(cttt.MaHoaDon, cttt.MaChiTietThanhToanHoaDon, ++i, cttt.NgayThanhToan, cttt.TienThanhToan.ToString("C0", vietnamCulture), conNoMoi.ToString("C0", vietnamCulture));
                    conNoMoi -= tienThanhToan;

                }    
               

            }  
                
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

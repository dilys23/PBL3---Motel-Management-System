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
            QLBLL.Instance.customDGV(dgvLichSu);
            this.loader = loader;
            this.IdHd =idHd;
            if(this.IdHd != null)
            {
                dtpThangThanhToan.Enabled = false;
                HoaDon hd = QLBLL.Instance.GetHoaDonById(this.IdHd);
              
                DateTime dt = DateTime.ParseExact(hd.ThangChiTra, "MM-yyyy", System.Globalization.CultureInfo.InvariantCulture);
                dtpThangThanhToan.Value = dt;
                double TongThanhToan = 0;
                txtTongTien.Text = hd.TongTien.ToString("#,##0") + "₫";
                PhongTro pt = QLBLL.Instance.GetPhongTroByMaHoaDon(this.IdHd);
                txtTenPhong.Text = pt.TenPhongTro.ToString();
                int i = 0;
                foreach (string idLs in QLBLL.Instance.GetAllIdLichSuThanhToanByIdHoaDon(idHd))
                {
                    
                    ChiTietThanhToanHoaDon cttt = QLBLL.Instance.GetChiTietThanhToanHoaDonById(idLs);
                    double tienThanhToan = cttt.TienThanhToan;
                    double tongtien = hd.TongTien;
                    TongThanhToan += cttt.TienThanhToan;
                    double ConNo = hd.TongTien - TongThanhToan;
                    dgvLichSu.Rows.Add( ++i, cttt.NgayThanhToan, cttt.TienThanhToan.ToString("#,##0") + "₫", ConNo.ToString("#,##0") + "₫");
          
                }    
               

            }  
                
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

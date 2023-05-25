using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
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
using static System.Net.Mime.MediaTypeNames;

namespace PBL3___Motel_Management_System.View.KhachHang
{
    public partial class HoaDonPhong : Form
    {
        private string idPhong;
        public HoaDonPhong(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            if(idPhong != null )
            {
                SetGUI(null);
            }
        }
        public void SetGUI(string txt)
        {
            dgvHoaDon.Rows.Clear();
            QLBLL.Instance.customDGV(dgvHoaDon);
            if (txt == null)
            {
                int i = 0;
                foreach (HoaDon hd in QLBLL.Instance.GetAllHoaDonBll())
                {
                    if(hd.MaPhongTro ==idPhong && hd.TinhTrang ==true)
                    {
                        dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, hd.NgayTao, hd.ThangChiTra, hd.TongTien, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
                    }
                   
                }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy"); 
                int i = 0;
                string IdDay = QLBLL.Instance.GetDayTroByIdPhong(idPhong).MaDayTro;
                foreach (HoaDon hd in QLBLL.Instance.GetHoaDonTimKiem(ThangSuDung, IdDay, idPhong, "1"))
                {
                    PhongTro pt = QLBLL.Instance.GetPhongTroByIdPhong(hd.MaPhongTro);
                    DayTro dt = QLBLL.Instance.GetDayTroByIdPhong(hd.MaPhongTro);
                    dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i,  hd.NgayTao, hd.ThangChiTra, hd.TongTien, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
                }
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SetGUI("");
        }
    }
}

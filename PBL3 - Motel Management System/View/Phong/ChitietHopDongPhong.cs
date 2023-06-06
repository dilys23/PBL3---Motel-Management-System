using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public delegate void Loader(string txt);
    public partial class ChitietHopDongPhong : Form
    {
        private ThuePhong tp;
        private Loader loader;
        CultureInfo vietnamCulture = new CultureInfo("vi-VN");
        public ChitietHopDongPhong(ThuePhong tp,Loader loader)
        {
            InitializeComponent();
            this.tp = tp;
            this.loader = loader;
            LoadForm();
        }
      
        public void LoadForm()
        {
            DayTro dt = new DayTro();
            dt = QLBLL.Instance.GetDayTroByIdPhong(tp.hopDong.MaPhongTro);
            txtTenDay.Text= dt.TenDayTro;
            PhongTro phongTro = new PhongTro();
            phongTro = QLBLL.Instance.GetPhongTroByIdPhong(tp.hopDong.MaPhongTro);
            txtDienTich.Text = phongTro.DienTich.ToString();
            txtTenPhong.Text = phongTro.TenPhongTro;
            string diachi = dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            txtDiaChi.Text = diachi;
            txtGiaPhong.Text = phongTro.GiaTien.ToString("#,##0") + "₫";
            txtSonguoitoida.Text = phongTro.ToiDa.ToString();
            Nguoi nguoi = new Nguoi();
            HopDong hd = new HopDong();
            hd = QLBLL.Instance.GetHopDongByIdPhong(tp.hopDong.MaPhongTro);
            if(hd != null)
            {
                if(QLBLL.Instance.PhongDaCocByIdPhong(tp.hopDong.MaPhongTro)==false)
                {
                    nguoi = QLBLL.Instance.GetNguoiByMaHopDong(hd.MaHopDong);
                    txtHoVaTen.Text = nguoi.Ten;
                    txtSdt.Text = nguoi.Sdt;
                    txtTienCoc.Text = hd.TienCoc.ToString("#,##0") + "₫";
                    txtCccd.Text = nguoi.Cccd;
                    DateTime ngaysinh = DateTime.ParseExact(nguoi.NgaySinh, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime batdau = DateTime.ParseExact(hd.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    DateTime ketthuc = DateTime.ParseExact(hd.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
                    dtpNgaySinh.Value = ngaysinh;
                    dtpNgayBatDau.Value = batdau;
                    dtpNgayKetThuc.Value = ketthuc;
                } 
            }
              

        }
    }
}

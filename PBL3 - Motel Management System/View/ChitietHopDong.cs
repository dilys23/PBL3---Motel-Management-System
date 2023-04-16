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

namespace PBL3___Motel_Management_System.View
{

    public partial class ChitietHopDong : Form
    {
        private ThuePhong tp;
        public ChitietHopDong(ThuePhong tp)
        {
            InitializeComponent();
            this.tp = tp;
            LoadForm();
        }
        public void LoadForm()
        {
            QLBLL qLBLL = new QLBLL();
            Nguoi nguoi = new Nguoi();
            nguoi = tp.hopDong.Nguoi;
            DayTro dt = new DayTro();
            dt= qLBLL.GetDayTroByIdPhong(tp.hopDong.PhongTro.MaPhongTro);
            PhongTro pt = new PhongTro();
            pt= qLBLL.GetPhongTroByIdPhong(tp.hopDong.PhongTro.MaPhongTro);
            txtHoVaTen.Text = nguoi.Ten;
            txtTenDay.Text = dt.TenDayTro;
            txtTenPhong.Text = pt.TenPhongTro;
            string diachi = dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            txtDiaChi.Text = diachi;
            txtGiaPhong.Text = pt.GiaTien.ToString();
            txtSdt.Text = nguoi.Sdt;
            txtTienCoc.Text = tp.hopDong.TienCoc.ToString();
            txtCccd.Text = nguoi.Cccd;
            txtDienTich.Text = pt.DienTich.ToString();
            DateTime ngaysinh = DateTime.ParseExact(nguoi.NgaySinh, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime batdau = DateTime.ParseExact(tp.hopDong.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime ketthuc = DateTime.ParseExact(tp.hopDong.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            dtpNgaySinh.Value = ngaysinh;
            dtpNgayBatDau.Value = batdau;
            dtpNgayKetThuc.Value = ketthuc;
            //int i = 0;
           // foreach(string idDv in tp.DsDichVu)
           // {
              //  DichVu dv = new DichVu();
              //  dv = qLBLL.GetDichVuByIdDichVu(idDv);
              //  dgvDichVu.Rows.Add(dv.MaDichVu,++i,dv.TenDichVu,dv.GiaDichVu);
           // }

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();  
            Nguoi nguoi = new Nguoi();
            nguoi = tp.hopDong.Nguoi;
            qLBLL.AddNguoiBll(nguoi);
            PhongTro pt = new PhongTro();
            pt = qLBLL.GetPhongTroByIdPhong(tp.hopDong.PhongTro.MaPhongTro);
            pt.TinhTrang = true;
            qLBLL.UpdatePTBLL(pt);
            ThanhVienTrongPhong tvtp = new ThanhVienTrongPhong();
            tvtp.MaThanhVienTrongPhong = qLBLL.TaoIdThanhVienTrongPhong();
            tvtp.MaPhongTro = pt.MaPhongTro;
            tvtp.MaNguoi = nguoi.MaNguoi;
            qLBLL.AddThanhVienTrongPhongBll(tvtp);
            foreach(string iddv in tp.DsDichVu)
            {
                ChiTietDichVu ctdv = new ChiTietDichVu();
                ctdv.MaChiTietDichVu = qLBLL.TaoIdChiTietDichVu();
                ctdv.MaDichVu = iddv;
                ctdv.MaPhongTro = tp.hopDong.PhongTro.MaPhongTro;
                ctdv.ChiSoCu = 0;
                ctdv.ChiSoMoi = 0;
                ctdv.ThoiGian = tp.hopDong.NgayBatDau;
                qLBLL.AddChiTietDichVuBll(ctdv);
            }
            HopDong hd = new HopDong();
            hd.MaHopDong = tp.hopDong.MaHopDong;
            hd.MaNguoi = tp.hopDong.Nguoi.MaNguoi;
            hd.MaPhongTro = tp.hopDong.PhongTro.MaPhongTro;
            hd.NgayBatDau = tp.hopDong.NgayBatDau;
            hd.NgayKetThuc = tp.hopDong.NgayKetThuc;
            hd.TienCoc = tp.hopDong.TienCoc;
            qLBLL.AddHdBll(hd);
            MessageBox.Show("Xác nhận thuê phòng thành công", "Thông báo",MessageBoxButtons.OK);
            this.Close();








        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

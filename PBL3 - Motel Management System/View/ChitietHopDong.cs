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
        private Loader loader;
        public ChitietHopDong(ThuePhong tp, Loader loader)
        {
            InitializeComponent();
            this.tp = tp;
            LoadForm();
            this.loader = loader;

        }
        public void LoadForm()
        {
            QLBLL qLBLL = new QLBLL();
            Nguoi nguoi = new Nguoi();
            nguoi = tp.hopDong.Nguoi;
            DayTro dt = new DayTro();
            dt = qLBLL.GetDayTroByIdPhong(tp.hopDong.MaPhongTro);
            PhongTro pt = new PhongTro();
            pt = qLBLL.GetPhongTroByIdPhong(tp.hopDong.MaPhongTro);
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
            int i = 0;
            foreach (string idDv in tp.DsDichVu)
            {
                DichVu dv = new DichVu();
                dv = qLBLL.GetDichVuByIdDichVu(idDv);
                dgvDichvu.Rows.Add(dv.MaDichVu, ++i, dv.TenDichVu, dv.GiaDichVu);
            }
            foreach (string idTb in tp.DsThietBi)
            {
                ThietBi tb = new ThietBi();
                tb = qLBLL.GetThietBiByIdThietBi(idTb);
                dgvThietbi.Rows.Add(tb.MaThietBi, ++i, tb.TenThietBi, tb.GiaThietBi);
            }

        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTroVe_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnXacNhan_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            Nguoi nguoi = new Nguoi();
            nguoi = tp.hopDong.Nguoi;
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                qLBLL.AddNguoiBll(nguoi);
            }
            catch (Exception ex)
            {
                qLBLL.UpdateNguoiBLL(nguoi);
            }
#pragma warning restore CS0168 // Variable is declared but never used
            PhongTro pt = new PhongTro();
            pt = qLBLL.GetPhongTroByIdPhong(tp.hopDong.MaPhongTro);
            pt.TinhTrang = true;
            qLBLL.UpdatePTBLL(pt);
            ThanhVienTrongPhong tvtp = new ThanhVienTrongPhong();
            tvtp.MaThanhVienTrongPhong = qLBLL.TaoIdThanhVienTrongPhong();
            tvtp.MaPhongTro = pt.MaPhongTro;
            tvtp.MaNguoi = nguoi.MaNguoi;
            qLBLL.AddThanhVienTrongPhongBll(tvtp);
            foreach (string iddv in tp.DsDichVu)
            {
                ChiTietDichVu ctdv = new ChiTietDichVu();
                ctdv.MaChiTietDichVu = qLBLL.TaoIdChiTietDichVu();
                ctdv.MaDichVu = iddv;
                ctdv.MaPhongTro = tp.hopDong.MaPhongTro;
                qLBLL.AddChiTietDichVuBll(ctdv);
            }
            HopDong hd = new HopDong();
            hd.MaHopDong = tp.hopDong.MaHopDong;
            hd.MaNguoi = tp.hopDong.Nguoi.MaNguoi;
            hd.MaPhongTro = tp.hopDong.MaPhongTro;
            hd.NgayBatDau = tp.hopDong.NgayBatDau;
            hd.NgayKetThuc = tp.hopDong.NgayKetThuc;
            hd.TienCoc = tp.hopDong.TienCoc;
            hd.TinhTrang = true;
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                qLBLL.AddHdBll(hd);
            }
            catch (Exception ex)
            {
                qLBLL.UpdateHopDongBLL(hd);
            }
#pragma warning restore CS0168 // Variable is declared but never used
            MessageBox.Show("Xác nhận thuê phòng thành công", "Thông báo", MessageBoxButtons.OK);
            this.loader(null);
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panelThem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
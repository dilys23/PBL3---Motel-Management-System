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
            QLBLLChung.Instance.customDGV(dgvDichvu);
            QLBLLChung.Instance.customDGV(dgvThietbi);
            DayTro dt = new DayTro();
            PhongTro phongTro = new PhongTro();
            Nguoi nguoi = new Nguoi();
            HopDong hopdong = new HopDong();
            //Ma Hop dong
            if (tp.hopDong.MaPhongTro==null && tp.hopDong.MaHopDong !=null)
            {
                hopdong = QLBLLHopDong.Instance.GetHopDongByMaHD(tp.hopDong.MaHopDong);
                phongTro = QLBLLPhongTro.Instance.GetPhongTroByMaHopDong(tp.hopDong.MaHopDong);
                dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(phongTro.MaPhongTro);  
                nguoi = QLBLLNguoi.Instance.GetNguoiByMaHopDong(hopdong.MaHopDong);
                SetGUI(dt, nguoi, phongTro, hopdong);            
            }
            //Thue phong
            if(tp.hopDong.MaHopDong !=null && tp.hopDong.MaPhongTro !=null)
            {    
                nguoi = tp.hopDong.Nguoi;
                dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(tp.hopDong.MaPhongTro);
                phongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(tp.hopDong.MaPhongTro);
                hopdong = this.tp.hopDong;
                SetGUI(dt, nguoi, phongTro, hopdong);             
            }
            if(tp.hopDong.MaHopDong == null && tp.hopDong.MaPhongTro !=null)
            {
                dt = QLBLLDayTro.Instance.GetDayTroByIdPhong(tp.hopDong.MaPhongTro);
                phongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(tp.hopDong.MaPhongTro);
                txtTenDay.Text = dt.TenDayTro;
                txtDienTich.Text = phongTro.DienTich.ToString();
                txtTenPhong.Text = phongTro.TenPhongTro;
                string diachi = dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
                txtDiaChi.Text = diachi;
                txtGiaPhong.Text = phongTro.GiaTien.ToString("#,##0") + "₫";

            }
        }
        public void SetGUI(DayTro dt, Nguoi nguoi,PhongTro phongTro, HopDong hopdong)
        {
            txtTenDay.Text = dt.TenDayTro;
            txtDienTich.Text = phongTro.DienTich.ToString();
            txtTenPhong.Text = phongTro.TenPhongTro;
            string diachi = dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            txtDiaChi.Text = diachi;
            txtGiaPhong.Text = phongTro.GiaTien.ToString("#,##0") + "₫";
            txtHoVaTen.Text = nguoi.Ten;
            txtSdt.Text = nguoi.Sdt;
            txtTienCoc.Text = hopdong.TienCoc.ToString("#,##0") + "₫";
            txtCccd.Text = nguoi.Cccd;
            DateTime ngaysinh = DateTime.ParseExact(nguoi.NgaySinh, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime batdau = DateTime.ParseExact(hopdong.NgayBatDau, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            DateTime ketthuc = DateTime.ParseExact(hopdong.NgayKetThuc, "yyyy-MM-dd", System.Globalization.CultureInfo.InvariantCulture);
            dtpNgaySinh.Value = ngaysinh;
            dtpNgayBatDau.Value = batdau;
            dtpNgayKetThuc.Value = ketthuc;
            int i = 0;
            int j = 0;
            if (tp.hopDong.MaPhongTro == null)
            {          
                foreach (ChiTietDichVu ctdv in QLBLLChiTietDichVu.Instance.GetChiTietDichVuByIdPhong(phongTro.MaPhongTro))
                {
                    
                    DichVu dv = new DichVu();
                    dv = QLBLLDichvu.Instance.GetDichVuByIdDichVu(ctdv.MaDichVu);
                    dgvDichvu.Rows.Add(dv.MaDichVu, ++i, dv.TenDichVu, dv.GiaDichVu.ToString("#,##0") + "₫");
                }
                foreach (ChiTietThietBi cttb in QLBLLChiTietThietBi.Instance.GetChiTietThietBiByIdPhong(phongTro.MaPhongTro))
                {
                    
                    ThietBi tb = new ThietBi();
                    tb = QLBLLThietbi.Instance.GetTBByIdTB(cttb.MaThietBi);
                    dgvThietbi.Rows.Add(tb.MaThietBi, ++j, tb.TenThietBi, tb.GiaThietBi.ToString("#,##0") + "₫", cttb.SoLuong);
                }
            }
            else
            {
                foreach (string idDv in tp.DsDichVu)
                {
                    DichVu dv = new DichVu();
                    dv = QLBLLDichvu.Instance.GetDichVuByIdDichVu(idDv);
                    dgvDichvu.Rows.Add(dv.MaDichVu, ++i, dv.TenDichVu, dv.GiaDichVu.ToString("#,##0") + "₫");
                }
                foreach (ChiTietThietBi ct in QLBLLChiTietThietBi.Instance.GetChiTietThietBiByIdPhong(tp.hopDong.MaPhongTro))
                {
                    ThietBi tb = QLBLLThietbi.Instance.GetTBByIdTB(ct.MaThietBi);
                    dgvThietbi.Rows.Add(tb.MaThietBi, ++j, tb.TenThietBi, tb.GiaThietBi.ToString("#,##0") + "₫", ct.SoLuong);
                }
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
            Nguoi nguoi = new Nguoi();
            nguoi = tp.hopDong.Nguoi;
            nguoi.TonTai = true;
            try
            {
            QLBLLNguoi.Instance.AddNguoiBll(nguoi);
            }
            catch{
                QLBLLNguoi.Instance.UpdateNguoiBLL(nguoi);
            }
            PhongTro pt = new PhongTro();
            pt = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(tp.hopDong.MaPhongTro);
            pt.TinhTrang = true;
            QLBLLPhongTro.Instance.UpdatePTBLL(pt);
            ThanhVienTrongPhong tvtp = new ThanhVienTrongPhong();
            tvtp.MaThanhVienTrongPhong = QLBLLThanhVienTrongPhong.Instance.TaoIdThanhVienTrongPhong();
            tvtp.MaPhongTro = pt.MaPhongTro;
            tvtp.MaNguoi = nguoi.MaNguoi;
            tvtp.TonTai = true;
            QLBLLThanhVienTrongPhong.Instance.AddThanhVienTrongPhongBll(tvtp);
            foreach (string iddv in tp.DsDichVu)
            {
                ChiTietDichVu ctdv = new ChiTietDichVu();
                ctdv.MaChiTietDichVu = QLBLLChiTietDichVu.Instance.TaoIdChiTietDichVu();
                ctdv.MaDichVu = iddv;
                ctdv.MaPhongTro = tp.hopDong.MaPhongTro;
                ctdv.TonTai = true;
                QLBLLChiTietDichVu.Instance.AddChiTietDichVuBll(ctdv);
            }
            HopDong hd = new HopDong();
            hd.MaHopDong = tp.hopDong.MaHopDong;
            hd.MaNguoi = tp.hopDong.Nguoi.MaNguoi;
            hd.MaPhongTro = tp.hopDong.MaPhongTro;
            hd.NgayBatDau = tp.hopDong.NgayBatDau;
            hd.NgayKetThuc = tp.hopDong.NgayKetThuc;
            hd.TienCoc = tp.hopDong.TienCoc;
            hd.TinhTrang = true;
            hd.TonTai = true;
#pragma warning disable CS0168 // Variable is declared but never used
            try
            {
                QLBLLHopDong.Instance.AddHdBll(hd);
            }
            catch (Exception ex)
            {
                QLBLLHopDong.Instance.UpdateHopDongBLL(hd);
            }
#pragma warning restore CS0168 // Variable is declared but never used
            MessageBox.Show("Xác nhận thuê phòng thành công", "Thông báo", MessageBoxButtons.OK);
            this.loader(null);
            this.Close();
        }

        private void panelThem_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
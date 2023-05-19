using PBL3___Motel_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Globalization;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.DAL
{
    internal class QLDAL
    {
        private static QLDAL _instance;
        public static QLDAL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLDAL();
                return _instance;
            }
            private set { }
        }
        private QLDAL()
        {

        }
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.TaiKhoan.Where(p => p.TonTai == true).Select(p => p).ToList<TaiKhoan>();
            }
        }
        public int GetIdTkDal(string taikhoan, string matkhau)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.TaiKhoan.Where(p => p.TenTaiKhoan == taikhoan && p.MatKhau == matkhau && p.TonTai == true).FirstOrDefault().MaTaiKhoan;
            }
        }
        public List<VaiTro> GetAllVaiTro()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.VaiTro.Where(p => p.TonTai == true).Select(p => p).ToList<VaiTro>();
            }
        }
        public List<ChiTietTaiKhoan> GetAllChiTietTaiKhoan()
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietTaiKhoan.Where(p => p.TonTai == true).Select(p => p).ToList<ChiTietTaiKhoan>();
            }
        }
        public TaiKhoan GetTaiKhoanByIdPhong(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietTaiKhoan.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).FirstOrDefault().TaiKhoan;
            }
        }
        public bool KiemTraTonTaiIdPhongTro(int id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.PhongTro.Any(p => p.MaPhongTro == id);
            }
        }
        public bool KiemTraTonTaiHopDongByIdNguoi(int idNguoi)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HopDong.Any(p => p.TonTai == true && p.MaNguoi == idNguoi);
            }
        }
        public List<int>GetIdNguoiByIdPhongDal(int id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ThanhVienTrongPhong.Where(p => p.MaPhongTro == id && p.TonTai ==true).Select(p => p.MaNguoi).ToList<int>();
            }
        }
        public List<PhongTro>GetPhongTroByIdDayDal(int idDay)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.PhongTro.Where(p => p.MaDayTro == idDay && p.TonTai == true).Select(p => p).ToList<PhongTro>();
            }
        }
        public List<int>GetAllIdPhongTroByIdDayDal(int idDay)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.PhongTro.Where(p => p.MaDayTro == idDay && p.TonTai == true).Select(p => p.MaPhongTro).ToList<int>();
            }
        }
        public List<int>GetAllIdPhongTroDal()
        {
            using(DataPbl data = new DataPbl())
            {
                return data.PhongTro.Where(p => p.TonTai == true).Select(p => p.MaPhongTro).ToList<int>();
            }
        }
        public Nguoi GetNguoiByIdNguoiDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.Nguoi.Find(id);
            }
        }
        public List<Nguoi>GetNguoiByIdPhongDal(int id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ThanhVienTrongPhong.Where(p => p.MaPhongTro == id && p.TonTai==true).Select(p => p.Nguoi).ToList<Nguoi>();
            }
        }
        public int GetIdNguoiByTaiKhoanDal(int idTaiKhoan)
        {
            using(DataPbl data = new DataPbl())
            {
                return (int)data.VaiTro.Where(p => p.MaTaiKhoan == idTaiKhoan && p.TonTai == true).FirstOrDefault().MaNguoi;
            }
        }
        public List<HopDong> GetAllHopDong()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true).Select(p => p).ToList<HopDong>();
            }
        }
        public List<HopDong> GetAllHopDongDangThue()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true && p.TinhTrang == true).Select(p => p).ToList<HopDong>();
            }
        }
        public List<int> GetAllIdHoaDon()
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HoaDon.Where(p => p.TonTai == true).Select(p => p.MaHoaDon).ToList<int>();
            }
        }
        public List<HoaDon> GetAllHoaDon()
        {
            using (DataPbl data = new DataPbl())
            {
                return  data.HoaDon.Where(p => p.TonTai==true).Select(p => p).ToList<HoaDon>();
            }
        }
        public List<ChiTietDichVu>GetChiTietDichVuByIdPhongDal(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).Select(p => p).ToList<ChiTietDichVu>();
            }
        }
        public ChiTietDichVu GetChiTietDichVuByIdDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Find(id);
            }
        }
        public List<DayTro>GetAllDayTro()
        {
            using(DataPbl data = new DataPbl())
            {
                return data.DayTro.Where(p => p.TonTai==true).Select(p => p).ToList<DayTro>();
            }
        }
        public List<PhongTro>GetAllPhongTro()
        {
            using(DataPbl data = new DataPbl())
            {
                return data.PhongTro.Where(p => p.TonTai==true).Select(p => p).ToList<PhongTro>();  
            }
        }
        public void AddDayTroDal(DayTro dt)
        {
            using(DataPbl data = new DataPbl())
            {
                data.DayTro.Add(dt);
                data.SaveChanges();
            }
        }
        public void AddTaiKhoanDal(TaiKhoan tk)
        {
            using (DataPbl data = new DataPbl())
            {
                data.TaiKhoan.Add(tk);
                data.SaveChanges();
            }
        }
        public void AddVaiTroDal(VaiTro vt)
        {
            using(DataPbl data = new DataPbl())
            {
                data.VaiTro.Add(vt);
                data.SaveChanges();
            }
        }
        
        public void AddChiTietTaiKhoanDal(ChiTietTaiKhoan cttk)
        {
            using (DataPbl data = new DataPbl())
            {
                data.ChiTietTaiKhoan.Add(cttk);
                data.SaveChanges();
            }
        }
        public void AddHoaDonDal(HoaDon hd)
        {
            using(DataPbl data = new DataPbl())
            {
                data.HoaDon.Add(hd);
                data.SaveChanges();
            }
        }
        public void AddPhongTroDal(PhongTro pt)
        {
            using (DataPbl data = new DataPbl())
            {
                data.PhongTro.Add(pt);
                data.SaveChanges();
            }
        }
        public void AddThanhVienTrongPhong(ThanhVienTrongPhong tvtp)
        {
            using (DataPbl data = new DataPbl())
            {
                data.ThanhVienTrongPhong.Add(tvtp);
                data.SaveChanges();
            }
        }
        public void AddNguoiDal(Nguoi dt)
        {
            using(DataPbl data = new DataPbl())
            {
                data.Nguoi.Add(dt);
                data.SaveChanges();
            }
        }
        public void AddChiTietDichVuDal(ChiTietDichVu dt)
        {
            using (DataPbl data = new DataPbl())
            {
                data.ChiTietDichVu.Add(dt);
                data.SaveChanges();
            }
        }
        public void AddChiTietThietBiDal(ChiTietThietBi tb)
        {
            using (DataPbl data = new DataPbl())
            {
                data.ChiTietThietBi.Add(tb);
                data.SaveChanges();
            }
        }
        public void AddHopDongDal(HopDong dt)
        {
            using (DataPbl data = new DataPbl())
            {
                data.HopDong.Add(dt);
                data.SaveChanges();
            }
        }
        public List<ChiTietSuDungDichVu> GetAllChiTietSuDungDichVu()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p => p.TonTai == true).Select(p => p).ToList<ChiTietSuDungDichVu>();
            }
        }
        public void AddChiTietSuDungDichVuDal(ChiTietSuDungDichVu dv)
        {
            using(DataPbl data = new DataPbl())
            {
                data.ChiTietSuDungDichVu.Add(dv);
                data.SaveChanges();
            }
        }
        public List<ChiTietDichVu> GetAllChiTietDichVu()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true).Select(p => p).ToList<ChiTietDichVu>();
            }
        }
        public List<int> GetAllMaChitietDichVu()
        { 
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Select(p => p.MaChiTietDichVu).ToList<int>();
            }
        }
        public List<ChiTietThietBi> GetAllChiTietThietBi()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true).Select(p => p).ToList<ChiTietThietBi>();
            }
        }
        public List<ThanhVienTrongPhong> GetAllThanhVienTrongPhong()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ThanhVienTrongPhong.Where(p => p.TonTai == true).Select(p => p).ToList<ThanhVienTrongPhong>();
            }
        }  
        public List<PhongTro> GetPhongByIdDay(int idDay)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.PhongTro.Where(p => p.MaDayTro == idDay && p.TonTai == true).Select(p => p).ToList<PhongTro>();
            }
        }
        public List<DichVu> GetAllDichVu()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.DichVu.Where(p => p.TonTai == true).Select(p => p).ToList<DichVu>();
            }
        }
        public List<ThietBi> GetAllThietBi()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ThietBi.Where(p => p.TonTai == true).Select(p => p).ToList<ThietBi>();
            }
        }
        public void ThemDVDal(DichVu dv)
        {
            using(DataPbl data = new DataPbl())
            {
                data.DichVu.Add(dv);
                data.SaveChanges();

            }
        }
        public HopDong GetHopDongByIdPhong(int idphong)
        {
            using (DataPbl data = new DataPbl())
            {
               return (HopDong)data.HopDong.Where(p => p.TonTai == true && p.MaPhongTro == idphong).FirstOrDefault();
            }
        }
        public List<int> GetAllIdHopDongDangThueByIdDay(int idDay)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true && p.PhongTro.MaDayTro == idDay && p.TinhTrang == true).Select(p => p.MaHopDong).ToList<int>();
            }
        }
        public List<int> GetAllIdHopDongDangThue()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true && p.TinhTrang == true).Select(p => p.MaHopDong).ToList<int>();
            }
        }
        public List<int> GetAllIdHopDongDangThueByIdPhong(int idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true && p.MaPhongTro == idPhong && p.TinhTrang == true).Select(p => p.MaHopDong).ToList<int>();
            }
        }
        public void ThemTBDal(ThietBi tb)
        {
            using (DataPbl data = new DataPbl())
            {
                data.ThietBi.Add(tb);
                data.SaveChanges();

            }
        }
        public void SuaDVDal(DichVu dv)
        {
            using( DataPbl data = new DataPbl())
            {
                //var s = data.DichVu.Single(p => p.MaDichVu == dv.MaDichVu);
                var s = data.DichVu.Find(dv.MaDichVu);
                s.TenDichVu = dv.TenDichVu;
                s.GiaDichVu = dv.GiaDichVu;
                s.TonTai = dv.TonTai;
                data.SaveChanges();
                
            }
        }
        public void SuaTBDal(ThietBi tb)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.ThietBi.Single(p => p.MaThietBi == tb.MaThietBi);
                s.MaThietBi = tb.MaThietBi;
                s.TenThietBi= tb.TenThietBi;
                s.GiaThietBi = tb.GiaThietBi;
                s.TonTai = tb.TonTai;
                data.SaveChanges();

            }
        }
        public void SuaDayDal(DayTro day)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.DayTro.Where(p => p.TonTai == true).Single(p => p.MaDayTro == day.MaDayTro);
                s.TenDayTro = day.TenDayTro;
                s.TenHuyen = day.TenHuyen;
                s.TenDuong = day.TenDuong;
                s.TenThanhPho = day.TenThanhPho;
                s.HinhAnh = day.HinhAnh;
                s.TonTai = day.TonTai;
                data.SaveChanges();

            }
        }
        public List<Nguoi>  GetAllNguoi()
        {
            using(DataPbl data = new DataPbl())
            {
                return data.Nguoi.Where(p => p.TonTai == true).Select(p => p).ToList<Nguoi>();
            }
        }
        public DayTro GetDayByIdDay(string Id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.DayTro.Find(Id);
            }
        }
        public List<int>GetAllIdDichVuByIdPhongDal(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.MaPhongTro == idPhong && p.TonTai ==true).Select(p => p.MaDichVu).ToList<int>();
            }
        }
        public List<int> GetAllIdThietBiByIdPhongDal(int idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.MaPhongTro == idPhong && p.TonTai == true).Select(p => p.MaThietBi).ToList<int>();
            }
        }
        public DayTro GetDayTroByIdPhongDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.PhongTro.Find(id).DayTro;
            }
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.PhongTro.Find(idPhong);
            }
        }
        public HopDong GetHopDongByMaHD(string MaHD)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HopDong.Find(MaHD);
            }
        }
        public void UpdatePTDAL(PhongTro PT)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.PhongTro.Where(p => p.TonTai == true).Single(p => p.MaPhongTro == PT.MaPhongTro);
                if (PT.ToiDa >= s.ToiDa)
                s.TenPhongTro = PT.TenPhongTro;
                s.DienTich = PT.DienTich;
                s.GiaTien=PT.GiaTien;
                s.ToiDa=PT.ToiDa;
                s.TinhTrang = PT.TinhTrang;
                s.HinhAnh = PT.HinhAnh;
                s.TonTai = PT.TonTai;
                data.SaveChanges();
            }
        }
        public void UpdateHoaDonDal(HoaDon hd)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.HoaDon.Where(p => p.TonTai == true).Single(p => p.MaHoaDon == hd.MaHoaDon);
                s.MaPhongTro = hd.MaPhongTro;
                s.NgayTao = hd.NgayTao;
                s.ThangChiTra = hd.ThangChiTra;
                s.TinhTrang = hd.TinhTrang;
                s.TongTien = hd.TongTien;
                s.DaThanhToan = hd.DaThanhToan;
                s.TonTai = hd.TonTai;
                data.SaveChanges();
           }
        }
        public void UpdateChiTietSuDungDichVuDAL(ChiTietSuDungDichVu dv)
        {
            using(DataPbl data = new DataPbl())
            {
                var s = data.ChiTietSuDungDichVu.Where(p => p.TonTai == true).Single(p => p.MaChiTietSuDungDichVu == dv.MaChiTietSuDungDichVu);
                s.ChiSoCu = dv.ChiSoCu;
                s.ChiSoMoi = dv.ChiSoMoi;
                s.ThoiGian = dv.ThoiGian;
                s.NgayLap = dv.NgayLap;
                s.TinhTrang = dv.TinhTrang;
                s.TonTai = dv.TonTai;
                data.SaveChanges();
            }
        }
        public ChiTietThietBi GetChiTietThietBiByIdDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Find(id);
            }
        }
        public List<ChiTietThietBi> GetChiTietThietBiByIdPhongDal(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).Select(p => p).ToList<ChiTietThietBi>();
            }
        }
        public void UpdateChitietdichvu(ChiTietDichVu ct)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietDichVu.Where(p => p.TonTai == true).Single(p => p.MaChiTietDichVu == ct.MaChiTietDichVu);
                s.MaDichVu = ct.MaDichVu;
                s.MaPhongTro = ct.MaPhongTro;
                s.TonTai = false;
                data.SaveChanges();
            }
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdDAL(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Find(id);
            }
        }
        public void UpdateHopDongDAL(HopDong hd)
        {
            using(DataPbl data = new DataPbl())
            {
                var s = data.HopDong.Where(p => p.TonTai == true).Single(p => p.MaHopDong == hd.MaHopDong);
                s.NgayBatDau = hd.NgayBatDau;
                s.NgayKetThuc = hd.NgayKetThuc;
                s.TienCoc = hd.TienCoc;
                s.TinhTrang = hd.TinhTrang;
                s.TonTai = hd.TonTai;
                data.SaveChanges();
            }
        }
        public void UpdateNguoiDAL(Nguoi nguoi)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.Nguoi.Where(p => p.TonTai == true).Single(p => p.MaNguoi == nguoi.MaNguoi);
                s.Cccd = nguoi.Cccd;
                s.Ten = nguoi.Ten;
                s.Sdt = nguoi.Sdt;
                s.Diachi = nguoi.Diachi;
                s.NgaySinh = nguoi.NgaySinh;
                s.GioiTinh = nguoi.GioiTinh;
                s.HinhAnh = nguoi.HinhAnh;
                s.TonTai = nguoi.TonTai;
                data.SaveChanges();
            }
        }
      
        public PhongTro GetPhongTroByIdHopDong(int idHd)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true && p.MaHopDong == idHd).FirstOrDefault().PhongTro;
            }
        }
        public PhongTro GetPhongTroByIdHoaDon(int idHd)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HoaDon.Where(p => p.TonTai == true && p.MaHoaDon == idHd).FirstOrDefault().PhongTro;
            }
        }
        public PhongTro GetPhongTroByMaHopDong(int MaHopDong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HopDong.Where(p => p.TonTai == true && p.MaHopDong == MaHopDong).FirstOrDefault().PhongTro;
            }
        }
        public Nguoi GetNguoiByIdHopDong(int idHopDong)
        {
            using (DataPbl data = new DataPbl())
            {
                return (Nguoi)data.HopDong.Where(p => p.TonTai == true && p.MaHopDong == idHopDong).FirstOrDefault().Nguoi;
            }
        }
        public List<int> GetHoaDonByTinhTrang(bool tinhTrang)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HoaDon.Where(p => p.TinhTrang == tinhTrang && p.TonTai == true).Select(p => p.MaHoaDon).ToList<int>();
            }
        }
        public List<int> GetHoaDonByIdPhong(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HoaDon.Where(p => p.MaPhongTro == idPhong && p.TonTai == true).Select(p => p.MaHoaDon).ToList<int>();
            }
        }
        public List<int>GetHoaDonByIdDay(int idDay)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HoaDon.Where(p => p.PhongTro.MaDayTro == idDay && p.TonTai == true).Select(p => p.MaHoaDon).ToList<int>();
            }
        }
        public List<int> GetIdHoaDonByThangChiTra(string ThangCt)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HoaDon.Where(p => p.ThangChiTra == ThangCt && p.TonTai == true ).Select(p => p.MaHoaDon).ToList<int>();
            }
        }
        public int GetIdPhongByIdHoaDon(int idHoaDon)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.HoaDon.Find(idHoaDon).MaPhongTro;
            }    
        }
        public int GetIdPhongbyIdChitietsudungDichVu(int idChitiet)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Find(idChitiet).ChiTietDichVu.MaPhongTro;
            }    
        }    
        public HoaDon GetHoaDonByIdDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.HoaDon.Find(id);
            }
        }
        public DichVu GetDichVuByIdDichVuDal(string id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.DichVu.Find(id);
            }
        }
        public ThietBi GetThietBiByIdThietBiDal(string id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ThietBi.Find(id);
            }
        }
        public List<int> GetIdPhongByIdTbDal(int idTb)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true && p.MaThietBi == idTb).Select(p => p.MaPhongTro).ToList<int>();
            }
        }
        public int GetIdChiTietDichVuDienByIdPhongDal(int idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return  data.ChiTietDichVu.Where(p => p.MaPhongTro == idPhong && p.MaDichVu == 1 && p.TonTai == true).FirstOrDefault().MaChiTietDichVu;
            }
        }
        
        public List<ChiTietSuDungDichVu> GetAllChiTietSuDungDichVuByIdPhong(int idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p=> p.ChiTietDichVu.MaPhongTro == idPhong).ToList();
            }
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuById(string id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Find(id);
            }
        }
        public int GetIdChiTietDichVuNuocByIdPhongDal(int idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.MaPhongTro == idPhong && p.MaDichVu == 0).FirstOrDefault().MaChiTietDichVu;
            }
        }
        public int GetIdDayByIdPhong(int IdPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.PhongTro.Find(IdPhong).MaDayTro;
            }
        }
        public int GetIdPhongByIdNguoiDal(int idNguoi)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ThanhVienTrongPhong.Where(p => p.TonTai == true && p.MaNguoi == idNguoi).FirstOrDefault().MaPhongTro;
            }
        }
        public void DelCHiTietThietBiById(string Id)
        {
            using(DataPbl data = new DataPbl())
            {
                var s = data.ChiTietThietBi.Find(Id);
                s.TonTai = false;
                data.SaveChanges();
            }
        }
        
        public void UpdateChiTietThietBiDal(ChiTietThietBi cttb)
        {
            using(DataPbl data = new DataPbl())
            {
                ChiTietThietBi ct = data.ChiTietThietBi.Where(p => p.TonTai == true).Single(p => p.MaChiTietThietBi == cttb.MaChiTietThietBi);
                ct.MaThietBi = cttb.MaThietBi;
                ct.MaPhongTro = cttb.MaPhongTro;
                ct.SoLuong = cttb.SoLuong;
                ct.TonTai = cttb.TonTai;
                data.SaveChanges();
            }
        }
        public void DelChiTietDichVuDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                var s = data.ChiTietDichVu.Find(id);
                s.TonTai = false;
                data.SaveChanges();
            }
        }
        public int GetIdChiTietDichVuByIdPhongAndIdDichVu(int idp, int iddv)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true && p.MaPhongTro == idp && p.MaDichVu == iddv).FirstOrDefault().MaChiTietDichVu;
            }
        }
        public void DelChiTietSuDungDichVuDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                ChiTietSuDungDichVu ct = (ChiTietSuDungDichVu)data.ChiTietSuDungDichVu.Find(id);
                ct.TonTai = false;
                UpdateChiTietSuDungDichVuDAL(ct);
            }    
        }
        public void DelDichVuDal(string id)
        {
            using (DataPbl data = new DataPbl())
            {
                DichVu s = (DichVu)data.DichVu.Find(id);
                s.TonTai = false;
                UpdateDichVuDal(s);
                
            }
        }
        public void UpdateDichVuDal(DichVu dv)
        {
            using (DataPbl data = new DataPbl())
            {
                DichVu tv = data.DichVu.Where(p => p.TonTai == true).Single(p => p.MaDichVu == dv.MaDichVu);
                tv.TenDichVu = dv.TenDichVu;
                tv.GiaDichVu = dv.GiaDichVu;
                tv.TonTai = dv.TonTai;
                data.SaveChanges();

            }
        }
        public void DelThietBiDal(string Id)
        {
            using(DataPbl data = new DataPbl())
            {
                ThietBi s = (ThietBi)data.ThietBi.Find(Id);
                s.TonTai = false;
                UpdateThietBiDal(s);
                
            }
        }
        public void DelDayTroDal(string MaDay)
        {
            using(DataPbl data= new DataPbl())
            {
                DayTro s= (DayTro)data.DayTro.Find(MaDay);
                s.TonTai = false;
                SuaDayDal(s);
            }
        }
        public void DelThanhVienDAL(string id)
        {
            using(DataPbl data= new DataPbl())
            {
                ThanhVienTrongPhong s = (ThanhVienTrongPhong)data.ThanhVienTrongPhong.Find(id);
                s.TonTai = false;
                UpdateThanhVienTrongPhongDal(s);
            }
        }
        public void UpdateThietBiDal(ThietBi tb)
        {
            using (DataPbl data = new DataPbl())
            {
                ThietBi tv = data.ThietBi.Where(p => p.TonTai == true).Single(p => p.MaThietBi == tb.MaThietBi);
                tv.TenThietBi = tb.TenThietBi;
                tv.GiaThietBi = tb.GiaThietBi;
                tv.TonTai = tb.TonTai;
                data.SaveChanges();

            }
        }
        public void UpdateThanhVienTrongPhongDal(ThanhVienTrongPhong tvtp)
        {
            using(DataPbl data = new DataPbl())
            {
                ThanhVienTrongPhong tv = data.ThanhVienTrongPhong.Where(p => p.TonTai == true).Single(p => p.MaThanhVienTrongPhong == tvtp.MaThanhVienTrongPhong);
                tv.MaPhongTro = tvtp.MaPhongTro;
                tv.MaNguoi = tvtp.MaNguoi;
                tv.TonTai = tvtp.TonTai;
                data.SaveChanges();

            }
        }
        public void DelPhongTroDAL(string idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                PhongTro s = (PhongTro)data.PhongTro.Find(idPhong);
                s.TonTai = false;
                UpdatePTDAL(s);
            }
        }
        public void DelNguoiDal(string id)
        {
            using (DataPbl data = new DataPbl())
            {
                Nguoi s = (Nguoi)data.Nguoi.Find(id);
                s.TonTai = false;
                UpdateNguoiDAL(s);
            }
        }
        public int GetIdThanhVienByIdNguoi(int id)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ThanhVienTrongPhong.Where(p => p.MaNguoi == id && p.TonTai == true).FirstOrDefault().MaThanhVienTrongPhong;
            }
        }
        public List<int> GetIDThanhvienbyIDPhong(int idphong)
        {
            using(DataPbl data = new DataPbl() )
            {
                return data.ThanhVienTrongPhong.Where(p => p.MaPhongTro == idphong && p.TonTai == true).Select(p => p.MaThanhVienTrongPhong).ToList<int>();
            }
        }
        public int GetMaChiTietDichVuByIdPhong(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).FirstOrDefault().MaChiTietDichVu;
            }
        }
        public void DelHoaDonDal(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                HoaDon s = (HoaDon)data.HoaDon.Find(id);
                s.TonTai =false;
                UpdateHoaDonDal(s);
            }
        }
        public void DelHopDong(string idhopdong)
        {
            using(DataPbl data = new DataPbl())
            {
                var s = data.HopDong.Find(idhopdong);
                HopDong hd = (HopDong)s;
                s.TonTai = false;
                UpdateHopDongDAL(hd);
            }
        }
        public List<int>GetAllIdChiTietThietBiByIdPhong(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).Select(p => p.MaChiTietThietBi).ToList<int>();
            }
        }
        public List<int> GetAllIdChiTietDichVuByIdPhong(int idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).Select(p => p.MaChiTietDichVu).ToList<int>();
            }
        }
        public List<ChiTietThietBi>GetAllChiTietThietBiDAL()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true).Select(p => p).ToList<ChiTietThietBi>();
               
            }
        }
        public List<int>GetChiTietSuDungDichVuByThangSuDungDal(string ThangSd)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p => p.TonTai == true && p.ThoiGian == ThangSd).Select(p => p.MaChiTietSuDungDichVu).ToList<int>();
            }
        }
        public List<int>GetChiTietSuDungDichVuByIdDayDal(int IdDay)
        {
            using(DataPbl data = new DataPbl())
            {   
                return data.ChiTietSuDungDichVu.Where(p => p.ChiTietDichVu.PhongTro.MaDayTro == IdDay && p.TonTai == true).Select(p => p.MaChiTietSuDungDichVu).ToList<int>();
            }
        }
        public List<int> GetChiTietSuDungDichVuByIdChitiet(int IdChitiet)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p => p.MaChiTietSuDungDichVu == IdChitiet && p.TonTai == true).Select(p => p.MaChiTietSuDungDichVu).ToList<int>();
            }
        }
        public List<int>GetAllIdChiTietSuDungDichVuDal()
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p => p.TonTai == true).Select(p => p.MaChiTietSuDungDichVu).ToList<int>();
            }

        }
        public List<int> GetChiTietSuDungDichVuByIdPhongDal(int IdPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p => p.ChiTietDichVu.PhongTro.MaPhongTro == IdPhong && p.TonTai == true).Select(p => p.MaChiTietSuDungDichVu).ToList<int>();
            }
        }
        public List<int> GetChiTietSuDungDichVuByTinhTrang(bool tinhTrang)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Where(p => p.TonTai == true && p.TinhTrang == tinhTrang).Select(p => p.MaChiTietSuDungDichVu).ToList<int>();
            }
        }


        public List<int>GetAllIdChiTietThietBiByIdThietBi(int idThietBi)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true && p.MaThietBi == idThietBi).Select(p => p.MaChiTietThietBi).ToList<int>();
            }
        }
        public List<int> GetAllIdChiTietDichVuByIdDichVu(int idDichVu)
        {
            using (DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true && p.MaDichVu == idDichVu).Select(p => p.MaChiTietDichVu).ToList<int>();
            }
        }
      
        public List<HoaDon> GetHoaDonByNam(string nam)
        {
            List<HoaDon> list = new List<HoaDon>();
            using (DataPbl data= new DataPbl())
            {
                foreach(HoaDon hoadon in GetAllHoaDon())
                {
                    DateTime dateTime; 
                    if (DateTime.TryParseExact(hoadon.ThangChiTra, "MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dateTime))
                    {
                        if (dateTime.Year.ToString() == nam)
                        {
                            list.Add(hoadon);
                        }
                    }
                }
                return list;
            }
        }
        public List<object> ThongKe(string thang)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.HoaDon.ToList()
                    .Where(p => p.ThangChiTra == thang && p.TinhTrang == true && p.DaThanhToan != 0)
                    .GroupBy(p => p.PhongTro.DayTro.TenDayTro)
                    .OrderBy(p => p.Key)
                    .Select(p => new { TenDayTro = p.Key, TongTien = p.Sum(k => k.DaThanhToan) })
                    .ToList<object>();
                return s;

            }
        }
        public List<DichVu> getAllDichVuByIdPhong(int idPhong)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietDichVu.Where(p => p.TonTai == true && p.MaPhongTro == idPhong).Select(p => p.DichVu).ToList<DichVu>();
            }
        }
        public string GetIdPhongByIdChiTietSuDungDichVu(string idct)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietSuDungDichVu.Find(idct).ChiTietDichVu.MaPhongTro.ToString();
            }
        }
      
        public ChiTietThietBi GetChiTietThietBiByIdPhongAndIdThietBi(int idp,int idtb)
        {
            using(DataPbl data = new DataPbl())
            {
                return data.ChiTietThietBi.Where(p => p.TonTai == true && p.MaThietBi == idtb && p.MaPhongTro == idp).FirstOrDefault();
            }
        }
    }
}

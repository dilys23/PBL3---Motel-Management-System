using PBL3___Motel_Management_System.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.DAL
{
    internal class QLDAL
    {
        public List<TaiKhoan> GetAllTaiKhoan()
        {
            List<TaiKhoan> list = new List<TaiKhoan>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.TaiKhoan.Select(p => p);
                list = s.ToList<TaiKhoan>();
            }
            return list;
        }
        public string GetIdTkDal(string taikhoan, string matkhau)
        {
            using(DataPbl data = new DataPbl())
            {
                TaiKhoan s = data.TaiKhoan.Single(p=> p.TenTaiKhoan == taikhoan && p.MatKhau == matkhau);
                return s.MaTaiKhoan;
            }
        }
        public List<VaiTro> GetAllVaiTro()
        {
            List<VaiTro> list = new List<VaiTro>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.VaiTro.Select(p => p);
                list = s.ToList<VaiTro>();
            }
            return list;
        }

        public List<HopDong> GetAllHopDong()
        {
            List<HopDong> list = new List<HopDong>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.HopDong.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<HopDong>();
            }
            return list;
        }
        public List<HoaDon> GetAllHoaDon()
        {
            List<HoaDon> list = new List<HoaDon>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.HoaDon.Where(p => p.TonTai==true).Select(p => p);
                list = s.ToList<HoaDon>();
            }
            return list;
        }
        public List<DayTro>GetAllDayTro()
        {
            List<DayTro> list = new List<DayTro>();
            using(DataPbl data = new DataPbl())
            {
                var s = data.DayTro.Where(p => p.TonTai==true).Select(p => p);
                list = s.ToList<DayTro>();
            }
            return list;
        }
        public List<PhongTro>GetAllPhongTro()
        {
            List<PhongTro> list = new List<PhongTro>();
            using(DataPbl data = new DataPbl())
            {
                var s = data.PhongTro.Where(p => p.TonTai==true).Select(p => p);
                list = s.ToList<PhongTro>();
            }
            return list;
        }
        public void AddDayTroDal(DayTro dt)
        {
            using(DataPbl data = new DataPbl())
            {
                data.DayTro.Add(dt);
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
            List<ChiTietSuDungDichVu> list = new List<ChiTietSuDungDichVu>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietSuDungDichVu.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<ChiTietSuDungDichVu>();
            }

            return list;
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
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietDichVu.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<ChiTietDichVu>();
            }

            return list;
        }
        public List<string> GetAllMaChitietDichVu()
        {
            List<string> list= new List<string>();  
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietDichVu.Select(p => p.MaChiTietDichVu);
                list = s.ToList<string>();
            }
            return list;
        }
        public List<ChiTietThietBi> GetAllChiTietThietBi()
        {
            List<ChiTietThietBi> list = new List<ChiTietThietBi>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietThietBi.Where(p => p.TonTai==true).Select(p => p);
                list = s.ToList<ChiTietThietBi>();
            }

            return list;
        }
        
        public List<ThanhVienTrongPhong> GetAllThanhVienTrongPhong()
        {
            List<ThanhVienTrongPhong> list = new List<ThanhVienTrongPhong>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ThanhVienTrongPhong.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<ThanhVienTrongPhong>();
            }

            return list;
        }
        
        public List<PhongTro> GetPhongByIdDay(string idDay)
        {
            List<PhongTro> list = new List<PhongTro>();
            List<PhongTro> listPhongTro = GetAllPhongTro();
            foreach(PhongTro pt in listPhongTro)
            {
                if (pt.MaDayTro ==  idDay) list.Add(pt);
            }
            return list;
        }
        public List<DichVu> GetAllDichVu()
        {
            List<DichVu> list = new List<DichVu>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.DichVu.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<DichVu>();
            }
            return list;
        }
        public List<ThietBi> GetAllThietBi()
        {
            List<ThietBi> list = new List<ThietBi>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ThietBi.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<ThietBi>();
            }

            return list;
        }
        public void ThemDVDal(DichVu dv)
        {
            using(DataPbl data = new DataPbl())
            {
                data.DichVu.Add(dv);
                data.SaveChanges();

            }
        }
        public HopDong GetHopDongByIdPhong(string idphong)
        {
            using (DataPbl data = new DataPbl())
            {
               var s= data.HopDong.Where(p => p.TonTai == true).Single(p=>p.MaPhongTro == idphong);
                return s;
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
                var s = data.DichVu.Single(p => p.MaDichVu == dv.MaDichVu);
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
                s.TenThietBi= tb.TenThietBi;
                s.GiaThietBi = tb.GiaThietBi;
                s.TonTai = tb.TonTai;
                data.SaveChanges();

            }
        }
        public List<Nguoi>  GetAllNguoi()
        {
            List<Nguoi> list = new List<Nguoi>();
            using(DataPbl data = new DataPbl())
            {
                var s = data.Nguoi.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<Nguoi>();
            }
            return list;
        }
        
        public DayTro GetDayByIdDay(string Id)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.DayTro.Where(p => p.TonTai == true).Single(p => p.MaDayTro == Id);
                return s;
            }
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.PhongTro.Where(p => p.TonTai == true).Single(p => p.MaPhongTro == idPhong);
                return s;
            }
        }
        public HopDong GetHopDongByMaHD(string MaHD)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.HopDong.Where(p => p.TonTai == true).Single(p => p.MaHopDong == MaHD);
                return s;
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
        public void UpdateChitietdichvu(ChiTietDichVu ct)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietDichVu.Where(p => p.TonTai == true).Single(p => p.MaChiTietDichVu == ct.MaChiTietDichVu);
                s.MaDichVu = ct.MaDichVu;
                s.MaPhongTro = ct.MaPhongTro;
                s.TonTai = ct.TonTai;
                data.SaveChanges() ;
            }
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdDAL(string id)
        {
            using(DataPbl data = new DataPbl())
            {
                var s = data.ChiTietSuDungDichVu.Where(p => p.TonTai == true).Single(p => p.MaChiTietSuDungDichVu == id);
                return (ChiTietSuDungDichVu)s;
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
        public string GetIdDayByIdPhong(string IdPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                foreach(PhongTro phongTro in GetAllPhongTro())
                {
                    if(phongTro.MaPhongTro==IdPhong)
                    {
                        return phongTro.MaDayTro;
                    }
                }
                return null;

            }
        }
        public void DelCHiTietThietBiById(string Id)
        {
            using(DataPbl data = new DataPbl())
            {
                ChiTietThietBi s = data.ChiTietThietBi.Find(Id);
                s.TonTai = false;
                UpdateChiTietThietBiDal(s);
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
                ChiTietDichVu s = (ChiTietDichVu)data.ChiTietDichVu.Find(id);
                s.TonTai = false;
                UpdateChitietdichvu(s);

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
        public string GetIdThanhVienByIdNguoi(string id)
        {
            using (DataPbl data = new DataPbl())
            {
                foreach (ThanhVienTrongPhong thanhvien in GetAllThanhVienTrongPhong())
                {
                    if (thanhvien.MaNguoi == id)
                    {
                        return thanhvien.MaThanhVienTrongPhong;
                    }

                }
                return null;
            }
        }
        public List<string> GetIDThanhvienbyIDPhong(string idphong)
        {
            List<string> list = new List<string>();
            foreach(ThanhVienTrongPhong tv in GetAllThanhVienTrongPhong())
                {
                    if (tv.MaPhongTro == idphong)
                        list.Add(tv.MaThanhVienTrongPhong);
                }
            return list;
            
        }
        public string GetMaChiTietDichVuByIdPhong(string idPhong)
        {
                foreach(ChiTietDichVu ctdv in GetAllChiTietDichVu())
                {
                     if(ctdv.MaPhongTro == idPhong)
                    {
                        return ctdv.MaChiTietDichVu;
                    }
                }
                return null;    
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
        public List<ChiTietThietBi>GetAllChiTietThietBiDAL()
        {
            List<ChiTietThietBi> list = new List<ChiTietThietBi> ();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietThietBi.Where(p => p.TonTai == true).Select(p => p);
                list = s.ToList<ChiTietThietBi>();
            }
            return list;
        }
    }
}

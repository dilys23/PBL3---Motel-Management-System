﻿using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
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
                var s = data.HopDong.Select(p => p);
                list = s.ToList<HopDong>();
            }
            return list;
        }
        public List<DayTro>GetAllDayTro()
        {
            List<DayTro> list = new List<DayTro>();
            using(DataPbl data = new DataPbl())
            {
                var s = data.DayTro.Select(p => p);
                list = s.ToList<DayTro>();
            }
            return list;
        }
        public List<PhongTro>GetAllPhongTro()
        {
            List<PhongTro> list = new List<PhongTro>();
            using(DataPbl data = new DataPbl())
            {
                var s = data.PhongTro.Select(p => p);
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
        public void AddHopDongDal(HopDong dt)
        {
            using (DataPbl data = new DataPbl())
            {
                data.HopDong.Add(dt);
                data.SaveChanges();
            }
        }
        public List<ChiTietDichVu> GetAllChiTietDichVu()
        {
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietDichVu.Select(p => p);
                list = s.ToList<ChiTietDichVu>();
            }

            return list;
        }
        public List<ChiTietThietBi> GetAllChiTietThietBi()
        {
            List<ChiTietThietBi> list = new List<ChiTietThietBi>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ChiTietThietBi.Select(p => p);
                list = s.ToList<ChiTietThietBi>();
            }

            return list;
        }
        public List<ThanhVienTrongPhong> GetAllThanhVienTrongPhong()
        {
            List<ThanhVienTrongPhong> list = new List<ThanhVienTrongPhong>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ThanhVienTrongPhong.Select(p => p);
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
        public List<DichVu> GetAllDichVu(string idPhong)
        {
            List<DichVu> list = new List<DichVu>();
            if (idPhong == null)
            {
                using (DataPbl data = new DataPbl())
                {
                    var s = data.DichVu.Select(p => p);
                    list = s.ToList<DichVu>();
                }
            }
            else
            {
                using (DataPbl data = new DataPbl())
                {
                    var s = data.ChiTietDichVu.Select(p => p).Where(p => p.MaPhongTro == idPhong).Select(p=>p.DichVu);
                    list = s.ToList<DichVu>();
                }
            }

            return list;
        }
        public List<ThietBi> GetAllThietBi()
        {
            List<ThietBi> list = new List<ThietBi>();
            using (DataPbl data = new DataPbl())
            {
                var s = data.ThietBi.Select(p => p);
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
                data.SaveChanges();

            }
        }
        public void UpdateNguoiDAL(Nguoi n)
        {
            using (DataPbl data= new DataPbl())
            {
                var s= data.Nguoi.Single(p=>p.MaNguoi == n.MaNguoi);
                s.Cccd = n.Cccd;
                s.Ten = n.Ten;
                s.Sdt = n.Sdt;
                s.Diachi = n.Diachi;
                s.NgaySinh = n.NgaySinh;
                s.GioiTinh = n.GioiTinh;
                data.SaveChanges() ;

            }
        }
        public List<Nguoi>  GetAllNguoi()
        {
            List<Nguoi> list = new List<Nguoi>();
            using(DataPbl data = new DataPbl())
            {
                var s = data.Nguoi.Select(p => p);
                list = s.ToList<Nguoi>();
            }
            return list;
        }
        
        public DayTro GetDayByIdDay(string Id)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.DayTro.Single(p => p.MaDayTro == Id);
                return s;
            }
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.PhongTro.Single(p => p.MaPhongTro == idPhong);
                return s;
            }
        }
        public void UpdatePTDAL(PhongTro PT)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.PhongTro.Single(p => p.MaPhongTro == PT.MaPhongTro);
                if (PT.ToiDa >= s.ToiDa)
                s.TenPhongTro = PT.TenPhongTro;
                s.DienTich = PT.DienTich;
                s.GiaTien=PT.GiaTien;
                s.ToiDa=PT.ToiDa;
                s.TinhTrang = PT.TinhTrang;
                data.SaveChanges();

            }
        }

        public void SuaDayDal(DayTro day)
        {
            using (DataPbl data = new DataPbl())
            {
                var s = data.DayTro.Single(p => p.MaDayTro == day.MaDayTro);
                s.TenDayTro = day.TenDayTro;
                s.TenHuyen = day.TenHuyen;
                s.TenDuong = day.TenDuong; 
                s.TenThanhPho = day.TenThanhPho;
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
    }
}

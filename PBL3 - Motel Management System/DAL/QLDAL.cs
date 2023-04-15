using System;
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
        public void AddPhongTroDal(PhongTro dt)
        {
            using (DataPbl data = new DataPbl())
            {
                data.PhongTro.Add(dt);
                data.SaveChanges();
            }
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
                var s = data.DichVu.Select(p => p);
                list = s.ToList<DichVu>();
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
                s.TenPhongTro = PT.TenPhongTro;
                s.DienTich = PT.DienTich;
                s.GiaTien=PT.GiaTien;
                s.ToiDa=PT.ToiDa;
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
                        return phongTro.MaDayTro;break;
                    }
                    
                }
                return null;

            }
        }
    }
}

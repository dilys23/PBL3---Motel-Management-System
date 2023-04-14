using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLL
    {
        public string GetIdTk(string taikhoan, string matkhau)
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            foreach (TaiKhoan tk in qLDAL.GetAllTaiKhoan())
            {
                if (taikhoan == tk.TenTaiKhoan && matkhau == tk.MatKhau)
                {
                    id = tk.MaTaiKhoan; break;
                }
            }
            return id;
        }
        public string GetIdNguoiByTaiKhoan(string idTaiKhoan)
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            foreach (VaiTro vt in qLDAL.GetAllVaiTro())
            {
                if (vt.MaTaiKhoan == idTaiKhoan)
                {
                    id = vt.MaNguoi; break;
                }
            }
            return id;
        }
        
        public List<ViewCbb> GetCbbDayTro()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { IdDayTro = "0", TenDayTro = "All"});
            QLDAL qLDAL = new QLDAL();
            foreach(DayTro dt in qLDAL.GetAllDayTro())
            {
                list.Add(new ViewCbb { IdDayTro = dt.MaDayTro,TenDayTro = dt.TenDayTro });
            }
            return list;
        }
        public string TaoIdNguoi()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (Nguoi ng in qLDAL.GetAllNguoi())
                {
                    if (ng.MaNguoi == id) status = true; break;
                }
            }
            return id;
        }
        public string TaoIdPhongTro()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (PhongTro phongTro in qLDAL.GetAllPhongTro())
                {
                    if (phongTro.MaPhongTro == id) status = true; break;
                }
            }
            return id;
        }
        public string TaoIdDayTro()
        {
            string id = null;
            QLDAL qLDAL =  new QLDAL() ;
            Boolean status = true;
            Random random = new Random();
            while(status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach(DayTro dayTro in qLDAL.GetAllDayTro())
                {
                    if(dayTro.MaDayTro == id)status = true;break;
                }
            }
            return id;
        }
        public string TaoIdDichVu()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (DichVu dv in qLDAL.GetAllDichVu())
                {
                    if (dv.MaDichVu == id) status = true; break;
                }
            }
            return id;
        }
        public void AddDayTroBll(DayTro dt)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddDayTroDal(dt);
        }
        public void AddPhongTroBll(PhongTro phongTro)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddPhongTroDal(phongTro);
        }
        public List<ViewDay> DgvDayTro(string txtTim)
        {
            List<ViewDay> list = new List<ViewDay>();
            QLDAL qLDAL = new QLDAL();
            int i = 0;
            foreach(DayTro dt in qLDAL.GetAllDayTro())
            {
                if(txtTim == null)
                {
                i++;
                ViewDay vd = new ViewDay();
                vd.MaDayTro = dt.MaDayTro;
                vd.Stt = i;
                vd.TenDayTro = dt.TenDayTro;
                vd.TenDuong = dt.TenDuong;
                vd.TenHuyen = dt.TenHuyen;
                vd.TenThanhPho = dt.TenThanhPho;
                vd.SoPhong = qLDAL.GetPhongByIdDay(dt.MaDayTro).Count();
                list.Add(vd);
                }
                else
                {
                    if(dt.TenDayTro.IndexOf(txtTim,0,StringComparison.OrdinalIgnoreCase)!=-1)
                    {
                        i++;
                        ViewDay vd = new ViewDay();
                        vd.MaDayTro = dt.MaDayTro;
                        vd.Stt = i;
                        vd.TenDayTro = dt.TenDayTro;
                        vd.TenDuong = dt.TenDuong;
                        vd.TenHuyen = dt.TenHuyen;
                        vd.TenThanhPho = dt.TenThanhPho;
                        vd.SoPhong = qLDAL.GetPhongByIdDay(dt.MaDayTro).Count();
                        list.Add(vd);
                    }
                }
            }
            return list;
        }
        
        public List<ViewPhongTro> DgvPhongTro(string txtTim)
        {
            List<ViewPhongTro> list = new List<ViewPhongTro>();
            QLDAL qLDAL = new QLDAL();
            int i = 0;
            foreach(PhongTro pt in qLDAL.GetAllPhongTro())
            {
                if(txtTim == null)
                {
                    i++;
                    ViewPhongTro vd = new ViewPhongTro();
                    vd.Stt = i;
                    vd.MaPhongTro = pt.MaPhongTro;
                    vd.TenPhongTro = pt.TenPhongTro;
                    vd.GiaTien = pt.GiaTien;
                    vd.DienTich = pt.DienTich;
                    vd.TinhTrang = pt.TinhTrang;
                    vd.SoNguoiToiDa = (int)pt.ToiDa;
                    vd.SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count;
                                        
                    list.Add(vd);
                }
                else
                {
                    if(pt.TenPhongTro.IndexOf(txtTim,0, StringComparison.OrdinalIgnoreCase)!=-1)
                    {
                        i++;
                        ViewPhongTro vd = new ViewPhongTro();
                        vd.Stt = i;
                        vd.MaPhongTro = pt.MaPhongTro;
                        vd.TenPhongTro = pt.TenPhongTro;
                        vd.GiaTien = pt.GiaTien;
                        vd.DienTich = pt.DienTich;
                        vd.TinhTrang = pt.TinhTrang;
                        vd.SoNguoiToiDa = (int)pt.ToiDa;
                        vd.SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count;
                        list.Add(vd);
                    }
                }
            }

            return list;
        }
        public List<ViewPhongTro> GetAllPhongTroByIdDay(string idDay)
        {
            List<ViewPhongTro> list = new List<ViewPhongTro>();
            QLDAL qLDAL = new QLDAL();
            int i = 0;
            if(idDay != "0")
            {
            foreach(PhongTro pt in qLDAL.GetAllPhongTro())
            {
                if(pt.MaDayTro == idDay)
                {
                    i++;
                    list.Add(new ViewPhongTro
                    {
                        Stt = i,
                        MaPhongTro = pt.MaPhongTro,
                        TenPhongTro = pt.TenPhongTro,
                        GiaTien = pt.GiaTien,
                        DienTich = pt.DienTich,
                        TinhTrang = pt.TinhTrang,
                        SoNguoiToiDa = (int)pt.ToiDa,
                        SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count

                });
                }
            }
            }
            else
            {
                list = DgvPhongTro(null);
            }
            return list;
        }
        public List<ViewPhongTro> GetAllPhongTroByIdTinhTrang(string idTinhTrang)
        {
            List<ViewPhongTro> list = new List<ViewPhongTro>();
            QLDAL qLDAL = new QLDAL();
            bool status = (idTinhTrang == "1");
            if (idTinhTrang != "-1")
            {
                int i = 0;
                foreach (PhongTro pt in qLDAL.GetAllPhongTro())
                {    
                    if(pt.TinhTrang == status)
                    {
                        i++;
                        list.Add(new ViewPhongTro
                        {
                            Stt = i,
                            MaPhongTro = pt.MaPhongTro,
                            TenPhongTro = pt.TenPhongTro,
                            GiaTien = pt.GiaTien,
                            DienTich = pt.DienTich,
                            TinhTrang = pt.TinhTrang,
                            SoNguoiToiDa = (int)pt.ToiDa,
                            SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count

                        });
                    }
                }
            }
            else
            {
                list = DgvPhongTro(null);
            }
            return list;
        }
        public List<ViewPhongTro> DgvPhongTroTimKiem(string idDay,string idTinhTrang,string txtTim)
        {
            
            List<ViewPhongTro> list = new List<ViewPhongTro>();
            List<String>IdPhongFromIdDay = new List<String>();
            foreach(ViewPhongTro pt in GetAllPhongTroByIdDay(idDay))
            {
                IdPhongFromIdDay.Add(pt.MaPhongTro);
            }
            List<String> IdPhongFromIdTinhTrang = new List<String>();
            foreach (ViewPhongTro pt in GetAllPhongTroByIdTinhTrang(idTinhTrang))
            {
                IdPhongFromIdTinhTrang.Add(pt.MaPhongTro);
            }
            List<String> IdPhongFromTxtTim = new List<String>();
            foreach (ViewPhongTro pt in DgvPhongTro(txtTim))
            {
                IdPhongFromTxtTim.Add(pt.MaPhongTro);
            }
            List<string>idPhong = new List<string>();

            idPhong = IdPhongFromIdDay.Intersect(IdPhongFromIdTinhTrang).Intersect(IdPhongFromTxtTim).ToList();
            
            foreach (ViewPhongTro pt in DgvPhongTro(null))
            {
                foreach(String id in idPhong)
                {
                    if (pt.MaPhongTro == id) list.Add(pt);
                }
            }

            return list;
        }
        public List<ViewDichVu> DgvDichVu(string txtTim)
        {
            List<ViewDichVu> list = new List<ViewDichVu> ();
            QLDAL qLDAL = new QLDAL();
            int i= 0;
            foreach(DichVu dv in qLDAL.GetAllDichVu())
            {
                if(txtTim == null)
                {
                    i++;
                    ViewDichVu s = new ViewDichVu();
                    s.Stt = i;
                    s.TenDichVu = dv.TenDichVu;
                    s.MaDichVu = dv.MaDichVu;
                    s.GiaDichVu = dv.GiaDichVu;
                    list.Add(s);
                }
                else
                {
                    if(dv.TenDichVu.IndexOf(txtTim,0, StringComparison.OrdinalIgnoreCase)!=-1)
                    {
                        i++;
                        ViewDichVu s = new ViewDichVu();
                        s.Stt = i;
                        s.TenDichVu = dv.TenDichVu;
                        s.MaDichVu = dv.MaDichVu;
                        s.GiaDichVu = dv.GiaDichVu;
                        list.Add(s);
                    }
                }
            }


            return list;
        }
        public void ThemDVBll(DichVu dv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.ThemDVDal(dv);
        }
        public void SuaDVBll(DichVu dv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.SuaDVDal(dv);
        }
        public DichVu GetDVByIdDV(string id)
        {
            
            QLDAL qLDAL = new QLDAL();
            foreach(DichVu dichVu in qLDAL.GetAllDichVu())
            {
                if (dichVu.MaDichVu == id) return dichVu;
            }
            return null;     
        }
        public List<string>GetIdNguoiByIdPhong(string id)
        {
            List<string> list = new List<string>();
            QLDAL qLDAL = new QLDAL();
            foreach(ThanhVienTrongPhong tv in qLDAL.GetAllThanhVienTrongPhong())
            {
                if (tv.MaPhongTro == id) list.Add(tv.MaNguoi);
            }
            return list;
        }
        
    }
}

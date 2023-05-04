using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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
        public List<PhongTro>GetAllPhongTro()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllPhongTro();
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
        public DayTro GetDayTroById(string id)
        {
            foreach(DayTro dt in GetAllDayTroBll())
            {
                if (dt.MaDayTro == id) return dt;
            }
            return null;
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
                    if (ng.MaNguoi == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdHoaDon()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (HoaDon hd in qLDAL.GetAllHoaDon())
                {
                    if (hd.MaHoaDon == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdChiTietSuDungDichVu()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietSuDungDichVu dv in qLDAL.GetAllChiTietSuDungDichVu())
                {
                    if (dv.MaChiTietSuDungDichVu == id) status = true;
                }
            }
            return id;
        }
        public List<ChiTietSuDungDichVu>GetAllChiTietSuDungDichVuBll()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllChiTietSuDungDichVu();

        }

        public string TaoIdChiTietDichVu()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietDichVu ctdv in qLDAL.GetAllChiTietDichVu())
                {
                    if (ctdv.MaChiTietDichVu == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdChiTietThietBi()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietThietBi cttb in qLDAL.GetAllChiTietThietBi())
                {
                    if (cttb.MaChiTietThietBi == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdThanhVienTrongPhong()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ThanhVienTrongPhong tvtp in qLDAL.GetAllThanhVienTrongPhong())
                {
                    if (tvtp.MaThanhVienTrongPhong == id) status = true; 
                }
            }
            return id;
        }
        public string GetIdPhongByIdNguoi(string idNguoi)
        {
            QLDAL qLDAL = new QLDAL();
            foreach(ThanhVienTrongPhong tvtp in qLDAL.GetAllThanhVienTrongPhong())
            {
                if (tvtp.MaNguoi == idNguoi) return tvtp.MaPhongTro;
            }
            return null;
        }
        public string GetIdPhongByIdTB(string idTB)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (ChiTietThietBi cttp in qLDAL.GetAllChiTietThietBi())
            {
                if (cttp.MaThietBi == idTB) return cttp.MaPhongTro;
            }
            return null;
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
                    if (phongTro.MaPhongTro == id) status = true;
                }
            }
            return id;
        }
        public string GetIdCHiTietDichVuDienByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL() ;
            foreach(ChiTietDichVu dv in qLDAL.GetAllChiTietDichVu())
            {
                if (dv.MaPhongTro == idPhong && dv.MaDichVu == "001") return dv.MaChiTietDichVu;
            }
            return null;
        }
        public string GetIdCHiTietDichVuNuocByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (ChiTietDichVu dv in qLDAL.GetAllChiTietDichVu())
            {
                if (dv.MaPhongTro == idPhong && dv.MaDichVu == "000") return dv.MaChiTietDichVu;
            }
            return null;
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
                    if(dayTro.MaDayTro == id)status = true;
                }
            }
            return id;
        }
        public string TaoIdHopDong()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (HopDong hopDong in qLDAL.GetAllHopDong())
                {
                    if (hopDong.MaHopDong == id) status = true; break;
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
                    if (dv.MaDichVu == id) status = true;
                }
            }
            return id;
        }

        public string TaoIdThietBi()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ThietBi dv in qLDAL.GetAllThietBi())
                {
                    if (dv.MaThietBi == id) status = true; break;
                }
            }
            return id;
        }
        public void AddDayTroBll(DayTro dt)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddDayTroDal(dt);
        }
        public void AddHoaDonBll(HoaDon hd)
        {
            QLDAL qLDAL= new QLDAL();
            qLDAL.AddHoaDonDal(hd);
        }
        public List<HoaDon>GetAllHoaDonBll()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllHoaDon();
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
                    vd.HinhAnh = dt.HinhAnh;
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
                        vd.HinhAnh = dt.HinhAnh;
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
                    vd.TenDay = GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro;
                    vd.HinhAnh = pt.HinhAnh;
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
                        vd.TenDay = GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro;
                        vd.HinhAnh = pt.HinhAnh;
                        list.Add(vd);
                    }
                }
            }

            return list;
        }
        public void AddChiTietSuDungDichVuBLL(ChiTietSuDungDichVu dv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddChiTietSuDungDichVuDal(dv);
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
                        SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count,
                        TenDay = GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro,
                        HinhAnh = pt.HinhAnh
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
            if (idTinhTrang != "-1")
            {
                int i = 0;
                foreach (PhongTro pt in qLDAL.GetAllPhongTro())
                {
                    if (idTinhTrang == "0")
                    {
                        if(GetHopDongByIdPhong(pt.MaPhongTro) == null)
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
                                SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count,
                                TenDay = GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro,
                                HinhAnh = pt.HinhAnh
                            });
                        }

                    }
                    else if (idTinhTrang == "1")
                    {
                        if(GetHopDongByIdPhong(pt.MaPhongTro)!=null)
                        {
                            if(GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == true)
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
                                    SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count,
                                    TenDay = GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro,
                                    HinhAnh = pt.HinhAnh
                                });
                            }
                        }
                    }
                    else
                    {
                        if (GetHopDongByIdPhong(pt.MaPhongTro)!=null)
                        {
                            if (GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == false)
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
                                    SoNguoiHienCo = GetIdNguoiByIdPhong(pt.MaPhongTro).Count,
                                    TenDay = GetDayTroByIdPhong(pt.MaPhongTro).TenDayTro,
                                    HinhAnh = pt.HinhAnh
                                });
                            }
                        }
                    }
                }
            }
            else
            {
                list = DgvPhongTro(null);
            }
            return list;
        }
        public HoaDon GetHoaDonById(string id)
        {
            foreach(HoaDon hd in GetAllHoaDonBll())
            {
                if (hd.MaHoaDon == id) return hd;
            }
            return null;
        }
        public void UpdateHopDongBLL(HopDong hd)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.UpdateHopDongDAL(hd);
        }
        public void UpdateHoaDonBLL(HoaDon hd)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.UpdateHoaDonDal(hd);
        }
        public void UpdateNguoiBLL(Nguoi nguoi)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.UpdateNguoiDAL(nguoi);
        }
        public void DelThietBiBll(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelThietBiDal(id);
        }
        
        public void UpdateChiTietSuDungDichVu(ChiTietSuDungDichVu dv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.UpdateChiTietSuDungDichVuDAL(dv);
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdBLL(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetChiTietSuDungDichVuByIdDAL(id);
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

        public List<ViewThietBi> DgvThietBi(string txtTim)
        {
            List<ViewThietBi> list = new List<ViewThietBi>();
            QLDAL qLDAL = new QLDAL();
            int i = 0;
            foreach (ThietBi dv in qLDAL.GetAllThietBi())
            {
                if (txtTim == null)
                {
                    i++;
                    ViewThietBi s = new ViewThietBi();
                    s.Stt = i;
                    s.TenThietBi = dv.TenThietBi;
                    s.MaThietBi = dv.MaThietBi;
                    s.GiaThietBi = dv.GiaThietBi;
                    list.Add(s);
                }
                else
                {
                    if (dv.TenThietBi.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        i++;
                        ViewThietBi s = new ViewThietBi();
                        s.Stt = i;
                        s.TenThietBi = dv.TenThietBi;
                        s.MaThietBi = dv.MaThietBi;
                        s.GiaThietBi = dv.GiaThietBi;
                        list.Add(s);
                    }
                }
            }


            return list;
        }
        public void AddHdBll(HopDong hd)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddHopDongDal(hd);
        }
        public void AddChiTietDichVuBll(ChiTietDichVu ctdv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddChiTietDichVuDal(ctdv);
        }
        public void AddChiTietThietBiBll(ChiTietThietBi cttb)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddChiTietThietBiDal(cttb);
        }
        public void AddNguoiBll(Nguoi n)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddNguoiDal(n);
        }
        public DichVu GetDichVuByIdDichVu(string id)
        {
            QLDAL qLDAL = new QLDAL();
            foreach(DichVu dv in qLDAL.GetAllDichVu())
            {
                if (dv.MaDichVu == id) return dv;
            }
            return null;
        }
        public ThietBi GetThietBiByIdThietBi(string id)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (ThietBi tb in qLDAL.GetAllThietBi())
            {
                if (tb.MaThietBi == id) return tb;
            }
            return null;
        }
        public void ThemDVBll(DichVu dv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.ThemDVDal(dv);
        }
        public void ThemTBBll(ThietBi tb)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.ThemTBDal(tb);
        }
        public void SuaDVBll(DichVu dv)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.SuaDVDal(dv);
        }
        public void SuaTBBll(ThietBi tb)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.SuaTBDal(tb);
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
        
        public ThietBi GetTBByIdTB(string id)
        {

            QLDAL qLDAL = new QLDAL();
            foreach (ThietBi tb in qLDAL.GetAllThietBi())
            {
                if (tb.MaThietBi == id) return tb;
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
        public List<Nguoi>GetNguoiByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            List<Nguoi> nguois = new List<Nguoi>();
            foreach(ThanhVienTrongPhong tv in qLDAL.GetAllThanhVienTrongPhong())
            {
                if(tv.MaPhongTro == idPhong)
                {
                    nguois.Add(GetNguoiByIdNguoi(tv.MaNguoi));
                }
            }
            return nguois;
        }
        public List<PhongTro>GetPhongTroByIdDay(string idDay)
        {
            List<PhongTro>list = new List<PhongTro>();
            foreach(PhongTro pt in GetAllPhongTro())
            {
                if (pt.MaDayTro == idDay) list.Add(pt);
            }
            return list;
        }
       
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            QLDAL qLDAL= new QLDAL();
            PhongTro phongtro = qLDAL.GetPhongTroByIdPhong(idPhong);
            return phongtro;

        }
        public void AddThanhVienTrongPhongBll(ThanhVienTrongPhong tvtp)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddThanhVienTrongPhong(tvtp);
        }
        public void UpdatePTBLL(PhongTro PT)
        {
            QLDAL qlDAl = new QLDAL();
            qlDAl.UpdatePTDAL(PT);
        }
        public string GetIdDayByIdPhong(string IdPhong)
        {
            QLDAL qlDAl = new QLDAL();
            return qlDAl.GetIdDayByIdPhong(IdPhong);
        }
        public string GetIdThietBiByIdPhong(string IdPhong)
        {
            QLDAL qlDAl = new QLDAL();
            return qlDAl.GetIdDayByIdPhong(IdPhong);
        }
        public DayTro GetDayTroByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            PhongTro pt = new PhongTro();
            pt = GetPhongTroByIdPhong(idPhong);
            foreach (DayTro daytro in qLDAL.GetAllDayTro())
            {
                if (daytro.MaDayTro  == pt.MaDayTro) return daytro;
            }
            return null;
        }
        
        public List<string>GetAllIdDichVuByIdPhong(string idPhong)
        {
            QLDAL qLDAL= new QLDAL();
            List<string> idDichVu = new List<string>();
            foreach(ChiTietDichVu ctdv in qLDAL.GetAllChiTietDichVu())
            {
                if (ctdv.MaPhongTro == idPhong) idDichVu.Add(ctdv.MaDichVu);
            }
            return idDichVu;
        }
        public List<string> GetAllIdThietBiByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            List<string> idThietBi = new List<string>();
            foreach (ChiTietThietBi cttb in qLDAL.GetAllChiTietThietBi())
            {
                if (cttb.MaPhongTro == idPhong) idThietBi.Add(cttb.MaThietBi);
            }
            return idThietBi;
        }
        public Nguoi GetNguoiByIdNguoi(string IdNguoi)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (Nguoi nguoi in qLDAL.GetAllNguoi())
            {
                if (nguoi.MaNguoi == IdNguoi) return nguoi;
            }
            return null;
        }

        public DayTro GetDayByIdDay(string id)
        {
            QLDAL qLDAL= new QLDAL();
            foreach (DayTro daytro in qLDAL.GetAllDayTro())
            {
                if (daytro.MaDayTro  == id) return daytro;
            }    
            return null;
        }

        public void SuaDayBll(DayTro day)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.SuaDayDal(day);
        }
        public List<DgvHopDong>DgvHopDong()
        {
            List<DgvHopDong>list = new List<DgvHopDong> ();
            QLDAL qLDAL = new QLDAL ();
            List<HopDong> hopDongs = new List<HopDong>();
            hopDongs = qLDAL.GetAllHopDong();
            int i = 1;
            foreach(HopDong hopDong in hopDongs)
            {
                DgvHopDong hd = new DgvHopDong ();
                hd.MaHopDong = hopDong.MaHopDong;
                hd.Stt = i++;
                hd.TenKhachHang = GetNguoiByIdNguoi(hopDong.MaNguoi).Ten;
                hd.TenPhongTro = GetPhongTroByIdPhong(hopDong.MaPhongTro).TenPhongTro;
                hd.TenDayTro = GetDayTroByIdPhong(hopDong.MaPhongTro).TenDayTro;
                hd.NgayBatDau = hopDong.NgayBatDau;
                hd.NgayKetThuc = hopDong.NgayKetThuc;
                hd.TienCoc = hopDong.TienCoc;
                list.Add(hd);
            }

            return list;
        }
        public ChiTietDichVu GetChiTietDichVuById(string id)
        {
            QLDAL qLDAL = new QLDAL();
            foreach(ChiTietDichVu dv in qLDAL.GetAllChiTietDichVu())
            {
                if (dv.MaChiTietDichVu == id) return dv;
            }
            return null;

        }
        public List<ChiTietDichVu>GetChiTietDichVuByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            List<ChiTietDichVu> list = new List<ChiTietDichVu> ();
            foreach(ChiTietDichVu ctdv in qLDAL.GetAllChiTietDichVu())
            {
                if(ctdv.MaPhongTro == idPhong)list.Add(ctdv);
            }
            return list;
        }
        public HopDong GetHopDongByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            foreach(HopDong hopDong in qLDAL.GetAllHopDong())
            {
                if(hopDong.MaPhongTro == IdPhong)return hopDong;
            }
            return null;
        }
        public List<ChiTietThietBi>GetChiTietThietBiByIdPhong(string IdPhong)
        {
            List<ChiTietThietBi> list = new List<ChiTietThietBi>();
            QLDAL qLDAL = new QLDAL() ;
            foreach(ChiTietThietBi cttb in qLDAL.GetAllChiTietThietBi())
            {
                if(cttb.MaPhongTro == IdPhong)list.Add(cttb);
            }
            return list;
        }
        public List<string>GetAllIdCHiTietThietBiByIdPhong(string idPhong)
        {
            List<string> list = new List<string>();
            QLDAL qLDAL = new QLDAL() ;
            foreach(ChiTietThietBi cttb in qLDAL.GetAllChiTietThietBi())
            {
                if (cttb.MaPhongTro == idPhong) list.Add(cttb.MaChiTietThietBi);
            }


            return list;
        }
        public ChiTietThietBi GetChiTietThietBiById(string IdChiTiet)
        {
            QLDAL qLDAL = new QLDAL();
            foreach(ChiTietThietBi cttb in qLDAL.GetAllChiTietThietBi())
            {
                if (cttb.MaChiTietThietBi == IdChiTiet) return cttb;
            }
            return null;
        }
        public void DelCHiTietThietBiByIdPhongBLL(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();

            foreach(string id in GetAllIdCHiTietThietBiByIdPhong(IdPhong))
            {
                qLDAL.DelCHiTietThietBiById(id);
            }
        }
        public List<string> GetAllChiTietThietBiByIdThietBi(string idThietBi)
        {
            QLDAL qLDAL = new QLDAL();
            List<string> list = new List<string>();
            foreach(ChiTietThietBi ct in qLDAL.GetAllChiTietThietBi())
            {
                if (ct.MaThietBi == idThietBi) list.Add(ct.MaChiTietThietBi);
            }
            return list;
        }
        public void DelChiTietThietBiByIdThietBi(string idThietBi)
        {
            QLDAL qLDAL =new QLDAL();
            foreach(string id in GetAllChiTietThietBiByIdThietBi(idThietBi))
                {
                qLDAL.DelCHiTietThietBiById(id);
            }
        }
        public void DelChiTietDichVu(string id)
        {
            QLDAL qLDAL=new QLDAL();
            qLDAL.DelChiTietDichVuDal(id);
        }
        public void DelDichVu(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelDichVuDal(id);
        }
        public List<string>GetAllChiTietDichVuByIdDichVu(string id)
        {
            List<string> list = new List<string>();
            QLDAL qLDAL = new QLDAL();
            foreach(ChiTietDichVu ct in qLDAL.GetAllChiTietDichVu())
            {
                if (ct.MaDichVu == id) list.Add(ct.MaChiTietDichVu);
            }
            return list;
        }
        public List<DayTro> GetAllDayTroBll()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllDayTro();
        }
        public void DelChiTietDichVuByIdDichVu(string id)
        {
            
            foreach(string Id in GetAllChiTietDichVuByIdDichVu(id))
            {
                DelChiTietDichVu(Id);
            }
        }
        public void DelNguoiBll(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelNguoiDal(id);
        }
        public void DelThanhVienBLL(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelThanhVienDAL(id);
        }
        public void DelHoaDonBll(string id)
        {
            QLDAL qLDAL= new QLDAL();
            qLDAL.DelHoaDonDal(id);
        }
        public string GetIdThanhVienByIdNguoi(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdThanhVienByIdNguoi(id);
        }
        public List<string>GetChiTietSuDungDichVuByThangSuDung(string ThangSd)
        {
            QLDAL qLDAL = new QLDAL();
            List<string> list = new List<string>();
            foreach(ChiTietSuDungDichVu dv in qLDAL.GetAllChiTietSuDungDichVu())
            {
                if(dv.ThoiGian == ThangSd)list.Add(dv.MaChiTietSuDungDichVu);
            }
            return list;
        }
        public List<string> GetChiTietSuDungDichVuByIdDay(string IdDay)
        {
            QLDAL qLDAL = new QLDAL();
            List<string> list = new List<string>();
            foreach (ChiTietSuDungDichVu dv in qLDAL.GetAllChiTietSuDungDichVu())
            {
                if(IdDay != "0")
                {

                ChiTietDichVu ctdv = GetChiTietDichVuById(dv.MaCHiTietDichVu);
                PhongTro pt = GetPhongTroByIdPhong(ctdv.MaPhongTro);
                if (pt.MaDayTro == IdDay) list.Add(dv.MaChiTietSuDungDichVu);
                }
                else
                {
                    list.Add(dv.MaChiTietSuDungDichVu);
                }
            }
            return list;
        }
        public List<string> GetChiTietSuDungDichVuByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            List<string> list = new List<string>();

            foreach (ChiTietSuDungDichVu dv in qLDAL.GetAllChiTietSuDungDichVu())
            {
                if(IdPhong != "0")
                {

                ChiTietDichVu ctdv = GetChiTietDichVuById(dv.MaCHiTietDichVu);
                PhongTro pt = GetPhongTroByIdPhong(ctdv.MaPhongTro);
                if (pt.MaPhongTro == IdPhong) list.Add(dv.MaChiTietSuDungDichVu);
                }
                else
                {
                    list.Add(dv.MaChiTietSuDungDichVu);
                }
            }
            return list;
        }
        public List<string> GetChiTietSuDungDichVuByTinhTrang(string IdTinhTrang)
        {
            QLDAL qLDAL = new QLDAL();
            List<string> list = new List<string>();

            foreach (ChiTietSuDungDichVu dv in qLDAL.GetAllChiTietSuDungDichVu())
            {
                if (IdTinhTrang != "0")
                {
                    bool tt = (IdTinhTrang == "1");
                    if (dv.TinhTrang == tt) list.Add(dv.MaChiTietSuDungDichVu);
                }
                else
                {
                    list.Add(dv.MaChiTietSuDungDichVu);
                }
            }
            return list;
        }
        public List<ChiTietSuDungDichVu> GetChiTietSuDungDichVuTimKiem(string ThangSd,string IdDay,string IdPhong,string idTinhTrang)
        {
            List<string> ThangSuDung = GetChiTietSuDungDichVuByThangSuDung(ThangSd);
            List<string> Day = GetChiTietSuDungDichVuByIdDay(IdDay);
            List<string> Phong = GetChiTietSuDungDichVuByIdPhong(IdPhong);
            List<string> TinhTrang = GetChiTietSuDungDichVuByTinhTrang(idTinhTrang);
            List<string> Id = new List<string>();
            List<ChiTietSuDungDichVu> kq = new List<ChiTietSuDungDichVu>();
            Id = ThangSuDung.Intersect(Day).Intersect(Phong).Intersect(TinhTrang).ToList();
            foreach(ChiTietSuDungDichVu dv in GetAllChiTietSuDungDichVuBll())
            {
                foreach(string id in Id)
                {
                    if(id == dv.MaChiTietSuDungDichVu)kq.Add(dv);
                }
            }
            return kq;


        }
        public bool TinhTrangPhongById(string IdPhong)
        {
            if (GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == false) return false;
            return true;
            
        }
        public bool PhongDaCocByIdPhong(string IdPhong)
        {
            if (GetHopDongByIdPhong(IdPhong)==null) return false;
            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == true) return false;
            return true;
        }
        public List<string> GetHoaDonByThangChiTra(string ThangCt)
        {
            
            List<string> list = new List<string>();
            foreach(HoaDon hd in GetAllHoaDonBll())
            {
                if (hd.ThangChiTra == ThangCt) list.Add(hd.MaHoaDon);
            }
            return list;
        }
        public List<string> GetHoaDonByIdDay(string IdDay)
        {
            List<string> list = new List<string>();
            foreach (HoaDon hd in GetAllHoaDonBll())
            {
                if(IdDay != "0")
                {
                    DayTro dt = GetDayTroByIdPhong(hd.MaPhongTro);
                    if(dt.MaDayTro == IdDay)
                    {
                        list.Add(hd.MaHoaDon);
                    }
                }
                else
                {
                    list.Add(hd.MaHoaDon);
                }
            }
            return list;
        }
        public List<string>GetHoaDonByIdPhong(string IdPhong)
        {
            List<string> list = new List<string>();
            foreach (HoaDon hd in GetAllHoaDonBll())
            {
                if (IdPhong != "0")
                {
                    
                    if (hd.MaPhongTro == IdPhong)
                    {
                        list.Add(hd.MaHoaDon);
                    }
                }
                else
                {
                    list.Add(hd.MaHoaDon);
                }
            }
            return list;
        }
        public List<string>GetHoaDonByTinhTrang(string IdTinhTrang)
        {
            List<string>list = new List<string>();
            foreach(HoaDon hd in GetAllHoaDonBll())
            {
                if(IdTinhTrang != "0")
                {
                    bool tt = (IdTinhTrang == "1");
                    if (hd.TinhTrang == tt) list.Add(hd.MaHoaDon);
                }
                else
                {
                    list.Add(hd.MaHoaDon);
                }
            }
            return list;
        }
        public List<HoaDon>GetHoaDonTimKiem(string ThangCt,string IdDay,string idPhong,string IdTinhTrang)
        {
            List<string> ThangChiTra = GetHoaDonByThangChiTra(ThangCt);
            List<string> Day = GetHoaDonByIdDay(IdDay);
            List<string> Phong = GetHoaDonByIdPhong(idPhong);
            List<string> TinhTrang = GetHoaDonByTinhTrang(IdTinhTrang);
            List<string> Id = new List<string>();
            List<HoaDon> kq = new List<HoaDon>();
            Id = ThangChiTra.Intersect(Day).Intersect(Phong).Intersect(TinhTrang).ToList();
            foreach(HoaDon hd in GetAllHoaDonBll())
            {
                foreach(string id in Id)
                {
                    if (id == hd.MaHoaDon) kq.Add(hd);
                }
            }
            return kq;
        }
    }
}

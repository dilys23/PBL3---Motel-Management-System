using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using Chart =System.Windows.Forms.DataVisualization.Charting.Chart;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLL
    {
        public string GetIdTk(string taikhoan, string matkhau)
        {  
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdTkDal(taikhoan,matkhau);//ok
        }
        public string GetIdNguoiByTaiKhoan(string idTaiKhoan)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdNguoiByTaiKhoanDal(idTaiKhoan);
        }
        public List<PhongTro> GetAllPhongTro()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllPhongTro();//ok
        }
        public List<ViewCbb> GetCbbDayTro()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb{key = "-1",value = "All"});
            QLDAL qLDAL = new QLDAL();
            foreach (DayTro dt in qLDAL.GetAllDayTro())
            {
                list.Add(new ViewCbb { key = dt.MaDayTro, value = dt.TenDayTro });//ok
            }
            return list;
        }
        public List<ViewCbb> GetCbbTinhTrang()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            list.Add(new ViewCbb { key = "1", value = "Đã xác thực" });
            list.Add(new ViewCbb { key = "2", value = "Chưa xác thực" });
            return list;
        }
        public List<ViewCbb> GetCbbTinhTrangPhong()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            list.Add(new ViewCbb { key = "1", value = "Đã cho thuê" });
            list.Add(new ViewCbb { key = "0", value = "Còn trống" });
            list.Add(new ViewCbb { key = "2", value = "Đã cọc" });
            return list;
        }
        public DayTro GetDayTroById(string id)
        {
            foreach (DayTro dt in GetAllDayTroBll())
            {
                if (dt.MaDayTro == id) return dt;//ok
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
        public List<ChiTietSuDungDichVu> GetAllChiTietSuDungDichVuBll()
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
            return qLDAL.GetIdPhongByIdNguoiDal(idNguoi);//ok
        }
        public List<String> GetIdPhongByIdTB(string idTB)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdPhongByIdTbDal(idTB);//ok
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
                foreach (PhongTro phongTro in qLDAL.GetAllPhongTro())//ok
                {
                    if (phongTro.MaPhongTro == id) status = true;
                }
            }
            return id;
        }
        public string GetIdCHiTietDichVuDienByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdChiTietDichVuDienByIdPhongDal(idPhong);
        }
        public string GetIdCHiTietDichVuNuocByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdChiTietDichVuNuocByIdPhongDal(idPhong);
        }
        public ChiTietSuDungDichVu GetChiTietSudungDichVuById(string id)
        {
            QLDAL qLDAL= new QLDAL();   
            return qLDAL.GetChiTietSuDungDichVuById(id);
        }
        public string TaoIdDayTro()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (DayTro dayTro in qLDAL.GetAllDayTro())
                {
                    if (dayTro.MaDayTro == id) status = true;//ok
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
            qLDAL.AddDayTroDal(dt);//ok
        }
        public void AddHoaDonBll(HoaDon hd)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddHoaDonDal(hd);
        }
        public List<HoaDon> GetAllHoaDonBll()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllHoaDon();
        }
        public void AddPhongTroBll(PhongTro phongTro)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddPhongTroDal(phongTro);//ok
        }
        public List<string> DgvPhongTro(string txtTim)//ok
        {
            List<string> list = new List<string>();
            QLDAL qLDAL = new QLDAL();
            foreach (PhongTro pt in qLDAL.GetAllPhongTro())
            {
                if (txtTim == null)
                {
                    list.Add(pt.MaPhongTro);
                }
                else
                {
                    if (pt.TenPhongTro.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        list.Add(pt.MaPhongTro);
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
        public List<string> GetAllPhongTroByIdDay(string idDay)
        {
            QLDAL qLDAL = new QLDAL();
            if(idDay != "-1")
            {
                return qLDAL.GetAllIdPhongTroByIdDayDal(idDay);
            }
            else
            {
                return qLDAL.GetAllIdPhongTroDal();//ok
            }
        }
        public List<string> GetAllPhongTroByIdTinhTrang(string idTinhTrang)
        {
            List<string> list = new List<string>();
            QLDAL qLDAL = new QLDAL();
            if (idTinhTrang != "-1")
            {
                foreach (PhongTro pt in qLDAL.GetAllPhongTro())
                {
                    if (idTinhTrang == "0")
                    {
                        if (GetHopDongByIdPhong(pt.MaPhongTro) == null)
                        {
                            list.Add(pt.MaPhongTro);
                        }
                    }
                    else if (idTinhTrang == "1")
                    {
                        if (GetHopDongByIdPhong(pt.MaPhongTro) != null)
                        {
                            if (GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == true)
                            {
                                list.Add(pt.MaPhongTro);
                            }
                        }
                    }
                    else
                    {
                        if (GetHopDongByIdPhong(pt.MaPhongTro) != null)
                        {
                            if (GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == false)
                            {
                                list.Add(pt.MaPhongTro);
                            }
                        }
                    }
                }
            }
            else
            {
                list = qLDAL.GetAllIdPhongTroDal();//ok
            }
            return list;
        }
        public HoaDon GetHoaDonById(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetHoaDonByIdDal(id);
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
        public void UpdateChitietdichvu(ChiTietDichVu ct)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.UpdateChitietdichvu(ct);
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetPhongTroByIdPhong(idPhong);//ok
        }
        public List<PhongTro> PhongTroTimKiem(string idDay, string idTinhTrang, string txtTim)
        {
            List<PhongTro> list = new List<PhongTro>();
            List<String> IdPhongFromIdDay = GetAllPhongTroByIdDay(idDay);
            List<String> IdPhongFromIdTinhTrang = GetAllPhongTroByIdTinhTrang(idTinhTrang);
            List<String> IdPhongFromTxtTim = DgvPhongTro(txtTim);
            List<string> idPhong = new List<string>();
            idPhong = IdPhongFromIdDay.Intersect(IdPhongFromIdTinhTrang).Intersect(IdPhongFromTxtTim).ToList();
            foreach(string id in idPhong)
            {
                list.Add(GetPhongTroByIdPhong(id));//ok
            }
            return list;
        }
        public List<ViewDichVu> DgvDichVu(string txtTim)
        {
            List<ViewDichVu> list = new List<ViewDichVu>();
            QLDAL qLDAL = new QLDAL();
            int i = 0;
            foreach (DichVu dv in qLDAL.GetAllDichVu())
            {
                if (txtTim == null)
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
                    if (dv.TenDichVu.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
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
            return qLDAL.GetDichVuByIdDichVuDal(id);
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
        public List<string> GetIdNguoiByIdPhong(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdNguoiByIdPhongDal(id);
        }
        public List<Nguoi> GetNguoiByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetNguoiByIdPhongDal(idPhong);
        }
        public List<PhongTro> GetPhongTroByIdDay(string idDay)
        {
            QLDAL qLDAL= new QLDAL();
            return qLDAL.GetPhongTroByIdDayDal(idDay);//ok
        }
        public HopDong GetHopDongByMaHD(string MaHD)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetHopDongByMaHD(MaHD);
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
            return qlDAl.GetIdDayByIdPhong(IdPhong);//ok
        }
        public string GetIdThietBiByIdPhong(string IdPhong)
        {
            QLDAL qlDAl = new QLDAL();
            return qlDAl.GetIdDayByIdPhong(IdPhong);
        }
        public DayTro GetDayTroByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetDayTroByIdPhongDal(idPhong);//ok
        }

        public List<string> GetAllIdDichVuByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllIdDichVuByIdPhongDal(idPhong);
        }

        public List<string> GetAllIdThietBiByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllIdThietBiByIdPhongDal(idPhong);
        }
        public Nguoi GetNguoiByIdNguoi(string IdNguoi)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetNguoiByIdNguoiDal(IdNguoi);
        }
        public DayTro GetDayByIdDay(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetDayByIdDay(id);//ok
        }
        public ThietBi GetTBByIdTB(string idTb)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetThietBiByIdThietBiDal(idTb);
        }
        public DichVu GetDVByIdDV(string IdDV)
        {
            QLDAL qLDAL= new QLDAL();
            return qLDAL.GetDichVuByIdDichVuDal(IdDV);
        }
        public void SuaDayBll(DayTro day)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.SuaDayDal(day);
        }
        public List<DgvHopDong> DgvHopDong()
        {
            List<DgvHopDong> list = new List<DgvHopDong>();
            QLDAL qLDAL = new QLDAL();
            int i = 1;
            foreach (HopDong hopDong in qLDAL.GetAllHopDong())
            {
                DgvHopDong hd = new DgvHopDong();
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
            return qLDAL.GetChiTietDichVuByIdDal(id);

        }
        public List<ChiTietDichVu> GetChiTietDichVuByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            foreach (ChiTietDichVu ctdv in qLDAL.GetAllChiTietDichVu())
            {
                if (ctdv.MaPhongTro == idPhong) list.Add(ctdv);
            }
            return list;
           
        }
        public HopDong GetHopDongByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetHopDongByIdPhong(IdPhong);
        }
        public List<ChiTietThietBi> GetChiTietThietBiByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetChiTietThietBiByIdPhongDal(IdPhong);
        }
        public List<string> GetAllIdCHiTietThietBiByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllIdChiTietThietBiByIdPhong(idPhong);
        }
        public List<string> GetAllIdChitietDichVuByIdPhong(string idphong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllIdChiTietDichVuByIdPhong(idphong);
        }
        public ChiTietThietBi GetChiTietThietBiById(string IdChiTiet)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetChiTietThietBiByIdDal(IdChiTiet);
        }
        public void DelCHiTietThietBiByIdPhongBLL(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (string id in GetAllIdCHiTietThietBiByIdPhong(IdPhong))
            {
                qLDAL.DelCHiTietThietBiById(id);
            }
        }
       
        public void DelCHiTietDichVuByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (string id in GetAllIdChitietDichVuByIdPhong(IdPhong))
            {
                qLDAL.DelChiTietDichVuDal(id);
            }
        }
        
       
        public string GetMaChiTietDichVuByIdPhong(string idPhong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetMaChiTietDichVuByIdPhong(idPhong);
        }
        public List<string> GetAllChiTietThietBiByIdThietBi(string idThietBi)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllIdChiTietThietBiByIdThietBi(idThietBi);
        }
        public void DelChiTietThietBiByIdThietBi(string idThietBi)
        {
            QLDAL qLDAL = new QLDAL();
            foreach (string id in GetAllChiTietThietBiByIdThietBi(idThietBi))
            {
                qLDAL.DelCHiTietThietBiById(id);
            }
        }

        public void DelChiTietDichVu(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelChiTietDichVuDal(id);
        }
        public void DelChiTietSuDungDichVu(string id)
        {
            QLDAL qLDAL= new QLDAL();
            qLDAL.DelChiTietSuDungDichVuDal(id);
        }
        public void DelDichVu(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelDichVuDal(id);
        }
        public List<string> GetAllChiTietDichVuByIdDichVu(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllIdChiTietDichVuByIdDichVu(id);
        }
        public List<string> GetAllChiTietSuDungDichVubyIdChiTiet (string id)
        {
            QLDAL qLDAL= new QLDAL();   
            return qLDAL.GetChiTietSuDungDichVuByIdChitiet(id);
        }
        public List<DayTro> GetAllDayTroBll()
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetAllDayTro();//ok
        }
        public void DelChiTietDichVuByIdDichVu(string id)
        {
            foreach (string Id in GetAllChiTietDichVuByIdDichVu(id))
            {
                DelChiTietDichVu(Id);
            }
        }
        public void DelChiTietSuDungDichVubyId(string id)
        {
            foreach (string Id in GetAllChiTietSuDungDichVubyIdChiTiet(id)) ;
            {
                DelChiTietSuDungDichVubyId(id);
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
        public void DelPhongTroBLL(string idphong)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelPhongTroDAL(idphong);//ok
        }
        public void DelHoaDonBll(string id)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelHoaDonDal(id);
        }
        public void DelHopDong(string idhopdong)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelHopDong(idhopdong);
        }
        public void DelDayTroBll(string MaDay)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.DelDayTroDal(MaDay);//ok
        }
        public bool CheckDay(string idday)
        {
            int check = 0;
            foreach (PhongTro pt in GetPhongTroByIdDay(idday))
            {
                if (GetHopDongByIdPhong(pt.MaPhongTro) != null && pt.TonTai ==true) check++;  //ok
            }
            if (check == 0) return false;
            else return true;
        }

        public string GetIdThanhVienByIdNguoi(string id)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdThanhVienByIdNguoi(id);
        }
        public List<string> GetIDThanhvienbyIDPhong(string idphong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIDThanhvienbyIDPhong(idphong);
        }
        public List<string>GetChiTietSuDungDichVuByThangSuDung(string ThangSd)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetChiTietSuDungDichVuByThangSuDungDal(ThangSd);
        }
        public List<string> GetChiTietSuDungDichVuByIdDay(string IdDay)
        {
            QLDAL qLDAL = new QLDAL();
            if(IdDay != "-1")
            {
                return qLDAL.GetChiTietSuDungDichVuByIdDayDal(IdDay);
            }
            else
            {
                return qLDAL.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public List<string> GetChiTietSuDungDichVuByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            if(IdPhong != "-1")
            {
                return qLDAL.GetChiTietSuDungDichVuByIdPhongDal(IdPhong);
            }
            else
            {
                return qLDAL.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public List<string> GetChiTietSuDungDichVuByTinhTrang(string IdTinhTrang)
        {
            QLDAL qLDAL = new QLDAL();
            if(IdTinhTrang != "-1")
            {
                bool tinhTrang = (IdTinhTrang == "1");
                return qLDAL.GetChiTietSuDungDichVuByTinhTrang(tinhTrang);
            }
            else
            {
                return qLDAL.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public List<ViewChiSo>GetAllViewChiSo()
        {
            List<ViewChiSo> list = new List<ViewChiSo>();
            foreach(ChiTietSuDungDichVu dv in GetAllChiTietSuDungDichVuBll())
            {
                ChiTietDichVu ctdv = GetChiTietDichVuById(dv.MaCHiTietDichVu);
                ViewChiSo view = new ViewChiSo
                {
                    MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                    MaChiTietDichVu = ctdv.MaChiTietDichVu,
                    Stt = 1,
                    TenDayTro = GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                    TenPhongTro = GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
                    ChiSoCu = dv.ChiSoCu,
                    ChiSoMoi = dv.ChiSoMoi,
                    DaDung = dv.ChiSoMoi-dv.ChiSoCu,
                    NgayLap = dv.NgayLap,
                    ThangSuDung = dv.ThoiGian,
                    TinhTrang = dv.TinhTrang
                };
                list.Add(view);
            }
            return list;
        }
        public List<ViewChiSo>GetViewChiSoByTimKiem(string ThangSuDung,string IdDay, string IdPhong, string IdTinhTrang)
        {
            List<ViewChiSo> list = new List<ViewChiSo>();
            foreach(ChiTietSuDungDichVu dv in GetChiTietSuDungDichVuTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang))
            {
                ChiTietDichVu ctdv = GetChiTietDichVuById(dv.MaCHiTietDichVu);
                ViewChiSo view = new ViewChiSo
                {
                    MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                    MaChiTietDichVu = ctdv.MaChiTietDichVu,
                    Stt = 1,
                    TenDayTro = GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                    TenPhongTro = GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
                    ChiSoCu = dv.ChiSoCu,
                    ChiSoMoi = dv.ChiSoMoi,
                    DaDung = dv.ChiSoMoi-dv.ChiSoCu,
                    NgayLap = dv.NgayLap,
                    ThangSuDung = dv.ThoiGian,
                    TinhTrang = dv.TinhTrang
                };
                list.Add(view);
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
            foreach (ChiTietSuDungDichVu dv in GetAllChiTietSuDungDichVuBll())
            {
                foreach (string id in Id)
                {
                    if (id == dv.MaChiTietSuDungDichVu) kq.Add(dv);
                }
            }
            return kq;
        }

        public bool TinhTrangPhongById(string IdPhong)
        {
            if (GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == false) return false;//ok
            return true;
        }
        public bool PhongDaCocByIdPhong(string IdPhong)
        {
            if (GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == true) return false;//ok
            return true;
        }
        public List<string> GetHoaDonByThangChiTra(string ThangCt)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetIdHoaDonByThangChiTra(ThangCt);
        }
        public List<TinhTrangPhongTro> GetAllTinhTrangPhongTro ()
        {
            List<TinhTrangPhongTro> list = new List<TinhTrangPhongTro>();
            QLDAL qLDAL = new QLDAL();
            // Lấy ds các phòng 
            List<PhongTro> phongTroList = qLDAL.GetAllPhongTro();
            foreach (PhongTro phongTro in phongTroList)
            {
                TinhTrangPhongTro tinhTrangPhongTro = new TinhTrangPhongTro();
                tinhTrangPhongTro.MaPhongTro = phongTro.MaPhongTro;
                tinhTrangPhongTro.TinhTrangPhong = phongTro.TinhTrang;

                // lấy thông tin HD dựa trên id phòng
                HopDong hopDong = qLDAL.GetHopDongByIdPhong(phongTro.MaDayTro);//ok
                if (hopDong != null)
                {
                    tinhTrangPhongTro.TinhTrangHD = (bool)hopDong.TinhTrang;
                }
                else
                {
                    tinhTrangPhongTro.TinhTrangHD =false;
                } 
                list.Add(tinhTrangPhongTro);
            }    
            return list;
        }
        public List<string> GetHoaDonByIdDay(string IdDay)
        {
            QLDAL qLDAL = new QLDAL();
            if(IdDay != "-1")
            {
                return qLDAL.GetHoaDonByIdDay(IdDay);
            }
            else
            {
                return qLDAL.GetAllIdHoaDon();
            }
        }
        public List<string> GetHoaDonByIdPhong(string IdPhong)
        {
            QLDAL qLDAL = new QLDAL();
            if(IdPhong != "-1")
            {
                return qLDAL.GetHoaDonByIdPhong(IdPhong);
            }
            else
            {
                return qLDAL.GetAllIdHoaDon();
            }
        }
        public List<string> GetHoaDonByTinhTrang(string IdTinhTrang)
        {
            QLDAL qLDAL= new QLDAL();
            if(IdTinhTrang != "-1")
            {
                bool tinhTrang = (IdTinhTrang == "1");
                return qLDAL.GetHoaDonByTinhTrang(tinhTrang);
            }
            else
            {
                return qLDAL.GetAllIdHoaDon();
            }
        }
        public List<HoaDon> GetHoaDonTimKiem(string ThangCt, string IdDay, string idPhong, string IdTinhTrang)
        {
            List<string> ThangChiTra = GetHoaDonByThangChiTra(ThangCt);
            List<string> Day = GetHoaDonByIdDay(IdDay);
            List<string> Phong = GetHoaDonByIdPhong(idPhong);
            List<string> TinhTrang = GetHoaDonByTinhTrang(IdTinhTrang);
            List<string> Id = new List<string>();
            List<HoaDon> kq = new List<HoaDon>();
            Id = ThangChiTra.Intersect(Day).Intersect(Phong).Intersect(TinhTrang).ToList();
            foreach (HoaDon hd in GetAllHoaDonBll())
            {
                foreach (string id in Id)
                {
                    if (id == hd.MaHoaDon) kq.Add(hd);
                }
            }
            return kq;
        }
        public PhongTro GetPhongTroByMaHoaDon(string idHD)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetPhongTroByIdHoaDon(idHD);//ok
        }
        public PhongTro GetPhongTroByMaHopDong(string MaHopDong)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetPhongTroByMaHopDong(MaHopDong);//ok
        }
       

        public Nguoi GetNguoiByMaHopDong(string MaHd)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.GetNguoiByIdHopDong(MaHd);
        }
       public List<object> ThongKe(string thang)
        {
            QLDAL qLDAL = new QLDAL();
            return qLDAL.ThongKe(thang);
        }
        public bool ChoPhepXacThucChiSo(string id, string MaChiSo)
        {
            ChiTietSuDungDichVu dv = GetChiTietSuDungDichVuByIdBLL(id);
            ChiTietDichVu ctdv = GetChiTietDichVuById(dv.MaCHiTietDichVu);
            List<ChiTietSuDungDichVu> list = GetChiTietSuDungDichVuTimKiem(dv.ThoiGian, "-1", ctdv.MaPhongTro, "1");
            List<ChiTietSuDungDichVu> mylist = new List<ChiTietSuDungDichVu>();
            foreach(ChiTietSuDungDichVu ct in list)
            {
                if(GetChiTietDichVuById(ct.MaCHiTietDichVu).MaDichVu == MaChiSo) mylist.Add(ct);
            }
            if(mylist.Count == 0)
            { 
                return true;
            }
            return false;

        }
        public bool ChoPhepXacThucHoaDon(string id)
        {
            HoaDon hd = GetHoaDonById(id);
            List<HoaDon> list = GetHoaDonTimKiem(hd.ThangChiTra, "0", hd.MaPhongTro, "1");
            if(list.Count == 0)
            {
                return true;
            }
            return false;
        }
        public string GetDiaChiByIdDay(string id)
        {
            DayTro dt = GetDayByIdDay(id);
            string DiaChi = "    " + dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            return DiaChi;
        }
        public void customDGV(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgv.DefaultCellStyle.ForeColor = Color.Blue;
            dgv.DefaultCellStyle.BackColor = Color.Beige;
            dgv.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            dgv.RowTemplate.Height = 35;
            dgv.RowTemplate.MinimumHeight = 20;
        }

    }
}

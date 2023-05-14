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
        private static QLBLL _instance;
        public static QLBLL Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLL();
                return _instance;
            }
            private set { }
        }
        private QLBLL()
        {

        }
        public string GetIdTk(string taikhoan, string matkhau)
        {  
            return QLDAL.Instance.GetIdTkDal(taikhoan,matkhau);
        }
        public string GetIdNguoiByTaiKhoan(string idTaiKhoan)
        {
            return QLDAL.Instance.GetIdNguoiByTaiKhoanDal(idTaiKhoan);
        }
        public List<PhongTro> GetAllPhongTro()
        {
            return QLDAL.Instance.GetAllPhongTro();
        }
        public List<ViewCbb> GetCbbDayTro()
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb{key = "-1",value = "All"});
            foreach (DayTro dt in QLDAL.Instance.GetAllDayTro())
            {
                list.Add(new ViewCbb { key = dt.MaDayTro, value = dt.TenDayTro });
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
                if (dt.MaDayTro == id) return dt;
            }
            return null;
        }
        public string TaoIdNguoi()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (Nguoi ng in QLDAL.Instance.GetAllNguoi())
                {
                    if (ng.MaNguoi == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdHoaDon()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (HoaDon hd in QLDAL.Instance.GetAllHoaDon())
                {
                    if (hd.MaHoaDon == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdChiTietSuDungDichVu()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietSuDungDichVu dv in QLDAL.Instance.GetAllChiTietSuDungDichVu())
                {
                    if (dv.MaChiTietSuDungDichVu == id) status = true;
                }
            }
            return id;
        }
        public List<ChiTietSuDungDichVu> GetAllChiTietSuDungDichVuBll()
        {
            return QLDAL.Instance.GetAllChiTietSuDungDichVu();

        }
        public string TaoIdChiTietDichVu()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietDichVu ctdv in QLDAL.Instance.GetAllChiTietDichVu())
                {
                    if (ctdv.MaChiTietDichVu == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdChiTietThietBi()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietThietBi cttb in QLDAL.Instance.GetAllChiTietThietBi())
                {
                    if (cttb.MaChiTietThietBi == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdThanhVienTrongPhong()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ThanhVienTrongPhong tvtp in QLDAL.Instance.GetAllThanhVienTrongPhong())
                {
                    if (tvtp.MaThanhVienTrongPhong == id) status = true;
                }
            }
            return id;
        }
        public string GetIdPhongByIdNguoi(string idNguoi)
        {
            return QLDAL.Instance.GetIdPhongByIdNguoiDal(idNguoi);
        }
        public List<String> GetIdPhongByIdTB(string idTB)
        {
            return QLDAL.Instance.GetIdPhongByIdTbDal(idTB);
        }
        public string TaoIdPhongTro()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (PhongTro phongTro in QLDAL.Instance.GetAllPhongTro())
                {
                    if (phongTro.MaPhongTro == id) status = true;
                }
            }
            return id;
        }
        public string GetIdCHiTietDichVuDienByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetIdChiTietDichVuDienByIdPhongDal(idPhong);
        }
        public string GetIdCHiTietDichVuNuocByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetIdChiTietDichVuNuocByIdPhongDal(idPhong);
        }
        public ChiTietSuDungDichVu GetChiTietSudungDichVuById(string id)
        {  
            return QLDAL.Instance.GetChiTietSuDungDichVuById(id);
        }
        public string TaoIdDayTro()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (DayTro dayTro in QLDAL.Instance.GetAllDayTro())
                {
                    if (dayTro.MaDayTro == id) status = true;
                }
            }
            return id;
        }
        public string TaoIdHopDong()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (HopDong hopDong in QLDAL.Instance.GetAllHopDong())
                {
                    if (hopDong.MaHopDong == id) status = true; break;
                }
            }
            return id;
        }
        public string TaoIdDichVu()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (DichVu dv in QLDAL.Instance.GetAllDichVu())
                {
                    if (dv.MaDichVu == id) status = true;
                }
            }
            return id;
        }

        public string TaoIdThietBi()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ThietBi dv in QLDAL.Instance.GetAllThietBi())
                {
                    if (dv.MaThietBi == id) status = true; break;
                }
            }
            return id;
        }
        public void AddDayTroBll(DayTro dt)
        {
            QLDAL.Instance.AddDayTroDal(dt);
        }
        public void AddHoaDonBll(HoaDon hd)
        {
            QLDAL.Instance.AddHoaDonDal(hd);
        }
        public List<HoaDon> GetAllHoaDonBll()
        {
            return QLDAL.Instance.GetAllHoaDon();
        }
        public void AddPhongTroBll(PhongTro phongTro)
        {
            QLDAL.Instance.AddPhongTroDal(phongTro);
        }
        public List<string> DgvPhongTro(string txtTim)
        {
            List<string> list = new List<string>();
            foreach (PhongTro pt in QLDAL.Instance.GetAllPhongTro())
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
            QLDAL.Instance.AddChiTietSuDungDichVuDal(dv);
        }
        public List<string> GetAllPhongTroByIdDay(string idDay)
        {
            if(idDay != "-1")
            {
                return QLDAL.Instance.GetAllIdPhongTroByIdDayDal(idDay);
            }
            else
            {
                return QLDAL.Instance.GetAllIdPhongTroDal();
            }
        }
        public List<string> GetAllPhongTroByIdTinhTrang(string idTinhTrang)
        {
            List<string> list = new List<string>();
            if (idTinhTrang != "-1")
            {
                foreach (PhongTro pt in QLDAL.Instance.GetAllPhongTro())
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
                list = QLDAL.Instance.GetAllIdPhongTroDal();
            }
            return list;
        }
        public HoaDon GetHoaDonById(string id)
        {
            return QLDAL.Instance.GetHoaDonByIdDal(id);
        }
        public void UpdateHopDongBLL(HopDong hd)
        {
            QLDAL.Instance.UpdateHopDongDAL(hd);
        }
        public void UpdateHoaDonBLL(HoaDon hd)
        {
            QLDAL.Instance.UpdateHoaDonDal(hd);
        }
        public void UpdateNguoiBLL(Nguoi nguoi)
        {
            QLDAL.Instance.UpdateNguoiDAL(nguoi);
        }
        public void DelThietBiBll(string id)
        {
            QLDAL.Instance.DelThietBiDal(id);
        }
       
        public void UpdateChiTietSuDungDichVu(ChiTietSuDungDichVu dv)
        {
            QLDAL.Instance.UpdateChiTietSuDungDichVuDAL(dv);
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdBLL(string id)
        {
            return QLDAL.Instance.GetChiTietSuDungDichVuByIdDAL(id);
        }
        public void UpdateChitietdichvu(ChiTietDichVu ct)
        {
            QLDAL.Instance.UpdateChitietdichvu(ct);
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetPhongTroByIdPhong(idPhong);
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
                list.Add(GetPhongTroByIdPhong(id));
            }
            return list;
        }
        public List<DichVu> DgvDichVu(string txtTim)
        {
            List<DichVu> list = new List<DichVu>();
            foreach (DichVu dv in QLDAL.Instance.GetAllDichVu())
            {
                if (txtTim == null)
                {
                    DichVu s = new DichVu();
                    s.TenDichVu = dv.TenDichVu;
                    s.MaDichVu = dv.MaDichVu;
                    s.GiaDichVu = dv.GiaDichVu;
                    list.Add(s);
                }
                else
                {
                    if (dv.TenDichVu.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        DichVu s = new DichVu();
                        s.TenDichVu = dv.TenDichVu;
                        s.MaDichVu = dv.MaDichVu;
                        s.GiaDichVu = dv.GiaDichVu;
                        list.Add(s);
                    }
                }
            }
            return list;
        }
        public List<DichVu> GetAllDichVuByIdPhong(string idPhong)
        {
            return QLDAL.Instance.getAllDichVuByIdPhong(idPhong);
        }

        public List<ThietBi> DgvThietBi(string txtTim)
        {
            List<ThietBi> list = new List<ThietBi>();
            foreach (ThietBi dv in QLDAL.Instance.GetAllThietBi())
            {
                if (txtTim == null)
                {
                    ThietBi s = new ThietBi();
                    s.TenThietBi = dv.TenThietBi;
                    s.MaThietBi = dv.MaThietBi;
                    s.GiaThietBi = dv.GiaThietBi;
                    list.Add(s);
                }
                else
                {
                    if (dv.TenThietBi.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        ThietBi s = new ThietBi();
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
            QLDAL.Instance.AddHopDongDal(hd);
        }
        public void AddChiTietDichVuBll(ChiTietDichVu ctdv)
        {
            QLDAL.Instance.AddChiTietDichVuDal(ctdv);
        }
        public void AddChiTietThietBiBll(ChiTietThietBi cttb)
        {
            QLDAL.Instance.AddChiTietThietBiDal(cttb);
        }
        public void AddNguoiBll(Nguoi n)
        {
            QLDAL.Instance.AddNguoiDal(n);
        }
        public DichVu GetDichVuByIdDichVu(string id)
        {
            return QLDAL.Instance.GetDichVuByIdDichVuDal(id);
        }

        public void ThemDVBll(DichVu dv)
        {
            QLDAL.Instance.ThemDVDal(dv);
        }
        public void ThemTBBll(ThietBi tb)
        {
            QLDAL.Instance.ThemTBDal(tb);
        }
        public void SuaDVBll(DichVu dv)
        {
            QLDAL.Instance.SuaDVDal(dv);
        }
        public void SuaTBBll(ThietBi tb)
        {
            QLDAL.Instance.SuaTBDal(tb);
        }
        public List<string> GetIdNguoiByIdPhong(string id)
        {
            return QLDAL.Instance.GetIdNguoiByIdPhongDal(id);
        }
        public List<Nguoi> GetNguoiByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetNguoiByIdPhongDal(idPhong);
        }
        public List<PhongTro> GetPhongTroByIdDay(string idDay)
        {
            return QLDAL.Instance.GetPhongTroByIdDayDal(idDay);
        }
        public HopDong GetHopDongByMaHD(string MaHD)
        {
            return QLDAL.Instance.GetHopDongByMaHD(MaHD);
        }
        public void AddThanhVienTrongPhongBll(ThanhVienTrongPhong tvtp)
        {
            QLDAL.Instance.AddThanhVienTrongPhong(tvtp);
        }
        public void UpdatePTBLL(PhongTro PT)
        {
            QLDAL.Instance.UpdatePTDAL(PT);
        }

        public string GetIdDayByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetIdDayByIdPhong(IdPhong);
        }
        public string GetIdThietBiByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetIdDayByIdPhong(IdPhong);
        }
        public DayTro GetDayTroByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetDayTroByIdPhongDal(idPhong);
        }

        public List<string> GetAllIdDichVuByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetAllIdDichVuByIdPhongDal(idPhong);
        }

        public List<string> GetAllIdThietBiByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetAllIdThietBiByIdPhongDal(idPhong);
        }
        public Nguoi GetNguoiByIdNguoi(string IdNguoi)
        {
            return QLDAL.Instance.GetNguoiByIdNguoiDal(IdNguoi);
        }
        public DayTro GetDayByIdDay(string id)
        {
            return QLDAL.Instance.GetDayByIdDay(id);
        }
        public ThietBi GetTBByIdTB(string idTb)
        {
            return QLDAL.Instance.GetThietBiByIdThietBiDal(idTb);
        }
        public DichVu GetDVByIdDV(string IdDV)
        {
            return QLDAL.Instance.GetDichVuByIdDichVuDal(IdDV);
        }
        public void SuaDayBll(DayTro day)
        {
            QLDAL.Instance.SuaDayDal(day);
        }
        public List<DgvHopDong> DgvHopDong()
        {
            List<DgvHopDong> list = new List<DgvHopDong>();
            int i = 1;
            foreach (HopDong hopDong in QLDAL.Instance.GetAllHopDongDangThue())
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
        public List<string> GetAllIdHopDongByIdDay(string idDay)
        {
            if(idDay != "-1")
            {
                return QLDAL.Instance.GetAllIdHopDongDangThueByIdDay(idDay);
            }
            else
            {
                return QLDAL.Instance.GetAllIdHopDongDangThue();
            }

        }
        public List<string> GetAllIdHopDongByIdPhong(string idPhong)
        {
            if(idPhong != "-1")
            {
                return QLDAL.Instance.GetAllIdHopDongDangThueByIdPhong(idPhong);
            }
            else
            {
                return QLDAL.Instance.GetAllIdHopDongDangThue();
            }
        }
        public List<DgvHopDong> GetAllHopDongTimKiem(string idDay, string idPhong)
        {
            List<string> ListDay = GetAllIdHopDongByIdDay(idDay);
            List<string> ListPhong = GetAllIdHopDongByIdPhong(idPhong);
            List<string> myList = new List<string>();
            myList = ListDay.Intersect(ListPhong).ToList();
            List<DgvHopDong> list = new List<DgvHopDong>();
            int i = 0;
            foreach(string id in myList)
            {
                HopDong hopDong = GetHopDongByMaHD(id);
                DgvHopDong hd = new DgvHopDong();
                hd.MaHopDong = hopDong.MaHopDong;
                hd.Stt = ++i;
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
            return QLDAL.Instance.GetChiTietDichVuByIdDal(id);

        }
        public List<ChiTietDichVu> GetChiTietDichVuByIdPhong(string idPhong)
        {
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            foreach (ChiTietDichVu ctdv in QLDAL.Instance.GetAllChiTietDichVu())
            {
                if (ctdv.MaPhongTro == idPhong) list.Add(ctdv);
            }
            return list;
           
        }
        public HopDong GetHopDongByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetHopDongByIdPhong(IdPhong);
        }
        public List<ChiTietThietBi> GetChiTietThietBiByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetChiTietThietBiByIdPhongDal(IdPhong);
        }
        public List<string> GetAllIdCHiTietThietBiByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetAllIdChiTietThietBiByIdPhong(idPhong);
        }
        public List<string> GetAllIdChitietDichVuByIdPhong(string idphong)
        {
            return QLDAL.Instance.GetAllIdChiTietDichVuByIdPhong(idphong);
        }
        public ChiTietThietBi GetChiTietThietBiById(string IdChiTiet)
        {
            return QLDAL.Instance.GetChiTietThietBiByIdDal(IdChiTiet);
        }
        public void DelCHiTietThietBiByIdPhongBLL(string IdPhong)
        {
            foreach (string id in GetAllIdCHiTietThietBiByIdPhong(IdPhong))
            {
                QLDAL.Instance.DelCHiTietThietBiById(id);
            }
        }
       
        public void DelCHiTietDichVuByIdPhong(string IdPhong)
        {
            foreach (string id in GetAllIdChitietDichVuByIdPhong(IdPhong))
            {
                QLDAL.Instance.DelChiTietDichVuDal(id);
            }
        }
        
       
        public string GetMaChiTietDichVuByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetMaChiTietDichVuByIdPhong(idPhong);
        }
        public List<string> GetAllChiTietThietBiByIdThietBi(string idThietBi)
        {
            return QLDAL.Instance.GetAllIdChiTietThietBiByIdThietBi(idThietBi);
        }
        public void DelChiTietThietBiByIdThietBi(string idThietBi)
        {
            foreach (string id in GetAllChiTietThietBiByIdThietBi(idThietBi))
            {
                QLDAL.Instance.DelCHiTietThietBiById(id);
            }
        }

        public void DelChiTietDichVu(string id)
        {
            QLDAL.Instance.DelChiTietDichVuDal(id);
        }
        public void DelChiTietSuDungDichVu(string id)
        {
            QLDAL.Instance.DelChiTietSuDungDichVuDal(id);
        }
        public void DelDichVu(string id)
        {
            QLDAL.Instance.DelDichVuDal(id);
        }
        public List<string> GetAllChiTietDichVuByIdDichVu(string id)
        {
            return QLDAL.Instance.GetAllIdChiTietDichVuByIdDichVu(id);
        }
        public List<string> GetAllChiTietSuDungDichVubyIdChiTiet (string id)
        {  
            return QLDAL.Instance.GetChiTietSuDungDichVuByIdChitiet(id);
        }
        public List<DayTro> GetAllDayTroBll()
        {
            return QLDAL.Instance.GetAllDayTro();
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
            foreach (string Id in GetAllChiTietSuDungDichVubyIdChiTiet(id));
            {
                DelChiTietSuDungDichVubyId(id);
            }
        }
        public void DelNguoiBll(string id)
        {
            QLDAL.Instance.DelNguoiDal(id);
        }
        public void DelThanhVienBLL(string id)
        {
            QLDAL.Instance.DelThanhVienDAL(id);
        }
        public void DelPhongTroBLL(string idphong)
        {
            QLDAL.Instance.DelPhongTroDAL(idphong);
        }
        public void DelHoaDonBll(string id)
        {
            QLDAL.Instance.DelHoaDonDal(id);
        }
        public void DelHopDong(string idhopdong)
        {
            QLDAL.Instance.DelHopDong(idhopdong);
        }
        public void DelDayTroBll(string MaDay)
        {
            QLDAL.Instance.DelDayTroDal(MaDay);
        }
        public bool CheckDay(string idDay)
        {
            return QLDAL.Instance.CheckDay(idDay);
        }
        public string GetIdThanhVienByIdNguoi(string id)
        {
            return QLDAL.Instance.GetIdThanhVienByIdNguoi(id);
        }
        public List<string> GetIDThanhvienbyIDPhong(string idphong)
        {
            return QLDAL.Instance.GetIDThanhvienbyIDPhong(idphong);
        }
        public List<string>GetChiTietSuDungDichVuByThangSuDung(string ThangSd)
        {
            return QLDAL.Instance.GetChiTietSuDungDichVuByThangSuDungDal(ThangSd);
        }
        public List<string> GetChiTietSuDungDichVuByIdDay(string IdDay)
        {
            if(IdDay != "-1")
            {
                return QLDAL.Instance.GetChiTietSuDungDichVuByIdDayDal(IdDay);
            }
            else
            {
                return QLDAL.Instance.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public List<string> GetChiTietSuDungDichVuByIdPhong(string IdPhong)
        {
            if(IdPhong != "-1")
            {
                return QLDAL.Instance.GetChiTietSuDungDichVuByIdPhongDal(IdPhong);
            }
            else
            {
                return QLDAL.Instance.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public void DelMaCTTBByIdPhongvaMaTB(string MaPhong,string MaTB)
        {
            QLDAL.Instance.DelMaCTTBByIdPhongvaMaTB(MaPhong, MaTB);
        }
        public void DelMaCTDVByIdPhongvaMaTB(string MaPhong,string MaTB)
        {
            QLDAL.Instance.DelMaCTDVByIdPhongvaMaTB(MaPhong, MaTB);
        }
        public List<string> GetChiTietSuDungDichVuByTinhTrang(string IdTinhTrang)
        {
            if(IdTinhTrang != "-1")
            {
                bool tinhTrang = (IdTinhTrang == "1");
                return QLDAL.Instance.GetChiTietSuDungDichVuByTinhTrang(tinhTrang);
            }
            else
            {
                return QLDAL.Instance.GetAllIdChiTietSuDungDichVuDal();
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
           
                foreach (string id in Id)
                {
                   kq.Add(QLBLL.Instance.GetChiTietSudungDichVuById(id));
                }
            
            return kq;
        }
        public bool TinhTrangThanhToan (string IdPhong, string Thangct)
        {
            List<string> Phong = QLDAL.Instance.GetHoaDonByIdPhong(IdPhong);
            List<string> Thang = QLDAL.Instance.GetIdHoaDonByThangChiTra(Thangct);
            List<string> list = new List<string>();
            list = Phong.Intersect(Thang).ToList();
            foreach (string idHoaDon in list)
            {
                HoaDon hd = GetHoaDonById(idHoaDon);
                if (hd.TinhTrang == true) return false;
            }  
            return true;

        }
        public string GetIdPhongByIdChiTietSuDungDichVu(string idct)
        {
            return QLDAL.Instance.GetIdPhongByIdChiTietSuDungDichVu(idct);
        }
        public string GetIdPhongByIdHoaDon(string idHoaDon)
        {
            return QLDAL.Instance.GetIdPhongByIdHoaDon(idHoaDon);
        }
          
        public string GetIdPhongbyIdChitietsudungDichVu(string idChitiet)
        {
            return QLDAL.Instance.GetIdPhongbyIdChitietsudungDichVu(idChitiet);
        }
        public bool TinhTrangPhongById(string IdPhong)
        {
            if (GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == false) return false;
            return true;
        }
        public bool PhongDaCocByIdPhong(string IdPhong)
        {
            if (GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == true) return false;
            return true;
        }
        public List<string> GetHoaDonByThangChiTra(string ThangCt)
        {
            return QLDAL.Instance.GetIdHoaDonByThangChiTra(ThangCt);
        }
        public List<TinhTrangPhongTro> GetAllTinhTrangPhongTro ()
        {
            List<TinhTrangPhongTro> list = new List<TinhTrangPhongTro>();
            // Lấy ds các phòng 
            List<PhongTro> phongTroList = QLDAL.Instance.GetAllPhongTro();
            foreach (PhongTro phongTro in phongTroList)
            {
                TinhTrangPhongTro tinhTrangPhongTro = new TinhTrangPhongTro();
                tinhTrangPhongTro.MaPhongTro = phongTro.MaPhongTro;
                tinhTrangPhongTro.TinhTrangPhong = phongTro.TinhTrang;

                // lấy thông tin HD dựa trên id phòng
                HopDong hopDong = QLDAL.Instance.GetHopDongByIdPhong(phongTro.MaDayTro);
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
            if(IdDay != "-1")
            {
                return QLDAL.Instance.GetHoaDonByIdDay(IdDay);
            }
            else
            {
                return QLDAL.Instance.GetAllIdHoaDon();
            }
        }
        public List<string> GetHoaDonByIdPhong(string IdPhong)
        {
            if(IdPhong != "-1")
            {
                return QLDAL.Instance.GetHoaDonByIdPhong(IdPhong);
            }
            else
            {
                return QLDAL.Instance.GetAllIdHoaDon();
            }
        }
        public List<string> GetHoaDonByTinhTrang(string IdTinhTrang)
        {
            if(IdTinhTrang != "-1")
            {
                bool tinhTrang = (IdTinhTrang == "1");
                return QLDAL.Instance.GetHoaDonByTinhTrang(tinhTrang);
            }
            else
            {
                return QLDAL.Instance.GetAllIdHoaDon();
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
            return QLDAL.Instance.GetPhongTroByIdHoaDon(idHD);
        }
        public PhongTro GetPhongTroByMaHopDong(string MaHopDong)
        {
            return QLDAL.Instance.GetPhongTroByMaHopDong(MaHopDong);
        }
       

        public Nguoi GetNguoiByMaHopDong(string MaHd)
        {
            return QLDAL.Instance.GetNguoiByIdHopDong(MaHd);
        }
       public List<object> ThongKe(string thang)
        {
            return QLDAL.Instance.ThongKe(thang);
        }
        public bool ChoPhepXacThucChiSo(string id, string MaChiSo)
        {
            ChiTietSuDungDichVu dv = GetChiTietSuDungDichVuByIdBLL(id);
            ChiTietDichVu ctdv = GetChiTietDichVuById(dv.MaCHiTietDichVu);
            List<ChiTietSuDungDichVu> list = GetChiTietSuDungDichVuTimKiem(dv.ThoiGian, "-1", ctdv.MaPhongTro, "1");     
            if(list.Count == 0)
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
        public void openChildForm1(Form childForm, System.Windows.Forms.Panel p)
        {
            DemoForm.Instance.SetActiveForm(childForm);
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            p.Controls.Add(childForm);
            p.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btSua, Image btXoa)
        {
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnSua" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnSua = btSua;
                var w = btnSua.Width;
                var h = btnSua.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnSua, new Rectangle(x, y, w, h));
                e.Handled = true;

              //   Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnXoa" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnXoa = btXoa;
                var w = btnXoa.Width;
                var h = btnXoa.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnXoa, new Rectangle(x, y, w, h));
                e.Handled = true;

               //  Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
        }
        public List<ViewCbb>GetViewCbbPhongByDay(string id)
        {
            List<ViewCbb>list = new List<ViewCbb> ();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            if (id == "-1")
            { 
                foreach(PhongTro pt in GetAllPhongTro())
                {
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            else
            {
                foreach (string idp in GetAllPhongTroByIdDay(id))
                { 
                    PhongTro pt = GetPhongTroByIdPhong(idp);
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            return list;
        }
        public List<ViewCbb>GetViewCbbPhongDaThueByDay(string id)
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            if (id == "-1")
            {
                foreach (PhongTro pt in GetAllPhongTro())
                {
                    if(TinhTrangPhongById(pt.MaPhongTro))
                    {
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            else
            {
                foreach (string idp in GetAllPhongTroByIdDay(id))
                {
                    if(TinhTrangPhongById(idp))
                    {
                    PhongTro pt = GetPhongTroByIdPhong(idp);
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            return list;
        }
        public List<ViewCbb> GetViewCbbPhongByDayForThemHoaDon(string id)
        {
            List<ViewCbb> list = new List<ViewCbb>();
            if (id == "-1")
            {
                foreach (PhongTro pt in GetAllPhongTro())
                {
                    if(TinhTrangPhongById(pt.MaPhongTro))
                    {
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            else
            {
                foreach (string idp in GetAllPhongTroByIdDay(id))
                {
                    if (TinhTrangPhongById(idp))
                    {
                        PhongTro pt = GetPhongTroByIdPhong(idp);
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            return list;
        }
        public void SetFontAndColors(DataGridView dgv)
        {
            dgv.DefaultCellStyle.Font = new Font("Tahoma", 10);
            dgv.DefaultCellStyle.ForeColor = Color.Blue;
            dgv.DefaultCellStyle.BackColor = Color.Beige;
            dgv.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            dgv.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = dgv.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
    }
}

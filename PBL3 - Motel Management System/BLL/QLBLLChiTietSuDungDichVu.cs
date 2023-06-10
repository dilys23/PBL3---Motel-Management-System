using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietSuDungDichVu
    {
        private static QLBLLChiTietSuDungDichVu _instance;
        public static QLBLLChiTietSuDungDichVu Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietSuDungDichVu();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietSuDungDichVu()
        {

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
                foreach (ChiTietSuDungDichVu dv in QLDAL.Instance.GetAllChiTietSuDungDichVuTaoId())
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
        public ChiTietSuDungDichVu GetChiTietSudungDichVuById(string id)
        {
            return QLDAL.Instance.GetChiTietSuDungDichVuById(id);
        }
        public void AddChiTietSuDungDichVuBLL(ChiTietSuDungDichVu dv)
        {
            QLDAL.Instance.AddChiTietSuDungDichVuDal(dv);
        }
        public void UpdateChiTietSuDungDichVu(ChiTietSuDungDichVu dv)
        {
            QLDAL.Instance.UpdateChiTietSuDungDichVuDAL(dv);
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdBLL(string id)
        {
            return QLDAL.Instance.GetChiTietSuDungDichVuByIdDAL(id);
        }
        public void DelChiTietSuDungDichVu(string id)
        {
            QLDAL.Instance.DelChiTietSuDungDichVuDal(id);
        }
        public List<string> GetAllChiTietSuDungDichVubyIdChiTiet(string id)
        {
            return QLDAL.Instance.GetChiTietSuDungDichVuByIdChitiet(id);
        }
        public void DelChiTietSuDungDichVubyId(string id)
        {
            foreach (string Id in GetAllChiTietSuDungDichVubyIdChiTiet(id)) ;
            {
                DelChiTietSuDungDichVubyId(id);
            }
        }
        public List<string> GetChiTietSuDungDichVuByThangSuDung(string ThangSd)
        {
            return QLDAL.Instance.GetChiTietSuDungDichVuByThangSuDungDal(ThangSd);
        }
        public List<string> GetChiTietSuDungDichVuByIdDay(string IdDay)
        {
            if (IdDay != "-1")
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
            if (IdPhong != "-1")
            {
                return QLDAL.Instance.GetChiTietSuDungDichVuByIdPhongDal(IdPhong);
            }
            else
            {
                return QLDAL.Instance.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public List<string> GetChiTietSuDungDichVuByTinhTrang(string IdTinhTrang)
        {
            if (IdTinhTrang != "-1")
            {
                bool tinhTrang = (IdTinhTrang == "1");
                return QLDAL.Instance.GetChiTietSuDungDichVuByTinhTrang(tinhTrang);
            }
            else
            {
                return QLDAL.Instance.GetAllIdChiTietSuDungDichVuDal();
            }
        }
        public void DelChiTietSuDungDichVuByIdPhong(string idp)
        {
            foreach(string id in GetChiTietSuDungDichVuByIdPhong(idp))
            {
                DelChiTietSuDungDichVu(id);
            }
        }
        public List<ViewChiSo> GetAllViewChiSo()
        {
            List<ViewChiSo> list = new List<ViewChiSo>();
            foreach (ChiTietSuDungDichVu dv in GetAllChiTietSuDungDichVuBll())
            {
                ChiTietDichVu ctdv = QLBLLChiTietDichVu.Instance.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                ViewChiSo view = new ViewChiSo
                {
                    MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                    MaChiTietDichVu = ctdv.MaChiTietDichVu,
                    Stt = 1,
                    TenDayTro = QLBLLDayTro.Instance.GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                    TenPhongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
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
        public List<ChiTietSuDungDichVu> GetChiTietSuDungDichVuTimKiem(string ThangSd, string IdDay, string IdPhong, string idTinhTrang)
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
        public List<ViewChiSo> GetViewChiSoByTimKiem(string ThangSuDung, string IdDay, string IdPhong, string IdTinhTrang)
        {
            List<ViewChiSo> list = new List<ViewChiSo>();
            foreach (ChiTietSuDungDichVu dv in GetChiTietSuDungDichVuTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang))
            {
                ChiTietDichVu ctdv = QLBLLChiTietDichVu.Instance.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                ViewChiSo view = new ViewChiSo
                {
                    MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                    MaChiTietDichVu = ctdv.MaChiTietDichVu,
                    Stt = 1,
                    TenDayTro = QLBLLDayTro.Instance.GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                    TenPhongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
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
        public List<ChiTietSuDungDichVu> GetChiTietSuDungDichVuTimKiem(string IdDay, string IdPhong, string idTinhTrang)
        {
            List<string> Day = GetChiTietSuDungDichVuByIdDay(IdDay);
            List<string> Phong = GetChiTietSuDungDichVuByIdPhong(IdPhong);
            List<string> TinhTrang = GetChiTietSuDungDichVuByTinhTrang(idTinhTrang);
            List<string> Id = new List<string>();
            List<ChiTietSuDungDichVu> kq = new List<ChiTietSuDungDichVu>();
            Id =Day.Intersect(Phong).Intersect(TinhTrang).ToList();
            foreach (ChiTietSuDungDichVu dv in GetAllChiTietSuDungDichVuBll())
            {
                foreach (string id in Id)
                {
                    if (id == dv.MaChiTietSuDungDichVu) kq.Add(dv);
                }
            }
            return kq;
        }
        public List<ViewChiSo> GetViewChiSoByPhong(string IdDay, string IdPhong, string IdTinhTrang)
        {
            List<ViewChiSo> list = new List<ViewChiSo>();
            foreach (ChiTietSuDungDichVu dv in GetChiTietSuDungDichVuTimKiem(IdDay, IdPhong, IdTinhTrang))
            {
                ChiTietDichVu ctdv = QLBLLChiTietDichVu.Instance.GetChiTietDichVuById(dv.MaCHiTietDichVu);
                ViewChiSo view = new ViewChiSo
                {
                    MaChiTietSuDungDichVu = dv.MaChiTietSuDungDichVu,
                    MaChiTietDichVu = ctdv.MaChiTietDichVu,
                    Stt = 1,
                    TenDayTro = QLBLLDayTro.Instance.GetDayTroByIdPhong(ctdv.MaPhongTro).TenDayTro,
                    TenPhongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(ctdv.MaPhongTro).TenPhongTro,
                    ChiSoCu = dv.ChiSoCu,
                    ChiSoMoi = dv.ChiSoMoi,
                    DaDung = dv.ChiSoMoi - dv.ChiSoCu,
                    NgayLap = dv.NgayLap,
                    ThangSuDung = dv.ThoiGian,
                    TinhTrang = dv.TinhTrang
                };
                list.Add(view);
            }
            return list;
        }
        public bool ChoPhepXacThucChiSo(string id, string MaChiSo)
        {
            ChiTietSuDungDichVu dv = GetChiTietSuDungDichVuByIdBLL(id);
            ChiTietDichVu ctdv = QLBLLChiTietDichVu.Instance.GetChiTietDichVuById(dv.MaCHiTietDichVu);
            List<ChiTietSuDungDichVu> list = GetChiTietSuDungDichVuTimKiem(dv.ThoiGian, "-1", ctdv.MaPhongTro, "1");
            List<ChiTietSuDungDichVu> mylist = new List<ChiTietSuDungDichVu>();
            foreach (ChiTietSuDungDichVu ct in list)
            {
                if (QLBLLChiTietDichVu.Instance.GetChiTietDichVuById(ct.MaCHiTietDichVu).MaDichVu == MaChiSo) mylist.Add(ct);
            }
            if (mylist.Count == 0)
            {
                return true;
            }
            return false;

        }
    }
}

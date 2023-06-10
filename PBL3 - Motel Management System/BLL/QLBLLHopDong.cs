using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLHopDong
    {
        private static QLBLLHopDong _instance;
        public static QLBLLHopDong Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLHopDong();
                return _instance;
            }
            private set { }
        }
        private QLBLLHopDong()
        {

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
                foreach (HopDong hopDong in QLDAL.Instance.GetAllHopDongTaoID())
                {
                    if (hopDong.MaHopDong == id) status = true; break;
                }
            }
            return id;
        }
        public HopDong GetHopDongByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetHopDongByIdPhong(IdPhong);
        }
        public void UpdateHopDongBLL(HopDong hd)
        {
            QLDAL.Instance.UpdateHopDongDAL(hd);
        }
        public void AddHdBll(HopDong hd)
        {
            QLDAL.Instance.AddHopDongDal(hd);
        }
        public HopDong GetHopDongByMaHD(string MaHD)
        {
            return QLDAL.Instance.GetHopDongByMaHD(MaHD);
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
                hd.TenKhachHang = QLBLLNguoi.Instance.GetNguoiByIdNguoi(hopDong.MaNguoi).Ten;
                hd.TenPhongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(hopDong.MaPhongTro).TenPhongTro;
                hd.TenDayTro = QLBLLDayTro.Instance.GetDayTroByIdPhong(hopDong.MaPhongTro).TenDayTro;
                hd.NgayBatDau = hopDong.NgayBatDau;
                hd.NgayKetThuc = hopDong.NgayKetThuc;
                hd.TienCoc = hopDong.TienCoc;
                list.Add(hd);
            }
            return list;
        }
        public List<string> GetAllIdHopDongByIdDay(string idDay)
        {
            if (idDay != "-1")
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
            if (idPhong != "-1")
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
            foreach (string id in myList)
            {
                HopDong hopDong = GetHopDongByMaHD(id);
                DgvHopDong hd = new DgvHopDong();
                hd.MaHopDong = hopDong.MaHopDong;
                hd.Stt = ++i;
                hd.TenKhachHang = QLBLLNguoi.Instance.GetNguoiByIdNguoi(hopDong.MaNguoi).Ten;
                hd.TenPhongTro = QLBLLPhongTro.Instance.GetPhongTroByIdPhong(hopDong.MaPhongTro).TenPhongTro;
                hd.TenDayTro = QLBLLDayTro.Instance.GetDayTroByIdPhong(hopDong.MaPhongTro).TenDayTro;
                hd.NgayBatDau = hopDong.NgayBatDau;
                hd.NgayKetThuc = hopDong.NgayKetThuc;
                hd.TienCoc = hopDong.TienCoc;
                list.Add(hd);
            }
            return list;
        }
        public void DelHopDong(string idhopdong)
        {
            QLDAL.Instance.DelHopDong(idhopdong);
        }
        public bool KiemTraTonTaiHopDongByIdNguoi(string idNguoi)
        {
            return QLDAL.Instance.KiemTraTonTaiHopDongByIdNguoi(idNguoi);
        }
      
    }
}

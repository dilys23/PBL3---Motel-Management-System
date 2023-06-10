using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLHoadon
    {
        private static QLBLLHoadon _instance;
        public static QLBLLHoadon Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLHoadon();
                return _instance;
            }
            private set { }
        }
        private QLBLLHoadon()
        {

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
                foreach (HoaDon hd in QLDAL.Instance.GetAllHoaDonTaoID())
                {
                    if (hd.MaHoaDon == id) status = true;
                }
            }
            return id;
        }
        public void AddHoaDonBll(HoaDon hd)
        {
            QLDAL.Instance.AddHoaDonDal(hd);
        }
        public List<HoaDon> GetAllHoaDonBll()
        {
            return QLDAL.Instance.GetAllHoaDon();
        }
       
        public HoaDon GetHoaDonById(string id)
        {
            return QLDAL.Instance.GetHoaDonByIdDal(id);
        }
        public void UpdateHoaDonBLL(HoaDon hd)
        {
            QLDAL.Instance.UpdateHoaDonDal(hd);
        }
        public void DelHoaDonBll(string id)
        {
            QLDAL.Instance.DelHoaDonDal(id);
        }
        public bool TinhTrangThanhToan(string IdPhong, string Thangct)
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
        public List<string> GetHoaDonByThangChiTraBLL(string ThangCt)
        {
            return QLDAL.Instance.GetIdHoaDonByThangChiTraDAL(ThangCt);
        }
        public List<HoaDon> GetAllHoaDon()
        {
            return QLDAL.Instance.GetAllHoaDonDAL();
        }
        public List<string> GetHoaDonByThangChiTra(string ThangCt)
        {
            return QLDAL.Instance.GetIdHoaDonByThangChiTra(ThangCt);
        }
        public List<string> GetHoaDonByIdDay(string IdDay)
        {
            if (IdDay != "-1")
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
            if (IdPhong != "-1")
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
            if (IdTinhTrang != "-1")
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
        public bool ChoPhepXacThucHoaDon(string id)
        {
            HoaDon hd = GetHoaDonById(id);
            List<HoaDon> list = GetHoaDonTimKiem(hd.ThangChiTra, "-1", hd.MaPhongTro, "1");
            if (list.Count == 0)
            {
                return true;
            }
            return false;
        }
    }
}

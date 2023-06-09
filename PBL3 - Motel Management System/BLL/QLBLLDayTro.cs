using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLDayTro
    {
        private static QLBLLDayTro _instance;
        public static QLBLLDayTro Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLDayTro();
                return _instance;
            }
            private set { }
        }
        private QLBLLDayTro()
        {

        }
        public List<DayTro> GetAllDayTroBll()
        {
            return QLDAL.Instance.GetAllDayTro();
        }
        public DayTro GetDayTroById(string id)
        {
            foreach (DayTro dt in GetAllDayTroBll())
            {
                if (dt.MaDayTro == id) return dt;
            }
            return null;
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
        public void AddDayTroBll(DayTro dt)
        {
            QLDAL.Instance.AddDayTroDal(dt);
        }
        public string GetIdDayByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetIdDayByIdPhong(IdPhong);
        }
        public DayTro GetDayTroByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetDayTroByIdPhongDal(idPhong);
        }
        public DayTro GetDayByIdDay(string id)
        {
            return QLDAL.Instance.GetDayByIdDay(id);
        }
        public void SuaDayBll(DayTro day)
        {
            QLDAL.Instance.SuaDayDal(day);
        }
        public void DelDayTroBll(string MaDay)
        {
            QLDAL.Instance.DelDayTroDal(MaDay);
        }
        public bool CheckDay(string idday)
        {
            int check = 0;
            foreach (PhongTro pt in QLBLLPhongTro.Instance.GetPhongTroByIdDay(idday))
            {
                if (QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro) != null && pt.TonTai ==true) check++; 
            }
            if (check == 0) return false;
            else return true;
        }
        public string GetDiaChiByIdDay(string id)
        {
            DayTro dt = GetDayByIdDay(id);
            string DiaChi = "    " + dt.TenDuong + " " + dt.TenHuyen + " " + dt.TenThanhPho;
            return DiaChi;
        }
    }
}

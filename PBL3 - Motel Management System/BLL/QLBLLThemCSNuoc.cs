using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLThemCSNuoc
    {
        private static QLBLLThemCSNuoc _instance;
        public static QLBLLThemCSNuoc Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLThemCSNuoc();
                return _instance;
            }
            private set { }
        }
        private QLBLLThemCSNuoc()
        {

        }
        public ChiTietSuDungDichVu GetChiTietSudungDichVuById(string id)
        {
            return QLBLL.Instance.GetChiTietSudungDichVuById(id);
        }
        public ChiTietDichVu GetChiTietDichVuById(string id)
        {
            return QLBLL.Instance.GetChiTietDichVuById(id);
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            return QLBLL.Instance.GetPhongTroByIdPhong(idPhong);
        }
        public DayTro GetDayByIdDay(string id)
        {
            return QLBLL.Instance.GetDayByIdDay(id);
        }
        public List<ViewCbb> GetCbbDayTro()
        {
            return QLBLL.Instance.GetCbbDayTro();
        }
        public List<ViewCbb> GetViewCbbPhongByDayForThemHoaDon(string id)
        {
            return QLBLL.Instance.GetViewCbbPhongByDayForThemHoaDon(id);
        }
        public void UpdateChiTietSuDungDichVu(ChiTietSuDungDichVu dv)
        {
            QLBLL.Instance.UpdateChiTietSuDungDichVu(dv);
        }
        public string TaoIdChiTietSuDungDichVu()
        {
            return QLBLL.Instance.TaoIdChiTietSuDungDichVu();
        }
        public string GetIdCHiTietDichVuNuocByIdPhong(string idPhong)
        {
            return QLBLL.Instance.GetIdCHiTietDichVuNuocByIdPhong(idPhong);
        }
        public void AddChiTietSuDungDichVuBLL(ChiTietSuDungDichVu dv)
        {
            QLBLL.Instance.AddChiTietSuDungDichVuBLL(dv);
        }
        public HopDong GetHopDongByIdPhong(string IdPhong)
        {
            return QLBLL.Instance.GetHopDongByIdPhong(IdPhong);
        }
    }
}

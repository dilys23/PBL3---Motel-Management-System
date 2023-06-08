using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLThanhToan
    {
        private static QLBLLThanhToan _instance;
        public static QLBLLThanhToan Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLThanhToan();
                return _instance;
            }
            private set { }
        }
        private QLBLLThanhToan()
        {

        }
        public HoaDon GetHoaDonById(string id)
        {
            return QLBLL.Instance.GetHoaDonById(id);
        }
        public PhongTro GetPhongTroByMaHoaDon(string idHD)
        {
            return QLBLL.Instance.GetPhongTroByMaHoaDon(idHD);
        }
        public string TaoIdChiTietThanhToanHoaDon()
        {
            return QLBLL.Instance.TaoIdChiTietThanhToanHoaDon();
        }
        public void UpdateHoaDonBLL(HoaDon hd)
        {
            QLBLL.Instance.UpdateHoaDonBLL(hd);
        }
        public void AddChiTietThanhToanHoaDonBll(ChiTietThanhToanHoaDon ct)
        {
            QLBLL.Instance.AddChiTietThanhToanHoaDonBll(ct);
        }
    }
}

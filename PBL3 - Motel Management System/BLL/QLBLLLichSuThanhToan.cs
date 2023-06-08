using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLLichSuThanhToan
    {
        private static QLBLLLichSuThanhToan _instance;
        public static QLBLLLichSuThanhToan Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLLichSuThanhToan();
                return _instance;
            }
            private set { }
        }
        private QLBLLLichSuThanhToan()
        {

        }
        public void customDGV(DataGridView dgv)
        {
            QLBLL.Instance.customDGV(dgv);
        }
        public HoaDon GetHoaDonById(string id)
        {
            return QLBLL.Instance.GetHoaDonById(id);
        }
        public PhongTro GetPhongTroByMaHoaDon(string idHD)
        {
            return QLBLL.Instance.GetPhongTroByMaHoaDon(idHD);
        }
        public List<string> GetAllIdLichSuThanhToanByIdHoaDon(string idHd)
        {
            return QLBLL.Instance.GetAllIdLichSuThanhToanByIdHoaDon(idHd);
        }
        public ChiTietThanhToanHoaDon GetChiTietThanhToanHoaDonById(string id)
        {
            return QLBLL.Instance.GetChiTietThanhToanHoaDonById(id);
        }
    }
}

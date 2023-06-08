using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietThanhToanHoaDon
    {
        private static QLBLLChiTietThanhToanHoaDon _instance;
        public static QLBLLChiTietThanhToanHoaDon Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietThanhToanHoaDon();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietThanhToanHoaDon()
        {

        }
        public string TaoIdChiTietThanhToanHoaDon()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietThanhToanHoaDon ct in QLDAL.Instance.GetAllChiTietThanhToanHoaDon())
                {
                    if (ct.MaChiTietThanhToanHoaDon == id) status = true;
                }
            }
            return id;
        }
        public void AddChiTietThanhToanHoaDonBll(ChiTietThanhToanHoaDon ct)
        {
            QLDAL.Instance.AddChiTietThanhToanHoaDonDal(ct);
        }
        public List<string> GetAllIdLichSuThanhToanByIdHoaDon(string idHd)
        {
            return QLDAL.Instance.GetAllIdLichSuThanhToanByIdHoaDon(idHd);
        }
        public ChiTietThanhToanHoaDon GetChiTietThanhToanHoaDonById(string id)
        {
            return QLDAL.Instance.GetChiTietThanhToanHoaDonByIdDal(id);
        }
    }
}

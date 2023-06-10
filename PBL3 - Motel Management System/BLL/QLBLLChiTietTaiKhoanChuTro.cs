using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietTaiKhoanChuTro
    {
        private static QLBLLChiTietTaiKhoanChuTro _instance;
        public static QLBLLChiTietTaiKhoanChuTro Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietTaiKhoanChuTro();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietTaiKhoanChuTro()
        {

        }
        public List<ChiTietTaiKhoanChuTro> GetAllTaiKhoanChuTro()
        {
            return QLDAL.Instance.GetAllTaiKhoanChuTro();
        }
        public string TaoIdChiTietTaiKhoanChuTro()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietTaiKhoanChuTro vt in QLDAL.Instance.GetAllTaiKhoanChuTroTaoId())
                {
                    if (vt.MaChiTietTaiKhoanChuTro == id) status = true;
                }
            }
            return id;
        }
        public void AddChiTietTaiKhoanChuTro(ChiTietTaiKhoanChuTro pt)
        {
            QLDAL.Instance.AddChiTietTaiKhoanChuTroDal(pt);
        }
    }
}

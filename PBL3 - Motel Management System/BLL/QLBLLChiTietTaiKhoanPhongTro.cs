using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietTaiKhoanPhongTro
    {
        private static QLBLLChiTietTaiKhoanPhongTro _instance;
        public static QLBLLChiTietTaiKhoanPhongTro Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietTaiKhoanPhongTro();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietTaiKhoanPhongTro()
        {

        }
        public List<ChiTietTaiKhoanPhongTro> GetAllTaiKhoanPhongTro()
        {
            return QLDAL.Instance.GetAllTaiKhoanPhongTro();
        }
        public string TaoIdChiTietTaiKhoanPhongTro()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietTaiKhoanPhongTro vt in QLDAL.Instance.GetAllTaiKhoanPhongTroTaoId())
                {
                    if (vt.MaChiTietTaiKhoanPhongTro == id) status = true;
                }
            }
            return id;
        }
        public void AddChiTietTaiKhoanPhongTro(ChiTietTaiKhoanPhongTro pt)
        {
            QLDAL.Instance.AddChiTietTaiKhoanPhongTroDal(pt);
        }
    }
}

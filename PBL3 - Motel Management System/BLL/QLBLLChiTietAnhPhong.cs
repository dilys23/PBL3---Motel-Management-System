using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietAnhPhong
    {

        private static QLBLLChiTietAnhPhong _instance;
        public static QLBLLChiTietAnhPhong Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietAnhPhong();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietAnhPhong()
        {

        }
        public List<ChiTietAnhPhong> GetAllChiTietAnhPhong()
        {
            return QLDAL.Instance.GetAllChiTietAnhPhong();
        }
        public List<ChiTietAnhPhong> GetChiTietAnhPhongByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetChiTietAnhPhongByIdPhong(idPhong);
        }
        public void AddChiTietAnhPhong (ChiTietAnhPhong ct)
        {
             QLDAL.Instance.AddChiTietAnhPhong(ct);
        }
        public void DelChiTietAnhPhong (string id )
        {
            QLDAL.Instance.DelChiTietAnhPhong(id);
        }
        public string TaoIdChiTietAnhPhong ()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietAnhPhong ct in QLDAL.Instance.GetAllChiTietAnhPhongTaoId())
                {
                    if (ct.MaChiTietAnhPhong == id) status = true;
                }
            }
            return id;
        }

    }
}

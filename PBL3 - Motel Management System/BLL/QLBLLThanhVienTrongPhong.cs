using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLThanhVienTrongPhong
    {
        private static QLBLLThanhVienTrongPhong _instance;
        public static QLBLLThanhVienTrongPhong Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLThanhVienTrongPhong();
                return _instance;
            }
            private set { }
        }
        private QLBLLThanhVienTrongPhong()
        {

        }
        public string TaoIdThanhVienTrongPhong()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ThanhVienTrongPhong tvtp in QLDAL.Instance.GetAllThanhVienTrongPhong())
                {
                    if (tvtp.MaThanhVienTrongPhong == id) status = true;
                }
            }
            return id;
        }
        public void AddThanhVienTrongPhongBll(ThanhVienTrongPhong tvtp)
        {
            QLDAL.Instance.AddThanhVienTrongPhong(tvtp);
        }
        public void DelThanhVienBLL(string id)
        {
            QLDAL.Instance.DelThanhVienDAL(id);
        }
        public string GetIdThanhVienByIdNguoi(string id)
        {
            return QLDAL.Instance.GetIdThanhVienByIdNguoi(id);
        }
        public List<string> GetIDThanhvienbyIDPhong(string idphong)
        {
            return QLDAL.Instance.GetIDThanhvienbyIDPhong(idphong);
        }
    }
}

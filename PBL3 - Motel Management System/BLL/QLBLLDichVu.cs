using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLDichvu
    {
        private static QLBLLDichvu _instance;
        public static QLBLLDichvu Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLDichvu();
                return _instance;
            }
            private set { }
        }
        private QLBLLDichvu()
        {

        }
        public string TaoIdDichVu()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (DichVu dv in QLDAL.Instance.GetAllDichVu())
                {
                    if (dv.MaDichVu == id) status = true;
                }
            }
            return id;
        }
        public List<DichVu> DgvDichVu(string txtTim)
        {
            List<DichVu> list = new List<DichVu>();
            foreach (DichVu dv in QLDAL.Instance.GetAllDichVu())
            {
                if (txtTim == null)
                {
                    list.Add(dv);
                }
                else
                {
                    if (dv.TenDichVu.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        list.Add(dv);
                    }
                }
            }
            return list;
        }
        public List<DichVu> GetAllDichVuByIdPhong(string idPhong)
        {
            return QLDAL.Instance.getAllDichVuByIdPhong(idPhong);
        }
        public DichVu GetDichVuByIdDichVu(string id)
        {
            return QLDAL.Instance.GetDichVuByIdDichVuDal(id);
        }
        public void ThemDVBll(DichVu dv)
        {
            QLDAL.Instance.ThemDVDal(dv);
        }
        public void SuaDVBll(DichVu dv)
        {
            QLDAL.Instance.SuaDVDal(dv);
        }
        public List<string> GetAllIdDichVuByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetAllIdDichVuByIdPhongDal(idPhong);
        }
        public DichVu GetDVByIdDV(string IdDV)
        {
            return QLDAL.Instance.GetDichVuByIdDichVuDal(IdDV);
        }
        public void DelDichVu(string id)
        {
            QLDAL.Instance.DelDichVuDal(id);
        }

    }
}

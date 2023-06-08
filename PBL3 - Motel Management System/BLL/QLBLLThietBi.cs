using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLThietbi
    {
        private static QLBLLThietbi _instance;
        public static QLBLLThietbi Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLThietbi();
                return _instance;
            }
            private set { }
        }
        private QLBLLThietbi()
        {

        }
        public string TaoIdThietBi()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ThietBi dv in QLDAL.Instance.GetAllThietBi())
                {
                    if (dv.MaThietBi == id) status = true; break;
                }
            }
            return id;
        }
        public void DelThietBiBll(string id)
        {
            QLDAL.Instance.DelThietBiDal(id);
        }
        public List<ThietBi> DgvThietBi(string txtTim)
        {
            List<ThietBi> list = new List<ThietBi>();
            foreach (ThietBi dv in QLDAL.Instance.GetAllThietBi())
            {
                if (txtTim == null)
                {
                    list.Add(dv);
                }
                else
                {
                    if (dv.TenThietBi.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        list.Add(dv);
                    }
                }
            }
            return list;
        }
        public void ThemTBBll(ThietBi tb)
        {
            QLDAL.Instance.ThemTBDal(tb);
        }
        public void SuaTBBll(ThietBi tb)
        {
            QLDAL.Instance.SuaTBDal(tb);
        }
        public string GetIdThietBiByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetIdDayByIdPhong(IdPhong);
        }
        public List<string> GetAllIdThietBiByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetAllIdThietBiByIdPhongDal(idPhong);
        }
        public ThietBi GetTBByIdTB(string idTb)
        {
            return QLDAL.Instance.GetThietBiByIdThietBiDal(idTb);
        }
    }
}

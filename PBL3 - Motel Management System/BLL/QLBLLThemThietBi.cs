using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLThemThietBi
    {
        private static QLBLLThemThietBi _instance;
        public static QLBLLThemThietBi Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLThemThietBi();
                return _instance;
            }
            private set { }
        }
        private QLBLLThemThietBi()
        {

        }
        public ThietBi GetTBByIdTB(string idTb)
        {
            return QLBLL.Instance.GetTBByIdTB(idTb);
        }
        public void SuaTBBll(ThietBi tb)
        {
            QLBLL.Instance.SuaTBBll(tb);
        }
        public string TaoIdThietBi()
        {
            return QLBLL.Instance.TaoIdThietBi();
        }
        public void ThemTBBll(ThietBi tb)
        {
            QLBLL.Instance.ThemTBBll(tb);
        }
    }
}

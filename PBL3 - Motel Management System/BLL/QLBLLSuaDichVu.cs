using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLSuaDichVu
    {
        private static QLBLLSuaDichVu _instance;
        public static QLBLLSuaDichVu Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLSuaDichVu();
                return _instance;
            }
            private set { }
        }
        private QLBLLSuaDichVu()
        {

        }
        public DichVu GetDVByIdDV(string IdDV)
        {
            return QLBLL.Instance.GetDVByIdDV(IdDV);
        }
        public void SuaDVBll(DichVu dv)
        {
            QLBLL.Instance.SuaDVBll(dv);
        }
        public string TaoIdDichVu()
        {
            return QLBLL.Instance.TaoIdDichVu(); 
        }
        public void ThemDVBll(DichVu dv)
        {
            QLBLL.Instance.ThemDVBll(dv);
        }
        public string TextMaDichVuDien()
        {
            return "001";
        }
        public string TextMaDichVuNuoc()
        {
            return "000";
        }
    }
}

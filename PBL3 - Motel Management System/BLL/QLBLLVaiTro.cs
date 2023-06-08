using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLVaiTro
    {
        private static QLBLLVaiTro _instance;
        public static QLBLLVaiTro Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLVaiTro();
                return _instance;
            }
            private set { }
        }
        private QLBLLVaiTro()
        {

        }
        public List<VaiTro> GetAllVaiTro()
        {
            return QLDAL.Instance.GetAllVaiTro();
        }
        public string TaoIdVaiTro()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (VaiTro vt in QLDAL.Instance.GetAllVaiTro())
                {
                    if (vt.MaVaiTro == id) status = true;
                }
            }
            return id;
        }
        public void AddVaiTro(VaiTro vt)
        {
            QLDAL.Instance.AddVaiTroDal(vt);
        }
        public VaiTro CheckVaiTro(string tentk, string mk)
        {
            return QLDAL.Instance.CheckVaiTro(tentk, mk);
        }
    }
}

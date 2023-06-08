using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLThemCSDien
    {
        private static QLBLLThemCSDien _instance;
        public static QLBLLThemCSDien Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLThemCSDien();
                return _instance;
            }
            private set { }
        }
        private QLBLLThemCSDien()
        {

        }

    }
}

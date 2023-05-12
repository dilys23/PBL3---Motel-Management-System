using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLHoaDonBLL
    {
        public string TaoIdHoaDon()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (HoaDon hd in qLDAL.GetAllHoaDon())
                {
                    if (hd.MaHoaDon == id) status = true;
                }
            }
            return id;
        }

    }
}

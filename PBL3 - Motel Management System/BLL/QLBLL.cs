using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLL
    {
        public string GetIdTk(string taikhoan, string matkhau)
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            foreach (TaiKhoan tk in qLDAL.GetAllTaiKhoan())
            {
                if(taikhoan == tk.TenTaiKhoan && matkhau == tk.MatKhau)
                {
                    id = tk.MaTaiKhoan;break;
                }
            }
            return id;
        }
        public string GetIdNguoiByTaiKhoan(string idTaiKhoan)
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            foreach(VaiTro vt in qLDAL.GetAllVaiTro())
            {
                if(vt.MaTaiKhoan == idTaiKhoan)
                {
                    id = vt.MaNguoi; break;
                }
            }
            return id;
        }

    }
}

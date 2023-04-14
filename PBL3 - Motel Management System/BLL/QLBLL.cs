using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
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
                if (taikhoan == tk.TenTaiKhoan && matkhau == tk.MatKhau)
                {
                    id = tk.MaTaiKhoan; break;
                }
            }
            return id;
        }
        public string GetIdNguoiByTaiKhoan(string idTaiKhoan)
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            foreach (VaiTro vt in qLDAL.GetAllVaiTro())
            {
                if (vt.MaTaiKhoan == idTaiKhoan)
                {
                    id = vt.MaNguoi; break;
                }
            }
            return id;
        }
        public List<CbbDayTro>GetCbbDayTro()
        {
            List<CbbDayTro> list = new List<CbbDayTro>();
            list.Add(new CbbDayTro { IdDayTro = "0", TenDayTro = "All"});
            QLDAL qLDAL = new QLDAL();
            foreach(DayTro dt in qLDAL.GetAllDayTro())
            {
                list.Add(new CbbDayTro {IdDayTro = dt.MaDayTro,TenDayTro = dt.TenDayTro });
            }
            return list;
        }
        public string TaoIdPhongTro()
        {
            string id = null;
            QLDAL qLDAL = new QLDAL();
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (PhongTro phongTro in qLDAL.GetAllPhongTro())
                {
                    if (phongTro.MaPhongTro == id) status = true; break;
                }
            }
            return id;
        }
        public string TaoIdDayTro()
        {
            string id = null;
            QLDAL qLDAL =  new QLDAL() ;
            Boolean status = true;
            Random random = new Random();
            while(status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach(DayTro dayTro in qLDAL.GetAllDayTro())
                {
                    if(dayTro.MaDayTro == id)status = true;break;
                }
            }
            return id;
        }
        public void AddDayTroBll(DayTro dt)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddDayTroDal(dt);
        }
        public void AddPhongTroBll(PhongTro phongTro)
        {
            QLDAL qLDAL = new QLDAL();
            qLDAL.AddPhongTroDal(phongTro);
        }
        public List<ViewDay> DgvDayTro()
        {
            List<ViewDay> list = new List<ViewDay>();
            QLDAL qLDAL = new QLDAL();
            int i = 0;
            foreach(DayTro dt in qLDAL.GetAllDayTro())
            {
                i++;
                ViewDay vd = new ViewDay();
                vd.MaDayTro = dt.MaDayTro;
                vd.Stt = i;
                vd.TenDayTro = dt.TenDayTro;
                vd.TenDuong = dt.TenDuong;
                vd.TenHuyen = dt.TenHuyen;
                vd.TenThanhPho = dt.TenThanhPho;
                vd.SoPhong = qLDAL.GetPhongByIdDay(dt.MaDayTro).Count();
                list.Add(vd);
            }
            return list;
        }

    }
}

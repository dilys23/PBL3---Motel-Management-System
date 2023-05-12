//using PBL3___Motel_Management_System.DAL;
//using PBL3___Motel_Management_System.DTO;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace PBL3___Motel_Management_System.BLL
//{
//    internal class QLPhongBLL
//    {
//        public List<PhongTro> GetAllPhongTro()
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetAllPhongTro();
//        }
//        public List<ViewCbb> GetCbbDayTro()
//        {
//            List<ViewCbb> list = new List<ViewCbb>();
//            list.Add(new ViewCbb { key = "-1", value = "All" });
//            QLDAL qLDAL = new QLDAL();
//            foreach (DayTro dt in qLDAL.GetAllDayTro())
//            {
//                list.Add(new ViewCbb { key = dt.MaDayTro, value = dt.TenDayTro });
//            }
//            return list;
//        }
//        public DayTro GetDayTroById(string id)
//        {
//            foreach (DayTro dt in GetAllDayTroBll())
//            {
//                if (dt.MaDayTro == id) return dt;
//            }
//            return null;
//        }
//        public string GetIdPhongByIdNguoi(string idNguoi)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetIdPhongByIdNguoiDal(idNguoi);
//        }
//        public List<String> GetIdPhongByIdTB(string idTB)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetIdPhongByIdTbDal(idTB);
//        }
//        public string TaoIdPhongTro()
//        {
//            string id = null;
//            QLDAL qLDAL = new QLDAL();
//            Boolean status = true;
//            Random random = new Random();
//            while (status)
//            {
//                id = random.Next(1, 1000).ToString();
//                status = false;
//                foreach (PhongTro phongTro in qLDAL.GetAllPhongTro())
//                {
//                    if (phongTro.MaPhongTro == id) status = true;
//                }
//            }
//            return id;
//        }
//        public string TaoIdDayTro()
//        {
//            string id = null;
//            QLDAL qLDAL = new QLDAL();
//            Boolean status = true;
//            Random random = new Random();
//            while (status)
//            {
//                id = random.Next(1, 1000).ToString();
//                status = false;
//                foreach (DayTro dayTro in qLDAL.GetAllDayTro())
//                {
//                    if (dayTro.MaDayTro == id) status = true;
//                }
//            }
//            return id;
//        }
//        public void AddDayTroBll(DayTro dt)
//        {
//            QLDAL qLDAL = new QLDAL();
//            qLDAL.AddDayTroDal(dt);//ok
//        }
//        public void AddPhongTroBll(PhongTro phongTro)
//        {
//            QLDAL qLDAL = new QLDAL();
//            qLDAL.AddPhongTroDal(phongTro);
//        }
//        public List<string> DgvPhongTro(string txtTim)
//        {
//            List<string> list = new List<string>();
//            QLDAL qLDAL = new QLDAL();
//            foreach (PhongTro pt in qLDAL.GetAllPhongTro())
//            {
//                if (txtTim == null)
//                {
//                    list.Add(pt.MaPhongTro);
//                }
//                else
//                {
//                    if (pt.TenPhongTro.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
//                    {
//                        list.Add(pt.MaPhongTro);
//                    }
//                }
//            }
//            return list;
//        }
//        public List<string> GetAllPhongTroByIdDay(string idDay)
//        {
//            QLDAL qLDAL = new QLDAL();
//            if (idDay != "-1")
//            {
//                return qLDAL.GetAllIdPhongTroByIdDayDal(idDay);
//            }
//            else
//            {
//                return qLDAL.GetAllIdPhongTroDal();
//            }
//        }

//        public List<string> GetAllPhongTroByIdTinhTrang(string idTinhTrang)
//        {
//            List<string> list = new List<string>();
//            QLDAL qLDAL = new QLDAL();
//            if (idTinhTrang != "-1")
//            {
//                foreach (PhongTro pt in qLDAL.GetAllPhongTro())
//                {
//                    if (idTinhTrang == "0")
//                    {
//                        if (GetHopDongByIdPhong(pt.MaPhongTro) == null)
//                        {
//                            list.Add(pt.MaPhongTro);
//                        }
//                    }
//                    else if (idTinhTrang == "1")
//                    {
//                        if (GetHopDongByIdPhong(pt.MaPhongTro) != null)
//                        {
//                            if (GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == true)
//                            {
//                                list.Add(pt.MaPhongTro);
//                            }
//                        }
//                    }
//                    else
//                    {
//                        if (GetHopDongByIdPhong(pt.MaPhongTro) != null)
//                        {
//                            if (GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == false)
//                            {
//                                list.Add(pt.MaPhongTro);
//                            }
//                        }
//                    }
//                }
//            }
//            else
//            {
//                list = qLDAL.GetAllIdPhongTroDal();
//            }
//            return list;
//        }
//        public PhongTro GetPhongTroByIdPhong(string idPhong)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetPhongTroByIdPhong(idPhong);
//        }
//        public List<PhongTro> PhongTroTimKiem(string idDay, string idTinhTrang, string txtTim)
//        {
//            List<PhongTro> list = new List<PhongTro>();
//            List<String> IdPhongFromIdDay = GetAllPhongTroByIdDay(idDay);
//            List<String> IdPhongFromIdTinhTrang = GetAllPhongTroByIdTinhTrang(idTinhTrang);
//            List<String> IdPhongFromTxtTim = DgvPhongTro(txtTim);
//            List<string> idPhong = new List<string>();
//            idPhong = IdPhongFromIdDay.Intersect(IdPhongFromIdTinhTrang).Intersect(IdPhongFromTxtTim).ToList();
//            foreach (string id in idPhong)
//            {
//                list.Add(GetPhongTroByIdPhong(id));
//            }
//            return list;
//        }
//        public List<PhongTro> GetPhongTroByIdDay(string idDay)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetPhongTroByIdDayDal(idDay);
//        }
//        public void UpdatePTBLL(PhongTro PT)
//        {
//            QLDAL qlDAl = new QLDAL();
//            qlDAl.UpdatePTDAL(PT);
//        }
//        public string GetIdDayByIdPhong(string IdPhong)
//        {
//            QLDAL qlDAl = new QLDAL();
//            return qlDAl.GetIdDayByIdPhong(IdPhong);
//        }
//        public DayTro GetDayTroByIdPhong(string idPhong)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetDayTroByIdPhongDal(idPhong);
//        }
//        public DayTro GetDayByIdDay(string id)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetDayByIdDay(id);
//        }
//        public void SuaDayBll(DayTro day)
//        {
//            QLDAL qLDAL = new QLDAL();
//            qLDAL.SuaDayDal(day);
//        }
//        public List<DayTro> GetAllDayTroBll()
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetAllDayTro();
//        }
//        public void DelPhongTroBLL(string idphong)
//        {
//            QLDAL qLDAL = new QLDAL();
//            qLDAL.DelPhongTroDAL(idphong);
//        }
//        public void DelDayTroBll(string MaDay)
//        {
//            QLDAL qLDAL = new QLDAL();
//            qLDAL.DelDayTroDal(MaDay);
//        }
//        public bool CheckDay(string idday)
//        {
//            int check = 0;
//            foreach (PhongTro pt in GetPhongTroByIdDay(idday))
//            {
//                if (GetHopDongByIdPhong(pt.MaPhongTro) != null && pt.TonTai == true) check++;
//            }
//            if (check == 0) return false;
//            else return true;
//        }
//        public bool TinhTrangPhongById(string IdPhong)
//        {
//            if (GetHopDongByIdPhong(IdPhong) == null) return false;
//            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == false) return false;
//            return true;
//        }
//        public bool PhongDaCocByIdPhong(string IdPhong)
//        {
//            if (GetHopDongByIdPhong(IdPhong) == null) return false;
//            else if (GetHopDongByIdPhong(IdPhong).TinhTrang == true) return false;
//            return true;
//        }
//        public List<TinhTrangPhongTro> GetAllTinhTrangPhongTro()
//        {
//            List<TinhTrangPhongTro> list = new List<TinhTrangPhongTro>();
//            QLDAL qLDAL = new QLDAL();
//            // Lấy ds các phòng 
//            List<PhongTro> phongTroList = qLDAL.GetAllPhongTro();
//            foreach (PhongTro phongTro in phongTroList)
//            {
//                TinhTrangPhongTro tinhTrangPhongTro = new TinhTrangPhongTro();
//                tinhTrangPhongTro.MaPhongTro = phongTro.MaPhongTro;
//                tinhTrangPhongTro.TinhTrangPhong = phongTro.TinhTrang;

//                // lấy thông tin HD dựa trên id phòng
//                HopDong hopDong = qLDAL.GetHopDongByIdPhong(phongTro.MaDayTro);
//                if (hopDong != null)
//                {
//                    tinhTrangPhongTro.TinhTrangHD = (bool)hopDong.TinhTrang;
//                }
//                else
//                {
//                    tinhTrangPhongTro.TinhTrangHD = false;
//                }
//                list.Add(tinhTrangPhongTro);
//            }
//            return list;
//        }
//        public PhongTro GetPhongTroByMaHoaDon(string idHD)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetPhongTroByIdHoaDon(idHD);
//        }
//        public PhongTro GetPhongTroByMaHopDong(string MaHopDong)
//        {
//            QLDAL qLDAL = new QLDAL();
//            return qLDAL.GetPhongTroByMaHopDong(MaHopDong);
//        }

//    }
//}

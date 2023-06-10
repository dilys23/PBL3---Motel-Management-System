using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLPhongTro
    {
        private static QLBLLPhongTro _instance;
        public static QLBLLPhongTro Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLPhongTro();
                return _instance;
            }
            private set { }
        }
        private QLBLLPhongTro()
        {

        }
        public string TaoIdPhongTro()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                if (QLDAL.Instance.KiemTraTonTaiIdPhongTro(id))
                {
                    status = true;
                }
            }
            return id;
        }

        public List<PhongTro> GetAllPhongTro()
        {
            return QLDAL.Instance.GetAllPhongTro();
        }
        public string GetIdPhongByIdNguoi(string idNguoi)
        {
            return QLDAL.Instance.GetIdPhongByIdNguoiDal(idNguoi);
        }
        public List<String> GetIdPhongByIdTB(string idTB)
        {
            return QLDAL.Instance.GetIdPhongByIdTbDal(idTB);
        }
        public PhongTro GetPhongTroByMaHoaDonBLL(string idHD)
        {
            return QLDAL.Instance.GetPhongTroByIdHoaDonDAL(idHD);
        }
        public void AddPhongTroBll(PhongTro phongTro)
        {
            QLDAL.Instance.AddPhongTroDal(phongTro);
        }
        public List<string> DgvPhongTro(string txtTim)
        {
            List<string> list = new List<string>();
            foreach (PhongTro pt in QLDAL.Instance.GetAllPhongTro())
            {
                if (txtTim == null)
                {
                    list.Add(pt.MaPhongTro);
                }
                else
                {
                    if (pt.TenPhongTro.IndexOf(txtTim, 0, StringComparison.OrdinalIgnoreCase) != -1)
                    {
                        list.Add(pt.MaPhongTro);
                    }
                }
            }
            return list;
        }
        public List<string> GetAllPhongTroByIdDay(string idDay)
        {
            if (idDay != "-1")
            {
                return QLDAL.Instance.GetAllIdPhongTroByIdDayDal(idDay);
            }
            else
            {
                return QLDAL.Instance.GetAllIdPhongTroDal();
            }
        }
        public List<string> GetAllPhongTroByIdTinhTrang(string idTinhTrang)
        {
            List<string> list = new List<string>();
            if (idTinhTrang != "-1")
            {
                foreach (PhongTro pt in QLDAL.Instance.GetAllPhongTro())
                {
                    if (idTinhTrang == "0")
                    {
                        if (QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro) == null)
                        {
                            list.Add(pt.MaPhongTro);
                        }
                    }
                    else if (idTinhTrang == "1")
                    {
                        if (QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro) != null)
                        {
                            if (QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == true)
                            {
                                list.Add(pt.MaPhongTro);
                            }
                        }
                    }
                    else
                    {
                        if (QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro) != null)
                        {
                            if (QLBLLHopDong.Instance.GetHopDongByIdPhong(pt.MaPhongTro).TinhTrang == false)
                            {
                                list.Add(pt.MaPhongTro);
                            }
                        }
                    }
                }
            }
            else
            {
                list = QLDAL.Instance.GetAllIdPhongTroDal();
            }
            return list;
        }
        public PhongTro GetPhongTroByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetPhongTroByIdPhong(idPhong);
        }
        public List<PhongTro> PhongTroTimKiem(string idDay, string idTinhTrang, string txtTim)
        {
            List<PhongTro> list = new List<PhongTro>();
            List<String> IdPhongFromIdDay = GetAllPhongTroByIdDay(idDay);
            List<String> IdPhongFromIdTinhTrang = GetAllPhongTroByIdTinhTrang(idTinhTrang);
            List<String> IdPhongFromTxtTim = DgvPhongTro(txtTim);
            List<string> idPhong = new List<string>();
            idPhong = IdPhongFromIdDay.Intersect(IdPhongFromIdTinhTrang).Intersect(IdPhongFromTxtTim).ToList();
            foreach (string id in idPhong)
            {
                list.Add(GetPhongTroByIdPhong(id));
            }
            return list;
        }
        public List<PhongTro> GetPhongTroByIdDay(string idDay)
        {
            return QLDAL.Instance.GetPhongTroByIdDayDal(idDay);
        }
        public void UpdatePTBLL(PhongTro PT)
        {
            QLDAL.Instance.UpdatePTDAL(PT);
        }
        public void DelPhongTroBLL(string idphong)
        {
            QLDAL.Instance.DelPhongTroDAL(idphong);
        }
        public string GetIdPhongByIdChiTietSuDungDichVu(string idct)
        {
            return QLDAL.Instance.GetIdPhongByIdChiTietSuDungDichVu(idct);
        }
        public string GetIdPhongByIdHoaDon(string idHoaDon)
        {
            return QLDAL.Instance.GetIdPhongByIdHoaDon(idHoaDon);
        }
        public string GetIdPhongbyIdChitietsudungDichVu(string idChitiet)
        {
            return QLDAL.Instance.GetIdPhongbyIdChitietsudungDichVu(idChitiet);
        }
        public bool TinhTrangPhongById(string IdPhong)
        {
            if (QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong).TinhTrang == false) return false;
            return true;
        }
        public bool PhongDaCocByIdPhong(string IdPhong)
        {
            if (QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong) == null) return false;
            else if (QLBLLHopDong.Instance.GetHopDongByIdPhong(IdPhong).TinhTrang == true) return false;
            return true;
        }
        public List<TinhTrangPhongTro> GetAllTinhTrangPhongTro()
        {
            List<TinhTrangPhongTro> list = new List<TinhTrangPhongTro>();
            // Lấy ds các phòng 
            List<PhongTro> phongTroList = QLDAL.Instance.GetAllPhongTro();
            foreach (PhongTro phongTro in phongTroList)
            {
                TinhTrangPhongTro tinhTrangPhongTro = new TinhTrangPhongTro();
                tinhTrangPhongTro.MaPhongTro = phongTro.MaPhongTro;
                tinhTrangPhongTro.TinhTrangPhong = phongTro.TinhTrang;

                // lấy thông tin HD dựa trên id phòng
                HopDong hopDong = QLDAL.Instance.GetHopDongByIdPhong(phongTro.MaDayTro);
                if (hopDong != null)
                {
                    tinhTrangPhongTro.TinhTrangHD = (bool)hopDong.TinhTrang;
                }
                else
                {
                    tinhTrangPhongTro.TinhTrangHD =false;
                }
                list.Add(tinhTrangPhongTro);
            }
            return list;
        }
        public PhongTro GetPhongTroByMaHoaDon(string idHD)
        {
            return QLDAL.Instance.GetPhongTroByIdHoaDon(idHD);
        }
        public PhongTro GetPhongTroByMaHopDong(string MaHopDong)
        {
            return QLDAL.Instance.GetPhongTroByMaHopDong(MaHopDong);
        }
        public List<ViewCbb> GetViewCbbPhongByDay(string id)
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            if (id == "-1")
            {
                foreach (PhongTro pt in GetAllPhongTro())
                {
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            else
            {
                foreach (string idp in GetAllPhongTroByIdDay(id))
                {
                    PhongTro pt = GetPhongTroByIdPhong(idp);
                    list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                }
            }
            return list;
        }
        public List<ViewCbb> GetViewCbbPhongDaThueByDay(string id)
        {
            List<ViewCbb> list = new List<ViewCbb>();
            list.Add(new ViewCbb { key = "-1", value = "All" });
            if (id == "-1")
            {
                foreach (PhongTro pt in GetAllPhongTro())
                {
                    if (TinhTrangPhongById(pt.MaPhongTro))
                    {
                        list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            else
            {
                foreach (string idp in GetAllPhongTroByIdDay(id))
                {
                    if (TinhTrangPhongById(idp))
                    {
                        PhongTro pt = GetPhongTroByIdPhong(idp);
                        list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            return list;
        }
        public List<ViewCbb> GetViewCbbPhongByDayForThemHoaDon(string id)
        {
            List<ViewCbb> list = new List<ViewCbb>();
            if (id == "-1")
            {
                foreach (PhongTro pt in GetAllPhongTro())
                {
                    if (TinhTrangPhongById(pt.MaPhongTro))
                    {
                        list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            else
            {
                foreach (string idp in GetAllPhongTroByIdDay(id))
                {
                    if (TinhTrangPhongById(idp))
                    {
                        PhongTro pt = GetPhongTroByIdPhong(idp);
                        list.Add(new ViewCbb { key = pt.MaPhongTro, value = pt.TenPhongTro });
                    }
                }
            }
            return list;
        }
        public PhongTro GetPhongTroByMaTaiKhoan(string matk)
        {
            return QLDAL.Instance.GetPhongTroByMaTaiKhoan(matk);
        }
    }
}

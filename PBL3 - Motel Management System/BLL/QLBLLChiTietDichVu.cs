using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietDichVu
    {
        private static QLBLLChiTietDichVu _instance;
        public static QLBLLChiTietDichVu Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietDichVu();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietDichVu()
        {

        }
        public string TaoIdChiTietDichVu()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietDichVu ctdv in QLDAL.Instance.GetAllChiTietDichVu())
                {
                    if (ctdv.MaChiTietDichVu == id) status = true;
                }
            }
            return id;
        }
        public string GetIdCHiTietDichVuDienByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetIdChiTietDichVuDienByIdPhongDal(idPhong);
        }
        public string GetIdCHiTietDichVuNuocByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetIdChiTietDichVuNuocByIdPhongDal(idPhong);
        }
        public void UpdateChitietdichvu(ChiTietDichVu ct)
        {
            QLDAL.Instance.UpdateChitietdichvu(ct);
        }
        public void AddChiTietDichVuBll(ChiTietDichVu ctdv)
        {
            QLDAL.Instance.AddChiTietDichVuDal(ctdv);
        }
        public ChiTietDichVu GetChiTietDichVuById(string id)
        {
            return QLDAL.Instance.GetChiTietDichVuByIdDal(id);

        }
        public List<ChiTietDichVu> GetChiTietDichVuByIdPhong(string idPhong)
        {
            List<ChiTietDichVu> list = new List<ChiTietDichVu>();
            foreach (ChiTietDichVu ctdv in QLDAL.Instance.GetAllChiTietDichVu())
            {
                if (ctdv.MaPhongTro == idPhong) list.Add(ctdv);
            }
            return list;

        }
        public List<string> GetAllIdChitietDichVuByIdPhong(string idphong)
        {
            return QLDAL.Instance.GetAllIdChiTietDichVuByIdPhong(idphong);
        }
        public void DelCHiTietDichVuByIdPhong(string IdPhong)
        {
            foreach (string id in GetAllIdChitietDichVuByIdPhong(IdPhong))
            {
                QLDAL.Instance.DelChiTietDichVuDal(id);
            }
        }
        public string GetMaChiTietDichVuByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetMaChiTietDichVuByIdPhong(idPhong);
        }
        public void DelChiTietDichVu(string id)
        {
            QLDAL.Instance.DelChiTietDichVuDal(id);
        }
        public string GetIdChiTietDichVuByIdPhongAndIdDichVu(string idp, string iddv)
        {
            return QLDAL.Instance.GetIdChiTietDichVuByIdPhongAndIdDichVu(idp, iddv);
        }
        public List<string> GetAllChiTietDichVuByIdDichVu(string id)
        {
            return QLDAL.Instance.GetAllIdChiTietDichVuByIdDichVu(id);
        }
        public void DelChiTietDichVuByIdDichVu(string id)
        {
            foreach (string Id in GetAllChiTietDichVuByIdDichVu(id))
            {
                DelChiTietDichVu(Id);
            }
        }
        public void ThayDoiDichVuPhong(List<string> dsdv, string idP)
        {
            List<string> ListCu = QLBLLDichvu.Instance.GetAllIdDichVuByIdPhong(idP);
            foreach (string id in ListCu)
            {
                if (!dsdv.Contains(id))
                {
                    DelChiTietDichVu(GetIdChiTietDichVuByIdPhongAndIdDichVu(idP, id));
                }
            }
            foreach (string id in dsdv)
            {
                if (!ListCu.Contains(id))
                {
                    AddChiTietDichVuBll(new ChiTietDichVu()
                    {
                        MaChiTietDichVu = TaoIdChiTietDichVu(),
                        MaDichVu = id,
                        MaPhongTro = idP,
                        TonTai = true
                    });
                }
            }
        }
    }
}

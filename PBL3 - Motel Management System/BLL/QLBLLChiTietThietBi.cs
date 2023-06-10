using PBL3___Motel_Management_System.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChiTietThietBi
    {
        private static QLBLLChiTietThietBi _instance;
        public static QLBLLChiTietThietBi Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChiTietThietBi();
                return _instance;
            }
            private set { }
        }
        private QLBLLChiTietThietBi()
        {

        }
        public string TaoIdChiTietThietBi()
        {
            string id = null;
            Boolean status = true;
            Random random = new Random();
            while (status)
            {
                id = random.Next(1, 1000).ToString();
                status = false;
                foreach (ChiTietThietBi cttb in QLDAL.Instance.GetAllChiTietThietBiTaoId())
                {
                    if (cttb.MaChiTietThietBi == id) status = true;
                }
            }
            return id;
        }
        public void AddChiTietThietBiBll(ChiTietThietBi cttb)
        {
            QLDAL.Instance.AddChiTietThietBiDal(cttb);
        }
        public List<ChiTietThietBi> GetChiTietThietBiByIdPhong(string IdPhong)
        {
            return QLDAL.Instance.GetChiTietThietBiByIdPhongDal(IdPhong);
        }
        public List<string> GetAllIdCHiTietThietBiByIdPhong(string idPhong)
        {
            return QLDAL.Instance.GetAllIdChiTietThietBiByIdPhong(idPhong);
        }
        public ChiTietThietBi GetChiTietThietBiById(string IdChiTiet)
        {
            return QLDAL.Instance.GetChiTietThietBiByIdDal(IdChiTiet);
        }
        public void DelCHiTietThietBiByIdPhongBLL(string IdPhong)
        {
            foreach (string id in GetAllIdCHiTietThietBiByIdPhong(IdPhong))
            {
                QLDAL.Instance.DelCHiTietThietBiById(id);
            }
        }
        public void DelCHiTietThietBiById(string id)
        {
            QLDAL.Instance.DelCHiTietThietBiById(id);
        }
        public List<string> GetAllChiTietThietBiByIdThietBi(string idThietBi)
        {
            return QLDAL.Instance.GetAllIdChiTietThietBiByIdThietBi(idThietBi);
        }
        public void DelChiTietThietBiByIdThietBi(string idThietBi)
        {
            foreach (string id in GetAllChiTietThietBiByIdThietBi(idThietBi))
            {
                QLDAL.Instance.DelCHiTietThietBiById(id);
            }
        }
        public ChiTietThietBi GetChiTietThietBiByIdPhongAndIdThietBi(string idp, string idtb)
        {
            return QLDAL.Instance.GetChiTietThietBiByIdPhongAndIdThietBi(idp, idtb);
        }
        public void UpdateChiTietThietBi(ChiTietThietBi cttb)
        {
            QLDAL.Instance.UpdateChiTietThietBiDal(cttb);
        }
        public void ThayDoiThietBiPhong(List<ChiTietThietBi> listMoi, string idp)
        {
            List<ChiTietThietBi> listCu = GetChiTietThietBiByIdPhong(idp);
            foreach (ChiTietThietBi ct in listCu)
            {
                bool status = false;
                foreach (ChiTietThietBi cttb in listMoi)
                {
                    if (cttb.MaThietBi == ct.MaThietBi && cttb.MaPhongTro == ct.MaPhongTro)
                    {
                        status = true;
                    }
                }
                if (!status)
                {
                    DelCHiTietThietBiById(ct.MaChiTietThietBi);
                }
            }
            foreach (ChiTietThietBi ct in listMoi)
            {
                ChiTietThietBi cttb = GetChiTietThietBiByIdPhongAndIdThietBi(idp, ct.MaThietBi);
                if (cttb != null)
                {
                    if (cttb.SoLuong != ct.SoLuong)
                    {
                        cttb.SoLuong = ct.SoLuong;
                        UpdateChiTietThietBi(cttb);
                    }
                }
                else
                {
                    AddChiTietThietBiBll(new ChiTietThietBi()
                    {
                        MaChiTietThietBi = QLBLLChiTietThietBi.Instance.TaoIdChiTietThietBi(),
                        MaThietBi = ct.MaThietBi,
                        MaPhongTro = idp,
                        SoLuong = ct.SoLuong,
                        TonTai = true
                    });
                }
            }
        }
    }
}

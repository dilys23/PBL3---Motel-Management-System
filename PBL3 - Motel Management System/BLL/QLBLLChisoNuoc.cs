using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.BLL
{
    internal class QLBLLChisoNuoc
    {
        private static QLBLLChisoNuoc _instance;
        public static QLBLLChisoNuoc Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChisoNuoc();
                return _instance;
            }
            private set { }
        }
        private QLBLLChisoNuoc()
        {

        }
        public void openChildForm1(Form childForm, System.Windows.Forms.Panel p)
        {
            QLBLL.Instance.openChildForm1(childForm, p);
        }
        public void customDGV(DataGridView dgv)
        {
            QLBLL.Instance.customDGV(dgv);
        }
        public List<ViewChiSo> GetAllViewChiSo()
        {
            return QLBLL.Instance.GetAllViewChiSo();
        }
        public ChiTietDichVu GetChiTietDichVuById(string id)
        {
            return QLBLL.Instance.GetChiTietDichVuById(id);
        }
        public List<ViewChiSo> GetViewChiSoByTimKiem(string ThangSuDung, string IdDay, string IdPhong, string IdTinhTrang)
        {
            return QLBLL.Instance.GetViewChiSoByTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang);
        }
        public List<ViewCbb> GetCbbDayTro()
        {
            return QLBLL.Instance.GetCbbDayTro();
        }
        public List<ViewCbb> GetCbbTinhTrang()
        {
            return QLBLL.Instance.GetCbbTinhTrang();
        }
        public List<ViewCbb> GetViewCbbPhongByDay(string id)
        {
            return QLBLL.Instance.GetViewCbbPhongByDay(id);
        }
        public bool ChoPhepXacThucChiSo(string id, string MaChiSo)
        {
            return QLBLL.Instance.ChoPhepXacThucChiSo(id, MaChiSo);
        }
        public void UpdateChiTietSuDungDichVu(ChiTietSuDungDichVu dv)
        {
            QLBLL.Instance.UpdateChiTietSuDungDichVu(dv);
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdBLL(string id)
        {
            return QLBLL.Instance.GetChiTietSuDungDichVuByIdBLL(id);
        }
        public string GetIdPhongbyIdChitietsudungDichVu(string idChitiet)
        {
            return QLBLL.Instance.GetIdPhongbyIdChitietsudungDichVu(idChitiet);
        }
        public bool TinhTrangThanhToan(string IdPhong, string Thangct)
        {
            return QLBLL.Instance.TinhTrangThanhToan(IdPhong, Thangct);
        }
        public void DelChiTietSuDungDichVu(string id)
        {
            QLBLL.Instance.DelChiTietSuDungDichVu(id);
        }
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btSua, Image btXoa)
        {
            QLBLL.Instance.dgvIcons_CellPainting1(dgv, e, btSua, btXoa);
        }
        public string TextMaDichVuNuoc()
        {
            return "000";
        }
        public string TextDaXacThuc()
        {
            return "Đã xác thực";
        }
        public string TextChuaXacThuc()
        {
            return "Chưa xác thực";
        }
        public string TextDiaChiIconSua()
        {
            return @"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-create-25.png";
        }
        public string TextDiaChiIconXoa()
        {
            return @"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png";
        }
        public string TextBtnSua()
        {
            return "btnSua";
        }
        

    }
}

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
    internal class QLBLLChisoDien
    {
        private static QLBLLChisoDien _instance;
        public static QLBLLChisoDien Instance
        {
            get
            {
                if (_instance == null) _instance = new QLBLLChisoDien();
                return _instance;
            }
            private set { }
        }
        private QLBLLChisoDien()
        {

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
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btSua, Image btXoa)
        {
            QLBLL.Instance.dgvIcons_CellPainting1(dgv, e, btSua, btXoa);
        }
        public string GetIdPhongByIdChiTietSuDungDichVu(string idChitiet)
        {
            return QLBLL.Instance.GetIdPhongbyIdChitietsudungDichVu(idChitiet);
        }
        public List<ViewCbb> GetCbbDayTro()
        {
            return QLBLL.Instance.GetCbbDayTro();
        }
        public List<ViewCbb> GetCbbTinhTrang()
        {
            return QLBLL.Instance.GetCbbTinhTrang();
        }
        public void openChildForm1(Form childForm, System.Windows.Forms.Panel p)
        {
            QLBLL.Instance.openChildForm1(childForm, p);
        }
        public bool ChoPhepXacThucChiSo(string id, string MaChiSo)
        {
            return QLBLL.Instance.ChoPhepXacThucChiSo(id, MaChiSo);
        }
        public void UpdateChiTietSuDungDichVu(ChiTietSuDungDichVu dv)
        {
            QLBLL.Instance.UpdateChiTietSuDungDichVu(dv);
        }
        public List<ViewCbb> GetViewCbbPhongByDay(string id)
        {
            return QLBLL.Instance.GetViewCbbPhongByDay(id);
        }
        public bool TinhTrangThanhToan(string IdPhong, string Thangct)
        {
            return QLBLL.Instance.TinhTrangThanhToan(IdPhong, Thangct);
        }
        public ChiTietSuDungDichVu GetChiTietSuDungDichVuByIdBLL(string id)
        {
            return QLBLL.Instance.GetChiTietSuDungDichVuByIdBLL(id);
        }
        public void DelChiTietSuDungDichVu(string id)
        {
            QLBLL.Instance.DelChiTietSuDungDichVu(id);
        }
        public string TextDaXacThuc()
        {
            return "Đã xác thực";
        }
        public string TextChuaXacThuc()
        {
            return "Chưa xác thực";
        }
        public string TextMaDichVuDien()
        {
            return "001";
        }
        public string TextKieuThoiGian()
        {
            return "MM-yyyy";
        }
        public string TextDiaChiNutSua()
        {
            return @"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-create-25.png";
        }
        public string TextDiaChiNutXoa()
        {
            return @"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png";
        }
        public string TextThongBaoXacThucThanhCong()
        {
            return "Xác thực thành công";
        }
        public string TextThongBao()
        {
            return "Thông báo";
        }
        public string TextThongBaoCoChiTietDaDuocXacThuc()
        {
            return "Phòng hiện tại của bạn đã có một chi tiết được xác nhận!!!";
        }
        public string TextDichVuDaDuocXacThuc()
        {
            return "Dịch vụ hiện tại đã được xác thực";
        }
        public string TextChiSoDienChuaXacThuc()
        {
            return "Chỉ số điện hiện tại đang chưa xác thực";
        }
        public string TextHuyXacThuc()
        {
            return "Hủy bỏ xác thực thành công";
        }
        public string TextChiTietDaNamTrongHoaDon()
        {
            return "Chi tiết này đang nằm trong 1 hóa đơn đang xác thực !! không thể hủy";
        }
        public string TextBtnSua()
        {
            return "btnSua";
        }
        public string TextChiSoDaXacThucKhongTheSua()
        {
            return "Chỉ số hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa chỉ số";
        }
        public string TextXoaThanhCong()
        {
            return "Xóa chỉ số điện thành công";
        }
        public string TextHoaDonDaXacThuc()
        {
            return "Hóa đơn đã được xác thực!! Không thể xóa";
        }
    }
}

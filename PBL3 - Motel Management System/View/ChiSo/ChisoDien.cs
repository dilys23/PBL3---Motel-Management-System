using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChisoDien : Form
    {
        public ChisoDien()
        {
            InitializeComponent();
            LoadForm(null);
            Setcbb();
        }
        private void LoadForm(string txt)
        {
            dgvChiSoDien.Rows.Clear();
            QLBLL.Instance.customDGV(dgvChiSoDien);
            int i = 0;
            if(txt==null)
            {
            foreach(ViewChiSo view in QLBLL.Instance.GetAllViewChiSo())
                {
                    if(QLBLL.Instance.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "001")
                    {
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        ,view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).key;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).key;
                foreach(ViewChiSo view in QLBLL.Instance.GetViewChiSoByTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang))
                {
                    if (QLBLL.Instance.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "001")
                    {
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        , view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvChiSoDien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLL.Instance.dgvIcons_CellPainting1(dgvChiSoDien, e, Sua, Xoa));
        }
        public void Setcbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLL.Instance.GetCbbDayTro().ToArray());
            cbbTinhTrang.Items.AddRange(QLBLL.Instance.GetCbbTinhTrang().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            QLBLL.Instance.openChildForm1(new ThemCSDien(null, LoadForm), panelChisoDien);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() != "Đã xác thực")
            {
                string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                if (QLBLL.Instance.ChoPhepXacThucChiSo(id, "001"))
                {
                    ChiTietSuDungDichVu dv = QLBLL.Instance.GetChiTietSuDungDichVuByIdBLL(id);
                    dv.TinhTrang = true;
                    QLBLL.Instance.UpdateChiTietSuDungDichVu(dv);
                    MessageBox.Show("Xác thực thành công", "Thông báo");
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show("Phòng hiện tại của bạn đã có một chi tiết được xác nhận!!!", "Thông báo");
                }
            } 
            else
            {
                MessageBox.Show("Dịch vụ hiện tại đã được xác thực", "Thông báo");
            }
        }
        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            cbbPhongTro.Items.AddRange(QLBLL.Instance.GetViewCbbPhongByDay(id).ToArray());
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy tháng và năm được chọn
            int month = dtpThangSuDung.Value.Month;
            int year = dtpThangSuDung.Value.Year;

            // Tạo ngày đầu tiên của tháng và năm được chọn
            DateTime date = new DateTime(year, month, 1);

            // Gán ngày đó cho DateTimePicker
            dtpThangSuDung.Value = date;
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }
        private void btnHuyXacThuc_Click(object sender, EventArgs e)
        {
            if(dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() != "Đã xác thực")
            {
                MessageBox.Show("Chỉ số điện hiện tại đang chưa xác thực");
            }
            else
            {
                string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                string thangct = dgvChiSoDien.CurrentRow.Cells[8].Value.ToString();
                string idp = QLBLL.Instance.GetIdPhongByIdChiTietSuDungDichVu(id);
                if (QLBLL.Instance.TinhTrangThanhToan(idp, thangct))
                {
                    
                    ChiTietSuDungDichVu dv = QLBLL.Instance.GetChiTietSuDungDichVuByIdBLL(id);
                    dv.TinhTrang = false;
                    QLBLL.Instance.UpdateChiTietSuDungDichVu(dv);
                    MessageBox.Show("Hủy bỏ xác thực thành công", "Thông báo");
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show("Chi tiết này đang nằm trong 1 hóa đơn đang xác thực !! không thể hủy");
                }
               

            }
        }
        private void dgvChiSoDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvChiSoDien.Columns[e.ColumnIndex].Name;
            if (columnName == "btnSua")
            {
                if (dgvChiSoDien.Rows[e.RowIndex].Cells[9].Value.ToString() == "Đã xác thực")
                {
                    MessageBox.Show("Chỉ số hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa chỉ số", "Thông báo");
                }
                else
                {
                    string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                    ThemCSDien frm = new ThemCSDien(id, LoadForm);
                    frm.cbbDayTro.Enabled = false;
                    frm.cbbPhongTro.Enabled = false;
                    QLBLL.Instance.openChildForm1(frm, panelChisoDien);

                }
            }
                else if (columnName == "btnXoa")
                {
                    if (dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() == "Chưa xác thực")
                    {
                        string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                        QLBLL.Instance.DelChiTietSuDungDichVu(id);
                        dgvChiSoDien.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show("Xóa chỉ số điện thành công", "Thông báo");
                        LoadForm(null);
                    }
                    else
                    {
                        MessageBox.Show("Hóa đơn đã được xác thực!! Không thể xóa", "Thông báo");
                    }
                }
            
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using PBL3___Motel_Management_System.View;
namespace PBL3___Motel_Management_System
{
    public partial class ChisoNuoc : Form
    {
        public ChisoNuoc()
        {
            InitializeComponent();
            LoadForm(null);
            Setcbb();
        }
        private void btnThemHD_Click(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            qLBLL.openChildForm1(new ThemCSNuoc(null, LoadForm), panelChisoNuoc);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            // Lấy tháng và năm được chọn
            int month = dtpThang.Value.Month;
            int year = dtpThang.Value.Year;

            // Tạo ngày đầu tiên của tháng và năm được chọn
            DateTime date = new DateTime(year, month, 1);

            // Gán ngày đó cho DateTimePicker
            dtpThang.Value = date;
        }
        private void LoadForm(string txt)
        {
            dgvChiSoNuoc.Rows.Clear();
            QLBLL qLBLL = new QLBLL();
            qLBLL.customDGV(dgvChiSoNuoc);
            int i = 0;
            if (txt==null)
            {
                foreach (ViewChiSo view in qLBLL.GetAllViewChiSo())
                {
                    if (qLBLL.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "000")
                    {
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";
                        dgvChiSoNuoc.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        , view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            else
            {
                string ThangSuDung = dtpThang.Value.ToString("MM-yyyy");
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).key;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).key;
                foreach (ViewChiSo view in qLBLL.GetViewChiSoByTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang))
                {
                    if (qLBLL.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == "000")
                    {
                        string tinhTrang = (view.TinhTrang) ? "Đã xác thực" : "Chưa xác thực";
                        dgvChiSoNuoc.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        , view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBLproject\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBLproject\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvChiSoNuoc.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => qLBLL.dgvIcons_CellPainting1(dgvChiSoNuoc, e, Sua, Xoa));
        }
        public void Setcbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            QLBLL qLBLL = new QLBLL();
            cbbDayTro.Items.AddRange(qLBLL.GetCbbDayTro().ToArray());
            cbbTinhTrang.Items.AddRange(qLBLL.GetCbbTinhTrang().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLBLL qLBLL = new QLBLL();
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            cbbPhongTro.Items.AddRange(qLBLL.GetViewCbbPhongByDay(id).ToArray());
            if (cbbPhongTro.Items.Count != 0)
            {
                cbbPhongTro.SelectedIndex = 0;
            }
        }
        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            LoadForm("");
        }

     

        private void btnXacThuc_Click(object sender, EventArgs e)
        {
            if (dgvChiSoNuoc.CurrentRow.Cells[9].Value.ToString() != "Đã xác thực")
            {
                QLBLL qLBLL = new QLBLL();
                string id = dgvChiSoNuoc.CurrentRow.Cells[0].Value.ToString();
                if (qLBLL.ChoPhepXacThucChiSo(id,"000"))
                {
                    ChiTietSuDungDichVu dv = qLBLL.GetChiTietSuDungDichVuByIdBLL(id);
                    dv.TinhTrang = true;
                    qLBLL.UpdateChiTietSuDungDichVu(dv);
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

        private void btnHuyXacThuc_Click(object sender, EventArgs e)
        {
            if (dgvChiSoNuoc.CurrentRow.Cells[9].Value.ToString() != "Đã xác thực")
            {
                MessageBox.Show("Dịch vụ hiện tại hiện đang chưa xác thực");
            }
            else
            {
                QLBLL qLBLL = new QLBLL();
                string id = dgvChiSoNuoc.CurrentRow.Cells[0].Value.ToString();
                ChiTietSuDungDichVu dv = qLBLL.GetChiTietSuDungDichVuByIdBLL(id);
                dv.TinhTrang = false;
                qLBLL.UpdateChiTietSuDungDichVu(dv);
                MessageBox.Show("Hủy bỏ xác thực thành công", "Thông báo");
                LoadForm(null);

            }
        }
        private void dgvChiSoNuoc_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvChiSoNuoc.Columns[e.ColumnIndex].Name;
            if (columnName == "btnSua")
            {
                if (dgvChiSoNuoc.Rows[e.RowIndex].Cells[9].Value.ToString() == "Đã xác thực")
                {
                    MessageBox.Show("Chỉ số hiện tại đã được xác thực nên không thể sửa!!Vui lòng bỏ xác thực trước khi sửa chỉ số", "Thông báo");
                }
                else
                {
                    string id = dgvChiSoNuoc.CurrentRow.Cells[0].Value.ToString();
                    ThemCSNuoc frm = new ThemCSNuoc(id, LoadForm);
                    frm.cbbDayTro.Enabled = false;
                    frm.cbbPhongTro.Enabled=false;
                    QLBLL qLBLL = new QLBLL();
                    qLBLL.openChildForm1(frm, panelChisoNuoc);
                }

            }
            else if (columnName == "btnXoa")
            {
                if (dgvChiSoNuoc.CurrentRow.Cells[9].Value.ToString() == "Chưa xác thực")
                {
                    string id = dgvChiSoNuoc.CurrentRow.Cells[0].Value.ToString();
                    QLBLL qLBLL = new QLBLL();
                    qLBLL.DelChiTietSuDungDichVu(id);
                    dgvChiSoNuoc.Rows.RemoveAt(e.RowIndex);
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

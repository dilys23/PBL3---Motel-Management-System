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
            QLBLLChisoDien.Instance.customDGV(dgvChiSoDien);
            int i = 0;
            if(txt==null)
            {
            foreach(ViewChiSo view in QLBLLChisoDien.Instance.GetAllViewChiSo())
                {
                    if(QLBLLChisoDien.Instance.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == QLBLLChisoDien.Instance.TextMaDichVuDien())
                    {
                        string tinhTrang = (view.TinhTrang) ? QLBLLChisoDien.Instance.TextDaXacThuc() : QLBLLChisoDien.Instance.TextChuaXacThuc();
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        ,view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString(QLBLLChisoDien.Instance.TextKieuThoiGian());
                string IdDay = ((ViewCbb)cbbDayTro.SelectedItem).key;
                string IdPhong = ((ViewCbb)cbbPhongTro.SelectedItem).key;
                string IdTinhTrang = ((ViewCbb)cbbTinhTrang.SelectedItem).key;
                foreach(ViewChiSo view in QLBLLChisoDien.Instance.GetViewChiSoByTimKiem(ThangSuDung, IdDay, IdPhong, IdTinhTrang))
                {
                    if (QLBLLChisoDien.Instance.GetChiTietDichVuById(view.MaChiTietDichVu).MaDichVu == QLBLLChisoDien.Instance.TextMaDichVuDien())
                    {
                        string tinhTrang = (view.TinhTrang) ? QLBLLChisoDien.Instance.TextDaXacThuc() : QLBLLChisoDien.Instance.TextChuaXacThuc();
                        dgvChiSoDien.Rows.Add(view.MaChiTietSuDungDichVu, ++i, view.TenDayTro, view.TenPhongTro, view.ChiSoCu, view.ChiSoMoi, view.DaDung
                        , view.NgayLap, view.ThangSuDung, tinhTrang);
                    }
                }
            }
            var Sua = System.Drawing.Image.FromFile(QLBLLChisoDien.Instance.TextDiaChiNutSua());
            var Xoa = System.Drawing.Image.FromFile(QLBLLChisoDien.Instance.TextDiaChiNutXoa());
            dgvChiSoDien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLLChisoDien.Instance.dgvIcons_CellPainting1(dgvChiSoDien, e, Sua, Xoa));
        }
        public void Setcbb()
        {
            cbbDayTro.Items.Clear();
            cbbPhongTro.Items.Clear();
            cbbDayTro.Items.AddRange(QLBLLChisoDien.Instance.GetCbbDayTro().ToArray());
            cbbTinhTrang.Items.AddRange(QLBLLChisoDien.Instance.GetCbbTinhTrang().ToArray());
            cbbDayTro.SelectedIndex = 0;
            cbbTinhTrang.SelectedIndex = 0;
        }
        private void iconButton2_Click(object sender, EventArgs e)
        {
            QLBLLChisoDien.Instance.openChildForm1(new ThemCSDien(null, LoadForm), panelChisoDien);
        }
        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() != QLBLLChisoDien.Instance.TextDaXacThuc())
            {
                string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                if (QLBLLChisoDien.Instance.ChoPhepXacThucChiSo(id, QLBLLChisoDien.Instance.TextMaDichVuDien()))
                {
                    ChiTietSuDungDichVu dv = QLBLLChisoDien.Instance.GetChiTietSuDungDichVuByIdBLL(id);
                    dv.TinhTrang = true;
                    QLBLLChisoDien.Instance.UpdateChiTietSuDungDichVu(dv);
                    MessageBox.Show(QLBLLChisoDien.Instance.TextThongBaoXacThucThanhCong(), QLBLLChisoDien.Instance.TextThongBao());
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show(QLBLLChisoDien.Instance.TextThongBaoCoChiTietDaDuocXacThuc(), QLBLLChisoDien.Instance.TextThongBao());
                }
            } 
            else
            {
                MessageBox.Show(QLBLLChisoDien.Instance.TextDichVuDaDuocXacThuc(), QLBLLChisoDien.Instance.TextThongBao());
            }
        }
        private void cbbDayTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbPhongTro.Items.Clear();
            string id = ((ViewCbb)cbbDayTro.SelectedItem).key;
            cbbPhongTro.Items.AddRange(QLBLLChisoDien.Instance.GetViewCbbPhongByDay(id).ToArray());
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
            if(dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() != QLBLLChisoDien.Instance.TextDaXacThuc())
            {
                MessageBox.Show(QLBLLChisoDien.Instance.TextChiSoDienChuaXacThuc());
            }
            else
            {
                string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                string thangct = dgvChiSoDien.CurrentRow.Cells[8].Value.ToString();
                string idp = QLBLLChisoDien.Instance.GetIdPhongByIdChiTietSuDungDichVu(id);
                if (QLBLLChisoDien.Instance.TinhTrangThanhToan(idp, thangct))
                {
                    
                    ChiTietSuDungDichVu dv = QLBLLChisoDien.Instance.GetChiTietSuDungDichVuByIdBLL(id);
                    dv.TinhTrang = false;
                    QLBLLChisoDien.Instance.UpdateChiTietSuDungDichVu(dv);
                    MessageBox.Show(QLBLLChisoDien.Instance.TextHuyXacThuc(), QLBLLChisoDien.Instance.TextThongBao());
                    LoadForm(null);
                }
                else
                {
                    MessageBox.Show(QLBLLChisoDien.Instance.TextChiTietDaNamTrongHoaDon());
                }
            }
        }
        private void dgvChiSoDien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string columnName = dgvChiSoDien.Columns[e.ColumnIndex].Name;
            if (columnName == QLBLLChisoDien.Instance.TextBtnSua())
            {
                if (dgvChiSoDien.Rows[e.RowIndex].Cells[9].Value.ToString() == QLBLLChisoDien.Instance.TextDaXacThuc())
                {
                    MessageBox.Show(QLBLLChisoDien.Instance.TextChiSoDaXacThucKhongTheSua(), QLBLLChisoDien.Instance.TextThongBao());
                }
                else
                {
                    string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                    ThemCSDien frm = new ThemCSDien(id, LoadForm);
                    frm.cbbDayTro.Enabled = false;
                    frm.cbbPhongTro.Enabled = false;
                    QLBLLChisoDien.Instance.openChildForm1(frm, panelChisoDien);
                }
            }
                else
                {
                    if (dgvChiSoDien.CurrentRow.Cells[9].Value.ToString() == QLBLLChisoDien.Instance.TextChuaXacThuc())
                    {
                        string id = dgvChiSoDien.CurrentRow.Cells[0].Value.ToString();
                        QLBLLChisoDien.Instance.DelChiTietSuDungDichVu(id);
                        dgvChiSoDien.Rows.RemoveAt(e.RowIndex);
                        MessageBox.Show(QLBLLChisoDien.Instance.TextXoaThanhCong(), QLBLLChisoDien.Instance.TextThongBao());
                        LoadForm(null);
                    }
                    else
                    {
                        MessageBox.Show(QLBLLChisoDien.Instance.TextHoaDonDaXacThuc(), QLBLLChisoDien.Instance.TextThongBao());
                    }
                }
        }
    }
}

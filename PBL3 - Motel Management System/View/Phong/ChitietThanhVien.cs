using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietThanhVien : Form
    {
        private string idPhong;
        public ChitietThanhVien(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
        }
        public void LoadForm(string txt)
        {
                QLBLLChung.Instance.customDGV(dgvThanhVien);
                dgvThanhVien.Rows.Clear();
                dgvThanhVien.Columns[8].ValueType = typeof(Image);
                dgvThanhVien.RowCount = 0;
                int i = 1;
                foreach (string idNguoi in QLBLLNguoi.Instance.GetIdNguoiByIdPhong(this.idPhong))
                {
                    Nguoi nguoi = new Nguoi();
                    nguoi = QLBLLNguoi.Instance.GetNguoiByIdNguoi(idNguoi);
                    Image image = null;
                    if (nguoi.HinhAnh != null)
                    {
                        image = QLBLLChung.Instance.Base64ToImage(nguoi.HinhAnh);
                    }
                    dgvThanhVien.Rows.Add(nguoi.MaNguoi, i++, nguoi.Ten, nguoi.Cccd, nguoi.Sdt, nguoi.Diachi, nguoi.NgaySinh, (nguoi.GioiTinh) ? "Nam" : "Nữ", image);
                }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvThanhVien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLLChung.Instance.dgvIcons_CellPainting1(dgvThanhVien, e, Sua, Xoa));
        }
        private void dgvThanhVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // Lấy tên cột của ô đã được nhấp
                string columnName = dgvThanhVien.Columns[e.ColumnIndex].Name;

                // Kiểm tra xem ô đã được nhấp có phải là nút Sửa hay Xóa không
                if (columnName == "btnSua")
                {
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaNguoi = dgvThanhVien.CurrentRow.Cells[0].Value.ToString();
                    QLBLLChung.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panelThem);
                }
                else if(columnName == "btnXoa")
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvThanhVien.Rows[e.RowIndex].Cells["MaNguoi"].Value.ToString();
                        int sl = dgvThanhVien.RowCount;
                        if (sl > 1)
                        {
                            if(!QLBLLHopDong.Instance.KiemTraTonTaiHopDongByIdNguoi(id))
                            {
                                string idThanhVien =QLBLLThanhVienTrongPhong.Instance.GetIdThanhVienByIdNguoi(id); 
                                QLBLLThanhVienTrongPhong.Instance.DelThanhVienBLL(idThanhVien);
                                QLBLLNguoi.Instance.DelNguoiBll(id);
                                MessageBox.Show("Xóa thành viên thành công", "Thông báo");
                                LoadForm(null);
                            }
                            else
                            {
                                MessageBox.Show("Người này đang đứng tên hợp đồng!! Không thể xóa");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Đây là thành viên duy nhất của phòng, không thể xóa");
                        }
                    }
                }
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {

            if (QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) && !QLBLLChung.Instance.PhongDaHetHan(idPhong))
            {

                if (QLBLLNguoi.Instance.GetIdNguoiByIdPhong(idPhong).Count() < QLBLLPhongTro.Instance.GetPhongTroByIdPhong(idPhong).ToiDa)
                {
                    string IdThanhVien = dgvThanhVien.Rows[0].Cells[0].Value.ToString();
                    string IdPhong = QLBLLPhongTro.Instance.GetIdPhongByIdNguoi(IdThanhVien);
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaPhongTro = idPhong;
                    QLBLLChung.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panelThem);
                }
                else
                {
                    MessageBox.Show("Số lượng người đã tối đa");
                }
            }
            else if (!QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) && !QLBLLChung.Instance.PhongDaHetHan(idPhong))
            {
                MessageBox.Show("Phòng chưa được cho thuê, không được thêm khách hàng", "Thông báo", MessageBoxButtons.OK); 
            }
            else if (QLBLLPhongTro.Instance.TinhTrangPhongById(idPhong) && QLBLLChung.Instance.PhongDaHetHan(idPhong))
            {
                MessageBox.Show("Phòng đã quá hạn hợp đồng, không được thêm khách hàng", "Thông báo", MessageBoxButtons.OK);
            }
        }

        //private void dgvThanhVien_DoubleClick(object sender, EventArgs e)
        //{
        //    if (dgvThanhVien.CurrentRow.Cells[0].Value != null)
        //    {
        //        ThuePhong tp = new ThuePhong();
        //        string id = dgvThanhVien.CurrentRow.Cells[0].Value.ToString();
        //        tp.hopDong.MaNguoi = id;
        //        ThemKhach tk = new ThemKhach(tp, LoadForm);
        //        QLBLLChung.Instance.openChildForm1(tk, panelThem);
        //        tk.btnLuu.Visible= false;
        //        tk.btnThemAnh.Visible= false;
        //        tk.txtCccd.Enabled = false;
        //        tk.txtDiaChi.Enabled = false;
        //        tk.dtpNgaySinh.Enabled = false;
        //        tk.txtSdt.Enabled = false;
        //        tk.txtTen.Enabled = false;
        //        tk.rdbtnNam.Enabled = false;
        //        tk.rdbtnNu.Enabled = false;
        //    }
        //}

     

        private void dgvThanhVien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvThanhVien.Columns[e.ColumnIndex].Name == "btnSua")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvThanhVien.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvThanhVien.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Chỉnh sửa";
                    }
                }
            }
            else if (dgvThanhVien.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvThanhVien.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvThanhVien.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Xóa";
                    }
                }
            }

        }
    }
}

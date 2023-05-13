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
                dgvThanhVien.Rows.Clear();
                dgvThanhVien.Columns[8].ValueType = typeof(Image);
                dgvThanhVien.RowCount = 0;
                int i = 1;
                //dgvThanhVien.Columns[6].ValueType = typeof(Boolean);
                foreach (string idNguoi in QLBLL.Instance.GetIdNguoiByIdPhong(this.idPhong))
                {
                    Nguoi nguoi = new Nguoi();
                    nguoi = QLBLL.Instance.GetNguoiByIdNguoi(idNguoi);
                    Image image = null;
                    if (nguoi.HinhAnh != null)
                    {
                        image = ChuyenDoiAnh.Base64ToImage(nguoi.HinhAnh);
                    }
                    dgvThanhVien.Rows.Add(nguoi.MaNguoi, i++, nguoi.Ten, nguoi.Cccd, nguoi.Sdt, nguoi.Diachi, nguoi.NgaySinh, (nguoi.GioiTinh) ? "Nam" : "Nữ", image);
                }
            var Sua = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-create-25.png");
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvThanhVien.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => dgvIcons_CellPainting1(dgvThanhVien, e, Sua, Xoa));
            QLBLL.Instance.SetFontAndColors(dgvThanhVien);
        }
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btSua, Image btXoa)
        {
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnSua" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnSua = btSua;
                var w = btnSua.Width;
                var h = btnSua.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnSua, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
            if (e.ColumnIndex >= 0 && dgv.Columns[e.ColumnIndex].Name == "btnXoa" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnXoa = btXoa;
                var w = btnXoa.Width;
                var h = btnXoa.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnXoa, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
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
                    QLBLL.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panelThem);


                }
                else if (columnName == "btnXoa")
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvThanhVien.Rows[e.RowIndex].Cells["MaNguoi"].Value.ToString();
                        if (id != "000" && id != "001")
                        {
                            string idThanhVien =QLBLL.Instance.GetIdThanhVienByIdNguoi(id); 
                            QLBLL.Instance.DelThanhVienBLL(idThanhVien);
                            QLBLL.Instance.DelNguoiBll(id);
                            MessageBox.Show("Xóa thành viên thành công", "Thông báo");
                            LoadForm(null);
                        }
                        else
                        {
                           
                        }
                    }
                }
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {

            if (QLBLL.Instance.GetPhongTroByIdPhong(idPhong).TinhTrang == true)
            {

                if (QLBLL.Instance.GetIdNguoiByIdPhong(idPhong).Count() < QLBLL.Instance.GetPhongTroByIdPhong(idPhong).ToiDa)
                {
                    string IdThanhVien = dgvThanhVien.Rows[0].Cells[0].Value.ToString();
                    string IdPhong = QLBLL.Instance.GetIdPhongByIdNguoi(IdThanhVien);
                    ThuePhong tp = new ThuePhong();
                    tp.hopDong.MaPhongTro = idPhong;
                    QLBLL.Instance.openChildForm1(new ThemKhach(tp, LoadForm), panelThem);
                }
                else
                {
                    MessageBox.Show("Số lượng người đã tối đa");
                }
            }
            else
            {
                MessageBox.Show("Phòng chưa được cho thuê, không được thêm khách hàng", "Thông báo", MessageBoxButtons.OK); ;
            }
        }

        private void dgvThanhVien_DoubleClick(object sender, EventArgs e)
        {
            if (dgvThanhVien.CurrentRow.Cells[0].Value != null)
            {
                ThuePhong tp = new ThuePhong();
                string id = dgvThanhVien.CurrentRow.Cells[0].Value.ToString();
                tp.hopDong.MaNguoi = id;
                ThemKhach tk = new ThemKhach(tp, LoadForm);
                QLBLL.Instance.openChildForm1(tk, panelThem);
                tk.btnLuu.Visible= false;
                tk.btnThemAnh.Visible= false;
                tk.txtCccd.Enabled = false;
                tk.txtDiaChi.Enabled = false;
                tk.dtpNgaySinh.Enabled = false;
                tk.txtSdt.Enabled = false;
                tk.txtTen.Enabled = false;
                tk.rdbtnNam.Enabled = false;
                tk.rdbtnNu.Enabled = false;
            }
        }

     

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
            if (dgvThanhVien.Columns[e.ColumnIndex].Name == "btnXoa")
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

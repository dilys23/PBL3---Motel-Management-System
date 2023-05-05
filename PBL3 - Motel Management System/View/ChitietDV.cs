using PBL3___Motel_Management_System.BLL;
using PBL3___Motel_Management_System.DAL;
using PBL3___Motel_Management_System.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3___Motel_Management_System.View
{
    public partial class ChitietDV : Form
    {
        private string idPhong;
        public ChitietDV(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            LoadForm(null);
            SetFontAndColors();
        }
        private void SetFontAndColors()
        {
            this.dgvDichVu.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvDichVu.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvDichVu.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvDichVu.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvDichVu.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;

            DataGridViewRow row = this.dgvDichVu.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
        public void LoadForm(string txt)
        {
           // dgvDichVu.Rows.
            dgvDichVu.Rows.Clear();
            QLBLL qLBLL = new QLBLL();
            //dgvDichVu.RowCount = 1;
             int  i = 1;
            foreach (string idDv in qLBLL.GetAllIdDichVuByIdPhong(this.idPhong))
            {
                DichVu dv = new DichVu();
                dv = qLBLL.GetDVByIdDV(idDv);
                dgvDichVu.Rows.Add(dv.MaDichVu, i++, dv.TenDichVu, dv.GiaDichVu);
            }
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBL3\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvDichVu.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => dgvIcons_CellPainting1(dgvDichVu, e, Xoa));
            
        }
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e,  Image btXoa)
        {
          
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
        TrangChu tc= new TrangChu();
        private void dgvDichVu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
               
                string columnName = dgvDichVu.Columns[e.ColumnIndex].Name;

               if (columnName == "btnXoa")
                {
                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvDichVu.Rows[e.RowIndex].Cells["MaDichVu"].Value.ToString();
                        if (id != "000" && id != "001")
                        {
                            QLBLL qLBLL = new QLBLL();
                            qLBLL.DelChiTietDichVuByIdDichVu(id);
                            MessageBox.Show("Xóa dịch vụ thành công", "Thông báo");
                            LoadForm(null);
                        }
                        else
                        {
                            MessageBox.Show("Đây là dịch vụ cố định!! Không thể xóa");
                        }
                    }
                }
            }
        }

        private void btnThemDichVu_Click(object sender, EventArgs e)
        {
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;
            tc.openChildForm1(new ThemDVphong(tp, LoadForm), panelThem);
        }

        private void dgvDichVu_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvDichVu.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvDichVu.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Xóa";
                    }
                }
            }
        }
    }
}

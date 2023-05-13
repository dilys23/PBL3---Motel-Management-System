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
    public partial class ChitietTB : Form
    {
        private string idPhong;
        public ChitietTB(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            SetFontAndColors();
            LoadForm(null);
        }
        private void SetFontAndColors()
        {
            this.dgvThietBi.DefaultCellStyle.Font = new Font("Tahoma", 10);
            this.dgvThietBi.DefaultCellStyle.ForeColor = Color.Blue;
            this.dgvThietBi.DefaultCellStyle.BackColor = Color.Beige;
            this.dgvThietBi.DefaultCellStyle.SelectionForeColor = Color.AliceBlue;
            this.dgvThietBi.DefaultCellStyle.SelectionBackColor = Color.LightSkyBlue;
            DataGridViewRow row = this.dgvThietBi.RowTemplate;
            row.Height = 35;
            row.MinimumHeight = 20;
        }
        public void LoadForm(string txt)
        {
            dgvThietBi.Rows.Clear();
            dgvThietBi.RowCount = 0;
            int i = 1;
            ThuePhong tp = new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;

            foreach (string idCttb in QLBLL.Instance.GetAllIdCHiTietThietBiByIdPhong(tp.hopDong.MaPhongTro))
            {
                ChiTietThietBi cttb = QLBLL.Instance.GetChiTietThietBiById(idCttb);
                ThietBi tb = QLBLL.Instance.GetTBByIdTB(cttb.MaThietBi);
                dgvThietBi.Rows.Add(tb.MaThietBi, ++i, tb.TenThietBi, tb.GiaThietBi, cttb.SoLuong);
            }
            var Xoa = System.Drawing.Image.FromFile(@"D:\PBLproject\PBL3_Main\PBL3 - Motel Management System\Icons\icons8-delete-25.png");
            dgvThietBi.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => dgvIcons_CellPainting1(dgvThietBi, e, Xoa));
        }
        public void dgvIcons_CellPainting1(DataGridView dgv, DataGridViewCellPaintingEventArgs e, Image btXoa)
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

        private void dgvThietBi_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (dgvThietBi.Columns[e.ColumnIndex].Name == "btnXoa")
            {
                if (e.Value != null)
                {
                    // Kiểm tra nếu ô là DataGridViewButtonCell
                    if (dgvThietBi.Rows[e.RowIndex].Cells[e.ColumnIndex] is DataGridViewButtonCell)
                    {
                        // Đặt giá trị ToolTipText cho ô DataGridViewButtonCell
                        DataGridViewButtonCell buttonCell = (DataGridViewButtonCell)dgvThietBi.Rows[e.RowIndex].Cells[e.ColumnIndex];
                        buttonCell.ToolTipText = "Xóa";
                    }
                }
            }
        }

        private void dgvThietBi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {

                string columnName = dgvThietBi.Columns[e.ColumnIndex].Name;

                if (columnName == "btnXoa")
                {

                    DialogResult kq = MessageBox.Show("Bạn có thực sự muốn xóa", "Cảnh báo!!!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                    if (kq == DialogResult.OK)
                    {
                        string id = dgvThietBi.Rows[e.RowIndex].Cells["MaThietBi"].Value.ToString();
                        if (Convert.ToInt32(dgvThietBi.Rows[e.RowIndex].Cells["SoLuong"].Value.ToString()) == 1)
                        {
                            QLBLL.Instance.DelChiTietThietBiByIdThietBi(id);
                        }
                        else
                        {
                            QLBLL.Instance.DelCHiTietThietBiByIdPhongBLL(idPhong);
                            foreach (DataGridViewRow dr in dgvThietBi.Rows)
                            {
                                if (dr.Cells[0].Value != null)
                                {
                                    ChiTietThietBi cttb = new ChiTietThietBi();
                                    cttb.MaChiTietThietBi = QLBLL.Instance.TaoIdChiTietThietBi();
                                    cttb.MaThietBi = dr.Cells[0].Value.ToString();
                                    cttb.MaPhongTro = idPhong;
                                    cttb.TonTai = true;
                                    if (cttb.MaThietBi == id)
                                    { cttb.SoLuong = Convert.ToInt32(dr.Cells[4].Value.ToString()) - 1; }
                                    else cttb.SoLuong = Convert.ToInt32(dr.Cells[4].Value.ToString()) ;
                                    
                                    QLBLL.Instance.AddChiTietThietBiBll(cttb);
                                }

                            }
                        }

                     
                        MessageBox.Show("Xóa thiết bị thành công", "Thông báo");
                        LoadForm(null);

                    }
                }
            }
        }
        private void btnThemThietbi_Click(object sender, EventArgs e)
        {
            ThuePhong tp= new ThuePhong();
            tp.hopDong.MaPhongTro = idPhong;
            QLBLL.Instance.openChildForm1(new ThemThietBiPhong(tp, LoadForm), panelThem);
        }
    }
}

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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;

namespace PBL3___Motel_Management_System.View.KhachHang
{
    public partial class HoaDonPhong : Form
    {
        private string idPhong;
        public HoaDonPhong(string idPhong)
        {
            InitializeComponent();
            this.idPhong = idPhong;
            if (idPhong != null)
            {
                SetGUI(null);
            }
        }
        public void SetGUI(string txt)
        {
            dgvHoaDon.Rows.Clear();
            QLBLL.Instance.customDGV(dgvHoaDon);
            if (txt == null)
            {
                int i = 0;
                foreach (HoaDon hd in QLBLL.Instance.GetAllHoaDonBll())
                {
                    if (hd.MaPhongTro == idPhong && hd.TinhTrang == true)
                    {
                        dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, hd.NgayTao, hd.ThangChiTra, hd.TongTien, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
                    }

                }
            }
            else
            {
                string ThangSuDung = dtpThangSuDung.Value.ToString("MM-yyyy");
                int i = 0;
                string IdDay = QLBLL.Instance.GetDayTroByIdPhong(idPhong).MaDayTro;
                foreach (HoaDon hd in QLBLL.Instance.GetHoaDonTimKiem(ThangSuDung, IdDay, idPhong, "1"))
                {
                    PhongTro pt = QLBLL.Instance.GetPhongTroByIdPhong(hd.MaPhongTro);
                    DayTro dt = QLBLL.Instance.GetDayTroByIdPhong(hd.MaPhongTro);
                    dgvHoaDon.Rows.Add(hd.MaHoaDon, ++i, hd.NgayTao, hd.ThangChiTra, hd.TongTien, hd.DaThanhToan, hd.TongTien - hd.DaThanhToan);
                }
            }
            // var ChiTiet = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-history-20.png");
            //dgvHoaDon.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler((sender, e) => QLBLL.Instance.dgvIcons_CellPainting2(dgvHoaDon, e, null, null, ChiTiet));
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            SetGUI("");
        }

        private void dgvHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                string columnName = dgvHoaDon.Columns[e.ColumnIndex].Name;
                if (columnName == "btnChiTiet")
                {
                    string id = dgvHoaDon.CurrentRow.Cells[0].Value.ToString();
                    QLBLL.Instance.openChildForm1(new LichSuThanhToan(SetGUI, id), panelHD);
                }    
            }    
        }

        private void dgvHoaDon_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.ColumnIndex >= 0 && dgvHoaDon.Columns[e.ColumnIndex].Name == "btnChiTiet" && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var btnChiTiet = System.Drawing.Image.FromFile(@"D:\PBL\PBL3_MAIN\PBL3 - Motel Management System\Icons\icons8-history-20.png");
                var w = btnChiTiet.Width;
                var h = btnChiTiet.Height;
                var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
                var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;
                e.Graphics.DrawImage(btnChiTiet, new Rectangle(x, y, w, h));
                e.Handled = true;

                // Thay đổi màu nền của cell khi được chọn
                if (e.State == DataGridViewElementStates.Selected)
                {
                    e.CellStyle.SelectionBackColor = Color.Tomato;
                }
            }
        }
    }
}
